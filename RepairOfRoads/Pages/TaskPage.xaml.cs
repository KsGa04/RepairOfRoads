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
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class TaskPage : Page
    {
        public RepairOfRoadsEntities db = new RepairOfRoadsEntities();
        List<Task> tasks = new List<Task>();
        public TaskPage()
        {
            InitializeComponent();
            tasks = db.Task.ToList();
            TaskDataGrid.ItemsSource = tasks;

        }

        private void AddPersonal_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.PageTask(0));
        }

        private void EditPersonal_Click(object sender, RoutedEventArgs e)
        {
            if (TaskDataGrid.SelectedIndex >= 0)
            {
                var item = TaskDataGrid.SelectedItem as Task;
                int id = item.idTask;
                NavigationService.Navigate(new PageTask(id));
            }
            else
            {
                MessageBox.Show("Вы не выбрали ни один элемент");
            }
        }

        private void DeletePersonal_Click(object sender, RoutedEventArgs e)
        {
            if (TaskDataGrid.SelectedIndex >= 0)
            {
                var result = MessageBox.Show("Вы точно хотите удалить эту задачу?", "Удалить", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    var item = TaskDataGrid.SelectedItem as Task;
                    int id = item.idTask;
                    Task materials = db.Task.Where(x => x.idTask == id).FirstOrDefault();
                    db.Task.Remove(materials);
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
