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
using System.Threading;

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
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.O)
            {
                SaveFile();
            }
            if (e.Key == Key.L)
            {
                LoadFile();
            }
        }
        private string sql;
        private bool factor = false;
        private int allID = 0;
        public static bool BOOLER = false;
        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Exit ex = new Exit();
            ex.Show();
        }
        private void BlueSide(object sender, RoutedEventArgs e)
        {
          factor = true;
        }
        private void SaveFile(object sender, RoutedEventArgs e)
        {
            SaveFile();
        }
        private void SaveFile()
        {
            MessageBox.Show("Успех! (В раазработке)", "Успех");
        }
        private void LoadFile()
        {
            MessageBox.Show("Успех! (В раазработке)", "Успех");
        }
        private void LoadFile(object sender, RoutedEventArgs e)
        {
            LoadFile();
        }
        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {
            popup1.IsOpen = true;
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
            
            /* Обнуление лишней строки */
            data.Remove("Выберете процессор");
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
                sql = "SELECT * FROM `processor` WHERE `Название` = " + '"' +stringer[0] + '"';
                MySqlCommand nextCommand = new MySqlCommand(sql, SQL_Class.connection);
                MySqlDataReader reader = nextCommand.ExecuteReader();
                while(reader.Read())
                {
                    allID = System.Convert.ToInt32(reader[0].ToString());
                }
            }

        }

        private void AboutMe(object sender, RoutedEventArgs e)
        {
            TY thx = new TY();
            thx.Show();
        }
        /* TY thx = new TY();
thx.Show(); */
    }
}
