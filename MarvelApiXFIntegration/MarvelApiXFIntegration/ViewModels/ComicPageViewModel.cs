using MarvelApiXFIntegration.Models;
using MarvelApiXFIntegration.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace MarvelApiXFIntegration.ViewModels
{
     public class ComicPageViewModel : INotifyPropertyChanged
    {
        
       IApiService apiService = new ApiService();


        const string Ae = "API EXCEPTION";
        public ObservableCollection<Comic> Comics { get; set; }

        public ComicPageViewModel()
        {
            LoadComicList();
        }

       async Task LoadComicList() 
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                try
                {
                    var getresult = await apiService.GetComic();
                    Comics = new ObservableCollection<Comic>(getresult.Data.Results);
                }
                catch (Exception ex)
                {
                     
                    Debug.WriteLine($"{Ae} {ex}");
                    
                }

            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Ups", "Internet Conection Needed", "ok");
            }
            
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
