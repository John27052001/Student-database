using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            var password = "Doomguy2";

            // construction the connection string
            var conString = "Server=localhost;database=" + db + ";uid=" + uid + ";password=" + password + ";";

            // returngin it
            return conString;

        }

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
                    LoginPage.Visible = false;

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


        // setting up the Other pages
        private void InitalizeMainPage()
        {

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


                WelcomeBlurb.Text = "Welcome " + reader[2] + " " + reader[3] + "\nPhoneNumb: " + reader[4].ToString() + "\nDOB: " + reader[4].ToString() + "\nGender: "+reader[6];


            }

        }
    }


    static class Global
    {

        // the current loged in user can be used for things
        private static String _CurrentLoggedInUser = null;

        public static String CurrentLoggedInUser
        {
            get { return _CurrentLoggedInUser; }
            set { _CurrentLoggedInUser = value; }
        }

    }
}