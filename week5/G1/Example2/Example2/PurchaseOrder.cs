using System;
using System.Collections.Generic;
namespace Example2
{
    public class PurchaseOrder
    {
        public Address address;
        public string OrderDate;
        public List<OrderItem> OrderItems;
        public PurchaseOrder(Address address, string OrderDate)
        {
            this.address = address;
            this.OrderDate = OrderDate;
            OrderItems = new List<OrderItem>();
        }

    }

    public class Address
    {
        public string Name;
        public string City;
        public string State;
        public string Zip;
        public Address() { }
        public Address(string Name, string City, string State, string Zip)
        {
            this.Name = Name;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
        }
    }

    public class OrderItem
    {
        public string ItemName;
        public string Description;
        public int UnitPrice;
        public int Quantity;
        public int Total;

        public OrderItem() { }
        public OrderItem(string ItemName, string Description, int UnitPrice, int Quanitity)
        {
            this.ItemName = ItemName;
            this.Description = Description;
            this.UnitPrice = UnitPrice;
            this.Quantity = Quanitity;
            this.CalcTotal();
        }
        public void CalcTotal()
        {
            Total = UnitPrice * Quantity;
        }
    }
}
