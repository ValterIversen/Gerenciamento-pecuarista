namespace Apresentacao.Vendas
{
    partial class frmCadastroVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroVenda));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelInside = new System.Windows.Forms.Panel();
            this.gpbAnimal = new System.Windows.Forms.GroupBox();
            this.lblInformeValorAnimal = new System.Windows.Forms.Label();
            this.txtValorAnimal = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnAdicionarIndividual = new System.Windows.Forms.Button();
            this.lblAnimalID = new System.Windows.Forms.Label();
            this.txtAnimalID = new System.Windows.Forms.TextBox();
            this.btnConsultarAnimal = new System.Windows.Forms.Button();
            this.gpbOutroPiquete = new System.Windows.Forms.GroupBox();
            this.lblValorANimalPiquete = new System.Windows.Forms.Label();
            this.txtValorAnimalOutroPiquete = new System.Windows.Forms.TextBox();
            this.lblValorAnimalOutroPiquete = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblPiqueteOutroID = new System.Windows.Forms.Label();
            this.dgvAnimaisOutroPiquete = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPiqueteOutroID = new System.Windows.Forms.TextBox();
            this.btnBuscarPiquete = new System.Windows.Forms.Button();
            this.gpbAnimaisVenda = new System.Windows.Forms.GroupBox();
            this.dgvAnimais = new System.Windows.Forms.DataGridView();
            this.AnimalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PiqueteDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RacaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemover = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelInside2 = new System.Windows.Forms.Panel();
            this.gpbPessoa = new System.Windows.Forms.GroupBox();
            this.gpbPessoaJuridica = new System.Windows.Forms.GroupBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblNomeFicticio = new System.Windows.Forms.Label();
            this.txtNomeFicticio = new System.Windows.Forms.TextBox();
            this.gpbPessoaFisica = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnBuscarPessoa = new System.Windows.Forms.Button();
            this.txtPessoa = new System.Windows.Forms.TextBox();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelInside3 = new System.Windows.Forms.Panel();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblQuantidadeInfo = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelInside.SuspendLayout();
            this.gpbAnimal.SuspendLayout();
            this.gpbOutroPiquete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimaisOutroPiquete)).BeginInit();
            this.gpbAnimaisVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimais)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panelInside2.SuspendLayout();
            this.gpbPessoa.SuspendLayout();
            this.gpbPessoaJuridica.SuspendLayout();
            this.gpbPessoaFisica.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelInside3.SuspendLayout();
            this.gpbDados.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 67);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1110, 666);
            this.tabControl.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelInside);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1102, 637);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Passo 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbAnimal);
            this.panelInside.Controls.Add(this.gpbOutroPiquete);
            this.panelInside.Controls.Add(this.gpbAnimaisVenda);
            this.panelInside.Location = new System.Drawing.Point(15, 18);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(1073, 609);
            this.panelInside.TabIndex = 0;
            // 
            // gpbAnimal
            // 
            this.gpbAnimal.Controls.Add(this.lblInformeValorAnimal);
            this.gpbAnimal.Controls.Add(this.txtValorAnimal);
            this.gpbAnimal.Controls.Add(this.lblValor);
            this.gpbAnimal.Controls.Add(this.btnAdicionarIndividual);
            this.gpbAnimal.Controls.Add(this.lblAnimalID);
            this.gpbAnimal.Controls.Add(this.txtAnimalID);
            this.gpbAnimal.Controls.Add(this.btnConsultarAnimal);
            this.gpbAnimal.Location = new System.Drawing.Point(540, 14);
            this.gpbAnimal.Name = "gpbAnimal";
            this.gpbAnimal.Size = new System.Drawing.Size(521, 153);
            this.gpbAnimal.TabIndex = 1;
            this.gpbAnimal.TabStop = false;
            this.gpbAnimal.Text = "Animal individual";
            // 
            // lblInformeValorAnimal
            // 
            this.lblInformeValorAnimal.AutoSize = true;
            this.lblInformeValorAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.lblInformeValorAnimal.Location = new System.Drawing.Point(339, 78);
            this.lblInformeValorAnimal.Name = "lblInformeValorAnimal";
            this.lblInformeValorAnimal.Size = new System.Drawing.Size(159, 16);
            this.lblInformeValorAnimal.TabIndex = 46;
            this.lblInformeValorAnimal.Text = "Por favor, informe o valor";
            this.lblInformeValorAnimal.Visible = false;
            // 
            // txtValorAnimal
            // 
            this.txtValorAnimal.Location = new System.Drawing.Point(207, 78);
            this.txtValorAnimal.MaxLength = 10;
            this.txtValorAnimal.Name = "txtValorAnimal";
            this.txtValorAnimal.Size = new System.Drawing.Size(126, 23);
            this.txtValorAnimal.TabIndex = 2;
            this.txtValorAnimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorAnimal_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(159, 81);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(42, 16);
            this.lblValor.TabIndex = 44;
            this.lblValor.Text = "Valor:";
            // 
            // btnAdicionarIndividual
            // 
            this.btnAdicionarIndividual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnAdicionarIndividual.FlatAppearance.BorderSize = 0;
            this.btnAdicionarIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarIndividual.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdicionarIndividual.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarIndividual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarIndividual.Location = new System.Drawing.Point(184, 108);
            this.btnAdicionarIndividual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionarIndividual.Name = "btnAdicionarIndividual";
            this.btnAdicionarIndividual.Size = new System.Drawing.Size(132, 37);
            this.btnAdicionarIndividual.TabIndex = 3;
            this.btnAdicionarIndividual.Text = "Adicionar";
            this.btnAdicionarIndividual.UseVisualStyleBackColor = false;
            this.btnAdicionarIndividual.Click += new System.EventHandler(this.btnAdicionarIndividual_Click);
            // 
            // lblAnimalID
            // 
            this.lblAnimalID.AutoSize = true;
            this.lblAnimalID.Location = new System.Drawing.Point(74, 33);
            this.lblAnimalID.Name = "lblAnimalID";
            this.lblAnimalID.Size = new System.Drawing.Size(24, 16);
            this.lblAnimalID.TabIndex = 16;
            this.lblAnimalID.Text = "ID:";
            // 
            // txtAnimalID
            // 
            this.txtAnimalID.Enabled = false;
            this.txtAnimalID.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtAnimalID.Location = new System.Drawing.Point(104, 30);
            this.txtAnimalID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnimalID.Name = "txtAnimalID";
            this.txtAnimalID.Size = new System.Drawing.Size(110, 23);
            this.txtAnimalID.TabIndex = 0;
            this.txtAnimalID.Text = "0";
            // 
            // btnConsultarAnimal
            // 
            this.btnConsultarAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnConsultarAnimal.FlatAppearance.BorderSize = 0;
            this.btnConsultarAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarAnimal.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultarAnimal.ForeColor = System.Drawing.Color.White;
            this.btnConsultarAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarAnimal.Location = new System.Drawing.Point(263, 20);
            this.btnConsultarAnimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultarAnimal.Name = "btnConsultarAnimal";
            this.btnConsultarAnimal.Size = new System.Drawing.Size(185, 42);
            this.btnConsultarAnimal.TabIndex = 1;
            this.btnConsultarAnimal.Text = "Buscar Animal";
            this.btnConsultarAnimal.UseVisualStyleBackColor = false;
            this.btnConsultarAnimal.Click += new System.EventHandler(this.btnConsultarAnimal_Click);
            // 
            // gpbOutroPiquete
            // 
            this.gpbOutroPiquete.Controls.Add(this.lblValorANimalPiquete);
            this.gpbOutroPiquete.Controls.Add(this.txtValorAnimalOutroPiquete);
            this.gpbOutroPiquete.Controls.Add(this.lblValorAnimalOutroPiquete);
            this.gpbOutroPiquete.Controls.Add(this.btnAdicionar);
            this.gpbOutroPiquete.Controls.Add(this.lblPiqueteOutroID);
            this.gpbOutroPiquete.Controls.Add(this.dgvAnimaisOutroPiquete);
            this.gpbOutroPiquete.Controls.Add(this.txtPiqueteOutroID);
            this.gpbOutroPiquete.Controls.Add(this.btnBuscarPiquete);
            this.gpbOutroPiquete.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOutroPiquete.Location = new System.Drawing.Point(540, 174);
            this.gpbOutroPiquete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbOutroPiquete.Name = "gpbOutroPiquete";
            this.gpbOutroPiquete.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbOutroPiquete.Size = new System.Drawing.Size(521, 425);
            this.gpbOutroPiquete.TabIndex = 0;
            this.gpbOutroPiquete.TabStop = false;
            this.gpbOutroPiquete.Text = "Animais de um piquete";
            // 
            // lblValorANimalPiquete
            // 
            this.lblValorANimalPiquete.AutoSize = true;
            this.lblValorANimalPiquete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.lblValorANimalPiquete.Location = new System.Drawing.Point(349, 348);
            this.lblValorANimalPiquete.Name = "lblValorANimalPiquete";
            this.lblValorANimalPiquete.Size = new System.Drawing.Size(159, 16);
            this.lblValorANimalPiquete.TabIndex = 47;
            this.lblValorANimalPiquete.Text = "Por favor, informe o valor";
            this.lblValorANimalPiquete.Visible = false;
            // 
            // txtValorAnimalOutroPiquete
            // 
            this.txtValorAnimalOutroPiquete.Location = new System.Drawing.Point(217, 348);
            this.txtValorAnimalOutroPiquete.MaxLength = 10;
            this.txtValorAnimalOutroPiquete.Name = "txtValorAnimalOutroPiquete";
            this.txtValorAnimalOutroPiquete.Size = new System.Drawing.Size(126, 23);
            this.txtValorAnimalOutroPiquete.TabIndex = 4;
            this.txtValorAnimalOutroPiquete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorAnimalOutroPiquete_KeyPress);
            // 
            // lblValorAnimalOutroPiquete
            // 
            this.lblValorAnimalOutroPiquete.AutoSize = true;
            this.lblValorAnimalOutroPiquete.Location = new System.Drawing.Point(169, 351);
            this.lblValorAnimalOutroPiquete.Name = "lblValorAnimalOutroPiquete";
            this.lblValorAnimalOutroPiquete.Size = new System.Drawing.Size(42, 16);
            this.lblValorAnimalOutroPiquete.TabIndex = 44;
            this.lblValorAnimalOutroPiquete.Text = "Valor:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(201, 378);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(132, 37);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblPiqueteOutroID
            // 
            this.lblPiqueteOutroID.AutoSize = true;
            this.lblPiqueteOutroID.Location = new System.Drawing.Point(74, 36);
            this.lblPiqueteOutroID.Name = "lblPiqueteOutroID";
            this.lblPiqueteOutroID.Size = new System.Drawing.Size(24, 16);
            this.lblPiqueteOutroID.TabIndex = 19;
            this.lblPiqueteOutroID.Text = "ID:";
            // 
            // dgvAnimaisOutroPiquete
            // 
            this.dgvAnimaisOutroPiquete.AllowUserToAddRows = false;
            this.dgvAnimaisOutroPiquete.AllowUserToDeleteRows = false;
            this.dgvAnimaisOutroPiquete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimaisOutroPiquete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvAnimaisOutroPiquete.Location = new System.Drawing.Point(6, 72);
            this.dgvAnimaisOutroPiquete.Name = "dgvAnimaisOutroPiquete";
            this.dgvAnimaisOutroPiquete.ReadOnly = true;
            this.dgvAnimaisOutroPiquete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimaisOutroPiquete.Size = new System.Drawing.Size(509, 270);
            this.dgvAnimaisOutroPiquete.TabIndex = 3;
            this.dgvAnimaisOutroPiquete.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAnimaisOutroPiquete_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AnimalID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AnimalIdentificador";
            this.dataGridViewTextBoxColumn2.HeaderText = "Identificador";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AnimalDescricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Piquete.PiqueteDescricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Piquete";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 180;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Raca.RacaNome";
            this.dataGridViewTextBoxColumn5.HeaderText = "Raça";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 180;
            // 
            // txtPiqueteOutroID
            // 
            this.txtPiqueteOutroID.Enabled = false;
            this.txtPiqueteOutroID.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtPiqueteOutroID.Location = new System.Drawing.Point(104, 33);
            this.txtPiqueteOutroID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPiqueteOutroID.Name = "txtPiqueteOutroID";
            this.txtPiqueteOutroID.Size = new System.Drawing.Size(110, 23);
            this.txtPiqueteOutroID.TabIndex = 1;
            this.txtPiqueteOutroID.Text = "0";
            // 
            // btnBuscarPiquete
            // 
            this.btnBuscarPiquete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarPiquete.FlatAppearance.BorderSize = 0;
            this.btnBuscarPiquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPiquete.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPiquete.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPiquete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPiquete.Location = new System.Drawing.Point(263, 23);
            this.btnBuscarPiquete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarPiquete.Name = "btnBuscarPiquete";
            this.btnBuscarPiquete.Size = new System.Drawing.Size(185, 42);
            this.btnBuscarPiquete.TabIndex = 2;
            this.btnBuscarPiquete.Text = "Buscar Piquete";
            this.btnBuscarPiquete.UseVisualStyleBackColor = false;
            this.btnBuscarPiquete.Click += new System.EventHandler(this.btnBuscarPiquete_Click);
            // 
            // gpbAnimaisVenda
            // 
            this.gpbAnimaisVenda.Controls.Add(this.dgvAnimais);
            this.gpbAnimaisVenda.Controls.Add(this.btnRemover);
            this.gpbAnimaisVenda.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAnimaisVenda.Location = new System.Drawing.Point(13, 44);
            this.gpbAnimaisVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbAnimaisVenda.Name = "gpbAnimaisVenda";
            this.gpbAnimaisVenda.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbAnimaisVenda.Size = new System.Drawing.Size(521, 528);
            this.gpbAnimaisVenda.TabIndex = 0;
            this.gpbAnimaisVenda.TabStop = false;
            this.gpbAnimaisVenda.Text = "Animais da venda";
            // 
            // dgvAnimais
            // 
            this.dgvAnimais.AllowUserToAddRows = false;
            this.dgvAnimais.AllowUserToDeleteRows = false;
            this.dgvAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnimalID,
            this.AnimalIdentificador,
            this.AnimalDescricao,
            this.PiqueteDescricao,
            this.RacaNome});
            this.dgvAnimais.Location = new System.Drawing.Point(6, 33);
            this.dgvAnimais.Name = "dgvAnimais";
            this.dgvAnimais.ReadOnly = true;
            this.dgvAnimais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimais.Size = new System.Drawing.Size(509, 442);
            this.dgvAnimais.TabIndex = 0;
            this.dgvAnimais.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAnimais_CellFormatting_1);
            // 
            // AnimalID
            // 
            this.AnimalID.DataPropertyName = "AnimalID";
            this.AnimalID.HeaderText = "ID";
            this.AnimalID.Name = "AnimalID";
            this.AnimalID.ReadOnly = true;
            this.AnimalID.Width = 70;
            // 
            // AnimalIdentificador
            // 
            this.AnimalIdentificador.DataPropertyName = "AnimalIdentificador";
            this.AnimalIdentificador.HeaderText = "Identificador";
            this.AnimalIdentificador.Name = "AnimalIdentificador";
            this.AnimalIdentificador.ReadOnly = true;
            this.AnimalIdentificador.Width = 90;
            // 
            // AnimalDescricao
            // 
            this.AnimalDescricao.DataPropertyName = "AnimalDescricao";
            this.AnimalDescricao.HeaderText = "Descricao";
            this.AnimalDescricao.Name = "AnimalDescricao";
            this.AnimalDescricao.ReadOnly = true;
            this.AnimalDescricao.Width = 200;
            // 
            // PiqueteDescricao
            // 
            this.PiqueteDescricao.DataPropertyName = "Piquete.PiqueteDescricao";
            this.PiqueteDescricao.HeaderText = "Piquete";
            this.PiqueteDescricao.Name = "PiqueteDescricao";
            this.PiqueteDescricao.ReadOnly = true;
            this.PiqueteDescricao.Width = 180;
            // 
            // RacaNome
            // 
            this.RacaNome.DataPropertyName = "Raca.RacaNome";
            this.RacaNome.HeaderText = "Raça";
            this.RacaNome.Name = "RacaNome";
            this.RacaNome.ReadOnly = true;
            this.RacaNome.Width = 180;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(186, 483);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(132, 37);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panelInside2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1102, 637);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Passo2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelInside2
            // 
            this.panelInside2.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside2.Controls.Add(this.gpbPessoa);
            this.panelInside2.Location = new System.Drawing.Point(331, 147);
            this.panelInside2.Name = "panelInside2";
            this.panelInside2.Size = new System.Drawing.Size(412, 306);
            this.panelInside2.TabIndex = 40;
            // 
            // gpbPessoa
            // 
            this.gpbPessoa.Controls.Add(this.gpbPessoaJuridica);
            this.gpbPessoa.Controls.Add(this.gpbPessoaFisica);
            this.gpbPessoa.Controls.Add(this.btnBuscarPessoa);
            this.gpbPessoa.Controls.Add(this.txtPessoa);
            this.gpbPessoa.Controls.Add(this.lblPessoa);
            this.gpbPessoa.Location = new System.Drawing.Point(15, 16);
            this.gpbPessoa.Name = "gpbPessoa";
            this.gpbPessoa.Size = new System.Drawing.Size(382, 277);
            this.gpbPessoa.TabIndex = 46;
            this.gpbPessoa.TabStop = false;
            this.gpbPessoa.Text = "Vendedor dos animais";
            // 
            // gpbPessoaJuridica
            // 
            this.gpbPessoaJuridica.Controls.Add(this.lblRazaoSocial);
            this.gpbPessoaJuridica.Controls.Add(this.txtRazaoSocial);
            this.gpbPessoaJuridica.Controls.Add(this.txtCNPJ);
            this.gpbPessoaJuridica.Controls.Add(this.lblCNPJ);
            this.gpbPessoaJuridica.Controls.Add(this.lblNomeFicticio);
            this.gpbPessoaJuridica.Controls.Add(this.txtNomeFicticio);
            this.gpbPessoaJuridica.Enabled = false;
            this.gpbPessoaJuridica.Location = new System.Drawing.Point(6, 161);
            this.gpbPessoaJuridica.Name = "gpbPessoaJuridica";
            this.gpbPessoaJuridica.Size = new System.Drawing.Size(368, 109);
            this.gpbPessoaJuridica.TabIndex = 46;
            this.gpbPessoaJuridica.TabStop = false;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(18, 51);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(84, 16);
            this.lblRazaoSocial.TabIndex = 27;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Enabled = false;
            this.txtRazaoSocial.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtRazaoSocial.Location = new System.Drawing.Point(108, 48);
            this.txtRazaoSocial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(205, 23);
            this.txtRazaoSocial.TabIndex = 26;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Enabled = false;
            this.txtCNPJ.Location = new System.Drawing.Point(157, 18);
            this.txtCNPJ.Mask = "000,000,000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(103, 23);
            this.txtCNPJ.TabIndex = 25;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(105, 21);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(42, 16);
            this.lblCNPJ.TabIndex = 24;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // lblNomeFicticio
            // 
            this.lblNomeFicticio.AutoSize = true;
            this.lblNomeFicticio.Location = new System.Drawing.Point(14, 82);
            this.lblNomeFicticio.Name = "lblNomeFicticio";
            this.lblNomeFicticio.Size = new System.Drawing.Size(88, 16);
            this.lblNomeFicticio.TabIndex = 20;
            this.lblNomeFicticio.Text = "Nome fictício:";
            // 
            // txtNomeFicticio
            // 
            this.txtNomeFicticio.Enabled = false;
            this.txtNomeFicticio.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtNomeFicticio.Location = new System.Drawing.Point(108, 79);
            this.txtNomeFicticio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeFicticio.Name = "txtNomeFicticio";
            this.txtNomeFicticio.Size = new System.Drawing.Size(205, 23);
            this.txtNomeFicticio.TabIndex = 19;
            // 
            // gpbPessoaFisica
            // 
            this.gpbPessoaFisica.Controls.Add(this.txtCPF);
            this.gpbPessoaFisica.Controls.Add(this.lblCPF);
            this.gpbPessoaFisica.Controls.Add(this.lblNome);
            this.gpbPessoaFisica.Controls.Add(this.txtNome);
            this.gpbPessoaFisica.Location = new System.Drawing.Point(6, 69);
            this.gpbPessoaFisica.Name = "gpbPessoaFisica";
            this.gpbPessoaFisica.Size = new System.Drawing.Size(368, 86);
            this.gpbPessoaFisica.TabIndex = 45;
            this.gpbPessoaFisica.TabStop = false;
            // 
            // txtCPF
            // 
            this.txtCPF.Enabled = false;
            this.txtCPF.Location = new System.Drawing.Point(143, 18);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(103, 23);
            this.txtCPF.TabIndex = 23;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(85, 21);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(39, 16);
            this.lblCPF.TabIndex = 22;
            this.lblCPF.Text = "CPF:  ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(41, 51);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtNome.Location = new System.Drawing.Point(94, 48);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(205, 23);
            this.txtNome.TabIndex = 17;
            // 
            // btnBuscarPessoa
            // 
            this.btnBuscarPessoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarPessoa.FlatAppearance.BorderSize = 0;
            this.btnBuscarPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPessoa.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPessoa.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPessoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPessoa.Location = new System.Drawing.Point(204, 20);
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
            this.txtPessoa.Location = new System.Drawing.Point(89, 30);
            this.txtPessoa.Name = "txtPessoa";
            this.txtPessoa.Size = new System.Drawing.Size(109, 23);
            this.txtPessoa.TabIndex = 1;
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Location = new System.Drawing.Point(59, 33);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(24, 16);
            this.lblPessoa.TabIndex = 0;
            this.lblPessoa.Text = "ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelInside3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1102, 637);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Passo 3";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelInside3
            // 
            this.panelInside3.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside3.Controls.Add(this.gpbDados);
            this.panelInside3.Controls.Add(this.btnCadastrar);
            this.panelInside3.Location = new System.Drawing.Point(376, 190);
            this.panelInside3.Name = "panelInside3";
            this.panelInside3.Size = new System.Drawing.Size(320, 253);
            this.panelInside3.TabIndex = 39;
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.lblQuantidade);
            this.gpbDados.Controls.Add(this.lblQuantidadeInfo);
            this.gpbDados.Controls.Add(this.txtValorTotal);
            this.gpbDados.Controls.Add(this.lblValorTotal);
            this.gpbDados.Controls.Add(this.lblDataEntrega);
            this.gpbDados.Controls.Add(this.dtpDataEntrega);
            this.gpbDados.Controls.Add(this.lblData);
            this.gpbDados.Controls.Add(this.dtpData);
            this.gpbDados.Location = new System.Drawing.Point(12, 13);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(294, 158);
            this.gpbDados.TabIndex = 28;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados finais";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuantidade.Location = new System.Drawing.Point(194, 122);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(15, 16);
            this.lblQuantidade.TabIndex = 7;
            this.lblQuantidade.Text = "0";
            // 
            // lblQuantidadeInfo
            // 
            this.lblQuantidadeInfo.AutoSize = true;
            this.lblQuantidadeInfo.Location = new System.Drawing.Point(25, 113);
            this.lblQuantidadeInfo.Name = "lblQuantidadeInfo";
            this.lblQuantidadeInfo.Size = new System.Drawing.Size(79, 32);
            this.lblQuantidadeInfo.TabIndex = 6;
            this.lblQuantidadeInfo.Text = "Quantidade\r\n de animais:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(131, 87);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(150, 23);
            this.txtValorTotal.TabIndex = 5;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(26, 90);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(73, 16);
            this.lblValorTotal.TabIndex = 4;
            this.lblValorTotal.Text = "Valor total:";
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.Location = new System.Drawing.Point(16, 63);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(107, 16);
            this.lblDataEntrega.TabIndex = 3;
            this.lblDataEntrega.Text = "Data de entrega:";
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrega.Location = new System.Drawing.Point(149, 58);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(113, 23);
            this.dtpDataEntrega.TabIndex = 2;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(16, 34);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(105, 16);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data da compra:";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(149, 29);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(113, 23);
            this.dtpData.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(67, 178);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(239, 68);
            this.btnCadastrar.TabIndex = 26;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
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
            this.panel2.Size = new System.Drawing.Size(1132, 45);
            this.panel2.TabIndex = 42;
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(1089, 4);
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
            this.panel4.Size = new System.Drawing.Size(1132, 15);
            this.panel4.TabIndex = 43;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(185, 24);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Cadastro de Venda";
            // 
            // frmCadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1132, 749);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCadastroVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroVenda";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelInside.ResumeLayout(false);
            this.gpbAnimal.ResumeLayout(false);
            this.gpbAnimal.PerformLayout();
            this.gpbOutroPiquete.ResumeLayout(false);
            this.gpbOutroPiquete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimaisOutroPiquete)).EndInit();
            this.gpbAnimaisVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimais)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panelInside2.ResumeLayout(false);
            this.gpbPessoa.ResumeLayout(false);
            this.gpbPessoa.PerformLayout();
            this.gpbPessoaJuridica.ResumeLayout(false);
            this.gpbPessoaJuridica.PerformLayout();
            this.gpbPessoaFisica.ResumeLayout(false);
            this.gpbPessoaFisica.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panelInside3.ResumeLayout(false);
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelInside3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gpbOutroPiquete;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblPiqueteOutroID;
        private System.Windows.Forms.DataGridView dgvAnimaisOutroPiquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox txtPiqueteOutroID;
        private System.Windows.Forms.Button btnBuscarPiquete;
        private System.Windows.Forms.GroupBox gpbAnimaisVenda;
        private System.Windows.Forms.DataGridView dgvAnimais;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiqueteDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn RacaNome;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox gpbAnimal;
        private System.Windows.Forms.Label lblAnimalID;
        private System.Windows.Forms.TextBox txtAnimalID;
        private System.Windows.Forms.Button btnConsultarAnimal;
        private System.Windows.Forms.Button btnAdicionarIndividual;
        private System.Windows.Forms.Panel panelInside2;
        private System.Windows.Forms.GroupBox gpbPessoa;
        private System.Windows.Forms.GroupBox gpbPessoaJuridica;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblNomeFicticio;
        private System.Windows.Forms.TextBox txtNomeFicticio;
        private System.Windows.Forms.GroupBox gpbPessoaFisica;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnBuscarPessoa;
        private System.Windows.Forms.TextBox txtPessoa;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.TextBox txtValorAnimal;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValorAnimalOutroPiquete;
        private System.Windows.Forms.Label lblValorAnimalOutroPiquete;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblQuantidadeInfo;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblDataEntrega;
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblInformeValorAnimal;
        private System.Windows.Forms.Label lblValorANimalPiquete;
        private System.Windows.Forms.Label lblTitulo;
    }
}