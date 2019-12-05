namespace Apresentacao.Estoque
{
    partial class frmConsultaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaEstoque));
            this.panelInside = new System.Windows.Forms.Panel();
            this.gpbItem = new System.Windows.Forms.GroupBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.gpbEstoqueLocalidade = new System.Windows.Forms.GroupBox();
            this.lblEstoqueLocalidade = new System.Windows.Forms.Label();
            this.txtEstoqueLocalidade = new System.Windows.Forms.TextBox();
            this.btnBuscarEstoqueLocalidade = new System.Windows.Forms.Button();
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbArmazem = new System.Windows.Forms.RadioButton();
            this.rbItem = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.EstoqueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueLocalidadeDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueLocalidadeEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelInside.SuspendLayout();
            this.gpbItem.SuspendLayout();
            this.gpbEstoqueLocalidade.SuspendLayout();
            this.gpbOpcoes.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbItem);
            this.panelInside.Controls.Add(this.gpbEstoqueLocalidade);
            this.panelInside.Controls.Add(this.gpbOpcoes);
            this.panelInside.Controls.Add(this.btnConsultar);
            this.panelInside.Controls.Add(this.gpbResultado);
            this.panelInside.Location = new System.Drawing.Point(12, 67);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(814, 531);
            this.panelInside.TabIndex = 0;
            this.panelInside.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInside_Paint);
            // 
            // gpbItem
            // 
            this.gpbItem.Controls.Add(this.lblItem);
            this.gpbItem.Controls.Add(this.txtItem);
            this.gpbItem.Controls.Add(this.btnBuscarItem);
            this.gpbItem.Location = new System.Drawing.Point(182, 13);
            this.gpbItem.Name = "gpbItem";
            this.gpbItem.Size = new System.Drawing.Size(227, 109);
            this.gpbItem.TabIndex = 1;
            this.gpbItem.TabStop = false;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(19, 25);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(72, 16);
            this.lblItem.TabIndex = 12;
            this.lblItem.Text = "ID do item:";
            // 
            // txtItem
            // 
            this.txtItem.Enabled = false;
            this.txtItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtItem.Location = new System.Drawing.Point(97, 22);
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
            this.btnBuscarItem.Location = new System.Drawing.Point(26, 53);
            this.btnBuscarItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(185, 42);
            this.btnBuscarItem.TabIndex = 1;
            this.btnBuscarItem.Text = "Buscar Item";
            this.btnBuscarItem.UseVisualStyleBackColor = false;
            this.btnBuscarItem.Click += new System.EventHandler(this.BtnBuscarItem_Click);
            // 
            // gpbEstoqueLocalidade
            // 
            this.gpbEstoqueLocalidade.Controls.Add(this.lblEstoqueLocalidade);
            this.gpbEstoqueLocalidade.Controls.Add(this.txtEstoqueLocalidade);
            this.gpbEstoqueLocalidade.Controls.Add(this.btnBuscarEstoqueLocalidade);
            this.gpbEstoqueLocalidade.Location = new System.Drawing.Point(183, 13);
            this.gpbEstoqueLocalidade.Name = "gpbEstoqueLocalidade";
            this.gpbEstoqueLocalidade.Size = new System.Drawing.Size(227, 109);
            this.gpbEstoqueLocalidade.TabIndex = 35;
            this.gpbEstoqueLocalidade.TabStop = false;
            this.gpbEstoqueLocalidade.Visible = false;
            // 
            // lblEstoqueLocalidade
            // 
            this.lblEstoqueLocalidade.AutoSize = true;
            this.lblEstoqueLocalidade.Location = new System.Drawing.Point(5, 26);
            this.lblEstoqueLocalidade.Name = "lblEstoqueLocalidade";
            this.lblEstoqueLocalidade.Size = new System.Drawing.Size(100, 16);
            this.lblEstoqueLocalidade.TabIndex = 26;
            this.lblEstoqueLocalidade.Text = "ID do armazém:";
            // 
            // txtEstoqueLocalidade
            // 
            this.txtEstoqueLocalidade.Enabled = false;
            this.txtEstoqueLocalidade.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtEstoqueLocalidade.Location = new System.Drawing.Point(111, 22);
            this.txtEstoqueLocalidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstoqueLocalidade.Name = "txtEstoqueLocalidade";
            this.txtEstoqueLocalidade.Size = new System.Drawing.Size(110, 23);
            this.txtEstoqueLocalidade.TabIndex = 24;
            // 
            // btnBuscarEstoqueLocalidade
            // 
            this.btnBuscarEstoqueLocalidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarEstoqueLocalidade.FlatAppearance.BorderSize = 0;
            this.btnBuscarEstoqueLocalidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEstoqueLocalidade.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarEstoqueLocalidade.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEstoqueLocalidade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarEstoqueLocalidade.Location = new System.Drawing.Point(21, 54);
            this.btnBuscarEstoqueLocalidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarEstoqueLocalidade.Name = "btnBuscarEstoqueLocalidade";
            this.btnBuscarEstoqueLocalidade.Size = new System.Drawing.Size(185, 42);
            this.btnBuscarEstoqueLocalidade.TabIndex = 25;
            this.btnBuscarEstoqueLocalidade.Text = "Buscar Armazém";
            this.btnBuscarEstoqueLocalidade.UseVisualStyleBackColor = false;
            this.btnBuscarEstoqueLocalidade.Click += new System.EventHandler(this.BtnBuscarEstoqueLocalidade_Click);
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.rbArmazem);
            this.gpbOpcoes.Controls.Add(this.rbItem);
            this.gpbOpcoes.Location = new System.Drawing.Point(12, 13);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(164, 59);
            this.gpbOpcoes.TabIndex = 0;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Opções";
            // 
            // rbArmazem
            // 
            this.rbArmazem.AutoSize = true;
            this.rbArmazem.Location = new System.Drawing.Point(66, 22);
            this.rbArmazem.Name = "rbArmazem";
            this.rbArmazem.Size = new System.Drawing.Size(82, 20);
            this.rbArmazem.TabIndex = 1;
            this.rbArmazem.Text = "Armazém";
            this.rbArmazem.UseVisualStyleBackColor = true;
            this.rbArmazem.CheckedChanged += new System.EventHandler(this.RbArmazem_CheckedChanged);
            // 
            // rbItem
            // 
            this.rbItem.AutoSize = true;
            this.rbItem.Checked = true;
            this.rbItem.Location = new System.Drawing.Point(7, 23);
            this.rbItem.Name = "rbItem";
            this.rbItem.Size = new System.Drawing.Size(53, 20);
            this.rbItem.TabIndex = 0;
            this.rbItem.TabStop = true;
            this.rbItem.Text = "Item";
            this.rbItem.UseVisualStyleBackColor = true;
            this.rbItem.CheckedChanged += new System.EventHandler(this.RbItem_CheckedChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(565, 452);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(239, 68);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.dgvResultado);
            this.gpbResultado.Location = new System.Drawing.Point(7, 128);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(797, 316);
            this.gpbResultado.TabIndex = 32;
            this.gpbResultado.TabStop = false;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstoqueID,
            this.EstoqueLocalidadeDescricao,
            this.EstoqueLocalidadeEndereco,
            this.EstoqueQuantidade,
            this.ItemDescricao});
            this.dgvResultado.Location = new System.Drawing.Point(7, 15);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(784, 295);
            this.dgvResultado.TabIndex = 2;
            this.dgvResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResultado_CellDoubleClick);
            this.dgvResultado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvResultado_CellFormatting);
            // 
            // EstoqueID
            // 
            this.EstoqueID.DataPropertyName = "EstoqueID";
            this.EstoqueID.HeaderText = "ID";
            this.EstoqueID.Name = "EstoqueID";
            this.EstoqueID.ReadOnly = true;
            // 
            // EstoqueLocalidadeDescricao
            // 
            this.EstoqueLocalidadeDescricao.DataPropertyName = "EstoqueLocalidade.EstoqueLocalidadeDescricao";
            this.EstoqueLocalidadeDescricao.HeaderText = "Armazém";
            this.EstoqueLocalidadeDescricao.Name = "EstoqueLocalidadeDescricao";
            this.EstoqueLocalidadeDescricao.ReadOnly = true;
            this.EstoqueLocalidadeDescricao.Width = 200;
            // 
            // EstoqueLocalidadeEndereco
            // 
            this.EstoqueLocalidadeEndereco.DataPropertyName = "EstoqueLocalidade.EstoqueLocalidadeEndereco";
            this.EstoqueLocalidadeEndereco.HeaderText = "Endereço";
            this.EstoqueLocalidadeEndereco.Name = "EstoqueLocalidadeEndereco";
            this.EstoqueLocalidadeEndereco.ReadOnly = true;
            this.EstoqueLocalidadeEndereco.Width = 180;
            // 
            // EstoqueQuantidade
            // 
            this.EstoqueQuantidade.DataPropertyName = "EstoqueQuantidade";
            this.EstoqueQuantidade.HeaderText = "Quantidade";
            this.EstoqueQuantidade.Name = "EstoqueQuantidade";
            this.EstoqueQuantidade.ReadOnly = true;
            this.EstoqueQuantidade.Width = 80;
            // 
            // ItemDescricao
            // 
            this.ItemDescricao.DataPropertyName = "Item.ItemDescricao";
            this.ItemDescricao.HeaderText = "Item";
            this.ItemDescricao.Name = "ItemDescricao";
            this.ItemDescricao.ReadOnly = true;
            this.ItemDescricao.Width = 180;
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
            this.panel2.Size = new System.Drawing.Size(837, 45);
            this.panel2.TabIndex = 28;
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(794, 4);
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
            this.panel4.Size = new System.Drawing.Size(837, 15);
            this.panel4.TabIndex = 29;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(198, 24);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Consulta de Estoque";
            // 
            // frmConsultaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(837, 608);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaEstoque";
            this.panelInside.ResumeLayout(false);
            this.gpbItem.ResumeLayout(false);
            this.gpbItem.PerformLayout();
            this.gpbEstoqueLocalidade.ResumeLayout(false);
            this.gpbEstoqueLocalidade.PerformLayout();
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.gpbResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gpbEstoqueLocalidade;
        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.RadioButton rbArmazem;
        private System.Windows.Forms.RadioButton rbItem;
        private System.Windows.Forms.Label lblEstoqueLocalidade;
        private System.Windows.Forms.TextBox txtEstoqueLocalidade;
        private System.Windows.Forms.Button btnBuscarEstoqueLocalidade;
        private System.Windows.Forms.GroupBox gpbItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueLocalidadeDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueLocalidadeEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescricao;
        private System.Windows.Forms.Label lblTitulo;
    }
}