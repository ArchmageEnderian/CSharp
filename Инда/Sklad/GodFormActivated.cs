using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class GodFormActivated : Form
    {
        public GodFormActivated()
        {
            InitializeComponent();
            Strtr();
        }
        string SELECT = "SELECT";
        string WHERE = "WHERE";
        string FROM = "FROM";
        private void Strtr()
        {
            string connectionString = "server=localhost;user=root;database=inda;password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            WriteStyle( ReaderStyle(connection, "`Last_name`,`Name`,`Father_name`, `Doljnost`, `Oklad`, rezume.Info", "`soiskateli`", "`rezume` ON soiskateli.id_users = rezume.User") );
         }
        private void WriteStyle(MySqlDataReader read)
        {
            while (read.Read())
            {
                dataGridView1.Rows.Add(read[0], read[1], read[2], read[3], read[4], read[5]);
            }
            read.Close();
        }
        private MySqlDataReader ReaderStyle(MySqlConnection connection, string postSelect, string postFrom)
        {
            string sql = SELECT + " " + postSelect + " " + FROM + " " + postFrom;
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        private MySqlDataReader ReaderStyle(MySqlConnection connection, string postSelect, string postFrom, string postJoin)
        {
            string sql = "SELECT `Last_name`,`Name`,`Father_name`, `Doljnost`, `Oklad`, rezume.Info FROM `soiskateli` JOIN `rezume` ON soiskateli.id_users = rezume.User";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        // SELECT `Last_name`,`Name`,`Father_name`, `Doljnost`, `Oklad`, rezume.Info FROM `soiskateli` JOIN `rezume` ON soiskateli.id_users = rezume.User
    }
}
