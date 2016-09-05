using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iluminacion
{
    public partial class Form1 : Form
    {
        private int cantidad;
        private string opcion;
        private double precioFinal;
        private double impuesto;
        private int lampara = 35;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cantidad = int.Parse(this.textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcion = this.comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(cantidad)
            {
                case 1:
                    precioFinal = lampara;
                    break;
                case 2:
                    precioFinal = lampara * 2;
                    break;
                case 3:
                    if ("ArgentinaLuz" == opcion)
                        precioFinal = (lampara * 3) * 0.85;
                    else if ("FelipeLamparas" == opcion)
                        precioFinal = (lampara * 3) * 0.9;
                    else
                        precioFinal = (lampara * 3) * 0.95;
                    break;
                case 4:
                    if ("ArgentinaLuz" == opcion || "FelipeLamparas" == opcion)
                        precioFinal = (lampara * 4) * 0.75;
                    else
                        precioFinal = (lampara * 4) * 0.8;
                    break;
                case 5:
                    if ("ArgentinaLuz" == opcion)
                        precioFinal = (lampara * 5) * 0.6;
                    else
                        precioFinal = (lampara * 5) * 0.7;
                    break;
                default:
                    precioFinal = (lampara * cantidad) * 0.5;
                    break;                  
            }
            if(precioFinal<120)
                this.textBox2.Text = Convert.ToString(precioFinal);
            else
            {
                impuesto = precioFinal * 0.1;
                precioFinal += impuesto;
                this.textBox2.Text = Convert.ToString(precioFinal);
                MessageBox.Show("El impuesto es de " + impuesto);
            }
        }
    }
}
