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
    /// Логика взаимодействия для MainWindowManager.xaml
    /// </summary>
    public partial class MainWindowManager : Window
    {
        public MainWindowManager()
        {
            InitializeComponent();
        }

        private void ViewMaterialsMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ViewTeamsMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WorkCalendarMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ViewRequestsMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Authorization_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Hide();
        }
    }
}
