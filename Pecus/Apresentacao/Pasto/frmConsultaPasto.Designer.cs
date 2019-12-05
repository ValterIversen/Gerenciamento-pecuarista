namespace Apresentacao.Pasto
{
    partial class frmConsultaPasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPasto));
            this.panel4 = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelInside = new System.Windows.Forms.Panel();
            this.gpbID = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gpbCidade = new System.Windows.Forms.GroupBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbbCidade = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.gpbContratoAluguel = new System.Windows.Forms.GroupBox();
            this.txtContratoAluguel = new System.Windows.Forms.TextBox();
            this.btnBuscarContratoAluguel = new System.Windows.Forms.Button();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.PastoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastoDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastoTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastoAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CidadeNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbDescricao = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gpbOpc = new System.Windows.Forms.GroupBox();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.rbContratoAluguel = new System.Windows.Forms.RadioButton();
            this.rbCidade = new System.Windows.Forms.RadioButton();
            this.rbDescricao = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panelInside.SuspendLayout();
            this.gpbID.SuspendLayout();
            this.gpbCidade.SuspendLayout();
            this.gpbContratoAluguel.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.gpbDescricao.SuspendLayout();
            this.gpbOpc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.panel4.Controls.Add(this.lblTitulo);
            this.panel4.Controls.Add(this.picExit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 18);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(778, 45);
            this.panel4.TabIndex = 18;
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(735, 5);
            this.picExit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 18);
            this.panel2.TabIndex = 17;
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbID);
            this.panelInside.Controls.Add(this.gpbCidade);
            this.panelInside.Controls.Add(this.gpbContratoAluguel);
            this.panelInside.Controls.Add(this.gpbResultado);
            this.panelInside.Controls.Add(this.gpbDescricao);
            this.panelInside.Controls.Add(this.gpbOpc);
            this.panelInside.Controls.Add(this.btnConsultar);
            this.panelInside.Location = new System.Drawing.Point(13, 72);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(752, 567);
            this.panelInside.TabIndex = 19;
            // 
            // gpbID
            // 
            this.gpbID.Controls.Add(this.txtID);
            this.gpbID.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbID.Location = new System.Drawing.Point(399, 16);
            this.gpbID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbID.Name = "gpbID";
            this.gpbID.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbID.Size = new System.Drawing.Size(203, 57);
            this.gpbID.TabIndex = 1;
            this.gpbID.TabStop = false;
            this.gpbID.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(17, 22);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(165, 23);
            this.txtID.TabIndex = 25;
            // 
            // gpbCidade
            // 
            this.gpbCidade.Controls.Add(this.cbbEstado);
            this.gpbCidade.Controls.Add(this.lblEstado);
            this.gpbCidade.Controls.Add(this.cbbCidade);
            this.gpbCidade.Controls.Add(this.lblCidade);
            this.gpbCidade.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCidade.Location = new System.Drawing.Point(399, 16);
            this.gpbCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbCidade.Name = "gpbCidade";
            this.gpbCidade.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbCidade.Size = new System.Drawing.Size(340, 91);
            this.gpbCidade.TabIndex = 1;
            this.gpbCidade.TabStop = false;
            this.gpbCidade.Visible = false;
            // 
            // cbbEstado
            // 
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(88, 23);
            this.cbbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(177, 24);
            this.cbbEstado.TabIndex = 0;
            this.cbbEstado.SelectedIndexChanged += new System.EventHandler(this.CbbEstado_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(30, 26);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 16);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado:";
            // 
            // cbbCidade
            // 
            this.cbbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCidade.FormattingEnabled = true;
            this.cbbCidade.Location = new System.Drawing.Point(88, 53);
            this.cbbCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbCidade.Name = "cbbCidade";
            this.cbbCidade.Size = new System.Drawing.Size(177, 24);
            this.cbbCidade.TabIndex = 1;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(30, 56);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 16);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "Cidade:";
            // 
            // gpbContratoAluguel
            // 
            this.gpbContratoAluguel.Controls.Add(this.txtContratoAluguel);
            this.gpbContratoAluguel.Controls.Add(this.btnBuscarContratoAluguel);
            this.gpbContratoAluguel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbContratoAluguel.Location = new System.Drawing.Point(399, 16);
            this.gpbContratoAluguel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbContratoAluguel.Name = "gpbContratoAluguel";
            this.gpbContratoAluguel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbContratoAluguel.Size = new System.Drawing.Size(340, 91);
            this.gpbContratoAluguel.TabIndex = 1;
            this.gpbContratoAluguel.TabStop = false;
            this.gpbContratoAluguel.Visible = false;
            // 
            // txtContratoAluguel
            // 
            this.txtContratoAluguel.Location = new System.Drawing.Point(20, 40);
            this.txtContratoAluguel.Name = "txtContratoAluguel";
            this.txtContratoAluguel.Size = new System.Drawing.Size(109, 23);
            this.txtContratoAluguel.TabIndex = 25;
            // 
            // btnBuscarContratoAluguel
            // 
            this.btnBuscarContratoAluguel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarContratoAluguel.FlatAppearance.BorderSize = 0;
            this.btnBuscarContratoAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarContratoAluguel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarContratoAluguel.ForeColor = System.Drawing.Color.White;
            this.btnBuscarContratoAluguel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarContratoAluguel.Location = new System.Drawing.Point(135, 30);
            this.btnBuscarContratoAluguel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarContratoAluguel.Name = "btnBuscarContratoAluguel";
            this.btnBuscarContratoAluguel.Size = new System.Drawing.Size(185, 42);
            this.btnBuscarContratoAluguel.TabIndex = 24;
            this.btnBuscarContratoAluguel.Text = "Buscar Contrato de Aluguel";
            this.btnBuscarContratoAluguel.UseVisualStyleBackColor = false;
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.dgvResultado);
            this.gpbResultado.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbResultado.Location = new System.Drawing.Point(12, 115);
            this.gpbResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbResultado.Size = new System.Drawing.Size(727, 366);
            this.gpbResultado.TabIndex = 2;
            this.gpbResultado.TabStop = false;
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PastoID,
            this.PastoDescricao,
            this.PastoTamanho,
            this.PastoAtivo,
            this.CidadeNome});
            this.dgvResultado.Location = new System.Drawing.Point(7, 24);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(714, 335);
            this.dgvResultado.TabIndex = 0;
            this.dgvResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResultado_CellDoubleClick);
            this.dgvResultado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvResultado_CellFormatting);
            // 
            // PastoID
            // 
            this.PastoID.DataPropertyName = "PastoID";
            this.PastoID.HeaderText = "ID";
            this.PastoID.Name = "PastoID";
            this.PastoID.ReadOnly = true;
            this.PastoID.Width = 80;
            // 
            // PastoDescricao
            // 
            this.PastoDescricao.DataPropertyName = "PastoDescricao";
            this.PastoDescricao.HeaderText = "Descrição";
            this.PastoDescricao.Name = "PastoDescricao";
            this.PastoDescricao.ReadOnly = true;
            this.PastoDescricao.Width = 280;
            // 
            // PastoTamanho
            // 
            this.PastoTamanho.DataPropertyName = "PastoTamanho";
            this.PastoTamanho.HeaderText = "Tamanho";
            this.PastoTamanho.Name = "PastoTamanho";
            this.PastoTamanho.ReadOnly = true;
            // 
            // PastoAtivo
            // 
            this.PastoAtivo.DataPropertyName = "PastoAtivo";
            this.PastoAtivo.HeaderText = "Ativo";
            this.PastoAtivo.Name = "PastoAtivo";
            this.PastoAtivo.ReadOnly = true;
            this.PastoAtivo.Width = 60;
            // 
            // CidadeNome
            // 
            this.CidadeNome.DataPropertyName = "Cidade.CidadeNome";
            this.CidadeNome.HeaderText = "Cidade";
            this.CidadeNome.Name = "CidadeNome";
            this.CidadeNome.ReadOnly = true;
            this.CidadeNome.Width = 150;
            // 
            // gpbDescricao
            // 
            this.gpbDescricao.Controls.Add(this.txtDescricao);
            this.gpbDescricao.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDescricao.Location = new System.Drawing.Point(399, 16);
            this.gpbDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbDescricao.Name = "gpbDescricao";
            this.gpbDescricao.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbDescricao.Size = new System.Drawing.Size(340, 57);
            this.gpbDescricao.TabIndex = 1;
            this.gpbDescricao.TabStop = false;
            this.gpbDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(17, 22);
            this.txtDescricao.MaxLength = 60;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(317, 23);
            this.txtDescricao.TabIndex = 0;
            // 
            // gpbOpc
            // 
            this.gpbOpc.Controls.Add(this.rbID);
            this.gpbOpc.Controls.Add(this.rbContratoAluguel);
            this.gpbOpc.Controls.Add(this.rbCidade);
            this.gpbOpc.Controls.Add(this.rbDescricao);
            this.gpbOpc.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOpc.Location = new System.Drawing.Point(12, 16);
            this.gpbOpc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbOpc.Name = "gpbOpc";
            this.gpbOpc.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbOpc.Size = new System.Drawing.Size(381, 57);
            this.gpbOpc.TabIndex = 0;
            this.gpbOpc.TabStop = false;
            this.gpbOpc.Text = "Opções de consulta";
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Location = new System.Drawing.Point(332, 23);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(39, 20);
            this.rbID.TabIndex = 3;
            this.rbID.Text = "ID";
            this.rbID.UseVisualStyleBackColor = true;
            this.rbID.CheckedChanged += new System.EventHandler(this.RbID_CheckedChanged);
            // 
            // rbContratoAluguel
            // 
            this.rbContratoAluguel.AutoSize = true;
            this.rbContratoAluguel.Location = new System.Drawing.Point(179, 23);
            this.rbContratoAluguel.Name = "rbContratoAluguel";
            this.rbContratoAluguel.Size = new System.Drawing.Size(147, 20);
            this.rbContratoAluguel.TabIndex = 2;
            this.rbContratoAluguel.Text = "Contrato de Aluguel";
            this.rbContratoAluguel.UseVisualStyleBackColor = true;
            this.rbContratoAluguel.CheckedChanged += new System.EventHandler(this.RbContratoAluguel_CheckedChanged);
            // 
            // rbCidade
            // 
            this.rbCidade.AutoSize = true;
            this.rbCidade.Location = new System.Drawing.Point(106, 23);
            this.rbCidade.Name = "rbCidade";
            this.rbCidade.Size = new System.Drawing.Size(67, 20);
            this.rbCidade.TabIndex = 1;
            this.rbCidade.Text = "Cidade";
            this.rbCidade.UseVisualStyleBackColor = true;
            this.rbCidade.CheckedChanged += new System.EventHandler(this.RbCidade_CheckedChanged);
            // 
            // rbDescricao
            // 
            this.rbDescricao.AutoSize = true;
            this.rbDescricao.Checked = true;
            this.rbDescricao.Location = new System.Drawing.Point(17, 23);
            this.rbDescricao.Name = "rbDescricao";
            this.rbDescricao.Size = new System.Drawing.Size(83, 20);
            this.rbDescricao.TabIndex = 0;
            this.rbDescricao.TabStop = true;
            this.rbDescricao.Text = "Descrição";
            this.rbDescricao.UseVisualStyleBackColor = true;
            this.rbDescricao.CheckedChanged += new System.EventHandler(this.RbDescricao_CheckedChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(500, 490);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(239, 68);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(175, 24);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Consulta de Pasto";
            // 
            // frmConsultaPasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(778, 650);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultaPasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaPasto";
            this.Load += new System.EventHandler(this.FrmConsultaPasto_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panelInside.ResumeLayout(false);
            this.gpbID.ResumeLayout(false);
            this.gpbID.PerformLayout();
            this.gpbCidade.ResumeLayout(false);
            this.gpbCidade.PerformLayout();
            this.gpbContratoAluguel.ResumeLayout(false);
            this.gpbContratoAluguel.PerformLayout();
            this.gpbResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.gpbDescricao.ResumeLayout(false);
            this.gpbDescricao.PerformLayout();
            this.gpbOpc.ResumeLayout(false);
            this.gpbOpc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.GroupBox gpbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox gpbCidade;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbbCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.GroupBox gpbContratoAluguel;
        private System.Windows.Forms.TextBox txtContratoAluguel;
        private System.Windows.Forms.Button btnBuscarContratoAluguel;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.GroupBox gpbDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.GroupBox gpbOpc;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.RadioButton rbContratoAluguel;
        private System.Windows.Forms.RadioButton rbCidade;
        private System.Windows.Forms.RadioButton rbDescricao;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastoDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastoTamanho;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PastoAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidadeNome;
        private System.Windows.Forms.Label lblTitulo;
    }
}