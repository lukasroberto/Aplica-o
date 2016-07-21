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
            this.panelButtonsChips = new System.Windows.Forms.Panel();
            this.cmbOperadora = new System.Windows.Forms.ComboBox();
            this.dtpDataEnvio = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dataGridChips = new System.Windows.Forms.DataGridView();
            this.tbChipCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbChipImei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbChipOperadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbChipDataEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbChipCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbChipStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtImei = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblImei = new System.Windows.Forms.Label();
            this.lblOperadora = new System.Windows.Forms.Label();
            this.lblDataEnvio = new System.Windows.Forms.Label();
            this.lblClienteInstalado = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCodigoChip = new System.Windows.Forms.Label();
            this.panelButtonsChips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChips)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(730, 508);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 55);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(12, 508);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(80, 55);
            this.btnNovo.TabIndex = 28;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(102, 508);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(80, 55);
            this.btnAlterar.TabIndex = 29;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Location = new System.Drawing.Point(188, 508);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 55);
            this.btnExcluir.TabIndex = 30;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.Green;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(645, 508);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(79, 55);
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panelButtonsChips
            // 
            this.panelButtonsChips.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtonsChips.Controls.Add(this.cmbOperadora);
            this.panelButtonsChips.Controls.Add(this.dtpDataEnvio);
            this.panelButtonsChips.Controls.Add(this.cmbStatus);
            this.panelButtonsChips.Controls.Add(this.dataGridChips);
            this.panelButtonsChips.Controls.Add(this.txtCliente);
            this.panelButtonsChips.Controls.Add(this.txtImei);
            this.panelButtonsChips.Controls.Add(this.txtCodigo);
            this.panelButtonsChips.Controls.Add(this.lblImei);
            this.panelButtonsChips.Controls.Add(this.lblOperadora);
            this.panelButtonsChips.Controls.Add(this.lblDataEnvio);
            this.panelButtonsChips.Controls.Add(this.lblClienteInstalado);
            this.panelButtonsChips.Controls.Add(this.lblStatus);
            this.panelButtonsChips.Controls.Add(this.lblCodigoChip);
            this.panelButtonsChips.Controls.Add(this.btnNovo);
            this.panelButtonsChips.Controls.Add(this.btnCancelar);
            this.panelButtonsChips.Controls.Add(this.btnAlterar);
            this.panelButtonsChips.Controls.Add(this.btnExcluir);
            this.panelButtonsChips.Controls.Add(this.btnSalvar);
            this.panelButtonsChips.Location = new System.Drawing.Point(0, 1);
            this.panelButtonsChips.Name = "panelButtonsChips";
            this.panelButtonsChips.Size = new System.Drawing.Size(832, 579);
            this.panelButtonsChips.TabIndex = 36;
            // 
            // cmbOperadora
            // 
            this.cmbOperadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperadora.FormattingEnabled = true;
            this.cmbOperadora.Items.AddRange(new object[] {
            "CLARO",
            "VIVO",
            "TIM(DATORA)"});
            this.cmbOperadora.Location = new System.Drawing.Point(389, 42);
            this.cmbOperadora.Name = "cmbOperadora";
            this.cmbOperadora.Size = new System.Drawing.Size(121, 24);
            this.cmbOperadora.TabIndex = 48;
            // 
            // dtpDataEnvio
            // 
            this.dtpDataEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEnvio.Location = new System.Drawing.Point(390, 82);
            this.dtpDataEnvio.Name = "dtpDataEnvio";
            this.dtpDataEnvio.Size = new System.Drawing.Size(120, 23);
            this.dtpDataEnvio.TabIndex = 47;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "ESTOQUE",
            "10",
            "CANCELAR"});
            this.cmbStatus.Location = new System.Drawing.Point(645, 77);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(175, 24);
            this.cmbStatus.TabIndex = 46;
            // 
            // dataGridChips
            // 
            this.dataGridChips.AllowUserToAddRows = false;
            this.dataGridChips.AllowUserToDeleteRows = false;
            this.dataGridChips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridChips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbChipCodigo,
            this.tbChipImei,
            this.tbChipOperadora,
            this.tbChipDataEnvio,
            this.tbChipCliente,
            this.tbChipStatus});
            this.dataGridChips.Location = new System.Drawing.Point(12, 132);
            this.dataGridChips.Name = "dataGridChips";
            this.dataGridChips.Size = new System.Drawing.Size(808, 347);
            this.dataGridChips.TabIndex = 45;
            // 
            // tbChipCodigo
            // 
            this.tbChipCodigo.HeaderText = "Código";
            this.tbChipCodigo.Name = "tbChipCodigo";
            this.tbChipCodigo.Width = 50;
            // 
            // tbChipImei
            // 
            this.tbChipImei.HeaderText = "Imei";
            this.tbChipImei.Name = "tbChipImei";
            this.tbChipImei.Width = 200;
            // 
            // tbChipOperadora
            // 
            this.tbChipOperadora.HeaderText = "Operadora";
            this.tbChipOperadora.Name = "tbChipOperadora";
            // 
            // tbChipDataEnvio
            // 
            this.tbChipDataEnvio.HeaderText = "Data de Envio";
            this.tbChipDataEnvio.Name = "tbChipDataEnvio";
            // 
            // tbChipCliente
            // 
            this.tbChipCliente.HeaderText = "Cliente Instalado";
            this.tbChipCliente.Name = "tbChipCliente";
            this.tbChipCliente.Width = 150;
            // 
            // tbChipStatus
            // 
            this.tbChipStatus.HeaderText = "Status";
            this.tbChipStatus.Name = "tbChipStatus";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCliente.Location = new System.Drawing.Point(645, 37);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(175, 23);
            this.txtCliente.TabIndex = 44;
            // 
            // txtImei
            // 
            this.txtImei.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtImei.Location = new System.Drawing.Point(58, 74);
            this.txtImei.Name = "txtImei";
            this.txtImei.Size = new System.Drawing.Size(210, 23);
            this.txtImei.TabIndex = 43;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCodigo.Location = new System.Drawing.Point(58, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 42;
            // 
            // lblImei
            // 
            this.lblImei.AutoSize = true;
            this.lblImei.Location = new System.Drawing.Point(26, 82);
            this.lblImei.Name = "lblImei";
            this.lblImei.Size = new System.Drawing.Size(26, 13);
            this.lblImei.TabIndex = 41;
            this.lblImei.Text = "Imei";
            // 
            // lblOperadora
            // 
            this.lblOperadora.AutoSize = true;
            this.lblOperadora.Location = new System.Drawing.Point(326, 45);
            this.lblOperadora.Name = "lblOperadora";
            this.lblOperadora.Size = new System.Drawing.Size(57, 13);
            this.lblOperadora.TabIndex = 40;
            this.lblOperadora.Text = "Operadora";
            // 
            // lblDataEnvio
            // 
            this.lblDataEnvio.AutoSize = true;
            this.lblDataEnvio.Location = new System.Drawing.Point(308, 82);
            this.lblDataEnvio.Name = "lblDataEnvio";
            this.lblDataEnvio.Size = new System.Drawing.Size(75, 13);
            this.lblDataEnvio.TabIndex = 39;
            this.lblDataEnvio.Text = "Data de Envio";
            // 
            // lblClienteInstalado
            // 
            this.lblClienteInstalado.AutoSize = true;
            this.lblClienteInstalado.Location = new System.Drawing.Point(554, 45);
            this.lblClienteInstalado.Name = "lblClienteInstalado";
            this.lblClienteInstalado.Size = new System.Drawing.Size(85, 13);
            this.lblClienteInstalado.TabIndex = 38;
            this.lblClienteInstalado.Text = "Cliente Instalado";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(602, 77);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 37;
            this.lblStatus.Text = "Status";
            // 
            // lblCodigoChip
            // 
            this.lblCodigoChip.AutoSize = true;
            this.lblCodigoChip.Location = new System.Drawing.Point(15, 45);
            this.lblCodigoChip.Name = "lblCodigoChip";
            this.lblCodigoChip.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoChip.TabIndex = 36;
            this.lblCodigoChip.Text = "Codigo";
            // 
            // frmChips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 582);
            this.Controls.Add(this.panelButtonsChips);
            this.Name = "frmChips";
            this.Text = "Gerenciando Chips";
            this.panelButtonsChips.ResumeLayout(false);
            this.panelButtonsChips.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChips)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Panel panelButtonsChips;
        private System.Windows.Forms.ComboBox cmbOperadora;
        private System.Windows.Forms.DateTimePicker dtpDataEnvio;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridView dataGridChips;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbChipCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbChipImei;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbChipOperadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbChipDataEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbChipCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbChipStatus;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtImei;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblImei;
        private System.Windows.Forms.Label lblOperadora;
        private System.Windows.Forms.Label lblDataEnvio;
        private System.Windows.Forms.Label lblClienteInstalado;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCodigoChip;
    }
}

