using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class StudentManagement : Form
    {
        public StudentManagement()
        {
            InitializeComponent();
            StudentManagement_Load();
        }

        public void StudentManagement_Load()
        {
            //To search a student details
            //get the value and store them in variables

            String ID = studentidTxt.Text;

            //Connect the application to the database using sql connection
            //Create an object of sql connection class

            SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");

            //Open the connection

            sqlcon.Open();

            //Sql comand to search student from the students table

            SqlCommand comand = new SqlCommand("Select * From Students where Student_ID=@Student_ID", sqlcon);

            //euqalize the column names with the variable names

            comand.Parameters.AddWithValue("@Student_ID", ID);

            //To retrive data from sql, sql data adapter

            SqlDataAdapter Da = new SqlDataAdapter(comand);

            //to set retrive data using datatable

            DataTable dt = new DataTable();
            Da.Fill(dt);//Using the data adapter to fill the datatable
            studentData.DataSource = dt;
        }
        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {

                //A new student needs to be added
                //get the value and store them in variables

                String name = studentnamTxt.Text;  
                String ID = studentidTxt.Text;
                String dob = studentdobTxt.Text;
                String email = studentemailTxt.Text;
                String number = studentnumTxt.Text;

                //Connect the application to the database using sql connection
                //create an object of sql coonnection class

                SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");


                //open the connection

                sqlcon.Open();

                //sql comand to insert new student

                SqlCommand comand = new SqlCommand("insert into Students (Student_ID, Student_Name, Date_of_Birth, Email, Phone_Number ) values ( @Student_ID, @Student_Name, @Date_of_Birth, @Email, @Phone_Number )", sqlcon);

                //equalize the colum names with the variable names

                comand.Parameters.AddWithValue("@Student_ID", ID);
                comand.Parameters.AddWithValue("@Student_Name", name);
                comand.Parameters.AddWithValue("@Date_of_Birth", dob);
                comand.Parameters.AddWithValue("@Email", email);
                comand.Parameters.AddWithValue("@Phone_Number", number);

                //Execute the query

                comand.ExecuteNonQuery();

                StudentManagement_Load();//call the data loading function

                //close the connection

                sqlcon.Close();
                MessageBox.Show("Inserted Successfully");
            }
            catch
            {
                // Show error message
                MessageBox.Show("An error occurred while inserting the student record");
            }            
            //This is the CREATE operation from the CRUD in the stdent management form.
        }

        private void studentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //click this button to go back to the inital 

            MainMenu menu = new MainMenu();
            menu.Show();//show the main page
            this.Hide();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //To update an existing student details
                //get the value and store them in variables

                String id = studentidTxt.Text;
                String name = studentnamTxt.Text;
                String dob = studentdobTxt.Text;
                String email = studentemailTxt.Text;
                String number = studentnumTxt.Text;

                //Connect the application to the database using sql connection
                //create an object of sql connection class

                SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");


                //open the connection

                sqlcon.Open();

                //sql comand to update existing Student

                SqlCommand comand = new SqlCommand("update Students set Student_Name=@Student_Name, Date_of_Birth=@Date_of_Birth, Email=@Email, Phone_Number=@Phone_Number" +
                    " WHERE Student_ID=@Student_ID", sqlcon);

                //equalize the column names with the variable names

                comand.Parameters.AddWithValue("@Student_ID", id);
                comand.Parameters.AddWithValue("@Student_Name", name);
                comand.Parameters.AddWithValue("@Date_of_Birth", dob);
                comand.Parameters.AddWithValue("@Email", email);
                comand.Parameters.AddWithValue("@Phone_Number", number);

                //Execute the query

                comand.ExecuteNonQuery();

                StudentManagement_Load();

                //close the connection
                sqlcon.Close();

                MessageBox.Show("Updated Successfully");
            }
            catch
            {
                //show error message 
                MessageBox.Show("couldn't update, Please try again");
            }
            //this is the update operation from the CRUD
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {

                //to delete a student details
                //get the value and store them in variables

                String ID = studentidTxt.Text;

                //Connect the application to the database using sql connection
                //create an object of sql connection class

                SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");


                //open the connection

                sqlcon.Open();

                //sql comand to update existing

                SqlCommand comand = new SqlCommand("delete from Students Where Student_Id=@Student_ID", sqlcon);

                //equalize the column names with the variable names

                comand.Parameters.AddWithValue("@Student_ID", ID);

                //Execute the query

                comand.ExecuteNonQuery();

                StudentManagement_Load();

                //close the connection
                sqlcon.Close();

                MessageBox.Show("Deleted Successfully");
            }
            catch
            {
                //show error message
                MessageBox.Show("Couldn't delete, Please try again");
            }

            //this is the delete operation from the CRUD
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //To search a student details
            //get the value and store them in variables

            String ID = studentidTxt.Text;

            //Connect the application to the database using sql connection
            //create an object of sql connection class

            SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");

            //open the connection

            sqlcon.Open();

            //sql comand to search student from the students table

            SqlCommand comand = new SqlCommand("Select * From Students where Student_ID=@Student_ID", sqlcon);

            //equalize the column names with the variable names

            comand.Parameters.AddWithValue("@Student_ID", ID);

            // to retrive data from sql,library sqldataadapter

            SqlDataAdapter Da = new SqlDataAdapter(comand);

            //to set retrive data using datatable

            DataTable dt = new DataTable();
            Da.Fill(dt);//using the dataadupter to fill the datatable
            studentData.DataSource = dt;

            // this is the read/search operation from CRUD
        }

        private void StudentManagement_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                      

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            //To view all the existing students

            //Connect the application to the database using sql connection
            //create an object of sql conection class

            SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");

            //open the connection

            sqlcon.Open();

            //sql comand to make all student visible in the data grid view

            SqlCommand comand = new SqlCommand("Select * From Students", sqlcon);

            // to retrive data from sql, sql data adapter

            SqlDataAdapter Da = new SqlDataAdapter(comand);

            //to set retrive data using datatable

            DataTable dt = new DataTable();
            Da.Fill(dt);//using the data adapter to fill the datatable
            studentData.DataSource = dt;

            // this is the read operation from CRUD
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // to clear details entered
            studentidTxt.Clear(); //erase students id
            studentnamTxt.Clear(); //erase students name
            studentdobTxt.Clear(); //erase students date of birth
            studentemailTxt.Clear(); //erase students email
            studentnumTxt.Clear(); //erase stdents mobile number
        }

        private void studentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
