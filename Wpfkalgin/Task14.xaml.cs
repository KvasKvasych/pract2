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
    /// Логика взаимодействия для Task14.xaml
    /// </summary>
    public partial class Task14 : Window
    {
        public Task14()
        {
            InitializeComponent();
        }

        private void abz141_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //1
            a = 0.5;
            b = 4.5;
            z = Math.Exp(a*x);

            if (x<=5*a)
            {
                y = 2.5 * Math.Pow(b, 2) + a * x - 4.5 * Math.Cos(x * z);
            }
            else if (x>b)
            {
                y = Math.Pow(Math.Pow(a, 2) - 5.4 * x, 3) + Math.Log10(x * z);
            }
            else if (5*a < x && x <=b)
            {
                y = Math.Sqrt(6.5 * Math.Pow(b, 2) + (a - Math.Pow(x, 3) * z));
            }
            MessageBox.Show($" y = {y}", "Задание №14", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abz142_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //2
            a = 0.5;
            b = 3.7;
            z = Math.Exp(2 * a * x);

            if (x <= 5 * a)
            {
                y = 2.5 * Math.Pow(b, 2) + a * x - 4.5 * Math.Cos(x * z);
            }
            else if (x > b)
            {
                y = Math.Pow(Math.Pow(a, 2) - 5.4 * x, 3) + Math.Log10(x * z);
            }
            else if (5 * a < x && x <= b)
            {
                y = Math.Sqrt(6.5 * Math.Pow(b, 2) + (a - Math.Pow(x, 3) * z));
            }
            MessageBox.Show($" y = {y}", "Задание №14", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abz143_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //3
            a = 0.5;
            b = 2.7;
            z = Math.Exp(2.5* a * x);

            if (x <= 5 * a)
            {
                y = 2.5 * Math.Pow(b, 2) + a * x - 4.5 * Math.Cos(x * z);
            }
            else if (x > b)
            {
                y = Math.Pow(Math.Pow(a, 2) - 5.4 * x, 3) + Math.Log10(x * z);
            }
            else if (5 * a < x && x <= b)
            {
                y = Math.Sqrt(6.5 * Math.Pow(b, 2) + (a - Math.Pow(x, 3) * z));
            }
            MessageBox.Show($" y = {y}", "Задание №14", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Backtotasks_Click(object sender, RoutedEventArgs e)
        {
            new TasksWindow().Show();
            Close();
        }
    }
}
