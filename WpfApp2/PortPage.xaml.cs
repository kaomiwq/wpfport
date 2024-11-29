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
using WpfApp2.Properties;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для PortPage.xaml
    /// </summary>
    public partial class PortPage : Page
    {
        public PortPage()
        {
            InitializeComponent();
            var data = Connect.conn.Ships.ToList();
            PortGrid.ItemsSource = data;
        }

        private void OrdersButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrdersPage());
        }

        private void EmployesButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployesPage());
        }
    }
}
