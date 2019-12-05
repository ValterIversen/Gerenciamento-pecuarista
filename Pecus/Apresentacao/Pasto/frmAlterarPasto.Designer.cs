namespace Apresentacao.Pasto
{
    partial class frmAlterarPasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarPasto));
            this.txtPiqueteDescricao = new System.Windows.Forms.TextBox();
            this.lblPiqueteDescricao = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.gpbPiquete = new System.Windows.Forms.GroupBox();
            this.btnCancelarPiqueteRemover = new System.Windows.Forms.Button();
            this.lblPiqueteRemover = new System.Windows.Forms.Label();
            this.dgvPiqueteRemover = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPiquetes = new System.Windows.Forms.DataGridView();
            this.PiqueteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PiqueteAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PiqueteQuantidadeAnimais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.ckContrato = new System.Windows.Forms.CheckBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbbCidade = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblContratoAluguelID = new System.Windows.Forms.Label();
            this.txtContratoAluguelID = new System.Windows.Forms.TextBox();
            this.gpbContratoAluguel = new System.Windows.Forms.GroupBox();
            this.btnCadastrarContrato = new System.Windows.Forms.Button();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.lblHectare = new System.Windows.Forms.Label();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelInside = new System.Windows.Forms.Panel();
            this.gpbPiquete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiqueteRemover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiquetes)).BeginInit();
            this.gpbContratoAluguel.SuspendLayout();
            this.gpbDados.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panelInside.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPiqueteDescricao
            // 
            this.txtPiqueteDescricao.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtPiqueteDescricao.Location = new System.Drawing.Point(136, 29);
            this.txtPiqueteDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPiqueteDescricao.MaxLength = 30;
            this.txtPiqueteDescricao.Name = "txtPiqueteDescricao";
            this.txtPiqueteDescricao.Size = new System.Drawing.Size(184, 23);
            this.txtPiqueteDescricao.TabIndex = 0;
            // 
            // lblPiqueteDescricao
            // 
            this.lblPiqueteDescricao.AutoSize = true;
            this.lblPiqueteDescricao.Location = new System.Drawing.Point(42, 32);
            this.lblPiqueteDescricao.Name = "lblPiqueteDescricao";
            this.lblPiqueteDescricao.Size = new System.Drawing.Size(68, 16);
            this.lblPiqueteDescricao.TabIndex = 19;
            this.lblPiqueteDescricao.Text = "Descrição:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(127, 312);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(132, 37);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(320, 312);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(132, 37);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // gpbPiquete
            // 
            this.gpbPiquete.Controls.Add(this.btnCancelarPiqueteRemover);
            this.gpbPiquete.Controls.Add(this.lblPiqueteRemover);
            this.gpbPiquete.Controls.Add(this.dgvPiqueteRemover);
            this.gpbPiquete.Controls.Add(this.txtPiqueteDescricao);
            this.gpbPiquete.Controls.Add(this.lblPiqueteDescricao);
            this.gpbPiquete.Controls.Add(this.btnAdicionar);
            this.gpbPiquete.Controls.Add(this.btnRemover);
            this.gpbPiquete.Controls.Add(this.dgvPiquetes);
            this.gpbPiquete.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPiquete.Location = new System.Drawing.Point(540, 20);
            this.gpbPiquete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbPiquete.Name = "gpbPiquete";
            this.gpbPiquete.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbPiquete.Size = new System.Drawing.Size(569, 568);
            this.gpbPiquete.TabIndex = 2;
            this.gpbPiquete.TabStop = false;
            this.gpbPiquete.Text = "Piquetes";
            // 
            // btnCancelarPiqueteRemover
            // 
            this.btnCancelarPiqueteRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnCancelarPiqueteRemover.FlatAppearance.BorderSize = 0;
            this.btnCancelarPiqueteRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPiqueteRemover.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelarPiqueteRemover.ForeColor = System.Drawing.Color.White;
            this.btnCancelarPiqueteRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarPiqueteRemover.Location = new System.Drawing.Point(226, 523);
            this.btnCancelarPiqueteRemover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelarPiqueteRemover.Name = "btnCancelarPiqueteRemover";
            this.btnCancelarPiqueteRemover.Size = new System.Drawing.Size(132, 37);
            this.btnCancelarPiqueteRemover.TabIndex = 5;
            this.btnCancelarPiqueteRemover.Text = "Cancelar exclusão";
            this.btnCancelarPiqueteRemover.UseVisualStyleBackColor = false;
            this.btnCancelarPiqueteRemover.Click += new System.EventHandler(this.BtnCancelarPiqueteRemover_Click);
            // 
            // lblPiqueteRemover
            // 
            this.lblPiqueteRemover.AutoSize = true;
            this.lblPiqueteRemover.Location = new System.Drawing.Point(6, 359);
            this.lblPiqueteRemover.Name = "lblPiqueteRemover";
            this.lblPiqueteRemover.Size = new System.Drawing.Size(167, 16);
            this.lblPiqueteRemover.TabIndex = 17;
            this.lblPiqueteRemover.Text = "Piquetes a serem excluídos";
            // 
            // dgvPiqueteRemover
            // 
            this.dgvPiqueteRemover.AllowUserToAddRows = false;
            this.dgvPiqueteRemover.AllowUserToDeleteRows = false;
            this.dgvPiqueteRemover.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPiqueteRemover.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.dgvPiqueteRemover.Location = new System.Drawing.Point(6, 378);
            this.dgvPiqueteRemover.Name = "dgvPiqueteRemover";
            this.dgvPiqueteRemover.ReadOnly = true;
            this.dgvPiqueteRemover.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPiqueteRemover.Size = new System.Drawing.Size(554, 138);
            this.dgvPiqueteRemover.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PiqueteID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PiqueteDescricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 280;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "PiqueteAtivo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Ativo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PiqueteQuantidadeAnimais";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dgvPiquetes
            // 
            this.dgvPiquetes.AllowUserToAddRows = false;
            this.dgvPiquetes.AllowUserToDeleteRows = false;
            this.dgvPiquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPiquetes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PiqueteID,
            this.Descricao,
            this.PiqueteAtivo,
            this.PiqueteQuantidadeAnimais});
            this.dgvPiquetes.Location = new System.Drawing.Point(6, 59);
            this.dgvPiquetes.Name = "dgvPiquetes";
            this.dgvPiquetes.ReadOnly = true;
            this.dgvPiquetes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPiquetes.Size = new System.Drawing.Size(554, 246);
            this.dgvPiquetes.TabIndex = 1;
            this.dgvPiquetes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPiquetes_CellDoubleClick);
            // 
            // PiqueteID
            // 
            this.PiqueteID.DataPropertyName = "PiqueteID";
            this.PiqueteID.HeaderText = "ID";
            this.PiqueteID.Name = "PiqueteID";
            this.PiqueteID.ReadOnly = true;
            this.PiqueteID.Width = 70;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "PiqueteDescricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 280;
            // 
            // PiqueteAtivo
            // 
            this.PiqueteAtivo.DataPropertyName = "PiqueteAtivo";
            this.PiqueteAtivo.HeaderText = "Ativo";
            this.PiqueteAtivo.Name = "PiqueteAtivo";
            this.PiqueteAtivo.ReadOnly = true;
            this.PiqueteAtivo.Width = 60;
            // 
            // PiqueteQuantidadeAnimais
            // 
            this.PiqueteQuantidadeAnimais.DataPropertyName = "PiqueteQuantidadeAnimais";
            this.PiqueteQuantidadeAnimais.HeaderText = "Quantidade";
            this.PiqueteQuantidadeAnimais.Name = "PiqueteQuantidadeAnimais";
            this.PiqueteQuantidadeAnimais.ReadOnly = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtDescricao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescricao.Location = new System.Drawing.Point(39, 55);
            this.txtDescricao.MaxLength = 60;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(422, 132);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.Text = "";
            // 
            // ckContrato
            // 
            this.ckContrato.AutoSize = true;
            this.ckContrato.Location = new System.Drawing.Point(242, 288);
            this.ckContrato.Name = "ckContrato";
            this.ckContrato.Size = new System.Drawing.Size(92, 20);
            this.ckContrato.TabIndex = 5;
            this.ckContrato.Text = "Arrendado";
            this.ckContrato.UseVisualStyleBackColor = true;
            // 
            // cbbEstado
            // 
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(200, 225);
            this.cbbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(177, 24);
            this.cbbEstado.TabIndex = 3;
            this.cbbEstado.SelectedIndexChanged += new System.EventHandler(this.CbbEstado_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(96, 225);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 16);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado:";
            // 
            // cbbCidade
            // 
            this.cbbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCidade.FormattingEnabled = true;
            this.cbbCidade.Location = new System.Drawing.Point(200, 257);
            this.cbbCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbCidade.Name = "cbbCidade";
            this.cbbCidade.Size = new System.Drawing.Size(177, 24);
            this.cbbCidade.TabIndex = 4;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(96, 260);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 16);
            this.lblCidade.TabIndex = 8;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblContratoAluguelID
            // 
            this.lblContratoAluguelID.AutoSize = true;
            this.lblContratoAluguelID.Location = new System.Drawing.Point(74, 33);
            this.lblContratoAluguelID.Name = "lblContratoAluguelID";
            this.lblContratoAluguelID.Size = new System.Drawing.Size(24, 16);
            this.lblContratoAluguelID.TabIndex = 16;
            this.lblContratoAluguelID.Text = "ID:";
            // 
            // txtContratoAluguelID
            // 
            this.txtContratoAluguelID.Enabled = false;
            this.txtContratoAluguelID.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtContratoAluguelID.Location = new System.Drawing.Point(104, 30);
            this.txtContratoAluguelID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContratoAluguelID.Name = "txtContratoAluguelID";
            this.txtContratoAluguelID.Size = new System.Drawing.Size(110, 23);
            this.txtContratoAluguelID.TabIndex = 0;
            // 
            // gpbContratoAluguel
            // 
            this.gpbContratoAluguel.Controls.Add(this.lblContratoAluguelID);
            this.gpbContratoAluguel.Controls.Add(this.txtContratoAluguelID);
            this.gpbContratoAluguel.Controls.Add(this.btnCadastrarContrato);
            this.gpbContratoAluguel.Enabled = false;
            this.gpbContratoAluguel.Location = new System.Drawing.Point(13, 355);
            this.gpbContratoAluguel.Name = "gpbContratoAluguel";
            this.gpbContratoAluguel.Size = new System.Drawing.Size(521, 77);
            this.gpbContratoAluguel.TabIndex = 1;
            this.gpbContratoAluguel.TabStop = false;
            this.gpbContratoAluguel.Text = "Contrato de Aluguel";
            // 
            // btnCadastrarContrato
            // 
            this.btnCadastrarContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnCadastrarContrato.FlatAppearance.BorderSize = 0;
            this.btnCadastrarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarContrato.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarContrato.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarContrato.Location = new System.Drawing.Point(263, 20);
            this.btnCadastrarContrato.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrarContrato.Name = "btnCadastrarContrato";
            this.btnCadastrarContrato.Size = new System.Drawing.Size(185, 42);
            this.btnCadastrarContrato.TabIndex = 1;
            this.btnCadastrarContrato.Text = "Buscar Contrato de Aluguel";
            this.btnCadastrarContrato.UseVisualStyleBackColor = false;
            this.btnCadastrarContrato.Click += new System.EventHandler(this.btnCadastrarContrato_Click);
            // 
            // txtTamanho
            // 
            this.txtTamanho.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtTamanho.Location = new System.Drawing.Point(185, 194);
            this.txtTamanho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTamanho.MaxLength = 23;
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(202, 23);
            this.txtTamanho.TabIndex = 2;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(91, 197);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(67, 16);
            this.lblTamanho.TabIndex = 2;
            this.lblTamanho.Text = "Tamanho:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(139, 475);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(239, 68);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.lblHectare);
            this.gpbDados.Controls.Add(this.ckbAtivo);
            this.gpbDados.Controls.Add(this.txtDescricao);
            this.gpbDados.Controls.Add(this.ckContrato);
            this.gpbDados.Controls.Add(this.cbbEstado);
            this.gpbDados.Controls.Add(this.lblEstado);
            this.gpbDados.Controls.Add(this.cbbCidade);
            this.gpbDados.Controls.Add(this.lblCidade);
            this.gpbDados.Controls.Add(this.txtTamanho);
            this.gpbDados.Controls.Add(this.lblTamanho);
            this.gpbDados.Controls.Add(this.lblDescricao);
            this.gpbDados.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDados.Location = new System.Drawing.Point(13, 20);
            this.gpbDados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbDados.Size = new System.Drawing.Size(521, 328);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Alteração de Pasto";
            // 
            // lblHectare
            // 
            this.lblHectare.AutoSize = true;
            this.lblHectare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.lblHectare.Location = new System.Drawing.Point(393, 194);
            this.lblHectare.Name = "lblHectare";
            this.lblHectare.Size = new System.Drawing.Size(60, 16);
            this.lblHectare.TabIndex = 17;
            this.lblHectare.Text = "Hectares";
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Location = new System.Drawing.Point(242, 23);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(59, 20);
            this.ckbAtivo.TabIndex = 0;
            this.ckbAtivo.Text = "Ativo";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(36, 36);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 16);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";
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
            this.panel2.Size = new System.Drawing.Size(1155, 45);
            this.panel2.TabIndex = 17;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(183, 24);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Alteração de Pasto";
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(1112, 4);
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
            this.panel4.Size = new System.Drawing.Size(1155, 15);
            this.panel4.TabIndex = 18;
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbDados);
            this.panelInside.Controls.Add(this.gpbPiquete);
            this.panelInside.Controls.Add(this.btnSalvar);
            this.panelInside.Controls.Add(this.gpbContratoAluguel);
            this.panelInside.Location = new System.Drawing.Point(12, 67);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(1131, 609);
            this.panelInside.TabIndex = 19;
            // 
            // frmAlterarPasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1155, 688);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAlterarPasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlterarPasto";
            this.Load += new System.EventHandler(this.FrmAlterarPasto_Load);
            this.gpbPiquete.ResumeLayout(false);
            this.gpbPiquete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiqueteRemover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiquetes)).EndInit();
            this.gpbContratoAluguel.ResumeLayout(false);
            this.gpbContratoAluguel.PerformLayout();
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panelInside.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtPiqueteDescricao;
        private System.Windows.Forms.Label lblPiqueteDescricao;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox gpbPiquete;
        private System.Windows.Forms.DataGridView dgvPiquetes;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.CheckBox ckContrato;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbbCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblContratoAluguelID;
        private System.Windows.Forms.TextBox txtContratoAluguelID;
        private System.Windows.Forms.GroupBox gpbContratoAluguel;
        private System.Windows.Forms.Button btnCadastrarContrato;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiqueteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PiqueteAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiqueteQuantidadeAnimais;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.Button btnCancelarPiqueteRemover;
        private System.Windows.Forms.Label lblPiqueteRemover;
        private System.Windows.Forms.DataGridView dgvPiqueteRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblHectare;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelInside;
    }
}