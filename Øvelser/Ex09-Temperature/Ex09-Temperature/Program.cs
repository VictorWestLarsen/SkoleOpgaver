using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;
            string[] lines = new string[2];
            Temperature[] cels = new Temperature[3];
            Temperature[] fahr = new Temperature[3];


            System.IO.StreamReader file =
    new System.IO.StreamReader(@"..\..\InputFil.txt");
            while ((line = file.ReadLine()) != null)
            {
                lines[counter] = line;
                counter++;
            }

            counter = 0;

            foreach (string temp in lines[0].Split(' '))
            {
                cels[counter] = new Temperature();
                cels[counter].Celsius = double.Parse(temp);
                Console.WriteLine(temp);
                counter++;
            }

            counter = 0;

            foreach (string temp in lines[1].Split(' '))
            {
                fahr[counter] = new Temperature();
                fahr[counter].Fahrenheit = double.Parse(temp);
                Console.WriteLine(temp);
                counter ++;
            }
        }
    }
}
