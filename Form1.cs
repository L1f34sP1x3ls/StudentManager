using Microsoft.VisualBasic.Devices;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Reflection.Emit;

namespace StudentManager
{
    public partial class Form1 : Form
    {
        private StudentManagerSystem studentManager = new StudentManagerSystem();
        private int CurrentIndex = -1;
        public Form1()
        {
            InitializeComponent();
            SetupStudentListView();
            LoadStudentsFromJson();
        }
        public void SaveStudentsToJson()
        {
            var students = studentManager.GetAllStudents();
            string json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(studentManager.jsonFilePath, json);
        }
        private void LoadStudentsFromJson()
        {
            if (File.Exists(studentManager.jsonFilePath))
            {
                string json = File.ReadAllText(studentManager.jsonFilePath);
                var students = JsonSerializer.Deserialize<List<Student>>(json);

                if (students != null)
                {
                    studentManager.SetStudents(students);
                    CurrentIndex = 0;
                    RefreshStudentListView();
                    DisplayCurrentStudent();
                }
            }
        }
        private void DisplayCurrentStudent()
        {

            var students = studentManager.GetAllStudents();

            if (students.Count == 0 || CurrentIndex < 0 || CurrentIndex >= students.Count)
            {
                richTextBoxDisplay.Text = $"No student to display.";
            }
            else
            {
                richTextBoxDisplay.Text = students[CurrentIndex].ToString();
            }
            //// Handle button states
            btnPrevious.Enabled = CurrentIndex > 0;
            btnNext.Enabled = CurrentIndex < students.Count - 1;

            RefreshStudentListView();
            SaveStudentsToJson();
        }
        private string Prompt(string message, string defaultValue)
        {
            using (Form prompt = new Form())
            {
                prompt.Width = 300;
                prompt.Height = 150;
                prompt.Text = message;

                System.Windows.Forms.Label textLabel = new System.Windows.Forms.Label() { Left = 10, Top = 10, Text = message, AutoSize = true };
                TextBox textBox = new TextBox() { Left = 10, Top = 30, Width = 250, Text = defaultValue };
                Button confirmation = new Button() { Text = "OK", Left = 190, Width = 70, Top = 60, DialogResult = DialogResult.OK };

                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : null;
            }
        }
        private void SetupStudentListView()
        {
            lvStudents.Columns.Clear();
            lvStudents.Columns.Add("Index", 50);
            lvStudents.Columns.Add("First Name", 80);
            lvStudents.Columns.Add("Last Name", 80);
            lvStudents.Columns.Add("Age", 50);
            lvStudents.Columns.Add("Cohort", 70);
        }
        private void RefreshStudentListView()
        {
            lvStudents.Items.Clear();
            var students = studentManager.GetAllStudents();

            for (int i = 0; i < students.Count; i++)
            {
                var student = students[i];
                var item = new ListViewItem(i.ToString());
                item.SubItems.Add(student.FirstName);
                item.SubItems.Add(student.LastName);
                item.SubItems.Add(student.Age.ToString());
                item.SubItems.Add(student.Cohort.ToString());
                lvStudents.Items.Add(item);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var CurrentStudent = studentManager.AddStudent();
            richTextBoxDisplay.Text = CurrentStudent.ToString();
            CurrentIndex = CurrentStudent.Id;
            DisplayCurrentStudent();
        }
        private void richTextBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            var students = studentManager.GetAllStudents();
            if (students.Count == 0) return;

            if (CurrentIndex < students.Count - 1)
            {
                CurrentIndex++;
                DisplayCurrentStudent();
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentIndex > 0)
            {
                CurrentIndex--;
                DisplayCurrentStudent();
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            var students = studentManager.GetAllStudents();

            if (students.Count == 0 || CurrentIndex < 0 || CurrentIndex >= students.Count)
            {
                MessageBox.Show("No student selected to remove.");
                return;
            }

            // Remove current student
            studentManager.RemoveStudentAt(CurrentIndex);

            // Adjust index
            if (CurrentIndex >= students.Count - 1)
            {
                CurrentIndex = students.Count - 1;
            }

            // Refresh display
            DisplayCurrentStudent();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var students = studentManager.GetAllStudents();

            if (students.Count == 0 || CurrentIndex < 0 || CurrentIndex >= students.Count)
            {
                MessageBox.Show("No student selected to edit.");
                return;
            }

            var student = students[CurrentIndex];

            // Prompt user for updated info
            string FirstName = Prompt("Edit First Name:", student.FirstName);
            if (FirstName == null) return;

            string LastName = Prompt("Edit Last Name:", student.LastName);
            if (LastName == null) return;

            string CohortInput = Prompt("Edit Cohort:", student.Cohort.ToString());
            if (CohortInput == null || !int.TryParse(CohortInput, out int Cohort)) return;

            string AgeInput = Prompt("Edit Age:", student.Age.ToString());
            if (AgeInput == null || !int.TryParse(AgeInput, out int Age)) return;


            //foreach (var grade in student.Grades)
            //{
            //    string GradeInput = Prompt($"Edit {grade.Key} Grade:", grade.Value.ToString());
            //    if (GradeInput == null || !int.TryParse(GradeInput, out int Grade)) return;
            //}
            // Update student info
            student.FirstName = FirstName;
            student.LastName = LastName;
            student.Cohort = Cohort;
            student.Age = Age;
            //student.Grades = ;

            // Refresh display
            DisplayCurrentStudent();
        }
        private void btnIndexSearch_Click(object sender, EventArgs e)
        {
            var students = studentManager.GetAllStudents();

            if (!int.TryParse(txtSearchIndex.Text, out int index))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            if (index < 0 || index > students.Count)
            {
                MessageBox.Show("Index out of range.");
                return;
            }

            CurrentIndex = index - 1;
            DisplayCurrentStudent();
        }
        private void txtSearchIndex_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtNameSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }

