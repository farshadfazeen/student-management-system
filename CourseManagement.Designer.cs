namespace Student_Management_System
{
    partial class CourseManagement
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
            this.courseData = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.courseidLbl = new System.Windows.Forms.Label();
            this.feeTxt = new System.Windows.Forms.TextBox();
            this.coursenameTxt = new System.Windows.Forms.TextBox();
            this.courseidTxt = new System.Windows.Forms.TextBox();
            this.feeLbl = new System.Windows.Forms.Label();
            this.crsdurationLbl = new System.Windows.Forms.Label();
            this.coursePanel = new System.Windows.Forms.Panel();
            this.courseLbl = new System.Windows.Forms.Label();
            this.coursenameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.courseWeeks = new System.Windows.Forms.NumericUpDown();
            this.weekLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseData)).BeginInit();
            this.coursePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseWeeks)).BeginInit();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(328, 338);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 48;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.Location = new System.Drawing.Point(488, 304);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 23);
            this.viewBtn.TabIndex = 47;
            this.viewBtn.Text = "View All";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // courseData
            // 
            this.courseData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.courseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseData.Location = new System.Drawing.Point(363, 129);
            this.courseData.Name = "courseData";
            this.courseData.Size = new System.Drawing.Size(409, 159);
            this.courseData.TabIndex = 46;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(673, 304);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 45;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(581, 304);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 44;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(232, 338);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 43;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(139, 338);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 42;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Location = new System.Drawing.Point(46, 338);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 41;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // courseidLbl
            // 
            this.courseidLbl.AutoSize = true;
            this.courseidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseidLbl.Location = new System.Drawing.Point(40, 149);
            this.courseidLbl.Name = "courseidLbl";
            this.courseidLbl.Size = new System.Drawing.Size(61, 15);
            this.courseidLbl.TabIndex = 40;
            this.courseidLbl.Text = "Course ID";
            // 
            // feeTxt
            // 
            this.feeTxt.Location = new System.Drawing.Point(127, 236);
            this.feeTxt.Name = "feeTxt";
            this.feeTxt.Size = new System.Drawing.Size(197, 20);
            this.feeTxt.TabIndex = 38;
            // 
            // coursenameTxt
            // 
            this.coursenameTxt.Location = new System.Drawing.Point(127, 176);
            this.coursenameTxt.Name = "coursenameTxt";
            this.coursenameTxt.Size = new System.Drawing.Size(197, 20);
            this.coursenameTxt.TabIndex = 36;
            // 
            // courseidTxt
            // 
            this.courseidTxt.Location = new System.Drawing.Point(127, 147);
            this.courseidTxt.Name = "courseidTxt";
            this.courseidTxt.Size = new System.Drawing.Size(197, 20);
            this.courseidTxt.TabIndex = 35;
            this.courseidTxt.TextChanged += new System.EventHandler(this.courseidTxt_TextChanged);
            // 
            // feeLbl
            // 
            this.feeLbl.AutoSize = true;
            this.feeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeLbl.Location = new System.Drawing.Point(41, 237);
            this.feeLbl.Name = "feeLbl";
            this.feeLbl.Size = new System.Drawing.Size(28, 15);
            this.feeLbl.TabIndex = 33;
            this.feeLbl.Text = "Fee";
            // 
            // crsdurationLbl
            // 
            this.crsdurationLbl.AutoSize = true;
            this.crsdurationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crsdurationLbl.Location = new System.Drawing.Point(40, 206);
            this.crsdurationLbl.Name = "crsdurationLbl";
            this.crsdurationLbl.Size = new System.Drawing.Size(54, 15);
            this.crsdurationLbl.TabIndex = 32;
            this.crsdurationLbl.Text = "Duration";
            // 
            // coursePanel
            // 
            this.coursePanel.BackColor = System.Drawing.Color.Gold;
            this.coursePanel.Controls.Add(this.courseLbl);
            this.coursePanel.Location = new System.Drawing.Point(0, 0);
            this.coursePanel.Name = "coursePanel";
            this.coursePanel.Size = new System.Drawing.Size(802, 87);
            this.coursePanel.TabIndex = 31;
            // 
            // courseLbl
            // 
            this.courseLbl.AutoSize = true;
            this.courseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLbl.Location = new System.Drawing.Point(206, 23);
            this.courseLbl.Name = "courseLbl";
            this.courseLbl.Size = new System.Drawing.Size(384, 42);
            this.courseLbl.TabIndex = 8;
            this.courseLbl.Text = "Course Management";
            // 
            // coursenameLbl
            // 
            this.coursenameLbl.AutoSize = true;
            this.coursenameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursenameLbl.Location = new System.Drawing.Point(40, 176);
            this.coursenameLbl.Name = "coursenameLbl";
            this.coursenameLbl.Size = new System.Drawing.Size(83, 15);
            this.coursenameLbl.TabIndex = 30;
            this.coursenameLbl.Text = "Course Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 29;
            // 
            // courseWeeks
            // 
            this.courseWeeks.Location = new System.Drawing.Point(127, 207);
            this.courseWeeks.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.courseWeeks.Name = "courseWeeks";
            this.courseWeeks.Size = new System.Drawing.Size(197, 20);
            this.courseWeeks.TabIndex = 49;
            // 
            // weekLbl
            // 
            this.weekLbl.AutoSize = true;
            this.weekLbl.BackColor = System.Drawing.Color.White;
            this.weekLbl.Location = new System.Drawing.Point(261, 210);
            this.weekLbl.Name = "weekLbl";
            this.weekLbl.Size = new System.Drawing.Size(46, 13);
            this.weekLbl.TabIndex = 50;
            this.weekLbl.Text = "WEEKS";
            this.weekLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // CourseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.weekLbl);
            this.Controls.Add(this.courseWeeks);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.courseData);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.courseidLbl);
            this.Controls.Add(this.feeTxt);
            this.Controls.Add(this.coursenameTxt);
            this.Controls.Add(this.courseidTxt);
            this.Controls.Add(this.feeLbl);
            this.Controls.Add(this.crsdurationLbl);
            this.Controls.Add(this.coursePanel);
            this.Controls.Add(this.coursenameLbl);
            this.Controls.Add(this.label1);
            this.Name = "CourseManagement";
            this.Text = "CourseManagement";
            this.Load += new System.EventHandler(this.CourseManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseData)).EndInit();
            this.coursePanel.ResumeLayout(false);
            this.coursePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseWeeks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.DataGridView courseData;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Label courseidLbl;
        private System.Windows.Forms.TextBox feeTxt;
        private System.Windows.Forms.TextBox coursenameTxt;
        private System.Windows.Forms.TextBox courseidTxt;
        private System.Windows.Forms.Label feeLbl;
        private System.Windows.Forms.Label crsdurationLbl;
        private System.Windows.Forms.Panel coursePanel;
        private System.Windows.Forms.Label courseLbl;
        private System.Windows.Forms.Label coursenameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown courseWeeks;
        private System.Windows.Forms.Label weekLbl;
    }
}