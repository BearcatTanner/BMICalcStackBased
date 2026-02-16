namespace BMICalcStackBased;

public partial class RecomPage : ContentPage
{
	public RecomPage(string BMICategory)
	{
		InitializeComponent();
		if (BMICategory == "Underweight")
		{
			LblRecommendation.Text = "-Increase calorie intake with nutrient-rich foods (e.g., nuts, lean protein, whole grains)." +
				"Incorporate strength training to build muscle mass. \r\n-Consult a nutritionist if needed.";

        }

		else if (BMICategory == "Normal weight")
		{
            LblRecommendation.Text = "-Maintain a balanced diet with proteins, healthy fats, and fiber. Stay physically active with at least 150 minutes of exercise per week." +
                 "\r\n-Keep regular check-ups to monitor overall health.";

        }

        else if (BMICategory == "Overweight")
        {
            LblRecommendation.Text = "-Reduce processed foods and focus on portion control. Engage in regular " +
                        "aerobic exercises(e.g., jogging, swimming) and strength training.\r\n-Drink " +
                        "plenty of water and track your progress.";
        }

        else if (BMICategory == "Obese")
        {
            LblRecommendation.Text = "-Consult a doctor for personalized guidance. Start with low-impact " +
                        "exercises(e.g., walking, cycling).\r\n-Follow a structured weight-loss meal " +
                        "plan and consider behavioral therapy for lifestyle changes. Avoid sugary " +
                        "drinks and maintain a consistent sleep schedule.";
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}