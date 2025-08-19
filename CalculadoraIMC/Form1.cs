using CalculadoraIMC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Validação dos campos
            // Verificar se o primeiro campo está vazio:
            if (txbPeso.Text == "")
            {
                MessageBox.Show("Preencha o Peso!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbAltura.Text == "")
            {
                MessageBox.Show("Preencha a Altura!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double peso = double.Parse(txbPeso.Text);
                double altura = double.Parse(txbAltura.Text);
                double IMC = peso / (altura * altura);



                // Classificar o IMC
                string classificacao = "";
                if (IMC < 18.5)
                {
                    classificacao = "Abaixo do peso";
                }
                else if (IMC >= 18.6 && IMC < 24.9)
                {
                    classificacao = "Peso Ideal";
                }
                else if (IMC >= 25 && IMC < 29.9)
                {
                    classificacao = "Levemente acima do peso";
                }
                else if (IMC >= 30 && IMC < 34.9)
                {
                    classificacao = "Obesidade grau I";
                }
                else if (IMC >= 35.0 && IMC < 39.9)
                {
                    classificacao = "Obesidade grau II (severa)";
                }
                else if (IMC >= 40)
                {
                    classificacao = "Obesidade grau III (mórbida)";
                }
                txbResultado.Text = $"IMC: {IMC:F2}\nClassificação: {classificacao}";
            }
        }

        private void txbPeso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbAltura.Focus();
            }
        }

        private void txbAltura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalcular.PerformClick();
            }
        }
    }
}