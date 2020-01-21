using System;

namespace Exercise_02._2_CanRack_Optional
{
    class Program
    {
        static void Main(string[] args)
        {
            PurchasePrice sodaPrice = new PurchasePrice(35);

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
            Console.Write("Please insert {0} cents: ",sodaPrice.Price);
            int valueInserted = int.Parse(Console.ReadLine());
            Console.WriteLine("You have inserted {0} cents", valueInserted);
            Console.WriteLine("Thanks, here is your soda.");
        }
    }
}
