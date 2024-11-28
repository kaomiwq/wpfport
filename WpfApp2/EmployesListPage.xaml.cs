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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для EmployesListPage.xaml
    /// </summary>
    public partial class EmployesListPage : Page
    {
        public EmployesListPage()
        {
            InitializeComponent();
        }

       

        private void PortButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PortPage());
        }

        private void OrdersButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrdersPage());
        }

        private void AddEmployesButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEmployesPage());
        }
    }
}
