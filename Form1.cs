using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMCforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
              double peso, altura;

    // Verifica se os campos não estão vazios
    if (string.IsNullOrWhiteSpace(txtPeso.Text) || string.IsNullOrWhiteSpace(txtAltura.Text))
    {
        MessageBox.Show("Preencha todos os campos.");
        return;
    }

    // Tenta converter os valores
    bool pesoValido = double.TryParse(txtPeso.Text, out peso);
    bool alturaValida = double.TryParse(txtAltura.Text, out altura);

    if (!pesoValido || !alturaValida)
    {
        MessageBox.Show("Digite valores numéricos válidos.");
        return;
    }

    if (peso > 0 && altura > 0)
    {
        // Calcula o IMC
        double imc = peso / (altura * altura);
        string classificacao = "";

        if (imc < 18.5)
        {
            classificacao = "Abaixo do peso";
        }
        else if (imc < 24.9)
        {
            classificacao = "Peso normal";
        }
        else if (imc < 29.9)
        {
            classificacao = "Sobrepeso";
        }
        else if (imc < 34.9)
        {
            classificacao = "Obesidade grau I";
        }
        else if (imc < 39.9)
        {
            classificacao = "Obesidade grau II";
        }
        else
        {
            classificacao = "Obesidade grau III (mórbida)";
        }

        lblResultado.Text = $"IMC: {imc:F2} - {classificacao}";
    }
    else
    {
        MessageBox.Show("Peso e altura devem ser maiores que zero.");
    }
}
       

        }
    }
}
    
  



        
