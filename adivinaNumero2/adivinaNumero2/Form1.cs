using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adivinaNumero2
{
    public partial class Form1 : Form
    {
        private Random rng;
        private int numero;
        private int intentos=1;
        private int probar;

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
            if(probar == numero)
            {
                switch (intentos)
                {
                    case 1:
                        MessageBox.Show("1° intento: “usted es un Psíquico”.");
                        break;
                    case 2:
                        MessageBox.Show("2° intento: “excelente percepción”. ");
                        break;
                    case 3:
                        MessageBox.Show("3° intento: “Esto es suerte”.  ");
                        break;
                    case 4:
                        MessageBox.Show("4° intento: “Excelente técnica”. ");
                        break;
                    case 5:
                        MessageBox.Show("5° intento: “usted está en la media”.  ");
                        break;
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        MessageBox.Show("Falta tecnica");
                        break;
                    default:
                        MessageBox.Show("Afortunado en el amor! ");
                        break;
                }
            }
            else
            {
                {
                    MessageBox.Show("Segui participando");
                    this.textBox2.Text = Convert.ToString(intentos);
                    if (probar < numero)
                        MessageBox.Show("Te falta");
                    else
                        MessageBox.Show("Te pasaste");
                }
            }

            intentos++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rng = new Random();
            numero = rng.Next(0, 100);
        }
    }
}
