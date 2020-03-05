using MarvelApiXFIntegration.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MarvelApiXFIntegration.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComicPage : ContentPage
    {
        public ComicPage()
        {
            InitializeComponent();
            BindingContext = new ComicPageViewModel();
        }
    }
}