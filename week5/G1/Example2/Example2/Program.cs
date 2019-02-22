using System;

namespace Example2
{
    class Program
    {
        public static void F1()
        {
            Address address = new Address();
            address.Name = "Askar Akshabayev";
            address.City = "Almaty";
            address.State = "Alatau district";
            address.Zip = "050000";

            OrderItem item1 = new OrderItem("Item1", "Item 1 description", 100, 2);
            OrderItem item2 = new OrderItem("Item2", "Item 2 description", 123, 3);

            PurchaseOrder order = new PurchaseOrder(address, "21.02.2019");
            order.OrderItems.Add(item1);
            order.OrderItems.Add(item2);
        }
        static void Main(string[] args)
        {
            F1();
        }
    }
}
