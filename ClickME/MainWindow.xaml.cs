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

namespace ClickME
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

        private readonly Random rand = new Random();

        private void buttonToClick_Click(object sender, RoutedEventArgs e)
        {
            var textPercent = rand.Next(1, 71);
            var buttonSizePercent = rand.Next(0, 26);
            var windowSizePercent = rand.Next(0, 6);

            buttonToClick.Content = Randomizer.Randomize(buttonToClick.Content.ToString(), textPercent);
            buttonToClick.Width += buttonToClick.Width * buttonSizePercent / 100;
            buttonToClick.Height += buttonToClick.Height * buttonSizePercent / 100;

            var window = Application.Current.MainWindow;

            Application.Current.MainWindow.Height += window.Height * windowSizePercent / 100;
            Application.Current.MainWindow.Width += window.Width * windowSizePercent / 100;
        }
    }
}