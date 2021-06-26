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

namespace PythagorasTheorem
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tbRes.Text = string.Empty;

            int.TryParse(tbInput.Text, out int finishRes);
            int tmpRes = 0;

            var pifagorDate = new List<DateTime>();
            var date = DateTime.Now;
            

            if (tbInput.Text is null)
            {
                tbRes.Text = "Input count of pythagoras that u need and try again!";
                return;
            }

            if (finishRes == 0)
            {
                tbRes.Text = "Number can not be less and equal to 0!";
                return;
            }

            if (rb1.IsChecked == false && rb2.IsChecked == false && rb3.IsChecked == false)
            {
                tbRes.Text = "Enter the any radio button and try again!";
                return;
            }

            int addDay = 1;

            if (rb1.IsChecked == true)
            {
                pifagorDate = GetDates(tmpRes, finishRes, date, addDay).ToList();
            }

            if (rb2.IsChecked == true)
            {
                addDay = -1;
                pifagorDate = GetDates(tmpRes, finishRes, date, -1, addDay).ToList();
            }

            if (rb3.IsChecked == true)
            {
                date = date.AddYears(1000);
                pifagorDate = GetDates(tmpRes, finishRes, date, addDay).ToList();
            }

            foreach (var pd in pifagorDate)
            {
                tbRes.Text += $"Year: {pd.Year} | Month: {pd.Month} | Day: {pd.Day}\n";
            }

        }

        /// <summary>
        /// Finding Pythagoras dates => sqrt(month) + sqrt(day) == sqrt(year)
        /// </summary>
        /// <param name="tmpRes"></param>
        /// <param name="finishRes"></param>
        /// <param name="date"></param>
        /// <param name="addDay"></param>
        /// <returns>all Pythagoras dates</returns>
        public IEnumerable<DateTime> GetDates(int tmpRes, int finishRes, DateTime date, int addDay)
        {
            var pifagorDate = new List<DateTime>();

            while (tmpRes < finishRes)
            {
                int.TryParse(date.Year.ToString().Substring(2), out int dateYear);

                if (Math.Pow(date.Day, 2) + Math.Pow(date.Month, 2) == Math.Pow(dateYear, 2))
                {
                    pifagorDate.Add(date);
                    tmpRes++;
                }

                if (date.DayOfYear == 365 && !(date.Year % 4 == 0 && (date.Year % 100 != 0 || date.Year % 400 == 0)))
                {
                    date = date.AddYears(1);
                }

                if (date.DayOfYear == 366)
                {
                    date = date.AddYears(1);
                }

                date = date.AddDays(addDay);
            }

            return pifagorDate.ToArray();
        }

        /// <summary>
        /// Finding Pythagoras dates => sqrt(month) + sqrt(day) == sqrt(year)
        /// Can to add negative days + years
        /// </summary>
        /// <param name="tmpRes"></param>
        /// <param name="finishRes"></param>
        /// <param name="date"></param>
        /// <param name="addDay"></param>
        /// <returns>all Pythagoras dates</returns>
        public IEnumerable<DateTime> GetDates(int tmpRes, int finishRes, DateTime date, int addYear, int addDay)
        {
            var pifagorDate = new List<DateTime>();

            while (tmpRes < finishRes)
            {
                int.TryParse(date.Year.ToString().Substring(2), out int dateYear);

                if (Math.Pow(date.Day, 2) + Math.Pow(date.Month, 2) == Math.Pow(dateYear, 2))
                {
                    pifagorDate.Add(date);
                    tmpRes++;
                }

                if (date.DayOfYear == 1)
                {
                    date = date.AddYears(addYear);
                }

                //if (date.DayOfYear == 366)
                //{
                //    date = date.AddYears(addYear);
                //}

                date = date.AddDays(addDay);
            }

            return pifagorDate.ToArray();
        }   
    }
}
