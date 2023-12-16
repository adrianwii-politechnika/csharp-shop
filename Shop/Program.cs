namespace Shop;

class Program
{
    static void Main(string[] args)
    {

        Receipt receipt = new Receipt();

        Console.WriteLine("Witaj w naszy sklepie");


        Console.WriteLine("Twój rachunek:");

        receipt.Print();
    }
}

