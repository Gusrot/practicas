using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int contador;
            int primo;
            int acumulador=0;
            numero = int.Parse(Console.ReadLine());

            for(contador=1;contador<=numero;contador++)
            {
                acumulador = 0;

                for(primo=1;primo<=contador;primo++)
                {
                    if (contador % primo == 0)
                    {
                        acumulador++;
                    }
                }

                if (acumulador == 2)
                    Console.WriteLine(contador);
            }

            Console.ReadKey();
        }
    }
}
