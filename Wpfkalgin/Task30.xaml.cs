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
    /// Логика взаимодействия для Task30.xaml
    /// </summary>
    public partial class Task30 : Window
    {
        public Task30()
        {
            InitializeComponent();
        }

        private void Backtotasks_Click(object sender, RoutedEventArgs e)
        {
            new TasksWindow().Show();
            Close();
        }

        private void bmn1_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, b, m, n;
            int x = new Random().Next(0, 5);
            //1
            b = -1.6;
            m = 0.9;
            n = -1.4;

            if (Math.Abs(b * m) > Math.Pow(x, 2))
            {
                y = Math.Sin(b * m + Math.Cos(x * n));
            }
            else if (Math.Abs(b * m) < Math.Pow(x, 2))
            {
                y = Math.Cos(b * m - Math.Sin(x));
            }
            else if (Math.Abs(b * m) == Math.Pow(x, 2))
            {
                y = Math.Sqrt(Math.Exp(Math.Abs(Math.Cos(x))) + Math.Sqrt(Math.Abs(b * m * x)));
            }
            MessageBox.Show($" y = {y}", "Задание №27", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void bmn2_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, b, m, n;
            int x = new Random().Next(0, 5);
            //2
            b = 4.5;
            m = -2;
            n = 2.2;

            if (Math.Abs(b * m) > Math.Pow(x, 2))
            {
                y = Math.Sin(b * m + Math.Cos(x * n));
            }
            else if (Math.Abs(b * m) < Math.Pow(x, 2))
            {
                y = Math.Cos(b * m - Math.Sin(x));
            }
            else if (Math.Abs(b * m) == Math.Pow(x, 2))
            {
                y = Math.Sqrt(Math.Exp(Math.Abs(Math.Cos(x))) + Math.Sqrt(Math.Abs(b * m * x)));
            }
            MessageBox.Show($" y = {y}", "Задание №27", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void bmn3_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, b, m, n;
            int x = new Random().Next(0, 5);
            //3
            b = -4.5;
            m = 0.5;
            n = -1.5;

            if (Math.Abs(b * m) > Math.Pow(x, 2))
            {
                y = Math.Sin(b * m + Math.Cos(x * n));
            }
            else if (Math.Abs(b * m) < Math.Pow(x, 2))
            {
                y = Math.Cos(b * m - Math.Sin(x));
            }
            else if (Math.Abs(b * m) == Math.Pow(x, 2))
            {
                y = Math.Sqrt(Math.Exp(Math.Abs(Math.Cos(x))) + Math.Sqrt(Math.Abs(b * m * x)));
            }
            MessageBox.Show($" y = {y}", "Задание №27", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
