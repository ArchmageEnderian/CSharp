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
    public partial class FindJobAlready : Form
    {
        public FindJobAlready()
        {
            InitializeComponent();
            Strtr();
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
            WriteStyle(ReaderStyle(" * ", "`vacansii`"));
            connection.Close();
            /*
            OpenServer();
            WriteStyle1(ReaderStyle("`id_vakansii`,`Doljnost`,`Oklad`,`Opisanie_raboti`", "`vacansii`"));
            //SELECT * FROM `vacansii`
            */
        }

        /*
        private void WriteStyle1(MySqlDataReader read)
        {
            while (read.Read())
            {
                dataGridView2.Rows.Add(read[0], read[1], read[2], read[3]);
            }
            read.Close();
        }
        */
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

        private void raeTdnApiR_Click(object sender, EventArgs e)
        {

        }
    }
}
