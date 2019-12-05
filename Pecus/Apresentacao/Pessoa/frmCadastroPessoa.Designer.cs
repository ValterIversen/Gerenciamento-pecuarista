namespace Apresentacao.Pessoa
{
    partial class frmCadastroPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroPessoa));
            this.panel2 = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelInside = new System.Windows.Forms.Panel();
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbPessoaJuridica = new System.Windows.Forms.GroupBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblNomeFicticio = new System.Windows.Forms.Label();
            this.txtNomeFicticio = new System.Windows.Forms.TextBox();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbbCidade = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.ckNoveDigito = new System.Windows.Forms.CheckBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.gpbPessoaFisica = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panelInside.SuspendLayout();
            this.gpbOpcoes.SuspendLayout();
            this.gpbPessoaJuridica.SuspendLayout();
            this.gpbDados.SuspendLayout();
            this.gpbPessoaFisica.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(826, 45);
            this.panel2.TabIndex = 29;
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(783, 4);
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
            this.panel4.Size = new System.Drawing.Size(826, 15);
            this.panel4.TabIndex = 30;
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbOpcoes);
            this.panelInside.Controls.Add(this.btnCadastrar);
            this.panelInside.Controls.Add(this.gpbPessoaJuridica);
            this.panelInside.Controls.Add(this.gpbDados);
            this.panelInside.Controls.Add(this.gpbPessoaFisica);
            this.panelInside.Location = new System.Drawing.Point(13, 68);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(800, 314);
            this.panelInside.TabIndex = 31;
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.rbPessoaFisica);
            this.gpbOpcoes.Controls.Add(this.rbPessoaJuridica);
            this.gpbOpcoes.Location = new System.Drawing.Point(13, 14);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(368, 60);
            this.gpbOpcoes.TabIndex = 0;
            this.gpbOpcoes.TabStop = false;
            // 
            // rbPessoaFisica
            // 
            this.rbPessoaFisica.AutoSize = true;
            this.rbPessoaFisica.Checked = true;
            this.rbPessoaFisica.Location = new System.Drawing.Point(78, 22);
            this.rbPessoaFisica.Name = "rbPessoaFisica";
            this.rbPessoaFisica.Size = new System.Drawing.Size(102, 20);
            this.rbPessoaFisica.TabIndex = 0;
            this.rbPessoaFisica.TabStop = true;
            this.rbPessoaFisica.Text = "Pessoa Física";
            this.rbPessoaFisica.UseVisualStyleBackColor = true;
            this.rbPessoaFisica.CheckedChanged += new System.EventHandler(this.RbPessoaFisica_CheckedChanged);
            // 
            // rbPessoaJuridica
            // 
            this.rbPessoaJuridica.AutoSize = true;
            this.rbPessoaJuridica.Location = new System.Drawing.Point(186, 22);
            this.rbPessoaJuridica.Name = "rbPessoaJuridica";
            this.rbPessoaJuridica.Size = new System.Drawing.Size(116, 20);
            this.rbPessoaJuridica.TabIndex = 1;
            this.rbPessoaJuridica.Text = "Pessoa Jurídica";
            this.rbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbPessoaJuridica.CheckedChanged += new System.EventHandler(this.RbPessoaJuridica_CheckedChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(549, 234);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(239, 68);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // gpbPessoaJuridica
            // 
            this.gpbPessoaJuridica.Controls.Add(this.lblRazaoSocial);
            this.gpbPessoaJuridica.Controls.Add(this.txtRazaoSocial);
            this.gpbPessoaJuridica.Controls.Add(this.txtCNPJ);
            this.gpbPessoaJuridica.Controls.Add(this.lblCNPJ);
            this.gpbPessoaJuridica.Controls.Add(this.lblNomeFicticio);
            this.gpbPessoaJuridica.Controls.Add(this.txtNomeFicticio);
            this.gpbPessoaJuridica.Enabled = false;
            this.gpbPessoaJuridica.Location = new System.Drawing.Point(13, 172);
            this.gpbPessoaJuridica.Name = "gpbPessoaJuridica";
            this.gpbPessoaJuridica.Size = new System.Drawing.Size(368, 109);
            this.gpbPessoaJuridica.TabIndex = 2;
            this.gpbPessoaJuridica.TabStop = false;
            this.gpbPessoaJuridica.Text = "Pessoa Jurídica";
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
            this.txtCNPJ.Location = new System.Drawing.Point(157, 18);
            this.txtCNPJ.Mask = "000,000,000/0000-00";
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(103, 23);
            this.txtCNPJ.TabIndex = 0;
            this.txtCNPJ.Leave += new System.EventHandler(this.txtCNPJ_Leave);
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
            this.txtNomeFicticio.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtNomeFicticio.Location = new System.Drawing.Point(108, 79);
            this.txtNomeFicticio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeFicticio.MaxLength = 60;
            this.txtNomeFicticio.Name = "txtNomeFicticio";
            this.txtNomeFicticio.Size = new System.Drawing.Size(205, 23);
            this.txtNomeFicticio.TabIndex = 2;
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.cbbEstado);
            this.gpbDados.Controls.Add(this.lblEstado);
            this.gpbDados.Controls.Add(this.cbbCidade);
            this.gpbDados.Controls.Add(this.lblCidade);
            this.gpbDados.Controls.Add(this.ckNoveDigito);
            this.gpbDados.Controls.Add(this.txtTelefone);
            this.gpbDados.Controls.Add(this.lblTelefone);
            this.gpbDados.Controls.Add(this.lblBairro);
            this.gpbDados.Controls.Add(this.txtBairro);
            this.gpbDados.Controls.Add(this.lblEndereco);
            this.gpbDados.Controls.Add(this.txtEndereco);
            this.gpbDados.Location = new System.Drawing.Point(387, 14);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(401, 213);
            this.gpbDados.TabIndex = 3;
            this.gpbDados.TabStop = false;
            // 
            // cbbEstado
            // 
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(145, 23);
            this.cbbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(177, 24);
            this.cbbEstado.TabIndex = 0;
            this.cbbEstado.SelectedValueChanged += new System.EventHandler(this.CbbEstado_SelectedValueChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(41, 26);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 16);
            this.lblEstado.TabIndex = 40;
            this.lblEstado.Text = "Estado:";
            // 
            // cbbCidade
            // 
            this.cbbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCidade.FormattingEnabled = true;
            this.cbbCidade.Location = new System.Drawing.Point(145, 55);
            this.cbbCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbCidade.Name = "cbbCidade";
            this.cbbCidade.Size = new System.Drawing.Size(177, 24);
            this.cbbCidade.TabIndex = 1;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(41, 58);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 16);
            this.lblCidade.TabIndex = 38;
            this.lblCidade.Text = "Cidade:";
            // 
            // ckNoveDigito
            // 
            this.ckNoveDigito.AutoSize = true;
            this.ckNoveDigito.Location = new System.Drawing.Point(285, 151);
            this.ckNoveDigito.Name = "ckNoveDigito";
            this.ckNoveDigito.Size = new System.Drawing.Size(103, 20);
            this.ckNoveDigito.TabIndex = 5;
            this.ckNoveDigito.Text = "Nove dígitos";
            this.ckNoveDigito.UseVisualStyleBackColor = true;
            this.ckNoveDigito.CheckedChanged += new System.EventHandler(this.ckNoveDigito_CheckedChanged);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(167, 148);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(103, 23);
            this.txtTelefone.TabIndex = 4;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(16, 151);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(108, 16);
            this.lblTelefone.TabIndex = 35;
            this.lblTelefone.Text = "Telefone/Celular:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(43, 118);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(47, 16);
            this.lblBairro.TabIndex = 31;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtBairro.Location = new System.Drawing.Point(133, 118);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(205, 23);
            this.txtBairro.TabIndex = 3;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(33, 90);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(67, 16);
            this.lblEndereco.TabIndex = 29;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtEndereco.Location = new System.Drawing.Point(133, 87);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndereco.MaxLength = 60;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(205, 23);
            this.txtEndereco.TabIndex = 2;
            // 
            // gpbPessoaFisica
            // 
            this.gpbPessoaFisica.Controls.Add(this.txtCPF);
            this.gpbPessoaFisica.Controls.Add(this.lblCPF);
            this.gpbPessoaFisica.Controls.Add(this.lblNome);
            this.gpbPessoaFisica.Controls.Add(this.txtNome);
            this.gpbPessoaFisica.Location = new System.Drawing.Point(13, 80);
            this.gpbPessoaFisica.Name = "gpbPessoaFisica";
            this.gpbPessoaFisica.Size = new System.Drawing.Size(368, 86);
            this.gpbPessoaFisica.TabIndex = 1;
            this.gpbPessoaFisica.TabStop = false;
            this.gpbPessoaFisica.Text = "Pessoa Física";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(143, 18);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(103, 23);
            this.txtCPF.TabIndex = 0;
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(190, 24);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Cadastro de Pessoa";
            // 
            // frmCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(826, 390);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCadastroPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroPessoa";
            this.Load += new System.EventHandler(this.FrmCadastroPessoa_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panelInside.ResumeLayout(false);
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.gpbPessoaJuridica.ResumeLayout(false);
            this.gpbPessoaJuridica.PerformLayout();
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.gpbPessoaFisica.ResumeLayout(false);
            this.gpbPessoaFisica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gpbPessoaJuridica;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.MaskedTextBox txtCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblNomeFicticio;
        private System.Windows.Forms.TextBox txtNomeFicticio;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbbCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.CheckBox ckNoveDigito;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.RadioButton rbPessoaJuridica;
        private System.Windows.Forms.RadioButton rbPessoaFisica;
        private System.Windows.Forms.GroupBox gpbPessoaFisica;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.Label lblTitulo;
    }
}