namespace Apresentacao.ConsultaVeterinaria
{
    partial class frmCadastroConsultaVeterinaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroConsultaVeterinaria));
            this.panelInside = new System.Windows.Forms.Panel();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.lblCusto = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gpbVeterinarios = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dgvVeterinarios = new System.Windows.Forms.DataGridView();
            this.VeterinarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeterinarioCRMV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeterinarioNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarVeterinario = new System.Windows.Forms.Button();
            this.txtVeterinario = new System.Windows.Forms.TextBox();
            this.lblVeterinario = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gpbAnimal = new System.Windows.Forms.GroupBox();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.cbbRaca = new System.Windows.Forms.ComboBox();
            this.lblRaca = new System.Windows.Forms.Label();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.txtPiquete = new System.Windows.Forms.TextBox();
            this.lblPiquete = new System.Windows.Forms.Label();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.txtAnimalDescricao = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelInside.SuspendLayout();
            this.gpbDados.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.gpbVeterinarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarios)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gpbAnimal.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbDados);
            this.panelInside.Location = new System.Drawing.Point(6, 65);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(548, 290);
            this.panelInside.TabIndex = 0;
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.txtDescricao);
            this.gpbDados.Controls.Add(this.lblDescricao);
            this.gpbDados.Controls.Add(this.dtpData);
            this.gpbDados.Controls.Add(this.txtCusto);
            this.gpbDados.Controls.Add(this.lblCusto);
            this.gpbDados.Controls.Add(this.lblData);
            this.gpbDados.Location = new System.Drawing.Point(75, 13);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(378, 254);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(97, 78);
            this.txtDescricao.MaxLength = 300;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(218, 164);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(20, 81);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 16);
            this.lblDescricao.TabIndex = 22;
            this.lblDescricao.Text = "Descrição:";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(145, 20);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(118, 23);
            this.dtpData.TabIndex = 0;
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(119, 49);
            this.txtCusto.MaxLength = 19;
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(177, 23);
            this.txtCusto.TabIndex = 1;
            this.txtCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusto_KeyPress);
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(20, 52);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(46, 16);
            this.lblCusto.TabIndex = 19;
            this.lblCusto.Text = "Custo:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(20, 25);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(39, 16);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(295, 377);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(239, 68);
            this.btnCadastrar.TabIndex = 1;
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
            this.panel2.Size = new System.Drawing.Size(592, 45);
            this.panel2.TabIndex = 36;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(314, 24);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Cadastro de Consulta Veterinária";
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(549, 4);
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
            this.panel4.Size = new System.Drawing.Size(592, 15);
            this.panel4.TabIndex = 37;
            // 
            // gpbVeterinarios
            // 
            this.gpbVeterinarios.Controls.Add(this.btnAdicionar);
            this.gpbVeterinarios.Controls.Add(this.btnRemover);
            this.gpbVeterinarios.Controls.Add(this.dgvVeterinarios);
            this.gpbVeterinarios.Controls.Add(this.btnBuscarVeterinario);
            this.gpbVeterinarios.Controls.Add(this.txtVeterinario);
            this.gpbVeterinarios.Controls.Add(this.lblVeterinario);
            this.gpbVeterinarios.Location = new System.Drawing.Point(12, 13);
            this.gpbVeterinarios.Name = "gpbVeterinarios";
            this.gpbVeterinarios.Size = new System.Drawing.Size(522, 357);
            this.gpbVeterinarios.TabIndex = 0;
            this.gpbVeterinarios.TabStop = false;
            this.gpbVeterinarios.Text = "Veterinários";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(44, 62);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(132, 37);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(323, 62);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(132, 37);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dgvVeterinarios
            // 
            this.dgvVeterinarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeterinarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VeterinarioID,
            this.VeterinarioCRMV,
            this.VeterinarioNome});
            this.dgvVeterinarios.Location = new System.Drawing.Point(6, 106);
            this.dgvVeterinarios.Name = "dgvVeterinarios";
            this.dgvVeterinarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeterinarios.Size = new System.Drawing.Size(510, 239);
            this.dgvVeterinarios.TabIndex = 4;
            this.dgvVeterinarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVeterinarios_CellFormatting);
            // 
            // VeterinarioID
            // 
            this.VeterinarioID.DataPropertyName = "VeterinarioID";
            this.VeterinarioID.HeaderText = "ID";
            this.VeterinarioID.Name = "VeterinarioID";
            this.VeterinarioID.ReadOnly = true;
            this.VeterinarioID.Width = 80;
            // 
            // VeterinarioCRMV
            // 
            this.VeterinarioCRMV.DataPropertyName = "VeterinarioCRMV";
            this.VeterinarioCRMV.HeaderText = "CRMV";
            this.VeterinarioCRMV.Name = "VeterinarioCRMV";
            this.VeterinarioCRMV.ReadOnly = true;
            this.VeterinarioCRMV.Width = 140;
            // 
            // VeterinarioNome
            // 
            this.VeterinarioNome.DataPropertyName = "VeterinarioNome";
            this.VeterinarioNome.HeaderText = "Nome";
            this.VeterinarioNome.Name = "VeterinarioNome";
            this.VeterinarioNome.ReadOnly = true;
            this.VeterinarioNome.Width = 246;
            // 
            // btnBuscarVeterinario
            // 
            this.btnBuscarVeterinario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarVeterinario.FlatAppearance.BorderSize = 0;
            this.btnBuscarVeterinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVeterinario.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarVeterinario.ForeColor = System.Drawing.Color.White;
            this.btnBuscarVeterinario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarVeterinario.Location = new System.Drawing.Point(252, 12);
            this.btnBuscarVeterinario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarVeterinario.Name = "btnBuscarVeterinario";
            this.btnBuscarVeterinario.Size = new System.Drawing.Size(165, 42);
            this.btnBuscarVeterinario.TabIndex = 1;
            this.btnBuscarVeterinario.Text = "Buscar Veterinário";
            this.btnBuscarVeterinario.UseVisualStyleBackColor = false;
            this.btnBuscarVeterinario.Click += new System.EventHandler(this.btnBuscarVeterinario_Click);
            // 
            // txtVeterinario
            // 
            this.txtVeterinario.Enabled = false;
            this.txtVeterinario.Location = new System.Drawing.Point(137, 22);
            this.txtVeterinario.Name = "txtVeterinario";
            this.txtVeterinario.Size = new System.Drawing.Size(109, 23);
            this.txtVeterinario.TabIndex = 0;
            // 
            // lblVeterinario
            // 
            this.lblVeterinario.AutoSize = true;
            this.lblVeterinario.Location = new System.Drawing.Point(54, 25);
            this.lblVeterinario.Name = "lblVeterinario";
            this.lblVeterinario.Size = new System.Drawing.Size(77, 16);
            this.lblVeterinario.TabIndex = 24;
            this.lblVeterinario.Text = "Veterinário:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 67);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(568, 499);
            this.tabControl.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelInside);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(560, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Passo 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(560, 470);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Passo2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.gpbAnimal);
            this.panel3.Location = new System.Drawing.Point(6, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 464);
            this.panel3.TabIndex = 0;
            // 
            // gpbAnimal
            // 
            this.gpbAnimal.Controls.Add(this.ckbAtivo);
            this.gpbAnimal.Controls.Add(this.cbbRaca);
            this.gpbAnimal.Controls.Add(this.lblRaca);
            this.gpbAnimal.Controls.Add(this.txtIdentificador);
            this.gpbAnimal.Controls.Add(this.txtPiquete);
            this.gpbAnimal.Controls.Add(this.lblPiquete);
            this.gpbAnimal.Controls.Add(this.lblIdentificador);
            this.gpbAnimal.Controls.Add(this.txtAnimalDescricao);
            this.gpbAnimal.Controls.Add(this.label1);
            this.gpbAnimal.Controls.Add(this.btnBuscarAnimal);
            this.gpbAnimal.Controls.Add(this.txtAnimal);
            this.gpbAnimal.Controls.Add(this.lblAnimal);
            this.gpbAnimal.Location = new System.Drawing.Point(15, 79);
            this.gpbAnimal.Name = "gpbAnimal";
            this.gpbAnimal.Size = new System.Drawing.Size(518, 297);
            this.gpbAnimal.TabIndex = 0;
            this.gpbAnimal.TabStop = false;
            this.gpbAnimal.Text = "Animal";
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Enabled = false;
            this.ckbAtivo.Location = new System.Drawing.Point(213, 269);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(59, 20);
            this.ckbAtivo.TabIndex = 6;
            this.ckbAtivo.Text = "Ativo";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // cbbRaca
            // 
            this.cbbRaca.Enabled = false;
            this.cbbRaca.FormattingEnabled = true;
            this.cbbRaca.Location = new System.Drawing.Point(164, 210);
            this.cbbRaca.Name = "cbbRaca";
            this.cbbRaca.Size = new System.Drawing.Size(170, 24);
            this.cbbRaca.TabIndex = 4;
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(119, 213);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(39, 16);
            this.lblRaca.TabIndex = 44;
            this.lblRaca.Text = "Raca:";
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Enabled = false;
            this.txtIdentificador.Location = new System.Drawing.Point(197, 181);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(100, 23);
            this.txtIdentificador.TabIndex = 3;
            // 
            // txtPiquete
            // 
            this.txtPiquete.Enabled = false;
            this.txtPiquete.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtPiquete.Location = new System.Drawing.Point(178, 240);
            this.txtPiquete.Name = "txtPiquete";
            this.txtPiquete.Size = new System.Drawing.Size(140, 23);
            this.txtPiquete.TabIndex = 5;
            // 
            // lblPiquete
            // 
            this.lblPiquete.AutoSize = true;
            this.lblPiquete.Location = new System.Drawing.Point(115, 243);
            this.lblPiquete.Name = "lblPiquete";
            this.lblPiquete.Size = new System.Drawing.Size(57, 16);
            this.lblPiquete.TabIndex = 42;
            this.lblPiquete.Text = "Piquete:";
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Location = new System.Drawing.Point(61, 184);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(130, 16);
            this.lblIdentificador.TabIndex = 40;
            this.lblIdentificador.Text = "Identificador/brinco:";
            // 
            // txtAnimalDescricao
            // 
            this.txtAnimalDescricao.Enabled = false;
            this.txtAnimalDescricao.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtAnimalDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtAnimalDescricao.Location = new System.Drawing.Point(43, 94);
            this.txtAnimalDescricao.Name = "txtAnimalDescricao";
            this.txtAnimalDescricao.Size = new System.Drawing.Size(422, 71);
            this.txtAnimalDescricao.TabIndex = 2;
            this.txtAnimalDescricao.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Descrição do animal:";
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarAnimal.FlatAppearance.BorderSize = 0;
            this.btnBuscarAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAnimal.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarAnimal.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(247, 23);
            this.btnBuscarAnimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(165, 42);
            this.btnBuscarAnimal.TabIndex = 1;
            this.btnBuscarAnimal.Text = "Buscar Animal";
            this.btnBuscarAnimal.UseVisualStyleBackColor = false;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click_1);
            // 
            // txtAnimal
            // 
            this.txtAnimal.Enabled = false;
            this.txtAnimal.Location = new System.Drawing.Point(132, 33);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.Size = new System.Drawing.Size(109, 23);
            this.txtAnimal.TabIndex = 0;
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(102, 36);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(24, 16);
            this.lblAnimal.TabIndex = 16;
            this.lblAnimal.Text = "ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(560, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Passo 3";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.gpbVeterinarios);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 456);
            this.panel1.TabIndex = 0;
            // 
            // frmCadastroConsultaVeterinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(592, 580);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCadastroConsultaVeterinaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroConsultaVeterinaria";
            this.panelInside.ResumeLayout(false);
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.gpbVeterinarios.ResumeLayout(false);
            this.gpbVeterinarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarios)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gpbAnimal.ResumeLayout(false);
            this.gpbAnimal.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.GroupBox gpbVeterinarios;
        private System.Windows.Forms.DataGridView dgvVeterinarios;
        private System.Windows.Forms.Button btnBuscarVeterinario;
        private System.Windows.Forms.TextBox txtVeterinario;
        private System.Windows.Forms.Label lblVeterinario;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeterinarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeterinarioCRMV;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeterinarioNome;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gpbAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.ComboBox cbbRaca;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.TextBox txtPiquete;
        private System.Windows.Forms.Label lblPiquete;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.RichTextBox txtAnimalDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
    }
}