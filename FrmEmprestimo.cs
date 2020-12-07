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
    public partial class FrmEmprestimo : Form
    {
        public FrmEmprestimo()
        {
            InitializeComponent();
        }

        private void FrmEmprestimo_Load(object sender, EventArgs e)
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

        private void txtjuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtprazo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double ValorEmprestimo, Pagamento, TaxaJuros, ValorTotalPago, ValorJurosPago;
            int PeriodoPagamento;
            try
            {
                TaxaJuros = Convert.ToDouble(txtjuros.Text);
                PeriodoPagamento = Convert.ToInt32(Convert.ToDouble(txtprazo.Text) * 12);
                ValorEmprestimo = Convert.ToDouble(txtvalor.Text);
                if (TaxaJuros >= 1)
                {
                    TaxaJuros = TaxaJuros / 100;
                }
                Pagamento = (ValorEmprestimo * Math.Pow((TaxaJuros / 12) + 1, (PeriodoPagamento)) * TaxaJuros / 12) / (Math.Pow(TaxaJuros / 12 + 1, (PeriodoPagamento)) - 1);
                ValorTotalPago = Pagamento * PeriodoPagamento;
                ValorJurosPago = ValorTotalPago - ValorEmprestimo;
                txtpagamentomensal.Text = Pagamento.ToString("N2");
                txttotal.Text = ValorTotalPago.ToString("N2");
                txtjurospagos.Text = ValorJurosPago.ToString("N2");
                txtvalor.Text = "";
                txtjuros.Text = "";
                txtprazo.Text = "";
                this.ActiveControl = txtvalor;
                txtvalor.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
