namespace Apresentacao.Usuario
{
    partial class frmConsultaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaUsuario));
            this.panel4 = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelInside = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.UsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TipoUsuarioDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panelInside.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.gpbDados.SuspendLayout();
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
            this.panel4.Size = new System.Drawing.Size(787, 45);
            this.panel4.TabIndex = 6;
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(744, 4);
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
            this.panel2.Size = new System.Drawing.Size(787, 15);
            this.panel2.TabIndex = 5;
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.btnConsultar);
            this.panelInside.Controls.Add(this.gpbResultado);
            this.panelInside.Controls.Add(this.gpbDados);
            this.panelInside.Location = new System.Drawing.Point(13, 68);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(762, 438);
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
            this.btnConsultar.Location = new System.Drawing.Point(512, 360);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(239, 68);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "C&onsultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.dgvResultado);
            this.gpbResultado.Location = new System.Drawing.Point(12, 79);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(739, 275);
            this.gpbResultado.TabIndex = 1;
            this.gpbResultado.TabStop = false;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsuarioID,
            this.UsuarioLogin,
            this.UsuarioNome,
            this.UsuarioAtivo,
            this.TipoUsuarioDescricao});
            this.dgvResultado.Location = new System.Drawing.Point(7, 23);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(724, 242);
            this.dgvResultado.TabIndex = 0;
            this.dgvResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResultado_CellDoubleClick);
            this.dgvResultado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvResultado_CellFormatting_1);
            // 
            // UsuarioID
            // 
            this.UsuarioID.DataPropertyName = "UsuarioID";
            this.UsuarioID.HeaderText = "ID";
            this.UsuarioID.Name = "UsuarioID";
            this.UsuarioID.ReadOnly = true;
            this.UsuarioID.Width = 80;
            // 
            // UsuarioLogin
            // 
            this.UsuarioLogin.DataPropertyName = "UsuarioLogin";
            this.UsuarioLogin.HeaderText = "Login";
            this.UsuarioLogin.Name = "UsuarioLogin";
            this.UsuarioLogin.ReadOnly = true;
            this.UsuarioLogin.Width = 140;
            // 
            // UsuarioNome
            // 
            this.UsuarioNome.DataPropertyName = "UsuarioNome";
            this.UsuarioNome.HeaderText = "Nome";
            this.UsuarioNome.Name = "UsuarioNome";
            this.UsuarioNome.ReadOnly = true;
            this.UsuarioNome.Width = 200;
            // 
            // UsuarioAtivo
            // 
            this.UsuarioAtivo.DataPropertyName = "UsuarioAtivo";
            this.UsuarioAtivo.HeaderText = "Ativo";
            this.UsuarioAtivo.Name = "UsuarioAtivo";
            this.UsuarioAtivo.ReadOnly = true;
            this.UsuarioAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UsuarioAtivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UsuarioAtivo.Width = 80;
            // 
            // TipoUsuarioDescricao
            // 
            this.TipoUsuarioDescricao.DataPropertyName = "TipoUsuario.TipoUsuarioDescricao";
            this.TipoUsuarioDescricao.HeaderText = "Tipo de Usuário";
            this.TipoUsuarioDescricao.Name = "TipoUsuarioDescricao";
            this.TipoUsuarioDescricao.ReadOnly = true;
            this.TipoUsuarioDescricao.Width = 180;
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.txtNome);
            this.gpbDados.Controls.Add(this.lblNome);
            this.gpbDados.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDados.Location = new System.Drawing.Point(12, 13);
            this.gpbDados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbDados.Size = new System.Drawing.Size(340, 59);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Consulta de usuário:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtNome.Location = new System.Drawing.Point(130, 24);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(204, 23);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(10, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(114, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do usuário:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(195, 24);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Consulta de Usuário";
            // 
            // frmConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(787, 518);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaUsuario";
            this.Load += new System.EventHandler(this.FrmConsultaUsuario_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panelInside.ResumeLayout(false);
            this.gpbResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioNome;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UsuarioAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuarioDescricao;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTitulo;
    }
}