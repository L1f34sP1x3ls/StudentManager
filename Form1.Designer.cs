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
            btnSaveToJson = new Button();
            btnLoadFromJson = new Button();
            btnExportStudents = new Button();
            btnImportStudents = new Button();
            menuStrip = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(478, 218);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // richTextBoxDisplay
            // 
            richTextBoxDisplay.Location = new Point(12, 52);
            richTextBoxDisplay.Name = "richTextBoxDisplay";
            richTextBoxDisplay.Size = new Size(381, 218);
            richTextBoxDisplay.TabIndex = 1;
            richTextBoxDisplay.Text = "";
            richTextBoxDisplay.TextChanged += richTextBoxDisplay_TextChanged;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(397, 247);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 23);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(478, 247);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(397, 217);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(559, 218);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnIndexSearch
            // 
            btnIndexSearch.Location = new Point(397, 52);
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
            txtSearchIndex.Location = new Point(512, 52);
            txtSearchIndex.Name = "txtSearchIndex";
            txtSearchIndex.Size = new Size(122, 23);
            txtSearchIndex.TabIndex = 7;
            txtSearchIndex.TextChanged += txtSearchIndex_TextChanged;
            // 
            // btnNameSearch
            // 
            btnNameSearch.Location = new Point(397, 81);
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
            txtNameSearch.Location = new Point(512, 82);
            txtNameSearch.Name = "txtNameSearch";
            txtNameSearch.Size = new Size(122, 23);
            txtNameSearch.TabIndex = 9;
            // 
            // lvStudents
            // 
            lvStudents.AllowColumnReorder = true;
            lvStudents.FullRowSelect = true;
            lvStudents.GridLines = true;
            lvStudents.Location = new Point(12, 276);
            lvStudents.Name = "lvStudents";
            lvStudents.Size = new Size(381, 172);
            lvStudents.TabIndex = 10;
            lvStudents.UseCompatibleStateImageBehavior = false;
            lvStudents.View = View.Details;
            lvStudents.SelectedIndexChanged += lvStudents_SelectedIndexChanged;
            // 
            // btnSaveToJson
            // 
            btnSaveToJson.Location = new Point(397, 165);
            btnSaveToJson.Name = "btnSaveToJson";
            btnSaveToJson.Size = new Size(75, 23);
            btnSaveToJson.TabIndex = 11;
            btnSaveToJson.Text = "Save";
            btnSaveToJson.UseVisualStyleBackColor = true;
            btnSaveToJson.Click += btnSaveToJson_Click;
            // 
            // btnLoadFromJson
            // 
            btnLoadFromJson.Location = new Point(478, 165);
            btnLoadFromJson.Name = "btnLoadFromJson";
            btnLoadFromJson.Size = new Size(75, 23);
            btnLoadFromJson.TabIndex = 12;
            btnLoadFromJson.Text = "Load";
            btnLoadFromJson.UseVisualStyleBackColor = true;
            btnLoadFromJson.Click += btnLoadFromJson_Click;
            // 
            // btnExportStudents
            // 
            btnExportStudents.Location = new Point(397, 136);
            btnExportStudents.Name = "btnExportStudents";
            btnExportStudents.Size = new Size(75, 23);
            btnExportStudents.TabIndex = 13;
            btnExportStudents.Text = "Export";
            btnExportStudents.UseVisualStyleBackColor = true;
            btnExportStudents.Click += btnExportStudents_Click_1;
            // 
            // btnImportStudents
            // 
            btnImportStudents.Location = new Point(478, 136);
            btnImportStudents.Name = "btnImportStudents";
            btnImportStudents.Size = new Size(75, 23);
            btnImportStudents.TabIndex = 14;
            btnImportStudents.Text = "Import";
            btnImportStudents.UseVisualStyleBackColor = true;
            btnImportStudents.Click += btnImportStudents_Click_1;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(643, 24);
            menuStrip.TabIndex = 15;
            menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(110, 22);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(110, 22);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(388, 15);
            label1.TabIndex = 17;
            label1.Text = "Click 'Add' to begin generating new fake students content one at a time.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 458);
            Controls.Add(label1);
            Controls.Add(btnImportStudents);
            Controls.Add(btnExportStudents);
            Controls.Add(btnLoadFromJson);
            Controls.Add(btnSaveToJson);
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
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Form1";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
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
        private Button btnSaveToJson;
        private Button btnLoadFromJson;
        private Button btnExportStudents;
        private Button btnImportStudents;
        private MenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private Label label1;
    }
}
