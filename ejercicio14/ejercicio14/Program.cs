using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double trianguloBase=3;
            double trianguloAltura=2;
            double cuadrado=2;
            double circulo=2;
            double triangulo;

            circulo = CalculoDeArea.CalcularCirculo(circulo);
            cuadrado = CalculoDeArea.CalcularCuadrado(cuadrado);
            triangulo = CalculoDeArea.CalcularTriangulo(trianguloAltura, trianguloBase);

            Console.WriteLine(circulo);
            Console.WriteLine(cuadrado);
            Console.WriteLine(triangulo);

            Console.ReadKey();
        }
    }
}
