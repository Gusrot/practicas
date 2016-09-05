using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado = Calculadora.Calcular(2, 1, "-");

            Calculadora.Mostrar(resultado);
        }
    }
}
