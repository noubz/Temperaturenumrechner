using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schritt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Runder obj = new Runder();

            string eingabe_temperatur;
            double ausgabe_temperatur;
            string einheit;
            int kommastellen = 1;

            while(true)
            {
                Anfang:
                Console.WriteLine("Bitte angeben in welche Einheit umgerechnet werden soll:\n (C für Celsius; F für Fahrenheit)");
                einheit = Console.ReadLine().ToLower();
                if (einheit == "quit")
                {
                    break;
                }
                if ((einheit != "f") && (einheit != "c")) {
                    Console.Clear();
                    Console.WriteLine("Bitte nur F/C eingeben...\n");
                    goto Anfang;
                }

                Temperatureingabe:
                Console.WriteLine("Die umzurechnenede Temperatur:");
                eingabe_temperatur = Console.ReadLine();
                if (eingabe_temperatur == "quit")
                {
                    break;
                }
                if (!double.TryParse(eingabe_temperatur, out double result))
                {
                    Console.WriteLine("Bitte nur Zahlen eingeben...\n");
                    goto Temperatureingabe;
                }

                if (einheit == "f")
                {
                    ausgabe_temperatur = (Convert.ToDouble(eingabe_temperatur) * 9 / 5) + 32;
                    ausgabe_temperatur = obj.Runden(ausgabe_temperatur, kommastellen);

                    Console.WriteLine("Die Temperatur in Fahrenheit ist " + ausgabe_temperatur + "°F");
                }
                if (einheit == "c")
                {
                    ausgabe_temperatur = (Convert.ToDouble(eingabe_temperatur) - 32) * 5 / 9;
                    ausgabe_temperatur = obj.Runden(ausgabe_temperatur, kommastellen);
                    Console.WriteLine("Die Temperatur in Celsius ist " + ausgabe_temperatur + "°C");
                }

                Console.Write("Taste drücken zum fortfahren...");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}
