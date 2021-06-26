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

namespace grid
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

        private void bRunner_Click(object sender, RoutedEventArgs e)
        {
            double left = this.Left;
            double right = this.Top;
            Random rand = new Random();

            left = rand.Next((int)(left * -1), (int)left);
            right = rand.Next((int)(right * -1), (int)right);

            var currentLeft = Canvas.GetLeft(bRunner);
            var currentRight = Canvas.GetRight(bRunner);

            while ()
            {

            }

            Canvas.SetLeft(bRunner, left);
            Canvas.SetRight(bRunner, right);

            bRunner.Margin = new Thickness(rand.Next(0, 500), rand.Next(0, 500), rand.Next(0, 500), rand.Next(0, 500));
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    int.TryParse(tbResSquare.Text.ToString(), out int resInt);
        //    lResSquare.Content = resInt * resInt;
        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    int.TryParse(tbresCube.Text.ToString(), out int resInt);
        //    lResSquare.Content = resInt * resInt * resInt;
        //}

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    int.TryParse(tbresCube.Text.ToString(), out int resInt);
        //    lResSquare.Content = Math.Sqrt(resInt);
        //}

        //private void Button_Click_3(object sender, RoutedEventArgs e)
        //{
        //    int.TryParse(tbresCube.Text.ToString(), out int resInt);
        //    lResSquare.Content = Math.Pow(resInt, resInt);
        //}

        //string pos = String.Empty;
        //void LayoutRoot_MouseMove(object sender, MouseEventArgs e)
        //{
        //    pos = "X=" + e.GetPosition(null).X + " Y=" + e.GetPosition(null).Y;
        //}
    }
}
