namespace MauiFirstApp;

public partial class SliderTestPage : ContentPage
{
	public SliderTestPage()
	{
		InitializeComponent();
	}

    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        LblValue.Text = e.NewValue.ToString("F3");
    }

    async void OnButtonClicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        await DisplayAlert("Clicked!", $"'{button.Text}' 버튼 클릭함!", "OK");
    }
}