namespace Apresentacao.Variados.Reports.FormsReport
{
    partial class frmReportContratoAluguel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportContratoAluguel));
            this.panelInside = new System.Windows.Forms.Panel();
            this.gpbOpcConsulta = new System.Windows.Forms.GroupBox();
            this.rbPasto = new System.Windows.Forms.RadioButton();
            this.rbEstoqueLocalidade = new System.Windows.Forms.RadioButton();
            this.rbPessoa = new System.Windows.Forms.RadioButton();
            this.gpbPessoa = new System.Windows.Forms.GroupBox();
            this.lblNomeFicticio = new System.Windows.Forms.Label();
            this.txtNomeFicticio = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblContratoAluguelID = new System.Windows.Forms.Label();
            this.txtPessoaID = new System.Windows.Forms.TextBox();
            this.btnBuscarPessoa = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gpbEstoqueLocalidade = new System.Windows.Forms.GroupBox();
            this.lblEstoqueLocalidadeID = new System.Windows.Forms.Label();
            this.txtEstoqueLocalidadeID = new System.Windows.Forms.TextBox();
            this.btnBuscarLocalidadeEstoque = new System.Windows.Forms.Button();
            this.gpbResultados = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.ContratoAluguelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContratoAluguelDataInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContratoAluguelDataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContratoAluguelValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PessoaFisicaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PessoaJuridicaNomeFicticio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbPasto = new System.Windows.Forms.GroupBox();
            this.lblPastoID = new System.Windows.Forms.Label();
            this.txtPastoID = new System.Windows.Forms.TextBox();
            this.btnBuscarPasto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelInside.SuspendLayout();
            this.gpbOpcConsulta.SuspendLayout();
            this.gpbPessoa.SuspendLayout();
            this.gpbEstoqueLocalidade.SuspendLayout();
            this.gpbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.gpbPasto.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbOpcConsulta);
            this.panelInside.Controls.Add(this.gpbPessoa);
            this.panelInside.Controls.Add(this.btnConsultar);
            this.panelInside.Controls.Add(this.gpbEstoqueLocalidade);
            this.panelInside.Controls.Add(this.gpbResultados);
            this.panelInside.Controls.Add(this.gpbPasto);
            this.panelInside.Location = new System.Drawing.Point(12, 67);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(900, 620);
            this.panelInside.TabIndex = 37;
            // 
            // gpbOpcConsulta
            // 
            this.gpbOpcConsulta.Controls.Add(this.rbPasto);
            this.gpbOpcConsulta.Controls.Add(this.rbEstoqueLocalidade);
            this.gpbOpcConsulta.Controls.Add(this.rbPessoa);
            this.gpbOpcConsulta.Location = new System.Drawing.Point(13, 13);
            this.gpbOpcConsulta.Name = "gpbOpcConsulta";
            this.gpbOpcConsulta.Size = new System.Drawing.Size(349, 50);
            this.gpbOpcConsulta.TabIndex = 0;
            this.gpbOpcConsulta.TabStop = false;
            this.gpbOpcConsulta.Text = "Opções de Consulta";
            // 
            // rbPasto
            // 
            this.rbPasto.AutoSize = true;
            this.rbPasto.Location = new System.Drawing.Point(216, 22);
            this.rbPasto.Name = "rbPasto";
            this.rbPasto.Size = new System.Drawing.Size(60, 20);
            this.rbPasto.TabIndex = 2;
            this.rbPasto.Text = "Pasto";
            this.rbPasto.UseVisualStyleBackColor = true;
            this.rbPasto.CheckedChanged += new System.EventHandler(this.rbPasto_CheckedChanged);
            // 
            // rbEstoqueLocalidade
            // 
            this.rbEstoqueLocalidade.AutoSize = true;
            this.rbEstoqueLocalidade.Location = new System.Drawing.Point(128, 22);
            this.rbEstoqueLocalidade.Name = "rbEstoqueLocalidade";
            this.rbEstoqueLocalidade.Size = new System.Drawing.Size(82, 20);
            this.rbEstoqueLocalidade.TabIndex = 1;
            this.rbEstoqueLocalidade.Text = "Armazém";
            this.rbEstoqueLocalidade.UseVisualStyleBackColor = true;
            this.rbEstoqueLocalidade.CheckedChanged += new System.EventHandler(this.rbEstoqueLocalidade_CheckedChanged);
            // 
            // rbPessoa
            // 
            this.rbPessoa.AutoSize = true;
            this.rbPessoa.Checked = true;
            this.rbPessoa.Location = new System.Drawing.Point(54, 22);
            this.rbPessoa.Name = "rbPessoa";
            this.rbPessoa.Size = new System.Drawing.Size(68, 20);
            this.rbPessoa.TabIndex = 0;
            this.rbPessoa.TabStop = true;
            this.rbPessoa.Text = "Pessoa";
            this.rbPessoa.UseVisualStyleBackColor = true;
            this.rbPessoa.CheckedChanged += new System.EventHandler(this.rbPessoa_CheckedChanged);
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
            this.gpbPessoa.Location = new System.Drawing.Point(13, 69);
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
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(644, 547);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(239, 68);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // gpbEstoqueLocalidade
            // 
            this.gpbEstoqueLocalidade.Controls.Add(this.lblEstoqueLocalidadeID);
            this.gpbEstoqueLocalidade.Controls.Add(this.txtEstoqueLocalidadeID);
            this.gpbEstoqueLocalidade.Controls.Add(this.btnBuscarLocalidadeEstoque);
            this.gpbEstoqueLocalidade.Enabled = false;
            this.gpbEstoqueLocalidade.Location = new System.Drawing.Point(540, 23);
            this.gpbEstoqueLocalidade.Name = "gpbEstoqueLocalidade";
            this.gpbEstoqueLocalidade.Size = new System.Drawing.Size(349, 77);
            this.gpbEstoqueLocalidade.TabIndex = 1;
            this.gpbEstoqueLocalidade.TabStop = false;
            this.gpbEstoqueLocalidade.Text = "Armazém";
            // 
            // lblEstoqueLocalidadeID
            // 
            this.lblEstoqueLocalidadeID.AutoSize = true;
            this.lblEstoqueLocalidadeID.Location = new System.Drawing.Point(10, 36);
            this.lblEstoqueLocalidadeID.Name = "lblEstoqueLocalidadeID";
            this.lblEstoqueLocalidadeID.Size = new System.Drawing.Size(24, 16);
            this.lblEstoqueLocalidadeID.TabIndex = 16;
            this.lblEstoqueLocalidadeID.Text = "ID:";
            // 
            // txtEstoqueLocalidadeID
            // 
            this.txtEstoqueLocalidadeID.Enabled = false;
            this.txtEstoqueLocalidadeID.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtEstoqueLocalidadeID.Location = new System.Drawing.Point(40, 33);
            this.txtEstoqueLocalidadeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstoqueLocalidadeID.Name = "txtEstoqueLocalidadeID";
            this.txtEstoqueLocalidadeID.Size = new System.Drawing.Size(110, 23);
            this.txtEstoqueLocalidadeID.TabIndex = 0;
            // 
            // btnBuscarLocalidadeEstoque
            // 
            this.btnBuscarLocalidadeEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarLocalidadeEstoque.FlatAppearance.BorderSize = 0;
            this.btnBuscarLocalidadeEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLocalidadeEstoque.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarLocalidadeEstoque.ForeColor = System.Drawing.Color.White;
            this.btnBuscarLocalidadeEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarLocalidadeEstoque.Location = new System.Drawing.Point(156, 23);
            this.btnBuscarLocalidadeEstoque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarLocalidadeEstoque.Name = "btnBuscarLocalidadeEstoque";
            this.btnBuscarLocalidadeEstoque.Size = new System.Drawing.Size(185, 42);
            this.btnBuscarLocalidadeEstoque.TabIndex = 1;
            this.btnBuscarLocalidadeEstoque.Text = "Buscar Armazém";
            this.btnBuscarLocalidadeEstoque.UseVisualStyleBackColor = false;
            this.btnBuscarLocalidadeEstoque.Click += new System.EventHandler(this.btnBuscarLocalidadeEstoque_Click);
            // 
            // gpbResultados
            // 
            this.gpbResultados.Controls.Add(this.lblInfo);
            this.gpbResultados.Controls.Add(this.dgvResultado);
            this.gpbResultados.Location = new System.Drawing.Point(13, 197);
            this.gpbResultados.Name = "gpbResultados";
            this.gpbResultados.Size = new System.Drawing.Size(876, 342);
            this.gpbResultados.TabIndex = 32;
            this.gpbResultados.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblInfo.Location = new System.Drawing.Point(6, 19);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(361, 16);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = "De um duplo clique na linha desejada para criar o relatório...";
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContratoAluguelID,
            this.ContratoAluguelDataInicial,
            this.ContratoAluguelDataFinal,
            this.ContratoAluguelValor,
            this.PessoaFisicaNome,
            this.PessoaJuridicaNomeFicticio});
            this.dgvResultado.Location = new System.Drawing.Point(6, 38);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(864, 298);
            this.dgvResultado.TabIndex = 2;
            this.dgvResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultado_CellDoubleClick);
            this.dgvResultado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvResultado_CellFormatting);
            // 
            // ContratoAluguelID
            // 
            this.ContratoAluguelID.DataPropertyName = "ContratoAluguelID";
            this.ContratoAluguelID.HeaderText = "ID";
            this.ContratoAluguelID.Name = "ContratoAluguelID";
            this.ContratoAluguelID.ReadOnly = true;
            this.ContratoAluguelID.Width = 80;
            // 
            // ContratoAluguelDataInicial
            // 
            this.ContratoAluguelDataInicial.DataPropertyName = "ContratoAluguelDataInicial";
            this.ContratoAluguelDataInicial.HeaderText = "Data Inicial";
            this.ContratoAluguelDataInicial.Name = "ContratoAluguelDataInicial";
            this.ContratoAluguelDataInicial.ReadOnly = true;
            this.ContratoAluguelDataInicial.Width = 130;
            // 
            // ContratoAluguelDataFinal
            // 
            this.ContratoAluguelDataFinal.DataPropertyName = "ContratoAluguelDataFinal";
            this.ContratoAluguelDataFinal.HeaderText = "Data Final";
            this.ContratoAluguelDataFinal.Name = "ContratoAluguelDataFinal";
            this.ContratoAluguelDataFinal.ReadOnly = true;
            this.ContratoAluguelDataFinal.Width = 130;
            // 
            // ContratoAluguelValor
            // 
            this.ContratoAluguelValor.DataPropertyName = "ContratoAluguelValor";
            this.ContratoAluguelValor.HeaderText = "Valor";
            this.ContratoAluguelValor.Name = "ContratoAluguelValor";
            this.ContratoAluguelValor.ReadOnly = true;
            this.ContratoAluguelValor.Width = 110;
            // 
            // PessoaFisicaNome
            // 
            this.PessoaFisicaNome.DataPropertyName = "Pessoa.PessoaFisica.PessoaFisicaNome";
            this.PessoaFisicaNome.HeaderText = "Nome";
            this.PessoaFisicaNome.Name = "PessoaFisicaNome";
            this.PessoaFisicaNome.ReadOnly = true;
            this.PessoaFisicaNome.Width = 185;
            // 
            // PessoaJuridicaNomeFicticio
            // 
            this.PessoaJuridicaNomeFicticio.DataPropertyName = "Pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio";
            this.PessoaJuridicaNomeFicticio.HeaderText = "Nome Fictício";
            this.PessoaJuridicaNomeFicticio.Name = "PessoaJuridicaNomeFicticio";
            this.PessoaJuridicaNomeFicticio.ReadOnly = true;
            this.PessoaJuridicaNomeFicticio.Width = 185;
            // 
            // gpbPasto
            // 
            this.gpbPasto.Controls.Add(this.lblPastoID);
            this.gpbPasto.Controls.Add(this.txtPastoID);
            this.gpbPasto.Controls.Add(this.btnBuscarPasto);
            this.gpbPasto.Enabled = false;
            this.gpbPasto.Location = new System.Drawing.Point(540, 106);
            this.gpbPasto.Name = "gpbPasto";
            this.gpbPasto.Size = new System.Drawing.Size(349, 77);
            this.gpbPasto.TabIndex = 1;
            this.gpbPasto.TabStop = false;
            this.gpbPasto.Text = "Pasto";
            // 
            // lblPastoID
            // 
            this.lblPastoID.AutoSize = true;
            this.lblPastoID.Location = new System.Drawing.Point(10, 36);
            this.lblPastoID.Name = "lblPastoID";
            this.lblPastoID.Size = new System.Drawing.Size(24, 16);
            this.lblPastoID.TabIndex = 16;
            this.lblPastoID.Text = "ID:";
            // 
            // txtPastoID
            // 
            this.txtPastoID.Enabled = false;
            this.txtPastoID.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtPastoID.Location = new System.Drawing.Point(40, 33);
            this.txtPastoID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPastoID.Name = "txtPastoID";
            this.txtPastoID.Size = new System.Drawing.Size(110, 23);
            this.txtPastoID.TabIndex = 0;
            // 
            // btnBuscarPasto
            // 
            this.btnBuscarPasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarPasto.FlatAppearance.BorderSize = 0;
            this.btnBuscarPasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPasto.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPasto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPasto.Location = new System.Drawing.Point(156, 23);
            this.btnBuscarPasto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarPasto.Name = "btnBuscarPasto";
            this.btnBuscarPasto.Size = new System.Drawing.Size(185, 42);
            this.btnBuscarPasto.TabIndex = 1;
            this.btnBuscarPasto.Text = "Buscar Pasto";
            this.btnBuscarPasto.UseVisualStyleBackColor = false;
            this.btnBuscarPasto.Click += new System.EventHandler(this.btnBuscarPasto_Click);
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
            this.panel2.Size = new System.Drawing.Size(927, 45);
            this.panel2.TabIndex = 35;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(313, 24);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Relatório de Contrato de Aluguel";
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(884, 4);
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
            this.panel4.Size = new System.Drawing.Size(927, 15);
            this.panel4.TabIndex = 36;
            // 
            // frmReportContratoAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(927, 696);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReportContratoAluguel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportContratoAluguel";
            this.panelInside.ResumeLayout(false);
            this.gpbOpcConsulta.ResumeLayout(false);
            this.gpbOpcConsulta.PerformLayout();
            this.gpbPessoa.ResumeLayout(false);
            this.gpbPessoa.PerformLayout();
            this.gpbEstoqueLocalidade.ResumeLayout(false);
            this.gpbEstoqueLocalidade.PerformLayout();
            this.gpbResultados.ResumeLayout(false);
            this.gpbResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.gpbPasto.ResumeLayout(false);
            this.gpbPasto.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.GroupBox gpbOpcConsulta;
        private System.Windows.Forms.RadioButton rbPasto;
        private System.Windows.Forms.RadioButton rbEstoqueLocalidade;
        private System.Windows.Forms.RadioButton rbPessoa;
        private System.Windows.Forms.GroupBox gpbPessoa;
        private System.Windows.Forms.Label lblNomeFicticio;
        private System.Windows.Forms.TextBox txtNomeFicticio;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblContratoAluguelID;
        private System.Windows.Forms.TextBox txtPessoaID;
        private System.Windows.Forms.Button btnBuscarPessoa;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gpbEstoqueLocalidade;
        private System.Windows.Forms.Label lblEstoqueLocalidadeID;
        private System.Windows.Forms.TextBox txtEstoqueLocalidadeID;
        private System.Windows.Forms.Button btnBuscarLocalidadeEstoque;
        private System.Windows.Forms.GroupBox gpbResultados;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContratoAluguelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContratoAluguelDataInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContratoAluguelDataFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContratoAluguelValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PessoaFisicaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn PessoaJuridicaNomeFicticio;
        private System.Windows.Forms.GroupBox gpbPasto;
        private System.Windows.Forms.Label lblPastoID;
        private System.Windows.Forms.TextBox txtPastoID;
        private System.Windows.Forms.Button btnBuscarPasto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblInfo;
    }
}