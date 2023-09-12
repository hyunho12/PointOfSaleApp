
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
                return tot.ToString("N2");
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
