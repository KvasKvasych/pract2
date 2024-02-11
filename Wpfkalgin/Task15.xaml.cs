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
    /// Логика взаимодействия для Task15.xaml
    /// </summary>
    public partial class Task15 : Window
    {
        public Task15()
        {
            InitializeComponent();
        }

        private void abc151_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, c;
            int x = new Random().Next(0, 5);
            //1
            a = 3.5;
            b = -0.73;
            c = 2.5;

            if (Math.Abs(1-Math.Pow(x,2)) == a + c)
            {
                y = Math.Sqrt(Math.Abs(x * a - Math.Pow(Math.Cos(Math.Pow(b, 3) * 3), 2) + 5.1 * Math.Pow(c, 2)));
            }
            else if (Math.Abs(1 - Math.Pow(x, 2)) > a + c)
            {
                y = Math.Exp(0.04 * x) + Math.Log10(Math.Abs(Math.Pow(b, 5) * Math.Cos(x)));
            }
            else if (Math.Abs(1 - Math.Pow(x, 2)) < a + c)
            {
                y = Math.Pow(Math.Cos(Math.Pow(b, 3) * Math.Pow(x, 2)), 2) + Math.Log10(b * x - Math.Pow(a, 2));
            }
            MessageBox.Show($" y = {y}", "Задание №15", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abc152_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, c;
            int x = new Random().Next(0, 5);
            //2
            a = 15.4;
            b = -5.6;
            c = 3.5;

            if (Math.Abs(1 - Math.Pow(x, 2)) == a + c)
            {
                y = Math.Sqrt(Math.Abs(x * a - Math.Pow(Math.Cos(Math.Pow(b, 3) * 3), 2) + 5.1 * Math.Pow(c, 2)));
            }
            else if (Math.Abs(1 - Math.Pow(x, 2)) > a + c)
            {
                y = Math.Exp(0.04 * x) + Math.Log10(Math.Abs(Math.Pow(b, 5) * Math.Cos(x)));
            }
            else if (Math.Abs(1 - Math.Pow(x, 2)) < a + c)
            {
                y = Math.Pow(Math.Cos(Math.Pow(b, 3) * Math.Pow(x, 2)), 2) + Math.Log10(b * x - Math.Pow(a, 2));
            }
            MessageBox.Show($" y = {y}", "Задание №15", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abc153_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, c;
            int x = new Random().Next(0, 5);
            //3
            a = 5.1;
            b = 4;
            c = 2.7;

            if (Math.Abs(1 - Math.Pow(x, 2)) == a + c)
            {
                y = Math.Sqrt(Math.Abs(x * a - Math.Pow(Math.Cos(Math.Pow(b, 3) * 3), 2) + 5.1 * Math.Pow(c, 2)));
            }
            else if (Math.Abs(1 - Math.Pow(x, 2)) > a + c)
            {
                y = Math.Exp(0.04 * x) + Math.Log10(Math.Abs(Math.Pow(b, 5) * Math.Cos(x)));
            }
            else if (Math.Abs(1 - Math.Pow(x, 2)) < a + c)
            {
                y = Math.Pow(Math.Cos(Math.Pow(b, 3) * Math.Pow(x, 2)), 2) + Math.Log10(b * x - Math.Pow(a, 2));
            }
            MessageBox.Show($" y = {y}", "Задание №15", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Backtotasks_Click(object sender, RoutedEventArgs e)
        {
            new TasksWindow().Show();
            Close();
        }
    }
}
