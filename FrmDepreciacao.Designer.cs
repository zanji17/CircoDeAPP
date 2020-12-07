
namespace CircodeApps2
{
    partial class FrmDepreciacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepreciacao));
            this.lblvalor = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.lblano = new System.Windows.Forms.Label();
            this.txtano = new System.Windows.Forms.TextBox();
            this.lblanual = new System.Windows.Forms.Label();
            this.lblmensal = new System.Windows.Forms.Label();
            this.lblvaloranual = new System.Windows.Forms.Label();
            this.lblvalormensal = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.lblprecoatual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.Location = new System.Drawing.Point(21, 32);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(88, 13);
            this.lblvalor.TabIndex = 0;
            this.lblvalor.Text = "Valor do Carro";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(24, 48);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 1;
            this.txtvalor.TextChanged += new System.EventHandler(this.txtvalor_TextChanged);
            this.txtvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor_KeyPress);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(353, 42);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(353, 86);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lblano
            // 
            this.lblano.AutoSize = true;
            this.lblano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblano.Location = new System.Drawing.Point(21, 88);
            this.lblano.Name = "lblano";
            this.lblano.Size = new System.Drawing.Size(114, 13);
            this.lblano.TabIndex = 0;
            this.lblano.Text = "Ano de Fabricação";
            // 
            // txtano
            // 
            this.txtano.Location = new System.Drawing.Point(24, 104);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(100, 20);
            this.txtano.TabIndex = 1;
            this.txtano.TextChanged += new System.EventHandler(this.txtano_TextChanged);
            this.txtano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtano_KeyPress);
            // 
            // lblanual
            // 
            this.lblanual.AutoSize = true;
            this.lblanual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanual.Location = new System.Drawing.Point(188, 32);
            this.lblanual.Name = "lblanual";
            this.lblanual.Size = new System.Drawing.Size(115, 13);
            this.lblanual.TabIndex = 0;
            this.lblanual.Text = "Depreciação Anual";
            // 
            // lblmensal
            // 
            this.lblmensal.AutoSize = true;
            this.lblmensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensal.Location = new System.Drawing.Point(188, 88);
            this.lblmensal.Name = "lblmensal";
            this.lblmensal.Size = new System.Drawing.Size(123, 13);
            this.lblmensal.TabIndex = 0;
            this.lblmensal.Text = "Depreciação Mensal";
            // 
            // lblvaloranual
            // 
            this.lblvaloranual.AutoSize = true;
            this.lblvaloranual.Location = new System.Drawing.Point(188, 55);
            this.lblvaloranual.Name = "lblvaloranual";
            this.lblvaloranual.Size = new System.Drawing.Size(0, 13);
            this.lblvaloranual.TabIndex = 0;
            // 
            // lblvalormensal
            // 
            this.lblvalormensal.AutoSize = true;
            this.lblvalormensal.Location = new System.Drawing.Point(188, 111);
            this.lblvalormensal.Name = "lblvalormensal";
            this.lblvalormensal.Size = new System.Drawing.Size(0, 13);
            this.lblvalormensal.TabIndex = 0;
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreco.Location = new System.Drawing.Point(188, 146);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(73, 13);
            this.lblpreco.TabIndex = 0;
            this.lblpreco.Text = "Preço Atual";
            // 
            // lblprecoatual
            // 
            this.lblprecoatual.AutoSize = true;
            this.lblprecoatual.Location = new System.Drawing.Point(188, 169);
            this.lblprecoatual.Name = "lblprecoatual";
            this.lblprecoatual.Size = new System.Drawing.Size(0, 13);
            this.lblprecoatual.TabIndex = 0;
            // 
            // FrmDepreciacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 350);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.lblprecoatual);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.lblvalormensal);
            this.Controls.Add(this.lblmensal);
            this.Controls.Add(this.lblano);
            this.Controls.Add(this.lblvaloranual);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lblanual);
            this.Controls.Add(this.lblvalor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDepreciacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depreciação de Veículo";
            this.Load += new System.EventHandler(this.FrmDepreciacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lblano;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.Label lblanual;
        private System.Windows.Forms.Label lblmensal;
        private System.Windows.Forms.Label lblvaloranual;
        private System.Windows.Forms.Label lblvalormensal;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.Label lblprecoatual;
    }
}