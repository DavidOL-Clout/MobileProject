﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Monday());
        }

        private async void Button_Clicked_SleepCal(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SleepCalculator());
        }
    }
}