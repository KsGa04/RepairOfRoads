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
    /// Логика взаимодействия для PageTask.xaml
    /// </summary>
    public partial class PageTask : Page
    {
        public RepairOfRoadsEntities db = new RepairOfRoadsEntities();
        Task Task = new Task();
        public int Id;
        public PageTask(int id)
        {
            InitializeComponent();
            if (id != 0)
            {
                Id = id;
                Task = db.Task.Where(x => x.idTask == id).FirstOrDefault();
                DataContext = Task;
            }
            foreach (var d in db.StatusTask)
            {
                status.Items.Add(d.namestatus);
            }
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (Id != 0)
            {
                Task.problemName = problem.Text;
                Task.idStatus = status.SelectedIndex + 1;
                Task.dateStart = (DateTime)dateStart.SelectedDate;
                Task.dateEnd = (DateTime)dateEnd.SelectedDate;
            }
            else
            {
                Task Task = new Task();
                Task.problemName = problem.Text;
                Task.idStatus = status.SelectedIndex + 1;
                Task.dateStart = (DateTime)dateStart.SelectedDate;
                Task.dateEnd = (DateTime)dateEnd.SelectedDate;
                db.Task.Add(Task);
                MaterialsTask materialsTask1 = new MaterialsTask();
                materialsTask1.idTask = Task.idTask;
                materialsTask1.idmaterials = 1;
                db.MaterialsTask.Add(materialsTask1);

                MaterialsTask materialsTask2 = new MaterialsTask();
                materialsTask2.idTask = Task.idTask;
                materialsTask2.idmaterials = 2;
                db.MaterialsTask.Add(materialsTask2);

                MaterialsTask materialsTask3 = new MaterialsTask();
                materialsTask3.idTask = Task.idTask;
                materialsTask3.idmaterials = 3;
                db.MaterialsTask.Add(materialsTask3);

                MaterialsTask materialsTask4 = new MaterialsTask();
                materialsTask4.idTask = Task.idTask;
                materialsTask4.idmaterials = 4;
                db.MaterialsTask.Add(materialsTask4);

                MaterialsTask materialsTask5 = new MaterialsTask();
                materialsTask5.idTask = Task.idTask;
                materialsTask5.idmaterials = 5;
                db.MaterialsTask.Add(materialsTask5);
            }
            db.SaveChanges();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.TaskPage());
        }
    }
}
