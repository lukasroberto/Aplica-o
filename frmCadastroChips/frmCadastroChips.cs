using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCadastroChips
{
    public partial class frmCadastrarChips : Form
    {
        public frmCadastrarChips()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblCodigoChip.Text = "Lukas";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperadora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
