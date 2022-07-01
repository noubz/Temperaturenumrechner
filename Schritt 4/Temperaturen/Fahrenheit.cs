using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schritt_4
{
    class Fahrenheit : Temperatur
    {
        Runder Runden = new Runder();

        public override double Celsius_Umwandlung(double temperatur)
        {
            double neue_temperatur = (temperatur - 32) / 1.8;
            neue_temperatur = Runden.Runden(neue_temperatur);
            return neue_temperatur;
        }

        public override double Fahrenheit_Umwandlung(double temperatur)
        {
            double neue_temperatur = Runden.Runden(temperatur);
            return neue_temperatur;
        }

        public override double Kelvin_Umwandlung(double temperatur)
        {
            double neue_temperatur = (temperatur - 32) / 1.8 + 273.15;
            neue_temperatur = Runden.Runden(neue_temperatur);
            return neue_temperatur;
        }
    }
}
