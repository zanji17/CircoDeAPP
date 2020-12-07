
namespace CircodeApps2
{
    partial class FrmMegaSena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMegaSena));
            this.btnsortear = new System.Windows.Forms.Button();
            this.lblnumeros = new System.Windows.Forms.Label();
            this.lbnumeros = new System.Windows.Forms.ListBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsortear
            // 
            this.btnsortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsortear.Location = new System.Drawing.Point(230, 35);
            this.btnsortear.Name = "btnsortear";
            this.btnsortear.Size = new System.Drawing.Size(75, 23);
            this.btnsortear.TabIndex = 0;
            this.btnsortear.Text = "Sortear";
            this.btnsortear.UseVisualStyleBackColor = true;
            this.btnsortear.Click += new System.EventHandler(this.btnsortear_Click);
            // 
            // lblnumeros
            // 
            this.lblnumeros.AutoSize = true;
            this.lblnumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumeros.Location = new System.Drawing.Point(30, 19);
            this.lblnumeros.Name = "lblnumeros";
            this.lblnumeros.Size = new System.Drawing.Size(120, 13);
            this.lblnumeros.TabIndex = 1;
            this.lblnumeros.Text = "Númenos Sorteados";
            // 
            // lbnumeros
            // 
            this.lbnumeros.FormattingEnabled = true;
            this.lbnumeros.Location = new System.Drawing.Point(33, 35);
            this.lbnumeros.Name = "lbnumeros";
            this.lbnumeros.Size = new System.Drawing.Size(172, 186);
            this.lbnumeros.TabIndex = 2;
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(230, 90);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 0;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // FrmMegaSena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 371);
            this.Controls.Add(this.lbnumeros);
            this.Controls.Add(this.lblnumeros);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnsortear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMegaSena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nº da MegaSena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsortear;
        private System.Windows.Forms.Label lblnumeros;
        private System.Windows.Forms.ListBox lbnumeros;
        private System.Windows.Forms.Button btnsair;
    }
}