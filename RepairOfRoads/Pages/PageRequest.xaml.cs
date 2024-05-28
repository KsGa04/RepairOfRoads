using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для PageRequest.xaml
    /// </summary>
    public partial class PageRequest : Page
    {
        public RepairOfRoadsEntities db = new RepairOfRoadsEntities();
        Requests Requests = new Requests();
        public int Id;
        public PageRequest(int id)
        {
            InitializeComponent();
            if (id != 0)
            {
                Id = id;
                Requests = db.Requests.Where(x => x.idrequests == id).FirstOrDefault();
                DataContext = Requests;
            }
            foreach (var d in db.StatusRequest)
            {
                status.Items.Add(d.namestatus);
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (Id != 0)
            {
                Requests.problemName = problem.Text;
                Requests.idStatus = status.SelectedIndex + 1;
            }
            else
            {
                Requests Requests = new Requests();
                Requests.problemName = problem.Text;
                Requests.idStatus = status.SelectedIndex + 1;
                db.Requests.Add(Requests);
            }
            db.SaveChanges();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.ApplicationsPage());
        }
    }
}
