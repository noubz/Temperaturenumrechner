using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schritt_4
{
    abstract class Temperatur
    {
        public abstract double Celsius_Umwandlung(double temperatur);
        public abstract double Fahrenheit_Umwandlung(double temperatur);
        public abstract double Kelvin_Umwandlung(double temperatur);
    }
}
