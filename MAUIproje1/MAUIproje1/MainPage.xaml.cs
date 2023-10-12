namespace MAUIproje1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		sayi = 0;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
	int sayi;

    private async void deneme_Clicked(object sender, EventArgs e)
    {
     sayi++;
     denemeLabel.Text = sayi.ToString();
		await Navigation.PushAsync(new NewPage1());

    }
}

