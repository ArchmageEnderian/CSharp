﻿using MySql.Data.MySqlClient;
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
        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void BlueSide(object sender, RoutedEventArgs e)
        {
            
            
        }
        private void SaveFile(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void ProcLoad(object sender, RoutedEventArgs e)
        {
            var combo = sender as ComboBox;

        }
        /* TY thx = new TY();
   thx.Show(); */
    }
}
