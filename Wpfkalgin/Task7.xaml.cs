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
    /// Логика взаимодействия для Task7.xaml
    /// </summary>
    public partial class Task7 : Window
    {
        public Task7()
        {
            InitializeComponent();
        }

        private void abc71_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, c;
            int x = new Random().Next(0, 5);
            //1
            a = 3.2;
            b = -0.7;
            c = 2.2; 

            if (Math.Abs(1-Math.Pow(x,2))==a+c)
            {
                y = x * Math.Exp(a) + Math.Exp(Math.Abs(b * c));
            }
            else if (Math.Abs(1 - Math.Pow(x, 2)) > a + c)
            {
                y = Math.Pow(Math.Sin(a * x), 2) + Math.Cos(b * c);
            }
            else if (Math.Abs(1 - Math.Pow(x, 2)) < a + c)
            {
                y = Math.Sqrt(a * Math.Pow(b, 4)) + Math.Pow(c * Math.Pow(x, 2), 1 / 5);
            }
            MessageBox.Show($" y = {y}", "Задание №7", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abc72_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, c;
            int x = new Random().Next(0, 5);
            //2
            a = 10.5;
            b = -2.5;
            c = 5.6;

            if (Math.Abs(1 - Math.Pow(x, 2)) == a + c)
            {
                y = x * Math.Exp(a) + Math.Exp(Math.Abs(b * c));
            }
            else if (Math.Abs(1 - Math.Pow(x, 2)) > a + c)
            {
                y = Math.Pow(Math.Sin(a * x), 2) + Math.Cos(b * c);
            }
            else if (Math.Abs(1 - Math.Pow(x, 2)) < a + c)
            {
                y = Math.Sqrt(a * Math.Pow(b, 4)) + Math.Pow(c * Math.Pow(x, 2), 1 / 5);
            }
            MessageBox.Show($" y = {y}", "Задание №7", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abc73_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, c;
            int x = new Random().Next(0, 5);
            //3
            a = 5.4;
            b = 3;
            c = 2.6;

            if (Math.Abs(1 - Math.Pow(x, 2)) == a + c)
            {
                y = x * Math.Exp(a) + Math.Exp(Math.Abs(b * c));
            }
            else if (Math.Abs(1 - Math.Pow(x, 2)) > a + c)
            {
                y = Math.Pow(Math.Sin(a * x), 2) + Math.Cos(b * c);
            }
            else if (Math.Abs(1 - Math.Pow(x, 2)) < a + c)
            {
                y = Math.Sqrt(a * Math.Pow(b, 4)) + Math.Pow(c * Math.Pow(x, 2), 1 / 5);
            }
            MessageBox.Show($" y = {y}", "Задание №7", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Backtotasks_Click(object sender, RoutedEventArgs e)
        {
            new TasksWindow().Show();
            Close();
        }
    }
}
