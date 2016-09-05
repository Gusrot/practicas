using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno uno = new Alumno();
            Alumno dos = new Alumno();
            Alumno tres = new Alumno();

            uno.nombre = "Gustavo";
            uno.apellido = "Rotela";
            uno.legajo = 1;

            dos.nombre = "Juan";
            dos.apellido = "Pollio";
            dos.legajo = 2;

            tres.nombre = "Santiago";
            tres.apellido = "Ortiz";
            tres.legajo = 3;

            uno.Estudiar(4, 4);
            dos.Estudiar(6, 7);
            tres.Estudiar(4, 4);

            uno.CalcularFinal();
            dos.CalcularFinal();
            tres.CalcularFinal();

            uno.mostrar();
            dos.mostrar();
            tres.mostrar();

            Console.ReadKey();
        }
    }
}
