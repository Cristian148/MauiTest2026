namespace MauiTest.MVVM.Views;

public partial class PeopleView : ContentPage
{
	public PeopleView()
	{
		InitializeComponent();
		this.BindingContext = new ViewModels.PeopleViewModel();
    }
}