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

namespace RepairOfRoads
{
    /// <summary>
    /// Логика взаимодействия для MainWindowDirector.xaml
    /// </summary>
    public partial class MainWindowDirector : Window
    {
        public MainWindowDirector()
        {
            InitializeComponent();
            MainFrame.Navigate(new Pages.ApplicationsPage());
        }

        private void ViewRequestsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.ApplicationsPage());
        }

        private void ViewTasksMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.TaskPage());
        }

        private void ViewPersonnelMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.PersonalPage());
        }

        private void Authorization_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Hide();
        }

        private void ViewTaskUsersMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.PageTasksUsers());
        }

        private void WorkCalendarMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.CalendarPage());
        }
    }
}
