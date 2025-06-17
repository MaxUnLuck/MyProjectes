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
    /// Логика взаимодействия для WindowEditOrder.xaml
    /// </summary>
    public partial class WindowEditOrder : Window
    {
        public WindowEditOrder()
        {
            InitializeComponent();
        }

        private void AcceptButton_Копировать_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void isClosed(object sender, EventArgs e)
        {
            CountOfWindowControl.Singelton().EditOrder = false;
        }
    }
}
