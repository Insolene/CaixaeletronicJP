using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Saque : Form
    {
        
        public Saque()
        {
            InitializeComponent();
        }
        double dinheiroAtual = 0;
        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                while (textBox1.Text == "")
                {
                    MessageBox.Show("INSIRA UM VALOR!");
                   return;
                }

            }
            catch (Exception)
            {

                throw;
            }
            

            var num = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = num.ToString("N2");
               

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DecNumber(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (textBox1.Text != "") //Se fazer um saque com o valor nulo, nao ira aceita.
            {
               
                double dinheiro;
                dinheiro = Convert.ToDouble(textBox1.Text);

                if (dinheiroAtual < dinheiro)
                {
                    MessageBox.Show("Você não possui saldo suficiente");
                }
                else
                {
                   
                    dinheiroAtual = dinheiroAtual - dinheiro;
                    MessageBox.Show("Saque R$ " + dinheiro + ",00");
                    textBox1.Clear();
                }
                textBox1.Clear();//limpa a tela do saque
                
            }
            
        }
    }
}
