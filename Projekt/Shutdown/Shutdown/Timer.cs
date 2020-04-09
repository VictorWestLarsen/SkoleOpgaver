using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Shutdown
{
    class Timer
    {
        public int Hours = 0;
        public int Minuts = 0;
        public Timer()
        {

        }
        public int HandleTime()
        {
            string time;
            Console.WriteLine("Indtast tid til lukning som følgende eksempel timer:minutter");
            time = Console.ReadLine();
            string[] timer = time.Split(':');
            Hours = int.Parse(timer[0]);
            Minuts = int.Parse(timer[1]);
            int Seconds = Hours * 3600 + Minuts * 60;
            
            return Seconds;

        }

        public void SetTimer(int Duration)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C shutdown -s -t" + Duration;
            process.Start();
        }

    }
}
