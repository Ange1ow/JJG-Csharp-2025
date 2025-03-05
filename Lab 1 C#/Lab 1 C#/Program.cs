using System.Text;

namespace Lab_1_C_
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            Product apple = new Product("Яблуко", 5, 100);
            Console.WriteLine(apple.GetInfo());

            apple.Sell(20);
            Console.WriteLine(apple.GetInfo());

            apple.Restock(50);
            Console.WriteLine(apple.GetInfo());

            apple.Price = 7;
            Console.WriteLine(apple.GetInfo());

            apple.Name = "Зелене яблуко";
            Console.WriteLine(apple.GetInfo());

            apple.Sell(200);
        }
    }
}
