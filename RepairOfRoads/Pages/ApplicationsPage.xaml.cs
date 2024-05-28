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

        }

        private void EditPersonal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeletePersonal_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
