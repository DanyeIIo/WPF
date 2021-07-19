using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Controls2
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

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(pb1.Password);
            //while (pb.Value < 100)
            //{
            //    pb.Value++;
            //    Thread.Sleep(200);
            //}
        }

        private void pb_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
        private void Win_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You won!");
        }
        Random random = new Random();
        //private void MouseMove(object sender, MouseEventArgs e)
        //{

        //    double x = Canvas.GetLeft(bMain);
        //    double y = Canvas.GetTop(bMain);



        //    int side = random.Next(1, 5);
        //    switch (side)
        //    {
        //        case 1:
        //            x += bMain.Width;
        //            break;
        //        case 2:
        //            x -= bMain.Width;
        //            break;
        //        case 3:
        //            y += bMain.Height;
        //            break;
        //        case 4:
        //            y -= bMain.Height;
        //            break;
        //        default:
        //            break;
        //    }
        //    Title = $"side={side}; x={x}; y={y}; ";
        //    Canvas.SetLeft(bMain, x);
        //    Canvas.SetTop(bMain, y);

        //    if ((x + bMain.Width + 20 > Width) || (y + bMain.Height + 50 > Height) || (y < 0) || (x < 0))
        //    {
        //        Canvas.SetLeft(bMain, 0);
        //        Canvas.SetTop(bMain, 0);
        //        MouseMove(null, null);
        //    }
        //}
    }
}
