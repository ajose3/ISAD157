using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SOFT562Week18
{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        //Here, I have declared my table names to reference when using it later
        
        DataTable facebookUsers;

        DataTable facebookFriendships;

        DataTable messages;

        DataTable universities;

        DataTable workplace;

        //Marco's code for the connection to the MySqlDatabases

        string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";
        private void DatabaseForm_Load(object sender, EventArgs e)
        {          
            using (MySqlConnection connection =
                   new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ISAD157_AJose.facebook_users", connection);

                //facebookUsers is the reference to the table facebook_users from MySql

                facebookUsers = new DataTable();
                adapter.Fill(facebookUsers);      //Filling the table using the data from the facebook_users database

                dataGridViewFacebookUser.DataSource = facebookUsers;   //Displaying the database in the datagridview
            }

            using (MySqlConnection connection =
                   new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ISAD157_AJose.facebook_friendships", connection);

                //facebookFriendships is the reference to the table facebook_users from MySql

                facebookFriendships = new DataTable();
                adapter.Fill(facebookFriendships);      //Filling the table using the data from the facebook_friendships database

                dataGridViewFacebookFriendships.DataSource = facebookFriendships;   //Displaying the database in the datagridview
            }

            using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ISAD157_AJose.messages", connection);

                //messages is the reference to the table messages from MySql

                messages = new DataTable();
                adapter.Fill(messages);       //Filling the table using the data from the messages database

                dataGridViewMessages.DataSource = messages;     //Displaying the database in the datagridview

            }

            using (MySqlConnection connection =
                      new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ISAD157_AJose.universities", connection);

                //universities is the reference to the table universities from MySql

                universities = new DataTable();
                adapter.Fill(universities);     //Filling the table using the data from the universities database

                dataGridViewUniversities.DataSource = universities;    //Displaying the database in the datagridview

                //Reading each university in the university field from the database into the combobox
                foreach (DataRow DR in universities.Rows)
                {
                    uniComboBox.Items.Add(DR["university"].ToString());
                }
            }

            using (MySqlConnection connection =
                   new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ISAD157_AJose.workplace", connection);

                //workplace is the reference to the table facebook_users from MySql

                workplace = new DataTable();
                adapter.Fill(workplace);         //Filling the table using the data from the workplace database

                dataGridViewWorkplace.DataSource = workplace;    //Displaying the database in the datagridview

                //Reading each workplace in the workplace field from the database into the combobox
                foreach (DataRow DR in workplace.Rows)
                {
                    workComboBox.Items.Add(DR["workplace"].ToString());
                }
            }

        }
        
        //This is to close the window
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        //This is to search by User ID in all databases
        private void userIDbox_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(facebookUsers);                 //Creating new dataview in the facebookUsers table         
            DV.RowFilter = string.Format("CONVERT(user_id, System.String) like '%{0}%'", userIDbox.Text);  //Converted user_id from MySql Database to string because it was integer before and finds the row the user is searching for using the textbox
            dataGridViewFacebookUser.DataSource = DV;                  //Displays the filtered user ID to the user with the element they are searching for in the facebookUsers table

            DataView view = new DataView(facebookFriendships);           //Creating new dataview in the facebookFriendships table
            view.RowFilter = string.Format("Convert(userID_1, System.String) like '%{0}%'", userIDbox.Text);
            dataGridViewFacebookFriendships.DataSource = view;          //Displays the filtered user ID to the user with the element they are searching for in the facebookFriendships table
             
            DataView VD = new DataView(messages);                       //Creating new dataview in the messages table
            VD.RowFilter = string.Format("Convert(sender_id, System.String) like '%{0}%'", userIDbox.Text);
            dataGridViewMessages.DataSource = VD;                       //Displays the filtered user ID to the user with the element they are searching for in the messages table

            DataView search = new DataView(universities);               //Creating new dataview in the universities table
            search.RowFilter = string.Format("Convert(user_id, System.String) like '%{0}%'", userIDbox.Text);
            dataGridViewUniversities.DataSource = search;              //Displays the filtered user ID to the user with the element they are searching for in the universities table

            DataView data = new DataView(workplace);                   //Creating new dataview in the workplace table
            data.RowFilter = string.Format("Convert(user_id, System.String) like '%{0}%'", userIDbox.Text);
            dataGridViewWorkplace.DataSource = data;                  //Displays the filtered user ID to the user with the element they are searching for in the workplace table
        }

        //This is used to search by first name in the facebookUsers table
        private void firstNameBox_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(facebookUsers);                 //Creating new dataview in the facebookUsers table
            DV.RowFilter = string.Format("first_name LIKE '%{0}%'", firstNameBox.Text);  //Searches through first_name field using what the user has entered into the textbox
            dataGridViewFacebookUser.DataSource = DV;                  //Displays the filtered first name to the user with the element they are searching for in the facebookUsers table
        }

        //This is used to search by last name in the facebookUsers table
        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(facebookUsers);                 //Creating new dataview in the facebookUsers table
            DV.RowFilter = string.Format("last_name LIKE '%{0}%'", lastNameBox.Text);   //Searches through last_name field using what the user has entered into the textbox
            dataGridViewFacebookUser.DataSource = DV;                  //Displays the filtered last name to the user with the element they are searching for in the facebookUsers table
        }

        //This is used so the user can select a university to search in the universities table
        private void uniComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(universities);          //Creating new dataview in the universities table 

            if (uniComboBox.SelectedItem.ToString() == "All")  //This acts likes a reset button if the user selects "All"
            {
                dataGridViewUniversities.DataSource = universities;   //All universities are displayed
            }
            else
            {
                DV.RowFilter = string.Format("university LIKE '%{0}%'", uniComboBox.SelectedItem.ToString());  //Selecting a specific university
                dataGridViewUniversities.DataSource = DV;      //Displays all the records that go to that university
            }
        }

        //This is used so the user can select a workplace to search in the workplace table
        private void workComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(workplace);           //Creating new dataview in the workplace table

            if (workComboBox.SelectedItem.ToString() == "All")  //This acts likes a reset button if the user selects "All"
            {
                dataGridViewWorkplace.DataSource = workplace;      //All workplaces are displayed
            }
            else
            {
                DV.RowFilter = string.Format("workplace LIKE '%{0}%'", workComboBox.SelectedItem.ToString());    //Selecting a specific workplace
                dataGridViewWorkplace.DataSource = DV;           //Displays all the records that are in that workplace
            }
        }
    }
}
