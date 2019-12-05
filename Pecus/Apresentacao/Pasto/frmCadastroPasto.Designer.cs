namespace Apresentacao.Pasto
{
    partial class frmCadastroPasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroPasto));
            this.panel4 = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPasto = new System.Windows.Forms.TabPage();
            this.panelInside = new System.Windows.Forms.Panel();
            this.gpbContratoAluguel = new System.Windows.Forms.GroupBox();
            this.lblContratoAluguelID = new System.Windows.Forms.Label();
            this.txtContratoAluguelID = new System.Windows.Forms.TextBox();
            this.btnBuscarContrato = new System.Windows.Forms.Button();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.lblHectare = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.ckContrato = new System.Windows.Forms.CheckBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbbCidade = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tabPiquete = new System.Windows.Forms.TabPage();
            this.panelInside2 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbPiquete = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dgvPiquetes = new System.Windows.Forms.DataGridView();
            this.PiqueteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPasto.SuspendLayout();
            this.panelInside.SuspendLayout();
            this.gpbContratoAluguel.SuspendLayout();
            this.gpbDados.SuspendLayout();
            this.tabPiquete.SuspendLayout();
            this.panelInside2.SuspendLayout();
            this.gpbPiquete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.panel4.Controls.Add(this.lblTitulo);
            this.panel4.Controls.Add(this.picExit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 15);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(602, 45);
            this.panel4.TabIndex = 8;
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(559, 4);
            this.picExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(40, 38);
            this.picExit.TabIndex = 4;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.PicExit_Click);
            this.picExit.MouseEnter += new System.EventHandler(this.PicExit_MouseEnter);
            this.picExit.MouseLeave += new System.EventHandler(this.PicExit_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(88)))), ((int)(((byte)(46)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 15);
            this.panel2.TabIndex = 7;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPasto);
            this.tabControl.Controls.Add(this.tabPiquete);
            this.tabControl.Location = new System.Drawing.Point(12, 67);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(578, 551);
            this.tabControl.TabIndex = 0;
            // 
            // tabPasto
            // 
            this.tabPasto.Controls.Add(this.panelInside);
            this.tabPasto.Location = new System.Drawing.Point(4, 25);
            this.tabPasto.Name = "tabPasto";
            this.tabPasto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPasto.Size = new System.Drawing.Size(570, 522);
            this.tabPasto.TabIndex = 0;
            this.tabPasto.Text = "Passo 1";
            this.tabPasto.UseVisualStyleBackColor = true;
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbContratoAluguel);
            this.panelInside.Controls.Add(this.gpbDados);
            this.panelInside.Location = new System.Drawing.Point(8, 40);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(550, 441);
            this.panelInside.TabIndex = 0;
            // 
            // gpbContratoAluguel
            // 
            this.gpbContratoAluguel.Controls.Add(this.lblContratoAluguelID);
            this.gpbContratoAluguel.Controls.Add(this.txtContratoAluguelID);
            this.gpbContratoAluguel.Controls.Add(this.btnBuscarContrato);
            this.gpbContratoAluguel.Location = new System.Drawing.Point(12, 350);
            this.gpbContratoAluguel.Name = "gpbContratoAluguel";
            this.gpbContratoAluguel.Size = new System.Drawing.Size(521, 77);
            this.gpbContratoAluguel.TabIndex = 1;
            this.gpbContratoAluguel.TabStop = false;
            this.gpbContratoAluguel.Text = "Contrato de Aluguel";
            // 
            // lblContratoAluguelID
            // 
            this.lblContratoAluguelID.AutoSize = true;
            this.lblContratoAluguelID.Location = new System.Drawing.Point(74, 33);
            this.lblContratoAluguelID.Name = "lblContratoAluguelID";
            this.lblContratoAluguelID.Size = new System.Drawing.Size(24, 16);
            this.lblContratoAluguelID.TabIndex = 2;
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
            // btnBuscarContrato
            // 
            this.btnBuscarContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarContrato.FlatAppearance.BorderSize = 0;
            this.btnBuscarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarContrato.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarContrato.ForeColor = System.Drawing.Color.White;
            this.btnBuscarContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarContrato.Location = new System.Drawing.Point(263, 20);
            this.btnBuscarContrato.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarContrato.Name = "btnBuscarContrato";
            this.btnBuscarContrato.Size = new System.Drawing.Size(185, 42);
            this.btnBuscarContrato.TabIndex = 1;
            this.btnBuscarContrato.Text = "Buscar Contrato de Aluguel";
            this.btnBuscarContrato.UseVisualStyleBackColor = false;
            this.btnBuscarContrato.Click += new System.EventHandler(this.BtnBuscarContrato_Click);
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.lblHectare);
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
            this.gpbDados.Location = new System.Drawing.Point(12, 15);
            this.gpbDados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbDados.Size = new System.Drawing.Size(521, 328);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Cadastro de Pasto";
            // 
            // lblHectare
            // 
            this.lblHectare.AutoSize = true;
            this.lblHectare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.lblHectare.Location = new System.Drawing.Point(415, 194);
            this.lblHectare.Name = "lblHectare";
            this.lblHectare.Size = new System.Drawing.Size(60, 16);
            this.lblHectare.TabIndex = 9;
            this.lblHectare.Text = "Hectares";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtDescricao.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDescricao.Location = new System.Drawing.Point(39, 55);
            this.txtDescricao.MaxLength = 60;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(422, 132);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.Text = "Aqui você pode descrever observações desejadas como características do pasto, loc" +
    "alização, responsável pelo pasto e muitos outros";
            this.txtDescricao.Enter += new System.EventHandler(this.TxtDescricao_Enter);
            this.txtDescricao.Leave += new System.EventHandler(this.TxtDescricao_Leave);
            // 
            // ckContrato
            // 
            this.ckContrato.AutoSize = true;
            this.ckContrato.Location = new System.Drawing.Point(263, 288);
            this.ckContrato.Name = "ckContrato";
            this.ckContrato.Size = new System.Drawing.Size(92, 20);
            this.ckContrato.TabIndex = 4;
            this.ckContrato.Text = "Arrendado";
            this.ckContrato.UseVisualStyleBackColor = true;
            this.ckContrato.CheckedChanged += new System.EventHandler(this.CkContrato_CheckedChanged);
            // 
            // cbbEstado
            // 
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(221, 225);
            this.cbbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(177, 24);
            this.cbbEstado.TabIndex = 2;
            this.cbbEstado.SelectedIndexChanged += new System.EventHandler(this.CbbEstado_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(117, 228);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 16);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado:";
            // 
            // cbbCidade
            // 
            this.cbbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCidade.FormattingEnabled = true;
            this.cbbCidade.Location = new System.Drawing.Point(221, 257);
            this.cbbCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbCidade.Name = "cbbCidade";
            this.cbbCidade.Size = new System.Drawing.Size(177, 24);
            this.cbbCidade.TabIndex = 3;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(117, 260);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 16);
            this.lblCidade.TabIndex = 8;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtTamanho.Location = new System.Drawing.Point(206, 194);
            this.txtTamanho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTamanho.MaxLength = 22;
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(202, 23);
            this.txtTamanho.TabIndex = 1;
            this.txtTamanho.Enter += new System.EventHandler(this.TxtDescricao_Enter);
            this.txtTamanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTamanho_KeyPress);
            this.txtTamanho.Leave += new System.EventHandler(this.TxtDescricao_Leave);
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(112, 197);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(67, 16);
            this.lblTamanho.TabIndex = 6;
            this.lblTamanho.Text = "Tamanho:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(36, 36);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 16);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição:";
            // 
            // tabPiquete
            // 
            this.tabPiquete.Controls.Add(this.panelInside2);
            this.tabPiquete.Location = new System.Drawing.Point(4, 25);
            this.tabPiquete.Name = "tabPiquete";
            this.tabPiquete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPiquete.Size = new System.Drawing.Size(570, 522);
            this.tabPiquete.TabIndex = 1;
            this.tabPiquete.Text = "Passo 2";
            this.tabPiquete.UseVisualStyleBackColor = true;
            // 
            // panelInside2
            // 
            this.panelInside2.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside2.Controls.Add(this.btnCadastrar);
            this.panelInside2.Controls.Add(this.gpbPiquete);
            this.panelInside2.Location = new System.Drawing.Point(58, 6);
            this.panelInside2.Name = "panelInside2";
            this.panelInside2.Size = new System.Drawing.Size(449, 510);
            this.panelInside2.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(110, 438);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(239, 68);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // gpbPiquete
            // 
            this.gpbPiquete.Controls.Add(this.btnAdicionar);
            this.gpbPiquete.Controls.Add(this.btnRemover);
            this.gpbPiquete.Controls.Add(this.dgvPiquetes);
            this.gpbPiquete.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPiquete.Location = new System.Drawing.Point(13, 13);
            this.gpbPiquete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbPiquete.Name = "gpbPiquete";
            this.gpbPiquete.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbPiquete.Size = new System.Drawing.Size(423, 417);
            this.gpbPiquete.TabIndex = 0;
            this.gpbPiquete.TabStop = false;
            this.gpbPiquete.Text = "Cadastro de Piquetes";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(6, 372);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(132, 37);
            this.btnAdicionar.TabIndex = 1;
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
            this.btnRemover.Location = new System.Drawing.Point(285, 372);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(132, 37);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // dgvPiquetes
            // 
            this.dgvPiquetes.AllowUserToAddRows = false;
            this.dgvPiquetes.AllowUserToDeleteRows = false;
            this.dgvPiquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPiquetes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PiqueteID,
            this.Descricao});
            this.dgvPiquetes.Location = new System.Drawing.Point(6, 23);
            this.dgvPiquetes.Name = "dgvPiquetes";
            this.dgvPiquetes.ReadOnly = true;
            this.dgvPiquetes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPiquetes.Size = new System.Drawing.Size(411, 342);
            this.dgvPiquetes.TabIndex = 0;
            // 
            // PiqueteID
            // 
            this.PiqueteID.DataPropertyName = "PiqueteID";
            this.PiqueteID.HeaderText = "ID";
            this.PiqueteID.Name = "PiqueteID";
            this.PiqueteID.ReadOnly = true;
            this.PiqueteID.Width = 88;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "PiqueteDescricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 280;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(177, 24);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Cadastro de Pasto";
            // 
            // frmCadastroPasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(602, 627);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCadastroPasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroPasto";
            this.Load += new System.EventHandler(this.FrmCadastroPasto_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPasto.ResumeLayout(false);
            this.panelInside.ResumeLayout(false);
            this.gpbContratoAluguel.ResumeLayout(false);
            this.gpbContratoAluguel.PerformLayout();
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.tabPiquete.ResumeLayout(false);
            this.panelInside2.ResumeLayout(false);
            this.gpbPiquete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiquetes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPasto;
        private System.Windows.Forms.TabPage tabPiquete;
        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.GroupBox gpbContratoAluguel;
        private System.Windows.Forms.Label lblContratoAluguelID;
        private System.Windows.Forms.TextBox txtContratoAluguelID;
        private System.Windows.Forms.Button btnBuscarContrato;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.CheckBox ckContrato;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbbCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Panel panelInside2;
        private System.Windows.Forms.GroupBox gpbPiquete;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dgvPiquetes;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblHectare;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiqueteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.Label lblTitulo;
    }
}