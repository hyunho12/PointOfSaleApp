using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleApp.Models
{
    public class Item
    {
        public string title { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public string image { get; set; }

        public double SubTotal
        {
            get => price * quantity;
        }
    }

    public enum ItemCategory
    {
        Noodles,
        Rice,
        Appetizers,
        Desserts,
        Beverages
    }
}
