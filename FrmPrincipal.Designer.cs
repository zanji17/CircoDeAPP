namespace CircodeApps2
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.BtnSair = new System.Windows.Forms.Button();
            this.PicBIMC = new System.Windows.Forms.PictureBox();
            this.LblIMC = new System.Windows.Forms.Label();
            this.LblData = new System.Windows.Forms.Label();
            this.PicBData = new System.Windows.Forms.PictureBox();
            this.LblViagem = new System.Windows.Forms.Label();
            this.PicBViagem = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbmegasena = new System.Windows.Forms.PictureBox();
            this.pbdepreciacao = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbjuros = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBIMC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBViagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmegasena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdepreciacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbjuros)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.DarkRed;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSair.Location = new System.Drawing.Point(637, 376);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(151, 62);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // PicBIMC
            // 
            this.PicBIMC.Image = global::CircodeApps2.Properties.Resources.imc;
            this.PicBIMC.Location = new System.Drawing.Point(13, 13);
            this.PicBIMC.Name = "PicBIMC";
            this.PicBIMC.Size = new System.Drawing.Size(152, 138);
            this.PicBIMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBIMC.TabIndex = 1;
            this.PicBIMC.TabStop = false;
            this.PicBIMC.Click += new System.EventHandler(this.PicBIMC_Click);
            // 
            // LblIMC
            // 
            this.LblIMC.AutoSize = true;
            this.LblIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIMC.Location = new System.Drawing.Point(22, 154);
            this.LblIMC.Name = "LblIMC";
            this.LblIMC.Size = new System.Drawing.Size(130, 20);
            this.LblIMC.TabIndex = 2;
            this.LblIMC.Text = "Cálculo do IMC";
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblData.Location = new System.Drawing.Point(213, 154);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(137, 20);
            this.LblData.TabIndex = 4;
            this.LblData.Text = "Cálculo da Data";
            // 
            // PicBData
            // 
            this.PicBData.Image = global::CircodeApps2.Properties.Resources.calendario;
            this.PicBData.Location = new System.Drawing.Point(204, 13);
            this.PicBData.Name = "PicBData";
            this.PicBData.Size = new System.Drawing.Size(152, 138);
            this.PicBData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBData.TabIndex = 3;
            this.PicBData.TabStop = false;
            this.PicBData.Click += new System.EventHandler(this.PicBData_Click);
            // 
            // LblViagem
            // 
            this.LblViagem.AutoSize = true;
            this.LblViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblViagem.Location = new System.Drawing.Point(397, 155);
            this.LblViagem.Name = "LblViagem";
            this.LblViagem.Size = new System.Drawing.Size(158, 20);
            this.LblViagem.TabIndex = 6;
            this.LblViagem.Text = "Cálculo da Viagem";
            // 
            // PicBViagem
            // 
            this.PicBViagem.Image = global::CircodeApps2.Properties.Resources.viagem2;
            this.PicBViagem.Location = new System.Drawing.Point(401, 14);
            this.PicBViagem.Name = "PicBViagem";
            this.PicBViagem.Size = new System.Drawing.Size(152, 138);
            this.PicBViagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBViagem.TabIndex = 5;
            this.PicBViagem.TabStop = false;
            this.PicBViagem.Click += new System.EventHandler(this.PicBViagem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CircodeApps2.Properties.Resources.emprestimo;
            this.pictureBox1.Location = new System.Drawing.Point(609, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CircodeApps2.Properties.Resources.Moeda;
            this.pictureBox2.Location = new System.Drawing.Point(13, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cálculo de Empréstimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Conversor de Moedas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nº da Megasena";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pbmegasena
            // 
            this.pbmegasena.Image = global::CircodeApps2.Properties.Resources.megasena;
            this.pbmegasena.Location = new System.Drawing.Point(204, 199);
            this.pbmegasena.Name = "pbmegasena";
            this.pbmegasena.Size = new System.Drawing.Size(153, 136);
            this.pbmegasena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmegasena.TabIndex = 12;
            this.pbmegasena.TabStop = false;
            this.pbmegasena.Click += new System.EventHandler(this.pbmegasena_Click);
            // 
            // pbdepreciacao
            // 
            this.pbdepreciacao.Image = global::CircodeApps2.Properties.Resources.despreciação_de_veiculo;
            this.pbdepreciacao.Location = new System.Drawing.Point(400, 199);
            this.pbdepreciacao.Name = "pbdepreciacao";
            this.pbdepreciacao.Size = new System.Drawing.Size(153, 136);
            this.pbdepreciacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdepreciacao.TabIndex = 13;
            this.pbdepreciacao.TabStop = false;
            this.pbdepreciacao.Click += new System.EventHandler(this.pbdepreciacao_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Depreciação de Veículo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(613, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Juros Compostos";
            // 
            // pbjuros
            // 
            this.pbjuros.Image = global::CircodeApps2.Properties.Resources.JurosCompostos;
            this.pbjuros.Location = new System.Drawing.Point(609, 197);
            this.pbjuros.Name = "pbjuros";
            this.pbjuros.Size = new System.Drawing.Size(152, 138);
            this.pbjuros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbjuros.TabIndex = 15;
            this.pbjuros.TabStop = false;
            this.pbjuros.Click += new System.EventHandler(this.pbjuros_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbjuros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbdepreciacao);
            this.Controls.Add(this.pbmegasena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblViagem);
            this.Controls.Add(this.PicBViagem);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.PicBData);
            this.Controls.Add(this.LblIMC);
            this.Controls.Add(this.PicBIMC);
            this.Controls.Add(this.BtnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circo de Apps";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBIMC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBViagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmegasena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdepreciacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbjuros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.PictureBox PicBIMC;
        private System.Windows.Forms.Label LblIMC;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.PictureBox PicBData;
        private System.Windows.Forms.Label LblViagem;
        private System.Windows.Forms.PictureBox PicBViagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbmegasena;
        private System.Windows.Forms.PictureBox pbdepreciacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbjuros;
    }
}

