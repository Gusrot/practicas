using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador;
            int acumulador = 0;
            bool flag = true;
            int minimo = 0;
            int maximo = 0;
            int numero = 0;
            int promedio = 0;

            for (contador = 0; contador < 5; contador++)
            {
                numero = int.Parse(Console.ReadLine());
                acumulador = acumulador + numero;

                if (flag == true || minimo > numero)
                {
                    minimo = numero;
                }

                if (flag == true || maximo < numero)
                {
                    flag = false;
                    maximo = numero;
                }
            }

            promedio = acumulador / contador;
            Console.Write("\nPromedio: " + promedio);
            Console.Write("\nMaximo: " + maximo);
            Console.Write("\nMinimo: " + minimo);
            Console.ReadKey();
        }
    }
}
