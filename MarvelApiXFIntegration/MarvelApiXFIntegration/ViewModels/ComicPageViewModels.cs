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
     public class ComicPageViewModels : INotifyPropertyChanged
    {
        
        private IApiService apiService = new ApiService();

        

        public ObservableCollection<Comic> Comics { get; set; }

        public ComicPageViewModels()
        {
            LoadComicList();
        }

       async Task LoadComicList() 
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                try
                {
                    var a = await apiService.GetComic();
                    Comics = new ObservableCollection<Comic>(a.Data.Results);
                }
                catch (Exception ex)
                {

                    Debug.WriteLine($"API EXCEPTION {ex}");
                }
                
            }
            
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
