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

namespace Wpfkalgin
{
    /// <summary>
    /// Логика взаимодействия для Task5.xaml
    /// </summary>
    public partial class Task5 : Window
    {
        public Task5()
        {
            InitializeComponent();
        }

        private void abc51_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, c;
            int x = new Random().Next(0, 5);
            //1
            a = 4.2;
            b = 5.3;
            c = 1.5;

            if (Math.Exp(a+b)>Math.Exp(x))
            {
                y = Math.Sin(Math.Exp(a + b)) + Math.Pow(x, 2);
            }
            else if (Math.Exp(a + b)==Math.Exp(x))
            {
                y = Math.Atan(a * b * c) + Math.Pow(x, 1 / 3);
            }
            else if (Math.Exp(a + b) < Math.Exp(x))
            {
                y = Math.Cos(Math.Sqrt(Math.Abs(x + a * b * c)));
            }
            MessageBox.Show($" y = {y}", "Задание №5", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abc52_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, c;
            int x = new Random().Next(0, 5);
            //2
            a = -0.35;
            b = 1.8;
            c = -1.8;

            if (Math.Exp(a + b) > Math.Exp(x))
            {
                y = Math.Sin(Math.Exp(a + b)) + Math.Pow(x, 2);
            }
            else if (Math.Exp(a + b) == Math.Exp(x))
            {
                y = Math.Atan(a * b * c) + Math.Pow(x, 1 / 3);
            }
            else if (Math.Exp(a + b) < Math.Exp(x))
            {
                y = Math.Cos(Math.Sqrt(Math.Abs(x + a * b * c)));
            }
            MessageBox.Show($" y = {y}", "Задание №5", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abc53_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, c;
            int x = new Random().Next(0, 5);
            //3
            a = 2.8;
            b = -0.6;
            c = 2.0;

            if (Math.Exp(a + b) > Math.Exp(x))
            {
                y = Math.Sin(Math.Exp(a + b)) + Math.Pow(x, 2);
            }
            else if (Math.Exp(a + b) == Math.Exp(x))
            {
                y = Math.Atan(a * b * c) + Math.Pow(x, 1 / 3);
            }
            else if (Math.Exp(a + b) < Math.Exp(x))
            {
                y = Math.Cos(Math.Sqrt(Math.Abs(x + a * b * c)));
            }
            MessageBox.Show($" y = {y}", "Задание №5", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Backtotasks_Click(object sender, RoutedEventArgs e)
        {
            new TasksWindow().Show();
            Close();
        }
    }
}
