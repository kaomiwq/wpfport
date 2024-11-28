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
    /// Логика взаимодействия для EmployesPage.xaml
    /// </summary>
    public partial class EmployesPage : Page
    {
        public EmployesPage()
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


        private void AddEmployeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEmployesPage());
        }

        private void EmployesListButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployesListPage());
        }
    }
}
