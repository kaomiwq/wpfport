using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using WpfApp2.DataBase;
using WpfApp2.Properties;

namespace WpfApp2
{
    public partial class AddEmployesPage : Page
    {
        private Data dataBase;
        public AddEmployesPage()
        {
            InitializeComponent();
            var dbContext = new ShipShipEntities();
            dataBase = new Data(dbContext);

        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OrdersButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrdersPage());
        }

        private void PortButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PortPage());
        }
        private void EmployesListButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployesListPage());
        }

        private async void AddEmployeButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameBox.Text;

            await dataBase.SaveStaff(name);
            NavigationService.Navigate(new EmployesPage());
        }
    }
}
