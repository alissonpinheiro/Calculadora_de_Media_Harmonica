using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // calcular
        {
            // Obter as notas dos TextBox
            if (double.TryParse(textBoxNota1.Text, out double nota1) &&
                double.TryParse(textBoxNota2.Text, out double nota2) &&
                double.TryParse(textBoxNota3.Text, out double nota3))
            {
                // Calcular a média harmônica
                double mediaHarmonica = CalcularMediaHarmonica(nota1, nota2, nota3);

                // Exibir o resultado em um MessageBox
                label6.Text = $"{mediaHarmonica:F2}";
            }
            
            else
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos para as notas.", "Erro de entrada");
            }
        }
        // Função para calcular a média harmônica
        private double CalcularMediaHarmonica(double a, double b, double c)
        {
            return 3.0 / ((1.0 / a) + (1.0 / b) + (1.0 / c));
        }

        private void button2_Click(object sender, EventArgs e) // limpar
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = "";
                }
            }
        }
    }
}