            var students = studentManager.GetAllStudents();

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].FirstName.ToLower() == searchName)
                {
                    CurrentIndex = i;
                    DisplayCurrentStudent();
                    return;
                }
            }

            MessageBox.Show("Student not found.");
        }
        private void lvStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStudents.SelectedItems.Count > 0)
            {
                int index = int.Parse(lvStudents.SelectedItems[0].Text);
                CurrentIndex = index;
                DisplayCurrentStudent();
            }
        }
        private void btnSaveToJson_Click(object sender, EventArgs e)
        {
            SaveStudentsToJson();
            MessageBox.Show("Students saved to executable root folder.");
        }
        private void btnLoadFromJson_Click(object sender, EventArgs e)
        {
            LoadStudentsFromJson();
        }
        private void ExportStudents()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json";
            saveFileDialog.Title = "Export Students";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                var students = studentManager.GetAllStudents();

                string json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);

                MessageBox.Show("Students exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ImportStudents()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            openFileDialog.Title = "Import Students";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string json = File.ReadAllText(filePath);

                var importedStudents = JsonSerializer.Deserialize<List<Student>>(json);

                if (importedStudents != null)
                {
                    studentManager.SetStudents(importedStudents);
                    CurrentIndex = 0;
                    RefreshStudentListView();
                    DisplayCurrentStudent();

                    MessageBox.Show("Students imported successfully!", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to import students.", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnExportStudents_Click_1(object sender, EventArgs e)
        {
            ExportStudents();
        }

        private void btnImportStudents_Click_1(object sender, EventArgs e)
        {
            ImportStudents();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportStudents();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportStudents();
        }
    }
    public enum Course
    {
        English,
        Math,
        SocialStudies,
        History,
        Science,
        PE
    }
    public class Student
    {
        public static int _id = 0; // static variable to keep track of the last assigned ID
        public int Id { get; set; } // serialized id #
        public string FirstName { get; set; } // two sets of random characters between 3-8 lenght each
        public string LastName { get; set; } // two sets of random characters between 3-8 lenght each
        public int Cohort { get; set; } // set random number 1-12
        public int Age { get; set; } // set random number range (18-12 +/-1), 18 +/- 1
        public Dictionary<Course, int> Grades { get; set; } // English, Math, Social Studies, History, Science, PE each assigned a grade between 0-100
        public Student() { }

        public override string ToString()
        {
            string _grades = "";
            foreach (var grade in this.Grades)
            {
                _grades += $"\n{grade.Key}: {grade.Value}";
            }
            return $"ID: {this.Id}\nFirst Name: {this.FirstName}\nLast Name: {this.LastName}\nCohort: {this.Cohort}\nAge: {this.Age}{_grades}\n";
        }
    }
    public class StudentManagerSystem
    {
        private List<Student> students = new List<Student>();
        private int CurrentIndex = 0;
        public readonly string jsonFilePath = "students.json";

        public Student AddStudent()
        {
            int _cohort = new Random().Next(1, 13);
            var student = new Student
            {
                Id = Student._id++,// random id #
                FirstName = GenerateRandomName(5, 5),
                LastName = GenerateRandomName(5, 5), // random name between 3 and 8 characters
                Cohort = _cohort, // random cohort between 1 and 12
                Age = _cohort + 6 + new Random().Next(-1, 2), // random age between +1/-1 of cohort + 6
                Grades = GenerateRandomGrades()
            };
            students.Add(student);
            return student;
        }
        public void RemoveStudentAt(int index)
        {
            if (index >= 0 && index < students.Count)
            {
                students.RemoveAt(index);
            }
        }
        public string GenerateRandomName(int min, int max)
        {
            Random random = new Random();
            int length = new Random().Next(min, max + 1);
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }

            return result.ToString();
        }
        public Dictionary<Course, int> GenerateRandomGrades()
        {
            Random random = new Random();
            Dictionary<Course, int> grades = new Dictionary<Course, int>();
            foreach (Course course in Enum.GetValues(typeof(Course)))
            {
                grades[course] = random.Next(60, 101); // random grade between 0 and 100
            }
            return grades;
        }
        public List<Student> GetAllStudents()
        {
            return students;
        }
        
        public void SetStudents(List<Student> newStudents)
        {
            students = newStudents;
        }


    }
}
