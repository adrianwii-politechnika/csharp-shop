using System;
namespace Shop
{
	public class Receipt
	{
        List<OrderItem> items = new List<OrderItem>
        {
            new OrderItem("Bread", 5.0m, 3)
        };

        public Receipt()
		{
        }

        public void Print()
        {
            foreach(OrderItem item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}

