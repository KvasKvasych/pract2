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
    /// Логика взаимодействия для Task13.xaml
    /// </summary>
    public partial class Task13 : Window
    {
        public Task13()
        {
            InitializeComponent();
        }

        private void krs131_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, k, r, s;
            int x = new Random().Next(0, 5);
            //1
            k = 1.33;
            r = 0.85;
            s = 3.5;

            if (Math.Cos(x)==Math.Cos(r*s))
            {
                y = Math.Pow(x, 2) * Math.Exp(2 * k) + Math.Log10(Math.Abs(r * x));
            }
            else if (Math.Cos(x) > Math.Cos(r * s))
            {
                y = Math.Pow(Math.Pow(x, 2), 1 / 3) + Math.Sqrt(Math.Abs(k + r * s * x));
            }
            else if (Math.Cos(x) < Math.Cos(r * s))
            {
                y = Math.Atan(k * x + r * s);
            }
            MessageBox.Show($" y = {y}", "Задание №13", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void krs132_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, k, r, s;
            int x = new Random().Next(0, 5);
            //2
            k = 0.9;
            r = 3.3;
            s = 1.2;

            if (Math.Cos(x) == Math.Cos(r * s))
            {
                y = Math.Pow(x, 2) * Math.Exp(2 * k) + Math.Log10(Math.Abs(r * x));
            }
            else if (Math.Cos(x) > Math.Cos(r * s))
            {
                y = Math.Pow(Math.Pow(x, 2), 1 / 3) + Math.Sqrt(Math.Abs(k + r * s * x));
            }
            else if (Math.Cos(x) < Math.Cos(r * s))
            {
                y = Math.Atan(k * x + r * s);
            }
            MessageBox.Show($" y = {y}", "Задание №13", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void krs133_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, k, r, s;
            int x = new Random().Next(0, 5);
            //3
            k = 1.57;
            r = 0.75;
            s = 2.15;

            if (Math.Cos(x) == Math.Cos(r * s))
            {
                y = Math.Pow(x, 2) * Math.Exp(2 * k) + Math.Log10(Math.Abs(r * x));
            }
            else if (Math.Cos(x) > Math.Cos(r * s))
            {
                y = Math.Pow(Math.Pow(x, 2), 1 / 3) + Math.Sqrt(Math.Abs(k + r * s * x));
            }
            else if (Math.Cos(x) < Math.Cos(r * s))
            {
                y = Math.Atan(k * x + r * s);
            }
            MessageBox.Show($" y = {y}", "Задание №13", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Backtotasks_Click(object sender, RoutedEventArgs e)
        {
            new TasksWindow().Show();
            Close();
        }
    }
}
