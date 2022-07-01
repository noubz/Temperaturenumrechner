using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schritt_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string eingabe_temperatur;
            double ausgabe_temperatur;

            while(true)
            {
                Console.WriteLine("Die umzurechnenede Temperatur in Celsius: \n ('quit' eingeben zum beenden)");
                eingabe_temperatur = Console.ReadLine();

                if (eingabe_temperatur == "quit") {
                    break;
                }
                if (double.TryParse(eingabe_temperatur, out double result))
                {
                    ausgabe_temperatur = (Convert.ToDouble(eingabe_temperatur) * 1.8) + 32;
                    Console.WriteLine("Die Temperatur in Fahrenheit ist " + ausgabe_temperatur + "°F");
                }
                else
                {
                    Console.WriteLine("Bitte nur gültige Zahlen eingeben...\n");
                }
                Console.WriteLine("");
            }
        }
    }
}
