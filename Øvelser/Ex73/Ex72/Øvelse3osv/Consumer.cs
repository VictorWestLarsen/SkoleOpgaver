using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Øvelse3osv
{
    class Consumer
    {
        private string name;
        private bool stop = false;
        private Buffer buffer;

        private Random randomGenerator = new Random((int)DateTime.Now.Ticks);

        public Consumer(string name, Buffer buffer)
        {
            this.name = name;
            this.buffer = buffer;
        }
        public void Run()
        {
            while (!stop)
            {
                System.Console.WriteLine(name + " Consume: ");
                Car car = buffer.Get();      //hent Car
                System.Console.WriteLine(name + " Resived: " + car);
                Thread.Sleep(randomGenerator.Next(50, 1000));
            }
        }
        public void SignalStop()
        {
            stop = true;
        }
    }

}
