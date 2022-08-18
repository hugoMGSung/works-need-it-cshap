namespace MauiFirstApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		Button button = new Button
		{
			Text = "Navigate!!",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};

		button.Clicked += async (sender, args) =>
		{
			await Navigation.PushAsync(new SliderTestPage());
		};

		GrdMain.Children.Add(button);
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		//CounterLabel.Text = $"Current count: {count}";

		//SemanticScreenReader.Announce(CounterLabel.Text);
	}
}

