using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
   public class Conversion
    {
        private int temperature;
       public Conversion()
        {
            temperature = 1;
            
        }
        public Conversion(int temperature)

        {
            this.temperature = temperature;
        }
        public double CelsiusToFahrenheit()
        {
            
            double celsius = Convert.ToDouble(temperature);
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
        public double FahrenheitToCelsius()
        {
            double fahrenheit = Convert.ToDouble(temperature);
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
        public double CelsiusToKelvin()
        {
            double celsius = Convert.ToDouble(temperature);
            double kelvin = (celsius + 273.15);
            return kelvin;
        }
        public double KelvinToCelsius()
        {
            double kelvin = Convert.ToDouble(temperature);
            double celsius = (kelvin - 273.15);
            return kelvin;
        }
        public double FahrenheitToKelvin()
        {
            double fahrenheit = Convert.ToDouble(temperature);
            double kelvin = (273.5 + ((fahrenheit - 32) * (5 / 9)));
            return kelvin;
        }
        public double KelvinToFahrenheit()
        {
            double kelvin = Convert.ToDouble(temperature);
            double fahrenheit = (1.8 * (kelvin - 273) + 32);
            return kelvin;
        }

    }
}
