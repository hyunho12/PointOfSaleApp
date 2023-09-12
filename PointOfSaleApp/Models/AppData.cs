
namespace PointOfSaleApp.Models;

public static class AppData
{
    public static List<int> Tables = new List<int> { 7, 8, 9, 10, 11, 12, 13, 14 };
    public static string[] Statuses = new string[] { "Ready to Pay", "Cooking", "Ready to Order" };
    private static Random random = new Random();

    public static List<Item> Items = new List<Item>
    {
        new Item(){ Title = "Japchae", Price = 13.99, Quantity = 1, Image = "japchae.png", Category = ItemCategory.Noodles},
        new Item(){ Title = "Jajangmyeon", Price = 14.99, Quantity = 1, Image = "jajangmyeon.png", Category = ItemCategory.Noodles},
        new Item(){ Title = "Janchi Guksu", Price = 12.99, Quantity = 1, Image = "janchi_guksu.png", Category = ItemCategory.Noodles},
        new Item(){ Title = "Budae Jjigae", Price = 14.99, Quantity = 1, Image = "budae_jjigae.png", Category = ItemCategory.Noodles},
        new Item(){ Title = "Naengmyeon", Price = 12.99, Quantity = 1, Image = "naengmyeon.png", Category = ItemCategory.Noodles},
        new Item(){ Title = "Soda", Price = 2.50, Quantity = 1,  Image = "soda.png", Category = ItemCategory.Beverages},
        new Item(){ Title = "Iced Tea", Price = 3.50, Quantity = 1, Image = "iced_tea.png", Category = ItemCategory.Beverages},
        new Item(){ Title = "Hot Tea", Price = 4.00, Quantity = 1, Image = "tea.png", Category = ItemCategory.Beverages},
        new Item(){ Title = "Coffee", Price = 4.00, Quantity = 1, Image = "coffee.png", Category = ItemCategory.Beverages},
        new Item(){ Title = "Milk", Price = 5.00, Quantity = 1, Image = "milk.png", Category = ItemCategory.Beverages},
    };

    public static List<Order> Orders { get; set; } = GenerateOrders();

    private static List<Order> GenerateOrders()
    {
        random.Shuffle(Tables);
        List<Order> orders = new List<Order>();
        for(int i = 0; i < Tables.Count; i++)
        {
            orders.Add(new Order()
            {
                Table = Tables[i],
                Status = RandomStatus(),
                Items = GenerateItems()
            });
        }

        orders.OrderByDescending(x => x.Status);
        return orders;
    }

    private static List<Item> GenerateItems()
    {
        List<Item> items = new List<Item>();
        int numItems = random.Next(1, Items.Count - 1);
        random.Shuffle(Items);
        for(int i = 0; i < numItems; i++)
        {
            items.Add(Items[i]);
        }

        return items;
    }

    private static string RandomStatus()
    {
        var i = random.Next(0, Statuses.Length - 1);
        return Statuses[i];
    }
}

public static class RandomExtension
{
    public static void Shuffle<T>(this Random rd, List<T> array)
    {
        int n = array.Count;
        while (n > 1)
        {
            int k = rd.Next(n--);
            T temp = array[n];
            array[n] = array[k];
            array[k] = temp;
        }
    }
}
