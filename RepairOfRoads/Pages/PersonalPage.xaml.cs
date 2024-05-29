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
    /// Логика взаимодействия для PersonalPage.xaml
    /// </summary>
    public partial class PersonalPage : Page
    {
        public RepairOfRoadsEntities db = new RepairOfRoadsEntities();
        List<Users> Users = new List<Users>();
        public PersonalPage()
        {
            InitializeComponent();
            Users = db.Users.ToList();
            usersDataGrid.ItemsSource = Users;
        }

        private void AddPersonal_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.PagePerson(0));
        }

        private void EditPersonal_Click(object sender, RoutedEventArgs e)
        {
            if (usersDataGrid.SelectedIndex >= 0)
            {
                var item = usersDataGrid.SelectedItem as Users;
                int id = item.iduser;
                NavigationService.Navigate(new PagePerson(id));
            }
            else
            {
                MessageBox.Show("Вы не выбрали ни один элемент");
            }
        }

        private void DeletePersonal_Click(object sender, RoutedEventArgs e)
        {
            if (usersDataGrid.SelectedIndex >= 0)
            {
                var result = MessageBox.Show("Вы точно хотите удалить этого пользователя?", "Удалить", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    var item = usersDataGrid.SelectedItem as Users;
                    int id = item.iduser;
                    Users materials = db.Users.Where(x => x.iduser == id).FirstOrDefault();
                    db.Users.Remove(materials);
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали ни один элемент");
            }
            usersDataGrid.ItemsSource = db.Users.ToList();
        }

    }
}
