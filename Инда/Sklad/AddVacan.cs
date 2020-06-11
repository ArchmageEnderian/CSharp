using Sklad;
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
    public partial class AddVacan : Form
    {
        public AddVacan()
        {
            InitializeComponent();
        }
        private void InsertStyle(MySqlConnection connection,string table, string id_vakansii, string doljnost, string oklad, string trebovaniya, string company, string region, string opisanie_raboti)
        {
            string sql = "INSERT" + " " + "INTO" + " " + table + " (`id_vakansii`, `Doljnost`, `Oklad`, `Trebovaniya`, `Company`, `Region`, `Opisanie_raboti`) " + "VALUES" + " ('" + id_vakansii + "', '" + doljnost + "', '" + oklad + "', '" + trebovaniya + "', '" + company + "', '" + region + "', '" + opisanie_raboti + "');";
            MySqlCommand command3 = new MySqlCommand(sql, connection);
            command3.ExecuteReader();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=inda;password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            DataBase.inform1 = textBox1.Text;
            DataBase.inform2 = textBox2.Text;
            DataBase.inform3 = textBox3.Text;
            DataBase.inform4 = textBox4.Text;
            DataBase.inform5 = textBox5.Text;
            DataBase.inform6 = textBox6.Text;
            DataBase.inform7 = textBox7.Text;
            InsertStyle(connection, "`vacansii`", DataBase.inform1, DataBase.inform2, DataBase.inform3, DataBase.inform4, DataBase.inform5, DataBase.inform6, DataBase.inform7);
            connection.Close();
            MessageBox.Show("Добавление успешно!", "Отлично!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            this.Close();
        }
        //INSERT INTO `vacansii` (`id_vakansii`, `Doljnost`, `Oklad`, `Trebovaniya`, `Company`, `Region`, `Opisanie_raboti`) VALUES ('34813', '485441', '150000', '15748', '1', 'Компсомолький', '841584');
    }
}
