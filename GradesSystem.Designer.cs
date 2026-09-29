namespace Student_Management_System
{
    partial class GradesSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewcrsBtn = new System.Windows.Forms.Button();
            this.courseList = new System.Windows.Forms.CheckedListBox();
            this.viewenrolBtn = new System.Windows.Forms.Button();
            this.gradeData3 = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.enrollidLbl = new System.Windows.Forms.Label();
            this.enrollidTxt = new System.Windows.Forms.TextBox();
            this.courseLbl = new System.Windows.Forms.Label();
            this.gradesPanel = new System.Windows.Forms.Panel();
            this.gradesLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradesBox = new System.Windows.Forms.GroupBox();
            this.resitRadio = new System.Windows.Forms.RadioButton();
            this.distinctRadio = new System.Windows.Forms.RadioButton();
            this.passRadio = new System.Windows.Forms.RadioButton();
            this.upperRadio = new System.Windows.Forms.RadioButton();
            this.lowerRadio = new System.Windows.Forms.RadioButton();
            this.viewgradeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gradeData3)).BeginInit();
            this.gradesPanel.SuspendLayout();
            this.gradesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewcrsBtn
            // 
            this.viewcrsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewcrsBtn.Location = new System.Drawing.Point(575, 307);
            this.viewcrsBtn.Name = "viewcrsBtn";
            this.viewcrsBtn.Size = new System.Drawing.Size(156, 23);
            this.viewcrsBtn.TabIndex = 90;
            this.viewcrsBtn.Text = "View All The Courses";
            this.viewcrsBtn.UseVisualStyleBackColor = true;
            this.viewcrsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // courseList
            // 
            this.courseList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseList.FormattingEnabled = true;
            this.courseList.Location = new System.Drawing.Point(121, 144);
            this.courseList.Name = "courseList";
            this.courseList.Size = new System.Drawing.Size(197, 84);
            this.courseList.TabIndex = 89;
            // 
            // viewenrolBtn
            // 
            this.viewenrolBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewenrolBtn.Location = new System.Drawing.Point(575, 336);
            this.viewenrolBtn.Name = "viewenrolBtn";
            this.viewenrolBtn.Size = new System.Drawing.Size(156, 23);
            this.viewenrolBtn.TabIndex = 87;
            this.viewenrolBtn.Text = "View All Enrollments";
            this.viewenrolBtn.UseVisualStyleBackColor = true;
            this.viewenrolBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // gradeData3
            // 
            this.gradeData3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gradeData3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeData3.Location = new System.Drawing.Point(363, 111);
            this.gradeData3.Name = "gradeData3";
            this.gradeData3.ReadOnly = true;
            this.gradeData3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gradeData3.Size = new System.Drawing.Size(409, 159);
            this.gradeData3.TabIndex = 86;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(656, 278);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 85;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(575, 278);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 84;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(278, 412);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 83;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(180, 412);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 82;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(84, 412);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 81;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // enrollidLbl
            // 
            this.enrollidLbl.AutoSize = true;
            this.enrollidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollidLbl.Location = new System.Drawing.Point(38, 120);
            this.enrollidLbl.Name = "enrollidLbl";
            this.enrollidLbl.Size = new System.Drawing.Size(57, 15);
            this.enrollidLbl.TabIndex = 80;
            this.enrollidLbl.Text = "Enroll  ID";
            // 
            // enrollidTxt
            // 
            this.enrollidTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollidTxt.Location = new System.Drawing.Point(121, 116);
            this.enrollidTxt.Name = "enrollidTxt";
            this.enrollidTxt.Size = new System.Drawing.Size(197, 21);
            this.enrollidTxt.TabIndex = 77;
            // 
            // courseLbl
            // 
            this.courseLbl.AutoSize = true;
            this.courseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLbl.Location = new System.Drawing.Point(38, 146);
            this.courseLbl.Name = "courseLbl";
            this.courseLbl.Size = new System.Drawing.Size(61, 15);
            this.courseLbl.TabIndex = 75;
            this.courseLbl.Text = "Course ID";
            // 
            // gradesPanel
            // 
            this.gradesPanel.BackColor = System.Drawing.Color.Gold;
            this.gradesPanel.Controls.Add(this.gradesLbl);
            this.gradesPanel.Location = new System.Drawing.Point(0, -1);
            this.gradesPanel.Name = "gradesPanel";
            this.gradesPanel.Size = new System.Drawing.Size(802, 87);
            this.gradesPanel.TabIndex = 74;
            // 
            // gradesLbl
            // 
            this.gradesLbl.AutoSize = true;
            this.gradesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradesLbl.Location = new System.Drawing.Point(253, 20);
            this.gradesLbl.Name = "gradesLbl";
            this.gradesLbl.Size = new System.Drawing.Size(288, 42);
            this.gradesLbl.TabIndex = 8;
            this.gradesLbl.Text = "Grades System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 72;
            // 
            // gradesBox
            // 
            this.gradesBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gradesBox.Controls.Add(this.resitRadio);
            this.gradesBox.Controls.Add(this.distinctRadio);
            this.gradesBox.Controls.Add(this.passRadio);
            this.gradesBox.Controls.Add(this.upperRadio);
            this.gradesBox.Controls.Add(this.lowerRadio);
            this.gradesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradesBox.Location = new System.Drawing.Point(121, 251);
            this.gradesBox.Name = "gradesBox";
            this.gradesBox.Size = new System.Drawing.Size(200, 135);
            this.gradesBox.TabIndex = 91;
            this.gradesBox.TabStop = false;
            this.gradesBox.Text = "Grades";
            // 
            // resitRadio
            // 
            this.resitRadio.AutoSize = true;
            this.resitRadio.Location = new System.Drawing.Point(6, 108);
            this.resitRadio.Name = "resitRadio";
            this.resitRadio.Size = new System.Drawing.Size(53, 19);
            this.resitRadio.TabIndex = 96;
            this.resitRadio.TabStop = true;
            this.resitRadio.Text = "Resit";
            this.resitRadio.UseVisualStyleBackColor = true;
            // 
            // distinctRadio
            // 
            this.distinctRadio.AutoSize = true;
            this.distinctRadio.Location = new System.Drawing.Point(6, 16);
            this.distinctRadio.Name = "distinctRadio";
            this.distinctRadio.Size = new System.Drawing.Size(82, 19);
            this.distinctRadio.TabIndex = 92;
            this.distinctRadio.TabStop = true;
            this.distinctRadio.Text = "Distinction";
            this.distinctRadio.UseVisualStyleBackColor = true;
            // 
            // passRadio
            // 
            this.passRadio.AutoSize = true;
            this.passRadio.Location = new System.Drawing.Point(6, 85);
            this.passRadio.Name = "passRadio";
            this.passRadio.Size = new System.Drawing.Size(55, 19);
            this.passRadio.TabIndex = 95;
            this.passRadio.TabStop = true;
            this.passRadio.Text = "Pass ";
            this.passRadio.UseVisualStyleBackColor = true;
            // 
            // upperRadio
            // 
            this.upperRadio.AutoSize = true;
            this.upperRadio.Location = new System.Drawing.Point(6, 39);
            this.upperRadio.Name = "upperRadio";
            this.upperRadio.Size = new System.Drawing.Size(104, 19);
            this.upperRadio.TabIndex = 93;
            this.upperRadio.TabStop = true;
            this.upperRadio.Text = "Second Upper";
            this.upperRadio.UseVisualStyleBackColor = true;
            // 
            // lowerRadio
            // 
            this.lowerRadio.AutoSize = true;
            this.lowerRadio.Location = new System.Drawing.Point(6, 62);
            this.lowerRadio.Name = "lowerRadio";
            this.lowerRadio.Size = new System.Drawing.Size(104, 19);
            this.lowerRadio.TabIndex = 94;
            this.lowerRadio.TabStop = true;
            this.lowerRadio.Text = "Second Lower";
            this.lowerRadio.UseVisualStyleBackColor = true;
            // 
            // viewgradeBtn
            // 
            this.viewgradeBtn.Location = new System.Drawing.Point(575, 365);
            this.viewgradeBtn.Name = "viewgradeBtn";
            this.viewgradeBtn.Size = new System.Drawing.Size(156, 23);
            this.viewgradeBtn.TabIndex = 92;
            this.viewgradeBtn.Text = "View All Grades";
            this.viewgradeBtn.UseVisualStyleBackColor = true;
            this.viewgradeBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GradesSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.viewgradeBtn);
            this.Controls.Add(this.gradesBox);
            this.Controls.Add(this.viewcrsBtn);
            this.Controls.Add(this.courseList);
            this.Controls.Add(this.viewenrolBtn);
            this.Controls.Add(this.gradeData3);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.enrollidLbl);
            this.Controls.Add(this.enrollidTxt);
            this.Controls.Add(this.courseLbl);
            this.Controls.Add(this.gradesPanel);
            this.Controls.Add(this.label1);
            this.Name = "GradesSystem";
            this.Text = "GradesSystem";
            this.Load += new System.EventHandler(this.GradesSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradeData3)).EndInit();
            this.gradesPanel.ResumeLayout(false);
            this.gradesPanel.PerformLayout();
            this.gradesBox.ResumeLayout(false);
            this.gradesBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewcrsBtn;
        private System.Windows.Forms.CheckedListBox courseList;
        private System.Windows.Forms.Button viewenrolBtn;
        private System.Windows.Forms.DataGridView gradeData3;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label enrollidLbl;
        private System.Windows.Forms.TextBox enrollidTxt;
        private System.Windows.Forms.Label courseLbl;
        private System.Windows.Forms.Panel gradesPanel;
        private System.Windows.Forms.Label gradesLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gradesBox;
        private System.Windows.Forms.RadioButton resitRadio;
        private System.Windows.Forms.RadioButton distinctRadio;
        private System.Windows.Forms.RadioButton passRadio;
        private System.Windows.Forms.RadioButton upperRadio;
        private System.Windows.Forms.RadioButton lowerRadio;
        private System.Windows.Forms.Button viewgradeBtn;
    }
}