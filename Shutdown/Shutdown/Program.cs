using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shutdown
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer SleepTimer = new Timer();
            int Duration = SleepTimer.HandleTime();
            SleepTimer.SetTimer(Duration);
            Console.WriteLine("Computeren Slukker om: " + SleepTimer.Hours + " time(r) og "+ SleepTimer.Minuts + "Minut(er)");
            Console.ReadKey();
        }
    }
}
