using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double area = 0;

            area = Math.Pow(lado, 2);

            return area;
        }
        public static double CalcularTriangulo(double altura,double bases)
        {
            double area = 0;

            area = (altura * bases) / 2;

            return area;
        }
        public static double CalcularCirculo(double radio)
        {
            double area = 0;

            area = Math.PI * (Math.Pow(radio, 2));

            return area;
        }
    }
}
