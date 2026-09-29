using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Student_Management_System
{
    public partial class GradesSystem : Form
    {
        public GradesSystem()
        {
            InitializeComponent();
            GradesSystem_Load();
        }
        private void GradesSystem_Load()
        {

            // To update the grades entered to grades table database
            // get the value and store them in variables

            String enrollID = enrollidTxt.Text;

            // Connect the application to the database using sql connection
            // create an object of sql connection class

            SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");

            sqlcon.Open();

            SqlCommand comand = new SqlCommand("SELECT * FROM Grades WHERE Enrollment_ID = @Enrollment_ID", sqlcon);

            comand.Parameters.AddWithValue("@Enrollment_ID", enrollID);


            foreach (var item in courseList.CheckedItems)
            {
                String selectedCourse = item.ToString();

            }


            SqlDataAdapter Da = new SqlDataAdapter(comand);

            // to set retrieve data using datatable
            DataTable dt = new DataTable();
            Da.Fill(dt); // using the data adapter to fill the datatable
            gradeData3.DataSource = dt;

            // close connection
            sqlcon.Close();

            // this is the read operation from CRUD
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //click this button to go back to the inital 

            MainMenu menu = new MainMenu();
            menu.Show();//show the main page
            this.Hide();
        }

        private void GradesSystem_Load(object sender, EventArgs e)
        {
            courseList.Items.Clear();

            string connectionString = "Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True";

            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("SELECT Course_ID FROM Courses", sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    courseList.Items.Add(row["Course_ID"].ToString());
                }

            }
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            //click this button to go back to the inital 

            MainMenu menu = new MainMenu();
            menu.Show();//show the main page
            this.Hide();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Grade for a course needs to be saved 
                //get the value and store them in variables

                String enrollID = enrollidTxt.Text;

                string grade;

                if (distinctRadio.Checked)
                {
                    grade = "Distinction";
                }
                else if (upperRadio.Checked)
                {
                    grade = "Second Upper";
                }
                else if (lowerRadio.Checked)
                {
                    grade = "Second Lower";
                }
                else if (passRadio.Checked)
                {
                    grade = "Pass";
                }
                else
                {
                    grade = "Resit";
                }

                //Connect the application to the database using sql connection
                //create an object of sql connection class

                SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");

                sqlcon.Open();

                foreach (var item in courseList.CheckedItems)
                {
                    String selectedCourse = item.ToString();

                    SqlCommand comand = new SqlCommand("INSERT INTO Grades (Enrollment_ID, Course_ID, Grade values) values (@Enrollment_ID, @Course_ID, @Grade)", sqlcon);
                    comand.Parameters.AddWithValue("@Enrollment_ID", enrollID);
                    comand.Parameters.AddWithValue("@Course_ID", selectedCourse);
                    comand.Parameters.AddWithValue("@Grade", grade);

                    comand.ExecuteNonQuery();
                }
                GradesSystem_Load();

                // close connection after this loop
                sqlcon.Close();

                MessageBox.Show("Saved Successfully"); //show message success
            }
            catch
            {
                MessageBox.Show("Couldn't save, Please try again"); // show message if any error
            }
        }//this is the create from CRUD


        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // To update the grades entered to grades table database
                //get the value and store them in variables

                String enrollID = enrollidTxt.Text;

                string grade;

                if (distinctRadio.Checked)
                {
                    grade = "Distinction";
                }
                else if (upperRadio.Checked)
                {
                    grade = "Second Upper";
                }
                else if (lowerRadio.Checked)
                {
                    grade = "Second Lower";
                }
                else if (passRadio.Checked)
                {
                    grade = "Pass";
                }
                else
                {
                    grade = "Resit";
                }

                //Connect the application to the database using sql connection
                //create an object of sql connection class

                SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");

                sqlcon.Open();

                foreach (var item in courseList.CheckedItems)
                {
                    String selectedCourse = item.ToString();

                    SqlCommand comand = new SqlCommand("UPDATE Grades SET Grade = @Grade WHERE Enrollment_ID = @Enrollment_ID AND Course_ID = @Course_ID", sqlcon);
                    comand.Parameters.AddWithValue("@Enrollment_ID", enrollID);
                    comand.Parameters.AddWithValue("@Course_ID", selectedCourse);
                    comand.Parameters.AddWithValue("@Grade", grade);

                    comand.ExecuteNonQuery();
                }
                GradesSystem_Load();

                // close connection after this loop
                sqlcon.Close();

                MessageBox.Show("Updated Successfully");
            }
            catch
            {
                MessageBox.Show("Couldn't update, please try again");
            }
            //this is the update from CRUD
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // To delete the grades entered to grades table database
                //get the value and store them in variables

                String enrollID = enrollidTxt.Text;


                //Connect the application to the database using sql connection
                //create an object of sql connection class

                SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");

                sqlcon.Open();

                SqlCommand comand = new SqlCommand("delete from Grades WHERE Enrollment_ID = @Enrollment_ID", sqlcon); ;
                comand.Parameters.AddWithValue("@Enrollment_ID", enrollID);

                comand.ExecuteNonQuery();

                GradesSystem_Load();

                // close connection after this loop
                sqlcon.Close();

                MessageBox.Show("Deleted Successfully");
            }
            catch
            {
                MessageBox.Show("Couldn't delete, Please try again");
            }
        }//this is delete from CRUD

        private void clearBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // To update the grades entered to grades table database
            // get the value and store them in variables

            String enrollID = enrollidTxt.Text;

            // Connect the application to the database using sql connection
            // create an object of sql connection class

            SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");

            sqlcon.Open();

            SqlCommand comand = new SqlCommand("SELECT * FROM Grades WHERE Enrollment_ID = @Enrollment_ID", sqlcon); 

            comand.Parameters.AddWithValue("@Enrollment_ID", enrollID);

            
            foreach (var item in courseList.CheckedItems)
            {
                String selectedCourse = item.ToString();
                
            }

            
            SqlDataAdapter Da = new SqlDataAdapter(comand);

            // to set retrieve data using datatable
            DataTable dt = new DataTable();
            Da.Fill(dt); // using the data adapter to fill the datatable
            gradeData3.DataSource = dt;

            // close connection
            sqlcon.Close();

            // this is the read operation from CRUD
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            //To view all the enrollments available

            //Connect the application to the database using sql connection
            //create an object of sql connection class

            SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");


            //open the connection

            sqlcon.Open();

            //sql comand to list all the  existing course

            SqlCommand comand = new SqlCommand("Select * from Enrollments", sqlcon);


            // to retrive data from sql, sqldataadapter

            SqlDataAdapter Da = new SqlDataAdapter(comand);

            //to set retrive data using datatable

            DataTable dt = new DataTable();
            Da.Fill(dt);//using the data adapter to fill the datatable
            gradeData3.DataSource = dt;

            // this is the read operation from CRUD
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //To view all the courses available

            //Connect the application to the database using sql connection
            //create an object of sql connection class

            SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");


            //open the connection

            sqlcon.Open();

            //sql comand to list all the  existing course

            SqlCommand comand = new SqlCommand("Select * from Courses", sqlcon);


            // to retrive data from sql, sqldataadapter

            SqlDataAdapter Da = new SqlDataAdapter(comand);

            //to set retrive data using datatable

            DataTable dt = new DataTable();
            Da.Fill(dt);//using the data adapter to fill the datatable
            gradeData3.DataSource = dt;

            // this is the read operation from CRUD
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //To view all the grades to the courses 

            //Connect the application to the database using sql connection
            //create an object of sql connection class

            SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");


            //open the connection

            sqlcon.Open();

            //sql comand to list all the  existing course

            SqlCommand comand = new SqlCommand("Select * from Grades", sqlcon);


            // to retrive data from sql, sql data adapter

            SqlDataAdapter Da = new SqlDataAdapter(comand);

            //to set retrive data using datatable

            DataTable dt = new DataTable();
            Da.Fill(dt);//using the data adapter to fill the datatable
            gradeData3.DataSource = dt;

            // this is the read operation from CRUD
        }
    }
}   

