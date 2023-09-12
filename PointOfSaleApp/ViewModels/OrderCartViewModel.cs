using CommunityToolkit.Mvvm.ComponentModel;
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
    }
}
