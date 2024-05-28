﻿using System;
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

namespace RepairOfRoads
{
    /// <summary>
    /// Логика взаимодействия для MainWindowUser.xaml
    /// </summary>
    public partial class MainWindowUser : Window
    {
        public MainWindowUser()
        {
            InitializeComponent();
            MainFrame.Navigate(new Pages.CreateRequest());
        }

        private void Authorization_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Hide();
        }

        private void ViewRequestsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.CreateRequest());
        }
    }
}
