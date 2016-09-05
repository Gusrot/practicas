using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio16
{
    public class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        float finalRandom;
        Random random = new Random();
       
        public void CalcularFinal()
        {
            if (_nota1 >= 4 && _nota2 >= 4)
                _notaFinal = random.Next(0, 10);
            else
                _notaFinal = -1;
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            _nota1 = notaUno;
            _nota2 = notaDos;
        }

        public void mostrar()
        {
            Console.WriteLine(nombre);
            Console.WriteLine(apellido);
            Console.WriteLine("Legajo: " + legajo);
            Console.WriteLine("Nota 1: " + _nota1);
            Console.WriteLine("Nota 2: " + _nota2);
            if (_notaFinal != -1)
                Console.WriteLine("Final: " + _notaFinal);
        }
    }
}