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
    /// Логика взаимодействия для AddEmployesPage.xaml
    /// </summary>
    public partial class AddEmployesPage : Page
    {
        public AddEmployesPage()
        {
            InitializeComponent();
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

        private void AddEmployeButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameBox.Text;
            string post = PostBox.Text;
            string phoneNumber = PhoneNumberBox.Text;

            if (name.Length > 30 && name.Length < 2 && post.Length <= 0 && phoneNumber.Length <= 0)
            {
                NameBox.ToolTip = "Поле введенно некоректно!";
                NameBox.Background = Brushes.DarkRed;
            }
            else {
                NameBox.ToolTip = "";
                NameBox.Background = Brushes.Transparent;
                PostBox.ToolTip = "";
                PostBox.Background = Brushes.Transparent;
                PhoneNumberBox.ToolTip = "";
                PhoneNumberBox.Background = Brushes.Transparent;

                MessageBox.Show("Сотрудник внесен в базу данных!");
            }
        }
    }
}
