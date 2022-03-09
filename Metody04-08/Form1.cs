using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody04_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Mocnina_Click(object sender, EventArgs e)
        {
            int zaklad = int.Parse(textBox1.Text);
            int exponent = int.Parse(textBox2.Text);

            MessageBox.Show("Mocnina se rovná: " + CelaCisla.Mocnina(zaklad, exponent));
        }

        private void button_Faktorial_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox3.Text);

            MessageBox.Show("Faktoriál se rovná: " + CelaCisla.Faktorial(x));
        }

        private void button_CifLichSoucet_Click(object sender, EventArgs e)
        {
            int cislo = int.Parse(textBox4.Text);

            MessageBox.Show("Součet lichých cifer je " + CelaCisla.CifLichSoucet(cislo));
        }

        private void button_JePrvocislo_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox5.Text);

            if(CelaCisla.JePrvocislo(n))
            {
                MessageBox.Show("Ano, je prvočíslo");
            }
            else
            {
                MessageBox.Show("Ne, není prvočíslo");
            }
        }

        private void button_PocetDeliteluSud_Click(object sender, EventArgs e)
        {

        }
    }
}
