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
    public partial class FrmConvMoedas : Form
    {
        public FrmConvMoedas()
        {
            InitializeComponent();
        }

        private void FrmConvMoedas_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtvalor;
            txtvalor.Focus();
        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void btnconverter_Click(object sender, EventArgs e)
        {
            double dolar, euro, franco, iene, reais;
            reais = Convert.ToDouble(txtvalor.Text);
            dolar = reais / 5.22;
            euro = reais / 6.32;
            franco = reais / 5.83;
            iene = reais / 0.05;
            lbldolar.Text = dolar.ToString("N2");
            lbleuro.Text = euro.ToString("N2");
            lblfranco.Text = franco.ToString("N2");
            lbliene.Text = iene.ToString("N0");
            txtvalor.Text = "";
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
