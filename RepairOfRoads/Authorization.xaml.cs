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
using System.Windows.Shapes;

namespace RepairOfRoads
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public RepairOfRoadsEntities db = new RepairOfRoadsEntities();
        public Authorization()
        {
            InitializeComponent();
            CurreintUser.id = 0;
        }

        private void AuthoButton_Click(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox.Text != "" && PasswordTextBox.Password != "")
            {
                Users users = db.Users.Where(x => x.login == UsernameTextBox.Text && x.password == PasswordTextBox.Password).FirstOrDefault();
                CurreintUser.id = users.iduser;
                if (users.idrole == 1)
                {
                    MainWindowUser mainWindowUser = new MainWindowUser();
                    mainWindowUser.Show();
                    this.Hide();
                }
                else if (users.idrole == 2)
                {
                    MainWindowEmployee mainWindowEmployee = new MainWindowEmployee();
                    mainWindowEmployee.Show();
                    this.Hide();
                }
                else if (users.idrole == 3)
                {
                    MainWindowDirector mainWindowDirector = new MainWindowDirector();
                    mainWindowDirector.Show();
                    this.Hide();
                }
                else if (users.idrole == 4)
                {
                    MainWindowManager mainWindowManager = new MainWindowManager();
                    mainWindowManager.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Данного пользователя нет");
                }
            }
            else
            {
                MessageBox.Show("Некоторые поля пустые");
            }
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }
    }
}
