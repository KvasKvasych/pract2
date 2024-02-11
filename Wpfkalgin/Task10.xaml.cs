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
    /// Логика взаимодействия для Task10.xaml
    /// </summary>
    public partial class Task10 : Window
    {
        public Task10()
        {
            InitializeComponent();
        }

        private void abc101_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, c;
            int x = new Random().Next(0, 5);
            //1
            a = 0.1;
            b = 9.8;
            c = 11.12;

            if (Math.Log10(a) < x)
            {
                y = Math.Pow(Math.Pow(b, 3) + Math.Sqrt(Math.Abs(x + c)), 1 / 3);
            }
            else if (Math.Log10(a) == x)
            {
                y = Math.Cos(x - b - c);
            }
            else if (Math.Log10(a) > x)
            {
                y = Math.Sin(x + a - b);
            }
            MessageBox.Show($" y = {y}", "Задание №10", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abc102_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, c;
            int x = new Random().Next(0, 5);
            //2
            a = 10;
            b = 10.05;
            c = 6.2;

            if (Math.Log10(a)<x)
            {
                y = Math.Pow(Math.Pow(b, 3) + Math.Sqrt(Math.Abs(x + c)), 1 / 3);
            }
            else if (Math.Log10(a) == x)
            {
                y = Math.Cos(x - b - c);
            }
            else if (Math.Log10(a) > x)
            {
                y = Math.Sin(x + a - b);
            }
            MessageBox.Show($" y = {y}", "Задание №10", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abc103_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, c;
            int x = new Random().Next(0, 5);
            //3
            a = 100;
            b = 3.03;
            c = 7.12;

            if (Math.Log10(a) < x)
            {
                y = Math.Pow(Math.Pow(b, 3) + Math.Sqrt(Math.Abs(x + c)), 1 / 3);
            }
            else if (Math.Log10(a) == x)
            {
                y = Math.Cos(x - b - c);
            }
            else if (Math.Log10(a) > x)
            {
                y = Math.Sin(x + a - b);
            }
            MessageBox.Show($" y = {y}", "Задание №10", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Backtotasks_Click(object sender, RoutedEventArgs e)
        {
            new TasksWindow().Show();
            Close();
        }
    }
}
