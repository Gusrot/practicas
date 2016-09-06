using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adivinarNumero1
{
    public partial class Form1 : Form
    {
        private Random nuevo;
        private int numero;
        private int probar;
        private int intento=1;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            probar = int.Parse(this.textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (probar == numero)
                MessageBox.Show("Ganaste!!!!");
            else
            {
                MessageBox.Show("Segui participando");
                this.textBox2.Text = Convert.ToString(intento);
                if (probar < numero)
                    MessageBox.Show("Te falta");
                else
                    MessageBox.Show("Te pasaste");
            }
            intento++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nuevo = new Random();
            numero = nuevo.Next(0, 100);
        }
    }
}
