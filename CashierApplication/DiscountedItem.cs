using System;

namespace ItemNamespace
{
    public class DiscountedItem : Item
    {
        private double discount;

        public DiscountedItem(
            string item_name,
            double item_price,
            int item_quantity,
            double discount)
            : base(item_name, item_price, item_quantity)
        {
            this.discount = discount;
        }

        public override double GetTotalAmount()
        {
            double discountedPrice = item_price - (item_price * (discount * 0.01));

            return discountedPrice * item_quantity;
        }
    }
}