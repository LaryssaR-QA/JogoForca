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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            Form F;
            F = new formJogo("");
            F.Show();
            this.Hide();
        }

        private void formMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }


     
    }
}
