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
    /// Логика взаимодействия для MaterialPage.xaml
    /// </summary>
    public partial class MaterialPage : Page
    {
        public RepairOfRoadsEntities db = new RepairOfRoadsEntities();
        public MaterialPage()
        {
            InitializeComponent();
            materialsDataGrid.ItemsSource = db.Materials.ToList();
        }


        private void AddPersonal_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.WindowMaterials(0));
        }

        private void EditPersonal_Click(object sender, RoutedEventArgs e)
        {
            if (materialsDataGrid.SelectedIndex >= 0)
            {
                var item = materialsDataGrid.SelectedItem as Materials;
                int id = item.idmaterials;
                NavigationService.Navigate(new WindowMaterials(id));
            }
            else
            {
                MessageBox.Show("Вы не выбрали ни один элемент");
            }
        }

        private void DeletePersonal_Click(object sender, RoutedEventArgs e)
        {
            if (materialsDataGrid.SelectedIndex >= 0)
            {
                var result = MessageBox.Show("Вы точно хотите удалить этот материал?", "Удалить", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    var item = materialsDataGrid.SelectedItem as Materials;
                    int id = item.idmaterials;
                    Materials materials = db.Materials.Where(x => x.idmaterials == id).FirstOrDefault();
                    db.Materials.Remove(materials);
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
