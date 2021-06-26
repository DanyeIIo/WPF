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

namespace Controls
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

        private void BStart_Click(object sender, RoutedEventArgs e)
        {
            Enumerable.Range(0, 3).AsParallel().ForAll(x =>
            {
                Console.WriteLine(MessageBox.Show("YO", "Dock", MessageBoxButton.YesNoCancel, MessageBoxImage.Question));
            });
            MessageBox.Show("YO");
            MessageBox.Show("YO","Dock");
            MessageBox.Show("YO", "Dock",
                MessageBoxButton.YesNo);
            MessageBox.Show("YO", "Dock", MessageBoxButton.YesNoCancel, MessageBoxImage.Error);

        }

        private void RepB_Click(object sender, RoutedEventArgs e)
        {
            repB.Content += "+1";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show(tb2.Text);
        }
    }
}
