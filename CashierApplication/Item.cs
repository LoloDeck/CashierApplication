using System;

namespace ItemNamespace
{
    public abstract class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;

        public Item(string item_name, double item_price, int item_quantity)
        {
            this.item_name = item_name;
            this.item_price = item_price;
            this.item_quantity = item_quantity;
        }

        public abstract double GetTotalAmount();
    }
}