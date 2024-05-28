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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public RepairOfRoadsEntities db = new RepairOfRoadsEntities();
        public Registration()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox.Text != "" && PasswordTextBox.Password != "")
            {
                Users users = new Users();
                users.login = UsernameTextBox.Text;
                users.password = PasswordTextBox.Password;
                users.idrole = 1;
                db.Users.Add(users);
                db.SaveChanges();

                Authorization authorization = new Authorization();
                authorization.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Заполнены не все данные");
            }
            
        }

        private void AuthoButton_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Hide();
        }
    }
}
