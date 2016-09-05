using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinturas
{
    public partial class Form1 : Form
    {
        private int temperatura;
        private double convertir;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            temperatura = int.Parse(this.textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            convertir = (temperatura - 32) / 1.8;
            MessageBox.Show(temperatura + " fahrenheit son " + convertir + "°centigrados");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            convertir = (temperatura * 1.8) + 32;
            MessageBox.Show(temperatura + "°centigrados son " + convertir + " fahrenheit");
        }
    }
}
