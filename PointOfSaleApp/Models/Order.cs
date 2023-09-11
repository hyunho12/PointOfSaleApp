
namespace PointOfSaleApp.Models
{
    public class Order
    {
        public int Table { get; set; }
        public double Tip { get; set; }
        public byte[] SignatureData { get; set; }

        public List<Item> items { get; set; }

        public string States { get; set; }
        public OrderType OrderType = OrderType.DineIn;

        public string Total
        {
            get
            {
                var tot = items.Sum(i => (i.price * i.quantity));
                if (Tip != 0)
                {
                    tot = tot + (tot * Tip);
                }
                return tot.ToString();
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
