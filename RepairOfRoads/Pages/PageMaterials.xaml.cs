using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для PageMaterials.xaml
    /// </summary>
    public partial class PageMaterials : Page
    {
        public RepairOfRoadsEntities db = new RepairOfRoadsEntities();
        Materials Materials = new Materials();
        public int Id;
        public PageMaterials(int id)
        {
            InitializeComponent();
            if (id != 0)
            {
                Id = id;
                Materials = db.Materials.Where(x => x.idmaterials == id).FirstOrDefault();
                DataContext = Materials;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (Id != 0)
            {
                Materials.nameMaterials = name.Text;
                Materials.countMaterials = Convert.ToInt32(count.Text);
            }
            else
            {
                Materials Materials = new Materials();
                Materials.nameMaterials = name.Text;
                Materials.countMaterials = Convert.ToInt32(count.Text);
                db.Materials.Add(Materials);
            }
            db.SaveChanges();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.MaterialPage());
        }
    }
}
