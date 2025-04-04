namespace StudentManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            richTextBoxDisplay = new RichTextBox();
            btnPrevious = new Button();
            btnNext = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            btnIndexSearch = new Button();
            txtSearchIndex = new TextBox();
            btnNameSearch = new Button();
            txtNameSearch = new TextBox();
            lvStudents = new ListView();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(480, 320);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // richTextBoxDisplay
            // 
            richTextBoxDisplay.Location = new Point(12, 12);
            richTextBoxDisplay.Name = "richTextBoxDisplay";
            richTextBoxDisplay.Size = new Size(381, 248);
            richTextBoxDisplay.TabIndex = 1;
            richTextBoxDisplay.Text = "";
            richTextBoxDisplay.TextChanged += richTextBoxDisplay_TextChanged;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(399, 349);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 23);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(480, 349);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(399, 319);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(561, 320);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnIndexSearch
            // 
            btnIndexSearch.Location = new Point(399, 12);
            btnIndexSearch.Name = "btnIndexSearch";
            btnIndexSearch.Size = new Size(109, 23);
            btnIndexSearch.TabIndex = 6;
            btnIndexSearch.Text = "Search by Index";
            btnIndexSearch.UseVisualStyleBackColor = true;
            btnIndexSearch.Click += btnIndexSearch_Click;
            // 
            // txtSearchIndex
            // 
            txtSearchIndex.ForeColor = SystemColors.WindowText;
            txtSearchIndex.Location = new Point(514, 12);
            txtSearchIndex.Name = "txtSearchIndex";
            txtSearchIndex.Size = new Size(122, 23);
            txtSearchIndex.TabIndex = 7;
            txtSearchIndex.TextChanged += txtSearchIndex_TextChanged;
            // 
            // btnNameSearch
            // 
            btnNameSearch.Location = new Point(399, 41);
            btnNameSearch.Name = "btnNameSearch";
            btnNameSearch.Size = new Size(109, 23);
            btnNameSearch.TabIndex = 8;
            btnNameSearch.Text = "Search by Name";
            btnNameSearch.UseVisualStyleBackColor = true;
            btnNameSearch.Click += btnNameSearch_Click;
            // 
            // txtNameSearch
            // 
            txtNameSearch.ForeColor = SystemColors.WindowText;
            txtNameSearch.Location = new Point(514, 42);
            txtNameSearch.Name = "txtNameSearch";
            txtNameSearch.Size = new Size(122, 23);
            txtNameSearch.TabIndex = 9;
            // 
            // lvStudents
            // 
            lvStudents.AllowColumnReorder = true;
            lvStudents.FullRowSelect = true;
            lvStudents.GridLines = true;
            lvStudents.Location = new Point(12, 266);
            lvStudents.Name = "lvStudents";
            lvStudents.Size = new Size(381, 172);
            lvStudents.TabIndex = 10;
            lvStudents.UseCompatibleStateImageBehavior = false;
            lvStudents.View = View.Details;
            lvStudents.SelectedIndexChanged += lvStudents_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvStudents);
            Controls.Add(txtNameSearch);
            Controls.Add(btnNameSearch);
            Controls.Add(txtSearchIndex);
            Controls.Add(btnIndexSearch);
            Controls.Add(btnEdit);
            Controls.Add(btnRemove);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(richTextBoxDisplay);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private RichTextBox richTextBoxDisplay;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnIndexSearch;
        private TextBox txtSearchIndex;
        private Button btnNameSearch;
        private TextBox txtNameSearch;
        private ListView lvStudents;
    }
}
