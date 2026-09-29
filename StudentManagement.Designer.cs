namespace Student_Management_System
{
    partial class StudentManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.studentnameLbl = new System.Windows.Forms.Label();
            this.studentPanel = new System.Windows.Forms.Panel();
            this.studentLbl = new System.Windows.Forms.Label();
            this.studentdobLbl = new System.Windows.Forms.Label();
            this.studentemailLbl = new System.Windows.Forms.Label();
            this.studentnumLbl = new System.Windows.Forms.Label();
            this.studentidTxt = new System.Windows.Forms.TextBox();
            this.studentnamTxt = new System.Windows.Forms.TextBox();
            this.studentdobTxt = new System.Windows.Forms.TextBox();
            this.studentemailTxt = new System.Windows.Forms.TextBox();
            this.studentnumTxt = new System.Windows.Forms.TextBox();
            this.studentidLbl = new System.Windows.Forms.Label();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.studentData = new System.Windows.Forms.DataGridView();
            this.viewBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.studentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // studentnameLbl
            // 
            this.studentnameLbl.AutoSize = true;
            this.studentnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentnameLbl.Location = new System.Drawing.Point(37, 172);
            this.studentnameLbl.Name = "studentnameLbl";
            this.studentnameLbl.Size = new System.Drawing.Size(64, 15);
            this.studentnameLbl.TabIndex = 1;
            this.studentnameLbl.Text = "Full Name";
            // 
            // studentPanel
            // 
            this.studentPanel.BackColor = System.Drawing.Color.Gold;
            this.studentPanel.Controls.Add(this.studentLbl);
            this.studentPanel.Location = new System.Drawing.Point(-1, 0);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(802, 87);
            this.studentPanel.TabIndex = 9;
            this.studentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.studentPanel_Paint);
            // 
            // studentLbl
            // 
            this.studentLbl.AutoSize = true;
            this.studentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLbl.Location = new System.Drawing.Point(197, 24);
            this.studentLbl.Name = "studentLbl";
            this.studentLbl.Size = new System.Drawing.Size(393, 42);
            this.studentLbl.TabIndex = 8;
            this.studentLbl.Text = "Student Management";
            // 
            // studentdobLbl
            // 
            this.studentdobLbl.AutoSize = true;
            this.studentdobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentdobLbl.Location = new System.Drawing.Point(36, 201);
            this.studentdobLbl.Name = "studentdobLbl";
            this.studentdobLbl.Size = new System.Drawing.Size(74, 15);
            this.studentdobLbl.TabIndex = 10;
            this.studentdobLbl.Text = "Date of Birth";
            // 
            // studentemailLbl
            // 
            this.studentemailLbl.AutoSize = true;
            this.studentemailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentemailLbl.Location = new System.Drawing.Point(37, 232);
            this.studentemailLbl.Name = "studentemailLbl";
            this.studentemailLbl.Size = new System.Drawing.Size(39, 15);
            this.studentemailLbl.TabIndex = 11;
            this.studentemailLbl.Text = "Email";
            // 
            // studentnumLbl
            // 
            this.studentnumLbl.AutoSize = true;
            this.studentnumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentnumLbl.Location = new System.Drawing.Point(37, 265);
            this.studentnumLbl.Name = "studentnumLbl";
            this.studentnumLbl.Size = new System.Drawing.Size(91, 15);
            this.studentnumLbl.TabIndex = 12;
            this.studentnumLbl.Text = "Phone Number";
            // 
            // studentidTxt
            // 
            this.studentidTxt.Location = new System.Drawing.Point(129, 143);
            this.studentidTxt.Name = "studentidTxt";
            this.studentidTxt.Size = new System.Drawing.Size(197, 20);
            this.studentidTxt.TabIndex = 13;
            // 
            // studentnamTxt
            // 
            this.studentnamTxt.Location = new System.Drawing.Point(129, 172);
            this.studentnamTxt.Name = "studentnamTxt";
            this.studentnamTxt.Size = new System.Drawing.Size(197, 20);
            this.studentnamTxt.TabIndex = 14;
            // 
            // studentdobTxt
            // 
            this.studentdobTxt.Location = new System.Drawing.Point(129, 201);
            this.studentdobTxt.Name = "studentdobTxt";
            this.studentdobTxt.Size = new System.Drawing.Size(197, 20);
            this.studentdobTxt.TabIndex = 15;
            this.studentdobTxt.Text = "MM/DD/YYYY";
            // 
            // studentemailTxt
            // 
            this.studentemailTxt.Location = new System.Drawing.Point(129, 232);
            this.studentemailTxt.Name = "studentemailTxt";
            this.studentemailTxt.Size = new System.Drawing.Size(197, 20);
            this.studentemailTxt.TabIndex = 16;
            // 
            // studentnumTxt
            // 
            this.studentnumTxt.Location = new System.Drawing.Point(129, 265);
            this.studentnumTxt.Name = "studentnumTxt";
            this.studentnumTxt.Size = new System.Drawing.Size(197, 20);
            this.studentnumTxt.TabIndex = 17;
            // 
            // studentidLbl
            // 
            this.studentidLbl.AutoSize = true;
            this.studentidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentidLbl.Location = new System.Drawing.Point(36, 144);
            this.studentidLbl.Name = "studentidLbl";
            this.studentidLbl.Size = new System.Drawing.Size(64, 15);
            this.studentidLbl.TabIndex = 18;
            this.studentidLbl.Text = "Student ID";
            // 
            // insertBtn
            // 
            this.insertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Location = new System.Drawing.Point(36, 334);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 20;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(129, 334);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 21;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(226, 334);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 22;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(581, 305);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 23;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(675, 305);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 24;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // studentData
            // 
            this.studentData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentData.Location = new System.Drawing.Point(363, 134);
            this.studentData.Name = "studentData";
            this.studentData.Size = new System.Drawing.Size(409, 159);
            this.studentData.TabIndex = 25;
            this.studentData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentData_CellContentClick);
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.Location = new System.Drawing.Point(486, 305);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 23);
            this.viewBtn.TabIndex = 27;
            this.viewBtn.Text = "View All";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(326, 334);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 28;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.studentData);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.studentidLbl);
            this.Controls.Add(this.studentnumTxt);
            this.Controls.Add(this.studentemailTxt);
            this.Controls.Add(this.studentdobTxt);
            this.Controls.Add(this.studentnamTxt);
            this.Controls.Add(this.studentidTxt);
            this.Controls.Add(this.studentnumLbl);
            this.Controls.Add(this.studentemailLbl);
            this.Controls.Add(this.studentdobLbl);
            this.Controls.Add(this.studentPanel);
            this.Controls.Add(this.studentnameLbl);
            this.Controls.Add(this.label1);
            this.Name = "StudentManagement";
            this.Text = "StudentManagement";
            this.Load += new System.EventHandler(this.StudentManagement_Load);
            this.studentPanel.ResumeLayout(false);
            this.studentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label studentnameLbl;
        private System.Windows.Forms.Panel studentPanel;
        private System.Windows.Forms.Label studentLbl;
        private System.Windows.Forms.Label studentdobLbl;
        private System.Windows.Forms.Label studentemailLbl;
        private System.Windows.Forms.Label studentnumLbl;
        private System.Windows.Forms.TextBox studentidTxt;
        private System.Windows.Forms.TextBox studentnamTxt;
        private System.Windows.Forms.TextBox studentdobTxt;
        private System.Windows.Forms.TextBox studentemailTxt;
        private System.Windows.Forms.TextBox studentnumTxt;
        private System.Windows.Forms.Label studentidLbl;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView studentData;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}