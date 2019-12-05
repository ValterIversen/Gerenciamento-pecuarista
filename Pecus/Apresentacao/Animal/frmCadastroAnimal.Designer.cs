namespace Apresentacao.Animal
{
    partial class frmCadastroAnimal
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
            System.Windows.Forms.Button btnCadastrar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroAnimal));
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.cbbRaca = new System.Windows.Forms.ComboBox();
            this.lblRaca = new System.Windows.Forms.Label();
            this.btnBuscarPiquete = new System.Windows.Forms.Button();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.txtPiquete = new System.Windows.Forms.TextBox();
            this.lblPiquete = new System.Windows.Forms.Label();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gpbDadosNaoObrigatorios = new System.Windows.Forms.GroupBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtLocalidade = new System.Windows.Forms.RichTextBox();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.btnBuscarAnimalMae = new System.Windows.Forms.Button();
            this.txtMae = new System.Windows.Forms.TextBox();
            this.lblMae = new System.Windows.Forms.Label();
            this.btnConsultaAnimalPai = new System.Windows.Forms.Button();
            this.txtPai = new System.Windows.Forms.TextBox();
            this.lblPai = new System.Windows.Forms.Label();
            this.panelInside = new System.Windows.Forms.Panel();
            this.gpbPesagem = new System.Windows.Forms.GroupBox();
            this.lblHectare = new System.Windows.Forms.Label();
            this.dpbDataPesagem = new System.Windows.Forms.DateTimePicker();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblDataPesagem = new System.Windows.Forms.Label();
            btnCadastrar = new System.Windows.Forms.Button();
            this.gpbDados.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.gpbDadosNaoObrigatorios.SuspendLayout();
            this.panelInside.SuspendLayout();
            this.gpbPesagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCadastrar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            btnCadastrar.ForeColor = System.Drawing.Color.White;
            btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new System.Drawing.Point(583, 286);
            btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new System.Drawing.Size(239, 68);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.cbbRaca);
            this.gpbDados.Controls.Add(this.lblRaca);
            this.gpbDados.Controls.Add(this.btnBuscarPiquete);
            this.gpbDados.Controls.Add(this.txtIdentificador);
            this.gpbDados.Controls.Add(this.txtPiquete);
            this.gpbDados.Controls.Add(this.lblPiquete);
            this.gpbDados.Controls.Add(this.lblIdentificador);
            this.gpbDados.Controls.Add(this.txtDescricao);
            this.gpbDados.Controls.Add(this.lblDescricao);
            this.gpbDados.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDados.Location = new System.Drawing.Point(12, 12);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(445, 248);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Cadastro de animal";
            // 
            // cbbRaca
            // 
            this.cbbRaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRaca.FormattingEnabled = true;
            this.cbbRaca.Location = new System.Drawing.Point(127, 163);
            this.cbbRaca.MaxLength = 4214124;
            this.cbbRaca.Name = "cbbRaca";
            this.cbbRaca.Size = new System.Drawing.Size(170, 24);
            this.cbbRaca.TabIndex = 2;
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(82, 166);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(39, 16);
            this.lblRaca.TabIndex = 35;
            this.lblRaca.Text = "Raca:";
            // 
            // btnBuscarPiquete
            // 
            this.btnBuscarPiquete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarPiquete.FlatAppearance.BorderSize = 0;
            this.btnBuscarPiquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPiquete.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPiquete.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPiquete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPiquete.Location = new System.Drawing.Point(224, 194);
            this.btnBuscarPiquete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarPiquete.Name = "btnBuscarPiquete";
            this.btnBuscarPiquete.Size = new System.Drawing.Size(185, 42);
            this.btnBuscarPiquete.TabIndex = 4;
            this.btnBuscarPiquete.Text = "Buscar Piquete";
            this.btnBuscarPiquete.UseVisualStyleBackColor = false;
            this.btnBuscarPiquete.Click += new System.EventHandler(this.btnBuscarPiquete_Click);
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(209, 129);
            this.txtIdentificador.MaxLength = 8;
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(100, 23);
            this.txtIdentificador.TabIndex = 1;
            // 
            // txtPiquete
            // 
            this.txtPiquete.Enabled = false;
            this.txtPiquete.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtPiquete.Location = new System.Drawing.Point(78, 204);
            this.txtPiquete.Name = "txtPiquete";
            this.txtPiquete.Size = new System.Drawing.Size(140, 23);
            this.txtPiquete.TabIndex = 3;
            this.txtPiquete.Text = "0";
            // 
            // lblPiquete
            // 
            this.lblPiquete.AutoSize = true;
            this.lblPiquete.Location = new System.Drawing.Point(15, 207);
            this.lblPiquete.Name = "lblPiquete";
            this.lblPiquete.Size = new System.Drawing.Size(57, 16);
            this.lblPiquete.TabIndex = 32;
            this.lblPiquete.Text = "Piquete:";
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Location = new System.Drawing.Point(73, 132);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(130, 16);
            this.lblIdentificador.TabIndex = 4;
            this.lblIdentificador.Text = "Identificador/brinco:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtDescricao.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDescricao.Location = new System.Drawing.Point(6, 47);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(422, 71);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.Text = "Descreva informações importantes para o animal, informações que o identifique e/o" +
    "u são importantes para sua criação.";
            this.txtDescricao.Enter += new System.EventHandler(this.TxtDescricao_Enter);
            this.txtDescricao.Leave += new System.EventHandler(this.TxtDescricao_Leave);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 29);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(129, 16);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição do animal:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.panel4.Controls.Add(this.lblTitulo);
            this.panel4.Controls.Add(this.picExit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(948, 45);
            this.panel4.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(191, 24);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Cadastro de Animal";
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(905, 3);
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
            this.panel2.Size = new System.Drawing.Size(948, 12);
            this.panel2.TabIndex = 6;
            // 
            // gpbDadosNaoObrigatorios
            // 
            this.gpbDadosNaoObrigatorios.Controls.Add(this.dtpDataNascimento);
            this.gpbDadosNaoObrigatorios.Controls.Add(this.lblDataNascimento);
            this.gpbDadosNaoObrigatorios.Controls.Add(this.txtLocalidade);
            this.gpbDadosNaoObrigatorios.Controls.Add(this.lblLocalidade);
            this.gpbDadosNaoObrigatorios.Controls.Add(this.btnBuscarAnimalMae);
            this.gpbDadosNaoObrigatorios.Controls.Add(this.txtMae);
            this.gpbDadosNaoObrigatorios.Controls.Add(this.lblMae);
            this.gpbDadosNaoObrigatorios.Controls.Add(this.btnConsultaAnimalPai);
            this.gpbDadosNaoObrigatorios.Controls.Add(this.txtPai);
            this.gpbDadosNaoObrigatorios.Controls.Add(this.lblPai);
            this.gpbDadosNaoObrigatorios.Location = new System.Drawing.Point(464, 13);
            this.gpbDadosNaoObrigatorios.Name = "gpbDadosNaoObrigatorios";
            this.gpbDadosNaoObrigatorios.Size = new System.Drawing.Size(447, 247);
            this.gpbDadosNaoObrigatorios.TabIndex = 2;
            this.gpbDadosNaoObrigatorios.TabStop = false;
            this.gpbDadosNaoObrigatorios.Text = "Dados não obrigatórios";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(148, 209);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(286, 23);
            this.dtpDataNascimento.TabIndex = 5;
            this.dtpDataNascimento.ValueChanged += new System.EventHandler(this.dtpDataNascimento_ValueChanged);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(13, 214);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(129, 16);
            this.lblDataNascimento.TabIndex = 34;
            this.lblDataNascimento.Text = "Data de nascimento:";
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtLocalidade.ForeColor = System.Drawing.Color.DarkGray;
            this.txtLocalidade.Location = new System.Drawing.Point(12, 149);
            this.txtLocalidade.MaxLength = 60;
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(422, 54);
            this.txtLocalidade.TabIndex = 4;
            this.txtLocalidade.Text = "Descreva informações que identifique a localidade de nascimento do animal.";
            this.txtLocalidade.Enter += new System.EventHandler(this.TxtLocalidade_Enter);
            this.txtLocalidade.Leave += new System.EventHandler(this.TxtLocalidade_Leave);
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Location = new System.Drawing.Point(12, 131);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(164, 16);
            this.lblLocalidade.TabIndex = 30;
            this.lblLocalidade.Text = "Localidade de nascimento:";
            // 
            // btnBuscarAnimalMae
            // 
            this.btnBuscarAnimalMae.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarAnimalMae.FlatAppearance.BorderSize = 0;
            this.btnBuscarAnimalMae.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAnimalMae.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarAnimalMae.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAnimalMae.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarAnimalMae.Location = new System.Drawing.Point(224, 73);
            this.btnBuscarAnimalMae.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarAnimalMae.Name = "btnBuscarAnimalMae";
            this.btnBuscarAnimalMae.Size = new System.Drawing.Size(185, 42);
            this.btnBuscarAnimalMae.TabIndex = 3;
            this.btnBuscarAnimalMae.Text = "Buscar Animal";
            this.btnBuscarAnimalMae.UseVisualStyleBackColor = false;
            this.btnBuscarAnimalMae.Click += new System.EventHandler(this.BtnBuscarAnimalMae_Click);
            // 
            // txtMae
            // 
            this.txtMae.Enabled = false;
            this.txtMae.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtMae.Location = new System.Drawing.Point(133, 83);
            this.txtMae.Name = "txtMae";
            this.txtMae.Size = new System.Drawing.Size(85, 23);
            this.txtMae.TabIndex = 2;
            this.txtMae.Text = "0";
            // 
            // lblMae
            // 
            this.lblMae.AutoSize = true;
            this.lblMae.Location = new System.Drawing.Point(12, 86);
            this.lblMae.Name = "lblMae";
            this.lblMae.Size = new System.Drawing.Size(115, 16);
            this.lblMae.TabIndex = 27;
            this.lblMae.Text = "Parentesco - Mãe:";
            // 
            // btnConsultaAnimalPai
            // 
            this.btnConsultaAnimalPai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnConsultaAnimalPai.FlatAppearance.BorderSize = 0;
            this.btnConsultaAnimalPai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaAnimalPai.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultaAnimalPai.ForeColor = System.Drawing.Color.White;
            this.btnConsultaAnimalPai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaAnimalPai.Location = new System.Drawing.Point(224, 23);
            this.btnConsultaAnimalPai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultaAnimalPai.Name = "btnConsultaAnimalPai";
            this.btnConsultaAnimalPai.Size = new System.Drawing.Size(185, 42);
            this.btnConsultaAnimalPai.TabIndex = 1;
            this.btnConsultaAnimalPai.Text = "Buscar Animal";
            this.btnConsultaAnimalPai.UseVisualStyleBackColor = false;
            this.btnConsultaAnimalPai.Click += new System.EventHandler(this.btnConsultaAnimalPai_Click);
            // 
            // txtPai
            // 
            this.txtPai.Enabled = false;
            this.txtPai.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtPai.Location = new System.Drawing.Point(133, 33);
            this.txtPai.Name = "txtPai";
            this.txtPai.Size = new System.Drawing.Size(85, 23);
            this.txtPai.TabIndex = 0;
            this.txtPai.Text = "0";
            // 
            // lblPai
            // 
            this.lblPai.AutoSize = true;
            this.lblPai.Location = new System.Drawing.Point(12, 36);
            this.lblPai.Name = "lblPai";
            this.lblPai.Size = new System.Drawing.Size(107, 16);
            this.lblPai.TabIndex = 24;
            this.lblPai.Text = "Parentesco - Pai:";
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbPesagem);
            this.panelInside.Controls.Add(btnCadastrar);
            this.panelInside.Controls.Add(this.gpbDados);
            this.panelInside.Controls.Add(this.gpbDadosNaoObrigatorios);
            this.panelInside.Location = new System.Drawing.Point(12, 63);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(923, 365);
            this.panelInside.TabIndex = 11;
            // 
            // gpbPesagem
            // 
            this.gpbPesagem.Controls.Add(this.lblHectare);
            this.gpbPesagem.Controls.Add(this.dpbDataPesagem);
            this.gpbPesagem.Controls.Add(this.txtPeso);
            this.gpbPesagem.Controls.Add(this.lblPeso);
            this.gpbPesagem.Controls.Add(this.lblDataPesagem);
            this.gpbPesagem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesagem.Location = new System.Drawing.Point(12, 266);
            this.gpbPesagem.Name = "gpbPesagem";
            this.gpbPesagem.Size = new System.Drawing.Size(445, 88);
            this.gpbPesagem.TabIndex = 1;
            this.gpbPesagem.TabStop = false;
            this.gpbPesagem.Text = "Peso do animal";
            // 
            // lblHectare
            // 
            this.lblHectare.AutoSize = true;
            this.lblHectare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.lblHectare.Location = new System.Drawing.Point(260, 54);
            this.lblHectare.Name = "lblHectare";
            this.lblHectare.Size = new System.Drawing.Size(74, 16);
            this.lblHectare.TabIndex = 37;
            this.lblHectare.Text = "Kilogramas";
            // 
            // dpbDataPesagem
            // 
            this.dpbDataPesagem.Location = new System.Drawing.Point(127, 22);
            this.dpbDataPesagem.Name = "dpbDataPesagem";
            this.dpbDataPesagem.Size = new System.Drawing.Size(286, 23);
            this.dpbDataPesagem.TabIndex = 0;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(127, 51);
            this.txtPeso.MaxLength = 10;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(127, 23);
            this.txtPeso.TabIndex = 1;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPeso_KeyPress);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(80, 54);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(40, 16);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso:";
            // 
            // lblDataPesagem
            // 
            this.lblDataPesagem.AutoSize = true;
            this.lblDataPesagem.Location = new System.Drawing.Point(6, 29);
            this.lblDataPesagem.Name = "lblDataPesagem";
            this.lblDataPesagem.Size = new System.Drawing.Size(114, 16);
            this.lblDataPesagem.TabIndex = 2;
            this.lblDataPesagem.Text = "Data da pesagem:";
            // 
            // frmCadastroAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(948, 439);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCadastroAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroAnimal";
            this.Load += new System.EventHandler(this.FrmCadastroAnimal_Load);
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.gpbDadosNaoObrigatorios.ResumeLayout(false);
            this.gpbDadosNaoObrigatorios.PerformLayout();
            this.panelInside.ResumeLayout(false);
            this.gpbPesagem.ResumeLayout(false);
            this.gpbPesagem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.ComboBox cbbRaca;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Button btnBuscarPiquete;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.TextBox txtPiquete;
        private System.Windows.Forms.Label lblPiquete;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.GroupBox gpbDadosNaoObrigatorios;
        private System.Windows.Forms.RichTextBox txtLocalidade;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.Button btnBuscarAnimalMae;
        private System.Windows.Forms.TextBox txtMae;
        private System.Windows.Forms.Label lblMae;
        private System.Windows.Forms.Button btnConsultaAnimalPai;
        private System.Windows.Forms.TextBox txtPai;
        private System.Windows.Forms.Label lblPai;
        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.GroupBox gpbPesagem;
        private System.Windows.Forms.DateTimePicker dpbDataPesagem;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblDataPesagem;
        private System.Windows.Forms.Label lblHectare;
        private System.Windows.Forms.Label lblTitulo;
    }
}