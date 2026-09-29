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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //the credentilas to enter should be same as the one below to enter the main menu
            //actual credentials             

            string actual_username = "admin";
            string actual_password = "123";

            //get the variable names from the design textboxes

            string given_username = userTxt.Text;
            string given_password = passTxt.Text;

            //if the username and the password enterd in the text boxes of the system login page is same as the actual username and password then the main menu opens

            if (actual_username == given_username && actual_password == given_password)
            {            
                MainMenu Mm = new MainMenu(); 
                Mm.Show();    //Shows the main menu form
                this.Hide();  //hides the main menu form

                MessageBox.Show("Login Successfull"); //Messagebox shows successfull 
            }
            else // if wrong credentials entered show unsuccesfull

            {
                MessageBox.Show("Invalid Username or password please try again");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //the credentials entered should be erased when this button is clicked

            userTxt.Clear(); //username (admin) entered in textbox will be cleared
            passTxt.Clear(); //password entered in textbox will be deleted
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // To exit the system 

            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
