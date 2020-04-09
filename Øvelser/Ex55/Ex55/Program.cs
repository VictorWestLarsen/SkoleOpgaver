using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex55;

namespace Ex55
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Fibon fibon = new Fibon();
            Console.WriteLine("Choose what you wanna do: \n" +
                "1. Fibonacci \n" +
                "2. Palindrom");
            string user = Console.ReadLine();
            int choice = Convert.ToInt32(user);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please enter a number:");
                    int number = Convert.ToInt32(Console.ReadKey());
                    fibon.Fibonacci(number);
                    break;
                case 2:
                    Console.WriteLine("Please enter a Palindrom: ");
                    string input = Console.ReadLine();

                    if (fibon.Polin(input) == false)
                    {
                       Console.WriteLine("This is not a Palidrom");
                        Console.ReadKey();
                    }
                    else
                        Console.WriteLine("this is a Palindrom");
                        Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Not a valid choice");
                    break;
            }
        }
    }
}
