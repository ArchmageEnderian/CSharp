using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainForm.xaml
    /// </summary>
    public partial class MainForm : Window
    {
        public MainForm()
        {
            InitializeComponent();
            SQL_Class.SQL_OpenServer();
        }
        private string sql;
        private bool factor = false;
        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void BlueSide(object sender, RoutedEventArgs e)
        {
          factor = true;
        }
        private void SaveFile(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void ProcLoad(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("Выберете процессор");
            var combo = sender as ComboBox;
            sql = "SELECT * FROM `processor`";
            MySqlCommand command = new MySqlCommand(sql, SQL_Class.connection);
            MySqlDataReader reader = command.ExecuteReader();
            combo.SelectedIndex = 0;
            while (reader.Read())
            {
                data.Add(reader[1].ToString() + " " + reader[2].ToString());
            }
            combo.ItemsSource = data;
            reader.Close();
        }

        private void Proс_Selection(object sender, SelectionChangedEventArgs e)
        {
            var selected = sender as ComboBox;
            string name = selected.SelectedItem as string;
            string[] stringer = name.Split(' ');
            if (factor)
            {
                sql = "SELECT * FROM `processor` WHERE " + stringer[0];
                MySqlCommand nextCommand = new MySqlCommand(sql, SQL_Class.connection);
                MySqlDataReader reader = nextCommand.ExecuteReader(); 
            }

        }
        /* TY thx = new TY();
thx.Show(); */
    }
}
