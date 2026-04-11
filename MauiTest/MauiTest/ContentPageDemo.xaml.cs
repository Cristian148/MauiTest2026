namespace MauiTest;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}
    void anotherPage(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new AnotherPage());
    }

}