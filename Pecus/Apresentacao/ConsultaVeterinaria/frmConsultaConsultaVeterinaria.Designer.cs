namespace Apresentacao.ConsultaVeterinaria
{
    partial class frmConsultaConsultaVeterinaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaConsultaVeterinaria));
            this.panelInside = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.ConsultaVeterinariaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultaVeterinariaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultaVeterinariaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultaVeterinariaCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RacaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbVeterinario = new System.Windows.Forms.GroupBox();
            this.btnBuscarVeterinario = new System.Windows.Forms.Button();
            this.txtVeterinario = new System.Windows.Forms.TextBox();
            this.lblVeterinario = new System.Windows.Forms.Label();
            this.gpbAnimal = new System.Windows.Forms.GroupBox();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.gpbID = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.gpbDescricao = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.gpbDatas = new System.Windows.Forms.GroupBox();
            this.dtpData2 = new System.Windows.Forms.DateTimePicker();
            this.dtpData1 = new System.Windows.Forms.DateTimePicker();
            this.lblTraco = new System.Windows.Forms.Label();
            this.gpbDataOpcoes = new System.Windows.Forms.GroupBox();
            this.rbEntre = new System.Windows.Forms.RadioButton();
            this.rbAntes = new System.Windows.Forms.RadioButton();
            this.rbApos = new System.Windows.Forms.RadioButton();
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbVeterinario = new System.Windows.Forms.RadioButton();
            this.rbDescricao = new System.Windows.Forms.RadioButton();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.rbAnimal = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelInside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.gpbVeterinario.SuspendLayout();
            this.gpbAnimal.SuspendLayout();
            this.gpbID.SuspendLayout();
            this.gpbDescricao.SuspendLayout();
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
            this.panelInside.Controls.Add(this.gpbVeterinario);
            this.panelInside.Controls.Add(this.gpbAnimal);
            this.panelInside.Controls.Add(this.gpbID);
            this.panelInside.Controls.Add(this.gpbDescricao);
            this.panelInside.Controls.Add(this.gpbDatas);
            this.panelInside.Controls.Add(this.gpbDataOpcoes);
            this.panelInside.Controls.Add(this.gpbOpcoes);
            this.panelInside.Location = new System.Drawing.Point(12, 67);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(875, 569);
            this.panelInside.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblInfo.Location = new System.Drawing.Point(9, 109);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(382, 16);
            this.lblInfo.TabIndex = 50;
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
            this.btnConsultar.Location = new System.Drawing.Point(626, 490);
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
            this.ConsultaVeterinariaID,
            this.ConsultaVeterinariaData,
            this.ConsultaVeterinariaDescricao,
            this.ConsultaVeterinariaCusto,
            this.AnimalDescricao,
            this.RacaNome});
            this.dgvResultados.Location = new System.Drawing.Point(12, 128);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(853, 354);
            this.dgvResultados.TabIndex = 3;
            this.dgvResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellDoubleClick);
            this.dgvResultados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvResultados_CellFormatting);
            // 
            // ConsultaVeterinariaID
            // 
            this.ConsultaVeterinariaID.DataPropertyName = "ConsultaVeterinariaID";
            this.ConsultaVeterinariaID.HeaderText = "ID";
            this.ConsultaVeterinariaID.Name = "ConsultaVeterinariaID";
            this.ConsultaVeterinariaID.ReadOnly = true;
            this.ConsultaVeterinariaID.Width = 80;
            // 
            // ConsultaVeterinariaData
            // 
            this.ConsultaVeterinariaData.DataPropertyName = "ConsultaVeterinariaData";
            this.ConsultaVeterinariaData.HeaderText = "Data";
            this.ConsultaVeterinariaData.Name = "ConsultaVeterinariaData";
            this.ConsultaVeterinariaData.ReadOnly = true;
            this.ConsultaVeterinariaData.Width = 110;
            // 
            // ConsultaVeterinariaDescricao
            // 
            this.ConsultaVeterinariaDescricao.DataPropertyName = "ConsultaVeterinariaDescricao";
            this.ConsultaVeterinariaDescricao.HeaderText = "Descrição";
            this.ConsultaVeterinariaDescricao.Name = "ConsultaVeterinariaDescricao";
            this.ConsultaVeterinariaDescricao.ReadOnly = true;
            this.ConsultaVeterinariaDescricao.Width = 200;
            // 
            // ConsultaVeterinariaCusto
            // 
            this.ConsultaVeterinariaCusto.DataPropertyName = "ConsultaVeterinariaCusto";
            this.ConsultaVeterinariaCusto.HeaderText = "Custo";
            this.ConsultaVeterinariaCusto.Name = "ConsultaVeterinariaCusto";
            this.ConsultaVeterinariaCusto.ReadOnly = true;
            // 
            // AnimalDescricao
            // 
            this.AnimalDescricao.DataPropertyName = "Animal.AnimalDescricao";
            this.AnimalDescricao.HeaderText = "Animal";
            this.AnimalDescricao.Name = "AnimalDescricao";
            this.AnimalDescricao.ReadOnly = true;
            this.AnimalDescricao.Width = 200;
            // 
            // RacaNome
            // 
            this.RacaNome.DataPropertyName = "Animal.Raca.RacaNome";
            this.RacaNome.HeaderText = "Raça";
            this.RacaNome.Name = "RacaNome";
            this.RacaNome.ReadOnly = true;
            this.RacaNome.Width = 120;
            // 
            // gpbVeterinario
            // 
            this.gpbVeterinario.Controls.Add(this.btnBuscarVeterinario);
            this.gpbVeterinario.Controls.Add(this.txtVeterinario);
            this.gpbVeterinario.Controls.Add(this.lblVeterinario);
            this.gpbVeterinario.Location = new System.Drawing.Point(268, 14);
            this.gpbVeterinario.Name = "gpbVeterinario";
            this.gpbVeterinario.Size = new System.Drawing.Size(378, 73);
            this.gpbVeterinario.TabIndex = 1;
            this.gpbVeterinario.TabStop = false;
            this.gpbVeterinario.Visible = false;
            // 
            // btnBuscarVeterinario
            // 
            this.btnBuscarVeterinario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarVeterinario.FlatAppearance.BorderSize = 0;
            this.btnBuscarVeterinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVeterinario.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarVeterinario.ForeColor = System.Drawing.Color.White;
            this.btnBuscarVeterinario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarVeterinario.Location = new System.Drawing.Point(204, 20);
            this.btnBuscarVeterinario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarVeterinario.Name = "btnBuscarVeterinario";
            this.btnBuscarVeterinario.Size = new System.Drawing.Size(165, 42);
            this.btnBuscarVeterinario.TabIndex = 15;
            this.btnBuscarVeterinario.Text = "Buscar Veterinário";
            this.btnBuscarVeterinario.UseVisualStyleBackColor = false;
            this.btnBuscarVeterinario.Click += new System.EventHandler(this.btnBuscarVeterinario_Click);
            // 
            // txtVeterinario
            // 
            this.txtVeterinario.Enabled = false;
            this.txtVeterinario.Location = new System.Drawing.Point(89, 30);
            this.txtVeterinario.Name = "txtVeterinario";
            this.txtVeterinario.Size = new System.Drawing.Size(109, 23);
            this.txtVeterinario.TabIndex = 1;
            // 
            // lblVeterinario
            // 
            this.lblVeterinario.AutoSize = true;
            this.lblVeterinario.Location = new System.Drawing.Point(6, 33);
            this.lblVeterinario.Name = "lblVeterinario";
            this.lblVeterinario.Size = new System.Drawing.Size(77, 16);
            this.lblVeterinario.TabIndex = 0;
            this.lblVeterinario.Text = "Veterinário:";
            // 
            // gpbAnimal
            // 
            this.gpbAnimal.Controls.Add(this.btnBuscarAnimal);
            this.gpbAnimal.Controls.Add(this.txtAnimal);
            this.gpbAnimal.Controls.Add(this.lblAnimal);
            this.gpbAnimal.Location = new System.Drawing.Point(268, 14);
            this.gpbAnimal.Name = "gpbAnimal";
            this.gpbAnimal.Size = new System.Drawing.Size(355, 73);
            this.gpbAnimal.TabIndex = 1;
            this.gpbAnimal.TabStop = false;
            this.gpbAnimal.Visible = false;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarAnimal.FlatAppearance.BorderSize = 0;
            this.btnBuscarAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAnimal.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarAnimal.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(179, 20);
            this.btnBuscarAnimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(165, 42);
            this.btnBuscarAnimal.TabIndex = 15;
            this.btnBuscarAnimal.Text = "Buscar Animal";
            this.btnBuscarAnimal.UseVisualStyleBackColor = false;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // txtAnimal
            // 
            this.txtAnimal.Enabled = false;
            this.txtAnimal.Location = new System.Drawing.Point(64, 30);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.Size = new System.Drawing.Size(109, 23);
            this.txtAnimal.TabIndex = 1;
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(6, 33);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(52, 16);
            this.lblAnimal.TabIndex = 0;
            this.lblAnimal.Text = "Animal:";
            // 
            // gpbID
            // 
            this.gpbID.Controls.Add(this.txtID);
            this.gpbID.Controls.Add(this.lblID);
            this.gpbID.Location = new System.Drawing.Point(268, 14);
            this.gpbID.Name = "gpbID";
            this.gpbID.Size = new System.Drawing.Size(137, 73);
            this.gpbID.TabIndex = 1;
            this.gpbID.TabStop = false;
            this.gpbID.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(36, 30);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(83, 23);
            this.txtID.TabIndex = 1;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // gpbDescricao
            // 
            this.gpbDescricao.Controls.Add(this.txtDescricao);
            this.gpbDescricao.Controls.Add(this.lblDescricao);
            this.gpbDescricao.Location = new System.Drawing.Point(268, 14);
            this.gpbDescricao.Name = "gpbDescricao";
            this.gpbDescricao.Size = new System.Drawing.Size(330, 73);
            this.gpbDescricao.TabIndex = 1;
            this.gpbDescricao.TabStop = false;
            this.gpbDescricao.Visible = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(80, 30);
            this.txtDescricao.MaxLength = 300;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(240, 23);
            this.txtDescricao.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 33);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 16);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";
            // 
            // gpbDatas
            // 
            this.gpbDatas.Controls.Add(this.dtpData2);
            this.gpbDatas.Controls.Add(this.dtpData1);
            this.gpbDatas.Controls.Add(this.lblTraco);
            this.gpbDatas.Location = new System.Drawing.Point(480, 25);
            this.gpbDatas.Name = "gpbDatas";
            this.gpbDatas.Size = new System.Drawing.Size(261, 56);
            this.gpbDatas.TabIndex = 2;
            this.gpbDatas.TabStop = false;
            // 
            // dtpData2
            // 
            this.dtpData2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData2.Location = new System.Drawing.Point(137, 22);
            this.dtpData2.Name = "dtpData2";
            this.dtpData2.Size = new System.Drawing.Size(105, 23);
            this.dtpData2.TabIndex = 4;
            // 
            // dtpData1
            // 
            this.dtpData1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData1.Location = new System.Drawing.Point(7, 22);
            this.dtpData1.Name = "dtpData1";
            this.dtpData1.Size = new System.Drawing.Size(105, 23);
            this.dtpData1.TabIndex = 3;
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
            this.gpbDataOpcoes.Location = new System.Drawing.Point(268, 25);
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
            this.rbEntre.TabIndex = 2;
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
            this.rbAntes.TabIndex = 1;
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
            this.gpbOpcoes.Controls.Add(this.rbVeterinario);
            this.gpbOpcoes.Controls.Add(this.rbDescricao);
            this.gpbOpcoes.Controls.Add(this.rbID);
            this.gpbOpcoes.Controls.Add(this.rbData);
            this.gpbOpcoes.Controls.Add(this.rbAnimal);
            this.gpbOpcoes.Location = new System.Drawing.Point(12, 13);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(250, 76);
            this.gpbOpcoes.TabIndex = 0;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Opções  de consulta";
            // 
            // rbVeterinario
            // 
            this.rbVeterinario.AutoSize = true;
            this.rbVeterinario.Location = new System.Drawing.Point(147, 22);
            this.rbVeterinario.Name = "rbVeterinario";
            this.rbVeterinario.Size = new System.Drawing.Size(92, 20);
            this.rbVeterinario.TabIndex = 2;
            this.rbVeterinario.Text = "Veterinário";
            this.rbVeterinario.UseVisualStyleBackColor = true;
            this.rbVeterinario.CheckedChanged += new System.EventHandler(this.rbVeterinario_CheckedChanged);
            // 
            // rbDescricao
            // 
            this.rbDescricao.AutoSize = true;
            this.rbDescricao.Location = new System.Drawing.Point(58, 48);
            this.rbDescricao.Name = "rbDescricao";
            this.rbDescricao.Size = new System.Drawing.Size(83, 20);
            this.rbDescricao.TabIndex = 3;
            this.rbDescricao.Text = "Descrição";
            this.rbDescricao.UseVisualStyleBackColor = true;
            this.rbDescricao.CheckedChanged += new System.EventHandler(this.rbDescricao_CheckedChanged);
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
            this.panel2.Size = new System.Drawing.Size(898, 45);
            this.panel2.TabIndex = 39;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(312, 24);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Consulta de Consulta Veterinária";
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(855, 4);
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
            this.panel4.Size = new System.Drawing.Size(898, 15);
            this.panel4.TabIndex = 40;
            // 
            // frmConsultaConsultaVeterinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(898, 648);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultaConsultaVeterinaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaConsultaVeterinaria";
            this.panelInside.ResumeLayout(false);
            this.panelInside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.gpbVeterinario.ResumeLayout(false);
            this.gpbVeterinario.PerformLayout();
            this.gpbAnimal.ResumeLayout(false);
            this.gpbAnimal.PerformLayout();
            this.gpbID.ResumeLayout(false);
            this.gpbID.PerformLayout();
            this.gpbDescricao.ResumeLayout(false);
            this.gpbDescricao.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gpbDatas;
        private System.Windows.Forms.DateTimePicker dtpData2;
        private System.Windows.Forms.DateTimePicker dtpData1;
        private System.Windows.Forms.Label lblTraco;
        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton rbAnimal;
        private System.Windows.Forms.GroupBox gpbDataOpcoes;
        private System.Windows.Forms.RadioButton rbEntre;
        private System.Windows.Forms.RadioButton rbAntes;
        private System.Windows.Forms.RadioButton rbApos;
        private System.Windows.Forms.RadioButton rbVeterinario;
        private System.Windows.Forms.RadioButton rbDescricao;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.GroupBox gpbVeterinario;
        private System.Windows.Forms.Button btnBuscarVeterinario;
        private System.Windows.Forms.TextBox txtVeterinario;
        private System.Windows.Forms.Label lblVeterinario;
        private System.Windows.Forms.GroupBox gpbAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.GroupBox gpbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gpbDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaVeterinariaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaVeterinariaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaVeterinariaDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaVeterinariaCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn RacaNome;
        private System.Windows.Forms.Label lblTitulo;
    }
}