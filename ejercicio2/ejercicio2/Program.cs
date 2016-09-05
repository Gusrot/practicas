using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double cuadrado;
            double triple;

            numero = double.Parse(Console.ReadLine());

            if (numero < 0)
                Console.Write("ERROR. Reingresar número!!!");

            cuadrado = Math.Pow(numero, 2);
            triple = Math.Pow(numero, 3);

            Console.WriteLine(cuadrado);
            Console.WriteLine(triple);
            Console.ReadKey();
        }
    }
}
