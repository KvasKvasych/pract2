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
    /// Логика взаимодействия для Task16.xaml
    /// </summary>
    public partial class Task16 : Window
    {
        public Task16()
        {
            InitializeComponent();
        }

        private void abz161_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //1
            a = 0.1;
            b = 0.5;
            z = Math.Exp(2.5*a*x);

            if (x<=a)
            {
                y = 3.5 * Math.Pow(Math.Sin(Math.Pow(b * x + z, 3)), 2) - Math.Exp(3.5 * a);
            }
            else if (a<x && x<= Math.Pow(b,2.5))
            {
                y = Math.Log10(a + Math.Pow(b, 3) * x) + a;
            }
            else if (x > Math.Pow(b, 2.5))
            {
                y = Math.Pow(Math.Cos(Math.Pow(b, 3) * Math.Pow(x, 2)), 2) + Math.Log10(b * x - Math.Pow(a, 2));
            }
            MessageBox.Show($" y = {y}", "Задание №16", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abz162_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //2
            a = 1.2;
            b = 2.5;
            z = Math.Exp(2.5 * a * x);

            if (x <= a)
            {
                y = 3.5 * Math.Pow(Math.Sin(Math.Pow(b * x + z, 3)), 2) - Math.Exp(3.5 * a);
            }
            else if (a < x && x <= Math.Pow(b, 2.5))
            {
                y = Math.Log10(a + Math.Pow(b, 3) * x) + a;
            }
            else if (x > Math.Pow(b, 2.5))
            {
                y = Math.Pow(Math.Cos(Math.Pow(b, 3) * Math.Pow(x, 2)), 2) + Math.Log10(b * x - Math.Pow(a, 2));
            }
            MessageBox.Show($" y = {y}", "Задание №16", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abz163_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //3
            a = 2.5;
            b = 1.2;
            z = Math.Exp(2.5 * a * x);

            if (x <= a)
            {
                y = 3.5 * Math.Pow(Math.Sin(Math.Pow(b * x + z, 3)), 2) - Math.Exp(3.5 * a);
            }
            else if (a < x && x <= Math.Pow(b, 2.5))
            {
                y = Math.Log10(a + Math.Pow(b, 3) * x) + a;
            }
            else if (x > Math.Pow(b, 2.5))
            {
                y = Math.Pow(Math.Cos(Math.Pow(b, 3) * Math.Pow(x, 2)), 2) + Math.Log10(b * x - Math.Pow(a, 2));
            }
            MessageBox.Show($" y = {y}", "Задание №16", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Backtotasks_Click(object sender, RoutedEventArgs e)
        {
            new TasksWindow().Show();
            Close();
        }
    }
}
