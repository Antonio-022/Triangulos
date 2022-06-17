using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea_II
{
    public partial class Form1 : Form
    {
        public int angulo_a = 0;
        public int angulo_b = 0;
        public int angulo_c = 0;
        public int contador = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            angulo_a = Convert.ToInt32(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            angulo_c = 150 - angulo_a - angulo_b;
            contador = angulo_a + angulo_b + angulo_c;

            if (contador == 180)
            {
                if (angulo_a == 90 || angulo_b == 90 || angulo_c == 90)
                {

                    label4.Text = "es triangulo rectangulo";
                }
                else if (angulo_a < 90 && angulo_b < 90 && angulo_c < 90)
                {
                    label4.Text = "es triangulo acutangulo";
                }
                else if (angulo_a > 90 && angulo_a < 180 || angulo_b > 90 && angulo_b < 180 || angulo_c > 90 && angulo_c < 180)
                {
                    label4.Text = "es triangulo obtusangulo";
                }
                else if (angulo_a >= 180 || angulo_b >= 180)
                {
                    label4.Text = "no es triangulo";
                }
                if (textBox1.Text == "0" || textBox2.Text == "0")
                {
                    label4.Text = "no es triangulo";

                }
                if (angulo_c <= 0)
                {
                    label4.Text = "no es triangulo";
                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            angulo_b = Convert.ToInt32(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
