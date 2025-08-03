using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            string input = Console.ReadLine();
            int age;

            if (int.TryParse(input, out age) && age > 0)
            {
                int price;
                if (age <= 12 || age >= 65)
                {
                    price = 7;
                }
                else
                {
                    price = 10;
                }
                Console.WriteLine($"Your ticket price is: GHC{price}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}