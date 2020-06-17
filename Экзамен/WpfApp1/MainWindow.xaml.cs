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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Starter_Click(object sender, RoutedEventArgs e)
        {
            SQL_Class.SQL_Starter();
            if (SQL_Class.OPENED)
            {
                MainForm forma = new MainForm();
                forma.Show();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
