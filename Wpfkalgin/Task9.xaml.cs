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
    /// Логика взаимодействия для Task9.xaml
    /// </summary>
    public partial class Task9 : Window
    {
        public Task9()
        {
            InitializeComponent();
        }

        private void abz91_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //1
            a = 1.2;
            b = 7.2;
            z = Math.Exp(x);

            if (x<Math.Pow(a,3))
            {
                y = a * Math.Pow(Math.Sin(x), 2) + b * Math.Cos(z * x + a);
            }
            else if (Math.Pow(a,3)<= x && x <= b )
            {
                y = Math.Pow(a + b * x, 2) - Math.Sin(a + z * x);
            }
            else if (x>b)
            {
                y = Math.Sqrt(x - (Math.Sin(b * x + z)));
            }
            MessageBox.Show($" y = {y}", "Задание №9", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abz92_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //2
            a = -1.5;
            b = 3.2;
            z = Math.Exp(2*x);

            if (x < Math.Pow(a, 3))
            {
                y = a * Math.Pow(Math.Sin(x), 2) + b * Math.Cos(z * x + a);
            }
            else if (Math.Pow(a, 3) <= x && x <= b)
            {
                y = Math.Pow(a + b * x, 2) - Math.Sin(a + z * x);
            }
            else if (x > b)
            {
                y = Math.Sqrt(x - (Math.Sin(b * x + z)));
            }
            MessageBox.Show($" y = {y}", "Задание №9", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abz93_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //3
            a = 1.7;
            b = 5.5;
            z = Math.Exp(3);

            if (x < Math.Pow(a, 3))
            {
                y = a * Math.Pow(Math.Sin(x), 2) + b * Math.Cos(z * x + a);
            }
            else if (Math.Pow(a, 3) <= x && x <= b)
            {
                y = Math.Pow(a + b * x, 2) - Math.Sin(a + z * x);
            }
            else if (x > b)
            {
                y = Math.Sqrt(x - (Math.Sin(b * x + z)));
            }
            MessageBox.Show($" y = {y}", "Задание №9", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Backtotasks_Click(object sender, RoutedEventArgs e)
        {
            new TasksWindow().Show();
            Close();
        }
    }
}
