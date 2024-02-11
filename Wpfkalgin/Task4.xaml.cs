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
    /// Логика взаимодействия для Task4.xaml
    /// </summary>
    public partial class Task4 : Window
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void abz41_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //1
            a = 0.2;
            b = 0.5;
            z = Math.Exp(a*x);

            if (x<-Math.Log10(a))
            {
                y = a * Math.Pow(Math.Sin(x), 2) + b * Math.Cos(z * x);
            }
            else if (-Math.Log10(a)<=x && x<= b)
            {
                y = Math.Pow(a, b) - Math.Pow(Math.Cos(a + z * x), 3);
            }
            else if (x>b)
            {
                y = Math.Sqrt(2.5 * Math.Pow(a, 3) + Math.Pow((b - z * Math.Pow(x, 2)),6));
            }
            MessageBox.Show($" y = {y}", "Задание №4", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abz42_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //2
            a = 0.15;
            b = 0.2;
            z = Math.Exp(2 * a * x);

            if (x < -Math.Log10(a))
            {
                y = a * Math.Pow(Math.Sin(x), 2) + b * Math.Cos(z * x);
            }
            else if (-Math.Log10(a) <= x && x <= b)
            {
                y = Math.Pow(a, b) - Math.Pow(Math.Cos(a + z * x), 3);
            }
            else if (x > b)
            {
                y = Math.Sqrt(2.5 * Math.Pow(a, 3) + Math.Pow((b - z * Math.Pow(x, 2)), 6));
            }
            MessageBox.Show($" y = {y}", "Задание №4", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abz43_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //3
            a = 0.9;
            b = 5;
            z = Math.Exp(2.5 * a * x);

            if (x < -Math.Log10(a))
            {
                y = a * Math.Pow(Math.Sin(x), 2) + b * Math.Cos(z * x);
            }
            else if (-Math.Log10(a) <= x && x <= b)
            {
                y = Math.Pow(a, b) - Math.Pow(Math.Cos(a + z * x), 3);
            }
            else if (x > b)
            {
                y = Math.Sqrt(2.5 * Math.Pow(a, 3) + Math.Pow((b - z * Math.Pow(x, 2)), 6));
            }
            MessageBox.Show($" y = {y}", "Задание №4", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Backtotasks_Click(object sender, RoutedEventArgs e)
        {
            new TasksWindow().Show();
            Close();
        }
    }
}
