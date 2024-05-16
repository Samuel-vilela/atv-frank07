using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv_frank07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            try
            {
                valor1 = double.Parse(textBoxValor1.Text);
                valor2 = double.Parse(textBoxValor2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro: Formato de número inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                    if (radioButtonAdicao.Checked)
            {
                resultado = valor1 + valor2;
            }
                      else if (radioButtonSubtracao.Checked)
            {
                resultado = valor1 - valor2;
            }
                      else if (radioButtonMultiplicacao.Checked)
            {
                resultado = valor1 * valor2;
            }
                   else if (radioButtonDivisao.Checked)
            {
                if (valor2 == 0)
                {
                    MessageBox.Show("Erro: Divisão por zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                resultado = valor1 / valor2;
            }
            else
            {
                resultado = 0;
            }

            labelResultado.Text = resultado.ToString();
        }
    }
}
