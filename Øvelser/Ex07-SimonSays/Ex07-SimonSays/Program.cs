using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_SimonSays
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string tekst = "";
            Console.WriteLine("Hej med dig, skriv en besked!");
            tekst = Console.ReadLine();
            Simon simon = new Simon();
            Console.WriteLine("Echo: " + simon.Echo(tekst));
            Console.WriteLine( "Shout: " +simon.Shout(tekst));



        }
    }
}
