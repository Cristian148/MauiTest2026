namespace MauiTest;

public partial class AnotherPage : ContentPage
{
	public AnotherPage()
	{
		InitializeComponent();
	}
    void goBack(System.Object sender, System.EventArgs e)
    {
        Navigation.PopAsync();
    }
}