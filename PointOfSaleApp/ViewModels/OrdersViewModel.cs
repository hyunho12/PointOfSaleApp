using CommunityToolkit.Mvvm.ComponentModel;
using PointOfSaleApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleApp.ViewModels
{
    public partial class OrdersViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Order> _orders;

        public OrdersViewModel() 
        {
            Orders = new ObservableCollection<Order>(AppData.Orders);
        }
    }
}
