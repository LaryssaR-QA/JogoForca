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
    public partial class FormResultado : Form
    {
        string ultimaSorteada;

        public FormResultado(int resultado)
        {
            InitializeComponent();

            lblPalavra.Text = Sorteio.PalavraSorteada;
            ultimaSorteada = Sorteio.PalavraSorteada;

            
            if (resultado == 6)
            {
                pcbResultado.Image = Properties.Resources.MORTO;
                lblTitulo.Text = "  Que pena !! \nVocê perdeu =(";
                lblTituloPalavra.Text = "A palavra era";
                this.Text = "Game Over";
            }

            else if (resultado == 2)
            {
                pcbResultado.Image = Properties.Resources.FELIZ;
                lblTitulo.Text = "  Parabéns !! \nVocê ganhou =D";
                lblTituloPalavra.Text = "Como sabe a palavra era";
                this.Text = "Congratulations!!!";
            }
        }

        private void btnVoltarJogo_Click(object sender, EventArgs e)
        {
            Form F;
            F = new formJogo(this.ultimaSorteada);
            F.Show();
            this.Close();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            Form F;
            F = new formMenu();
            F.Show();
            this.Close();
        }
//teste git
    }
}
