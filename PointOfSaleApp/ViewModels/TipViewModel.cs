using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PointOfSaleApp.Models;

namespace PointOfSaleApp.ViewModels
{
    [QueryProperty("Order","Order")]
    public partial class TipViewModel : ObservableObject
    {
        [ObservableProperty]
        Order order;

        [ObservableProperty]
        double tip;

        partial void OnTipChanged(double value)
        {
            Order.Tip = value;
            OnPropertyChanged(nameof(Order));
        }


        public TipViewModel() 
        {

        }        

        [RelayCommand]
        private async Task Continue(object obj)
        {
            await Shell.Current.GoToAsync("PayPage", new Dictionary<string, object>
            {
                ["Order"] = (Order)obj
            });
        }
    }
}
