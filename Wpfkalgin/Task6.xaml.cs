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
    /// Логика взаимодействия для Task6.xaml
    /// </summary>
    public partial class Task6 : Window
    {
        public Task6()
        {
            InitializeComponent();
        }

        private void abz61_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //1
            a = -5;
            b = 2.5;
            z = Math.Log10(Math.Abs(b*Math.Pow(x,3)));

            if (x<a)
            {
                y = 2.8 * Math.Pow(Math.Sin(a * x), 2) - b * Math.Pow(x, 3) * z;
            }
            else if (a<=x && x<= Math.Pow(b,2))
            {
                y = z * Math.Pow(Math.Cos(a * x + b), 2) + Math.Log10(z);
            }
            else if (x>Math.Pow(b,2))
            {
                y = Math.Exp(2.5 * a * x) + z * a * b * x;
            }
            MessageBox.Show($" y = {y}", "Задание №6", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abz62_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //2
            a = 3;
            b = 5;
            z = Math.Log10(Math.Abs(b * x));

            if (x < a)
            {
                y = 2.8 * Math.Pow(Math.Sin(a * x), 2) - b * Math.Pow(x, 3) * z;
            }
            else if (a <= x && x <= Math.Pow(b, 2))
            {
                y = z * Math.Pow(Math.Cos(a * x + b), 2) + Math.Log10(z);
            }
            else if (x > Math.Pow(b, 2))
            {
                y = Math.Exp(2.5 * a * x) + z * a * b * x;
            }
            MessageBox.Show($" y = {y}", "Задание №6", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abz63_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //1
            a = -10;
            b = 3;
            z = Math.Log10(Math.Abs(b * Math.Pow(x, 2)));

            if (x < a)
            {
                y = 2.8 * Math.Pow(Math.Sin(a * x), 2) - b * Math.Pow(x, 3) * z;
            }
            else if (a <= x && x <= Math.Pow(b, 2))
            {
                y = z * Math.Pow(Math.Cos(a * x + b), 2) + Math.Log10(z);
            }
            else if (x > Math.Pow(b, 2))
            {
                y = Math.Exp(2.5 * a * x) + z * a * b * x;
            }
            MessageBox.Show($" y = {y}", "Задание №6", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Backtotasks_Click(object sender, RoutedEventArgs e)
        {
            new TasksWindow().Show();
            Close();
        }
    }
}
