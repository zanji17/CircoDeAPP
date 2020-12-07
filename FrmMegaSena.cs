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
    public partial class FrmMegaSena : Form
    {
        public FrmMegaSena()
        {
            InitializeComponent();
        }

        private void btnsortear_Click(object sender, EventArgs e)
        {
            lbnumeros.Items.Clear();
            lbnumeros.BeginUpdate();
            Random randnum = new Random();
            for (int i = 0; i <= 5; i++)
            {
                lbnumeros.Items.Add(randnum.Next(60));
            }
            lbnumeros.EndUpdate();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
