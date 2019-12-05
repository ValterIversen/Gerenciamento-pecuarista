namespace Apresentacao.Raca
{
    partial class frmConsultaRaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaRaca));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelInside = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.txtDados = new System.Windows.Forms.TextBox();
            this.gpbResultados = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.RacaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RacaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RacaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbOpcao = new System.Windows.Forms.GroupBox();
            this.rbDescricao = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panelInside.SuspendLayout();
            this.gpbDados.SuspendLayout();
            this.gpbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.gpbOpcao.SuspendLayout();
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
            this.panel4.Size = new System.Drawing.Size(544, 45);
            this.panel4.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(169, 24);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Consulta de Raça";
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(501, 3);
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
            this.panel2.Size = new System.Drawing.Size(544, 12);
            this.panel2.TabIndex = 5;
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.btnConsultar);
            this.panelInside.Controls.Add(this.gpbDados);
            this.panelInside.Controls.Add(this.gpbResultados);
            this.panelInside.Controls.Add(this.gpbOpcao);
            this.panelInside.Location = new System.Drawing.Point(13, 64);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(519, 463);
            this.panelInside.TabIndex = 7;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(262, 384);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(239, 68);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.txtDados);
            this.gpbDados.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.gpbDados.Location = new System.Drawing.Point(207, 12);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(294, 54);
            this.gpbDados.TabIndex = 1;
            this.gpbDados.TabStop = false;
            // 
            // txtDados
            // 
            this.txtDados.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtDados.Location = new System.Drawing.Point(5, 21);
            this.txtDados.MaxLength = 30;
            this.txtDados.Name = "txtDados";
            this.txtDados.Size = new System.Drawing.Size(281, 23);
            this.txtDados.TabIndex = 0;
            // 
            // gpbResultados
            // 
            this.gpbResultados.Controls.Add(this.lblInfo);
            this.gpbResultados.Controls.Add(this.dgvResultados);
            this.gpbResultados.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.gpbResultados.Location = new System.Drawing.Point(13, 72);
            this.gpbResultados.Name = "gpbResultados";
            this.gpbResultados.Size = new System.Drawing.Size(488, 306);
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
            this.RacaID,
            this.RacaNome,
            this.RacaDescricao});
            this.dgvResultados.Location = new System.Drawing.Point(6, 43);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(474, 257);
            this.dgvResultados.TabIndex = 0;
            this.dgvResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResultados_CellDoubleClick);
            // 
            // RacaID
            // 
            this.RacaID.DataPropertyName = "RacaID";
            this.RacaID.HeaderText = "ID";
            this.RacaID.MinimumWidth = 100;
            this.RacaID.Name = "RacaID";
            this.RacaID.ReadOnly = true;
            // 
            // RacaNome
            // 
            this.RacaNome.DataPropertyName = "RacaNome";
            this.RacaNome.HeaderText = "Nome";
            this.RacaNome.MinimumWidth = 130;
            this.RacaNome.Name = "RacaNome";
            this.RacaNome.ReadOnly = true;
            this.RacaNome.Width = 130;
            // 
            // RacaDescricao
            // 
            this.RacaDescricao.DataPropertyName = "RacaDescricao";
            this.RacaDescricao.HeaderText = "Descrição";
            this.RacaDescricao.MinimumWidth = 200;
            this.RacaDescricao.Name = "RacaDescricao";
            this.RacaDescricao.ReadOnly = true;
            this.RacaDescricao.Width = 200;
            // 
            // gpbOpcao
            // 
            this.gpbOpcao.Controls.Add(this.rbDescricao);
            this.gpbOpcao.Controls.Add(this.rbNome);
            this.gpbOpcao.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.gpbOpcao.Location = new System.Drawing.Point(13, 12);
            this.gpbOpcao.Name = "gpbOpcao";
            this.gpbOpcao.Size = new System.Drawing.Size(188, 54);
            this.gpbOpcao.TabIndex = 0;
            this.gpbOpcao.TabStop = false;
            this.gpbOpcao.Text = "Opção de consulta:";
            // 
            // rbDescricao
            // 
            this.rbDescricao.AutoSize = true;
            this.rbDescricao.Location = new System.Drawing.Point(74, 22);
            this.rbDescricao.Name = "rbDescricao";
            this.rbDescricao.Size = new System.Drawing.Size(83, 20);
            this.rbDescricao.TabIndex = 1;
            this.rbDescricao.TabStop = true;
            this.rbDescricao.Text = "Descrição";
            this.rbDescricao.UseVisualStyleBackColor = true;
            this.rbDescricao.CheckedChanged += new System.EventHandler(this.RbDescricao_CheckedChanged);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Location = new System.Drawing.Point(6, 22);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(62, 20);
            this.rbNome.TabIndex = 0;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.RbNome_CheckedChanged);
            // 
            // frmConsultaRaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(544, 539);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaRaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaRaca";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panelInside.ResumeLayout(false);
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.gpbResultados.ResumeLayout(false);
            this.gpbResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.gpbOpcao.ResumeLayout(false);
            this.gpbOpcao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.TextBox txtDados;
        private System.Windows.Forms.GroupBox gpbResultados;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn RacaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RacaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn RacaDescricao;
        private System.Windows.Forms.GroupBox gpbOpcao;
        private System.Windows.Forms.RadioButton rbDescricao;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.Label lblTitulo;
    }
}