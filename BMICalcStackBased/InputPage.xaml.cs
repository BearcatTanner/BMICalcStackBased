using Microsoft.Maui.Animations;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace BMICalcStackBased;

public partial class InputPage : ContentPage
{
    string choice = "";
    public InputPage()
	{
		InitializeComponent();
	}

    private void TappedMale_Tapped(object sender, TappedEventArgs e)
    {
        choice = "Male";
        FrameMale.BorderColor = Color.FromRgba("#0a0e29");
        FrameFemale.BorderColor = Color.FromRgba("#fdfdfd");
        CalculateBMI.BackgroundColor = Color.FromRgba("#8bcaff");
    }

    private void TappedFemale_Tapped(object sender, TappedEventArgs e)
    {
        choice = "Female";
        FrameFemale.BorderColor = Color.FromRgba("#0a0e29");
        FrameMale.BorderColor = Color.FromRgba("#fdfdfd");
        CalculateBMI.BackgroundColor = Color.FromRgba("#ff94d4");
    }

    private void CalculateBMI_Clicked(object sender, EventArgs e)
    {
        if (choice == "")
        {
            DisplayAlert("Unselected Gender", "Please select a gender", "OK");
        }
        else
        {
            string Chosen = choice;
            int BMI = (Convert.ToInt32(LblWeight.Text) * 703) / (Convert.ToInt32(LblHeight.Text) * Convert.ToInt32(LblHeight.Text));
            Navigation.PushAsync(new ResultPage(Chosen, BMI));

        }
    }

 
}