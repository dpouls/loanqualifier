using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoanQual
{
    public partial class MainPage : ContentPage
    {
        const int MIN_YEARS = 3;
        const decimal MIN_SALARY = 40000.00m;
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQualify_Clicked(object sender, EventArgs e)
        {
            // validate user input for year
            if (int.TryParse(YearsEntry.Text,out int years))
            {
                //validate salary input
                if(decimal.TryParse(SalaryEntry.Text, out decimal salary))
                {
                    if(years >= MIN_YEARS)
                    {
                        if(salary >= MIN_SALARY)
                        {
                            DisplayAlert("You Qualify!", "You have qualified for the loan.", "Close");

                        }
                        else
                        {
                            DisplayAlert("Not Qualified", "You must have a job for at least 3 years.", "Close");
                        }
                    }
                    else
                    {
                        DisplayAlert("Not Qualified", "You must have a job for at least 3 years.", "Close");
                    }
                }
                else
                {
                    DisplayAlert("Invalid Input", "please enter a number for the salary", "Close");
                }
            }
            else
            {
                DisplayAlert("Invalid Input", "Please enter an integer for the years.", "Close");
            }
        }
    }
}
