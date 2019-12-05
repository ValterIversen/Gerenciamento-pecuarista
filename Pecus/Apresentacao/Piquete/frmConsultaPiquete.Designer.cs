namespace Apresentacao.Piquete
{
    partial class frmConsultaPiquete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPiquete));
            this.panel4 = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelInside = new System.Windows.Forms.Panel();
            this.gpbDataGridView = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.PiqueteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PiqueteDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PiqueteAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PastoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PiqueteQuantidadeAnimais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gpbPasto = new System.Windows.Forms.GroupBox();
            this.btnBuscarPasto = new System.Windows.Forms.Button();
            this.txtPasto = new System.Windows.Forms.TextBox();
            this.lblPasto = new System.Windows.Forms.Label();
            this.gpbID = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbPasto = new System.Windows.Forms.RadioButton();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panelInside.SuspendLayout();
            this.gpbDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.gpbPasto.SuspendLayout();
            this.gpbID.SuspendLayout();
            this.gpbOpcoes.SuspendLayout();
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
            this.panel4.Size = new System.Drawing.Size(710, 45);
            this.panel4.TabIndex = 13;
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(667, 4);
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
            this.panel2.Size = new System.Drawing.Size(710, 15);
            this.panel2.TabIndex = 12;
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbDataGridView);
            this.panelInside.Controls.Add(this.gpbPasto);
            this.panelInside.Controls.Add(this.gpbID);
            this.panelInside.Controls.Add(this.gpbOpcoes);
            this.panelInside.Location = new System.Drawing.Point(13, 68);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(684, 515);
            this.panelInside.TabIndex = 14;
            // 
            // gpbDataGridView
            // 
            this.gpbDataGridView.Controls.Add(this.btnConsultar);
            this.gpbDataGridView.Controls.Add(this.dgvResultados);
            this.gpbDataGridView.Controls.Add(this.lblInfo);
            this.gpbDataGridView.Location = new System.Drawing.Point(12, 92);
            this.gpbDataGridView.Name = "gpbDataGridView";
            this.gpbDataGridView.Size = new System.Drawing.Size(658, 409);
            this.gpbDataGridView.TabIndex = 2;
            this.gpbDataGridView.TabStop = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(411, 331);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(239, 68);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PiqueteID,
            this.PiqueteDescricao,
            this.PiqueteAtivo,
            this.PastoID,
            this.PiqueteQuantidadeAnimais});
            this.dgvResultados.Location = new System.Drawing.Point(6, 38);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(644, 285);
            this.dgvResultados.TabIndex = 0;
            this.dgvResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResultados_CellDoubleClick);
            this.dgvResultados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvResultados_CellFormatting);
            // 
            // PiqueteID
            // 
            this.PiqueteID.DataPropertyName = "PiqueteID";
            this.PiqueteID.HeaderText = "ID";
            this.PiqueteID.Name = "PiqueteID";
            this.PiqueteID.ReadOnly = true;
            this.PiqueteID.Width = 80;
            // 
            // PiqueteDescricao
            // 
            this.PiqueteDescricao.DataPropertyName = "PiqueteDescricao";
            this.PiqueteDescricao.HeaderText = "Descrição";
            this.PiqueteDescricao.Name = "PiqueteDescricao";
            this.PiqueteDescricao.ReadOnly = true;
            this.PiqueteDescricao.Width = 200;
            // 
            // PiqueteAtivo
            // 
            this.PiqueteAtivo.DataPropertyName = "PiqueteAtivo";
            this.PiqueteAtivo.HeaderText = "Ativo";
            this.PiqueteAtivo.Name = "PiqueteAtivo";
            this.PiqueteAtivo.ReadOnly = true;
            // 
            // PastoID
            // 
            this.PastoID.DataPropertyName = "Pasto.PastoID";
            this.PastoID.HeaderText = "Pasto";
            this.PastoID.Name = "PastoID";
            this.PastoID.ReadOnly = true;
            this.PastoID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PastoID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PastoID.Width = 80;
            // 
            // PiqueteQuantidadeAnimais
            // 
            this.PiqueteQuantidadeAnimais.DataPropertyName = "PiqueteQuantidadeAnimais";
            this.PiqueteQuantidadeAnimais.HeaderText = "Qtd animais";
            this.PiqueteQuantidadeAnimais.Name = "PiqueteQuantidadeAnimais";
            this.PiqueteQuantidadeAnimais.ReadOnly = true;
            this.PiqueteQuantidadeAnimais.Width = 140;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblInfo.Location = new System.Drawing.Point(6, 19);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(382, 16);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "De um duplo clique na linha desejada para abrir mais detalhes...";
            // 
            // gpbPasto
            // 
            this.gpbPasto.Controls.Add(this.btnBuscarPasto);
            this.gpbPasto.Controls.Add(this.txtPasto);
            this.gpbPasto.Controls.Add(this.lblPasto);
            this.gpbPasto.Location = new System.Drawing.Point(165, 3);
            this.gpbPasto.Name = "gpbPasto";
            this.gpbPasto.Size = new System.Drawing.Size(343, 73);
            this.gpbPasto.TabIndex = 1;
            this.gpbPasto.TabStop = false;
            this.gpbPasto.Visible = false;
            // 
            // btnBuscarPasto
            // 
            this.btnBuscarPasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarPasto.FlatAppearance.BorderSize = 0;
            this.btnBuscarPasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPasto.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPasto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPasto.Location = new System.Drawing.Point(166, 20);
            this.btnBuscarPasto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarPasto.Name = "btnBuscarPasto";
            this.btnBuscarPasto.Size = new System.Drawing.Size(165, 42);
            this.btnBuscarPasto.TabIndex = 15;
            this.btnBuscarPasto.Text = "Buscar Pasto";
            this.btnBuscarPasto.UseVisualStyleBackColor = false;
            this.btnBuscarPasto.Click += new System.EventHandler(this.BtnBuscarPasto_Click);
            // 
            // txtPasto
            // 
            this.txtPasto.Enabled = false;
            this.txtPasto.Location = new System.Drawing.Point(51, 30);
            this.txtPasto.Name = "txtPasto";
            this.txtPasto.Size = new System.Drawing.Size(109, 23);
            this.txtPasto.TabIndex = 1;
            // 
            // lblPasto
            // 
            this.lblPasto.AutoSize = true;
            this.lblPasto.Location = new System.Drawing.Point(6, 33);
            this.lblPasto.Name = "lblPasto";
            this.lblPasto.Size = new System.Drawing.Size(45, 16);
            this.lblPasto.TabIndex = 0;
            this.lblPasto.Text = "Pasto:";
            // 
            // gpbID
            // 
            this.gpbID.Controls.Add(this.txtID);
            this.gpbID.Controls.Add(this.lblID);
            this.gpbID.Location = new System.Drawing.Point(165, 12);
            this.gpbID.Name = "gpbID";
            this.gpbID.Size = new System.Drawing.Size(160, 50);
            this.gpbID.TabIndex = 1;
            this.gpbID.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(36, 20);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(109, 23);
            this.txtID.TabIndex = 1;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtID_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.rbPasto);
            this.gpbOpcoes.Controls.Add(this.rbID);
            this.gpbOpcoes.Location = new System.Drawing.Point(12, 13);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(147, 49);
            this.gpbOpcoes.TabIndex = 0;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Opções de consulta";
            // 
            // rbPasto
            // 
            this.rbPasto.AutoSize = true;
            this.rbPasto.Location = new System.Drawing.Point(51, 22);
            this.rbPasto.Name = "rbPasto";
            this.rbPasto.Size = new System.Drawing.Size(60, 20);
            this.rbPasto.TabIndex = 1;
            this.rbPasto.Text = "Pasto";
            this.rbPasto.UseVisualStyleBackColor = true;
            this.rbPasto.CheckedChanged += new System.EventHandler(this.RbPasto_CheckedChanged);
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
            this.rbID.CheckedChanged += new System.EventHandler(this.RbID_CheckedChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(194, 24);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Consulta de Piquete";
            // 
            // frmConsultaPiquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(710, 593);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultaPiquete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaPiquete";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panelInside.ResumeLayout(false);
            this.gpbDataGridView.ResumeLayout(false);
            this.gpbDataGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.gpbPasto.ResumeLayout(false);
            this.gpbPasto.PerformLayout();
            this.gpbID.ResumeLayout(false);
            this.gpbID.PerformLayout();
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.GroupBox gpbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.RadioButton rbPasto;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.GroupBox gpbPasto;
        private System.Windows.Forms.TextBox txtPasto;
        private System.Windows.Forms.Label lblPasto;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBuscarPasto;
        private System.Windows.Forms.GroupBox gpbDataGridView;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiqueteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiqueteDescricao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PiqueteAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiqueteQuantidadeAnimais;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblTitulo;
    }
}