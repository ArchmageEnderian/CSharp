using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Sklad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ErrorLabel.Hide();
            Starter(); 
        }
        string SELECT = "SELECT";
        string WHERE = "WHERE";
        string FROM = "FROM";
        private MySqlDataReader ReaderStyle(MySqlConnection connection, string postSelect, string postFrom)
        {
            string sql = SELECT + postSelect + FROM + postFrom;
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public void Starter()
        {
            try
            {
                string connectionString = "server=localhost;user=root;database=inda;password=;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch
            {
                label1.Hide();
                label2.Hide();
                label3.Hide();
                ErrorLabel.Show();
            }
            /*
            ReaderStyle(connection)
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0], reader[1], reader[2]);
            }
            reader.Close();
            */
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
