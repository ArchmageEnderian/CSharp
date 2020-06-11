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

namespace Sklad
{
    public partial class FJAdd : Form
    {
        public FJAdd()
        {
            InitializeComponent();
        }
        private void InsertStyle(MySqlConnection connection, string table, string User, string doljnost, string oklad, string Staj, string Region, string Graphic, string Info)
        {
            string sql = "INSERT" + " " + "INTO" + " " + table + " (`User`, `Doljnost`, `Oklad`, `Staj`, `Region`, `Graphic`, `Info`) " + "VALUES" + " ('" + User + "', '" + doljnost + "', '" + oklad + "', '" + Staj + "', '" + Region + "', '" + Graphic + "', '" + Info + "');";
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
            InsertStyle(connection, "`rezume`", DataBase.inform1, DataBase.inform2, DataBase.inform3, DataBase.inform4, DataBase.inform5, DataBase.inform6, DataBase.inform7);
            connection.Close();
            MessageBox.Show("Создание успешно!", "Отлично!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            this.Close();
        }
    }
}
