namespace Apresentacao.Vendas
{
    partial class frmConsultaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaVenda));
            this.panelInside = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.VendaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendaValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PessoaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeAnimais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbID = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.gpbUsuario = new System.Windows.Forms.GroupBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gpbPessoa = new System.Windows.Forms.GroupBox();
            this.btnBuscarPessoa = new System.Windows.Forms.Button();
            this.txtPessoa = new System.Windows.Forms.TextBox();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.gpbAnimal = new System.Windows.Forms.GroupBox();
            this.btnBuscaAnimal = new System.Windows.Forms.Button();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.gpbDatas = new System.Windows.Forms.GroupBox();
            this.dtpData2 = new System.Windows.Forms.DateTimePicker();
            this.dtpData1 = new System.Windows.Forms.DateTimePicker();
            this.lblTraco = new System.Windows.Forms.Label();
            this.gpbDataOpcoes = new System.Windows.Forms.GroupBox();
            this.rbEntre = new System.Windows.Forms.RadioButton();
            this.rbAntes = new System.Windows.Forms.RadioButton();
            this.rbApos = new System.Windows.Forms.RadioButton();
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbPessoa = new System.Windows.Forms.RadioButton();
            this.rbUsuario = new System.Windows.Forms.RadioButton();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.rbAnimal = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelInside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.gpbID.SuspendLayout();
            this.gpbUsuario.SuspendLayout();
            this.gpbPessoa.SuspendLayout();
            this.gpbAnimal.SuspendLayout();
            this.gpbDatas.SuspendLayout();
            this.gpbDataOpcoes.SuspendLayout();
            this.gpbOpcoes.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.lblInfo);
            this.panelInside.Controls.Add(this.btnConsultar);
            this.panelInside.Controls.Add(this.dgvResultados);
            this.panelInside.Controls.Add(this.gpbID);
            this.panelInside.Controls.Add(this.gpbUsuario);
            this.panelInside.Controls.Add(this.gpbPessoa);
            this.panelInside.Controls.Add(this.gpbAnimal);
            this.panelInside.Controls.Add(this.gpbDatas);
            this.panelInside.Controls.Add(this.gpbDataOpcoes);
            this.panelInside.Controls.Add(this.gpbOpcoes);
            this.panelInside.Location = new System.Drawing.Point(12, 67);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(761, 573);
            this.panelInside.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblInfo.Location = new System.Drawing.Point(9, 111);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(382, 16);
            this.lblInfo.TabIndex = 53;
            this.lblInfo.Text = "De um duplo clique na linha desejada para abrir mais detalhes...";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(508, 492);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(239, 68);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VendaID,
            this.VendaData,
            this.VendaValorTotal,
            this.PessoaID,
            this.UsuarioNome,
            this.QuantidadeAnimais});
            this.dgvResultados.Location = new System.Drawing.Point(12, 130);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(735, 354);
            this.dgvResultados.TabIndex = 3;
            this.dgvResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellDoubleClick);
            this.dgvResultados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvResultados_CellFormatting);
            // 
            // VendaID
            // 
            this.VendaID.DataPropertyName = "VendaID";
            this.VendaID.HeaderText = "ID";
            this.VendaID.Name = "VendaID";
            this.VendaID.ReadOnly = true;
            this.VendaID.Width = 80;
            // 
            // VendaData
            // 
            this.VendaData.DataPropertyName = "VendaData";
            this.VendaData.HeaderText = "Data";
            this.VendaData.Name = "VendaData";
            this.VendaData.ReadOnly = true;
            this.VendaData.Width = 130;
            // 
            // VendaValorTotal
            // 
            this.VendaValorTotal.DataPropertyName = "VendaValorTotal";
            this.VendaValorTotal.HeaderText = "Valor";
            this.VendaValorTotal.Name = "VendaValorTotal";
            this.VendaValorTotal.ReadOnly = true;
            this.VendaValorTotal.Width = 140;
            // 
            // PessoaID
            // 
            this.PessoaID.DataPropertyName = "Pessoa.PessoaID";
            this.PessoaID.HeaderText = "Pessoa";
            this.PessoaID.Name = "PessoaID";
            this.PessoaID.ReadOnly = true;
            // 
            // UsuarioNome
            // 
            this.UsuarioNome.DataPropertyName = "Usuario.UsuarioNome";
            this.UsuarioNome.HeaderText = "Usuário";
            this.UsuarioNome.Name = "UsuarioNome";
            this.UsuarioNome.ReadOnly = true;
            this.UsuarioNome.Width = 140;
            // 
            // QuantidadeAnimais
            // 
            this.QuantidadeAnimais.DataPropertyName = "QuantidadeAnimais";
            this.QuantidadeAnimais.HeaderText = "Quantidade";
            this.QuantidadeAnimais.Name = "QuantidadeAnimais";
            this.QuantidadeAnimais.ReadOnly = true;
            // 
            // gpbID
            // 
            this.gpbID.Controls.Add(this.txtId);
            this.gpbID.Controls.Add(this.lblID);
            this.gpbID.Location = new System.Drawing.Point(268, 17);
            this.gpbID.Name = "gpbID";
            this.gpbID.Size = new System.Drawing.Size(167, 73);
            this.gpbID.TabIndex = 1;
            this.gpbID.TabStop = false;
            this.gpbID.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(39, 29);
            this.txtId.MaxLength = 10;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(109, 23);
            this.txtId.TabIndex = 1;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(9, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // gpbUsuario
            // 
            this.gpbUsuario.Controls.Add(this.btnBuscarUsuario);
            this.gpbUsuario.Controls.Add(this.txtUsuario);
            this.gpbUsuario.Controls.Add(this.lblUsuario);
            this.gpbUsuario.Location = new System.Drawing.Point(268, 17);
            this.gpbUsuario.Name = "gpbUsuario";
            this.gpbUsuario.Size = new System.Drawing.Size(378, 73);
            this.gpbUsuario.TabIndex = 1;
            this.gpbUsuario.TabStop = false;
            this.gpbUsuario.Visible = false;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarUsuario.FlatAppearance.BorderSize = 0;
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnBuscarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(187, 19);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(165, 42);
            this.btnBuscarUsuario.TabIndex = 15;
            this.btnBuscarUsuario.Text = "Buscar Usuário";
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(72, 29);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(109, 23);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(9, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 16);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário:";
            // 
            // gpbPessoa
            // 
            this.gpbPessoa.Controls.Add(this.btnBuscarPessoa);
            this.gpbPessoa.Controls.Add(this.txtPessoa);
            this.gpbPessoa.Controls.Add(this.lblPessoa);
            this.gpbPessoa.Location = new System.Drawing.Point(268, 17);
            this.gpbPessoa.Name = "gpbPessoa";
            this.gpbPessoa.Size = new System.Drawing.Size(378, 73);
            this.gpbPessoa.TabIndex = 1;
            this.gpbPessoa.TabStop = false;
            this.gpbPessoa.Visible = false;
            // 
            // btnBuscarPessoa
            // 
            this.btnBuscarPessoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarPessoa.FlatAppearance.BorderSize = 0;
            this.btnBuscarPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPessoa.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPessoa.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPessoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPessoa.Location = new System.Drawing.Point(187, 19);
            this.btnBuscarPessoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarPessoa.Name = "btnBuscarPessoa";
            this.btnBuscarPessoa.Size = new System.Drawing.Size(165, 42);
            this.btnBuscarPessoa.TabIndex = 15;
            this.btnBuscarPessoa.Text = "Buscar Pessoa";
            this.btnBuscarPessoa.UseVisualStyleBackColor = false;
            this.btnBuscarPessoa.Click += new System.EventHandler(this.btnBuscarPessoa_Click);
            // 
            // txtPessoa
            // 
            this.txtPessoa.Enabled = false;
            this.txtPessoa.Location = new System.Drawing.Point(72, 29);
            this.txtPessoa.Name = "txtPessoa";
            this.txtPessoa.Size = new System.Drawing.Size(109, 23);
            this.txtPessoa.TabIndex = 1;
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Location = new System.Drawing.Point(14, 32);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(53, 16);
            this.lblPessoa.TabIndex = 0;
            this.lblPessoa.Text = "Pessoa:";
            // 
            // gpbAnimal
            // 
            this.gpbAnimal.Controls.Add(this.btnBuscaAnimal);
            this.gpbAnimal.Controls.Add(this.txtAnimal);
            this.gpbAnimal.Controls.Add(this.lblAnimal);
            this.gpbAnimal.Location = new System.Drawing.Point(268, 17);
            this.gpbAnimal.Name = "gpbAnimal";
            this.gpbAnimal.Size = new System.Drawing.Size(378, 73);
            this.gpbAnimal.TabIndex = 1;
            this.gpbAnimal.TabStop = false;
            this.gpbAnimal.Visible = false;
            // 
            // btnBuscaAnimal
            // 
            this.btnBuscaAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscaAnimal.FlatAppearance.BorderSize = 0;
            this.btnBuscaAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaAnimal.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscaAnimal.ForeColor = System.Drawing.Color.White;
            this.btnBuscaAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaAnimal.Location = new System.Drawing.Point(187, 19);
            this.btnBuscaAnimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscaAnimal.Name = "btnBuscaAnimal";
            this.btnBuscaAnimal.Size = new System.Drawing.Size(165, 42);
            this.btnBuscaAnimal.TabIndex = 15;
            this.btnBuscaAnimal.Text = "Buscar Animal";
            this.btnBuscaAnimal.UseVisualStyleBackColor = false;
            this.btnBuscaAnimal.Click += new System.EventHandler(this.btnBuscaAnimal_Click);
            // 
            // txtAnimal
            // 
            this.txtAnimal.Enabled = false;
            this.txtAnimal.Location = new System.Drawing.Point(72, 29);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.Size = new System.Drawing.Size(109, 23);
            this.txtAnimal.TabIndex = 1;
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(14, 32);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(52, 16);
            this.lblAnimal.TabIndex = 0;
            this.lblAnimal.Text = "Animal:";
            // 
            // gpbDatas
            // 
            this.gpbDatas.Controls.Add(this.dtpData2);
            this.gpbDatas.Controls.Add(this.dtpData1);
            this.gpbDatas.Controls.Add(this.lblTraco);
            this.gpbDatas.Location = new System.Drawing.Point(480, 27);
            this.gpbDatas.Name = "gpbDatas";
            this.gpbDatas.Size = new System.Drawing.Size(261, 56);
            this.gpbDatas.TabIndex = 2;
            this.gpbDatas.TabStop = false;
            // 
            // dtpData2
            // 
            this.dtpData2.Enabled = false;
            this.dtpData2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData2.Location = new System.Drawing.Point(137, 22);
            this.dtpData2.Name = "dtpData2";
            this.dtpData2.Size = new System.Drawing.Size(105, 23);
            this.dtpData2.TabIndex = 1;
            // 
            // dtpData1
            // 
            this.dtpData1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData1.Location = new System.Drawing.Point(7, 22);
            this.dtpData1.Name = "dtpData1";
            this.dtpData1.Size = new System.Drawing.Size(105, 23);
            this.dtpData1.TabIndex = 0;
            // 
            // lblTraco
            // 
            this.lblTraco.AutoSize = true;
            this.lblTraco.Location = new System.Drawing.Point(118, 25);
            this.lblTraco.Name = "lblTraco";
            this.lblTraco.Size = new System.Drawing.Size(13, 16);
            this.lblTraco.TabIndex = 2;
            this.lblTraco.Text = "-";
            // 
            // gpbDataOpcoes
            // 
            this.gpbDataOpcoes.Controls.Add(this.rbEntre);
            this.gpbDataOpcoes.Controls.Add(this.rbAntes);
            this.gpbDataOpcoes.Controls.Add(this.rbApos);
            this.gpbDataOpcoes.Location = new System.Drawing.Point(268, 27);
            this.gpbDataOpcoes.Name = "gpbDataOpcoes";
            this.gpbDataOpcoes.Size = new System.Drawing.Size(206, 56);
            this.gpbDataOpcoes.TabIndex = 1;
            this.gpbDataOpcoes.TabStop = false;
            // 
            // rbEntre
            // 
            this.rbEntre.AutoSize = true;
            this.rbEntre.Location = new System.Drawing.Point(139, 24);
            this.rbEntre.Name = "rbEntre";
            this.rbEntre.Size = new System.Drawing.Size(58, 20);
            this.rbEntre.TabIndex = 3;
            this.rbEntre.Text = "Entre";
            this.rbEntre.UseVisualStyleBackColor = true;
            this.rbEntre.CheckedChanged += new System.EventHandler(this.rbEntre_CheckedChanged);
            // 
            // rbAntes
            // 
            this.rbAntes.AutoSize = true;
            this.rbAntes.Location = new System.Drawing.Point(72, 24);
            this.rbAntes.Name = "rbAntes";
            this.rbAntes.Size = new System.Drawing.Size(61, 20);
            this.rbAntes.TabIndex = 2;
            this.rbAntes.Text = "Antes";
            this.rbAntes.UseVisualStyleBackColor = true;
            this.rbAntes.CheckedChanged += new System.EventHandler(this.rbAntes_CheckedChanged);
            // 
            // rbApos
            // 
            this.rbApos.AutoSize = true;
            this.rbApos.Checked = true;
            this.rbApos.Location = new System.Drawing.Point(9, 23);
            this.rbApos.Name = "rbApos";
            this.rbApos.Size = new System.Drawing.Size(57, 20);
            this.rbApos.TabIndex = 1;
            this.rbApos.TabStop = true;
            this.rbApos.Text = "Após";
            this.rbApos.UseVisualStyleBackColor = true;
            this.rbApos.CheckedChanged += new System.EventHandler(this.rbApos_CheckedChanged);
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.rbPessoa);
            this.gpbOpcoes.Controls.Add(this.rbUsuario);
            this.gpbOpcoes.Controls.Add(this.rbID);
            this.gpbOpcoes.Controls.Add(this.rbData);
            this.gpbOpcoes.Controls.Add(this.rbAnimal);
            this.gpbOpcoes.Location = new System.Drawing.Point(12, 15);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(250, 76);
            this.gpbOpcoes.TabIndex = 0;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Opções  de consulta";
            // 
            // rbPessoa
            // 
            this.rbPessoa.AutoSize = true;
            this.rbPessoa.Location = new System.Drawing.Point(147, 22);
            this.rbPessoa.Name = "rbPessoa";
            this.rbPessoa.Size = new System.Drawing.Size(68, 20);
            this.rbPessoa.TabIndex = 2;
            this.rbPessoa.Text = "Pessoa";
            this.rbPessoa.UseVisualStyleBackColor = true;
            this.rbPessoa.CheckedChanged += new System.EventHandler(this.rbPessoa_CheckedChanged);
            // 
            // rbUsuario
            // 
            this.rbUsuario.AutoSize = true;
            this.rbUsuario.Location = new System.Drawing.Point(58, 48);
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.Size = new System.Drawing.Size(72, 20);
            this.rbUsuario.TabIndex = 3;
            this.rbUsuario.Text = "Usuário";
            this.rbUsuario.UseVisualStyleBackColor = true;
            this.rbUsuario.CheckedChanged += new System.EventHandler(this.rbUsuario_CheckedChanged);
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Location = new System.Drawing.Point(147, 48);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(39, 20);
            this.rbID.TabIndex = 4;
            this.rbID.Text = "ID";
            this.rbID.UseVisualStyleBackColor = true;
            this.rbID.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Checked = true;
            this.rbData.Location = new System.Drawing.Point(14, 22);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(54, 20);
            this.rbData.TabIndex = 0;
            this.rbData.TabStop = true;
            this.rbData.Text = "Data";
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.rbData_CheckedChanged);
            // 
            // rbAnimal
            // 
            this.rbAnimal.AutoSize = true;
            this.rbAnimal.Location = new System.Drawing.Point(74, 22);
            this.rbAnimal.Name = "rbAnimal";
            this.rbAnimal.Size = new System.Drawing.Size(67, 20);
            this.rbAnimal.TabIndex = 1;
            this.rbAnimal.Text = "Animal";
            this.rbAnimal.UseVisualStyleBackColor = true;
            this.rbAnimal.CheckedChanged += new System.EventHandler(this.rbAnimal_CheckedChanged);
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
            this.panel2.Size = new System.Drawing.Size(785, 45);
            this.panel2.TabIndex = 47;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(183, 24);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Consulta de Venda";
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(742, 4);
            this.picExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(40, 38);
            this.picExit.TabIndex = 4;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseEnter += new System.EventHandler(this.picExit_MouseEnter);
            this.picExit.MouseLeave += new System.EventHandler(this.picExit_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(88)))), ((int)(((byte)(46)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(785, 15);
            this.panel4.TabIndex = 48;
            // 
            // frmConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(785, 647);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaVenda";
            this.panelInside.ResumeLayout(false);
            this.panelInside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.gpbID.ResumeLayout(false);
            this.gpbID.PerformLayout();
            this.gpbUsuario.ResumeLayout(false);
            this.gpbUsuario.PerformLayout();
            this.gpbPessoa.ResumeLayout(false);
            this.gpbPessoa.PerformLayout();
            this.gpbAnimal.ResumeLayout(false);
            this.gpbAnimal.PerformLayout();
            this.gpbDatas.ResumeLayout(false);
            this.gpbDatas.PerformLayout();
            this.gpbDataOpcoes.ResumeLayout(false);
            this.gpbDataOpcoes.PerformLayout();
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.GroupBox gpbID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gpbUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gpbPessoa;
        private System.Windows.Forms.Button btnBuscarPessoa;
        private System.Windows.Forms.TextBox txtPessoa;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.GroupBox gpbAnimal;
        private System.Windows.Forms.Button btnBuscaAnimal;
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.GroupBox gpbDatas;
        private System.Windows.Forms.DateTimePicker dtpData2;
        private System.Windows.Forms.DateTimePicker dtpData1;
        private System.Windows.Forms.Label lblTraco;
        private System.Windows.Forms.GroupBox gpbDataOpcoes;
        private System.Windows.Forms.RadioButton rbEntre;
        private System.Windows.Forms.RadioButton rbAntes;
        private System.Windows.Forms.RadioButton rbApos;
        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.RadioButton rbPessoa;
        private System.Windows.Forms.RadioButton rbUsuario;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton rbAnimal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendaValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PessoaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeAnimais;
        private System.Windows.Forms.Label lblTitulo;
    }
}