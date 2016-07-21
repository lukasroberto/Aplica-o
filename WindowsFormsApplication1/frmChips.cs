using Monial.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monial
{
    public partial class frmChips : Form
    {
        Chips controller = new Chips();

        public frmChips()
        {
            InitializeComponent();
        }
        public Panel acessaChips()
        {
            return this.panelButtonsChips;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            controller.cadastra(txtImei.Text, cmbOperadora.Text, DateTime.Parse(dtpDataEnvio.Text), Double.Parse(cmbStatus.Text), long.Parse(txtCliente.Text));
            MessageBox.Show("Cadastrado!");
        }

        private void validaCampos()
        {
            if (txtCliente.Text.Equals("") || txtImei.Text == "" || cmbOperadora.Text == "" || cmbStatus.Text == "" || dtpDataEnvio.Text == "")
            {
                MessageBox.Show("Por Favor, Preencha todos os Campos!");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Conexao.abrirConexao();
            // vamos obter a conexão com o banco de dados
            SqlConnection conn = Conexao.abrirConexao();

            // a conexão foi efetuada com sucesso?
            if (conn == null)
            {
                MessageBox.Show("Não foi possível obter a conexão. Veja o log de erros.");
            }
            else
            {
                MessageBox.Show("A conexão foi obtida com sucesso.");
            }

            // não precisamos mais da conexão? vamos fechá-la
            Conexao.fecharConexao();

        }
         private void preecheDataGridChips()
        {


        }
    }
}
