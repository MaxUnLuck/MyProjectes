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

namespace WpfApp8_1
{
    /// <summary>
    /// Логика взаимодействия для GeneralWindow.xaml
    /// </summary>
    public partial class GeneralWindow : Window
    {
        public GeneralWindow()
        {
            InitializeComponent();
            CountOfWindowControl.Singelton();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void MenuSewOrder_Click(object sender, RoutedEventArgs e)
        {
            if (!CountOfWindowControl.Singelton().SewOrder)
            {
                WindowSewOrders windowSewOrders = new WindowSewOrders();
                CountOfWindowControl.Singelton().SewOrder = true;
                windowSewOrders.Show();
            }
            else
            {
                MessageBox.Show("Данное окно уже открыто!", "Обовещение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void MenuCreateOrder_Click(object sender, RoutedEventArgs e)
        {
            if (!CountOfWindowControl.Singelton().CreateOrder)
            {
                CreateOrderWindow windowCreateOrder = new CreateOrderWindow();
                CountOfWindowControl.Singelton().CreateOrder = true;
                windowCreateOrder.Show();
            }
            else
            {
                MessageBox.Show("Данное окно уже открыто!", "Обовещение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void MenuAboutProgram_Click(object sender, RoutedEventArgs e)
        {
            if (!CountOfWindowControl.Singelton().AboutProgram)
            {
                AboutProgramWindow windowAboutProgram = new AboutProgramWindow();
                CountOfWindowControl.Singelton().AboutProgram = true;
                windowAboutProgram.Show();
            }
            else
            {
                MessageBox.Show("Данное окно уже открыто!", "Обовещение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void MenuAdministration_Click(object sender, RoutedEventArgs e)
        {
            if (!CountOfWindowControl.Singelton().AdminUserControl)
            {
                AdminUserControlWindow windowAdminUserControl = new AdminUserControlWindow();
                CountOfWindowControl.Singelton().AdminUserControl = true;
                windowAdminUserControl.Show();
            }
            else
            {
                MessageBox.Show("Данное окно уже открыто!", "Обовещение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void TotalExit(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
