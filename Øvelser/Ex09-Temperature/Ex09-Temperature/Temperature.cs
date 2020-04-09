using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Temperature
{
    public class Temperature
    {
        public double Celsius;

        public double Fahrenheit { get; set; }

        public void SetFahrenheitFromCelsius()
        {
           this.Fahrenheit = TemperatureUtil.CelsiusToFahrenheit(Celsius);
        }

        public void SetCelsiusFromFahrenheit()
        {
            this.Celsius = TemperatureUtil.FahrenheitToCelsius(Fahrenheit);
        }
    }
}
