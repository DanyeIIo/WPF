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

namespace FirstTest
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

        //private void Button1_Click(object sender, RoutedEventArgs e)
        //{
        //    button1.Content = "Hello hell";
        //    button1.Width = 228;
        //    //button1.Content = ;
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //lResult.Content = string.Empty;
            //bool res = true;
            //if (fio.ToString().Split(' ').Count() != 2)
            //{
            //    res = false;
            //    lResult.Content += "Uncorrect! Input first and last names\n";
            //}
            //bool checkData = DateTime.TryParse(date.ToString(), out DateTime dateOfBirth);

            //if (!checkData)
            //{
            //    res = false;
            //    lResult.Content += "Uncorrect input of Date of birth\n";
            //}
            //else if (dateOfBirth > DateTime.UtcNow)
            //{
            //    res = false;
            //    lResult.Content += "Birthdate can't be more than current time\n";
            //}
            //if (pass.Text != passVerif.Text)
            //{
            //    res = false;
            //    lResult.Content += "passwords aren't equal\n";
            //    return;
            //}
            //if (res is true)
            //{
            //    lResult.Content = "All is fine";
            //}
            ///2
            //int.TryParse(countOfPerson.Text, out int personCount);
            //int.TryParse(ticketCost.Text, out int costTicker);
            //int.TryParse(hotelCost.Text, out int costHotel);
            //int.TryParse(countDaysInHotel.Text, out int daysInHotel);
            //int.TryParse(visaСosts.Text, out int costVisa);
            //int.TryParse(excursionCostLimit.Text, out int costExcursion);


            //if (personCount <= 0 || costTicker <= 0 || costHotel <= 0 || daysInHotel <= 0 || costVisa <= 0 || costExcursion <= 0)
            //{
            //    lResult.Content = $"Wrong Input!";
            //    return;
            //}

            //decimal money = personCount * costTicker;
            //money += personCount * costHotel * daysInHotel;
            //money += costVisa * personCount;
            //money += costExcursion;

            //lResult.Content = $"Total sum is {money} in kz\n";
            //lResult.Content += $"Total sum is {money * 400} in dollars\n";
            //lResult.Content += $"Total sum is {money * 6} in rubles";
            var res = numbers.Text.ToString().Split(' ');

            lResult.Content = string.Empty;
            
            if (res.Count() != 2)
            {
                lResult.Content = "Enter 2 numbers by space again!!!";
                return;
            }
            
            int[] arr = new int[2];
            
            for (int i = 0; i < 2; i++)
            {
                int.TryParse(res[i], out arr[i]);
            }

            if (arr[0] > arr[1])
            {
                lResult.Content = "first number can not be more than second!";
                return;
            }

            uint counter = 0;

            for (int i = arr[0]; i <= arr[1]; i++)
            {
                if (++counter == 10)
                {
                    lResult.Content += "\n";
                    counter = 0;
                }

                lResult.Content += (0.25 * i - 50).ToString() + " ";
            }
        }
    }
}
