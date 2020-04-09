using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Temperature
{
    public class TemperatureUtil
    {
       
        public static double CelsiusToFahrenheit(double cels)
        {
            return Math.Round(cels * 9 / 5 + 32,2) ;
        }

        public static double FahrenheitToCelsius(double fahr)
        {
            return (fahr - 32) * 5 / 9;
        }
    }
}
