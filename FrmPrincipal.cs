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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicBIMC_Click(object sender, EventArgs e)
        {
            FrmIMC imc = new FrmIMC();
            imc.Show();
        }

        private void PicBData_Click(object sender, EventArgs e)
        {
            FrmData data = new FrmData();
            data.Show();
        }

        private void PicBViagem_Click(object sender, EventArgs e)
        {
            FrmViagem viagem = new FrmViagem();
            viagem.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmEmprestimo emprestimo = new FrmEmprestimo();
            emprestimo.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmConvMoedas converter_moeda = new FrmConvMoedas();
            converter_moeda.Show();
        }

        private void pbmegasena_Click(object sender, EventArgs e)
        {
            FrmMegaSena megasena = new FrmMegaSena();
            megasena.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pbdepreciacao_Click(object sender, EventArgs e)
        {
            FrmDepreciacao dep_carro = new FrmDepreciacao();
            dep_carro.Show();
        }

        private void pbjuros_Click(object sender, EventArgs e)
        {
            FrmJuros juros = new FrmJuros();
            juros.Show();
        }
    }
}
