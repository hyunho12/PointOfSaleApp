using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PointOfSaleApp.Models;
using PointOfSaleApp.Pages.Mobile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleApp.ViewModels
{
    [QueryProperty("Order","Order")]
    public partial class PayViewModel : ObservableObject
    {
        [ObservableProperty]
        Order order;

        [RelayCommand]
        public async Task Pay()
        {
            var navigationParameter = new Dictionary<string, object>
            {
                {"Order", order }
            };
            await Shell.Current.GoToAsync($"{nameof(SignaturePage)}", navigationParameter);
        }
    }
}
