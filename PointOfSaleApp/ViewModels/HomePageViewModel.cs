using CommunityToolkit.Mvvm.ComponentModel;
using PointOfSaleApp.Models;
using System.Collections.ObjectModel;

namespace PointOfSaleApp.ViewModels
{
    public partial class HomePageViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Item> products;

        [ObservableProperty]
        private string category = ItemCategory.Noodles.ToString();

        public HomePageViewModel() 
        {
            Products = new ObservableCollection<Item>(AppData.Items.Where(x=>x.Category == ItemCategory.Noodles).ToList());
        }
    }
}
