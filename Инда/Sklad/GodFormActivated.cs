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
        MySqlConnection connection;
        string SELECT = "SELECT";
        string WHERE = "WHERE";
        string FROM = "FROM";
        string JOIN = "JOIN";
        string DELETE = "DELETE";
        private void OpenServer()
        {
            string connectionString = "server=localhost;user=root;database=inda;password=;";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }
        private void Strtr()
        {
            OpenServer();
            WriteStyle( ReaderStyle(connection, "`id_users`,`Last_name`,`Name`,`Father_name`,`Doljnost`,`Oklad`,rezume.Info", "`soiskateli`", "`rezume` ON soiskateli.id_users = rezume.User") );
            //connection.Close();
        }
        private void WriteStyle(MySqlDataReader read)
        {
            while (read.Read())
            {
                dataGridView1.Rows.Add(read[0], read[1], read[2], read[3], read[4], read[5], read[6]);
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
            string sql = SELECT + " " + postSelect + " " + FROM + " " + postFrom + " " + JOIN + " " + postJoin;
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        private void DeleterStyle(MySqlConnection connection, int idDel, string postFrom, string postWhere, string postFrom1, string postWhere1)
        {
            string sql = DELETE + " " + FROM + " " + postFrom + " " + WHERE + " " + postWhere + " " + idDel.ToString();
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.ExecuteReader();
        }
        private void Refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Strtr();
            
        }
        private void Add_Click(object sender, EventArgs e)
        {
            // INSERT INTO `rezume` (`User`, `Doljnost`, `Oklad`, `Staj`, `Region`, `Graphic`, `Info`) VALUES ('34813', 'IT специалист', '150000', '0', 'Компсомолький', '2-2', '16554');
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

            int id = Convert.ToInt32(textBox2.Text);
            try
            {
                DeleterStyle(connection, id, "`rezume`", "`User` =", "`soiskateli`", "`id_users` =");
                //string sql = DELETE + " " + FROM + " " + postFrom1 + " " + WHERE + " " + postWhere1 + " " + idDel.ToString();
                connection.Close();
                OpenServer();
                MySqlCommand command2 = new MySqlCommand("DELETE FROM `soiskateli` WHERE `soiskateli`.`id_users` = 34813", connection);
                command2.ExecuteReader();
                MessageBox.Show("Собеседование назначено!", "Отлично!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                MessageBox.Show("ОШИБКА!", "ПЛОХО!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            //dataGridView1.Rows.RemoveAt();

            /*  DELETE FROM `rezume` WHERE `User` = 34813
                DELETE FROM `soiskateli` WHERE `soiskateli`.`id_users` = 34813 */

            //Функция удаления человека из базы

        
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
