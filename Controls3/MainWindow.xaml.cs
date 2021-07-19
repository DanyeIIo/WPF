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

namespace Controls3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("OAAAAAAOAOAOAOAEAO");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((languages.Items[1] as ListBoxItem).Content.ToString());
            MessageBox.Show((languages.SelectedItem as ListBoxItem).Content.ToString());
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            //Hide();
            //MessageBox.Show("Hidden");
            //Show();
            //MessageBox.Show("Shown");
            //Close();
            //MessageBox.Show("Closed");
            //Show();// ERROR
            var myWindow = new MyWindow();
            myWindow.Show();
        }
    }
}
