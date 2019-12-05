namespace Apresentacao.ContratoAluguel
{
    partial class frmAlterarContratoAluguel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarContratoAluguel));
            this.panelInside = new System.Windows.Forms.Panel();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.gpbArmazem = new System.Windows.Forms.GroupBox();
            this.dgvLocalidadesEstoque = new System.Windows.Forms.DataGridView();
            this.EstoqueLocalidadeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueLocalidadeDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueLocalidadeEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoverArmazem = new System.Windows.Forms.Button();
            this.btnConsultarArmazem = new System.Windows.Forms.Button();
            this.btnCadastrarArmazem = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gpbPessoa = new System.Windows.Forms.GroupBox();
            this.lblNomeFicticio = new System.Windows.Forms.Label();
            this.txtNomeFicticio = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblContratoAluguelID = new System.Windows.Forms.Label();
            this.txtPessoaID = new System.Windows.Forms.TextBox();
            this.btnBuscarPessoa = new System.Windows.Forms.Button();
            this.gpbPastos = new System.Windows.Forms.GroupBox();
            this.dgvPastos = new System.Windows.Forms.DataGridView();
            this.PastoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastoDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastoTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CidadeNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoverPasto = new System.Windows.Forms.Button();
            this.btnConsultarPasto = new System.Windows.Forms.Button();
            this.btnCadastrarPasto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelInside.SuspendLayout();
            this.gpbDados.SuspendLayout();
            this.gpbArmazem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidadesEstoque)).BeginInit();
            this.gpbPessoa.SuspendLayout();
            this.gpbPastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbDados);
            this.panelInside.Controls.Add(this.gpbArmazem);
            this.panelInside.Controls.Add(this.btnAlterar);
            this.panelInside.Controls.Add(this.gpbPessoa);
            this.panelInside.Controls.Add(this.gpbPastos);
            this.panelInside.Location = new System.Drawing.Point(12, 67);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(1073, 504);
            this.panelInside.TabIndex = 32;
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.lblDataFinal);
            this.gpbDados.Controls.Add(this.dtpFinal);
            this.gpbDados.Controls.Add(this.dtpInicial);
            this.gpbDados.Controls.Add(this.txtValor);
            this.gpbDados.Controls.Add(this.lblValor);
            this.gpbDados.Controls.Add(this.lblDataInicio);
            this.gpbDados.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDados.Location = new System.Drawing.Point(12, 15);
            this.gpbDados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbDados.Size = new System.Drawing.Size(521, 122);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Location = new System.Drawing.Point(242, 36);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(67, 16);
            this.lblDataFinal.TabIndex = 6;
            this.lblDataFinal.Text = "Data final:";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(245, 56);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(200, 23);
            this.dtpFinal.TabIndex = 1;
            this.dtpFinal.ValueChanged += new System.EventHandler(this.dtpFinal_ValueChanged);
            // 
            // dtpInicial
            // 
            this.dtpInicial.Location = new System.Drawing.Point(39, 56);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(200, 23);
            this.dtpInicial.TabIndex = 0;
            this.dtpInicial.ValueChanged += new System.EventHandler(this.dtpInicial_ValueChanged);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtValor.Location = new System.Drawing.Point(158, 86);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValor.MaxLength = 19;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(202, 23);
            this.txtValor.TabIndex = 2;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(110, 89);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(42, 16);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor:";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(36, 36);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(75, 16);
            this.lblDataInicio.TabIndex = 0;
            this.lblDataInicio.Text = "Data inicial:";
            // 
            // gpbArmazem
            // 
            this.gpbArmazem.Controls.Add(this.dgvLocalidadesEstoque);
            this.gpbArmazem.Controls.Add(this.btnRemoverArmazem);
            this.gpbArmazem.Controls.Add(this.btnConsultarArmazem);
            this.gpbArmazem.Controls.Add(this.btnCadastrarArmazem);
            this.gpbArmazem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbArmazem.Location = new System.Drawing.Point(27, 144);
            this.gpbArmazem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbArmazem.Name = "gpbArmazem";
            this.gpbArmazem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbArmazem.Size = new System.Drawing.Size(521, 275);
            this.gpbArmazem.TabIndex = 2;
            this.gpbArmazem.TabStop = false;
            this.gpbArmazem.Text = "Estoques";
            // 
            // dgvLocalidadesEstoque
            // 
            this.dgvLocalidadesEstoque.AllowUserToAddRows = false;
            this.dgvLocalidadesEstoque.AllowUserToDeleteRows = false;
            this.dgvLocalidadesEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalidadesEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstoqueLocalidadeID,
            this.EstoqueLocalidadeDescricao,
            this.EstoqueLocalidadeEndereco,
            this.dataGridViewTextBoxColumn1});
            this.dgvLocalidadesEstoque.Location = new System.Drawing.Point(6, 73);
            this.dgvLocalidadesEstoque.Name = "dgvLocalidadesEstoque";
            this.dgvLocalidadesEstoque.ReadOnly = true;
            this.dgvLocalidadesEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalidadesEstoque.Size = new System.Drawing.Size(509, 150);
            this.dgvLocalidadesEstoque.TabIndex = 2;
            // 
            // EstoqueLocalidadeID
            // 
            this.EstoqueLocalidadeID.DataPropertyName = "EstoqueLocalidadeID";
            this.EstoqueLocalidadeID.HeaderText = "ID";
            this.EstoqueLocalidadeID.Name = "EstoqueLocalidadeID";
            this.EstoqueLocalidadeID.ReadOnly = true;
            // 
            // EstoqueLocalidadeDescricao
            // 
            this.EstoqueLocalidadeDescricao.DataPropertyName = "EstoqueLocalidadeDescricao";
            this.EstoqueLocalidadeDescricao.HeaderText = "Descrição";
            this.EstoqueLocalidadeDescricao.Name = "EstoqueLocalidadeDescricao";
            this.EstoqueLocalidadeDescricao.ReadOnly = true;
            this.EstoqueLocalidadeDescricao.Width = 200;
            // 
            // EstoqueLocalidadeEndereco
            // 
            this.EstoqueLocalidadeEndereco.DataPropertyName = "EstoqueLocalidadeEndereco";
            this.EstoqueLocalidadeEndereco.HeaderText = "Endereço";
            this.EstoqueLocalidadeEndereco.Name = "EstoqueLocalidadeEndereco";
            this.EstoqueLocalidadeEndereco.ReadOnly = true;
            this.EstoqueLocalidadeEndereco.Width = 180;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cidade.CidadeNome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 160;
            // 
            // btnRemoverArmazem
            // 
            this.btnRemoverArmazem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnRemoverArmazem.FlatAppearance.BorderSize = 0;
            this.btnRemoverArmazem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverArmazem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoverArmazem.ForeColor = System.Drawing.Color.White;
            this.btnRemoverArmazem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverArmazem.Location = new System.Drawing.Point(383, 230);
            this.btnRemoverArmazem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoverArmazem.Name = "btnRemoverArmazem";
            this.btnRemoverArmazem.Size = new System.Drawing.Size(132, 37);
            this.btnRemoverArmazem.TabIndex = 3;
            this.btnRemoverArmazem.Text = "Remover";
            this.btnRemoverArmazem.UseVisualStyleBackColor = false;
            this.btnRemoverArmazem.Click += new System.EventHandler(this.btnRemoverArmazem_Click);
            // 
            // btnConsultarArmazem
            // 
            this.btnConsultarArmazem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnConsultarArmazem.FlatAppearance.BorderSize = 0;
            this.btnConsultarArmazem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarArmazem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultarArmazem.ForeColor = System.Drawing.Color.White;
            this.btnConsultarArmazem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarArmazem.Location = new System.Drawing.Point(315, 24);
            this.btnConsultarArmazem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultarArmazem.Name = "btnConsultarArmazem";
            this.btnConsultarArmazem.Size = new System.Drawing.Size(185, 42);
            this.btnConsultarArmazem.TabIndex = 1;
            this.btnConsultarArmazem.Text = "Buscar Armazem";
            this.btnConsultarArmazem.UseVisualStyleBackColor = false;
            this.btnConsultarArmazem.Click += new System.EventHandler(this.btnConsultarArmazem_Click);
            // 
            // btnCadastrarArmazem
            // 
            this.btnCadastrarArmazem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnCadastrarArmazem.FlatAppearance.BorderSize = 0;
            this.btnCadastrarArmazem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarArmazem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarArmazem.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarArmazem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarArmazem.Location = new System.Drawing.Point(22, 24);
            this.btnCadastrarArmazem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrarArmazem.Name = "btnCadastrarArmazem";
            this.btnCadastrarArmazem.Size = new System.Drawing.Size(185, 42);
            this.btnCadastrarArmazem.TabIndex = 0;
            this.btnCadastrarArmazem.Text = "Cadastrar Armazem";
            this.btnCadastrarArmazem.UseVisualStyleBackColor = false;
            this.btnCadastrarArmazem.Click += new System.EventHandler(this.btnCadastrarArmazem_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(789, 426);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(239, 68);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Salvar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // gpbPessoa
            // 
            this.gpbPessoa.Controls.Add(this.lblNomeFicticio);
            this.gpbPessoa.Controls.Add(this.txtNomeFicticio);
            this.gpbPessoa.Controls.Add(this.lblNome);
            this.gpbPessoa.Controls.Add(this.txtNome);
            this.gpbPessoa.Controls.Add(this.lblContratoAluguelID);
            this.gpbPessoa.Controls.Add(this.txtPessoaID);
            this.gpbPessoa.Controls.Add(this.btnBuscarPessoa);
            this.gpbPessoa.Enabled = false;
            this.gpbPessoa.Location = new System.Drawing.Point(539, 15);
            this.gpbPessoa.Name = "gpbPessoa";
            this.gpbPessoa.Size = new System.Drawing.Size(521, 122);
            this.gpbPessoa.TabIndex = 1;
            this.gpbPessoa.TabStop = false;
            this.gpbPessoa.Text = "Pessoa";
            // 
            // lblNomeFicticio
            // 
            this.lblNomeFicticio.AutoSize = true;
            this.lblNomeFicticio.Location = new System.Drawing.Point(10, 88);
            this.lblNomeFicticio.Name = "lblNomeFicticio";
            this.lblNomeFicticio.Size = new System.Drawing.Size(88, 16);
            this.lblNomeFicticio.TabIndex = 20;
            this.lblNomeFicticio.Text = "Nome fictício:";
            // 
            // txtNomeFicticio
            // 
            this.txtNomeFicticio.Enabled = false;
            this.txtNomeFicticio.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtNomeFicticio.Location = new System.Drawing.Point(104, 85);
            this.txtNomeFicticio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeFicticio.Name = "txtNomeFicticio";
            this.txtNomeFicticio.Size = new System.Drawing.Size(205, 23);
            this.txtNomeFicticio.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(51, 57);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtNome.Location = new System.Drawing.Point(104, 54);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(205, 23);
            this.txtNome.TabIndex = 1;
            // 
            // lblContratoAluguelID
            // 
            this.lblContratoAluguelID.AutoSize = true;
            this.lblContratoAluguelID.Location = new System.Drawing.Point(120, 26);
            this.lblContratoAluguelID.Name = "lblContratoAluguelID";
            this.lblContratoAluguelID.Size = new System.Drawing.Size(24, 16);
            this.lblContratoAluguelID.TabIndex = 16;
            this.lblContratoAluguelID.Text = "ID:";
            // 
            // txtPessoaID
            // 
            this.txtPessoaID.Enabled = false;
            this.txtPessoaID.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtPessoaID.Location = new System.Drawing.Point(150, 23);
            this.txtPessoaID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPessoaID.Name = "txtPessoaID";
            this.txtPessoaID.Size = new System.Drawing.Size(110, 23);
            this.txtPessoaID.TabIndex = 0;
            // 
            // btnBuscarPessoa
            // 
            this.btnBuscarPessoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarPessoa.FlatAppearance.BorderSize = 0;
            this.btnBuscarPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPessoa.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPessoa.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPessoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPessoa.Location = new System.Drawing.Point(330, 44);
            this.btnBuscarPessoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarPessoa.Name = "btnBuscarPessoa";
            this.btnBuscarPessoa.Size = new System.Drawing.Size(185, 42);
            this.btnBuscarPessoa.TabIndex = 3;
            this.btnBuscarPessoa.Text = "Buscar Pessoa";
            this.btnBuscarPessoa.UseVisualStyleBackColor = false;
            this.btnBuscarPessoa.Click += new System.EventHandler(this.btnBuscarPessoa_Click);
            // 
            // gpbPastos
            // 
            this.gpbPastos.Controls.Add(this.dgvPastos);
            this.gpbPastos.Controls.Add(this.btnRemoverPasto);
            this.gpbPastos.Controls.Add(this.btnConsultarPasto);
            this.gpbPastos.Controls.Add(this.btnCadastrarPasto);
            this.gpbPastos.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPastos.Location = new System.Drawing.Point(554, 143);
            this.gpbPastos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbPastos.Name = "gpbPastos";
            this.gpbPastos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbPastos.Size = new System.Drawing.Size(474, 275);
            this.gpbPastos.TabIndex = 3;
            this.gpbPastos.TabStop = false;
            this.gpbPastos.Text = "Pastos";
            // 
            // dgvPastos
            // 
            this.dgvPastos.AllowUserToAddRows = false;
            this.dgvPastos.AllowUserToDeleteRows = false;
            this.dgvPastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PastoID,
            this.PastoDescricao,
            this.PastoTamanho,
            this.CidadeNome});
            this.dgvPastos.Location = new System.Drawing.Point(6, 73);
            this.dgvPastos.Name = "dgvPastos";
            this.dgvPastos.ReadOnly = true;
            this.dgvPastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPastos.Size = new System.Drawing.Size(462, 150);
            this.dgvPastos.TabIndex = 2;
            // 
            // PastoID
            // 
            this.PastoID.DataPropertyName = "PastoID";
            this.PastoID.HeaderText = "ID";
            this.PastoID.Name = "PastoID";
            this.PastoID.ReadOnly = true;
            this.PastoID.Width = 80;
            // 
            // PastoDescricao
            // 
            this.PastoDescricao.DataPropertyName = "PastoDescricao";
            this.PastoDescricao.HeaderText = "Descrição";
            this.PastoDescricao.Name = "PastoDescricao";
            this.PastoDescricao.ReadOnly = true;
            this.PastoDescricao.Width = 200;
            // 
            // PastoTamanho
            // 
            this.PastoTamanho.DataPropertyName = "PastoTamanho";
            this.PastoTamanho.HeaderText = "Tamanho";
            this.PastoTamanho.Name = "PastoTamanho";
            this.PastoTamanho.ReadOnly = true;
            // 
            // CidadeNome
            // 
            this.CidadeNome.DataPropertyName = "Cidade.CidadeNome";
            this.CidadeNome.HeaderText = "Cidade";
            this.CidadeNome.Name = "CidadeNome";
            this.CidadeNome.ReadOnly = true;
            this.CidadeNome.Width = 150;
            // 
            // btnRemoverPasto
            // 
            this.btnRemoverPasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnRemoverPasto.FlatAppearance.BorderSize = 0;
            this.btnRemoverPasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverPasto.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoverPasto.ForeColor = System.Drawing.Color.White;
            this.btnRemoverPasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverPasto.Location = new System.Drawing.Point(336, 230);
            this.btnRemoverPasto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoverPasto.Name = "btnRemoverPasto";
            this.btnRemoverPasto.Size = new System.Drawing.Size(132, 37);
            this.btnRemoverPasto.TabIndex = 3;
            this.btnRemoverPasto.Text = "Remover";
            this.btnRemoverPasto.UseVisualStyleBackColor = false;
            this.btnRemoverPasto.Click += new System.EventHandler(this.btnRemoverPasto_Click);
            // 
            // btnConsultarPasto
            // 
            this.btnConsultarPasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnConsultarPasto.FlatAppearance.BorderSize = 0;
            this.btnConsultarPasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarPasto.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultarPasto.ForeColor = System.Drawing.Color.White;
            this.btnConsultarPasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarPasto.Location = new System.Drawing.Point(273, 24);
            this.btnConsultarPasto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultarPasto.Name = "btnConsultarPasto";
            this.btnConsultarPasto.Size = new System.Drawing.Size(185, 42);
            this.btnConsultarPasto.TabIndex = 1;
            this.btnConsultarPasto.Text = "Buscar Pasto";
            this.btnConsultarPasto.UseVisualStyleBackColor = false;
            this.btnConsultarPasto.Click += new System.EventHandler(this.btnConsultarPasto_Click);
            // 
            // btnCadastrarPasto
            // 
            this.btnCadastrarPasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnCadastrarPasto.FlatAppearance.BorderSize = 0;
            this.btnCadastrarPasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarPasto.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarPasto.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarPasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarPasto.Location = new System.Drawing.Point(16, 24);
            this.btnCadastrarPasto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrarPasto.Name = "btnCadastrarPasto";
            this.btnCadastrarPasto.Size = new System.Drawing.Size(185, 42);
            this.btnCadastrarPasto.TabIndex = 0;
            this.btnCadastrarPasto.Text = "Cadastrar Pasto";
            this.btnCadastrarPasto.UseVisualStyleBackColor = false;
            this.btnCadastrarPasto.Click += new System.EventHandler(this.btnCadastrarPasto_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.picExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1099, 45);
            this.panel2.TabIndex = 30;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(318, 24);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Alteração de Contrato de Aluguel";
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(1056, 4);
            this.picExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(40, 38);
            this.picExit.TabIndex = 4;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.PicExit_Click);
            this.picExit.MouseEnter += new System.EventHandler(this.PicExit_MouseEnter);
            this.picExit.MouseLeave += new System.EventHandler(this.PicExit_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(88)))), ((int)(((byte)(46)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1099, 15);
            this.panel4.TabIndex = 31;
            // 
            // frmAlterarContratoAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1099, 581);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAlterarContratoAluguel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlterarContratoAluguel";
            this.Load += new System.EventHandler(this.frmAlterarContratoAluguel_Load);
            this.panelInside.ResumeLayout(false);
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.gpbArmazem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidadesEstoque)).EndInit();
            this.gpbPessoa.ResumeLayout(false);
            this.gpbPessoa.PerformLayout();
            this.gpbPastos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.GroupBox gpbArmazem;
        private System.Windows.Forms.DataGridView dgvLocalidadesEstoque;
        private System.Windows.Forms.Button btnRemoverArmazem;
        private System.Windows.Forms.Button btnConsultarArmazem;
        private System.Windows.Forms.Button btnCadastrarArmazem;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox gpbPessoa;
        private System.Windows.Forms.Label lblNomeFicticio;
        private System.Windows.Forms.TextBox txtNomeFicticio;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblContratoAluguelID;
        private System.Windows.Forms.TextBox txtPessoaID;
        private System.Windows.Forms.Button btnBuscarPessoa;
        private System.Windows.Forms.GroupBox gpbPastos;
        private System.Windows.Forms.DataGridView dgvPastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastoDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastoTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidadeNome;
        private System.Windows.Forms.Button btnRemoverPasto;
        private System.Windows.Forms.Button btnConsultarPasto;
        private System.Windows.Forms.Button btnCadastrarPasto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueLocalidadeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueLocalidadeDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueLocalidadeEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblTitulo;
    }
}