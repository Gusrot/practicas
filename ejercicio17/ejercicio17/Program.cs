using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cuenta nueva = new Cuenta();

            nueva.setNombre("Gustavo");
            nueva.setNroCuenta(1234567891);
            nueva.setSaldo(1000);
            nueva.setTipoInteres(ETipoInteres.TIN);

            Console.WriteLine(nueva.getNombre());
            Console.WriteLine(nueva.getNroCuenta());
            Console.WriteLine(nueva.getSaldo());
            Console.WriteLine(nueva.getTipoInteres());
            Console.ReadKey();
        }
    }
}
