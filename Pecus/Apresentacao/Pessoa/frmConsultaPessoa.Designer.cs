namespace Apresentacao.Pessoa
{
    partial class frmConsultaPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPessoa));
            this.panel2 = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gpbOpcConsulta = new System.Windows.Forms.GroupBox();
            this.rbRazaoSocial = new System.Windows.Forms.RadioButton();
            this.rbNomeFicticio = new System.Windows.Forms.RadioButton();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gpbResultados = new System.Windows.Forms.GroupBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.PessoaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PessoaFisicaCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PessoaFisicaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PessoaJuridicaCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PessoaJuridicaNomeFicticio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PessoaTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PessoaEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CidadeNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblNomeFicticio = new System.Windows.Forms.Label();
            this.txtNomeFicticio = new System.Windows.Forms.TextBox();
            this.panelInside = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.gpbOpcConsulta.SuspendLayout();
            this.gpbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.gpbDados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelInside.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(1145, 45);
            this.panel2.TabIndex = 27;
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(1102, 4);
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
            this.panel4.Size = new System.Drawing.Size(1145, 15);
            this.panel4.TabIndex = 28;
            // 
            // gpbOpcConsulta
            // 
            this.gpbOpcConsulta.Controls.Add(this.rbRazaoSocial);
            this.gpbOpcConsulta.Controls.Add(this.rbNomeFicticio);
            this.gpbOpcConsulta.Controls.Add(this.rbCNPJ);
            this.gpbOpcConsulta.Controls.Add(this.rbNome);
            this.gpbOpcConsulta.Controls.Add(this.rbCPF);
            this.gpbOpcConsulta.Location = new System.Drawing.Point(13, 11);
            this.gpbOpcConsulta.Name = "gpbOpcConsulta";
            this.gpbOpcConsulta.Size = new System.Drawing.Size(349, 86);
            this.gpbOpcConsulta.TabIndex = 0;
            this.gpbOpcConsulta.TabStop = false;
            this.gpbOpcConsulta.Text = "Opções de Consulta";
            // 
            // rbRazaoSocial
            // 
            this.rbRazaoSocial.AutoSize = true;
            this.rbRazaoSocial.Location = new System.Drawing.Point(102, 51);
            this.rbRazaoSocial.Name = "rbRazaoSocial";
            this.rbRazaoSocial.Size = new System.Drawing.Size(99, 20);
            this.rbRazaoSocial.TabIndex = 3;
            this.rbRazaoSocial.Text = "Razão Social";
            this.rbRazaoSocial.UseVisualStyleBackColor = true;
            this.rbRazaoSocial.CheckedChanged += new System.EventHandler(this.RbRazaoSocial_CheckedChanged);
            // 
            // rbNomeFicticio
            // 
            this.rbNomeFicticio.AutoSize = true;
            this.rbNomeFicticio.Location = new System.Drawing.Point(211, 51);
            this.rbNomeFicticio.Name = "rbNomeFicticio";
            this.rbNomeFicticio.Size = new System.Drawing.Size(103, 20);
            this.rbNomeFicticio.TabIndex = 4;
            this.rbNomeFicticio.Text = "Nome fictício";
            this.rbNomeFicticio.UseVisualStyleBackColor = true;
            this.rbNomeFicticio.CheckedChanged += new System.EventHandler(this.RbNomeFicticio_CheckedChanged);
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.Location = new System.Drawing.Point(39, 51);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(57, 20);
            this.rbCNPJ.TabIndex = 2;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = true;
            this.rbCNPJ.CheckedChanged += new System.EventHandler(this.RbCNPJ_CheckedChanged);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Location = new System.Drawing.Point(160, 25);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(62, 20);
            this.rbNome.TabIndex = 1;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.RbNome_CheckedChanged);
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Location = new System.Drawing.Point(106, 25);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(48, 20);
            this.rbCPF.TabIndex = 0;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.CheckedChanged += new System.EventHandler(this.RbCPF_CheckedChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(831, 455);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(279, 84);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // gpbResultados
            // 
            this.gpbResultados.Controls.Add(this.dgvResultado);
            this.gpbResultados.Location = new System.Drawing.Point(13, 114);
            this.gpbResultados.Name = "gpbResultados";
            this.gpbResultados.Size = new System.Drawing.Size(1097, 333);
            this.gpbResultados.TabIndex = 3;
            this.gpbResultados.TabStop = false;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PessoaID,
            this.PessoaFisicaCPF,
            this.PessoaFisicaNome,
            this.PessoaJuridicaCNPJ,
            this.PessoaJuridicaNomeFicticio,
            this.PessoaTelefone,
            this.PessoaEndereco,
            this.CidadeNome});
            this.dgvResultado.Location = new System.Drawing.Point(6, 12);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(1085, 315);
            this.dgvResultado.TabIndex = 0;
            this.dgvResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResultado_CellDoubleClick);
            this.dgvResultado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvResultado_CellFormatting);
            // 
            // PessoaID
            // 
            this.PessoaID.DataPropertyName = "PessoaID";
            this.PessoaID.HeaderText = "ID";
            this.PessoaID.Name = "PessoaID";
            this.PessoaID.ReadOnly = true;
            this.PessoaID.Width = 80;
            // 
            // PessoaFisicaCPF
            // 
            this.PessoaFisicaCPF.DataPropertyName = "PessoaFisica.PessoaFisicaCPF";
            this.PessoaFisicaCPF.HeaderText = "CPF";
            this.PessoaFisicaCPF.Name = "PessoaFisicaCPF";
            this.PessoaFisicaCPF.ReadOnly = true;
            this.PessoaFisicaCPF.Width = 110;
            // 
            // PessoaFisicaNome
            // 
            this.PessoaFisicaNome.DataPropertyName = "PessoaFisica.PessoaFisicaNome";
            this.PessoaFisicaNome.HeaderText = "Nome";
            this.PessoaFisicaNome.Name = "PessoaFisicaNome";
            this.PessoaFisicaNome.ReadOnly = true;
            this.PessoaFisicaNome.Width = 185;
            // 
            // PessoaJuridicaCNPJ
            // 
            this.PessoaJuridicaCNPJ.DataPropertyName = "PessoaJuridica.PessoaJuridicaCNPJ";
            this.PessoaJuridicaCNPJ.HeaderText = "CNPJ";
            this.PessoaJuridicaCNPJ.Name = "PessoaJuridicaCNPJ";
            this.PessoaJuridicaCNPJ.ReadOnly = true;
            this.PessoaJuridicaCNPJ.Width = 130;
            // 
            // PessoaJuridicaNomeFicticio
            // 
            this.PessoaJuridicaNomeFicticio.DataPropertyName = "PessoaJuridica.PessoaJuridicaNomeFicticio";
            this.PessoaJuridicaNomeFicticio.HeaderText = "Nome Fictício";
            this.PessoaJuridicaNomeFicticio.Name = "PessoaJuridicaNomeFicticio";
            this.PessoaJuridicaNomeFicticio.ReadOnly = true;
            this.PessoaJuridicaNomeFicticio.Width = 185;
            // 
            // PessoaTelefone
            // 
            this.PessoaTelefone.DataPropertyName = "PessoaTelefone";
            this.PessoaTelefone.HeaderText = "Telefone";
            this.PessoaTelefone.Name = "PessoaTelefone";
            this.PessoaTelefone.ReadOnly = true;
            // 
            // PessoaEndereco
            // 
            this.PessoaEndereco.DataPropertyName = "PessoaEndereco";
            this.PessoaEndereco.HeaderText = "Endereço";
            this.PessoaEndereco.Name = "PessoaEndereco";
            this.PessoaEndereco.ReadOnly = true;
            this.PessoaEndereco.Width = 180;
            // 
            // CidadeNome
            // 
            this.CidadeNome.DataPropertyName = "Cidade.CidadeNome";
            this.CidadeNome.HeaderText = "Cidade";
            this.CidadeNome.Name = "CidadeNome";
            this.CidadeNome.ReadOnly = true;
            this.CidadeNome.Width = 140;
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.txtCPF);
            this.gpbDados.Controls.Add(this.lblCPF);
            this.gpbDados.Controls.Add(this.lblNome);
            this.gpbDados.Controls.Add(this.txtNome);
            this.gpbDados.Location = new System.Drawing.Point(368, 11);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(368, 86);
            this.gpbDados.TabIndex = 1;
            this.gpbDados.TabStop = false;
            // 
            // txtCPF
            // 
            this.txtCPF.Enabled = false;
            this.txtCPF.Location = new System.Drawing.Point(143, 18);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(103, 23);
            this.txtCPF.TabIndex = 0;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(85, 21);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(39, 16);
            this.lblCPF.TabIndex = 22;
            this.lblCPF.Text = "CPF:  ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(41, 51);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtNome.Location = new System.Drawing.Point(94, 48);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(205, 23);
            this.txtNome.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRazaoSocial);
            this.groupBox1.Controls.Add(this.txtRazaoSocial);
            this.groupBox1.Controls.Add(this.txtCNPJ);
            this.groupBox1.Controls.Add(this.lblCNPJ);
            this.groupBox1.Controls.Add(this.lblNomeFicticio);
            this.groupBox1.Controls.Add(this.txtNomeFicticio);
            this.groupBox1.Location = new System.Drawing.Point(742, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(18, 51);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(84, 16);
            this.lblRazaoSocial.TabIndex = 27;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Enabled = false;
            this.txtRazaoSocial.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtRazaoSocial.Location = new System.Drawing.Point(108, 48);
            this.txtRazaoSocial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRazaoSocial.MaxLength = 50;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(205, 23);
            this.txtRazaoSocial.TabIndex = 1;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Enabled = false;
            this.txtCNPJ.Location = new System.Drawing.Point(157, 18);
            this.txtCNPJ.Mask = "000,000,000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(103, 23);
            this.txtCNPJ.TabIndex = 0;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(105, 21);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(42, 16);
            this.lblCNPJ.TabIndex = 24;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // lblNomeFicticio
            // 
            this.lblNomeFicticio.AutoSize = true;
            this.lblNomeFicticio.Location = new System.Drawing.Point(14, 82);
            this.lblNomeFicticio.Name = "lblNomeFicticio";
            this.lblNomeFicticio.Size = new System.Drawing.Size(88, 16);
            this.lblNomeFicticio.TabIndex = 20;
            this.lblNomeFicticio.Text = "Nome fictício:";
            // 
            // txtNomeFicticio
            // 
            this.txtNomeFicticio.Enabled = false;
            this.txtNomeFicticio.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtNomeFicticio.Location = new System.Drawing.Point(108, 79);
            this.txtNomeFicticio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeFicticio.MaxLength = 60;
            this.txtNomeFicticio.Name = "txtNomeFicticio";
            this.txtNomeFicticio.Size = new System.Drawing.Size(205, 23);
            this.txtNomeFicticio.TabIndex = 2;
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbOpcConsulta);
            this.panelInside.Controls.Add(this.groupBox1);
            this.panelInside.Controls.Add(this.gpbDados);
            this.panelInside.Controls.Add(this.gpbResultados);
            this.panelInside.Controls.Add(this.btnConsultar);
            this.panelInside.Location = new System.Drawing.Point(12, 67);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(1122, 550);
            this.panelInside.TabIndex = 40;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(188, 24);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Consulta de Pessoa";
            // 
            // frmConsultaPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1145, 629);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultaPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroPessoa";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.gpbOpcConsulta.ResumeLayout(false);
            this.gpbOpcConsulta.PerformLayout();
            this.gpbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelInside.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gpbOpcConsulta;
        private System.Windows.Forms.RadioButton rbNomeFicticio;
        private System.Windows.Forms.RadioButton rbCNPJ;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gpbResultados;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblNomeFicticio;
        private System.Windows.Forms.TextBox txtNomeFicticio;
        private System.Windows.Forms.RadioButton rbRazaoSocial;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.DataGridViewTextBoxColumn PessoaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PessoaFisicaCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn PessoaFisicaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn PessoaJuridicaCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn PessoaJuridicaNomeFicticio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PessoaTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn PessoaEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidadeNome;
        private System.Windows.Forms.Label lblTitulo;
    }
}