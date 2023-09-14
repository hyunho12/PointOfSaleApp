using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PointOfSaleApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleApp.ViewModels
{
    public partial class SettingsViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Item> _products;

        public SettingsViewModel()
        {
            Products = new ObservableCollection<Item>(AppData.Items);
        }

        [RelayCommand]
        public async Task NotImplemented()
        {
            await App.Current.MainPage.DisplayAlert("Not Implemented", "Wouldn't it be nice?", "Okay");
        }
    }
}
