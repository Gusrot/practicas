using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int perfecto;
            int contador;
            int acumulador = 0;

            for(contador=1;contador<2000000000;contador++)
            {
                acumulador = 0;
                for(perfecto=1;perfecto<contador;perfecto++)
                {
                    if (contador % perfecto == 0)
                        acumulador += perfecto;
                }

                if (acumulador == contador)
                    Console.WriteLine(contador);
            }

            Console.ReadKey();
        }
    }
}

