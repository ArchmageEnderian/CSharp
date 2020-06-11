using MySql.Data.MySqlClient;
using BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sklad;

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
        string INSERT = "INSERT";
        string INTO = "INTO";
        string VALUES = "VALUES";
        private void OpenServer()
        {
            string connectionString = "server=localhost;user=root;database=inda;password=;";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }
        private void Strtr()
        {
            OpenServer();
            WriteStyle(ReaderStyle("`id_users`,`Last_name`,`Name`,`Father_name`,`Doljnost`,`Oklad`,rezume.Info", "`soiskateli`", "`rezume` ON soiskateli.id_users = rezume.User"));
            connection.Close();
            OpenServer();
            WriteStyle1(ReaderStyle("`id_vakansii`,`Doljnost`,`Oklad`,`Opisanie_raboti`" , "`vacansii`"));
            //SELECT `id_vakansii`,`Doljnost`,`Oklad`,`Opisanie_raboti` FROM `vacansii`WHERE `Company` = 1        
        }
        private void WriteStyle1(MySqlDataReader read)
        {
            while (read.Read())
            {
                dataGridView2.Rows.Add(read[0], read[1], read[2], read[3]);
            }
            read.Close();
        }
        private void WriteStyle(MySqlDataReader read)
        {
            while (read.Read())
            {
                dataGridView1.Rows.Add(read[0], read[1], read[2], read[3], read[4], read[5], read[6]);
            }
            read.Close();
        }
        private MySqlDataReader ReaderStyle(string postSelect, string postFrom)
        {
            string sql = SELECT + " " + postSelect + " " + FROM + " " + postFrom + " " + WHERE + " `Company` = 1";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        private MySqlDataReader ReaderStyle(string postSelect, string postFrom, string postJoin)
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
        /* Код для другой стороны
        private void InsertStyle(string table, string table1, string user, string doljnost, string oklad, string staj, string region, string graphic, string info1, string id_users, string last_name, string name, string father_name, string pol, string age, string pasport, string info)
        {
            //InsertStyle("`soiskateli`", "`rezume`", "'34813'", "'IT специалист'", "'150000'", "'0'", "'Компсомолький'", "'2-2'", "'16554'", "'034813'", "'Малахов'", "'Игорь'", "'Дмитриевич'", "'м'", "'20'", "'1111111111'", "'1685'");
            string sql1 = INSERT + " " + INTO + " " + table + " (`id_users`, `Last_name`, `Name`, `Father_name`, `Pol`, `Age`, `Pasport`, `Info`) " + VALUES + " (" + id_users + ", " + last_name + ", " + name + ", " + father_name + ", " + pol + ", " + age + ", " + pasport + ", " + info + ");";
            string sql2 = INSERT + " " + INTO + " " + table1 + " (`User`, `Doljnost`, `Oklad`, `Staj`, `Region`, `Graphic`, `Info`) " + VALUES + " (" + user + ", " + doljnost + ", " + oklad + ", " + staj + ", " + region + ", " + graphic + ", " + info1 + ");";
            MySqlCommand command3 = new MySqlCommand(sql1, connection);
            command3.ExecuteReader();
            //command3.EndExecuteReader();
            connection.Close();
            OpenServer();
            MySqlCommand command4 = new MySqlCommand(sql2, connection);
            command4.ExecuteReader();
        }
        */
        private void InsertStyle(string table, string id_vakansii, string doljnost, string oklad, string trebovaniya, string company, string region, string opisanie_raboti)
        {
            string sql = INSERT + " " + INTO + " " + table + " (`id_vakansii`, `Doljnost`, `Oklad`, `Trebovaniya`, `Company`, `Region`, `Opisanie_raboti`) " + VALUES + " (" + id_vakansii + ", " + doljnost + ", " + oklad + ", " + trebovaniya + ", " + company + ", " + region + ", " + opisanie_raboti + ");";
            MySqlCommand command3 = new MySqlCommand(sql, connection);
            command3.ExecuteReader();
        }
        private void RefresherOrb()
        {
            connection.Close();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            Strtr();
        }
        private void Refresh_Click(object sender, EventArgs e)
        {
            RefresherOrb();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            connection.Close();
            AddVacan addding = new AddVacan();
            addding.Show();
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
                string sql = "DELETE FROM `soiskateli` WHERE `soiskateli`.`id_users` = " + id.ToString();
                connection.Close();
                OpenServer();
                MySqlCommand command2 = new MySqlCommand(sql, connection);
                command2.ExecuteReader();
                MessageBox.Show("Собеседование назначено!", "Отлично!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                MessageBox.Show("ОШИБКА!", "ПЛОХО!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            RefresherOrb();
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
