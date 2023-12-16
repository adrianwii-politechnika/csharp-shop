using System;
namespace Shop
{
	public class OrderItem
	{
        protected string name;
        protected decimal price;
        protected int quantity;


        public OrderItem(string name, decimal price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public virtual decimal GetValue()
        {
            return quantity * price;
        }

        public override string? ToString()
        {
            //"Bread, price: 3.50 PLN,5 szt, value: 17.5 PLN"
            return $"{name}, price: {price} PLN, {quantity} szt, value: {GetValue()} PLN";
        }
    }
}

