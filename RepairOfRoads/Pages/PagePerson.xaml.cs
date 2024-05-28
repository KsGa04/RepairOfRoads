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
using System.Xml.Linq;

namespace RepairOfRoads.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePerson.xaml
    /// </summary>
    public partial class PagePerson : Page
    {
        public RepairOfRoadsEntities db = new RepairOfRoadsEntities();
        Users Users = new Users();
        public int Id;
        public PagePerson(int id)
        {
            InitializeComponent();
            if (id != 0)
            {
                Id = id;
                Users = db.Users.Where(x => x.iduser == id).FirstOrDefault();
                DataContext = Users;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (Id != 0)
            {
                Users.login = login.Text;
                Users.password =pass.Text;
                Users.idrole = role.SelectedIndex + 1;
            }
            else
            {
                Users Users = new Users();
                Users.login = login.Text;
                Users.password = pass.Text;
                Users.idrole = role.SelectedIndex + 1;
                db.Users.Add(Users);
            }
            db.SaveChanges();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.PersonalPage());
        }
    }
}
