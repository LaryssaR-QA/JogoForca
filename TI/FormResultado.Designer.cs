namespace TI
{
    partial class FormResultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResultado));
            this.pcbResultado = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPalavra = new System.Windows.Forms.Label();
            this.lblTituloPalavra = new System.Windows.Forms.Label();
            this.btnVoltarJogo = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbResultado
            // 
            this.pcbResultado.Location = new System.Drawing.Point(36, 31);
            this.pcbResultado.Name = "pcbResultado";
            this.pcbResultado.Size = new System.Drawing.Size(269, 317);
            this.pcbResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbResultado.TabIndex = 0;
            this.pcbResultado.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(398, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(70, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "label1";
            // 
            // lblPalavra
            // 
            this.lblPalavra.AutoSize = true;
            this.lblPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra.Location = new System.Drawing.Point(339, 199);
            this.lblPalavra.Name = "lblPalavra";
            this.lblPalavra.Size = new System.Drawing.Size(93, 33);
            this.lblPalavra.TabIndex = 2;
            this.lblPalavra.Text = "label1";
            // 
            // lblTituloPalavra
            // 
            this.lblTituloPalavra.AutoSize = true;
            this.lblTituloPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPalavra.Location = new System.Drawing.Point(340, 148);
            this.lblTituloPalavra.Name = "lblTituloPalavra";
            this.lblTituloPalavra.Size = new System.Drawing.Size(70, 25);
            this.lblTituloPalavra.TabIndex = 3;
            this.lblTituloPalavra.Text = "label1";
            // 
            // btnVoltarJogo
            // 
            this.btnVoltarJogo.Location = new System.Drawing.Point(382, 251);
            this.btnVoltarJogo.Name = "btnVoltarJogo";
            this.btnVoltarJogo.Size = new System.Drawing.Size(117, 23);
            this.btnVoltarJogo.TabIndex = 4;
            this.btnVoltarJogo.Text = "Jogar Novamente";
            this.btnVoltarJogo.UseVisualStyleBackColor = true;
            this.btnVoltarJogo.Click += new System.EventHandler(this.btnVoltarJogo_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Location = new System.Drawing.Point(382, 299);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(117, 23);
            this.btnMenuPrincipal.TabIndex = 5;
            this.btnMenuPrincipal.Text = "Menu Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // FormResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 390);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.btnVoltarJogo);
            this.Controls.Add(this.lblTituloPalavra);
            this.Controls.Add(this.lblPalavra);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pcbResultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado";
            ((System.ComponentModel.ISupportInitialize)(this.pcbResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbResultado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPalavra;
        private System.Windows.Forms.Label lblTituloPalavra;
        private System.Windows.Forms.Button btnVoltarJogo;
        private System.Windows.Forms.Button btnMenuPrincipal;
    }
}