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
    /// Логика взаимодействия для OpenSaveLoad.xaml
    /// </summary>
    public partial class OpenSaveLoad : Window
    {
        public OpenSaveLoad()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string sql = "";
            GlobalDataBase.OSLid = Convert.ToInt32(OSLtextBox.Text);
            SQL_Class.SQL_OpenServer();
            if(GlobalDataBase.OSLCh == 1)
            {
                sql = "INSERT INTO `savedfiles` (`id`, `Процессор`, `Материнская плата`, `Видеокарта`, `Оперативная память`, `Хранилище`, `Блок питания`) VALUES ('" + GlobalDataBase.OSLid + "', '" + GlobalDataBase.pr + "', '" + GlobalDataBase.mat + "', '" + GlobalDataBase.vid + "', '" + GlobalDataBase.op + "', '" + GlobalDataBase.hdd + "', '" + GlobalDataBase.pow + "');";
                MySqlCommand command11 = new MySqlCommand(sql, SQL_Class.connection);
                MessageBox.Show("Успех! (В раазработке)", "Успех");
            }
            /*
            if (GlobalDataBase.OSLCh == 1)
            {
                sql = "SELECT * FROM `savedfiles` WHERE " + GlobalDataBase.OSLid;
                MySqlCommand command11 = new MySqlCommand(sql, SQL_Class.connection);
                MySqlDataReader reader11 = command11.ExecuteReader();
                while(reader11.Read())
                {
                    GlobalDataBase.pr = reader11[1].ToString();
                    GlobalDataBase.mat = reader11[2].ToString();
                    GlobalDataBase.vid = reader11[3].ToString();
                    GlobalDataBase.op = reader11[4].ToString();
                    GlobalDataBase.hdd = reader11[5].ToString();
                    GlobalDataBase.pow = reader11[6].ToString();
                }
            }
            */
            this.Close();
        }
    }
}
