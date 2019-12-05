namespace Apresentacao.Veterinario
{
    partial class frmConsultaVeterinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaVeterinario));
            this.panelInside = new System.Windows.Forms.Panel();
            this.gpbResultados = new System.Windows.Forms.GroupBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.VeterinarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeterinarioCRMV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeterinarioNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeterinarioTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CidadeNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbID = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.gpbNome = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelInside.SuspendLayout();
            this.gpbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.gpbID.SuspendLayout();
            this.gpbOpcoes.SuspendLayout();
            this.gpbNome.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbResultados);
            this.panelInside.Controls.Add(this.gpbID);
            this.panelInside.Controls.Add(this.gpbOpcoes);
            this.panelInside.Controls.Add(this.gpbNome);
            this.panelInside.Controls.Add(this.btnCadastrar);
            this.panelInside.Location = new System.Drawing.Point(12, 67);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(671, 625);
            this.panelInside.TabIndex = 35;
            // 
            // gpbResultados
            // 
            this.gpbResultados.Controls.Add(this.dgvResultados);
            this.gpbResultados.Location = new System.Drawing.Point(13, 79);
            this.gpbResultados.Name = "gpbResultados";
            this.gpbResultados.Size = new System.Drawing.Size(645, 463);
            this.gpbResultados.TabIndex = 29;
            this.gpbResultados.TabStop = false;
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VeterinarioID,
            this.VeterinarioCRMV,
            this.VeterinarioNome,
            this.VeterinarioTelefone,
            this.CidadeNome,
            this.EstadoNome});
            this.dgvResultados.Location = new System.Drawing.Point(7, 11);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(632, 446);
            this.dgvResultados.TabIndex = 2;
            this.dgvResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellDoubleClick);
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
            this.VeterinarioCRMV.Width = 150;
            // 
            // VeterinarioNome
            // 
            this.VeterinarioNome.DataPropertyName = "VeterinarioNome";
            this.VeterinarioNome.HeaderText = "Nome";
            this.VeterinarioNome.Name = "VeterinarioNome";
            this.VeterinarioNome.ReadOnly = true;
            this.VeterinarioNome.Width = 250;
            // 
            // VeterinarioTelefone
            // 
            this.VeterinarioTelefone.DataPropertyName = "VeterinarioTelefone";
            this.VeterinarioTelefone.HeaderText = "Telefone";
            this.VeterinarioTelefone.Name = "VeterinarioTelefone";
            this.VeterinarioTelefone.ReadOnly = true;
            this.VeterinarioTelefone.Width = 120;
            // 
            // CidadeNome
            // 
            this.CidadeNome.DataPropertyName = "Cidade.CidadeNome";
            this.CidadeNome.HeaderText = "Cidade";
            this.CidadeNome.Name = "CidadeNome";
            this.CidadeNome.ReadOnly = true;
            this.CidadeNome.Width = 130;
            // 
            // EstadoNome
            // 
            this.EstadoNome.DataPropertyName = "Cidade.EstadoNome";
            this.EstadoNome.HeaderText = "Estado";
            this.EstadoNome.Name = "EstadoNome";
            this.EstadoNome.ReadOnly = true;
            this.EstadoNome.Width = 130;
            // 
            // gpbID
            // 
            this.gpbID.Controls.Add(this.txtID);
            this.gpbID.Controls.Add(this.lblID);
            this.gpbID.Location = new System.Drawing.Point(165, 14);
            this.gpbID.Name = "gpbID";
            this.gpbID.Size = new System.Drawing.Size(131, 58);
            this.gpbID.TabIndex = 1;
            this.gpbID.TabStop = false;
            this.gpbID.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(44, 22);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(78, 23);
            this.txtID.TabIndex = 3;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(14, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 16);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID:";
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.rbNome);
            this.gpbOpcoes.Controls.Add(this.rbID);
            this.gpbOpcoes.Location = new System.Drawing.Point(13, 14);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(146, 58);
            this.gpbOpcoes.TabIndex = 0;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Opções de Consulta";
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Location = new System.Drawing.Point(63, 27);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(62, 20);
            this.rbNome.TabIndex = 1;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Location = new System.Drawing.Point(18, 27);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(39, 20);
            this.rbID.TabIndex = 0;
            this.rbID.Text = "ID";
            this.rbID.UseVisualStyleBackColor = true;
            this.rbID.CheckedChanged += new System.EventHandler(this.rbID_CheckedChanged);
            // 
            // gpbNome
            // 
            this.gpbNome.Controls.Add(this.txtNome);
            this.gpbNome.Controls.Add(this.lblNome);
            this.gpbNome.Location = new System.Drawing.Point(165, 14);
            this.gpbNome.Name = "gpbNome";
            this.gpbNome.Size = new System.Drawing.Size(302, 58);
            this.gpbNome.TabIndex = 1;
            this.gpbNome.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(67, 22);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(223, 23);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(14, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(419, 549);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(239, 68);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Consultar";
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
            this.panel2.Size = new System.Drawing.Size(696, 45);
            this.panel2.TabIndex = 33;
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(653, 4);
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
            this.panel4.Size = new System.Drawing.Size(696, 15);
            this.panel4.TabIndex = 34;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(227, 24);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "Consulta de Veterinário";
            // 
            // frmConsultaVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(696, 698);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultaVeterinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaVeterinario";
            this.panelInside.ResumeLayout(false);
            this.gpbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.gpbID.ResumeLayout(false);
            this.gpbID.PerformLayout();
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.gpbNome.ResumeLayout(false);
            this.gpbNome.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.GroupBox gpbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gpbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.GroupBox gpbResultados;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeterinarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeterinarioCRMV;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeterinarioNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeterinarioTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidadeNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoNome;
        private System.Windows.Forms.Label lblTitulo;
    }
}