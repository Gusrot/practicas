using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    class conversor
    {
        public static string DecimalBinario(double decimales)
        {
            string residuo = "";

            while (decimales > 0)
            {
                if (decimales % 2 == 0)
                {
                    residuo = "0" + residuo;
                }
                else
                {
                    residuo = "1" + residuo;
                }
                decimales = (int)(decimales / 2);
            }

            return residuo;
        }
        public static double BinarioDecimal(string binario)
        {
            double decimales = 0;
            int exponente = binario.Length - 1;
            int contador;

            for (contador = 0; contador < binario.Length; contador++)
            {
                if (double.Parse(binario.Substring(contador, 1)) == 1)
                {
                    decimales = decimales + double.Parse(System.Math.Pow(2, double.Parse(exponente.ToString())).ToString());
                }
                exponente--;
            }

            return decimales;
        }
    }
}
