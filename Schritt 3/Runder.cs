using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schritt_3
{
    class Runder
    {
        public double Runden(double temperatur)
        {
            int kommastellen = 1;
            double verschiebung = 1;

            while (kommastellen > 0)
            {
                verschiebung *= 10;
                kommastellen -= 1;
            }

            int zwischen_temperatur = (int)(temperatur * verschiebung + 0.5);
            temperatur = zwischen_temperatur / verschiebung;

            return temperatur;
        }
    }
}
