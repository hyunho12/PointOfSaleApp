using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleApp.Models
{
    public class Item
    {
        public string Title { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        public double SubTotal
        {
            get => Price * Quantity;
        }

        public ItemCategory Category { get; set; }
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
