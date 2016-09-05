using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int contador;
            int contador2;
            String cad = "*";
            string espacio = "";

            Console.Write("Ingresar numero");
            numero = int.Parse(Console.ReadLine());
            contador2 = numero;
            for (contador = 0; contador < numero-1; contador++)
                espacio += " ";

            for (contador = 0; contador < numero; contador++)
            {
                Console.WriteLine(espacio + cad);

                if(contador2>1)
                    espacio = espacio.Remove(contador2 - 2, 1);

                cad += "**";
                contador2--;
            }

            Console.ReadLine();
        }
    }
}
