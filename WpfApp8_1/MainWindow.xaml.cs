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
            TimerBox.Text = Convert.ToString(GetTimer() + " сек.");
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
                if (string.IsNullOrWhiteSpace(login) && string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Введите логин и пароль!", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ResetTimer();
                    StartTimer();
                    return;
                }

                if (string.IsNullOrWhiteSpace(login))
                {
                    MessageBox.Show("Введите логин!", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ResetTimer();
                    StartTimer();
                    return;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Введите пароль!", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ResetTimer();
                    StartTimer();
                    return;
                }

                if (password.Length < 8)
                {
                    MessageBox.Show("Пароль не менее 8 символов!", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ResetTimer();
                    StartTimer();
                    password = string.Empty;
                    return;
                }

                if (password.Length > 32)
                {
                    MessageBox.Show("Пароль не больше 32 символов!", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ResetTimer();
                    StartTimer();
                    password = string.Empty;
                    return;
                }

                bool isLetter = false;
                bool isNumber = false;
                for (int i = 0; i < password.Length; i++)
                {
                    if ((password[i] >= 48 && password[i] <= 57) || password[i] >= 65 && password[i] <= 90 || password[i] >= 97 && password[i] <= 122) // проверка на разрешенные символы
                    {
                        if (password[i] >= 48 && password[i] <= 57)
                        {
                            isNumber = true;
                        }
                        if (password[i] >= 65 && password[i] <= 90 || password[i] >= 97 && password[i] <= 122)
                        {
                            isLetter = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пароль не должен содержать символы кроме цифр и латинского алфавита!", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                        ResetTimer();
                        StartTimer();
                        password = string.Empty;
                        return;
                    }
                }

                if (!isLetter)
                {
                    MessageBox.Show("Пароль не содержит букв!", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ResetTimer();
                    StartTimer();
                    password = string.Empty;
                    return;
                }

                if (!isNumber)
                {
                    MessageBox.Show("Пароль не содержит цифр!", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ResetTimer();
                    StartTimer();
                    password = string.Empty;
                    return;
                }


                // Имитация проверки данных в БД
                if (login == "admin" && password == "GG343430")
                {
                    MessageBox.Show($"Успешная авторизация, за {GetTimer()} секунд!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

                    GeneralWindow generalWindow = new GeneralWindow();
                    generalWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                    ResetTimer();
                    StartTimer();
                    password = string.Empty;
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
