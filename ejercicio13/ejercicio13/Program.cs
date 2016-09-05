using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            string binario;
            double decimales;

            decimales = conversor.BinarioDecimal("1010010");

            binario = conversor.DecimalBinario(82);

            Console.WriteLine(decimales);
            Console.WriteLine(binario);
            Console.ReadKey();
        }
    }
}
