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
    /// Логика взаимодействия для Task8.xaml
    /// </summary>
    public partial class Task8 : Window
    {
        public Task8()
        {
            InitializeComponent();
        }

        private void kmn81_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, k, m, n;
            int x = new Random().Next(0, 5);
            //1
            k = 3.1;
            m = 5.15;
            n = -1.15;

            if (Math.Pow(x,2)>m+n)
            {
                y = Math.Log10(Math.Abs(m * x + n));
            }
            else if (Math.Pow(x, 2) == m + n)
            {
                y = Math.Exp(Math.Cos(Math.Abs(m * x - n)));
            }
            else if (Math.Pow(x, 2) < m + n)
            {
                y = Math.Pow(Math.Pow(k, 2) + Math.Pow(Math.Cos(x), 2), 1 / 3);
            }
            MessageBox.Show($" y = {y}", "Задание №8", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void kmn82_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, k, m, n;
            int x = new Random().Next(0, 5);
            //2
            k = 0.78;
            m = -2.4;
            n = 4.36;

            if (Math.Pow(x, 2) > m + n)
            {
                y = Math.Log10(Math.Abs(m * x + n));
            }
            else if (Math.Pow(x, 2) == m + n)
            {
                y = Math.Exp(Math.Cos(Math.Abs(m * x - n)));
            }
            else if (Math.Pow(x, 2) < m + n)
            {
                y = Math.Pow(Math.Pow(k, 2) + Math.Pow(Math.Cos(x), 2), 1 / 3);
            }
            MessageBox.Show($" y = {y}", "Задание №8", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        private void Backtotasks_Click(object sender, RoutedEventArgs e)
        {
            new TasksWindow().Show();
            Close();
        }

        private void akmn83_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, k, m, n;
            int x = new Random().Next(0, 5);
            //3
            k = 1.1;
            m = 0.8;
            n = 0.41;

            if (Math.Pow(x, 2) > m + n)
            {
                y = Math.Log10(Math.Abs(m * x + n));
            }
            else if (Math.Pow(x, 2) == m + n)
            {
                y = Math.Exp(Math.Cos(Math.Abs(m * x - n)));
            }
            else if (Math.Pow(x, 2) < m + n)
            {
                y = Math.Pow(Math.Pow(k, 2) + Math.Pow(Math.Cos(x), 2), 1 / 3);
            }
            MessageBox.Show($" y = {y}", "Задание №8", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
