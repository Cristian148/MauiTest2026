
using MauiTest.MVVM.ViewModels;
using MauiTest.MVVM.Views;

namespace MauiTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new NavigationPage(new ContentPageDemo()));
            //var navPage = new NavigationPage(new ContentPageDemo());
            //navPage.BarBackgroundColor = Colors.Chocolate;
            //navPage.BarTextColor = Colors.White;
            //navPage.Title = "MauiTest";
            //return new Window(navPage);

            //return new Window(new NavigationPage( new FlyoutPageDemo()));
            return new Window(new NavigationPage(new QRCodeGenerator()));

        }
    }
}