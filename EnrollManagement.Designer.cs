namespace Student_Management_System
{
    partial class EnrollManagement
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.courseData2 = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.enrollidLbl = new System.Windows.Forms.Label();
            this.enrolldtTxt = new System.Windows.Forms.TextBox();
            this.enrollidTxt = new System.Windows.Forms.TextBox();
            this.enrolldtLbl = new System.Windows.Forms.Label();
            this.courseLbl = new System.Windows.Forms.Label();
            this.enrollPanel = new System.Windows.Forms.Panel();
            this.enrollLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.courseList = new System.Windows.Forms.CheckedListBox();
            this.enrollView = new System.Windows.Forms.Button();
            this.studentidLbl = new System.Windows.Forms.Label();
            this.studentidTxt = new System.Windows.Forms.TextBox();
            this.studentView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseData2)).BeginInit();
            this.enrollPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(316, 346);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 67;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.Location = new System.Drawing.Point(597, 336);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(156, 23);
            this.viewBtn.TabIndex = 66;
            this.viewBtn.Text = "View All Courses";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // courseData2
            // 
            this.courseData2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.courseData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseData2.Location = new System.Drawing.Point(363, 138);
            this.courseData2.Name = "courseData2";
            this.courseData2.ReadOnly = true;
            this.courseData2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseData2.Size = new System.Drawing.Size(409, 159);
            this.courseData2.TabIndex = 65;
            this.courseData2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseData_CellContentClick);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(678, 307);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 64;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(597, 307);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 63;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(232, 346);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 62;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(143, 346);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 61;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(53, 346);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 60;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // enrollidLbl
            // 
            this.enrollidLbl.AutoSize = true;
            this.enrollidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollidLbl.Location = new System.Drawing.Point(29, 138);
            this.enrollidLbl.Name = "enrollidLbl";
            this.enrollidLbl.Size = new System.Drawing.Size(57, 15);
            this.enrollidLbl.TabIndex = 59;
            this.enrollidLbl.Text = "Enroll  ID";
            // 
            // enrolldtTxt
            // 
            this.enrolldtTxt.Location = new System.Drawing.Point(127, 295);
            this.enrolldtTxt.Name = "enrolldtTxt";
            this.enrolldtTxt.Size = new System.Drawing.Size(197, 20);
            this.enrolldtTxt.TabIndex = 58;
            this.enrolldtTxt.Text = "MM/DD/YYYY";
            // 
            // enrollidTxt
            // 
            this.enrollidTxt.Location = new System.Drawing.Point(127, 138);
            this.enrollidTxt.Name = "enrollidTxt";
            this.enrollidTxt.Size = new System.Drawing.Size(197, 20);
            this.enrollidTxt.TabIndex = 56;
            this.enrollidTxt.TextChanged += new System.EventHandler(this.enrollidTxt_TextChanged);
            // 
            // enrolldtLbl
            // 
            this.enrolldtLbl.AutoSize = true;
            this.enrolldtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrolldtLbl.Location = new System.Drawing.Point(23, 294);
            this.enrolldtLbl.Name = "enrolldtLbl";
            this.enrolldtLbl.Size = new System.Drawing.Size(100, 15);
            this.enrolldtLbl.TabIndex = 55;
            this.enrolldtLbl.Text = "Enrollment_Date";
            // 
            // courseLbl
            // 
            this.courseLbl.AutoSize = true;
            this.courseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLbl.Location = new System.Drawing.Point(28, 193);
            this.courseLbl.Name = "courseLbl";
            this.courseLbl.Size = new System.Drawing.Size(61, 15);
            this.courseLbl.TabIndex = 54;
            this.courseLbl.Text = "Course ID";
            // 
            // enrollPanel
            // 
            this.enrollPanel.BackColor = System.Drawing.Color.Gold;
            this.enrollPanel.Controls.Add(this.enrollLbl);
            this.enrollPanel.Location = new System.Drawing.Point(0, 0);
            this.enrollPanel.Name = "enrollPanel";
            this.enrollPanel.Size = new System.Drawing.Size(802, 87);
            this.enrollPanel.TabIndex = 53;
            // 
            // enrollLbl
            // 
            this.enrollLbl.AutoSize = true;
            this.enrollLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollLbl.Location = new System.Drawing.Point(186, 23);
            this.enrollLbl.Name = "enrollLbl";
            this.enrollLbl.Size = new System.Drawing.Size(444, 42);
            this.enrollLbl.TabIndex = 8;
            this.enrollLbl.Text = "Enrollment Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 51;
            // 
            // courseList
            // 
            this.courseList.FormattingEnabled = true;
            this.courseList.Location = new System.Drawing.Point(127, 193);
            this.courseList.Name = "courseList";
            this.courseList.Size = new System.Drawing.Size(197, 94);
            this.courseList.TabIndex = 69;
            // 
            // enrollView
            // 
            this.enrollView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollView.Location = new System.Drawing.Point(597, 365);
            this.enrollView.Name = "enrollView";
            this.enrollView.Size = new System.Drawing.Size(156, 23);
            this.enrollView.TabIndex = 71;
            this.enrollView.Text = "View All Enrollments";
            this.enrollView.UseVisualStyleBackColor = true;
            this.enrollView.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentidLbl
            // 
            this.studentidLbl.AutoSize = true;
            this.studentidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentidLbl.Location = new System.Drawing.Point(28, 167);
            this.studentidLbl.Name = "studentidLbl";
            this.studentidLbl.Size = new System.Drawing.Size(64, 15);
            this.studentidLbl.TabIndex = 52;
            this.studentidLbl.Text = "Student ID";
            // 
            // studentidTxt
            // 
            this.studentidTxt.Location = new System.Drawing.Point(127, 167);
            this.studentidTxt.Name = "studentidTxt";
            this.studentidTxt.Size = new System.Drawing.Size(197, 20);
            this.studentidTxt.TabIndex = 57;
            // 
            // studentView
            // 
            this.studentView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentView.Location = new System.Drawing.Point(597, 394);
            this.studentView.Name = "studentView";
            this.studentView.Size = new System.Drawing.Size(156, 23);
            this.studentView.TabIndex = 72;
            this.studentView.Text = "View All Students";
            this.studentView.UseVisualStyleBackColor = true;
            this.studentView.Click += new System.EventHandler(this.button2_Click);
            // 
            // EnrollManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.studentView);
            this.Controls.Add(this.enrollView);
            this.Controls.Add(this.courseList);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.courseData2);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.enrollidLbl);
            this.Controls.Add(this.enrolldtTxt);
            this.Controls.Add(this.studentidTxt);
            this.Controls.Add(this.enrollidTxt);
            this.Controls.Add(this.enrolldtLbl);
            this.Controls.Add(this.courseLbl);
            this.Controls.Add(this.enrollPanel);
            this.Controls.Add(this.studentidLbl);
            this.Controls.Add(this.label1);
            this.Name = "EnrollManagement";
            this.Text = "EnrollManagement";
            this.Load += new System.EventHandler(this.EnrollManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseData2)).EndInit();
            this.enrollPanel.ResumeLayout(false);
            this.enrollPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.DataGridView courseData2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label enrollidLbl;
        private System.Windows.Forms.TextBox enrolldtTxt;
        private System.Windows.Forms.TextBox enrollidTxt;
        private System.Windows.Forms.Label enrolldtLbl;
        private System.Windows.Forms.Label courseLbl;
        private System.Windows.Forms.Panel enrollPanel;
        private System.Windows.Forms.Label enrollLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox courseList;
        private System.Windows.Forms.Button enrollView;
        private System.Windows.Forms.Label studentidLbl;
        private System.Windows.Forms.TextBox studentidTxt;
        private System.Windows.Forms.Button studentView;
    }
}