using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piedraPapelTijera1
{
    public partial class Form1 : Form
    {
        private Random rng;
        private int numero;
        private int eleccion;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eleccion = 1;
            juego();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eleccion = 2;
            juego();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eleccion = 3;
            juego();
        }

        private void juego()
        {
            rng = new Random();
            numero = rng.Next(1, 3);

            if (eleccion == numero)
                MessageBox.Show("Empate");
            else if (eleccion == 1 && numero == 2)
                MessageBox.Show("Perdio");
            else if (eleccion == 1 && numero == 3)
                MessageBox.Show("Gano");
            else if (eleccion == 2 && numero == 3)
                MessageBox.Show("Perdio");
            else if (eleccion == 2 && numero == 1)
                MessageBox.Show("Gano");
            else if (eleccion == 3 && numero == 1)
                MessageBox.Show("Perdio");
            else if (eleccion == 3 && numero == 2)
                MessageBox.Show("Gano");

        }
    }
}
