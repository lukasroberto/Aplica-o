using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Monial
{
    public partial class frmChips : Form
    {
        ControllerChips controllerChips = new ControllerChips();
        monialEntities db = new monialEntities();

        public frmChips()
        {
            InitializeComponent();
            preecheDataGridChips();
        }
        public Panel acessaChips()
        {
            return this.panelChips;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaCampos() == true)
            {
                String imei = txtImei.Text;
                String operadora = cmbOperadora.Text;
                DateTime data = DateTime.Parse(dtpDataEnvio.Text);
                long cliId = long.Parse(txtCliId.Text);
                String status = cmbStatus.Text;
                int statusICodigo = int.Parse(cmbStatus.Text);

                if (status == "ATIVO") { statusICodigo = 1; }
                if (status == "ESTOQUE") { statusICodigo = 2; }
                if (status == "CANCELADO") { statusICodigo = 3; }
                if (status == "CANCELAR") { statusICodigo = 4; }

                controllerChips.cadastra(imei,operadora,data,cliId,statusICodigo);
                MessageBox.Show("Cadastrado com sucesso!");
                preecheDataGridChips();
            }else
            {
                MessageBox.Show("Por Favor, Preencha todos os Campos!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(!txtCodigoChip.Text.Equals(""))
            {
                controllerChips.exclui(int.Parse(txtCodigoChip.Text));
                preecheDataGridChips();
            }
            else
            {
                MessageBox.Show("Selecione um Chip para ser excluido!");
            }
        }

        private void preecheDataGridChips()
        {
            dataGridChips.Rows.Clear();

            try
            {//where chip.chip_status == 1
                var query = (from chip in db.Chip  select chip);

                foreach (var item in query)
                {

                }

                foreach (var item in query)
                {
                    String status = "";
                    if (item.chip_status == 1) { status = "ATIVO"; }
                    if (item.chip_status == 2) { status = "ESTOQUE"; }
                    if (item.chip_status == 3) { status = "CANCELADO"; }
                    if (item.chip_status == 4) { status = "CANCELAR"; }

                dataGridChips.Rows.Add(item.chip_id,item.Cliente.cli_id,item.Cliente.cli_nome,item.chip_imei,item.chip_data_envio.Value.ToShortDateString(),item.chip_operadora,status);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private bool validaCampos()
        {
            if (txtCliNome.Text.Equals("") || txtImei.Text == "" || cmbOperadora.Text == "" || cmbStatus.Text == "" || dtpDataEnvio.Text == "")
            {
                return false;
            }
        return true;
        }


        private void dataGridChips_SelectionChanged(object sender, EventArgs e)
        {
            desabilitaCampos();
            var linha = dataGridChips.CurrentRow.Index;

            //Se linha é menor que -1 então retorna
            if (linha == -1)
            {
                return;
            }

            DataGridViewRow rowData = dataGridChips.Rows[linha];

            txtCodigoChip.Text = rowData.Cells["chip_id"].Value.ToString();
            txtCliId.Text = rowData.Cells["cli_id"].Value.ToString();
            txtCliNome.Text = rowData.Cells["cli_nome"].Value.ToString();
            txtImei.Text = rowData.Cells["chip_imei"].Value.ToString();
            dtpDataEnvio.Text = rowData.Cells["chip_data_envio"].Value.ToString();
            cmbOperadora.Text = rowData.Cells["chip_operadora"].Value.ToString();
            cmbStatus.Text = rowData.Cells["chip_status"].Value.ToString();
        }

        private void abilitaCampos()
        {
            txtCliId.Enabled = true;
            txtCliNome.Enabled = true;
            txtImei.Enabled = true;
            cmbOperadora.Enabled = true;
            cmbStatus.Enabled = true;
            dtpDataEnvio.Enabled = true;
        }

        private void desabilitaCampos()
        {
            txtCliId.Enabled = false;
            txtCliNome.Enabled = false;
            txtImei.Enabled = false;
            cmbOperadora.Enabled = false;
            cmbStatus.Enabled = false;
            dtpDataEnvio.Enabled = false;
        }

        private void limpaCampos()
        {
            txtCliId.Text = "";
            txtCliNome.Text = "";
            txtImei.Text = "";
            cmbOperadora.Text = "";
            cmbStatus.Text = "";
            dtpDataEnvio.Text = "";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            abilitaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            abilitaCampos();
            limpaCampos();
        }
    }
}