using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;


// CAREFUL! TRASH CODE!!!
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
            raw.Append(b1.Content.ToString());
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b2.Content.ToString();
            raw.Append(b2.Content.ToString());
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b3.Content.ToString();
            raw.Append(b3.Content.ToString());
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b4.Content.ToString();
            raw.Append(b4.Content.ToString());
        }
        private void B5_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b5.Content.ToString();
            raw.Append(b5.Content.ToString());
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b6.Content.ToString();
            raw.Append(b6.Content.ToString());
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b7.Content.ToString();
            raw.Append(b7.Content.ToString());
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b8.Content.ToString();
            raw.Append(b8.Content.ToString());
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b9.Content.ToString();
            raw.Append(b9.Content.ToString());
        }

        private void B0_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += b0.Content.ToString();
            raw.Append(b0.Content.ToString());
        }

        private void BEquals_Click(object sender, RoutedEventArgs e)
        {
            var specialSymbols = "+-*/";
            var specialEngineerSymbols = "@#$?";
            var strTmp = lResult.Content.ToString();

            lResult.Content = string.Empty;

            if (specialSymbols.Contains(strTmp[0]) || specialSymbols.Contains(strTmp[strTmp.Length - 1]))
            {
                lResult.Content = "Wrong input";
                return;
            }

            for (int i = 0; i < strTmp.Length - 2; i++)
            {
                if (specialSymbols.Contains(strTmp[i]) && specialSymbols.Contains(strTmp[i + 1]))
                {
                    lResult.Content = "Wrong input";
                    return;
                }

                if (strTmp[i] == '(' && specialSymbols.Contains(strTmp[i + 1]))
                {
                    lResult.Content = "Wrong input";
                    return;
                }

            }

            List<string> strArr = new List<string>();
            List<char> symbols = new List<char>();
            List<decimal> arr = new List<decimal>();

            bool toggle = false;

            strArr.Add("");
            for (int i = 0; i < raw.Length; i++)
            {
                if (specialSymbols.Contains(raw[i]))
                {
                    toggle = false;
                    symbols.Add(raw[i]);
                    strArr.Add("");
                    continue;
                }
                else if (specialEngineerSymbols.Contains(raw[i]))
                {
                    var specialSymbol = raw[i]; 

                    if(toggle is true)
                        strArr.Add("");
                    
                    StringBuilder res = new StringBuilder();
                    
                    for (int j = i + 2; j < raw.Length; j++)
                    {
                        if (")]".Contains(raw[j]))
                        {
                            i = j;
                            break;
                        }
                        res.Append(raw[j]);
                    }
                    if (specialSymbol == '#')
                    {
                        double.TryParse(res.ToString(), out double resultInDouble);
                        strArr[strArr.Count - 1] += ((decimal)Math.Sin(resultInDouble)).ToString();
                    }
                    if (specialSymbol == '@')
                    {
                        double.TryParse(res.ToString(), out double resultInDouble);
                        strArr[strArr.Count - 1] += ((decimal)Math.Cos(resultInDouble)).ToString();
                    }
                    if (specialSymbol == '$')
                    {
                        double.TryParse(res.ToString(), out double resultInDouble);
                        strArr[strArr.Count - 1] += ((decimal)Math.Abs(resultInDouble)).ToString();
                    }
                    if (specialSymbol == '?')
                    {
                        double.TryParse(res.ToString(), out double resultInDouble);
                        strArr[strArr.Count - 1] += ((decimal)Math.Log(resultInDouble)).ToString();
                    }
                    toggle = true;
                    continue;
                }

                strArr[strArr.Count - 1] += raw[i];
            }

            foreach (var item in strArr)
            {
                arr.Add(Convert.ToDecimal(item));
            }

            decimal sum = arr[0];
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
            var content = lResult.Content.ToString();
            for (int i = content.Length - 1; i >= 0; i--)
            {
                if (")]".Contains(content[i]))
                {
                    break;
                }
                else if ("([".Contains(content[i]))
                {
                    lResult.Content += (content[i] == '(') ? ")" : "]";
                    raw.Append((content[i] == '(') ? ")" : "]");
                }
            }

            raw.Append(bPlus.Content.ToString());
            lResult.Content += bPlus.Content.ToString();
        }

        private void BMinus_Click(object sender, RoutedEventArgs e)
        {
            var content = lResult.Content.ToString();
            for (int i = content.Length - 1; i >= 0; i--)
            {
                if (")]".Contains(content[i]))
                {
                    break;
                }
                else if ("([".Contains(content[i]))
                {
                    lResult.Content += (content[i] == '(') ? ")" : "]";
                    raw.Append((content[i] == '(') ? ")" : "]");
                }
            }

            raw.Append(bMinus.Content.ToString());
            lResult.Content += bMinus.Content.ToString();
        }

        private void BMultiply_Click(object sender, RoutedEventArgs e)
        {
            var content = lResult.Content.ToString();
            for (int i = content.Length - 1; i >= 0; i--)
            {
                if (")]".Contains(content[i]))
                {
                    break;
                }
                else if ("([".Contains(content[i]))
                {
                    lResult.Content += (content[i] == '(') ? ")" : "]";
                    raw.Append((content[i] == '(') ? ")" : "]");
                }
            }

            raw.Append(bMultiply.Content.ToString());
            lResult.Content += bMultiply.Content.ToString();
        }

        private void BDivision_Click(object sender, RoutedEventArgs e)
        {
            var content = lResult.Content.ToString();
            for (int i = content.Length - 1; i >= 0; i--)
            {
                if (")]".Contains(content[i]))
                {
                    break;
                }
                else if ("([".Contains(content[i]))
                {
                    lResult.Content += (content[i] == '(') ? ")" : "]";
                    raw.Append((content[i] == '(') ? ")" : "]");
                }
            }

            raw.Append(bDivision.Content.ToString());
            lResult.Content += bDivision.Content.ToString();
        }

        /// <summary>
        /// sin symbol: #
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BSin_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += bSin.Content.ToString() + "(";
            raw.Append("#(");
        }

        /// <summary>
        /// cos symbol: @
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BCos_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += bCos.Content.ToString() + "(";
            raw.Append("@(");
        }

        /// <summary>
        /// log symbol: ?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BLog_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += bLog.Content.ToString() + "(";
            raw.Append("?(");
        }

        /// <summary>
        /// module symbol: $
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BModuleX_Click(object sender, RoutedEventArgs e)
        {
            lResult.Content += "[";
            raw.Append("$[");
        }


        private void MenuItemClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItemSimpleCalc_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 496;
        }
        private void MenuItemEngineerCalc_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 629;
        }
        private void MenuItemRef_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
