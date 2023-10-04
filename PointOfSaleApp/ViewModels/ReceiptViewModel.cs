using CommunityToolkit.Mvvm.ComponentModel;
using PointOfSaleApp.Models;

namespace PointOfSaleApp.ViewModels
{
    [QueryProperty("Order","Order")]
    public partial class ReceiptViewModel : ObservableObject
    {
        [ObservableProperty]
        Order order;

        public ReceiptViewModel() 
        {
        }
    }
}
