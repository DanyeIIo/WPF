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

namespace MathTest
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

        readonly Dictionary<int, int> results = new Dictionary<int, int>()
        {
            {1, 1 },
            {2, 1 },
            {3, 1 },
            {4, 1 },
            {5, 1 },
            {6, 1 },
            {7, 1 },
            {8, 1 },
            {9, 1 },
            {10, 1 }
        };

        private void BCheckResults_Click(object sender, RoutedEventArgs e)
        {
            int correctAnswers = 0;

            if ((rb1.IsChecked == true || rb2.IsChecked == true || rb3.IsChecked == true || rb4.IsChecked == true) &&
                (rb21.IsChecked == true || rb22.IsChecked == true || rb23.IsChecked == true || rb24.IsChecked == true) &&
                (rb31.IsChecked == true || rb32.IsChecked == true || rb33.IsChecked == true || rb34.IsChecked == true) &&
                (rb41.IsChecked == true || rb42.IsChecked == true || rb43.IsChecked == true || rb44.IsChecked == true) &&
                (rb51.IsChecked == true || rb52.IsChecked == true || rb53.IsChecked == true || rb54.IsChecked == true) &&
                (rb61.IsChecked == true || rb62.IsChecked == true || rb63.IsChecked == true || rb64.IsChecked == true) &&
                (rb71.IsChecked == true || rb72.IsChecked == true || rb73.IsChecked == true || rb74.IsChecked == true) &&
                (rb81.IsChecked == true || rb82.IsChecked == true || rb83.IsChecked == true || rb84.IsChecked == true) &&
                (rb91.IsChecked == true || rb92.IsChecked == true || rb93.IsChecked == true || rb94.IsChecked == true) &&
                (rb101.IsChecked == true || rb102.IsChecked == true || rb103.IsChecked == true || rb104.IsChecked == true))
            {
                if (rb1.IsChecked == true)
                    correctAnswers++;
                if (rb21.IsChecked == true)
                    correctAnswers++;
                if (rb31.IsChecked == true)
                    correctAnswers++;
                if (rb41.IsChecked == true)
                    correctAnswers++;
                if (rb51.IsChecked == true)
                    correctAnswers++;
                if (rb61.IsChecked == true)
                    correctAnswers++;
                if (rb71.IsChecked == true)
                    correctAnswers++;
                if (rb81.IsChecked == true)
                    correctAnswers++;
                if (rb91.IsChecked == true)
                    correctAnswers++;
                if (rb101.IsChecked == true)
                    correctAnswers++;
            }
            else
            {
                tbResult.Text = "u haven't chosen all the options";
                MessageBox.Show("u haven't chosen all the options");
                return;
            }

            MessageBox.Show($"Correct answers: {correctAnswers}");
            tbResult.Text = $"Correct answers: {correctAnswers}";

        }
    }
}
