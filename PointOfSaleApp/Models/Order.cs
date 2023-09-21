
using CommunityToolkit.Mvvm.Input;
using PointOfSaleApp.Pages.Mobile;
using System.Diagnostics;

namespace PointOfSaleApp.Models
{
    public class Order
    {
        public int Table { get; set; }
        public double Tip { get; set; }
        public byte[] SignatureData { get; set; }

        public List<Item> Items { get; set; }

        public string Status { get; set; }
        private OrderType OrderType = OrderType.DineIn;

        public string Total
        {
            get
            {                
                var tot = Items.Sum(i => (i.Price * i.Quantity));
                if (Tip != 0)
                {
                    tot = tot + (tot * Tip);
                }
                //return tot.ToString("N3");
                return tot.ToString("N2");
            }
        }

        private static readonly Random _random = new Random();

        private static readonly string[] brushes = new string[] { "#FFB572", "#65B0F6", "#FF7CA3", "#50D1AA", "#9290FE" };
        public static Brush RandomBrush
        {
            get
            {
                var id = _random.Next(0,4);
                return new SolidColorBrush(Color.Parse(brushes[id]));
            }
        }
    }

    public enum OrderType
    {
        DineIn,
        CarryOut,
        Delivery
    }    
}
