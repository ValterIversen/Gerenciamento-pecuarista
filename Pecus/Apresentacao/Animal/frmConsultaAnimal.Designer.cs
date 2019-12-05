namespace Apresentacao.Animal
{
    partial class frmConsultaAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaAnimal));
            this.panel4 = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gpbDescricao = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gpbID = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gpbResultados = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.AnimalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RacaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PiqueteDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbOpcao = new System.Windows.Forms.GroupBox();
            this.rbRaca = new System.Windows.Forms.RadioButton();
            this.rbPiquete = new System.Windows.Forms.RadioButton();
            this.rbIdentificacao = new System.Windows.Forms.RadioButton();
            this.rbDescricao = new System.Windows.Forms.RadioButton();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.gpbIdentificador = new System.Windows.Forms.GroupBox();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.gpbPiquete = new System.Windows.Forms.GroupBox();
            this.btnBuscarPiquete = new System.Windows.Forms.Button();
            this.txtPiquete = new System.Windows.Forms.TextBox();
            this.gpbRaca = new System.Windows.Forms.GroupBox();
            this.cbbRaca = new System.Windows.Forms.ComboBox();
            this.panelInside = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.gpbDescricao.SuspendLayout();
            this.gpbID.SuspendLayout();
            this.gpbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.gpbOpcao.SuspendLayout();
            this.gpbIdentificador.SuspendLayout();
            this.gpbPiquete.SuspendLayout();
            this.gpbRaca.SuspendLayout();
            this.panelInside.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.panel4.Controls.Add(this.lblTitulo);
            this.panel4.Controls.Add(this.picExit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(939, 45);
            this.panel4.TabIndex = 9;
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(896, 3);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 12);
            this.panel2.TabIndex = 8;
            // 
            // gpbDescricao
            // 
            this.gpbDescricao.Controls.Add(this.txtDescricao);
            this.gpbDescricao.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.gpbDescricao.Location = new System.Drawing.Point(406, 12);
            this.gpbDescricao.Name = "gpbDescricao";
            this.gpbDescricao.Size = new System.Drawing.Size(294, 54);
            this.gpbDescricao.TabIndex = 1;
            this.gpbDescricao.TabStop = false;
            this.gpbDescricao.Visible = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtDescricao.Location = new System.Drawing.Point(6, 19);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(282, 23);
            this.txtDescricao.TabIndex = 0;
            // 
            // gpbID
            // 
            this.gpbID.Controls.Add(this.txtID);
            this.gpbID.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.gpbID.Location = new System.Drawing.Point(406, 12);
            this.gpbID.Name = "gpbID";
            this.gpbID.Size = new System.Drawing.Size(146, 54);
            this.gpbID.TabIndex = 1;
            this.gpbID.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtID.Location = new System.Drawing.Point(6, 22);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(134, 23);
            this.txtID.TabIndex = 0;
            // 
            // gpbResultados
            // 
            this.gpbResultados.Controls.Add(this.lblInfo);
            this.gpbResultados.Controls.Add(this.dgvResultados);
            this.gpbResultados.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.gpbResultados.Location = new System.Drawing.Point(12, 72);
            this.gpbResultados.Name = "gpbResultados";
            this.gpbResultados.Size = new System.Drawing.Size(890, 306);
            this.gpbResultados.TabIndex = 2;
            this.gpbResultados.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblInfo.Location = new System.Drawing.Point(6, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(382, 16);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Text = "De um duplo clique na linha desejada para abrir mais detalhes...";
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnimalID,
            this.AnimalDescricao,
            this.AnimalIdentificador,
            this.RacaNome,
            this.PiqueteDescricao});
            this.dgvResultados.Location = new System.Drawing.Point(6, 43);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(875, 257);
            this.dgvResultados.TabIndex = 0;
            this.dgvResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResultados_CellDoubleClick);
            this.dgvResultados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvResultados_CellFormatting);
            // 
            // AnimalID
            // 
            this.AnimalID.DataPropertyName = "AnimalID";
            this.AnimalID.HeaderText = "ID";
            this.AnimalID.MinimumWidth = 100;
            this.AnimalID.Name = "AnimalID";
            this.AnimalID.ReadOnly = true;
            // 
            // AnimalDescricao
            // 
            this.AnimalDescricao.DataPropertyName = "AnimalDescricao";
            this.AnimalDescricao.HeaderText = "Descrição";
            this.AnimalDescricao.MinimumWidth = 300;
            this.AnimalDescricao.Name = "AnimalDescricao";
            this.AnimalDescricao.ReadOnly = true;
            this.AnimalDescricao.Width = 300;
            // 
            // AnimalIdentificador
            // 
            this.AnimalIdentificador.DataPropertyName = "AnimalIdentificador";
            this.AnimalIdentificador.HeaderText = "Identificador";
            this.AnimalIdentificador.Name = "AnimalIdentificador";
            this.AnimalIdentificador.ReadOnly = true;
            // 
            // RacaNome
            // 
            this.RacaNome.DataPropertyName = "Raca.RacaNome";
            this.RacaNome.HeaderText = "Raça";
            this.RacaNome.Name = "RacaNome";
            this.RacaNome.ReadOnly = true;
            this.RacaNome.Width = 130;
            // 
            // PiqueteDescricao
            // 
            this.PiqueteDescricao.DataPropertyName = "Piquete.PiqueteDescricao";
            this.PiqueteDescricao.HeaderText = "Piquete";
            this.PiqueteDescricao.Name = "PiqueteDescricao";
            this.PiqueteDescricao.ReadOnly = true;
            this.PiqueteDescricao.Width = 200;
            // 
            // gpbOpcao
            // 
            this.gpbOpcao.Controls.Add(this.rbRaca);
            this.gpbOpcao.Controls.Add(this.rbPiquete);
            this.gpbOpcao.Controls.Add(this.rbIdentificacao);
            this.gpbOpcao.Controls.Add(this.rbDescricao);
            this.gpbOpcao.Controls.Add(this.rbID);
            this.gpbOpcao.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.gpbOpcao.Location = new System.Drawing.Point(12, 12);
            this.gpbOpcao.Name = "gpbOpcao";
            this.gpbOpcao.Size = new System.Drawing.Size(388, 54);
            this.gpbOpcao.TabIndex = 0;
            this.gpbOpcao.TabStop = false;
            this.gpbOpcao.Text = "Opção de consulta:";
            // 
            // rbRaca
            // 
            this.rbRaca.AutoSize = true;
            this.rbRaca.Location = new System.Drawing.Point(326, 22);
            this.rbRaca.Name = "rbRaca";
            this.rbRaca.Size = new System.Drawing.Size(54, 20);
            this.rbRaca.TabIndex = 4;
            this.rbRaca.Text = "Raça";
            this.rbRaca.UseVisualStyleBackColor = true;
            this.rbRaca.CheckedChanged += new System.EventHandler(this.rbRaca_CheckedChanged);
            // 
            // rbPiquete
            // 
            this.rbPiquete.AutoSize = true;
            this.rbPiquete.Location = new System.Drawing.Point(248, 22);
            this.rbPiquete.Name = "rbPiquete";
            this.rbPiquete.Size = new System.Drawing.Size(72, 20);
            this.rbPiquete.TabIndex = 3;
            this.rbPiquete.Text = "Piquete";
            this.rbPiquete.UseVisualStyleBackColor = true;
            this.rbPiquete.CheckedChanged += new System.EventHandler(this.rbPiquete_CheckedChanged);
            // 
            // rbIdentificacao
            // 
            this.rbIdentificacao.AutoSize = true;
            this.rbIdentificacao.Location = new System.Drawing.Point(140, 22);
            this.rbIdentificacao.Name = "rbIdentificacao";
            this.rbIdentificacao.Size = new System.Drawing.Size(102, 20);
            this.rbIdentificacao.TabIndex = 2;
            this.rbIdentificacao.Text = "Identificação";
            this.rbIdentificacao.UseVisualStyleBackColor = true;
            this.rbIdentificacao.CheckedChanged += new System.EventHandler(this.rbIdentificacao_CheckedChanged);
            // 
            // rbDescricao
            // 
            this.rbDescricao.AutoSize = true;
            this.rbDescricao.Location = new System.Drawing.Point(51, 22);
            this.rbDescricao.Name = "rbDescricao";
            this.rbDescricao.Size = new System.Drawing.Size(83, 20);
            this.rbDescricao.TabIndex = 1;
            this.rbDescricao.Text = "Descrição";
            this.rbDescricao.UseVisualStyleBackColor = true;
            this.rbDescricao.CheckedChanged += new System.EventHandler(this.rbDescricao_CheckedChanged);
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Checked = true;
            this.rbID.Location = new System.Drawing.Point(6, 22);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(39, 20);
            this.rbID.TabIndex = 0;
            this.rbID.TabStop = true;
            this.rbID.Text = "ID";
            this.rbID.UseVisualStyleBackColor = true;
            this.rbID.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // gpbIdentificador
            // 
            this.gpbIdentificador.Controls.Add(this.txtIdentificador);
            this.gpbIdentificador.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.gpbIdentificador.Location = new System.Drawing.Point(406, 12);
            this.gpbIdentificador.Name = "gpbIdentificador";
            this.gpbIdentificador.Size = new System.Drawing.Size(294, 54);
            this.gpbIdentificador.TabIndex = 1;
            this.gpbIdentificador.TabStop = false;
            this.gpbIdentificador.Visible = false;
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtIdentificador.Location = new System.Drawing.Point(5, 21);
            this.txtIdentificador.MaxLength = 8;
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(281, 23);
            this.txtIdentificador.TabIndex = 0;
            // 
            // gpbPiquete
            // 
            this.gpbPiquete.Controls.Add(this.btnBuscarPiquete);
            this.gpbPiquete.Controls.Add(this.txtPiquete);
            this.gpbPiquete.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.gpbPiquete.Location = new System.Drawing.Point(406, 12);
            this.gpbPiquete.Name = "gpbPiquete";
            this.gpbPiquete.Size = new System.Drawing.Size(330, 61);
            this.gpbPiquete.TabIndex = 1;
            this.gpbPiquete.TabStop = false;
            this.gpbPiquete.Visible = false;
            // 
            // btnBuscarPiquete
            // 
            this.btnBuscarPiquete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarPiquete.FlatAppearance.BorderSize = 0;
            this.btnBuscarPiquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPiquete.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPiquete.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPiquete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPiquete.Location = new System.Drawing.Point(136, 13);
            this.btnBuscarPiquete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarPiquete.Name = "btnBuscarPiquete";
            this.btnBuscarPiquete.Size = new System.Drawing.Size(185, 42);
            this.btnBuscarPiquete.TabIndex = 1;
            this.btnBuscarPiquete.Text = "Buscar Piquete";
            this.btnBuscarPiquete.UseVisualStyleBackColor = false;
            // 
            // txtPiquete
            // 
            this.txtPiquete.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtPiquete.Location = new System.Drawing.Point(5, 23);
            this.txtPiquete.Name = "txtPiquete";
            this.txtPiquete.Size = new System.Drawing.Size(125, 23);
            this.txtPiquete.TabIndex = 0;
            // 
            // gpbRaca
            // 
            this.gpbRaca.Controls.Add(this.cbbRaca);
            this.gpbRaca.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.gpbRaca.Location = new System.Drawing.Point(406, 12);
            this.gpbRaca.Name = "gpbRaca";
            this.gpbRaca.Size = new System.Drawing.Size(250, 61);
            this.gpbRaca.TabIndex = 1;
            this.gpbRaca.TabStop = false;
            this.gpbRaca.Visible = false;
            // 
            // cbbRaca
            // 
            this.cbbRaca.FormattingEnabled = true;
            this.cbbRaca.Location = new System.Drawing.Point(6, 22);
            this.cbbRaca.Name = "cbbRaca";
            this.cbbRaca.Size = new System.Drawing.Size(237, 24);
            this.cbbRaca.TabIndex = 37;
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbRaca);
            this.panelInside.Controls.Add(this.gpbOpcao);
            this.panelInside.Controls.Add(this.gpbPiquete);
            this.panelInside.Controls.Add(this.gpbResultados);
            this.panelInside.Controls.Add(this.gpbID);
            this.panelInside.Controls.Add(this.gpbDescricao);
            this.panelInside.Controls.Add(this.gpbIdentificador);
            this.panelInside.Controls.Add(this.btnConsultar);
            this.panelInside.Location = new System.Drawing.Point(12, 63);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(914, 464);
            this.panelInside.TabIndex = 16;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(663, 384);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(239, 68);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(189, 24);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Consulta de Animal";
            // 
            // frmConsultaAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(939, 537);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultaAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaAnimal";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.gpbDescricao.ResumeLayout(false);
            this.gpbDescricao.PerformLayout();
            this.gpbID.ResumeLayout(false);
            this.gpbID.PerformLayout();
            this.gpbResultados.ResumeLayout(false);
            this.gpbResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.gpbOpcao.ResumeLayout(false);
            this.gpbOpcao.PerformLayout();
            this.gpbIdentificador.ResumeLayout(false);
            this.gpbIdentificador.PerformLayout();
            this.gpbPiquete.ResumeLayout(false);
            this.gpbPiquete.PerformLayout();
            this.gpbRaca.ResumeLayout(false);
            this.panelInside.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gpbDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.GroupBox gpbResultados;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.GroupBox gpbOpcao;
        private System.Windows.Forms.RadioButton rbDescricao;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.RadioButton rbRaca;
        private System.Windows.Forms.RadioButton rbPiquete;
        private System.Windows.Forms.RadioButton rbIdentificacao;
        private System.Windows.Forms.GroupBox gpbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox gpbIdentificador;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.GroupBox gpbPiquete;
        private System.Windows.Forms.TextBox txtPiquete;
        private System.Windows.Forms.GroupBox gpbRaca;
        private System.Windows.Forms.Button btnBuscarPiquete;
        private System.Windows.Forms.ComboBox cbbRaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn RacaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiqueteDescricao;
        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblTitulo;
    }
}