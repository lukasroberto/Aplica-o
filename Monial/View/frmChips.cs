using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Monial
{
    public partial class frmChips : Form
    {
        ControllerChips controllerChips = new ControllerChips();
        //monialEntities db = new monialEntities();

        public frmChips()
        {
            InitializeComponent();
            preecheDataGridChips(controllerChips.carregarDadosChips());
        }
        public Panel acessaChips()
        {
            return this.panelChips;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaCamposCadastroChips() == true)
            {
                String status = cmbStatus.Text;
                int statusInt = 0;

                if (status == "ATIVO") { statusInt = 1; }
                if (status == "ESTOQUE") { statusInt = 2; }
                if (status == "CANCELADO") { statusInt = 3; }
                if (status == "CANCELAR") { statusInt = 4; }

                Chip chip = new Chip();

                chip.chip_id = int.Parse(txtChipId.Text);
                chip.chip_imei = txtImei.Text;
                chip.chip_operadora = cmbOperadora.Text;
                chip.chip_data_envio = DateTime.Parse(dtpDataEnvio.Text);
                chip.chip_status = statusInt;
                chip.cli_id = long.Parse(txtCliId.Text);

                controllerChips.saveOrUpdate(chip);
                controllerChips.linpaListaDeChips();
                preecheDataGridChips(controllerChips.carregarDadosChips());
            }
            else
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
            if (!txtChipId.Text.Equals(""))
            {
                controllerChips.delete(int.Parse(txtChipId.Text));

                preecheDataGridChips(controllerChips.carregarDadosChips());
            }
            else
            {
                MessageBox.Show("Selecione um Chip para ser excluido!");
            }
        }

        private void preecheDataGridChips(List<Chip> listaDeChips)
        {
            dataGridChips.Rows.Clear();
            try
            {
                foreach (var item in listaDeChips)
                {
                    String status = "";
                    if (item.chip_status == 1) { status = "ATIVO"; }
                    if (item.chip_status == 2) { status = "ESTOQUE"; }
                    if (item.chip_status == 3) { status = "CANCELADO"; }
                    if (item.chip_status == 4) { status = "CANCELAR"; }

                    dataGridChips.Rows.Add(item.chip_id, item.Cliente.cli_id, item.Cliente.cli_nome, item.chip_imei, item.chip_data_envio.Value.ToShortDateString(), item.chip_operadora, status);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private bool validaCamposCadastroChips()
        {
            if (txtCliNome.Text.Equals("") || txtImei.Text == "" || cmbOperadora.Text == "" || cmbStatus.Text == "" || dtpDataEnvio.Text == "")
            {
                return false;
            }
            return true;
        }

        private bool validaCamposBuscaChips()
        {
            switch (cmbBuscarChips.Text)
            {
                case "Código do Cliente":
                    if (!Char.IsDigit(txtBuscarChip.Text, 0))
                    {
                        return false;
                    }
                    return true;
                case "Imei":
                    if (!Char.IsDigit(txtBuscarChip.Text, 0))
                    {
                        return false;
                    }
                    return true;
            }return true;
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

            txtChipId.Text = rowData.Cells["chip_id"].Value.ToString();
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
            txtChipId.Text = "0";
        }

        private void btnBuscarChip_Click(object sender, EventArgs e)
        {
            if (validaCamposBuscaChips() == true)
            {
                var listaDeChipsParaFiltrar = controllerChips.filtraDadosChips(cmbBuscarChips.Text, txtBuscarChip.Text);

                preecheDataGridChips(listaDeChipsParaFiltrar);
            }else
            {
                MessageBox.Show("Para pesquisar Imei ou Código do Cliente utilize apenas números.");
            }

        }
    }
}