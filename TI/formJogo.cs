using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI
{
    public partial class formJogo : Form
    {
        private int erro = 0;

        private void limparTentadas()
        {
            for (int i = 0; i < 25; i++)
            {
                Verificar.tentadas[i] = "";
            }
        }

        public formJogo(string ultima)
        {
            InitializeComponent();

            limparTentadas();
            Sorteio.Sortear(ultima);
            lblTemaSorteado.Text = Sorteio.TemaSorteado;
            lblQuantidadeCaracteres.Text = Convert.ToString(Sorteio.PalavraSorteada.Length);

            lblPalavra.Text = Verificar.povoarCampo(Sorteio.PalavraSorteada);
        }

        //Clique do Botão OK
        private void btnOk_Click(object sender, EventArgs e)
        {    
            int confirmacao=0;
            double numero;

            if (textPalavra.Text != "")
            {
                foreach (string letra in Verificar.tentadas)
                {
                    if (letra == textPalavra.Text.ToUpper())
                        MessageBox.Show("Erro", "Aviso", MessageBoxButtons.OK);
                    else
                    {
                        try
                        {
                            numero = Convert.ToDouble(textPalavra.Text);
                            MessageBox.Show("Erro", "Aviso", MessageBoxButtons.OK);
                        }
                        catch
                        {
                            confirmacao = Verificar.Testar(textPalavra.Text, Sorteio.PalavraSorteada);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Erro", "Aviso", MessageBoxButtons.OK);




                Verificar.Tentadas(textPalavra.Text);
                textPalavra.Text = "";
                textPalavra.Focus();
                lblPalavra.Text = Verificar.MostrarCampos(Sorteio.PalavraSorteada);

                if (confirmacao == 1)
                    erro++;
                else if (confirmacao == 50)
                    erro = 6;
                else if (confirmacao == 100)
                {
                    Form F;
                    F = new FormResultado(2);
                    F.Show();
                    this.Close();
                }


                verificarDerrota(erro);
                lblLetrasTentadas.Text = Verificar.MostrarTentadas();
            
        }

        //Metódo para verficar quantas tentativas o usuário já executou
        public void verificarDerrota(int tentativa)
        {
            if (tentativa == 1)
            {
                pcbImagens.Image = Properties.Resources._1;
            }
            else if (tentativa == 2)
            {
                pcbImagens.Image = Properties.Resources._2;
            }
            else if (tentativa == 3)
            {
                pcbImagens.Image = Properties.Resources._3;
            }
            else if (tentativa == 4)
            {
                pcbImagens.Image = Properties.Resources._4;
            }
            else if (tentativa == 5)
            {
                pcbImagens.Image = Properties.Resources._5;
            }
            else if (tentativa == 6)
            {
                Form F;
                F = new FormResultado(6);
                F.Show();
                this.Hide();
            }
        }

        private void menuInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form F;
            F = new formMenu();
            F.Show();
            this.Hide();
        }


    }
}
