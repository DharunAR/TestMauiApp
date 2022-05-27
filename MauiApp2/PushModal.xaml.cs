namespace MauiApp2;

public partial class PushModal : ContentPage
{
	public PushModal()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new AppShell();

        GetTaskAsync();
    }

    async Task GetTaskAsync()
    {
        await Shell.Current.GoToAsync($"{nameof(DetailPage)}");
    }
}