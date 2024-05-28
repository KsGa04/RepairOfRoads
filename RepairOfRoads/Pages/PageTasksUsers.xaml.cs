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
    /// Логика взаимодействия для PageTasksUsers.xaml
    /// </summary>
    public partial class PageTasksUsers : Page
    {
        public RepairOfRoadsEntities db = new RepairOfRoadsEntities();
        List<UsersTask> tasks = new List<UsersTask>();
        public PageTasksUsers()
        {
            InitializeComponent();
            tasks = db.UsersTask.ToList();
            requestsDataGrid.ItemsSource = tasks;
        }

        private void AddPersonal_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.TaskUserPage(0));
        }

        private void EditPersonal_Click(object sender, RoutedEventArgs e)
        {
            if (requestsDataGrid.SelectedIndex >= 0)
            {
                var item = requestsDataGrid.SelectedItem as UsersTask;
                int id = item.id;
                NavigationService.Navigate(new TaskUserPage(id));
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
                var result = MessageBox.Show("Вы точно хотите удалить этого пользователя?", "Удалить", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    var item = requestsDataGrid.SelectedItem as UsersTask;
                    int id = item.id;
                    UsersTask materials = db.UsersTask.Where(x => x.id == id).FirstOrDefault();
                    db.UsersTask.Remove(materials);
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали ни один элемент");
            }
        }
    }
}
