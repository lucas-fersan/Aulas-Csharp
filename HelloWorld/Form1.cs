using System;
using System.Windows.Forms;

namespace CalculadoraWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0;

          
            if (double.TryParse(txtNumero1.Text, out num1) && double.TryParse(txtNumero2.Text, out num2))
            {
            
                if (sender == btnSoma)
                {
                    resultado = num1 + num2;
                }
                else if (sender == btnSubtracao)
                {
                    resultado = num1 - num2;
                }
                else if (sender == btnMultiplicacao)
                {
                    resultado = num1 * num2;
                }
                else if (sender == btnDivisao)
                {
              
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("Não é possível dividir por zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

              
                lblResultado.Text = "Resultado: " + resultado.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, insira números válidos.", "Erro de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void btnSoma_Click(object sender, EventArgs e)
        {
            btnCalcular_Click(sender, e);
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            btnCalcular_Click(sender, e);
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            btnCalcular_Click(sender, e);
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            btnCalcular_Click(sender, e);
        }
    }
}
