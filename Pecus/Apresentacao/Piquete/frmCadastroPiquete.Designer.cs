namespace Apresentacao.Piquete
{
    partial class frmCadastroPiquete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroPiquete));
            this.panel4 = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelInside = new System.Windows.Forms.Panel();
            this.picArrowLeftAnimal = new System.Windows.Forms.PictureBox();
            this.gpbAnimal = new System.Windows.Forms.GroupBox();
            this.lblAnimalID = new System.Windows.Forms.Label();
            this.txtAnimalID = new System.Windows.Forms.TextBox();
            this.btnConsultarAnimal = new System.Windows.Forms.Button();
            this.picArrowRightPiquete = new System.Windows.Forms.PictureBox();
            this.picArrowLeftPiquete = new System.Windows.Forms.PictureBox();
            this.gpbOutroPiquete = new System.Windows.Forms.GroupBox();
            this.lblPiqueteOutroID = new System.Windows.Forms.Label();
            this.dgvAnimaisOutroPiquete = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPiqueteOutroID = new System.Windows.Forms.TextBox();
            this.btnBuscarPiquete = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.lblAnimais = new System.Windows.Forms.Label();
            this.dgvAnimaisAtual = new System.Windows.Forms.DataGridView();
            this.AnimalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PiqueteDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RacaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panelInside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowLeftAnimal)).BeginInit();
            this.gpbAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowRightPiquete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowLeftPiquete)).BeginInit();
            this.gpbOutroPiquete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimaisOutroPiquete)).BeginInit();
            this.gpbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimaisAtual)).BeginInit();
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
            this.panel4.Size = new System.Drawing.Size(1145, 45);
            this.panel4.TabIndex = 11;
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(1101, 4);
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
            this.panel2.Size = new System.Drawing.Size(1145, 15);
            this.panel2.TabIndex = 10;
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.picArrowLeftAnimal);
            this.panelInside.Controls.Add(this.gpbAnimal);
            this.panelInside.Controls.Add(this.picArrowRightPiquete);
            this.panelInside.Controls.Add(this.picArrowLeftPiquete);
            this.panelInside.Controls.Add(this.gpbOutroPiquete);
            this.panelInside.Controls.Add(this.btnSalvar);
            this.panelInside.Controls.Add(this.gpbDados);
            this.panelInside.Location = new System.Drawing.Point(12, 67);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(1122, 613);
            this.panelInside.TabIndex = 34;
            // 
            // picArrowLeftAnimal
            // 
            this.picArrowLeftAnimal.BackgroundImage = global::Apresentacao.Properties.Resources.arrow_left;
            this.picArrowLeftAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picArrowLeftAnimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picArrowLeftAnimal.Location = new System.Drawing.Point(540, 58);
            this.picArrowLeftAnimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picArrowLeftAnimal.Name = "picArrowLeftAnimal";
            this.picArrowLeftAnimal.Size = new System.Drawing.Size(44, 41);
            this.picArrowLeftAnimal.TabIndex = 39;
            this.picArrowLeftAnimal.TabStop = false;
            this.picArrowLeftAnimal.Click += new System.EventHandler(this.PicArrowLeftAnimal_Click);
            // 
            // gpbAnimal
            // 
            this.gpbAnimal.Controls.Add(this.lblAnimalID);
            this.gpbAnimal.Controls.Add(this.txtAnimalID);
            this.gpbAnimal.Controls.Add(this.btnConsultarAnimal);
            this.gpbAnimal.Location = new System.Drawing.Point(590, 35);
            this.gpbAnimal.Name = "gpbAnimal";
            this.gpbAnimal.Size = new System.Drawing.Size(521, 77);
            this.gpbAnimal.TabIndex = 1;
            this.gpbAnimal.TabStop = false;
            this.gpbAnimal.Text = "Transferir Animais";
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
            this.btnConsultarAnimal.Click += new System.EventHandler(this.BtnConsultarAnimal_Click);
            // 
            // picArrowRightPiquete
            // 
            this.picArrowRightPiquete.BackgroundImage = global::Apresentacao.Properties.Resources.arrow_right;
            this.picArrowRightPiquete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picArrowRightPiquete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picArrowRightPiquete.Location = new System.Drawing.Point(540, 384);
            this.picArrowRightPiquete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picArrowRightPiquete.Name = "picArrowRightPiquete";
            this.picArrowRightPiquete.Size = new System.Drawing.Size(44, 41);
            this.picArrowRightPiquete.TabIndex = 37;
            this.picArrowRightPiquete.TabStop = false;
            this.picArrowRightPiquete.Click += new System.EventHandler(this.PicArrowRightPiquete_Click);
            // 
            // picArrowLeftPiquete
            // 
            this.picArrowLeftPiquete.BackgroundImage = global::Apresentacao.Properties.Resources.arrow_left;
            this.picArrowLeftPiquete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picArrowLeftPiquete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picArrowLeftPiquete.Location = new System.Drawing.Point(540, 335);
            this.picArrowLeftPiquete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picArrowLeftPiquete.Name = "picArrowLeftPiquete";
            this.picArrowLeftPiquete.Size = new System.Drawing.Size(44, 41);
            this.picArrowLeftPiquete.TabIndex = 33;
            this.picArrowLeftPiquete.TabStop = false;
            this.picArrowLeftPiquete.Click += new System.EventHandler(this.PicArrowLeftPiquete_Click);
            // 
            // gpbOutroPiquete
            // 
            this.gpbOutroPiquete.Controls.Add(this.lblPiqueteOutroID);
            this.gpbOutroPiquete.Controls.Add(this.dgvAnimaisOutroPiquete);
            this.gpbOutroPiquete.Controls.Add(this.txtPiqueteOutroID);
            this.gpbOutroPiquete.Controls.Add(this.btnBuscarPiquete);
            this.gpbOutroPiquete.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOutroPiquete.Location = new System.Drawing.Point(590, 176);
            this.gpbOutroPiquete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbOutroPiquete.Name = "gpbOutroPiquete";
            this.gpbOutroPiquete.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbOutroPiquete.Size = new System.Drawing.Size(521, 349);
            this.gpbOutroPiquete.TabIndex = 2;
            this.gpbOutroPiquete.TabStop = false;
            this.gpbOutroPiquete.Text = "Transferir Animais de outros Piquetes";
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
            this.dgvAnimaisOutroPiquete.TabIndex = 2;
            this.dgvAnimaisOutroPiquete.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvAnimaisOutroPiquete_CellFormatting);
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
            this.txtPiqueteOutroID.TabIndex = 0;
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
            this.btnBuscarPiquete.TabIndex = 1;
            this.btnBuscarPiquete.Text = "Buscar Piquete";
            this.btnBuscarPiquete.UseVisualStyleBackColor = false;
            this.btnBuscarPiquete.Click += new System.EventHandler(this.BtnBuscarPiquete_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(756, 533);
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
            this.gpbDados.Controls.Add(this.lblAnimais);
            this.gpbDados.Controls.Add(this.dgvAnimaisAtual);
            this.gpbDados.Controls.Add(this.ckbAtivo);
            this.gpbDados.Controls.Add(this.txtDescricao);
            this.gpbDados.Controls.Add(this.lblDescricao);
            this.gpbDados.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDados.Location = new System.Drawing.Point(13, 12);
            this.gpbDados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbDados.Size = new System.Drawing.Size(521, 513);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Cadastro de Piquete";
            // 
            // lblAnimais
            // 
            this.lblAnimais.AutoSize = true;
            this.lblAnimais.Location = new System.Drawing.Point(6, 213);
            this.lblAnimais.Name = "lblAnimais";
            this.lblAnimais.Size = new System.Drawing.Size(55, 16);
            this.lblAnimais.TabIndex = 17;
            this.lblAnimais.Text = "Animais";
            // 
            // dgvAnimaisAtual
            // 
            this.dgvAnimaisAtual.AllowUserToAddRows = false;
            this.dgvAnimaisAtual.AllowUserToDeleteRows = false;
            this.dgvAnimaisAtual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimaisAtual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnimalID,
            this.AnimalIdentificador,
            this.AnimalDescricao,
            this.PiqueteDescricao,
            this.RacaNome});
            this.dgvAnimaisAtual.Location = new System.Drawing.Point(6, 236);
            this.dgvAnimaisAtual.Name = "dgvAnimaisAtual";
            this.dgvAnimaisAtual.ReadOnly = true;
            this.dgvAnimaisAtual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimaisAtual.Size = new System.Drawing.Size(509, 270);
            this.dgvAnimaisAtual.TabIndex = 2;
            this.dgvAnimaisAtual.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvAnimaisAtual_CellFormatting);
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
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Checked = true;
            this.ckbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAtivo.Enabled = false;
            this.ckbAtivo.Location = new System.Drawing.Point(217, 23);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(59, 20);
            this.ckbAtivo.TabIndex = 0;
            this.ckbAtivo.Text = "Ativo";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtDescricao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescricao.Location = new System.Drawing.Point(39, 55);
            this.txtDescricao.MaxLength = 30;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(422, 132);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.Text = "";
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(196, 24);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Cadastro de Piquete";
            // 
            // frmCadastroPiquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1145, 690);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCadastroPiquete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroPiquete";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panelInside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArrowLeftAnimal)).EndInit();
            this.gpbAnimal.ResumeLayout(false);
            this.gpbAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowRightPiquete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowLeftPiquete)).EndInit();
            this.gpbOutroPiquete.ResumeLayout(false);
            this.gpbOutroPiquete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimaisOutroPiquete)).EndInit();
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimaisAtual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.PictureBox picArrowLeftAnimal;
        private System.Windows.Forms.GroupBox gpbAnimal;
        private System.Windows.Forms.Label lblAnimalID;
        private System.Windows.Forms.TextBox txtAnimalID;
        private System.Windows.Forms.Button btnConsultarAnimal;
        private System.Windows.Forms.PictureBox picArrowLeftPiquete;
        private System.Windows.Forms.GroupBox gpbOutroPiquete;
        private System.Windows.Forms.Label lblPiqueteOutroID;
        private System.Windows.Forms.DataGridView dgvAnimaisOutroPiquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox txtPiqueteOutroID;
        private System.Windows.Forms.Button btnBuscarPiquete;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.Label lblAnimais;
        private System.Windows.Forms.DataGridView dgvAnimaisAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiqueteDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn RacaNome;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.PictureBox picArrowRightPiquete;
        private System.Windows.Forms.Label lblTitulo;
    }
}