using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ErrorLabel.Hide();
            Starter(); 
        }
        public MySqlDataReader ReaderStyle(MySqlConnection connection, string postSelect, string postFrom)
        {
            string sql = SELECT + postSelect + FROM + postFrom;
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        string SELECT = "SELECT";
        string WHERE = "WHERE";
        string FROM = "FROM";
        public void Starter()
        {
            try
            {
                string connectionString = "server=localhost;user=root;database=inda;password=;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                connection.Close();
            }
            catch
            {
                label1.Hide();
                label2.Hide();
                label3.Hide();
                ErrorLabel.Show();
            }
        }

        private void God_Click(object sender, EventArgs e)
        {
            GodFormActivated god = new GodFormActivated();
            god.Show();
        }

        private void Rab_Click(object sender, EventArgs e)
        {
            /* В разработке */
        }
    }
   
}
