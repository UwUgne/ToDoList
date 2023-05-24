namespace Notes.Views;

public partial class About : ContentPage
{
	public About()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.AboutP about)
            // Navigate to the specified URL in the system browser.
            await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}