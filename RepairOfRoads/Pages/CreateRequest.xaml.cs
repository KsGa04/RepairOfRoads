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
    /// Логика взаимодействия для CreateRequest.xaml
    /// </summary>
    public partial class CreateRequest : Page
    {
        public RepairOfRoadsEntities db = new RepairOfRoadsEntities();
        public CreateRequest()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (problem.Text != "")
            {
                Requests requests = new Requests();
                requests.problemName = problem.Text;
                db.Requests.Add(requests);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Полня пустые");
            }
            
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            problem.Text = string.Empty;
        }
    }
}
