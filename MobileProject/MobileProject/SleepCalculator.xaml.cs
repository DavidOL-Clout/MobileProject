using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SleepCalculator : ContentPage
	{

		public SleepCalculator ()
		{
			InitializeComponent ();
		}
        //When Calculate button is clicked performs calculations
        private void BtnCalculate_Clicked(object sender, EventArgs e)
        {
            float resultMins;
            float optimumHourSleep = 8;
            float timeToCollegeMins;
            float timePrepare;
            float hourToMin = 60;
            float minToHour = 1 / 60;
            float timeReady, timeToCollege, timeCollegeHour, timeCollegeMinute = 0;

            //Reading in variables from entry boxes
            timeReady = (float)Convert.ToDecimal(EntryTimeToReady.Text);
            timeToCollege = (float)Convert.ToDecimal(EntryTimeToCollege.Text);
            timeCollegeHour = (float)Convert.ToDecimal(EntryTimeCollegeHour.Text);
            timeCollegeMinute = (float)Convert.ToDecimal(EntryTimeCollegeMinute.Text);

            bool isReadyEmpty = true, isCollegeEmpty = true, isHourEmpty = true;

            // IsNullOrEmpty is a static method
            isReadyEmpty = string.IsNullOrEmpty(EntryTimeToReady.Text);
            isCollegeEmpty = string.IsNullOrEmpty(EntryTimeToCollege.Text);
            isHourEmpty = string.IsNullOrEmpty(EntryTimeCollegeHour.Text);

            // if is variables = true, then do nothing
            if (isReadyEmpty || isCollegeEmpty || isHourEmpty)
            {
                // do nothing
                LblAnswer.Text = "Please enter a values (numbers only)";
                return;
            }

            timePrepare = timeReady + timeToCollege;
            
            timeToCollegeMins = (timeCollegeHour * hourToMin) + timeCollegeMinute;
            resultMins = (timeToCollegeMins) - (optimumHourSleep * hourToMin) - timePrepare ;
            TimeSpan ts = TimeSpan.FromMinutes(resultMins);
            LblAnswer.Text = string.Format("The Optimal time to Sleep is at: {0} : {1}", ts.Hours, ts.Minutes);
            



        }

        private async void Home_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}