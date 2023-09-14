using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PointOfSaleApp.Models;
using PointOfSaleApp.Pages.Mobile;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace PointOfSaleApp.ViewModels
{
    public partial class OrdersViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Order> _orders;

        [RelayCommand]
        private async Task PayAsync(object obj)
        {
            try
            {
                var navigationParameter = new Dictionary<string, object>
                {
                    {"Order",this }
                };
                await Shell.Current.GoToAsync($"{nameof(OrderDetailsPage)}", navigationParameter);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            //await Shell.Current.GoToAsync("OrderDetailsPage");
        }

        public OrdersViewModel() 
        {
            Orders = new ObservableCollection<Order>(AppData.Orders);
        }
        
    }
}
