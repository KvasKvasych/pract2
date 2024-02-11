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
    /// Логика взаимодействия для Task1.xaml
    /// </summary>
    public partial class Task1 : Window
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void usinx_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, u;
            int x = new Random().Next(0, 5);
            //1
            u = Math.Sin(x);

            if (u + x > -0.5)
            {
                y = Math.Pow((2 * u + 1), 2) / 7 * Math.PI + x;
            }
            else if (-0.5 >= u + x && u + x <= Math.Pow(10, -3))
            {
                y = Math.Pow(Math.Cos(u), 2) - Math.Sin(u / 3);
            }
            else if (u + x > Math.Pow(10, -3))
            {
                y = (Math.Log10(u + x) - Math.Exp(x)) / (3.5 * x);
            }
            MessageBox.Show($" y = {y}", "Задание №1", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ucosx_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, u;
            int x = new Random().Next(0, 5);
            //2
            u = Math.Cos(x);

            if (u + x > -0.5)
            {
                y = Math.Pow((2 * u + 1), 2) / 7 * Math.PI + x;
            }
            else if (-0.5 >= u + x && u + x <= Math.Pow(10, -3))
            {
                y = Math.Pow(Math.Cos(u), 2) - Math.Sin(u / 3);
            }
            else if (u + x > Math.Pow(10, -3))
            {
                y = (Math.Log10(u + x) - Math.Exp(x)) / (3.5 * x);
            }
            MessageBox.Show($" y = {y}", "Задание №1", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void utgx_Click(object sender, RoutedEventArgs e)
        {
            double y = 0, u;
            int x = new Random().Next(0, 5);
            //3
            u = Math.Tan(x);

            if (u + x > -0.5)
            {
                y = Math.Pow((2 * u + 1), 2) / 7 * Math.PI + x;
            }
            else if (-0.5 >= u + x && u + x <= Math.Pow(10, -3))
            {
                y = Math.Pow(Math.Cos(u), 2) - Math.Sin(u / 3);
            }
            else if (u + x > Math.Pow(10, -3))
            {
                y = (Math.Log10(u + x) - Math.Exp(x)) / (3.5 * x);
            }
            MessageBox.Show($" y = {y}", "Задание №1", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Backtotasks_Click(object sender, RoutedEventArgs e)
        {
            new TasksWindow().Show();
            Close();
        }
    }
}
