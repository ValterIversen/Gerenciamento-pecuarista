namespace Apresentacao.Item
{
    partial class frmConsultaItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaItem));
            this.panel2 = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelInside = new System.Windows.Forms.Panel();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoItemDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbID = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.gpbTipoItem = new System.Windows.Forms.GroupBox();
            this.cbbTipoItem = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.gpbOpcao = new System.Windows.Forms.GroupBox();
            this.rbTipo = new System.Windows.Forms.RadioButton();
            this.rbDescricao = new System.Windows.Forms.RadioButton();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbDescricao = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panelInside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.gpbID.SuspendLayout();
            this.gpbTipoItem.SuspendLayout();
            this.gpbOpcao.SuspendLayout();
            this.gpbDescricao.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(642, 45);
            this.panel2.TabIndex = 31;
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(599, 4);
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
            this.panel4.Size = new System.Drawing.Size(642, 15);
            this.panel4.TabIndex = 32;
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.dgvResultados);
            this.panelInside.Controls.Add(this.gpbID);
            this.panelInside.Controls.Add(this.gpbTipoItem);
            this.panelInside.Controls.Add(this.gpbOpcao);
            this.panelInside.Controls.Add(this.btnCadastrar);
            this.panelInside.Controls.Add(this.gpbDescricao);
            this.panelInside.Location = new System.Drawing.Point(12, 64);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(615, 489);
            this.panelInside.TabIndex = 0;
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemDescricao,
            this.TipoItemDescricao});
            this.dgvResultados.Location = new System.Drawing.Point(10, 105);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(593, 297);
            this.dgvResultados.TabIndex = 2;
            this.dgvResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResultados_CellDoubleClick);
            this.dgvResultados.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvResultados_CellFormatting);
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Width = 80;
            // 
            // ItemDescricao
            // 
            this.ItemDescricao.DataPropertyName = "ItemDescricao";
            this.ItemDescricao.HeaderText = "Descrição";
            this.ItemDescricao.Name = "ItemDescricao";
            this.ItemDescricao.ReadOnly = true;
            this.ItemDescricao.Width = 300;
            // 
            // TipoItemDescricao
            // 
            this.TipoItemDescricao.DataPropertyName = "TipoItem.TipoItemDescricao";
            this.TipoItemDescricao.HeaderText = "Tipo de Item";
            this.TipoItemDescricao.Name = "TipoItemDescricao";
            this.TipoItemDescricao.ReadOnly = true;
            this.TipoItemDescricao.Width = 170;
            // 
            // gpbID
            // 
            this.gpbID.Controls.Add(this.txtID);
            this.gpbID.Controls.Add(this.lblID);
            this.gpbID.Location = new System.Drawing.Point(226, 3);
            this.gpbID.Name = "gpbID";
            this.gpbID.Size = new System.Drawing.Size(181, 55);
            this.gpbID.TabIndex = 1;
            this.gpbID.TabStop = false;
            this.gpbID.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(53, 18);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 13;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtID_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(22, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 16);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID:";
            // 
            // gpbTipoItem
            // 
            this.gpbTipoItem.Controls.Add(this.cbbTipoItem);
            this.gpbTipoItem.Controls.Add(this.lblTipo);
            this.gpbTipoItem.Location = new System.Drawing.Point(226, 3);
            this.gpbTipoItem.Name = "gpbTipoItem";
            this.gpbTipoItem.Size = new System.Drawing.Size(336, 55);
            this.gpbTipoItem.TabIndex = 1;
            this.gpbTipoItem.TabStop = false;
            this.gpbTipoItem.Visible = false;
            // 
            // cbbTipoItem
            // 
            this.cbbTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoItem.FormattingEnabled = true;
            this.cbbTipoItem.Location = new System.Drawing.Point(131, 18);
            this.cbbTipoItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbTipoItem.Name = "cbbTipoItem";
            this.cbbTipoItem.Size = new System.Drawing.Size(177, 24);
            this.cbbTipoItem.TabIndex = 13;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(22, 21);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(86, 16);
            this.lblTipo.TabIndex = 12;
            this.lblTipo.Text = "Tipo do Item:";
            // 
            // gpbOpcao
            // 
            this.gpbOpcao.Controls.Add(this.rbTipo);
            this.gpbOpcao.Controls.Add(this.rbDescricao);
            this.gpbOpcao.Controls.Add(this.rbID);
            this.gpbOpcao.Location = new System.Drawing.Point(10, 3);
            this.gpbOpcao.Name = "gpbOpcao";
            this.gpbOpcao.Size = new System.Drawing.Size(210, 55);
            this.gpbOpcao.TabIndex = 0;
            this.gpbOpcao.TabStop = false;
            this.gpbOpcao.Text = "Consulta de Itens";
            // 
            // rbTipo
            // 
            this.rbTipo.AutoSize = true;
            this.rbTipo.Location = new System.Drawing.Point(141, 23);
            this.rbTipo.Name = "rbTipo";
            this.rbTipo.Size = new System.Drawing.Size(52, 20);
            this.rbTipo.TabIndex = 2;
            this.rbTipo.Text = "Tipo";
            this.rbTipo.UseVisualStyleBackColor = true;
            this.rbTipo.CheckedChanged += new System.EventHandler(this.RbTipo_CheckedChanged);
            // 
            // rbDescricao
            // 
            this.rbDescricao.AutoSize = true;
            this.rbDescricao.Checked = true;
            this.rbDescricao.Location = new System.Drawing.Point(52, 22);
            this.rbDescricao.Name = "rbDescricao";
            this.rbDescricao.Size = new System.Drawing.Size(83, 20);
            this.rbDescricao.TabIndex = 1;
            this.rbDescricao.TabStop = true;
            this.rbDescricao.Text = "Descrição";
            this.rbDescricao.UseVisualStyleBackColor = true;
            this.rbDescricao.CheckedChanged += new System.EventHandler(this.RbDescricao_CheckedChanged);
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Location = new System.Drawing.Point(7, 23);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(39, 20);
            this.rbID.TabIndex = 0;
            this.rbID.Text = "ID";
            this.rbID.UseVisualStyleBackColor = true;
            this.rbID.CheckedChanged += new System.EventHandler(this.RbID_CheckedChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(364, 409);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(239, 68);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Consultar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // gpbDescricao
            // 
            this.gpbDescricao.Controls.Add(this.txtDescricao);
            this.gpbDescricao.Controls.Add(this.lblDescricao);
            this.gpbDescricao.Location = new System.Drawing.Point(226, 3);
            this.gpbDescricao.Name = "gpbDescricao";
            this.gpbDescricao.Size = new System.Drawing.Size(336, 96);
            this.gpbDescricao.TabIndex = 1;
            this.gpbDescricao.TabStop = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(106, 26);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(202, 60);
            this.txtDescricao.TabIndex = 8;
            this.txtDescricao.Text = "";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(20, 29);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 16);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(166, 24);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Consulta de Item";
            // 
            // frmConsultaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(642, 561);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultaItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaItem";
            this.Load += new System.EventHandler(this.FrmConsultaItem_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panelInside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.gpbID.ResumeLayout(false);
            this.gpbID.PerformLayout();
            this.gpbTipoItem.ResumeLayout(false);
            this.gpbTipoItem.PerformLayout();
            this.gpbOpcao.ResumeLayout(false);
            this.gpbOpcao.PerformLayout();
            this.gpbDescricao.ResumeLayout(false);
            this.gpbDescricao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gpbDescricao;
        private System.Windows.Forms.ComboBox cbbTipoItem;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.GroupBox gpbTipoItem;
        private System.Windows.Forms.GroupBox gpbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gpbOpcao;
        private System.Windows.Forms.RadioButton rbTipo;
        private System.Windows.Forms.RadioButton rbDescricao;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoItemDescricao;
        private System.Windows.Forms.Label lblTitulo;
    }
}