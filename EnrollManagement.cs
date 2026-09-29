using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class EnrollManagement : Form
    {
        public EnrollManagement()
        {
            InitializeComponent();
            EnrollManagement_Load();
        }
        public void EnrollManagement_Load()
        {
            //to search an enrollment
            //get the value and store them in variables

            String ID = enrollidTxt.Text;

            //Connect the application to the database using sql connection
            //create an object of sql connection class

            SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");

            sqlcon.Open();

            SqlCommand comand = new SqlCommand("select * from Enrollments WHERE Enrollment_ID=@Enrollment_ID", sqlcon);

            comand.Parameters.AddWithValue("@Enrollment_ID", ID);

            comand.ExecuteNonQuery();

            // to retrive data from sql, library sqldataadapter

            SqlDataAdapter Da = new SqlDataAdapter(comand);

            //to set retrive data using datatable

            DataTable dt = new DataTable();
            Da.Fill(dt);//using the dataadupter to fill the datatable
            courseData2.DataSource = dt;

            // this is the read operation from CRUD
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            //click this button to go back to the inital 

            MainMenu menu = new MainMenu();
            menu.Show();//show the main page
            this.Hide();
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
            courseData2.DataSource = dt;

            // this is the read operation from CRUD
        }

        private void courseData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EnrollManagement_Load(object sender, EventArgs e)
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


        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //A new enrollment
                //get the value and store them in variables

                String ID = enrollidTxt.Text;
                String studentID = studentidTxt.Text;
                String Date = enrolldtTxt.Text;

                //Connect the application to the database using sql connection
                //create an object of sql connection class

                SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");

                sqlcon.Open();

                //foreach loop to iterate over CheckedItems in a CheckedListBox control, to retrieve all selected items.

                foreach (var item in courseList.CheckedItems)
                {
                    String selectedCourse = item.ToString(); // converted to string

                    SqlCommand comand = new SqlCommand("insert into Enrollments (Enrollment_ID, Student_ID, Course_ID, Enrollment_Date) values (@Enrollment_ID, @Student_ID, @Course_ID, @Enrollment_Date)", sqlcon);

                    comand.Parameters.AddWithValue("@Enrollment_ID", ID);
                    comand.Parameters.AddWithValue("@Student_ID", studentID);
                    comand.Parameters.AddWithValue("@Course_ID", selectedCourse);
                    comand.Parameters.AddWithValue("@Enrollment_Date", Date);

                    comand.ExecuteNonQuery();
                }

                EnrollManagement_Load();

                // close connection after this loop
                sqlcon.Close();

                //show message if success
                MessageBox.Show("Saved Successfully");
            }
            catch
            {
                //show message if errors
                MessageBox.Show("Couldn't save, Please try again");
            }
            //this is the Create from CRUD 
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //To update an enrollment
                //get the value and store them in variables

                String ID = enrollidTxt.Text;
                String studentID = studentidTxt.Text;
                String Date = enrolldtTxt.Text;

                //Connect the application to the database using sql connection
                //create an object of sql connection class

                SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");

                sqlcon.Open();

                foreach (var item in courseList.CheckedItems)
                {
                    String selectedCourse = item.ToString();

                    SqlCommand comand = new SqlCommand("UPDATE Enrollments SET Student_ID = @Student_ID, Course_ID = @Course_ID, Enrollment_Date = @Enrollment_Date WHERE Enrollment_ID = @Enrollment_ID", sqlcon);


                    comand.Parameters.AddWithValue("@Enrollment_ID", ID);
                    comand.Parameters.AddWithValue("@Student_ID", studentID);
                    comand.Parameters.AddWithValue("@Course_ID", selectedCourse);
                    comand.Parameters.AddWithValue("@Enrollment_Date", Date);

                    comand.ExecuteNonQuery();
                }

                EnrollManagement_Load();

                // close connection after this loop
                sqlcon.Close();

                MessageBox.Show("Updated Successfully");
            }
            catch
            {
                MessageBox.Show("Couldn't update, Please try again");
            }
            //this is the Update from CRUD
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //To delete an enrollment
                //get the value and store them in variables

                String ID = enrollidTxt.Text;


                //Connect the application to the database using sql connection
                //create an object of sql connection class

                SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");

                sqlcon.Open();

                SqlCommand comand = new SqlCommand("delete from Enrollments WHERE Enrollment_ID = @Enrollment_ID", sqlcon);

                comand.Parameters.AddWithValue("@Enrollment_ID", ID);

                comand.ExecuteNonQuery();

                EnrollManagement_Load();

                // close connection after this loop
                sqlcon.Close();

                MessageBox.Show("Deleted Successfully");
            }
            catch
            {
                MessageBox.Show("Couldn't delete, Please try again");
            }
            //this is the delete from CRUD
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //to clear the details entered
            enrollidTxt.Clear();//erase enrollment id entered
            studentidTxt.Clear();//erase student id entered
            enrolldtTxt.Clear(); //erase enrollment date entered
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //to search an enrollment
            //get the value and store them in variables

            String ID = enrollidTxt.Text;

            //Connect the application to the database using sql connection
            //create an object of sql connection class

            SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");

            sqlcon.Open();

            SqlCommand comand = new SqlCommand("select * from Enrollments WHERE Enrollment_ID=@Enrollment_ID", sqlcon);

            comand.Parameters.AddWithValue("@Enrollment_ID", ID);

            comand.ExecuteNonQuery();

            // to retrive data from sql, sqldataadapter

            SqlDataAdapter Da = new SqlDataAdapter(comand);

            //to set retrive data using datatable

            DataTable dt = new DataTable();
            Da.Fill(dt);//using the dataadupter to fill the datatable
            courseData2.DataSource = dt;

            // this is the read operation from CRUD
        }

        private void enrollData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //To view all the enrollments

            //Connect the application to the database using sql connection
            //create an object of sql connection class

            SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");


            //open the connection

            sqlcon.Open();

            //sql comand to list all the  existing enrollments

            SqlCommand comand = new SqlCommand("Select * from Enrollments", sqlcon);


            // to retrive data from sql, library sqldataadapter

            SqlDataAdapter Da = new SqlDataAdapter(comand);

            //to set retrive data using datatable

            DataTable dt = new DataTable();
            Da.Fill(dt);//using the dataadupter to fill the datatable
            courseData2.DataSource = dt;

            // this is the read operation from CRUD
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            //click this button to go back to the inital 

            MainMenu menu = new MainMenu();
            menu.Show();//show the main page
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //To view all the existing students

            //Connect the application to the database using sql connection
            //create an object of sql conection class

            SqlConnection sqlcon = new SqlConnection("Data Source=MYASUSI3;Initial Catalog=Student_Management_System;Integrated Security=True");

            //open the connection

            sqlcon.Open();

            //sql comand to make all student visible in the data grid view

            SqlCommand comand = new SqlCommand("Select * From Students", sqlcon);

            // to retrive data from sql,library sqldataadapter

            SqlDataAdapter Da = new SqlDataAdapter(comand);

            //to set retrive data using datatable

            DataTable dt = new DataTable();
            Da.Fill(dt);//using the dataadupter to fill the datatable
            courseData2.DataSource = dt;

            // this is the read operation from CRUD
        }

        private void enrollidTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

