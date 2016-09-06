using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Aula miPrimerAula=new Aula();
            Aula.mostrarAlumno(miPrimerAula);
            bool existe;

            Alumno alumno1 = new Alumno("Pollo", 1);
            Alumno alumno2 = new Alumno("Rotela", 2);
            Alumno alumno3 = new Alumno("Ortiz", 3);
            Alumno alumno4 = new Alumno("Otero", 4);

            /*miPrimerAula.agregarAlumno(alumno1);
            miPrimerAula.agregarAlumno(alumno2);
            miPrimerAula.agregarAlumno(alumno3);
            miPrimerAula.borrarAlumno(alumno2);
            miPrimerAula.agregarAlumno(alumno4);
            miPrimerAula.agregarAlumno(alumno1);
            miPrimerAula.agregarAlumno(alumno2);
            miPrimerAula.agregarAlumno(alumno3);*/
            miPrimerAula = miPrimerAula + alumno1;
            //miPrimerAula.listaDeAlumno[0].nombre="lalala";
            existe=miPrimerAula.existeAlumno(alumno2);
            Aula.mostrarAlumno(miPrimerAula);
            Console.WriteLine(existe);
            Console.ReadKey();
        }

    }
}
