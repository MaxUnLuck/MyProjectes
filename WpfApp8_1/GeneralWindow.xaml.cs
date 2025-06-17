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
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void MenuSewOrder_Click(object sender, RoutedEventArgs e)
        {
            WindowSewOrders windowSewOrders = new WindowSewOrders();
            windowSewOrders.Show();
        }

        private void MenuCreateOrder_Click(object sender, RoutedEventArgs e)
        {
            CreateOrderWindow windowCreateOrder = new CreateOrderWindow();
            windowCreateOrder.Show();
        }

        private void MenuAboutProgram_Click(object sender, RoutedEventArgs e)
        {
            AboutProgramWindow windowAboutProgram = new AboutProgramWindow();
            windowAboutProgram.Show();
        }

        private void MenuAdministration_Click(object sender, RoutedEventArgs e)
        {
            AdminUserControlWindow windowAdminUserControl = new AdminUserControlWindow();
            windowAdminUserControl.Show();
        }

        private void TotalExit(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
