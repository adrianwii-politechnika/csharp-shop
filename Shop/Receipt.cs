using System;
namespace Shop
{
	public class Receipt
	{
        List<OrderItem> items = new List<OrderItem>();

        public Receipt()
		{
        }

        public void Print()
        {
            foreach(OrderItem item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Suma: {GetSum()} PLN");
        }

        public void AddProduct(OrderItem item)
        {
            items.Add(item);
        }

        public decimal GetSum()
        {
            decimal sum = 0;
            foreach(OrderItem item in items)
            {
                sum = sum + item.GetValue();
            }
            return sum;
        }
    }
}

