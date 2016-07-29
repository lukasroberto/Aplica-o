namespace Monial
{
    partial class frmChips
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panelChips = new System.Windows.Forms.Panel();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnBuscarChip = new System.Windows.Forms.Button();
            this.cmbBuscarChips = new System.Windows.Forms.ComboBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtBuscarChip = new System.Windows.Forms.TextBox();
            this.txtCliId = new System.Windows.Forms.TextBox();
            this.dataGridChips = new System.Windows.Forms.DataGridView();
            this.chip_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chip_imei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chip_data_envio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chip_operadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chip_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbOperadora = new System.Windows.Forms.ComboBox();
            this.dtpDataEnvio = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtCliNome = new System.Windows.Forms.TextBox();
            this.txtImei = new System.Windows.Forms.TextBox();
            this.txtChipId = new System.Windows.Forms.TextBox();
            this.lblImei = new System.Windows.Forms.Label();
            this.lblOperadora = new System.Windows.Forms.Label();
            this.lblDataEnvio = new System.Windows.Forms.Label();
            this.lblClienteInstalado = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCodigoChip = new System.Windows.Forms.Label();
            this.panelChips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChips)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(879, 508);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 55);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(18, 508);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(80, 55);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(104, 508);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(80, 55);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Location = new System.Drawing.Point(190, 508);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 55);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.Green;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(794, 508);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(79, 55);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panelChips
            // 
            this.panelChips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChips.Controls.Add(this.btnBuscarCliente);
            this.panelChips.Controls.Add(this.btnBuscarChip);
            this.panelChips.Controls.Add(this.cmbBuscarChips);
            this.panelChips.Controls.Add(this.lblbuscar);
            this.panelChips.Controls.Add(this.txtBuscarChip);
            this.panelChips.Controls.Add(this.txtCliId);
            this.panelChips.Controls.Add(this.dataGridChips);
            this.panelChips.Controls.Add(this.cmbOperadora);
            this.panelChips.Controls.Add(this.dtpDataEnvio);
            this.panelChips.Controls.Add(this.cmbStatus);
            this.panelChips.Controls.Add(this.txtCliNome);
            this.panelChips.Controls.Add(this.txtImei);
            this.panelChips.Controls.Add(this.txtChipId);
            this.panelChips.Controls.Add(this.lblImei);
            this.panelChips.Controls.Add(this.lblOperadora);
            this.panelChips.Controls.Add(this.lblDataEnvio);
            this.panelChips.Controls.Add(this.lblClienteInstalado);
            this.panelChips.Controls.Add(this.lblStatus);
            this.panelChips.Controls.Add(this.lblCodigoChip);
            this.panelChips.Controls.Add(this.btnNovo);
            this.panelChips.Controls.Add(this.btnCancelar);
            this.panelChips.Controls.Add(this.btnAlterar);
            this.panelChips.Controls.Add(this.btnExcluir);
            this.panelChips.Controls.Add(this.btnSalvar);
            this.panelChips.Location = new System.Drawing.Point(0, 1);
            this.panelChips.Name = "panelChips";
            this.panelChips.Size = new System.Drawing.Size(987, 579);
            this.panelChips.TabIndex = 36;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(459, 30);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(66, 24);
            this.btnBuscarCliente.TabIndex = 6;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // btnBuscarChip
            // 
            this.btnBuscarChip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarChip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarChip.Location = new System.Drawing.Point(905, 118);
            this.btnBuscarChip.Name = "btnBuscarChip";
            this.btnBuscarChip.Size = new System.Drawing.Size(66, 24);
            this.btnBuscarChip.TabIndex = 10;
            this.btnBuscarChip.Text = "Buscar";
            this.btnBuscarChip.UseVisualStyleBackColor = true;
            this.btnBuscarChip.Click += new System.EventHandler(this.btnBuscarChip_Click);
            // 
            // cmbBuscarChips
            // 
            this.cmbBuscarChips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBuscarChips.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarChips.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscarChips.FormattingEnabled = true;
            this.cmbBuscarChips.Items.AddRange(new object[] {
            "Imei",
            "Operadora",
            "Nome do Cliente",
            "Código do Cliente"});
            this.cmbBuscarChips.Location = new System.Drawing.Point(724, 118);
            this.cmbBuscarChips.Name = "cmbBuscarChips";
            this.cmbBuscarChips.Size = new System.Drawing.Size(175, 24);
            this.cmbBuscarChips.TabIndex = 9;
            // 
            // lblbuscar
            // 
            this.lblbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(517, 123);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(64, 13);
            this.lblbuscar.TabIndex = 52;
            this.lblbuscar.Text = "Buscar Chip";
            // 
            // txtBuscarChip
            // 
            this.txtBuscarChip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarChip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBuscarChip.Location = new System.Drawing.Point(587, 118);
            this.txtBuscarChip.Name = "txtBuscarChip";
            this.txtBuscarChip.Size = new System.Drawing.Size(131, 23);
            this.txtBuscarChip.TabIndex = 8;
            this.txtBuscarChip.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarChip_KeyUp);
            // 
            // txtCliId
            // 
            this.txtCliId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCliId.Location = new System.Drawing.Point(402, 31);
            this.txtCliId.Name = "txtCliId";
            this.txtCliId.Size = new System.Drawing.Size(54, 23);
            this.txtCliId.TabIndex = 5;
            // 
            // dataGridChips
            // 
            this.dataGridChips.AllowDrop = true;
            this.dataGridChips.AllowUserToAddRows = false;
            this.dataGridChips.AllowUserToDeleteRows = false;
            this.dataGridChips.AllowUserToOrderColumns = true;
            this.dataGridChips.AllowUserToResizeRows = false;
            this.dataGridChips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridChips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridChips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chip_id,
            this.cli_id,
            this.cli_nome,
            this.chip_imei,
            this.chip_data_envio,
            this.chip_operadora,
            this.chip_status});
            this.dataGridChips.Location = new System.Drawing.Point(18, 148);
            this.dataGridChips.MultiSelect = false;
            this.dataGridChips.Name = "dataGridChips";
            this.dataGridChips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridChips.Size = new System.Drawing.Size(951, 354);
            this.dataGridChips.TabIndex = 11;
            this.dataGridChips.SelectionChanged += new System.EventHandler(this.dataGridChips_SelectionChanged);
            // 
            // chip_id
            // 
            this.chip_id.HeaderText = "Código";
            this.chip_id.Name = "chip_id";
            this.chip_id.Width = 65;
            // 
            // cli_id
            // 
            this.cli_id.HeaderText = "Código Cliente";
            this.cli_id.Name = "cli_id";
            // 
            // cli_nome
            // 
            this.cli_nome.HeaderText = "Nome";
            this.cli_nome.Name = "cli_nome";
            this.cli_nome.Width = 60;
            // 
            // chip_imei
            // 
            this.chip_imei.HeaderText = "Imei";
            this.chip_imei.Name = "chip_imei";
            this.chip_imei.Width = 51;
            // 
            // chip_data_envio
            // 
            this.chip_data_envio.HeaderText = "Data Envio";
            this.chip_data_envio.Name = "chip_data_envio";
            this.chip_data_envio.Width = 85;
            // 
            // chip_operadora
            // 
            this.chip_operadora.HeaderText = "Operadora";
            this.chip_operadora.Name = "chip_operadora";
            this.chip_operadora.Width = 82;
            // 
            // chip_status
            // 
            this.chip_status.HeaderText = "Status";
            this.chip_status.Name = "chip_status";
            this.chip_status.Width = 62;
            // 
            // cmbOperadora
            // 
            this.cmbOperadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperadora.Items.AddRange(new object[] {
            "CLARO",
            "VIVO",
            "TIM(DATORA)"});
            this.cmbOperadora.Location = new System.Drawing.Point(254, 31);
            this.cmbOperadora.Name = "cmbOperadora";
            this.cmbOperadora.Size = new System.Drawing.Size(121, 24);
            this.cmbOperadora.TabIndex = 3;
            // 
            // dtpDataEnvio
            // 
            this.dtpDataEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEnvio.Location = new System.Drawing.Point(254, 78);
            this.dtpDataEnvio.Name = "dtpDataEnvio";
            this.dtpDataEnvio.Size = new System.Drawing.Size(120, 23);
            this.dtpDataEnvio.TabIndex = 4;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "ESTOQUE",
            "CANCELADO",
            "CANCELAR"});
            this.cmbStatus.Location = new System.Drawing.Point(402, 77);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(175, 24);
            this.cmbStatus.TabIndex = 7;
            // 
            // txtCliNome
            // 
            this.txtCliNome.Enabled = false;
            this.txtCliNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCliNome.Location = new System.Drawing.Point(528, 31);
            this.txtCliNome.Name = "txtCliNome";
            this.txtCliNome.Size = new System.Drawing.Size(224, 23);
            this.txtCliNome.TabIndex = 44;
            // 
            // txtImei
            // 
            this.txtImei.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtImei.Location = new System.Drawing.Point(32, 78);
            this.txtImei.Name = "txtImei";
            this.txtImei.Size = new System.Drawing.Size(199, 23);
            this.txtImei.TabIndex = 2;
            // 
            // txtChipId
            // 
            this.txtChipId.Enabled = false;
            this.txtChipId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtChipId.Location = new System.Drawing.Point(32, 31);
            this.txtChipId.Name = "txtChipId";
            this.txtChipId.Size = new System.Drawing.Size(100, 23);
            this.txtChipId.TabIndex = 1;
            // 
            // lblImei
            // 
            this.lblImei.AutoSize = true;
            this.lblImei.Location = new System.Drawing.Point(29, 65);
            this.lblImei.Name = "lblImei";
            this.lblImei.Size = new System.Drawing.Size(26, 13);
            this.lblImei.TabIndex = 41;
            this.lblImei.Text = "Imei";
            // 
            // lblOperadora
            // 
            this.lblOperadora.AutoSize = true;
            this.lblOperadora.Location = new System.Drawing.Point(251, 16);
            this.lblOperadora.Name = "lblOperadora";
            this.lblOperadora.Size = new System.Drawing.Size(57, 13);
            this.lblOperadora.TabIndex = 40;
            this.lblOperadora.Text = "Operadora";
            // 
            // lblDataEnvio
            // 
            this.lblDataEnvio.AutoSize = true;
            this.lblDataEnvio.Location = new System.Drawing.Point(251, 65);
            this.lblDataEnvio.Name = "lblDataEnvio";
            this.lblDataEnvio.Size = new System.Drawing.Size(75, 13);
            this.lblDataEnvio.TabIndex = 39;
            this.lblDataEnvio.Text = "Data de Envio";
            // 
            // lblClienteInstalado
            // 
            this.lblClienteInstalado.AutoSize = true;
            this.lblClienteInstalado.Location = new System.Drawing.Point(399, 14);
            this.lblClienteInstalado.Name = "lblClienteInstalado";
            this.lblClienteInstalado.Size = new System.Drawing.Size(90, 13);
            this.lblClienteInstalado.TabIndex = 38;
            this.lblClienteInstalado.Text = "Código do Cliente";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(399, 64);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 37;
            this.lblStatus.Text = "Status";
            // 
            // lblCodigoChip
            // 
            this.lblCodigoChip.AutoSize = true;
            this.lblCodigoChip.Location = new System.Drawing.Point(29, 16);
            this.lblCodigoChip.Name = "lblCodigoChip";
            this.lblCodigoChip.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoChip.TabIndex = 36;
            this.lblCodigoChip.Text = "Codigo";
            // 
            // frmChips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 582);
            this.Controls.Add(this.panelChips);
            this.Name = "frmChips";
            this.Text = "Gerenciando Chips";
            this.panelChips.ResumeLayout(false);
            this.panelChips.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChips)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Panel panelChips;
        private System.Windows.Forms.ComboBox cmbOperadora;
        private System.Windows.Forms.DateTimePicker dtpDataEnvio;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtCliNome;
        private System.Windows.Forms.TextBox txtImei;
        private System.Windows.Forms.TextBox txtChipId;
        private System.Windows.Forms.Label lblImei;
        private System.Windows.Forms.Label lblOperadora;
        private System.Windows.Forms.Label lblDataEnvio;
        private System.Windows.Forms.Label lblClienteInstalado;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCodigoChip;
        private System.Windows.Forms.DataGridView dataGridChips;
        private System.Windows.Forms.TextBox txtCliId;
        private System.Windows.Forms.DataGridViewTextBoxColumn chip_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn chip_imei;
        private System.Windows.Forms.DataGridViewTextBoxColumn chip_data_envio;
        private System.Windows.Forms.DataGridViewTextBoxColumn chip_operadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn chip_status;
        private System.Windows.Forms.Button btnBuscarChip;
        private System.Windows.Forms.ComboBox cmbBuscarChips;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtBuscarChip;
        private System.Windows.Forms.Button btnBuscarCliente;
    }
}

