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
    public partial class CourseManagement : Form
    {
        public CourseManagement()
        {
            InitializeComponent();
            CourseManagement_Load();
        }
        public void CourseManagement_Load()
        {
        //A Course needs to be searched
        //get the value and store thim in variables

        String ID = courseidTxt.Text;

        //Connect the application to the database using sql connection
        //create an object of sql connection class

        SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");


        //open the connection

        sqlcon.Open();

            //sql comand to search an existing course

            SqlCommand comand = new SqlCommand("select * from Courses where Course_ID=@Course_ID", sqlcon);

        //equalize the column names with the variable names

        comand.Parameters.AddWithValue("@Course_ID", ID);

            // to retrive data from sql, library sqldataadapter

            SqlDataAdapter Da = new SqlDataAdapter(comand);

        //to set retrive data using datatable

        DataTable dt = new DataTable();
        Da.Fill(dt);//using the dataadupter to fill the datatable
            courseData.DataSource = dt;

            // this is the search operation from CRUD
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //click this button to go back to the inital 

            MainMenu menu = new MainMenu();
            menu.Show();//show the main page
            this.Hide();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //A new Course needs to be added
                //get the value and store them in variables

                String ID = courseidTxt.Text;
                String name = coursenameTxt.Text;
                String duration = courseWeeks.Text;
                String fee = feeTxt.Text;

                //Connect the application to the database using sql connection
                //create an object of sql connection class

                SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");


                //open the connection

                sqlcon.Open();

                //sql comand to insert new course
                SqlCommand comand = new SqlCommand("insert into Courses (Course_ID, Course_Name, Duration_Weeks, Fee) values (@Course_ID, @Course_Name, @Duration_Weeks, @Fee)", sqlcon);

                //equalize the column names with the variable names
                comand.Parameters.AddWithValue("@Course_ID", ID);
                comand.Parameters.AddWithValue("@Course_Name", name);
                comand.Parameters.AddWithValue("@Duration_Weeks", duration);
                comand.Parameters.AddWithValue("@Fee", fee);

                //Execute the query

                comand.ExecuteNonQuery();

                CourseManagement_Load();

                //close the connection
                sqlcon.Close();

                MessageBox.Show("Course added successfully");
            }
            catch
            {
                MessageBox.Show("Couldn't add course, Please try again");
            }
            // this is the create operation from the CRUD
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //An existing course needs to be updated
                //get the value and store them in variables

                String ID = courseidTxt.Text;
                String name = coursenameTxt.Text;
                String duration = courseWeeks.Text;
                String fee = feeTxt.Text;


                //Connect the application to the database using sql connection
                //create an object of sql connection class

                SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");


                //open the connection

                sqlcon.Open();

                //sql comand to insert new course

                SqlCommand comand = new SqlCommand("UPDATE Courses SET Course_Name = @Course_Name, Duration_Weeks = @Duration_Weeks, Fee = @Fee WHERE Course_ID = @Course_ID", sqlcon);

                //equalize the column names with the variable names

                comand.Parameters.AddWithValue("@Course_ID", ID);
                comand.Parameters.AddWithValue("@Course_Name", name);
                comand.Parameters.AddWithValue("@Duration_Weeks", duration);
                comand.Parameters.AddWithValue("@Fee", fee);

                //Execute the query

                comand.ExecuteNonQuery();

                CourseManagement_Load();

                //close the connection
                sqlcon.Close();

                MessageBox.Show("Course Updated Successfully");
            }
            catch
            {
                MessageBox.Show("Couldn't update course, Please try again");
            }


            // this is the update operation from the CRUD
        }
        
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            { //A Course needs to be deleted
              //get the value and store them in variables

                String ID = courseidTxt.Text;

                //Connect the application to the database using sql connection
                //create an object of sql connection class

                SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");


                //open the connection

                sqlcon.Open();

                //sql comand to delete an existing course

                SqlCommand comand = new SqlCommand("delete from Courses WHERE Course_ID=@Course_ID", sqlcon);

                //equalize the column names with the variable names

                comand.Parameters.AddWithValue("@Course_ID", ID);

                //Execute the query

                comand.ExecuteNonQuery();

                CourseManagement_Load();

                //close the connection
                sqlcon.Close();

                MessageBox.Show("Course deleted successfully");
            }
            catch
            {
                MessageBox.Show("Couldn't delete course, Please try again");
            }

            // this is the delete operation from the CRUD

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //To clear the details entered 
            courseidTxt.Clear(); //erase course id entered
            coursenameTxt.Clear(); //erase courses name entered
            feeTxt.Clear();//erase course amount entered
        }

        private void viewBtn_Click(object sender, EventArgs e)
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
            Da.Fill(dt);//using the dataadupter to fill the datatable
            courseData.DataSource = dt;

            // this is the read operation from CRUD
        }

        private void CourseManagement_Load(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //A Course needs to be searched
            //get the value and store them in variables

            String ID = courseidTxt.Text;

            //Connect the application to the database using sql connection
            //create an object of sql connection class

            SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");


            //open the connection

            sqlcon.Open();

            //sql comand to search an existing course

            SqlCommand comand = new SqlCommand("select * from Courses where Course_ID=@Course_ID", sqlcon);

            //equalize the column names with the variable names

            comand.Parameters.AddWithValue("@Course_ID", ID);

            // to retrive data from sql, library sqldataadapter

            SqlDataAdapter Da = new SqlDataAdapter(comand);

            //to set retrive data using datatable

            DataTable dt = new DataTable();
            Da.Fill(dt);//using the dataadupter to fill the datatable
            courseData.DataSource = dt;

            // this is the read/search operation from CRUD
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            //click this button to go back to the inital 

            MainMenu menu = new MainMenu();
            menu.Show();//show the main page
            this.Hide();
        }

        private void courseidTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
