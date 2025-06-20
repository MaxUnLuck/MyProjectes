﻿using System;
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
    /// Логика взаимодействия для WindowSewOrders.xaml
    /// </summary>
    public partial class WindowSewOrders : Window
    {
        public WindowSewOrders()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (!CountOfWindowControl.Singelton().EditOrder)
            {
                WindowEditOrder windowEditOrder = new WindowEditOrder();
                CountOfWindowControl.Singelton().EditOrder = true;
                windowEditOrder.Show();
            }
            else
            {
                MessageBox.Show("Данное окно уже открыто!", "Обовещение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void isClosed(object sender, EventArgs e)
        {
            CountOfWindowControl.Singelton().SewOrder = false;
        }
    }
}
