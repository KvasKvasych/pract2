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
    /// Логика взаимодействия для Task2.xaml
    /// </summary>
    public partial class Task2 : Window
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void Backtotasks_Click(object sender, RoutedEventArgs e)
        {
            new TasksWindow().Show();
            Close();
        }

        private void abz1_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //1
            a = 0.4;
            b = 2.3;
            z = Math.Exp(2*x);

            if (x < 3.5*a)
            {
                y = a * b * x - Math.Pow(Math.Cos(z * x), 2);
            }
            else if (3.5 * a <= x && x <= b)
            {
                y = Math.Pow(a - x, 2) - Math.Log10(z + x);
            }
            else if (x>b)
            {
                y = Math.Sqrt(b * x - a + Math.Pow(z * x, 2));
            }
            MessageBox.Show($" y = {y}", "Задание №2", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abz2_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //2
            a = 0.2;
            b = 0.8;
            z = Math.Exp(x);

            if (x < 3.5 * a)
            {
                y = a * b * x - Math.Pow(Math.Cos(z * x), 2);
            }
            else if (3.5 * a <= x && x <= b)
            {
                y = Math.Pow(a - x, 2) - Math.Log10(z + x);
            }
            else if (x > b)
            {
                y = Math.Sqrt(b * x - a + Math.Pow(z * x, 2));
            }
            MessageBox.Show($" y = {y}", "Задание №2", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abz3_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //3
            a = 0.7;
            b = 8.1;
            z = 0.8;

            if (x < 3.5 * a)
            {
                y = a * b * x - Math.Pow(Math.Cos(z * x), 2);
            }
            else if (3.5 * a <= x && x <= b)
            {
                y = Math.Pow(a - x, 2) - Math.Log10(z + x);
            }
            else if (x > b)
            {
                y = Math.Sqrt(b * x - a + Math.Pow(z * x, 2));
            }
            MessageBox.Show($" y = {y}", "Задание №2", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
