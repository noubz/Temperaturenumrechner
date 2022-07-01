using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schritt_4
{
    class Runder
    {
        public static int Kommastellen { get; set; }
        public double Runden(double temperatur)
        {
            double verschiebung = 1;

            while (Kommastellen > 0)
            {
                verschiebung *= 10;
                Kommastellen -= 1;
            }

            int zwischen_temperatur = (int)(temperatur * verschiebung + 0.5);
            temperatur = zwischen_temperatur / verschiebung;

            return temperatur;
        }
    }
}
