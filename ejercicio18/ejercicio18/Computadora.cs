using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio18_computadora
{
    public class Computadora
    {
        private bool _estaEncendida;
        private ejercicio18_EMarca.EMarca _marca;
        private ejercicio18_EProcesador.EProcesador _procesador;
        private float _peso;

        public Computadora(bool estaEncendida, ejercicio18_EMarca.EMarca marca, ejercicio18_EProcesador.EProcesador procesador, float peso)
        {
            this.setEstaEncendida(estaEncendida);
            this.setMarca(marca);
            this.setPeso(peso);
            this.setProcesador(procesador);
            this.InformarEstado(this.getEstaEncendida(), this.getMarca(), this.getProcesador(), this.getPeso());
        }

        public bool getEstaEncendida()
        {
            return this._estaEncendida;
        }

        public ejercicio18_EMarca.EMarca getMarca()
        {
            return this._marca;
        }

        public float getPeso()
        {
            return this._peso;
        }

        public ejercicio18_EProcesador.EProcesador getProcesador()
        {
            return this._procesador;
        }

        public void setEstaEncendida(bool encender)
        {
            if (encender == true)
            {
                this.Encender();
            }
            else
            {
                this.Apagar();
            }
        }

        public void setMarca(ejercicio18_EMarca.EMarca marca)
        {
            this._marca = marca;
        }

        public void setPeso(float peso)
        {
            this._peso = peso;
        }

        public void setProcesador(ejercicio18_EProcesador.EProcesador procesador)
        {
            this._procesador = procesador;
        }

        private void InformarEstado(bool estaEncendida, ejercicio18_EMarca.EMarca marca, ejercicio18_EProcesador.EProcesador procesador, float peso)
        {
            Console.Write("\n**********COMPUTADORA**********");
            Console.Write("\nProcesador: " + this._marca);
            Console.Write("\nMarca: " + this._procesador);
            Console.Write("\nPeso: " + this._peso);
            Console.Write("\nEstado (true = encendida // false = apagada): " + this._estaEncendida);
        }

        private bool Apagar()
        {
            this._estaEncendida = false;

            return this._estaEncendida;
        }

        private bool Encender()
        {
            this._estaEncendida = true;

            return this._estaEncendida;
        }
    }
}