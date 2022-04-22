using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperadoresAritmeticos
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbNumero1.Text);
            int numero2 = Convert.ToInt32(txbNumero2.Text);
            //int resultado = numero1 + numero2;
            //txbResultado.Text = resultado.ToString();
            //notação reduzida
            //numero1 += numero2;
            //txbResultado.Text = numero1.ToString();
            txbResultado.Text = Somar(numero1, numero2, 100).ToString();

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbNumero1.Text);
            int numero2 = Convert.ToInt32(txbNumero2.Text);
            //int resultado = numero1 - numero2;
            //txbResultado.Text = resultado.ToString();
            txbResultado.Text = Subtrair(numero1, numero2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbNumero1.Text);
            int numero2 = Convert.ToInt32(txbNumero2.Text);
            //int resultado = numero1 * numero2;
            //txbResultado.Text = resultado.ToString();

            txbResultado.Text = Multiplicar(numero1, numero2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txbNumero1.Text);
            int numero2 = Convert.ToInt32(txbNumero2.Text);
            //int resultado = numero1 / numero2;
            //txbResultado.Text = resultado.ToString();
            txbResultado.Text = Dividir(numero1, numero2).ToString();

        }

      /*  int Somar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }
      */

        int Somar(params int [] numeros)//o params permite que você não passe nada de parametro
        {
            int resultado = 0;
            foreach (int numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }

        int Subtrair(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return resultado;
        }

        int Multiplicar (int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }

        int Dividir (int numero1, int numero2)
        {
            int resultado = numero1 / numero2;
            return resultado;
        }

    }
}
