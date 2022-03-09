﻿using System;
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

        public static bool JePrvocislo(int n)
        {
            bool je = true;
            if (n == 1) //Jednička není prvočíslo
            {
                je = false;
            }
            else if (n == 2) //Dvojka je jediné sudé prvočíslo
            {
                je = true;
            }
            else if (n % 2 != 0) //Sudá čísla nikdy nejsou prvočísla
            {
                int i = 3;
                while (i < (n / 2) - 1 && je)
                {
                    if (n % i == 0)
                    {
                        je = false;
                    }
                    i += 2;
                }
            }
            else
            {
                je = false;
            }

            return je;
        }
    }
}
