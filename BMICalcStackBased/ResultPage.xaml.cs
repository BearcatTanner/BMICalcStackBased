namespace BMICalcStackBased;

public partial class ResultPage : ContentPage
{
	public ResultPage(string chosen, int BMI)
	{
        
		InitializeComponent();
        LblBMIValue.Text = BMI.ToString();
        if (chosen== "Male")
        {
            if (BMI < 18.5)
            {
                LblBMICategory.Text = "Underweight";
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                LblBMICategory.Text = "Normal weight";
            }
            else if (BMI >= 25 && BMI < 30)
            {
                LblBMICategory.Text = "Overweight";
            }
            else if (BMI >= 30)
            {
                LblBMICategory.Text = "Obese";
            }
        }
        else if (chosen == "Female")
        {
            if (BMI < 18)
            {
                LblBMICategory.Text = "Underweight";
            }
            else if (BMI >= 18 && BMI < 24)
            {
                LblBMICategory.Text = "Normal weight";
            }
            else if (BMI >= 24 && BMI < 29)
            {
                LblBMICategory.Text = "Overweight";
            }
            else if (BMI >= 29)
            {
                LblBMICategory.Text = "Obese";
            }
        }

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        string BMICategory = LblBMICategory.Text;
        Navigation.PushAsync(new RecomPage(BMICategory));
    }
}