using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numero;
            int contador = 0;
            int acumulador = 0;
            int min = 0;
            int max = 0;
            int promedio = 0;


            for (contador = 0; contador < 10; contador++)
            {

                Console.Write("Ingrese numero: ");
                numero = int.Parse(Console.ReadLine());
                while (estatico11.validacion.validar(-100, 100, numero))
                {
                    Console.Write("Reingrese numero: ");
                    numero = int.Parse(Console.ReadLine());
                }
                acumulador = acumulador + numero;
                if (contador == 0)
                {
                    min = numero;
                    max = numero;
                }
                else
                {
                    if (numero < min)
                    {
                        min = numero;
                    }
                    else if (numero > max)
                    {
                        max = numero;
                    }
                }



            }
            promedio = estatico11.validacion.dividir(acumulador, contador);

            Console.WriteLine("Minimo" + min);
            Console.WriteLine("Maximo" + max);
            Console.WriteLine("Promedio" + promedio);
            Console.ReadKey();
        }
    }
}
