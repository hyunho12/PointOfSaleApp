using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PointOfSaleApp.Models;
using PointOfSaleApp.Pages.Mobile;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace PointOfSaleApp.ViewModels
{
    [QueryProperty("Order","Order")]
    public partial class OrderDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        Order order;

        public OrderDetailViewModel()
        {

        }

        [RelayCommand]
        async Task Pay()
        {
            try
            {
                var navigationParameter = new Dictionary<string, object>
            {
                { "Order", order }
            };
                await Shell.Current.GoToAsync($"{nameof(TipPage)}", navigationParameter);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        //[RelayCommand]
        //async Task Pay(object obj)
        //{
        //    try
        //    {
        //        await Shell.Current.GoToAsync("TipPage", new Dictionary<string, object>
        //        {
        //            ["Order"] = (Order)obj
        //        });
        //    } catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.Message);
        //    }            
        //}

        [RelayCommand]
        private async Task Add()
        {
            await Shell.Current.GoToAsync($"{nameof(ScanPage)}");
        }
    }
}
