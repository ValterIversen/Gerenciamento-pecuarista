namespace Apresentacao.EstoqueLocalidade
{
    partial class frmAlterarEstoqueLocalidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarEstoqueLocalidade));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelInside = new System.Windows.Forms.Panel();
            this.gpbContratoAluguel = new System.Windows.Forms.GroupBox();
            this.lblContratoAluguelID = new System.Windows.Forms.Label();
            this.txtContratoAluguelID = new System.Windows.Forms.TextBox();
            this.btnBuscarContrato = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gpbEstoque = new System.Windows.Forms.GroupBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnAdicionarEstoque = new System.Windows.Forms.Button();
            this.gpbItemsEstocados = new System.Windows.Forms.GroupBox();
            this.lblEstoqueInfo = new System.Windows.Forms.Label();
            this.dgvEstoques = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.ckbContratoAluguel = new System.Windows.Forms.CheckBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbbCidade = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panelInside.SuspendLayout();
            this.gpbContratoAluguel.SuspendLayout();
            this.gpbEstoque.SuspendLayout();
            this.gpbItemsEstocados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoques)).BeginInit();
            this.gpbDados.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(867, 45);
            this.panel2.TabIndex = 39;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(221, 24);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Alteração de Armazém";
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(824, 4);
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
            this.panel4.Size = new System.Drawing.Size(867, 15);
            this.panel4.TabIndex = 40;
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbContratoAluguel);
            this.panelInside.Controls.Add(this.btnSalvar);
            this.panelInside.Controls.Add(this.gpbEstoque);
            this.panelInside.Controls.Add(this.gpbItemsEstocados);
            this.panelInside.Controls.Add(this.gpbDados);
            this.panelInside.Location = new System.Drawing.Point(12, 67);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(842, 556);
            this.panelInside.TabIndex = 0;
            // 
            // gpbContratoAluguel
            // 
            this.gpbContratoAluguel.Controls.Add(this.lblContratoAluguelID);
            this.gpbContratoAluguel.Controls.Add(this.txtContratoAluguelID);
            this.gpbContratoAluguel.Controls.Add(this.btnBuscarContrato);
            this.gpbContratoAluguel.Location = new System.Drawing.Point(618, 12);
            this.gpbContratoAluguel.Name = "gpbContratoAluguel";
            this.gpbContratoAluguel.Size = new System.Drawing.Size(213, 113);
            this.gpbContratoAluguel.TabIndex = 2;
            this.gpbContratoAluguel.TabStop = false;
            this.gpbContratoAluguel.Text = "Contrato de Aluguel";
            // 
            // lblContratoAluguelID
            // 
            this.lblContratoAluguelID.AutoSize = true;
            this.lblContratoAluguelID.Location = new System.Drawing.Point(31, 26);
            this.lblContratoAluguelID.Name = "lblContratoAluguelID";
            this.lblContratoAluguelID.Size = new System.Drawing.Size(24, 16);
            this.lblContratoAluguelID.TabIndex = 1;
            this.lblContratoAluguelID.Text = "ID:";
            // 
            // txtContratoAluguelID
            // 
            this.txtContratoAluguelID.Enabled = false;
            this.txtContratoAluguelID.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtContratoAluguelID.Location = new System.Drawing.Point(61, 23);
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
            this.btnBuscarContrato.Location = new System.Drawing.Point(14, 54);
            this.btnBuscarContrato.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarContrato.Name = "btnBuscarContrato";
            this.btnBuscarContrato.Size = new System.Drawing.Size(185, 42);
            this.btnBuscarContrato.TabIndex = 1;
            this.btnBuscarContrato.Text = "Buscar Contrato de Aluguel";
            this.btnBuscarContrato.UseVisualStyleBackColor = false;
            this.btnBuscarContrato.Click += new System.EventHandler(this.BtnBuscarContrato_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(592, 476);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(239, 68);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // gpbEstoque
            // 
            this.gpbEstoque.Controls.Add(this.lblItem);
            this.gpbEstoque.Controls.Add(this.txtItem);
            this.gpbEstoque.Controls.Add(this.btnBuscarItem);
            this.gpbEstoque.Controls.Add(this.txtQuantidade);
            this.gpbEstoque.Controls.Add(this.lblQuantidade);
            this.gpbEstoque.Controls.Add(this.btnAdicionarEstoque);
            this.gpbEstoque.Location = new System.Drawing.Point(315, 13);
            this.gpbEstoque.Name = "gpbEstoque";
            this.gpbEstoque.Size = new System.Drawing.Size(297, 193);
            this.gpbEstoque.TabIndex = 1;
            this.gpbEstoque.TabStop = false;
            this.gpbEstoque.Text = "Cadastro de Estoque";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(51, 25);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(72, 16);
            this.lblItem.TabIndex = 14;
            this.lblItem.Text = "ID do item:";
            // 
            // txtItem
            // 
            this.txtItem.Enabled = false;
            this.txtItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtItem.Location = new System.Drawing.Point(129, 22);
            this.txtItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(110, 23);
            this.txtItem.TabIndex = 0;
            // 
            // btnBuscarItem
            // 
            this.btnBuscarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarItem.FlatAppearance.BorderSize = 0;
            this.btnBuscarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarItem.ForeColor = System.Drawing.Color.White;
            this.btnBuscarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarItem.Location = new System.Drawing.Point(58, 53);
            this.btnBuscarItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(185, 42);
            this.btnBuscarItem.TabIndex = 1;
            this.btnBuscarItem.Text = "Buscar Item";
            this.btnBuscarItem.UseVisualStyleBackColor = false;
            this.btnBuscarItem.Click += new System.EventHandler(this.BtnBuscarItem_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtQuantidade.Location = new System.Drawing.Point(120, 103);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantidade.MaxLength = 10;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(136, 23);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantidade_KeyPress_1);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(32, 106);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(82, 16);
            this.lblQuantidade.TabIndex = 11;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // btnAdicionarEstoque
            // 
            this.btnAdicionarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnAdicionarEstoque.FlatAppearance.BorderSize = 0;
            this.btnAdicionarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarEstoque.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdicionarEstoque.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarEstoque.Location = new System.Drawing.Point(58, 138);
            this.btnAdicionarEstoque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionarEstoque.Name = "btnAdicionarEstoque";
            this.btnAdicionarEstoque.Size = new System.Drawing.Size(185, 42);
            this.btnAdicionarEstoque.TabIndex = 3;
            this.btnAdicionarEstoque.Text = "Adicionar Estoque";
            this.btnAdicionarEstoque.UseVisualStyleBackColor = false;
            this.btnAdicionarEstoque.Click += new System.EventHandler(this.BtnAdicionarEstoque_Click);
            // 
            // gpbItemsEstocados
            // 
            this.gpbItemsEstocados.Controls.Add(this.lblEstoqueInfo);
            this.gpbItemsEstocados.Controls.Add(this.dgvEstoques);
            this.gpbItemsEstocados.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbItemsEstocados.Location = new System.Drawing.Point(12, 234);
            this.gpbItemsEstocados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbItemsEstocados.Name = "gpbItemsEstocados";
            this.gpbItemsEstocados.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbItemsEstocados.Size = new System.Drawing.Size(690, 234);
            this.gpbItemsEstocados.TabIndex = 3;
            this.gpbItemsEstocados.TabStop = false;
            this.gpbItemsEstocados.Text = "Estoques";
            // 
            // lblEstoqueInfo
            // 
            this.lblEstoqueInfo.AutoSize = true;
            this.lblEstoqueInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEstoqueInfo.Location = new System.Drawing.Point(590, 23);
            this.lblEstoqueInfo.Name = "lblEstoqueInfo";
            this.lblEstoqueInfo.Size = new System.Drawing.Size(92, 64);
            this.lblEstoqueInfo.TabIndex = 1;
            this.lblEstoqueInfo.Text = "* Para alterar \r\num estoque, \r\nde duplo click \r\nno desejado.";
            // 
            // dgvEstoques
            // 
            this.dgvEstoques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemDescricao,
            this.EstoqueQuantidade,
            this.EstoqueAtivo});
            this.dgvEstoques.Location = new System.Drawing.Point(6, 23);
            this.dgvEstoques.Name = "dgvEstoques";
            this.dgvEstoques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoques.Size = new System.Drawing.Size(578, 200);
            this.dgvEstoques.TabIndex = 0;
            this.dgvEstoques.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEstoques_CellDoubleClick);
            this.dgvEstoques.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvEstoques_CellFormatting);
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "Item.ItemID";
            this.ItemID.HeaderText = "ID do Item";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Width = 130;
            // 
            // ItemDescricao
            // 
            this.ItemDescricao.DataPropertyName = "Item.ItemDescricao";
            this.ItemDescricao.HeaderText = "Descrição";
            this.ItemDescricao.Name = "ItemDescricao";
            this.ItemDescricao.ReadOnly = true;
            this.ItemDescricao.Width = 200;
            // 
            // EstoqueQuantidade
            // 
            this.EstoqueQuantidade.DataPropertyName = "EstoqueQuantidade";
            this.EstoqueQuantidade.HeaderText = "Quantidade";
            this.EstoqueQuantidade.Name = "EstoqueQuantidade";
            this.EstoqueQuantidade.ReadOnly = true;
            this.EstoqueQuantidade.Width = 135;
            // 
            // EstoqueAtivo
            // 
            this.EstoqueAtivo.DataPropertyName = "EstoqueAtivo";
            this.EstoqueAtivo.HeaderText = "Ativo";
            this.EstoqueAtivo.Name = "EstoqueAtivo";
            this.EstoqueAtivo.ReadOnly = true;
            this.EstoqueAtivo.Width = 70;
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.ckbContratoAluguel);
            this.gpbDados.Controls.Add(this.cbbEstado);
            this.gpbDados.Controls.Add(this.lblEstado);
            this.gpbDados.Controls.Add(this.cbbCidade);
            this.gpbDados.Controls.Add(this.lblCidade);
            this.gpbDados.Controls.Add(this.txtDescricao);
            this.gpbDados.Controls.Add(this.txtEndereco);
            this.gpbDados.Controls.Add(this.lblEndereco);
            this.gpbDados.Controls.Add(this.lblDescricao);
            this.gpbDados.Location = new System.Drawing.Point(12, 13);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(297, 214);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Alteração de Armazém";
            // 
            // ckbContratoAluguel
            // 
            this.ckbContratoAluguel.AutoSize = true;
            this.ckbContratoAluguel.Location = new System.Drawing.Point(134, 187);
            this.ckbContratoAluguel.Name = "ckbContratoAluguel";
            this.ckbContratoAluguel.Size = new System.Drawing.Size(92, 20);
            this.ckbContratoAluguel.TabIndex = 4;
            this.ckbContratoAluguel.Text = "Arrendado";
            this.ckbContratoAluguel.UseVisualStyleBackColor = true;
            // 
            // cbbEstado
            // 
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(90, 124);
            this.cbbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(177, 24);
            this.cbbEstado.TabIndex = 2;
            this.cbbEstado.SelectedIndexChanged += new System.EventHandler(this.CbbEstado_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(11, 127);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 16);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado:";
            // 
            // cbbCidade
            // 
            this.cbbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCidade.FormattingEnabled = true;
            this.cbbCidade.Location = new System.Drawing.Point(90, 156);
            this.cbbCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbCidade.Name = "cbbCidade";
            this.cbbCidade.Size = new System.Drawing.Size(177, 24);
            this.cbbCidade.TabIndex = 3;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(11, 159);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 16);
            this.lblCidade.TabIndex = 8;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(80, 26);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(202, 60);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.Text = "";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtEndereco.Location = new System.Drawing.Point(80, 93);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndereco.MaxLength = 60;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(202, 23);
            this.txtEndereco.TabIndex = 1;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(6, 96);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(67, 16);
            this.lblEndereco.TabIndex = 6;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 29);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 16);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição:";
            // 
            // frmAlterarEstoqueLocalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(867, 635);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAlterarEstoqueLocalidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlterarEstoqueLocalidade";
            this.Load += new System.EventHandler(this.FrmAlterarEstoqueLocalidade_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panelInside.ResumeLayout(false);
            this.gpbContratoAluguel.ResumeLayout(false);
            this.gpbContratoAluguel.PerformLayout();
            this.gpbEstoque.ResumeLayout(false);
            this.gpbEstoque.PerformLayout();
            this.gpbItemsEstocados.ResumeLayout(false);
            this.gpbItemsEstocados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoques)).EndInit();
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.GroupBox gpbContratoAluguel;
        private System.Windows.Forms.Label lblContratoAluguelID;
        private System.Windows.Forms.TextBox txtContratoAluguelID;
        private System.Windows.Forms.Button btnBuscarContrato;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gpbEstoque;
        private System.Windows.Forms.Button btnAdicionarEstoque;
        private System.Windows.Forms.GroupBox gpbItemsEstocados;
        private System.Windows.Forms.Label lblEstoqueInfo;
        private System.Windows.Forms.DataGridView dgvEstoques;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.CheckBox ckbContratoAluguel;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbbCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueQuantidade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EstoqueAtivo;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblTitulo;
    }
}