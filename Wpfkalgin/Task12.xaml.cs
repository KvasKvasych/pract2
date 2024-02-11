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
    /// Логика взаимодействия для Task12.xaml
    /// </summary>
    public partial class Task12 : Window
    {
        public Task12()
        {
            InitializeComponent();
        }

        private void kmn121_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, k, m, n;
            int x = new Random().Next(0, 5);
            //1
            k = 4;
            m = -14.7;
            n = -0.6;

            if (3*x > Math.Abs(m+n))
            {
                y = Math.Log10(Math.Abs(k * x + m * n));
            }
            else if (3 * x == Math.Abs(m + n))
            {
                y = Math.Sin(k * m * x) + Math.Sqrt(Math.Abs(n * x));
            }
            else if (3 * x < Math.Abs(m + n))
            {
                y = Math.Exp(Math.Cos(x)) + Math.Exp(m + n);
            }
            MessageBox.Show($" y = {y}", "Задание №12", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void kmn122_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, k, m, n;
            int x = new Random().Next(0, 5);
            //2
            k = 3;
            m = 6.5;
            n = 3.15;

            if (3 * x > Math.Abs(m + n))
            {
                y = Math.Log10(Math.Abs(k * x + m * n));
            }
            else if (3 * x == Math.Abs(m + n))
            {
                y = Math.Sin(k * m * x) + Math.Sqrt(Math.Abs(n * x));
            }
            else if (3 * x < Math.Abs(m + n))
            {
                y = Math.Exp(Math.Cos(x)) + Math.Exp(m + n);
            }
            MessageBox.Show($" y = {y}", "Задание №12", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void kmn123_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, k, m, n;
            int x = new Random().Next(0, 5);
            //3
            k = 5;
            m = -12;
            n = 0.45;

            if (3 * x > Math.Abs(m + n))
            {
                y = Math.Log10(Math.Abs(k * x + m * n));
            }
            else if (3 * x == Math.Abs(m + n))
            {
                y = Math.Sin(k * m * x) + Math.Sqrt(Math.Abs(n * x));
            }
            else if (3 * x < Math.Abs(m + n))
            {
                y = Math.Exp(Math.Cos(x)) + Math.Exp(m + n);
            }
            MessageBox.Show($" y = {y}", "Задание №12", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Backtotasks_Click(object sender, RoutedEventArgs e)
        {
            new TasksWindow().Show();
            Close();
        }
    }
}
