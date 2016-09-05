using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros;
            int acumulador = 0;

            while(ValidarRespuesta.validaS_N())
            {
                Console.Write("Ingrese numero a sumar: ");
                numeros = int.Parse(Console.ReadLine());

                acumulador += numeros;
            }

            Console.WriteLine(acumulador);
            Console.ReadKey();
        }
    }
}
