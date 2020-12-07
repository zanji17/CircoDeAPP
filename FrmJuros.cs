using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircodeApps2
{
    public partial class FrmJuros : Form
    {
        public FrmJuros()
        {
            InitializeComponent();
        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txttaxa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txttempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void FrmJuros_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtvalor;
            txtvalor.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double taxa1, taxa2, valor, anterior, montante,juros;
            int meses;
            anterior = 0.0;
            valor = Convert.ToDouble(txtvalor.Text);
            taxa1 = Convert.ToDouble(txttaxa.Text);
            meses = Convert.ToInt32(txttempo.Text);
            lbparcelas.Items.Clear();
            lbparcelas.BeginUpdate();
            for (int i = 1; i <= meses; i++)
            {
                taxa2 = (1 + taxa1 / 100);
                montante = (Math.Pow(taxa2, i)) * valor;
                juros = montante - valor - anterior;
                anterior += juros;
                string montante2 = montante.ToString("C");
                string juros2 = juros.ToString("C");
                lbparcelas.Items.Add("Mês: " + i + " - Montante: " + montante2 + "- Juros: " + juros2);
                string total2 = montante.ToString("C");
                lbltotal.Text = total2;
            }
            lbparcelas.EndUpdate();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
