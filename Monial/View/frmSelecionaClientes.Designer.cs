namespace Monial
{
    partial class frmSelecionarClientes
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
            this.panelChips = new System.Windows.Forms.Panel();
            this.btnBuscarClientes = new System.Windows.Forms.Button();
            this.cmbBuscarClientes = new System.Windows.Forms.ComboBox();
            this.lblbuscarClientes = new System.Windows.Forms.Label();
            this.txtBuscarClientes = new System.Windows.Forms.TextBox();
            this.dataGridSelecionarClientes = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSelecionarCliente = new System.Windows.Forms.Button();
            this.cli_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelChips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelecionarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChips
            // 
            this.panelChips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChips.Controls.Add(this.btnBuscarClientes);
            this.panelChips.Controls.Add(this.cmbBuscarClientes);
            this.panelChips.Controls.Add(this.lblbuscarClientes);
            this.panelChips.Controls.Add(this.txtBuscarClientes);
            this.panelChips.Controls.Add(this.dataGridSelecionarClientes);
            this.panelChips.Controls.Add(this.btnCancelar);
            this.panelChips.Controls.Add(this.btnSelecionarCliente);
            this.panelChips.Location = new System.Drawing.Point(0, 0);
            this.panelChips.Name = "panelChips";
            this.panelChips.Size = new System.Drawing.Size(1145, 608);
            this.panelChips.TabIndex = 37;
            // 
            // btnBuscarClientes
            // 
            this.btnBuscarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarClientes.Location = new System.Drawing.Point(336, 44);
            this.btnBuscarClientes.Name = "btnBuscarClientes";
            this.btnBuscarClientes.Size = new System.Drawing.Size(66, 24);
            this.btnBuscarClientes.TabIndex = 10;
            this.btnBuscarClientes.Text = "Buscar";
            this.btnBuscarClientes.UseVisualStyleBackColor = true;
            // 
            // cmbBuscarClientes
            // 
            this.cmbBuscarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBuscarClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscarClientes.FormattingEnabled = true;
            this.cmbBuscarClientes.Items.AddRange(new object[] {
            "Imei",
            "Operadora",
            "Nome do Cliente",
            "Código do Cliente"});
            this.cmbBuscarClientes.Location = new System.Drawing.Point(155, 44);
            this.cmbBuscarClientes.Name = "cmbBuscarClientes";
            this.cmbBuscarClientes.Size = new System.Drawing.Size(175, 24);
            this.cmbBuscarClientes.TabIndex = 9;
            // 
            // lblbuscarClientes
            // 
            this.lblbuscarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblbuscarClientes.AutoSize = true;
            this.lblbuscarClientes.Location = new System.Drawing.Point(15, 28);
            this.lblbuscarClientes.Name = "lblbuscarClientes";
            this.lblbuscarClientes.Size = new System.Drawing.Size(75, 13);
            this.lblbuscarClientes.TabIndex = 52;
            this.lblbuscarClientes.Text = "Buscar Cliente";
            // 
            // txtBuscarClientes
            // 
            this.txtBuscarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBuscarClientes.Location = new System.Drawing.Point(18, 44);
            this.txtBuscarClientes.Name = "txtBuscarClientes";
            this.txtBuscarClientes.Size = new System.Drawing.Size(131, 23);
            this.txtBuscarClientes.TabIndex = 8;
            // 
            // dataGridSelecionarClientes
            // 
            this.dataGridSelecionarClientes.AllowDrop = true;
            this.dataGridSelecionarClientes.AllowUserToAddRows = false;
            this.dataGridSelecionarClientes.AllowUserToDeleteRows = false;
            this.dataGridSelecionarClientes.AllowUserToOrderColumns = true;
            this.dataGridSelecionarClientes.AllowUserToResizeRows = false;
            this.dataGridSelecionarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSelecionarClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridSelecionarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSelecionarClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cli_id,
            this.cli_nome,
            this.cli_rua,
            this.cli_cidade,
            this.cli_empresa});
            this.dataGridSelecionarClientes.Location = new System.Drawing.Point(18, 74);
            this.dataGridSelecionarClientes.MultiSelect = false;
            this.dataGridSelecionarClientes.Name = "dataGridSelecionarClientes";
            this.dataGridSelecionarClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSelecionarClientes.Size = new System.Drawing.Size(1109, 457);
            this.dataGridSelecionarClientes.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1037, 537);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 55);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSelecionarCliente
            // 
            this.btnSelecionarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarCliente.BackColor = System.Drawing.Color.Green;
            this.btnSelecionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelecionarCliente.Location = new System.Drawing.Point(952, 537);
            this.btnSelecionarCliente.Name = "btnSelecionarCliente";
            this.btnSelecionarCliente.Size = new System.Drawing.Size(79, 55);
            this.btnSelecionarCliente.TabIndex = 15;
            this.btnSelecionarCliente.Text = "OK";
            this.btnSelecionarCliente.UseVisualStyleBackColor = false;
            this.btnSelecionarCliente.Click += new System.EventHandler(this.btnSelecionarCliente_Click);
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
            // cli_rua
            // 
            this.cli_rua.HeaderText = "Endereço";
            this.cli_rua.Name = "cli_rua";
            this.cli_rua.Width = 78;
            // 
            // cli_cidade
            // 
            this.cli_cidade.HeaderText = "Cidade";
            this.cli_cidade.Name = "cli_cidade";
            this.cli_cidade.Width = 65;
            // 
            // cli_empresa
            // 
            this.cli_empresa.HeaderText = "Empresa";
            this.cli_empresa.Name = "cli_empresa";
            this.cli_empresa.Width = 73;
            // 
            // frmSelecionarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 609);
            this.Controls.Add(this.panelChips);
            this.Name = "frmSelecionarClientes";
            this.Text = "Selecionar Clientes";
            this.panelChips.ResumeLayout(false);
            this.panelChips.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelecionarClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelChips;
        private System.Windows.Forms.Button btnBuscarClientes;
        private System.Windows.Forms.ComboBox cmbBuscarClientes;
        private System.Windows.Forms.Label lblbuscarClientes;
        private System.Windows.Forms.TextBox txtBuscarClientes;
        private System.Windows.Forms.DataGridView dataGridSelecionarClientes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSelecionarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_empresa;
    }
}

