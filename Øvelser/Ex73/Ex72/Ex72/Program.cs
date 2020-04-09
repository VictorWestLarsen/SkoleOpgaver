using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex72
{
    //class Program
    //{
    //    private double accum = 0.0;
    //    private const int WEATHERSTATIONS = 100;
    //    private const int MEASURES = 1000;
    //    private const double VALUE = 1.0;
    //    private readonly object _lock = new object();
    //    static void Main(string[] args)
    //    {
    //        Program p = new Program();
    //        p.Run();
    //    }

    //    private void Run()
    //    {
    //        const double EXPECTED = WEATHERSTATIONS * MEASURES * VALUE;
    //        for (int i = 0; i < 10; i++)
    //        {
    //            accum = 0.0;
    //            double result = Measure();
    //            if (result != EXPECTED)
    //            {
    //                Console.WriteLine("ERROR: " + (EXPECTED - result));

    //            }
    //        }
    //        Console.Write("Press a key ..."); Console.ReadKey();
    //    }

    //    private double Measure()
    //    {
    //        Thread[] threads = new Thread[WEATHERSTATIONS];
    //        for (int i = 0; i < WEATHERSTATIONS; i++)
    //        {
    //            threads[i] = new Thread(Sensor);
    //            threads[i].Start();
    //        }
    //        //Do not join until all threads are started

    //        for (int i = 0; i < WEATHERSTATIONS; i++)
    //        {

    //                    threads[i].Join();

    //        }

    //        return accum;
    //    }

    //    private void Sensor()
    //    {

    //            for (int i = 0; i < MEASURES; i++)
    //            {
    //            lock (_lock) {
    //                double temp = accum;
    //                //do some work 
    //                //Thread.Sleep(1);
    //                accum = temp + VALUE;
    //            }
    //            }

    //    }
    //}

    class Program
    {
        private const int ITERATIONS = 1000000;
        private Int64 _number;
        private readonly object _locker = new object();
        public Int64 Number { get { return _number; } set { _number = value; } }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        private void Run()
        {
            Number = 0;
            Thread adder = new Thread(Add);
            Thread subtractor = new Thread(Subtract);
            adder.Start();
            subtractor.Start();
            adder.Join();
            subtractor.Join();
            Console.Write($"Number: {Number}. \t\tPress any key...");
            Console.ReadKey();
        }

        private void Add()
        {

                for (int i = 0; i < ITERATIONS; i++)
                {
                Interlocked.Increment(ref _number);
                }

        }

        private void Subtract()
        {
            for (int i = 0; i < ITERATIONS; i++)
            {
                Interlocked.Decrement(ref _number);
            }
        }
    }


}
