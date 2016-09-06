using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construccion
{
    public partial class Form1 : Form
    {

        private int largo;
        private int ancho;
        private int radio;
        private double total;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            largo = int.Parse(this.textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ancho = int.Parse(this.textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            radio = int.Parse(this.textBox3.Text);
        }     

        private void button1_Click(object sender, EventArgs e)
        {
            total = (2 * largo) + (2 * ancho);
            MessageBox.Show("la cantidad de alambre a usar es de: " + total + " metros.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            total = (2 * Math.PI * radio);
            MessageBox.Show("la cantidad de alambre a usar es de: " + total + " metros.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            total = ancho * largo;
            MessageBox.Show("Se necesitan " + (total * 2) + " de cemento mas " + (total * 3) + " de cal.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
