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
    /// Логика взаимодействия для TaskUserPage.xaml
    /// </summary>
    public partial class TaskUserPage : Page
    {
        public RepairOfRoadsEntities db = new RepairOfRoadsEntities();
        UsersTask Task = new UsersTask();
        public int Id;
        public TaskUserPage(int id)
        {
            InitializeComponent();
            if (id != 0)
            {
                Id = id;
                Task = db.UsersTask.Where(x => x.id == id).FirstOrDefault();
                DataContext = Task;
            }
            foreach (var d in db.Task)
            {
                tasks.Items.Add(d.problemName);
            }
            foreach (var d in db.Users)
            {
                login.Items.Add(d.login);
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (Id != 0)
            {
                Task.idTask = tasks.SelectedIndex + 1;
                Task.idUser = login.SelectedIndex + 1;
            }
            else
            {
                UsersTask Task = new UsersTask();
                Task.idTask = tasks.SelectedIndex + 1;
                Task.idUser = login.SelectedIndex + 1;
                db.UsersTask.Add(Task);
            }
            db.SaveChanges();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.PageTasksUsers());
        }
    }
}
