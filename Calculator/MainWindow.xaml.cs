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

namespace Calculator
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

        readonly StringBuilder raw = new StringBuilder();
        private void B1_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b1.Content.ToString();
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b2.Content.ToString();

        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b3.Content.ToString();
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b4.Content.ToString();
        }
        private void B5_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b5.Content.ToString();
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b6.Content.ToString();
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b7.Content.ToString();
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b8.Content.ToString();
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b9.Content.ToString();
        }

        private void B0_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b0.Content.ToString();
        }

        private void BEquals_Click(object sender, RoutedEventArgs e)
        {
            var speacialSymbols = "+-*/";
            var strTmp = lResult.Content.ToString();

            lResult.Content = string.Empty;

            if (speacialSymbols.Contains(strTmp[0]) || speacialSymbols.Contains(strTmp[strTmp.Length - 1]))
            {
                lResult.Content = "Wrong input";
                return;
            }

            for (int i = 0; i < strTmp.Length - 2; i++)
            {
                if (speacialSymbols.Contains(strTmp[i]) && speacialSymbols.Contains(strTmp[i + 1]))
                {
                    lResult.Content = "Wrong input";
                    return;
                }
            }

            List<string> strArr = new List<string>();
            List<char> symbols = new List<char>();
            List<int> arr = new List<int>();

            strArr.Add("");
            for (int i = 0; i < strTmp.Length; i++)
            {
                if (speacialSymbols.Contains(strTmp[i]))
                {
                    symbols.Add(strTmp[i]);
                    strArr.Add("");
                    continue;
                }
                strArr[strArr.Count - 1] += strTmp[i];
            }

            foreach (var item in strArr)
            {
                arr.Add(Convert.ToInt32(item));
            }

            int sum = arr[0];
            for (int i = 0, j = 1; i < symbols.Count; i++, j++)
            {
                switch (symbols[i])
                {
                    case '+':
                        sum += arr[j];
                        break;
                    case '-':
                        sum -= arr[j];
                        break;
                    case '*':
                        sum *= arr[j];
                        break;
                    case '/':
                        if (arr[j] == 0)
                        {
                            lResult.Content = "wrong expression";
                            return;
                        }
                        sum /= arr[j];
                        break;
                    default:
                        break;
                }
            }
            lResult.Content = sum.ToString();
        }

        private void BClear_Click(object sender, RoutedEventArgs e)
        {
            raw.Clear();
            lResult.Content = string.Empty;
        }

        private void BPlus_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += bPlus.Content.ToString();
        }

        private void BMinus_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += bMinus.Content.ToString();
        }

        private void BMultiply_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += bMultiply.Content.ToString();
        }

        private void BDivision_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += bDivision.Content.ToString();
        }
    }
}
