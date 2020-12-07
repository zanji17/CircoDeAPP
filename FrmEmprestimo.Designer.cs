
namespace CircodeApps2
{
    partial class FrmEmprestimo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmprestimo));
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtjurospagos = new System.Windows.Forms.TextBox();
            this.txtpagamentomensal = new System.Windows.Forms.TextBox();
            this.txtjuros = new System.Windows.Forms.TextBox();
            this.txtprazo = new System.Windows.Forms.TextBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(414, 39);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(87, 23);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(28, 53);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(116, 20);
            this.txtvalor.TabIndex = 2;
            this.txtvalor.TextChanged += new System.EventHandler(this.txtvalor_TextChanged);
            this.txtvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtjurospagos);
            this.groupBox1.Controls.Add(this.txtpagamentomensal);
            this.groupBox1.Location = new System.Drawing.Point(174, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 198);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Demonstrativo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Juros Pagos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Pago";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(37, 88);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(116, 20);
            this.txttotal.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pagamento Mensal";
            // 
            // txtjurospagos
            // 
            this.txtjurospagos.Location = new System.Drawing.Point(37, 152);
            this.txtjurospagos.Name = "txtjurospagos";
            this.txtjurospagos.Size = new System.Drawing.Size(116, 20);
            this.txtjurospagos.TabIndex = 2;
            // 
            // txtpagamentomensal
            // 
            this.txtpagamentomensal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtpagamentomensal.Location = new System.Drawing.Point(37, 37);
            this.txtpagamentomensal.Name = "txtpagamentomensal";
            this.txtpagamentomensal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtpagamentomensal.Size = new System.Drawing.Size(116, 20);
            this.txtpagamentomensal.TabIndex = 2;
            // 
            // txtjuros
            // 
            this.txtjuros.Location = new System.Drawing.Point(28, 104);
            this.txtjuros.Name = "txtjuros";
            this.txtjuros.Size = new System.Drawing.Size(116, 20);
            this.txtjuros.TabIndex = 2;
            this.txtjuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtjuros_KeyPress);
            // 
            // txtprazo
            // 
            this.txtprazo.Location = new System.Drawing.Point(28, 164);
            this.txtprazo.Name = "txtprazo";
            this.txtprazo.Size = new System.Drawing.Size(116, 20);
            this.txtprazo.TabIndex = 2;
            this.txtprazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprazo_KeyPress);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(414, 93);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(87, 23);
            this.btnsair.TabIndex = 0;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor de Empréstimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Juros(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prazo(Anos)";
            // 
            // FrmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 241);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtjuros);
            this.Controls.Add(this.txtprazo);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncalcular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Empréstimo";
            this.Load += new System.EventHandler(this.FrmEmprestimo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtjuros;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtjurospagos;
        private System.Windows.Forms.TextBox txtpagamentomensal;
        private System.Windows.Forms.TextBox txtprazo;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}