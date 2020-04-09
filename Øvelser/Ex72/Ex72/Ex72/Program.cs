using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex72
{
    class Program
    {
        static void Main(string[] args)
        {



        }

        public void Run()
        {
            Thread t1 = new Thread(Print);
            Thread t2 = new Thread(delegate (object msg)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Hello World!");
                }
            });
            Thread t3 = new Thread((object msg) =>
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Hello World!");
                }
            });

            t1.Start("Hello World!");
            t2.Start("Hello World!");
            t3.Start("Hello World!");
        }
        
        

        public void Print(object msg)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
