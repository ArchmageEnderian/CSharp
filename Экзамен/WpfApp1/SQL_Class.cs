using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    static class SQL_Class
    {
        public static string connectionString = "server=localhost;user=root;database=inda;password=0000;";
        public static MySqlConnection connection;

        public static void SQL_Starter()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }
    }
}
