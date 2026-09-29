using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //click this button to go back to the inital 

            Login login = new Login();
            login.Show();//show the Login page
            this.Hide();// hide the main menu
        }

        private void gradesBtn_Click(object sender, EventArgs e)
        {
            //click this button to open Grades System

            GradesSystem  grade = new GradesSystem();
            grade.Show();//show the grades page
            this.Hide();//hide the main menu
        }

        private void enrollBtn_Click(object sender, EventArgs e)
        {
            //click this button to open Enrollmemnt Management

            EnrollManagement enroll = new EnrollManagement();
            enroll.Show();//show the enrollment page
            this.Hide();//hide the main menu
        }

        private void courseBtn_Click(object sender, EventArgs e)
        {
            //click this button to open Course Management

            CourseManagement course = new CourseManagement();
            course.Show();//show the course page
            this.Hide();//hide the main menu
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            //click this button to open Student Management

            StudentManagement student = new StudentManagement();
            student.Show();//show the student page
            this.Hide();//hide the main menu
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
