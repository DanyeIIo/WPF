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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FindingAreasOfShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cbi1_Selected(object sender, RoutedEventArgs e)
        {
            l1.Visibility = Visibility.Visible;
            tb1.Visibility = Visibility.Visible;
            l2.Visibility = Visibility.Hidden;
            tb2.Visibility = Visibility.Hidden;

            l1.Content = "Input r";
        }
        private void Cbi2_Selected(object sender, RoutedEventArgs e)
        {
            l1.Visibility = Visibility.Visible;
            tb1.Visibility = Visibility.Visible;
            l1.Content = "Input a";
        }

        private void Cbi3_Selected(object sender, RoutedEventArgs e)
        {
            l1.Visibility = Visibility.Visible;
            tb1.Visibility = Visibility.Visible;
            l2.Visibility = Visibility.Visible;
            tb2.Visibility = Visibility.Visible;
            l1.Content = "Input a";
            l2.Content = "Input h";
        }

        private void Cbi4_Selected(object sender, RoutedEventArgs e)
        {
            l1.Visibility = Visibility.Visible;
            tb1.Visibility = Visibility.Visible;
            l2.Visibility = Visibility.Visible;
            tb2.Visibility = Visibility.Visible;
            l1.Content = "Input a";
            l2.Content = "Input b";
        }

        private void Cbi5_Selected(object sender, RoutedEventArgs e)
        {
            l1.Visibility = Visibility.Visible;
            tb1.Visibility = Visibility.Visible;
            l2.Visibility = Visibility.Hidden;
            tb2.Visibility = Visibility.Hidden;

            l1.Content = "Input a";
        }

        private void BRes_Click(object sender, RoutedEventArgs e)
        {
            double res = 0;
            if (cbi1.IsSelected)
            {
                double.TryParse(tb1.Text, out double r);
                res = 3.14 * r;
            }

            else if (cbi2.IsSelected)
            {
                double.TryParse(tb1.Text, out double a);
                double.TryParse(tb2.Text, out double b);
                res = Math.Pow(a, 2);
            }

            else if (cbi3.IsSelected)
            {
                double.TryParse(tb1.Text, out double a);
                double.TryParse(tb2.Text, out double h);
                res = a * h;
            }

            else if (cbi4.IsSelected)
            {
                double.TryParse(tb1.Text, out double a);
                double.TryParse(tb2.Text, out double b);
                res = (a * b) / 2;
            }

            else if (cbi5.IsSelected)
            {
                double.TryParse(tb1.Text, out double a);
                double.TryParse(tb2.Text, out double b);
                res = (Math.Pow(a, 2) * Math.Sqrt(3)) / 4;
            }
            tbRes.Text = res.ToString();

            l1.Content = "";
            l2.Content = "";
            tb1.Text = "";
            tb2.Text = "";
        }
    }
}
