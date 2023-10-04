using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PointOfSaleApp.Models;
using PointOfSaleApp.Pages.Mobile;

namespace PointOfSaleApp.ViewModels
{
    [QueryProperty("Order","Order")]
    public partial class SignatureViewModel : ObservableObject
    {
        [ObservableProperty]
        Order order;

        public SignatureViewModel()
        {

        }

        [RelayCommand]
        public async Task Done()
        {
            var navigationParameter = new Dictionary<string, object>
            {
                {"Order", order }
            };
            await Shell.Current.GoToAsync($"{nameof(ReceiptPage)}", navigationParameter);
        }

        [RelayCommand]
        public async void Clear()
        {

        }
    }
}
