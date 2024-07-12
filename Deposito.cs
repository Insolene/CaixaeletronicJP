using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }
        double dinheiroAtual = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DecNumber(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Insira o valor do Deposito");
            }
            else
            {
                var num = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = num.ToString("N2");

                double dinheiro;
                dinheiro = Convert.ToDouble(textBox1.Text); //Converter texto para double
                dinheiroAtual = dinheiroAtual + dinheiro;
                textBox1.Clear();//limpa a tela do Deposito
            }

            
        }
    }
}
