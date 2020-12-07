
namespace CircodeApps2
{
    partial class FrmJuros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJuros));
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblvalor = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.lbparcelas = new System.Windows.Forms.ListBox();
            this.txttaxa = new System.Windows.Forms.TextBox();
            this.lbltaxa = new System.Windows.Forms.Label();
            this.txttempo = new System.Windows.Forms.TextBox();
            this.lbltempo = new System.Windows.Forms.Label();
            this.lblparcelas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(768, 22);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(87, 23);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.Location = new System.Drawing.Point(35, 22);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(36, 13);
            this.lblvalor.TabIndex = 1;
            this.lblvalor.Text = "Valor";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(38, 38);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(116, 20);
            this.txtvalor.TabIndex = 2;
            this.txtvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor_KeyPress);
            // 
            // lbparcelas
            // 
            this.lbparcelas.FormattingEnabled = true;
            this.lbparcelas.Location = new System.Drawing.Point(262, 38);
            this.lbparcelas.Name = "lbparcelas";
            this.lbparcelas.Size = new System.Drawing.Size(342, 212);
            this.lbparcelas.TabIndex = 3;
            // 
            // txttaxa
            // 
            this.txttaxa.Location = new System.Drawing.Point(38, 97);
            this.txttaxa.Name = "txttaxa";
            this.txttaxa.Size = new System.Drawing.Size(116, 20);
            this.txttaxa.TabIndex = 5;
            this.txttaxa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttaxa_KeyPress);
            // 
            // lbltaxa
            // 
            this.lbltaxa.AutoSize = true;
            this.lbltaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaxa.Location = new System.Drawing.Point(35, 81);
            this.lbltaxa.Name = "lbltaxa";
            this.lbltaxa.Size = new System.Drawing.Size(104, 13);
            this.lbltaxa.TabIndex = 4;
            this.lbltaxa.Text = "Taxa de Juros(%)";
            // 
            // txttempo
            // 
            this.txttempo.Location = new System.Drawing.Point(38, 169);
            this.txttempo.Name = "txttempo";
            this.txttempo.Size = new System.Drawing.Size(116, 20);
            this.txttempo.TabIndex = 7;
            this.txttempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttempo_KeyPress);
            // 
            // lbltempo
            // 
            this.lbltempo.AutoSize = true;
            this.lbltempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltempo.Location = new System.Drawing.Point(35, 153);
            this.lbltempo.Name = "lbltempo";
            this.lbltempo.Size = new System.Drawing.Size(89, 13);
            this.lbltempo.TabIndex = 6;
            this.lbltempo.Text = "Tempo(Meses)";
            // 
            // lblparcelas
            // 
            this.lblparcelas.AutoSize = true;
            this.lblparcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblparcelas.Location = new System.Drawing.Point(259, 22);
            this.lblparcelas.Name = "lblparcelas";
            this.lblparcelas.Size = new System.Drawing.Size(56, 13);
            this.lblparcelas.TabIndex = 8;
            this.lblparcelas.Text = "Parcelas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resultado";
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(768, 71);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(87, 23);
            this.btnsair.TabIndex = 10;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(259, 291);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 31);
            this.lbltotal.TabIndex = 11;
            // 
            // FrmJuros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblparcelas);
            this.Controls.Add(this.txttempo);
            this.Controls.Add(this.lbltempo);
            this.Controls.Add(this.txttaxa);
            this.Controls.Add(this.lbltaxa);
            this.Controls.Add(this.lbparcelas);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.btncalcular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmJuros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juros Compostos";
            this.Load += new System.EventHandler(this.FrmJuros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.ListBox lbparcelas;
        private System.Windows.Forms.TextBox txttaxa;
        private System.Windows.Forms.Label lbltaxa;
        private System.Windows.Forms.TextBox txttempo;
        private System.Windows.Forms.Label lbltempo;
        private System.Windows.Forms.Label lblparcelas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lbltotal;
    }
}