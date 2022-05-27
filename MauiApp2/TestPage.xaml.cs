using MauiApp2.ViewModel;

namespace MauiApp2;

public partial class TestPage : ContentPage
{
	public TestPage()
	{
		InitializeComponent();
		BindingContext = new TestPageViewModel();
	}
}