namespace MauiTest.MVVM.Views;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();

		BindingContext = new ViewModels.CommandsViewModel();
    }
}