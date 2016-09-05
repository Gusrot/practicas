using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int bisiesto;

            bisiesto = int.Parse(Console.ReadLine());

            if(bisiesto % 4 == 0)
                Console.WriteLine("El año es bisiesto");

            else if(bisiesto % 100 == 0 && bisiesto % 400 == 0)
                Console.WriteLine("El año es bisiesto");

            else
                Console.WriteLine("El año no es bisiesto");

            Console.ReadKey();
        }
    }
}
