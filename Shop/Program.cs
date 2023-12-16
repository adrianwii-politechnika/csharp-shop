namespace Shop;

class Program
{
    static void Main(string[] args)
    {

        Receipt receipt = new Receipt();

        Console.WriteLine("Witaj w naszy sklepie");

        receipt.AddProduct(new OrderItem("Bread", 5.0m, 3));
        receipt.AddProduct(new OrderItem("Milk", 4.0m, 5));
        receipt.AddProduct(new OrderItem("Egg", 2.0m, 10));


        Console.WriteLine("Twój rachunek:");

        receipt.Print();
    }
}

