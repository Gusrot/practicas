using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio17
{
    public class Cuenta
    {
        private string _nombre;
        private long _nroCuenta;
        private double _saldo;
        private ETipoInteres _tipoInteres;

        public string getNombre()
        {
            return this._nombre;
        }

        public long getNroCuenta()
        {
            return this._nroCuenta;
        }

        public double getSaldo()
        {
            return this._saldo;
        }

        public ETipoInteres getTipoInteres()
        {
            return this._tipoInteres;
        }

        public void setNombre(string nombre)
        {
            if (nombre.Length > 3 && nombre.Length < 20)
                _nombre = nombre;
            else
                Console.WriteLine("Nombre incorrecto.");
        }

        public void setNroCuenta(long nroCuenta)
        {
            if (nroCuenta > 1000000000 && nroCuenta <= 9999999999)
                _nroCuenta = nroCuenta;
            else
                Console.WriteLine("Numero de cuenta incorrecto.");
        }

        public void setSaldo(double saldo)
        {
            if (saldo > 0)
                _saldo = saldo;
            else
                Console.WriteLine("El saldo es incorrecto.");
        }

        public void setTipoInteres(ETipoInteres tipoInteres)
        {
            if (tipoInteres < ETipoInteres.TIN || tipoInteres > ETipoInteres.TIR)
                _tipoInteres = tipoInteres;
            else
                Console.WriteLine("El tipo de interes es incorrecto");
        }
    }
}