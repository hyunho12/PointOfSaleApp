using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PointOfSaleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleApp.ViewModels
{
    public partial class OrderCartViewModel : ObservableObject
    {
        [ObservableProperty]
        public Order order;

        public OrderCartViewModel()
        {
            Order = AppData.Orders.First();
        }

        [RelayCommand]
        public async Task PlaceOrder()
        {
            await App.Current.MainPage.DisplayAlert("Not Implemented", "Wouldn't it be cool tho?", "Okay");
        }
    }
}
