using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador;
            int numero;
            int contadormenores;
            int contadormayores;
            int acumuladormenores;
            int acumuladormayores;

            numero = int.Parse(Console.ReadLine());

            for(contador=2;contador<=numero;contador++)
            {
                acumuladormenores = 0;
                acumuladormayores = 0;

                for (contadormenores=1;contadormenores<contador;contadormenores++)
                {
                    acumuladormenores += contadormenores;
                }

                acumuladormayores = contador + 1;
                contadormayores = contador + 1;

                while(acumuladormayores<acumuladormenores)
                {
                    contadormayores++;
                    acumuladormayores = acumuladormayores + contadormayores;
                }

                if (acumuladormayores == acumuladormenores)
                    Console.WriteLine(contador);
            }
            Console.ReadKey();
        }
    }
}
