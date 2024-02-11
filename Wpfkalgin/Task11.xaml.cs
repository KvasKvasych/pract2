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
    /// Логика взаимодействия для Task11.xaml
    /// </summary>
    public partial class Task11 : Window
    {
        public Task11()
        {
            InitializeComponent();
        }

        private void abz111_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //1
            a = -1;
            b = 3.4;
            z = Math.Tan(b*x);

            if (x<=a)
            {
                y = Math.Exp(a * x) - 3.5 * Math.Pow(Math.Cos(z + b * x), 2);
            }
            else if (a<x && x <= Math.Pow(b,3.5))
            {
                y = a + Math.Log10(Math.Abs(a + b * x)) - 2 * x;
            }
            else if (x>Math.Pow(b,3.5))
            {
                y = a + Math.Pow(Math.Cos(a + b * x * z), 3.5);
            }
            MessageBox.Show($" y = {y}", "Задание №11", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abz112_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //2
            a = -3.2;
            b = 5.5;
            z = Math.Tan(b * Math.Pow(x,2));

            if (x <= a)
            {
                y = Math.Exp(a * x) - 3.5 * Math.Pow(Math.Cos(z + b * x), 2);
            }
            else if (a < x && x <= Math.Pow(b, 3.5))
            {
                y = a + Math.Log10(Math.Abs(a + b * x)) - 2 * x;
            }
            else if (x > Math.Pow(b, 3.5))
            {
                y = a + Math.Pow(Math.Cos(a + b * x * z), 3.5);
            }
            MessageBox.Show($" y = {y}", "Задание №11", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abz113_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //3
            a = -3.2;
            b = 5.5;
            z = Math.Tan(b * Math.Pow(x, 3));

            if (x <= a)
            {
                y = Math.Exp(a * x) - 3.5 * Math.Pow(Math.Cos(z + b * x), 2);
            }
            else if (a < x && x <= Math.Pow(b, 3.5))
            {
                y = a + Math.Log10(Math.Abs(a + b * x)) - 2 * x;
            }
            else if (x > Math.Pow(b, 3.5))
            {
                y = a + Math.Pow(Math.Cos(a + b * x * z), 3.5);
            }
            MessageBox.Show($" y = {y}", "Задание №11", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Backtotasks_Click(object sender, RoutedEventArgs e)
        {
            new TasksWindow().Show();
            Close();
        }
    }
}
