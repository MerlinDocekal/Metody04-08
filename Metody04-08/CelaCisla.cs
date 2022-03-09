using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody04_08
{
    class CelaCisla
    {
        public static double Mocnina(int zaklad, int exponent)
        {
            double mocnina = 1;

            bool zapornyExp = exponent < 0;
            exponent = Math.Abs(exponent);

            for (int i = 0; i < exponent; i++)
            {
                mocnina *= zaklad;
            }

            if(zapornyExp)
            {
                mocnina = 1 / mocnina;
            }

            return mocnina;
        }

        public static double Faktorial(int x)
        {
            int faktorial = 1;
            for(int i = 1; i <= x; i++)
            {
                faktorial *= i;
            }

            return faktorial;
        }
    }
}
