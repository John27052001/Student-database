using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // putting the location and visability of the login screen when initalizing 
            LoginPage.Visible = true;
            LoginPage.Location = new Point(12, 12);

            Dashboard.Visible = false;

            ClassManagePage.Visible = false;

            editInfoPage.Visible = false;

            Global.CurrentLoggedInUser = null;

        }
        // getting the Connection string
        public string connectionString()
        {

            // database
            var db = "studentdb_test";
            // name of the server
            var uid = "root";
            // password to acess the Server
            //var password = "Doomguy2";
            var password = "st3v0hUh8!";

            // construction the connection string
            var conString = "Server=localhost;database=" + db + ";uid=" + uid + ";password=" + password + ";";

            // returngin it
            return conString;

        }

        ////////////////////////  LOGIN PAGE   ///////////////////

        // Logging into the thing
        private void LoginButton_Click(object sender, EventArgs e)
        {

            var username = LoginUsername.Text;

            var password = LoginPassword.Text;

            // if either the username or password are empty
            if (username == "" || password == "")
            {

                MessageBox.Show("No username/passward is imputed.");

                return;
            }

            var connStr = connectionString();

            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            // getting the  studentid/pasword from the studentinfo list
            var commStr = "SELECT studentid,password FROM studentdb_test.studentinfo where studentid = '" + username + "'";

            MySqlCommand cmd = new MySqlCommand(commStr, conn);

            var reader = cmd.ExecuteReader();

            // reading the returned table
            if (reader.Read())
            {

                var recevPass = reader[1].ToString();

                if (password == recevPass)
                {
                    MessageBox.Show("Login Successfull");
                    // setting the current logged in thing
                    Global.CurrentLoggedInUser = username;
                    // hiding the login page


                    InitalizeMainPage();

                }
                else
                {
                    MessageBox.Show("Incorrect password");
                }

            }
            else
            {

                MessageBox.Show("Invalid Username");

            }



        }


        ////////////////////////  SETTING UP THE STUDENT DASHBOARD ///////////////////

        // setting up the Other pages
        private void InitalizeMainPage()
        {

            ResettingSeletingThings();

            // hiding the other pages
            LoginPage.Visible = false;

            // setting the location of the thing or someting
            Dashboard.Location = new Point(12,12);

            // showing the dashboard
            Dashboard.Visible = true;

            // creating the connection
            MySqlConnection con = new MySqlConnection(connectionString());

            con.Open();

            // getting the  studentid/pasword from the studentinfo list
            var commStr = "SELECT * FROM studentdb_test.studentinfo where studentid = " + Global.CurrentLoggedInUser ;

            MySqlCommand cmd = new MySqlCommand(commStr, con);

            var reader = cmd.ExecuteReader();

            // reading the returned table
            if (reader.Read())
            {

                //var recevPass = reader[1].ToString();


                WelcomeBlurb.Text = "Welcome " + reader[2] + " " + reader[3] + "\nPhoneNumb: " + reader[4].ToString() + "\nDOB: " + reader[5].ToString() + "\nGender: "+reader[6];

                reader.Close();

            }


            // binging the currently enrolled classes to the dashboard gridView



            commStr = "SELECT  course.courseid as CourseId,course.cname as Course, instructor.name as Teacher ,department.deptname as Department\r\n\tfrom course\r\nleft outer join studentcourse\r\n\ton course.courseid = studentcourse.courseid\r\nleft outer join studentinfo\r\n\ton studentcourse.studentid = studentinfo.studentid\r\nleft outer join instructor\r\n\ton instructor.iid = course.instructor\r\nleft outer join department\r\n\ton department.deptid = course.deptid\r\nwhere studentcourse.studentid = "+ Global.CurrentLoggedInUser +";";

            using (cmd = new MySqlCommand(commStr, con)) { 
            
            
                cmd.CommandType = CommandType.Text;
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd)) {

                    using (DataTable dt = new DataTable()) { 
                    
                        sda.Fill(dt);
                        DashGridView.DataSource = dt;  

                    }

                }

            
            }

            con.Close();

        }

        ////////////////////////  CLASS MANAGEMENT PAGE   ///////////////////

        // switching to the management page
        private void button1_Click(object sender, EventArgs e)
        {

            // hiding the other pages
            LoginPage.Visible = false;
            Dashboard.Visible = false;

            // showing the manage class thing
            ClassManagePage.Location = new Point(12,12);
            ClassManagePage.Visible = true;

            loadManageTables();

        }

        private void ResettingSeletingThings() {

            // resettiing all values for the adding and droping classes portion of it
            Global.SelectedEnrolledClass = "";
            Global.SelectedCurrentEnrolledClass = "";
            // disabeling the add / drop button
            AddClass.Enabled = false;
            DropClass.Enabled = false;

        }

        // Actually loading the data into the tables
        private void loadManageTables() {


            ResettingSeletingThings();

            // opening the connection
            // creating the connection
            MySqlConnection con = new MySqlConnection(connectionString());

            con.Open();
            MySqlCommand cmd;

            MySqlTransaction mySqlTransaction = con.BeginTransaction();
            // creating view that holds the currently enrolled classes

            try
            {

                using (cmd = new MySqlCommand("create or replace view `temp` as \r\nselect  course.courseid as CourseId,course.cname as Course, instructor.name as Teacher ,department.deptname as Department\r\n\tfrom course\r\nleft outer join studentcourse\r\n\ton course.courseid = studentcourse.courseid\r\nleft outer join studentinfo\r\n\ton studentcourse.studentid = studentinfo.studentid\r\nleft outer join instructor\r\n\ton instructor.iid = course.instructor\r\nleft outer join department\r\n\ton department.deptid = course.deptid\r\nwhere studentcourse.studentid = " + Global.CurrentLoggedInUser + ";", con))
                {

                    int i = cmd.ExecuteNonQuery();

                }


                // loading the currently enrolled classes
                var commStr = "SELECT * from `temp` ";

                cmd = new MySqlCommand(commStr, con);

                using (cmd = new MySqlCommand(commStr, con))
                {


                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {

                        using (DataTable dt = new DataTable())
                        {

                            sda.Fill(dt);
                            CurrentlyEnrolledClassesGrid.DataSource = dt;

                        }

                    }


                }


                // loading the avalable classes

                commStr = "select course.* \r\n\tfrom course\r\nwhere courseid not in (select CourseId from temp);";

                cmd = new MySqlCommand(commStr, con);

                using (cmd = new MySqlCommand(commStr, con))
                {


                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {

                        using (DataTable dt = new DataTable())
                        {

                            sda.Fill(dt);
                            AvalableClassesGrid.DataSource = dt;

                        }

                    }


                }


                // droping the view
                using (cmd = new MySqlCommand("drop view `temp`;", con))
                {

                    int i = cmd.ExecuteNonQuery();

                }

                mySqlTransaction.Commit();

            }
            catch { mySqlTransaction.Rollback(); }

            con.Close();


        }




        // Goes back to dashboard Screen
        private void ToDashboard_Click(object sender, EventArgs e)
        {

            InitalizeMainPage();

        }


        /// SELECTING THE CLASS TO ADD TO THE STUDENT
        private void AvalableClassesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // retreving the selected class id
            Global.SelectedEnrolledClass = AvalableClassesGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            
            Debug.Write(Global.SelectedEnrolledClass);
            // turning on the button to add the class
            AddClass.Enabled = true;

        }

        /// SELECTING THE CLASS TO DROP FROM THE STUDENT
        private void CurrentlyEnrolledClassesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // retreving the selected class id
            Global.SelectedCurrentEnrolledClass = CurrentlyEnrolledClassesGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

            Debug.Write(Global.SelectedCurrentEnrolledClass);
            // turning on the button to add the class
            DropClass.Enabled = true;
        }

        // adding class the the student
        private void AddClass_Click(object sender, EventArgs e)
        {

            // creating the connection
            MySqlConnection con = new MySqlConnection(connectionString());

            con.Open();
            MySqlCommand cmd;

            MySqlTransaction mySqlTransaction = con.BeginTransaction();
            // creating view that holds the currently enrolled classes

            // trying to add thing to the classes
            try
            {

                var cmdStr = "insert into studentcourse (`studentid`,`courseid`) values ('"+ Global.CurrentLoggedInUser +"','"+ Global.SelectedEnrolledClass +"');";

                using (cmd = new MySqlCommand( cmdStr ,con)) {


                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {

                        // someting went wrong here

                    }

                }

                // committing the change
                mySqlTransaction.Commit();


            }
            // rolling back if someting messes up
            catch { mySqlTransaction.Rollback(); }

            loadManageTables();

        }

        private void DropClass_Click(object sender, EventArgs e)
        {
            // creating the connection
            MySqlConnection con = new MySqlConnection(connectionString());

            con.Open();
            MySqlCommand cmd;

            MySqlTransaction mySqlTransaction = con.BeginTransaction();
            // creating view that holds the currently enrolled classes

            // trying to add thing to the classes
            try
            {
                //"Delete from studentcourse WHERE studentid = 1 and courseid = 1;"
                var cmdStr = "Delete from studentcourse WHERE studentid =" + Global.CurrentLoggedInUser + " and courseid = " + Global.SelectedCurrentEnrolledClass + ";";
                //cmdStr = "Delete from studentcourse WHERE studentid = 1 and courseid = 1;";

                using (cmd = new MySqlCommand(cmdStr, con))
                {


                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {

                        // someting went wrong here

                    }

                }

                // committing the change
                mySqlTransaction.Commit();


            }
            // rolling back if someting messes up
            catch { mySqlTransaction.Rollback(); }

            loadManageTables();
        }


        ///EDIT STUDENT INFO PAGE ////
        private void editInfoBtn_Click(object sender, EventArgs e)
        {
            Dashboard.Visible = false;
            ClassManagePage.Visible = false;

            editInfoPage.Location = new Point(12, 12);
            editInfoPage.Visible = true;

            MySqlConnection con = new MySqlConnection(connectionString());

            con.Open();

            string getFname = "select fname, lname, phonenum, dob from studentinfo where studentid = '" + LoginUsername.Text + "'";
            MySqlCommand cmd = new MySqlCommand(getFname, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                fnameTxtBox.Text = reader[0].ToString();
                lnameTxtBox.Text = reader[1].ToString();
                phoneTxtBox.Text = reader[2].ToString();
                dobTxtBox.Text = reader[3].ToString();

                reader.Close();
            }
            con.Close();
        }

        private void toDashboardBtn_Click(object sender, EventArgs e)
        {
            editInfoPage.Visible = false;

            Dashboard.Location = new Point(12, 12);
            Dashboard.Visible = true;

            InitalizeMainPage();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString());
            con.Open();

            string updateInfo = "update studentinfo set fname = '" + fnameTxtBox.Text + "' where studentid = '" + LoginUsername.Text + "'";
            MySqlCommand cmd = new MySqlCommand(updateInfo, con);
            int i = cmd.ExecuteNonQuery();
            if (i >= 1)
            {
                MessageBox.Show("Saved Changes");
            }
            else
            {
                MessageBox.Show("Failed to Save Changes");
            }
            con.Close();
        }
    }


    static class Global
    {

        // the current loged in user can be used for things
        private static String _CurrentLoggedInUser = null;

        private static String _SelectedEnrolledClass= null;

        private static String _SelectedCurrentEnrolledClass= null;

        public static String CurrentLoggedInUser
        {
            get { return _CurrentLoggedInUser; }
            set { _CurrentLoggedInUser = value; }
        }
        public static String SelectedEnrolledClass
        {
            get { return _SelectedEnrolledClass; }
            set { _SelectedEnrolledClass = value; }
        }
        public static String SelectedCurrentEnrolledClass
        {
            get { return _SelectedCurrentEnrolledClass; }
            set { _SelectedCurrentEnrolledClass = value; }
        }

    }
}