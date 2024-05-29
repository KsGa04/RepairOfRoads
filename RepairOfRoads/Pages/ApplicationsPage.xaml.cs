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

namespace RepairOfRoads.Pages
{
    /// <summary>
    /// Логика взаимодействия для ApplicationsPage.xaml
    /// </summary>
    public partial class ApplicationsPage : Page
    {
        public RepairOfRoadsEntities db= new RepairOfRoadsEntities();
        public ApplicationsPage()
        {
            InitializeComponent();
            requestsDataGrid.ItemsSource = db.Requests.ToList();
        }

        private void AddPersonal_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.PageRequest(0));
        }

        private void EditPersonal_Click(object sender, RoutedEventArgs e)
        {
            if (requestsDataGrid.SelectedIndex >= 0)
            {
                var item = requestsDataGrid.SelectedItem as Requests;
                int id = item.idrequests;
                NavigationService.Navigate(new PageRequest(id));
            }
            else
            {
                MessageBox.Show("Вы не выбрали ни один элемент");
            }
        }

        private void DeletePersonal_Click(object sender, RoutedEventArgs e)
        {
            if (requestsDataGrid.SelectedIndex >= 0)
            {
                var result = MessageBox.Show("Вы точно хотите удалить эту заявку?", "Удалить", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    var item = requestsDataGrid.SelectedItem as Requests;
                    int id = item.idrequests;
                    Requests requests = db.Requests.Where(x => x.idrequests == id).FirstOrDefault();
                    db.Requests.Remove(requests);
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали ни один элемент");
            }
            requestsDataGrid.ItemsSource = db.Requests.ToList();
        }
    }
}
