using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schritt_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string eingabe_temperatur;
            string ursprungseinheit;
            string umrechnungseinheit;
            double umgewandelte_temperatur = 0;

            // Schleife für den Temperaturumwandler
            while (true)
            {
                Temperatur temperatur = null;

                Anfang: // Umrechnung von
                Console.WriteLine("Bitte angeben von welcher Einheit umgerechnet werden soll:\n (C für Celsius; F für Fahrenheit; K für Kelvin)");
                ursprungseinheit = Console.ReadLine().ToUpper();
                if (ursprungseinheit == "QUIT")
                {
                    break;
                }
                // Testen, ob Eingabe gültig
                if (ursprungseinheit == "C" || ursprungseinheit == "F" || ursprungseinheit == "K")
                {
                    if (ursprungseinheit == "C") { temperatur = new Celsius(); }
                    if (ursprungseinheit == "F") { temperatur = new Fahrenheit(); }
                    if (ursprungseinheit == "K") { temperatur = new Kelvin(); }
                    
                }
                else
                {
                    Console.WriteLine("Bitte eine der vorgegebenen Einheiten wählen.\n");
                    goto Anfang;
                }

                Umrechnungseinheit: // Umrechnen zu
                Console.WriteLine("Bitte angeben in welche Einheit umgerechnet werden soll:\n (C für Celsius; F für Fahrenheit; K für Kelvin)");
                umrechnungseinheit = Console.ReadLine().ToUpper();
                if (umrechnungseinheit == "QUIT")
                {
                    break;
                }
                // Testen, ob Eingabe ungültig
                if (umrechnungseinheit != "C" && umrechnungseinheit != "F" && umrechnungseinheit != "K")
                {
                    Console.Clear();
                    Console.WriteLine("Bitte nur eine der vorgegebenen Einheiten wählen.\n");
                    goto Umrechnungseinheit;
                }

                Temperatureingabe: // Temperatur
                Console.WriteLine("Die umzurechnenede Temperatur:");
                eingabe_temperatur = Console.ReadLine();
                // Auf Eingabe "quit" testen
                if (eingabe_temperatur == "quit")
                {
                    break;
                }
                // Testen, ob Eingabe ungültig
                if (!double.TryParse(eingabe_temperatur, out double result))
                {
                    Console.WriteLine("Bitte nur Dezimalzahlen eingeben.\n");
                    goto Temperatureingabe;
                }

                // Umwandlung
                if (umrechnungseinheit == "C") {
                    umgewandelte_temperatur = temperatur.Celsius_Umwandlung(Convert.ToDouble(eingabe_temperatur)); 
                }
                if (umrechnungseinheit == "F") {
                    umgewandelte_temperatur = temperatur.Fahrenheit_Umwandlung(Convert.ToDouble(eingabe_temperatur)); 
                }
                if (umrechnungseinheit == "K") {
                    umgewandelte_temperatur = temperatur.Kelvin_Umwandlung(Convert.ToDouble(eingabe_temperatur)); 
                }

                // Ausgabe des Ergebnisses
                Console.WriteLine("Die umgewandelte Temperatur ist " + umgewandelte_temperatur + "°" + umrechnungseinheit);

                // Leeren der Konsole / Fortfahren
                Console.Write("Taste drücken zum fortfahren...");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}