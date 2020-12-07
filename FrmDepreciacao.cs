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
    public partial class FrmDepreciacao : Form
    {
        public FrmDepreciacao()
        {
            InitializeComponent();
        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtano_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmDepreciacao_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtvalor;
            txtvalor.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double valor, preco, da, dm;
            int ano, anouso;
            valor = Convert.ToDouble(txtvalor.Text);
            ano = Convert.ToInt32(txtano.Text);
            anouso = 2020 - ano;
            da = valor / anouso;
            dm = da/12;
            preco = valor - da;
            lblvaloranual.Text = da.ToString("N2");
            lblvalormensal.Text = dm.ToString("N2");
            lblprecoatual.Text = preco.ToString("N2");
            txtvalor.Text = "";
            txtano.Text = "";
        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtano_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
