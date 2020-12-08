using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consolee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btncamioneta_Click(object sender, EventArgs e)
        {
            Camioneta c;
            c = new Camioneta();
            c.Espacio = 6;
            MessageBox.Show(c.ToString());
        }

        private void btncamion_Click(object sender, EventArgs e)
        {
            Camion c;
            c = new Camion();
            c.Asientos = 20;
            MessageBox.Show(c.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carro c;
            c = new Carro();
            c.Modelo = 2020;
            MessageBox.Show(c.ToString());

        }
    }
}
