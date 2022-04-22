namespace TI
{
    partial class formJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formJogo));
            this.lblTema = new System.Windows.Forms.Label();
            this.lblTemaSorteado = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.pnlInformações = new System.Windows.Forms.Panel();
            this.lblLetrasTentadas = new System.Windows.Forms.Label();
            this.lblLetras = new System.Windows.Forms.Label();
            this.lblQuantidadeCaracteres = new System.Windows.Forms.Label();
            this.lblPalavra = new System.Windows.Forms.Label();
            this.textPalavra = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.pcbImagens = new System.Windows.Forms.PictureBox();
            this.menuJogo = new System.Windows.Forms.MenuStrip();
            this.menuInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInformações.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagens)).BeginInit();
            this.menuJogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTema.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.ForeColor = System.Drawing.Color.White;
            this.lblTema.Location = new System.Drawing.Point(19, 12);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(49, 20);
            this.lblTema.TabIndex = 0;
            this.lblTema.Text = "Tema:";
            // 
            // lblTemaSorteado
            // 
            this.lblTemaSorteado.AutoSize = true;
            this.lblTemaSorteado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTemaSorteado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemaSorteado.ForeColor = System.Drawing.Color.White;
            this.lblTemaSorteado.Location = new System.Drawing.Point(74, 11);
            this.lblTemaSorteado.Name = "lblTemaSorteado";
            this.lblTemaSorteado.Size = new System.Drawing.Size(52, 21);
            this.lblTemaSorteado.TabIndex = 1;
            this.lblTemaSorteado.Text = "label1";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblQuantidade.Location = new System.Drawing.Point(19, 32);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(182, 20);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade de caracteres:";
            // 
            // pnlInformações
            // 
            this.pnlInformações.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlInformações.BackgroundImage")));
            this.pnlInformações.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInformações.Controls.Add(this.lblLetrasTentadas);
            this.pnlInformações.Controls.Add(this.lblLetras);
            this.pnlInformações.Controls.Add(this.lblQuantidadeCaracteres);
            this.pnlInformações.Controls.Add(this.lblTema);
            this.pnlInformações.Controls.Add(this.lblQuantidade);
            this.pnlInformações.Controls.Add(this.lblTemaSorteado);
            this.pnlInformações.Location = new System.Drawing.Point(437, 37);
            this.pnlInformações.Name = "pnlInformações";
            this.pnlInformações.Size = new System.Drawing.Size(376, 176);
            this.pnlInformações.TabIndex = 3;
            // 
            // lblLetrasTentadas
            // 
            this.lblLetrasTentadas.AutoSize = true;
            this.lblLetrasTentadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblLetrasTentadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetrasTentadas.ForeColor = System.Drawing.Color.White;
            this.lblLetrasTentadas.Location = new System.Drawing.Point(20, 92);
            this.lblLetrasTentadas.Name = "lblLetrasTentadas";
            this.lblLetrasTentadas.Size = new System.Drawing.Size(0, 21);
            this.lblLetrasTentadas.TabIndex = 5;
            // 
            // lblLetras
            // 
            this.lblLetras.AutoSize = true;
            this.lblLetras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblLetras.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetras.ForeColor = System.Drawing.Color.White;
            this.lblLetras.Location = new System.Drawing.Point(20, 72);
            this.lblLetras.Name = "lblLetras";
            this.lblLetras.Size = new System.Drawing.Size(115, 20);
            this.lblLetras.TabIndex = 4;
            this.lblLetras.Text = "Letras utilizadas";
            // 
            // lblQuantidadeCaracteres
            // 
            this.lblQuantidadeCaracteres.AutoSize = true;
            this.lblQuantidadeCaracteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblQuantidadeCaracteres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeCaracteres.ForeColor = System.Drawing.Color.White;
            this.lblQuantidadeCaracteres.Location = new System.Drawing.Point(207, 31);
            this.lblQuantidadeCaracteres.Name = "lblQuantidadeCaracteres";
            this.lblQuantidadeCaracteres.Size = new System.Drawing.Size(52, 21);
            this.lblQuantidadeCaracteres.TabIndex = 3;
            this.lblQuantidadeCaracteres.Text = "label1";
            // 
            // lblPalavra
            // 
            this.lblPalavra.AutoSize = true;
            this.lblPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra.Location = new System.Drawing.Point(507, 256);
            this.lblPalavra.Name = "lblPalavra";
            this.lblPalavra.Size = new System.Drawing.Size(93, 33);
            this.lblPalavra.TabIndex = 4;
            this.lblPalavra.Text = "label2";
            this.lblPalavra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textPalavra
            // 
            this.textPalavra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPalavra.Location = new System.Drawing.Point(513, 316);
            this.textPalavra.Name = "textPalavra";
            this.textPalavra.Size = new System.Drawing.Size(113, 25);
            this.textPalavra.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(632, 317);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pcbImagens
            // 
            this.pcbImagens.Image = ((System.Drawing.Image)(resources.GetObject("pcbImagens.Image")));
            this.pcbImagens.InitialImage = null;
            this.pcbImagens.Location = new System.Drawing.Point(12, 37);
            this.pcbImagens.Name = "pcbImagens";
            this.pcbImagens.Size = new System.Drawing.Size(363, 351);
            this.pcbImagens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagens.TabIndex = 7;
            this.pcbImagens.TabStop = false;
            // 
            // menuJogo
            // 
            this.menuJogo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInicialToolStripMenuItem});
            this.menuJogo.Location = new System.Drawing.Point(0, 0);
            this.menuJogo.Name = "menuJogo";
            this.menuJogo.Size = new System.Drawing.Size(823, 24);
            this.menuJogo.TabIndex = 8;
            this.menuJogo.Text = "menuStrip1";
            // 
            // menuInicialToolStripMenuItem
            // 
            this.menuInicialToolStripMenuItem.Name = "menuInicialToolStripMenuItem";
            this.menuInicialToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuInicialToolStripMenuItem.Text = "Menu Principal";
            this.menuInicialToolStripMenuItem.Click += new System.EventHandler(this.menuInicialToolStripMenuItem_Click);
            // 
            // formJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 400);
            this.Controls.Add(this.pcbImagens);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textPalavra);
            this.Controls.Add(this.lblPalavra);
            this.Controls.Add(this.pnlInformações);
            this.Controls.Add(this.menuJogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuJogo;
            this.MaximizeBox = false;
            this.Name = "formJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forca";
            this.pnlInformações.ResumeLayout(false);
            this.pnlInformações.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagens)).EndInit();
            this.menuJogo.ResumeLayout(false);
            this.menuJogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblTemaSorteado;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Panel pnlInformações;
        private System.Windows.Forms.Label lblQuantidadeCaracteres;
        private System.Windows.Forms.Label lblLetrasTentadas;
        private System.Windows.Forms.Label lblLetras;
        private System.Windows.Forms.Label lblPalavra;
        private System.Windows.Forms.TextBox textPalavra;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pcbImagens;
        private System.Windows.Forms.MenuStrip menuJogo;
        private System.Windows.Forms.ToolStripMenuItem menuInicialToolStripMenuItem;
    }
}