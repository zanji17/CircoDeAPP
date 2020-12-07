
namespace CircodeApps2
{
    partial class FrmConvMoedas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConvMoedas));
            this.btnconverter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.lbldolar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbleuro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblfranco = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbliene = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnconverter
            // 
            this.btnconverter.Location = new System.Drawing.Point(230, 19);
            this.btnconverter.Name = "btnconverter";
            this.btnconverter.Size = new System.Drawing.Size(75, 23);
            this.btnconverter.TabIndex = 0;
            this.btnconverter.Text = "Converter";
            this.btnconverter.UseVisualStyleBackColor = true;
            this.btnconverter.Click += new System.EventHandler(this.btnconverter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor em Reais";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(15, 35);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 2;
            this.txtvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor em Dólar";
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(230, 66);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 0;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lbldolar
            // 
            this.lbldolar.AutoSize = true;
            this.lbldolar.Location = new System.Drawing.Point(12, 84);
            this.lbldolar.Name = "lbldolar";
            this.lbldolar.Size = new System.Drawing.Size(0, 13);
            this.lbldolar.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor em Euro";
            // 
            // lbleuro
            // 
            this.lbleuro.AutoSize = true;
            this.lbleuro.Location = new System.Drawing.Point(12, 129);
            this.lbleuro.Name = "lbleuro";
            this.lbleuro.Size = new System.Drawing.Size(0, 13);
            this.lbleuro.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Franco Suiço";
            // 
            // lblfranco
            // 
            this.lblfranco.AutoSize = true;
            this.lblfranco.Location = new System.Drawing.Point(12, 173);
            this.lblfranco.Name = "lblfranco";
            this.lblfranco.Size = new System.Drawing.Size(0, 13);
            this.lblfranco.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Iene";
            // 
            // lbliene
            // 
            this.lbliene.AutoSize = true;
            this.lbliene.Location = new System.Drawing.Point(12, 232);
            this.lbliene.Name = "lbliene";
            this.lbliene.Size = new System.Drawing.Size(0, 13);
            this.lbliene.TabIndex = 1;
            // 
            // FrmConvMoedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 284);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lbliene);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblfranco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbleuro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbldolar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnconverter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConvMoedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Moedas";
            this.Load += new System.EventHandler(this.FrmConvMoedas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconverter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lbldolar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbleuro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblfranco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbliene;
    }
}