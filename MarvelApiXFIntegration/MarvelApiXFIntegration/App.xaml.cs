using MarvelApiXFIntegration.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MarvelApiXFIntegration
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ComicPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
