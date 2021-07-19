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

namespace Windoww
{
    /// <summary>
    /// Interaction logic for NewWindow.xaml
    /// </summary>
    public partial class NewWindow : Window
    {
        public NewWindow()
        {
            InitializeComponent();
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            //var w = new NewWindow();
            var win = new WindowsFolder();

            win.Show();
            //w.Show();
        }

        private void Magic_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            foreach (Window window in App.Current.Windows)
            {
                window.Title = "Hi Yo";
                window.Height = rand.Next(100,501);
                window.Background = new SolidColorBrush(
                    Color.FromArgb(
                        (byte)rand.Next(256),
                        (byte)rand.Next(256),
                        (byte)rand.Next(256),
                        (byte)rand.Next(256)));
            }
        }
    }
}
