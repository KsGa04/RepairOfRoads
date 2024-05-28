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
    /// Логика взаимодействия для CertainUserTask.xaml
    /// </summary>
    public partial class CertainUserTask : Page
    {
        public RepairOfRoadsEntities db = new RepairOfRoadsEntities();
        List<UsersTask> tasks = new List<UsersTask>();
        public CertainUserTask()
        {
            InitializeComponent();
            tasks = db.UsersTask.Where(x => x.idUser == CurreintUser.id).ToList();
            requestsDataGrid.ItemsSource = tasks;
        }
    }
}
