namespace Apresentacao.EstoqueLocalidade
{
    partial class frmConsultaEstoqueLocalidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaEstoqueLocalidade));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelInside = new System.Windows.Forms.Panel();
            this.gpbItem = new System.Windows.Forms.GroupBox();
            this.btnConsultarItem = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.gpbContratoAluguel = new System.Windows.Forms.GroupBox();
            this.btnConsultarContratoAluguel = new System.Windows.Forms.Button();
            this.txtContratoAluguel = new System.Windows.Forms.TextBox();
            this.lblContratoAluguel = new System.Windows.Forms.Label();
            this.gpbDescricao = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.gpbID = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.gpbCidade = new System.Windows.Forms.GroupBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbbCidade = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbCidade = new System.Windows.Forms.RadioButton();
            this.rbItem = new System.Windows.Forms.RadioButton();
            this.rbContratoAluguel = new System.Windows.Forms.RadioButton();
            this.rbDescricao = new System.Windows.Forms.RadioButton();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.EstoqueLocalidadeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueLocalidadeDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueLocalidadeEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CidadeNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContratoAluguelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panelInside.SuspendLayout();
            this.gpbItem.SuspendLayout();
            this.gpbContratoAluguel.SuspendLayout();
            this.gpbDescricao.SuspendLayout();
            this.gpbID.SuspendLayout();
            this.gpbCidade.SuspendLayout();
            this.gpbOpcoes.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(845, 45);
            this.panel2.TabIndex = 25;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(213, 24);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Consulta de Armazém";
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(802, 4);
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
            this.panel4.Size = new System.Drawing.Size(845, 15);
            this.panel4.TabIndex = 26;
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbItem);
            this.panelInside.Controls.Add(this.gpbContratoAluguel);
            this.panelInside.Controls.Add(this.gpbDescricao);
            this.panelInside.Controls.Add(this.gpbID);
            this.panelInside.Controls.Add(this.gpbCidade);
            this.panelInside.Controls.Add(this.gpbOpcoes);
            this.panelInside.Controls.Add(this.btnConsultar);
            this.panelInside.Controls.Add(this.gpbResultado);
            this.panelInside.Location = new System.Drawing.Point(12, 67);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(822, 513);
            this.panelInside.TabIndex = 0;
            // 
            // gpbItem
            // 
            this.gpbItem.Controls.Add(this.btnConsultarItem);
            this.gpbItem.Controls.Add(this.txtItem);
            this.gpbItem.Controls.Add(this.lblItem);
            this.gpbItem.Location = new System.Drawing.Point(301, 21);
            this.gpbItem.Name = "gpbItem";
            this.gpbItem.Size = new System.Drawing.Size(342, 82);
            this.gpbItem.TabIndex = 1;
            this.gpbItem.TabStop = false;
            this.gpbItem.Visible = false;
            // 
            // btnConsultarItem
            // 
            this.btnConsultarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnConsultarItem.FlatAppearance.BorderSize = 0;
            this.btnConsultarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultarItem.ForeColor = System.Drawing.Color.White;
            this.btnConsultarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarItem.Location = new System.Drawing.Point(147, 26);
            this.btnConsultarItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultarItem.Name = "btnConsultarItem";
            this.btnConsultarItem.Size = new System.Drawing.Size(185, 42);
            this.btnConsultarItem.TabIndex = 23;
            this.btnConsultarItem.Text = "Buscar Item";
            this.btnConsultarItem.UseVisualStyleBackColor = false;
            this.btnConsultarItem.Click += new System.EventHandler(this.btnConsultarItem_Click);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(21, 45);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(105, 23);
            this.txtItem.TabIndex = 1;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(52, 26);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(38, 16);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item:";
            // 
            // gpbContratoAluguel
            // 
            this.gpbContratoAluguel.Controls.Add(this.btnConsultarContratoAluguel);
            this.gpbContratoAluguel.Controls.Add(this.txtContratoAluguel);
            this.gpbContratoAluguel.Controls.Add(this.lblContratoAluguel);
            this.gpbContratoAluguel.Location = new System.Drawing.Point(301, 12);
            this.gpbContratoAluguel.Name = "gpbContratoAluguel";
            this.gpbContratoAluguel.Size = new System.Drawing.Size(342, 91);
            this.gpbContratoAluguel.TabIndex = 1;
            this.gpbContratoAluguel.TabStop = false;
            this.gpbContratoAluguel.Visible = false;
            // 
            // btnConsultarContratoAluguel
            // 
            this.btnConsultarContratoAluguel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnConsultarContratoAluguel.FlatAppearance.BorderSize = 0;
            this.btnConsultarContratoAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarContratoAluguel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultarContratoAluguel.ForeColor = System.Drawing.Color.White;
            this.btnConsultarContratoAluguel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarContratoAluguel.Location = new System.Drawing.Point(147, 32);
            this.btnConsultarContratoAluguel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultarContratoAluguel.Name = "btnConsultarContratoAluguel";
            this.btnConsultarContratoAluguel.Size = new System.Drawing.Size(185, 42);
            this.btnConsultarContratoAluguel.TabIndex = 23;
            this.btnConsultarContratoAluguel.Text = "Buscar Contrato de Aluguel";
            this.btnConsultarContratoAluguel.UseVisualStyleBackColor = false;
            this.btnConsultarContratoAluguel.Click += new System.EventHandler(this.btnConsultarContratoAluguel_Click);
            // 
            // txtContratoAluguel
            // 
            this.txtContratoAluguel.Location = new System.Drawing.Point(21, 45);
            this.txtContratoAluguel.Name = "txtContratoAluguel";
            this.txtContratoAluguel.Size = new System.Drawing.Size(105, 23);
            this.txtContratoAluguel.TabIndex = 1;
            // 
            // lblContratoAluguel
            // 
            this.lblContratoAluguel.AutoSize = true;
            this.lblContratoAluguel.Location = new System.Drawing.Point(6, 26);
            this.lblContratoAluguel.Name = "lblContratoAluguel";
            this.lblContratoAluguel.Size = new System.Drawing.Size(132, 16);
            this.lblContratoAluguel.TabIndex = 0;
            this.lblContratoAluguel.Text = "Contrato de Aluguel:";
            // 
            // gpbDescricao
            // 
            this.gpbDescricao.Controls.Add(this.textBox1);
            this.gpbDescricao.Controls.Add(this.lblDescricao);
            this.gpbDescricao.Location = new System.Drawing.Point(301, 34);
            this.gpbDescricao.Name = "gpbDescricao";
            this.gpbDescricao.Size = new System.Drawing.Size(283, 48);
            this.gpbDescricao.TabIndex = 31;
            this.gpbDescricao.TabStop = false;
            this.gpbDescricao.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 16);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 19);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 16);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";
            // 
            // gpbID
            // 
            this.gpbID.Controls.Add(this.txtID);
            this.gpbID.Controls.Add(this.lblID);
            this.gpbID.Location = new System.Drawing.Point(301, 34);
            this.gpbID.Name = "gpbID";
            this.gpbID.Size = new System.Drawing.Size(147, 48);
            this.gpbID.TabIndex = 1;
            this.gpbID.TabStop = false;
            this.gpbID.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(36, 16);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(105, 23);
            this.txtID.TabIndex = 1;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 19);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // gpbCidade
            // 
            this.gpbCidade.Controls.Add(this.cbbEstado);
            this.gpbCidade.Controls.Add(this.lblEstado);
            this.gpbCidade.Controls.Add(this.cbbCidade);
            this.gpbCidade.Controls.Add(this.lblCidade);
            this.gpbCidade.Location = new System.Drawing.Point(301, 12);
            this.gpbCidade.Name = "gpbCidade";
            this.gpbCidade.Size = new System.Drawing.Size(283, 91);
            this.gpbCidade.TabIndex = 1;
            this.gpbCidade.TabStop = false;
            this.gpbCidade.Visible = false;
            // 
            // cbbEstado
            // 
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(80, 23);
            this.cbbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(177, 24);
            this.cbbEstado.TabIndex = 0;
            this.cbbEstado.SelectedIndexChanged += new System.EventHandler(this.CbbEstado_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(22, 26);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 16);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado:";
            // 
            // cbbCidade
            // 
            this.cbbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCidade.FormattingEnabled = true;
            this.cbbCidade.Location = new System.Drawing.Point(80, 55);
            this.cbbCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbCidade.Name = "cbbCidade";
            this.cbbCidade.Size = new System.Drawing.Size(177, 24);
            this.cbbCidade.TabIndex = 1;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(22, 58);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 16);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "Cidade:";
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.rbCidade);
            this.gpbOpcoes.Controls.Add(this.rbItem);
            this.gpbOpcoes.Controls.Add(this.rbContratoAluguel);
            this.gpbOpcoes.Controls.Add(this.rbDescricao);
            this.gpbOpcoes.Controls.Add(this.rbID);
            this.gpbOpcoes.Location = new System.Drawing.Point(12, 12);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(283, 91);
            this.gpbOpcoes.TabIndex = 0;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Consulta de Armazém";
            // 
            // rbCidade
            // 
            this.rbCidade.AutoSize = true;
            this.rbCidade.Location = new System.Drawing.Point(73, 48);
            this.rbCidade.Name = "rbCidade";
            this.rbCidade.Size = new System.Drawing.Size(67, 20);
            this.rbCidade.TabIndex = 3;
            this.rbCidade.Text = "Cidade";
            this.rbCidade.UseVisualStyleBackColor = true;
            this.rbCidade.CheckedChanged += new System.EventHandler(this.rbCidade_CheckedChanged);
            // 
            // rbItem
            // 
            this.rbItem.AutoSize = true;
            this.rbItem.Location = new System.Drawing.Point(14, 48);
            this.rbItem.Name = "rbItem";
            this.rbItem.Size = new System.Drawing.Size(53, 20);
            this.rbItem.TabIndex = 2;
            this.rbItem.Text = "Item";
            this.rbItem.UseVisualStyleBackColor = true;
            this.rbItem.CheckedChanged += new System.EventHandler(this.rbItem_CheckedChanged);
            // 
            // rbContratoAluguel
            // 
            this.rbContratoAluguel.AutoSize = true;
            this.rbContratoAluguel.Location = new System.Drawing.Point(73, 22);
            this.rbContratoAluguel.Name = "rbContratoAluguel";
            this.rbContratoAluguel.Size = new System.Drawing.Size(147, 20);
            this.rbContratoAluguel.TabIndex = 1;
            this.rbContratoAluguel.Text = "Contrato de Aluguel";
            this.rbContratoAluguel.UseVisualStyleBackColor = true;
            this.rbContratoAluguel.CheckedChanged += new System.EventHandler(this.rbContratoAluguel_CheckedChanged);
            // 
            // rbDescricao
            // 
            this.rbDescricao.AutoSize = true;
            this.rbDescricao.Checked = true;
            this.rbDescricao.Location = new System.Drawing.Point(146, 48);
            this.rbDescricao.Name = "rbDescricao";
            this.rbDescricao.Size = new System.Drawing.Size(83, 20);
            this.rbDescricao.TabIndex = 4;
            this.rbDescricao.TabStop = true;
            this.rbDescricao.Text = "Descrição";
            this.rbDescricao.UseVisualStyleBackColor = true;
            this.rbDescricao.CheckedChanged += new System.EventHandler(this.rbDescricao_CheckedChanged);
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Location = new System.Drawing.Point(28, 22);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(39, 20);
            this.rbID.TabIndex = 0;
            this.rbID.Text = "ID";
            this.rbID.UseVisualStyleBackColor = true;
            this.rbID.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(570, 433);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(239, 68);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.lblInfo);
            this.gpbResultado.Controls.Add(this.dgvResultado);
            this.gpbResultado.Location = new System.Drawing.Point(12, 109);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(797, 316);
            this.gpbResultado.TabIndex = 2;
            this.gpbResultado.TabStop = false;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstoqueLocalidadeID,
            this.EstoqueLocalidadeDescricao,
            this.EstoqueLocalidadeEndereco,
            this.CidadeNome,
            this.ContratoAluguelID});
            this.dgvResultado.Location = new System.Drawing.Point(7, 38);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(784, 272);
            this.dgvResultado.TabIndex = 0;
            this.dgvResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResultado_CellDoubleClick);
            this.dgvResultado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvResultado_CellFormatting);
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
            // CidadeNome
            // 
            this.CidadeNome.DataPropertyName = "Cidade.CidadeNome";
            this.CidadeNome.HeaderText = "Cidade";
            this.CidadeNome.Name = "CidadeNome";
            this.CidadeNome.ReadOnly = true;
            this.CidadeNome.Width = 160;
            // 
            // ContratoAluguelID
            // 
            this.ContratoAluguelID.DataPropertyName = "ContratoAluguel.ContratoAluguelID";
            this.ContratoAluguelID.HeaderText = "Contrato";
            this.ContratoAluguelID.Name = "ContratoAluguelID";
            this.ContratoAluguelID.ReadOnly = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblInfo.Location = new System.Drawing.Point(6, 19);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(382, 16);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "De um duplo clique na linha desejada para abrir mais detalhes...";
            // 
            // frmConsultaEstoqueLocalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(845, 592);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultaEstoqueLocalidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaEstoqueLocalidade";
            this.Load += new System.EventHandler(this.FrmConsultaEstoqueLocalidade_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panelInside.ResumeLayout(false);
            this.gpbItem.ResumeLayout(false);
            this.gpbItem.PerformLayout();
            this.gpbContratoAluguel.ResumeLayout(false);
            this.gpbContratoAluguel.PerformLayout();
            this.gpbDescricao.ResumeLayout(false);
            this.gpbDescricao.PerformLayout();
            this.gpbID.ResumeLayout(false);
            this.gpbID.PerformLayout();
            this.gpbCidade.ResumeLayout(false);
            this.gpbCidade.PerformLayout();
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.gpbResultado.ResumeLayout(false);
            this.gpbResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueLocalidadeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueLocalidadeDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueLocalidadeEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidadeNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContratoAluguelID;
        private System.Windows.Forms.GroupBox gpbCidade;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbbCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.RadioButton rbCidade;
        private System.Windows.Forms.RadioButton rbItem;
        private System.Windows.Forms.RadioButton rbContratoAluguel;
        private System.Windows.Forms.RadioButton rbDescricao;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.GroupBox gpbDescricao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.GroupBox gpbContratoAluguel;
        private System.Windows.Forms.TextBox txtContratoAluguel;
        private System.Windows.Forms.Label lblContratoAluguel;
        private System.Windows.Forms.GroupBox gpbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnConsultarContratoAluguel;
        private System.Windows.Forms.GroupBox gpbItem;
        private System.Windows.Forms.Button btnConsultarItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInfo;
    }
}