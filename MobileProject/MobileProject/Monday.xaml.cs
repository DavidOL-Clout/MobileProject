using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


//Comments in this section are the same for Tuesday - Friday

namespace MobileProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Monday : ContentPage
	{
		public Monday ()
		{
			InitializeComponent ();
		}
        //Back button linked to Page1(Home Page)
        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
        // Linked to monday - friday below
        private async void MondayButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Monday());
        }
        private async void TuesdayButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tuesday());
        }
        private async void WednesdayButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Wednesday());
        }
        private async void ThursdayButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Thursday());
        }
        private async void FridayButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Friday());
        }
        //when button is clicked displays entry boxes to edit info, makes all slots invisble and the editor visible (Same for Edit1-5)
        private void Edit1_Clicked(object sender, EventArgs e)
        {
            Editor1.IsVisible = true;
            Slot1.IsVisible = false;
            Slot2.IsVisible = false;
            Slot3.IsVisible = false;
            Slot4.IsVisible = false;
            Slot5.IsVisible = false;

            SlotTime1.IsVisible = false;
            SlotTime2.IsVisible = false;
            SlotTime3.IsVisible = false;
            SlotTime4.IsVisible = false;
            SlotTime5.IsVisible = false;

            SlotButton1.IsVisible = false;
            SlotButton2.IsVisible = false;
            SlotButton3.IsVisible = false;
            SlotButton4.IsVisible = false;
            SlotButton5.IsVisible = false;

        }



        private void Edit2_Clicked(object sender, EventArgs e)
        {
            Editor2.IsVisible = true;
            Slot1.IsVisible = false;
            Slot2.IsVisible = false;
            Slot3.IsVisible = false;
            Slot4.IsVisible = false;
            Slot5.IsVisible = false;

            SlotTime1.IsVisible = false;
            SlotTime2.IsVisible = false;
            SlotTime3.IsVisible = false;
            SlotTime4.IsVisible = false;
            SlotTime5.IsVisible = false;

            SlotButton1.IsVisible = false;
            SlotButton2.IsVisible = false;
            SlotButton3.IsVisible = false;
            SlotButton4.IsVisible = false;
            SlotButton5.IsVisible = false;

        }

        private void Edit3_Clicked(object sender, EventArgs e)
        {
            Editor3.IsVisible = true;
            Slot1.IsVisible = false;
            Slot2.IsVisible = false;
            Slot3.IsVisible = false;
            Slot4.IsVisible = false;
            Slot5.IsVisible = false;

            SlotTime1.IsVisible = false;
            SlotTime2.IsVisible = false;
            SlotTime3.IsVisible = false;
            SlotTime4.IsVisible = false;
            SlotTime5.IsVisible = false;

            SlotButton1.IsVisible = false;
            SlotButton2.IsVisible = false;
            SlotButton3.IsVisible = false;
            SlotButton4.IsVisible = false;
            SlotButton5.IsVisible = false;
        }

        private void Edit4_Clicked(object sender, EventArgs e)
        {
            Editor4.IsVisible = true;
            Slot1.IsVisible = false;
            Slot2.IsVisible = false;
            Slot3.IsVisible = false;
            Slot4.IsVisible = false;
            Slot5.IsVisible = false;

            SlotTime1.IsVisible = false;
            SlotTime2.IsVisible = false;
            SlotTime3.IsVisible = false;
            SlotTime4.IsVisible = false;
            SlotTime5.IsVisible = false;

            SlotButton1.IsVisible = false;
            SlotButton2.IsVisible = false;
            SlotButton3.IsVisible = false;
            SlotButton4.IsVisible = false;
            SlotButton5.IsVisible = false;
        }

        private void Edit5_Clicked(object sender, EventArgs e)
        {
            Editor5.IsVisible = true;
            Slot1.IsVisible = false;
            Slot2.IsVisible = false;
            Slot3.IsVisible = false;
            Slot4.IsVisible = false;
            Slot5.IsVisible = false;

            SlotTime1.IsVisible = false;
            SlotTime2.IsVisible = false;
            SlotTime3.IsVisible = false;
            SlotTime4.IsVisible = false;
            SlotTime5.IsVisible = false;

            SlotButton1.IsVisible = false;
            SlotButton2.IsVisible = false;
            SlotButton3.IsVisible = false;
            SlotButton4.IsVisible = false;
            SlotButton5.IsVisible = false;
        }

        //Saves changes as per Entry box inputs, and formats the tiem to display correctly. Reverses visabilty from Edit Buttons (Same for SaveChanges1-5)
        private void SaveChanges1_Clicked(object sender, EventArgs e)
        {
            String module1Name;
            String hour;
            String minute;
            String displayTime;

            module1Name = Convert.ToString(Module1Name.Text);
            Module1.Text = module1Name;
            hour = Convert.ToString(TimeHour1.Text);
            minute = Convert.ToString(TimeMinute1.Text);
            displayTime = string.Format("{0} : {1}", hour, minute);

            Time1.Text = displayTime;
            Editor1.IsVisible = false;
            Slot1.IsVisible = true;
            Slot2.IsVisible = true;
            Slot3.IsVisible = true;
            Slot4.IsVisible = true;
            Slot5.IsVisible = true;

            SlotTime1.IsVisible = true;
            SlotTime2.IsVisible = true;
            SlotTime3.IsVisible = true;
            SlotTime4.IsVisible = true;
            SlotTime5.IsVisible = true;

            SlotButton1.IsVisible = true;
            SlotButton2.IsVisible = true;
            SlotButton3.IsVisible = true;
            SlotButton4.IsVisible = true;
            SlotButton5.IsVisible = true;
            DisplayAlert("Item Added", module1Name , "OK");
        }

        private void SaveChanges2_Clicked(object sender, EventArgs e)
        {
            String module1Name;
            String hour;
            String minute;
            String displayTime;

            module1Name = Convert.ToString(Module2Name.Text);
            Module2.Text = module1Name;
            hour = Convert.ToString(TimeHour2.Text);
            minute = Convert.ToString(TimeMinute2.Text);
            displayTime = string.Format("{0} : {1}", hour, minute);

            Time2.Text = displayTime;
            Editor2.IsVisible = false;
            Slot1.IsVisible = true;
            Slot2.IsVisible = true;
            Slot3.IsVisible = true;
            Slot4.IsVisible = true;
            Slot5.IsVisible = true;

            SlotTime1.IsVisible = true;
            SlotTime2.IsVisible = true;
            SlotTime3.IsVisible = true;
            SlotTime4.IsVisible = true;
            SlotTime5.IsVisible = true;

            SlotButton1.IsVisible = true;
            SlotButton2.IsVisible = true;
            SlotButton3.IsVisible = true;
            SlotButton4.IsVisible = true;
            SlotButton5.IsVisible = true;
            DisplayAlert("Item Added", module1Name, "OK");
        }

        private void SaveChanges3_Clicked(object sender, EventArgs e)
        {
            String module1Name;
            String hour;
            String minute;
            String displayTime;

            module1Name = Convert.ToString(Module3Name.Text);
            Module3.Text = module1Name;
            hour = Convert.ToString(TimeHour3.Text);
            minute = Convert.ToString(TimeMinute3.Text);
            displayTime = string.Format("{0} : {1}", hour, minute);

            Time3.Text = displayTime;
            Editor3.IsVisible = false;

            Slot1.IsVisible = true;
            Slot2.IsVisible = true;
            Slot3.IsVisible = true;
            Slot4.IsVisible = true;
            Slot5.IsVisible = true;

            SlotTime1.IsVisible = true;
            SlotTime2.IsVisible = true;
            SlotTime3.IsVisible = true;
            SlotTime4.IsVisible = true;
            SlotTime5.IsVisible = true;

            SlotButton1.IsVisible = true;
            SlotButton2.IsVisible = true;
            SlotButton3.IsVisible = true;
            SlotButton4.IsVisible = true;
            SlotButton5.IsVisible = true;
            DisplayAlert("Item Added", module1Name, "OK");
        }

        private void SaveChanges4_Clicked(object sender, EventArgs e)
        {
            String module1Name;
            String hour;
            String minute;
            String displayTime;

            module1Name = Convert.ToString(Module4Name.Text);
            Module4.Text = module1Name;
            hour = Convert.ToString(TimeHour4.Text);
            minute = Convert.ToString(TimeMinute4.Text);
            displayTime = string.Format("{0} : {1}", hour, minute);

            Time4.Text = displayTime;
            Editor4.IsVisible = false;

            Slot1.IsVisible = true;
            Slot2.IsVisible = true;
            Slot3.IsVisible = true;
            Slot4.IsVisible = true;
            Slot5.IsVisible = true;

            SlotTime1.IsVisible = true;
            SlotTime2.IsVisible = true;
            SlotTime3.IsVisible = true;
            SlotTime4.IsVisible = true;
            SlotTime5.IsVisible = true;

            SlotButton1.IsVisible = true;
            SlotButton2.IsVisible = true;
            SlotButton3.IsVisible = true;
            SlotButton4.IsVisible = true;
            SlotButton5.IsVisible = true;
            DisplayAlert("Item Added", module1Name, "OK");
        }

        private void SaveChanges5_Clicked(object sender, EventArgs e)
        {
            String module1Name;
            String hour;
            String minute;
            String displayTime;

            module1Name = Convert.ToString(Module5Name.Text);
            Module5.Text = module1Name;
            hour = Convert.ToString(TimeHour5.Text);
            minute = Convert.ToString(TimeMinute5.Text);
            displayTime = string.Format("{0} : {1}", hour, minute);

            Time5.Text = displayTime;
            Editor5.IsVisible = false;

            Slot1.IsVisible = true;
            Slot2.IsVisible = true;
            Slot3.IsVisible = true;
            Slot4.IsVisible = true;
            Slot5.IsVisible = true;

            SlotTime1.IsVisible = true;
            SlotTime2.IsVisible = true;
            SlotTime3.IsVisible = true;
            SlotTime4.IsVisible = true;
            SlotTime5.IsVisible = true;

            SlotButton1.IsVisible = true;
            SlotButton2.IsVisible = true;
            SlotButton3.IsVisible = true;
            SlotButton4.IsVisible = true;
            SlotButton5.IsVisible = true;
            //Displays Alert for added item
            DisplayAlert("Item Added", module1Name, "OK");
            // Did not include empty entry if statement like in Sleep Calc as I want this to be fully optional
        }


    }
}