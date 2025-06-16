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
using System.Diagnostics;
using System.Windows.Threading;

namespace WpfApp8_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        Stopwatch stopwatch = new Stopwatch();
        public void StartTimer()
        {
            stopwatch.Start();
        }
        public TimeSpan StopTimer()
        {
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }
        public TimeSpan ResetTimer()
        {
            stopwatch.Reset();
            return stopwatch.Elapsed;
        }
        public int GetTimer()
        {
            return Convert.ToInt32(stopwatch.ElapsedMilliseconds / 1000);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimerBox.Text = Convert.ToString(GetTimer());
        }
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;  // Метод, который будет вызываться при каждом тике таймера  
            timer.Start();  // Запуск таймера
            StartTimer();
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(StopTimer() > TimeSpan.FromSeconds(60))
                {
                    MessageBox.Show("Вы регестрировались больше минуты, повторите попытку!", "Отказано!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ResetTimer();
                    StartTimer();
                    return;
                }
                // Имитация задержки подключения к БД
                System.Threading.Thread.Sleep(1000);
                string login = LoginBox.Text;
                string password = PasswordBox.Password;

                // Проверка на пустые поля
                if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Введите логин и пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ResetTimer();
                    StartTimer();
                    return;
                }

                // Имитация проверки данных в БД
                if (login == "admin" && password == "12345")
                {
                    MessageBox.Show($"Успешная авторизация, за {GetTimer()} секунд!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

                    GeneralWindow generalWindow = new GeneralWindow();
                    generalWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    ResetTimer();
                    StartTimer();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных!\n{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                ResetTimer();
                StartTimer();
            }
        }
    }
}
