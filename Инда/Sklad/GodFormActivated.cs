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
            Otmena.Hide();
            textBox2.Hide();
            label.Hide();
        }
        string SELECT = "SELECT";
        string WHERE = "WHERE";
        string FROM = "FROM";
        string JOIN = "JOIN";
        private void Strtr()
        {
            string connectionString = "server=localhost;user=root;database=inda;password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            WriteStyle( ReaderStyle(connection, "`Last_name`,`Name`,`Father_name`, `Doljnost`, `Oklad`, rezume.Info", "`soiskateli`", "`rezume` ON soiskateli.id_users = rezume.User") );
            connection.Close();
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
            string sql = SELECT + " " + "`Last_name`,`Name`,`Father_name`,`Doljnost`,`Oklad`,rezume.Info" + " " + FROM + " " + "`soiskateli`" + " " + JOIN + " " + "`rezume` ON soiskateli.id_users = rezume.User";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Strtr();
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Добавление вакансии в список вакансий
        }

        private void Take_Click(object sender, EventArgs e)
        {
            Add.Hide();
            Refresh.Hide();
            Otmena.Show();
            textBox2.Show();
            Take.Hide(); 
            yesbut.Show();
            label.Show();
        }

        private void yesbut_Click(object sender, EventArgs e)
        {

            int num = Convert.ToInt32(textBox2.Text);
            dataGridView1.Rows.RemoveAt(num - 1);

            //Функция удаления человека из базы

            MessageBox.Show("Собеседование назначено!", "Отлично!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            Add.Show();
            Refresh.Show();
            Take.Show();
            Otmena.Hide();
            textBox2.Hide();
            yesbut.Hide();
            label.Hide();
        }

        private void Otmena_Click(object sender, EventArgs e)
        {
            Add.Show();
            Refresh.Show();
            Take.Show();
            Otmena.Hide();
            textBox2.Hide();
            yesbut.Hide();
            label.Hide();
        }

        // SELECT `Last_name`,`Name`,`Father_name`, `Doljnost`, `Oklad`, rezume.Info FROM `soiskateli` JOIN `rezume` ON soiskateli.id_users = rezume.User
    }
}
