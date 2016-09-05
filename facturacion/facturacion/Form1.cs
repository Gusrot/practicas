using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturacion
{
    public partial class Form1 : Form
    {

        private int numero1;
        private int numero2;
        private int numero3;
        private int resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numero1 = int.Parse(this.textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            numero2 = int.Parse(this.textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            numero3 = int.Parse(this.textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultado = numero1 + numero2 + numero3;
            MessageBox.Show("El resultado es: " + resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double precio;
            precio = (numero1 + numero2 + numero3) / 3;
            MessageBox.Show("El promedio es: " + precio);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Precio = (numero1 + numero2 + numero3) * 1.21;
            MessageBox.Show("El precio es " + Precio);
        }
    }
}
