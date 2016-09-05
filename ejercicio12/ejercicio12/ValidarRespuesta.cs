using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    class ValidarRespuesta
    {
        public static bool validaS_N()
        {
            string validar;

            Console.Write("Desea continuar?: ");
            validar = Console.ReadLine();

            while(validar!="s"&&validar!="n")
            {
                Console.Write("Ingrese s o n: ");
                validar = Console.ReadLine();
            }

            if (validar == "s")
                return true;

            return false;
        }
    }
}
