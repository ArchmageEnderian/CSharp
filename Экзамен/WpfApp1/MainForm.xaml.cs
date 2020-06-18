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
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            /* НЕНУЖНАЯ ЧАСТЬ */
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
        private List<string> data1; 
        private List<string> data2;
        private List<string> data3;
        private List<string> data4;
        private List<string> data5;
        private List<string> data6;
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
            SQL_Class.SQL_OpenServer();
            data1 = new List<string>();
            ProcLabel.Background = Brushes.Red;
            data1.Add("Выберете процессор");
            var combo = sender as ComboBox;
            sql = "SELECT * FROM `processor`";
            MySqlCommand command = new MySqlCommand(sql, SQL_Class.connection);
            MySqlDataReader reader = command.ExecuteReader();
            combo.SelectedIndex = 0;
            while (reader.Read())
            {
                data1.Add(reader[1].ToString() + " " + reader[2].ToString());
            }
            combo.ItemsSource = data1;
            
            /* Обнуление лишней строки */
            data1.Remove("Выберете процессор");
            combo.ItemsSource = data1;  
            reader.Close();
            SQL_Class.SQL_CloseServer();
        }
        private void MatLoad(object sender, RoutedEventArgs e)
        {
            SQL_Class.SQL_OpenServer();
            data2 = new List<string>();
            data2.Add("Выберете материнскую плату");
            var combo = sender as ComboBox;
            sql = "SELECT * FROM `motherboard`";
            MySqlCommand command = new MySqlCommand(sql, SQL_Class.connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                data2.Add(reader[1].ToString() + " " + reader[2].ToString());
            }
            reader.Close();
            SQL_Class.SQL_CloseServer();
            combo.SelectedIndex = 0;
            combo.ItemsSource = data2;
            MatLabel.Background = Brushes.Red;
        }       
        private void VideoLoad(object sender, RoutedEventArgs e)
        {
            SQL_Class.SQL_OpenServer();
            data3 = new List<string>();
            data3.Add("Выберете видеокарту");
            var combo = sender as ComboBox;
            sql = "SELECT * FROM `videocard`";
            MySqlCommand command = new MySqlCommand(sql, SQL_Class.connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                data3.Add(reader[1].ToString() + " " + reader[2].ToString());
            }
            reader.Close();
            SQL_Class.SQL_CloseServer();
            combo.SelectedIndex = 0;
            combo.ItemsSource = data3;
            VideoLabel.Background = Brushes.Red;
        }
        private void OperLoad(object sender, RoutedEventArgs e)
        {
            SQL_Class.SQL_OpenServer();
            data4 = new List<string>();
            data4.Add("Выберете оперативную память");
            var combo = sender as ComboBox;
            sql = "SELECT * FROM `operativa`";
            MySqlCommand command = new MySqlCommand(sql, SQL_Class.connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                data4.Add(reader[1].ToString() + " " + reader[2].ToString());
            }
            reader.Close();
            SQL_Class.SQL_CloseServer();
            combo.SelectedIndex = 0;
            combo.ItemsSource = data4;
            OperLabel.Background = Brushes.Red;
        }
        private void HranLoad(object sender, RoutedEventArgs e)
        {
            SQL_Class.SQL_OpenServer();
            data5 = new List<string>();
            data5.Add("Выберете хранилище данных");
            var combo = sender as ComboBox;
            sql = "SELECT * FROM `hdd`";
            MySqlCommand command = new MySqlCommand(sql, SQL_Class.connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                data5.Add(reader[1].ToString() + " " + reader[2].ToString());
            }
            reader.Close();
            SQL_Class.SQL_CloseServer();
            combo.SelectedIndex = 0;
            combo.ItemsSource = data5;
            HranLabel.Background = Brushes.Red;
        }
        private void BlockLoad(object sender, RoutedEventArgs e)
        {
            SQL_Class.SQL_OpenServer();
            data6 = new List<string>();
            data6.Add("Выберете блок питания");
            var combo = sender as ComboBox;
            sql = "SELECT * FROM `power`";
            MySqlCommand command = new MySqlCommand(sql, SQL_Class.connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                data6.Add(reader[1].ToString() + " " + reader[2].ToString());
            }
            reader.Close();
            SQL_Class.SQL_CloseServer();
            combo.SelectedIndex = 0;
            combo.ItemsSource = data6;
            BlockLabel.Background = Brushes.Red;
        }
        private void SovmestReloader()
        {
            if(factor)
            {
                List<string> data6 = new List<string>();
                Sad.ItemsSource = data6;

            }

        }
        private void Proс_Selection(object sender, SelectionChangedEventArgs e)
        {
            string spname = "Выберете процессор";
            var selected = sender as ComboBox;
            if(!(spname == selected.SelectedItem as string))
            {
                string name = selected.SelectedItem as string;
                string[] stringer = name.Split(' ');
                if (factor)
                {
                    SQL_Class.SQL_OpenServer();
                    sql = "SELECT * FROM `processor` WHERE `Название` = " + '"' + stringer[0] + '"';
                    MySqlCommand nextCommand = new MySqlCommand(sql, SQL_Class.connection);
                    MySqlDataReader reader = nextCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        allID = System.Convert.ToInt32(reader[0].ToString());
                    }
                    reader.Close();
                    SQL_Class.SQL_CloseServer();
                }
                ProcLabel.Background = Brushes.Transparent;
            }
            SovmestReloader();
        }
        private void Mat_Selection(object sender, SelectionChangedEventArgs e)
        {
            /*
            List<string> dat11 = new List<string>();
            string spname = "Выберете материнскую плату";
            var selected = sender as ComboBox;
            if(!(spname == selected.SelectedItem as string))
            {
                if(factor)
                {
                    SQL_Class.SQL_OpenServer();
                    sql = "SELECT * FROM `motherboard` WHERE `id` = " + allID.ToString();
                    MySqlCommand nextCommand = new MySqlCommand(sql, SQL_Class.connection);
                    MySqlDataReader reader = nextCommand.ExecuteReader();
                    while (reader.Read())
                    {
                       dat11.Add(reader[1].ToString() + " " + reader[2].ToString());
                    }
                    reader.Close();
                    SQL_Class.SQL_CloseServer();
                    selected.SelectedIndex = 0;
                    selected.ItemsSource = dat11;
                }
            }
            */

        }

        private void Video_Selection(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Oper_Selection(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Hran_Selection(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Block_Selection(object sender, SelectionChangedEventArgs e)
        {

        }
        private void AboutMe(object sender, RoutedEventArgs e)
        {
            TY thx = new TY();
            thx.Show();
        }
        interface IFire 
        {
            void Fst();
            void Scnd();
            void Thrt();
        }
        class FireWorks : IFire 
        {
            public void Fst()
            {
                MessageBox.Show("Ба-бах", "Пиу");
            }
            public void Scnd()
            {
                MessageBox.Show("Ба-бах", "Пиу");
            }
            public void Thrt()
            {
                MessageBox.Show("Ба-бах", "Пиу");
            }
        }
        class ImpFireWorks : FireWorks 
        {
            public void NeverMore()
            {
                MessageBox.Show("Ба-бах-бах-бааах", "Пиу");
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IFire canonfire = new FireWorks();
            canonfire.Fst();
            canonfire.Scnd();
            canonfire.Thrt();
            ImpFireWorks newfire = new ImpFireWorks();
            newfire.NeverMore();
        }
    }
}
