using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = new Operacoes().Somar(Convert.ToInt32(txtNumero1.Text), Convert.ToInt32(txtNumero2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insira os valores corretos!");
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = new Operacoes().Subtrair(Convert.ToInt32(txtNumero1.Text), Convert.ToInt32(txtNumero2.Text)).ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
    }
}
