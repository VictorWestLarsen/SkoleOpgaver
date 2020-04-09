using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex55;

namespace Ex55
{
    public class Fibon
    {
        public int Fibonacci(int number)
        {


            {
                if (number == 0)
                    return 1;

                int factorial = 1;
                for (int i = number; i >= 1; i--)
                {
                    factorial = factorial * i;
                    Console.WriteLine(factorial);
                }
                return factorial;
            }
        }
        public bool Polin(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            new string(charArray);

            if (charArray.Equals(input))
            {
                return true;
            }
            else
            return false;
        }
    }
}
