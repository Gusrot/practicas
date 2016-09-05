using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        int contador;
        String cad = "*";


        Console.Write("Ingresar numero");
        numero = int.Parse(Console.ReadLine());

        for (contador = 0; contador < numero; contador++)
        {
            Console.WriteLine(cad);
            cad += "**";
        }

        Console.ReadLine();
    }
}
