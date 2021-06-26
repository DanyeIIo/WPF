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

namespace ClickMe2
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

        Random rand = new Random();
        private void Win_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("WINNER");
        }
        private void MouseMove(object sender, MouseEventArgs e)
        {
            int x = rand.Next((int)(Width - 20 - bMain.Width));
            int y = rand.Next((int)(Height - 50 - bMain.Height));

            Title = $"x = {x};y = {y}";

            if (x > bMain.Width + 100)
            {
                Canvas.SetLeft(bMain, bMain.Width + rand.Next(50, 101));
            }
            else
            {
                if (x < bMain.Height - 100)
                {
                    Canvas.SetLeft(bMain, bMain.Width - rand.Next(50, 101));
                }
                else
                {
                    Canvas.SetLeft(bMain, x);
                }
            }

            if (y > bMain.Height + 100)
            {
                Canvas.SetTop(bMain, bMain.Height + rand.Next(50, 101));
            }
            else
            {
                if (y < bMain.Height - 100)
                {
                    Canvas.SetTop(bMain, bMain.Height - rand.Next(50, 101));
                }
                else
                {
                    Canvas.SetTop(bMain, y);
                }
            }
        }
    }
}
