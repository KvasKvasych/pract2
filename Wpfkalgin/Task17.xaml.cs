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
    /// Логика взаимодействия для Task17.xaml
    /// </summary>
    public partial class Task17 : Window
    {
        public Task17()
        {
            InitializeComponent();
        }

        private void abz171_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //1
            a = -1.2;
            b = 0.75;
            z = Math.Log10(Math.Abs(Math.Tan(b*x)));

            if (x <= a)
            {
                y = 3.5 * Math.Pow(Math.Sin(Math.Pow(b * x + z, 3)), 2) - Math.Exp(3.5 * a);
            }
            else if (a< x && x < Math.Log10(b))
            {
                y = Math.Log10(a + Math.Pow(b, 3) * x) + a;
            }
            else if (x >= Math.Log10(b))
            {
                y = Math.Pow(Math.Cos(Math.Pow(b, 3) * Math.Pow(x, 2)), 2) + Math.Log10(b * x - Math.Pow(a, 2));
            }
            MessageBox.Show($" y = {y}", "Задание №17", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abz172_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //2
            a = 0.4;
            b = 2.4;
            z = Math.Log10(Math.Abs(Math.Tan(b * x)));

            if (x <= a)
            {
                y = 3.5 * Math.Pow(Math.Sin(Math.Pow(b * x + z, 3)), 2) - Math.Exp(3.5 * a);
            }
            else if (a < x && x < Math.Log10(b))
            {
                y = Math.Log10(a + Math.Pow(b, 3) * x) + a;
            }
            else if (x >= Math.Log10(b))
            {
                y = Math.Pow(Math.Cos(Math.Pow(b, 3) * Math.Pow(x, 2)), 2) + Math.Log10(b * x - Math.Pow(a, 2));
            }
            MessageBox.Show($" y = {y}", "Задание №17", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void abz173_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, a, b, z;
            int x = new Random().Next(0, 5);
            //3
            a = 1.1;
            b = 6.1;
            z = Math.Log10(Math.Abs(Math.Tan(b * x)));

            if (x <= a)
            {
                y = 3.5 * Math.Pow(Math.Sin(Math.Pow(b * x + z, 3)), 2) - Math.Exp(3.5 * a);
            }
            else if (a < x && x < Math.Log10(b))
            {
                y = Math.Log10(a + Math.Pow(b, 3) * x) + a;
            }
            else if (x >= Math.Log10(b))
            {
                y = Math.Pow(Math.Cos(Math.Pow(b, 3) * Math.Pow(x, 2)), 2) + Math.Log10(b * x - Math.Pow(a, 2));
            }
            MessageBox.Show($" y = {y}", "Задание №17", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Backtotasks_Click(object sender, RoutedEventArgs e)
        {
            new TasksWindow().Show();
            Close();
        }
    }
}
