namespace Apresentacao.Variados
{
    partial class controlPessoas
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlPessoas));
            this.panelPessoa = new System.Windows.Forms.Panel();
            this.lblConsultaPessoa = new System.Windows.Forms.Label();
            this.lblCadastroPessoa = new System.Windows.Forms.Label();
            this.picArrowPessoa = new System.Windows.Forms.PictureBox();
            this.btnConsultaPessoa = new System.Windows.Forms.Button();
            this.btnCadastroPessoa = new System.Windows.Forms.Button();
            this.timerPessoaAumenta = new System.Windows.Forms.Timer(this.components);
            this.timerPessoaRecolhe = new System.Windows.Forms.Timer(this.components);
            this.panelContratoAluguel = new System.Windows.Forms.Panel();
            this.lblConsultaContratoAluguel = new System.Windows.Forms.Label();
            this.lblCadastroContratoAluguel = new System.Windows.Forms.Label();
            this.picArrowContratoAluguel = new System.Windows.Forms.PictureBox();
            this.btnConsultaContratoAluguel = new System.Windows.Forms.Button();
            this.btnCadastroContratoAluguel = new System.Windows.Forms.Button();
            this.timerContratoAumenta = new System.Windows.Forms.Timer(this.components);
            this.timerContratoRecolhe = new System.Windows.Forms.Timer(this.components);
            this.panelPessoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowPessoa)).BeginInit();
            this.panelContratoAluguel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowContratoAluguel)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPessoa
            // 
            this.panelPessoa.Controls.Add(this.lblConsultaPessoa);
            this.panelPessoa.Controls.Add(this.lblCadastroPessoa);
            this.panelPessoa.Controls.Add(this.picArrowPessoa);
            this.panelPessoa.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.panelPessoa.Location = new System.Drawing.Point(437, 96);
            this.panelPessoa.Name = "panelPessoa";
            this.panelPessoa.Size = new System.Drawing.Size(0, 55);
            this.panelPessoa.TabIndex = 39;
            // 
            // lblConsultaPessoa
            // 
            this.lblConsultaPessoa.AutoSize = true;
            this.lblConsultaPessoa.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaPessoa.ForeColor = System.Drawing.Color.DarkGray;
            this.lblConsultaPessoa.Location = new System.Drawing.Point(61, 1);
            this.lblConsultaPessoa.Name = "lblConsultaPessoa";
            this.lblConsultaPessoa.Size = new System.Drawing.Size(269, 51);
            this.lblConsultaPessoa.TabIndex = 21;
            this.lblConsultaPessoa.Text = "Consulte seu pecuarista ou cliente\r\npara alterar seus dados e ver todas\r\ncompras," +
    " vendas e contratos relacionados";
            this.lblConsultaPessoa.Visible = false;
            // 
            // lblCadastroPessoa
            // 
            this.lblCadastroPessoa.AutoSize = true;
            this.lblCadastroPessoa.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroPessoa.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCadastroPessoa.Location = new System.Drawing.Point(61, 0);
            this.lblCadastroPessoa.Name = "lblCadastroPessoa";
            this.lblCadastroPessoa.Size = new System.Drawing.Size(197, 51);
            this.lblCadastroPessoa.TabIndex = 16;
            this.lblCadastroPessoa.Text = "Cadastre seus pecuaristas e\r\nclientes para realizar compras,\r\nvendas e contratos " +
    "de aluguel\r\n";
            this.lblCadastroPessoa.Visible = false;
            // 
            // picArrowPessoa
            // 
            this.picArrowPessoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picArrowPessoa.BackgroundImage")));
            this.picArrowPessoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picArrowPessoa.Location = new System.Drawing.Point(3, 0);
            this.picArrowPessoa.Name = "picArrowPessoa";
            this.picArrowPessoa.Size = new System.Drawing.Size(52, 52);
            this.picArrowPessoa.TabIndex = 22;
            this.picArrowPessoa.TabStop = false;
            // 
            // btnConsultaPessoa
            // 
            this.btnConsultaPessoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultaPessoa.FlatAppearance.BorderSize = 0;
            this.btnConsultaPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaPessoa.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultaPessoa.ForeColor = System.Drawing.Color.White;
            this.btnConsultaPessoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaPessoa.Location = new System.Drawing.Point(226, 96);
            this.btnConsultaPessoa.Name = "btnConsultaPessoa";
            this.btnConsultaPessoa.Size = new System.Drawing.Size(205, 55);
            this.btnConsultaPessoa.TabIndex = 38;
            this.btnConsultaPessoa.Text = "Consulta de Pecuaristas/Clientes";
            this.btnConsultaPessoa.UseVisualStyleBackColor = false;
            this.btnConsultaPessoa.Click += new System.EventHandler(this.btnConsultaPessoa_Click);
            this.btnConsultaPessoa.MouseEnter += new System.EventHandler(this.btnConsultaPessoa_MouseEnter);
            this.btnConsultaPessoa.MouseLeave += new System.EventHandler(this.btnConsultaPessoa_MouseLeave);
            // 
            // btnCadastroPessoa
            // 
            this.btnCadastroPessoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastroPessoa.FlatAppearance.BorderSize = 0;
            this.btnCadastroPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroPessoa.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastroPessoa.ForeColor = System.Drawing.Color.White;
            this.btnCadastroPessoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroPessoa.Location = new System.Drawing.Point(15, 96);
            this.btnCadastroPessoa.Name = "btnCadastroPessoa";
            this.btnCadastroPessoa.Size = new System.Drawing.Size(205, 55);
            this.btnCadastroPessoa.TabIndex = 37;
            this.btnCadastroPessoa.Text = "Cadastro de Pecuaristas/Clientes";
            this.btnCadastroPessoa.UseVisualStyleBackColor = false;
            this.btnCadastroPessoa.Click += new System.EventHandler(this.btnCadastroPessoa_Click);
            this.btnCadastroPessoa.MouseEnter += new System.EventHandler(this.btnCadastroPessoa_MouseEnter);
            this.btnCadastroPessoa.MouseLeave += new System.EventHandler(this.btnCadastroPessoa_MouseLeave);
            // 
            // timerPessoaAumenta
            // 
            this.timerPessoaAumenta.Interval = 1;
            this.timerPessoaAumenta.Tick += new System.EventHandler(this.timerPessoaAumenta_Tick);
            // 
            // timerPessoaRecolhe
            // 
            this.timerPessoaRecolhe.Interval = 1;
            this.timerPessoaRecolhe.Tick += new System.EventHandler(this.timerPessoaRecolhe_Tick);
            // 
            // panelContratoAluguel
            // 
            this.panelContratoAluguel.Controls.Add(this.lblConsultaContratoAluguel);
            this.panelContratoAluguel.Controls.Add(this.lblCadastroContratoAluguel);
            this.panelContratoAluguel.Controls.Add(this.picArrowContratoAluguel);
            this.panelContratoAluguel.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.panelContratoAluguel.Location = new System.Drawing.Point(437, 212);
            this.panelContratoAluguel.Name = "panelContratoAluguel";
            this.panelContratoAluguel.Size = new System.Drawing.Size(0, 55);
            this.panelContratoAluguel.TabIndex = 42;
            // 
            // lblConsultaContratoAluguel
            // 
            this.lblConsultaContratoAluguel.AutoSize = true;
            this.lblConsultaContratoAluguel.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaContratoAluguel.ForeColor = System.Drawing.Color.DarkGray;
            this.lblConsultaContratoAluguel.Location = new System.Drawing.Point(61, 1);
            this.lblConsultaContratoAluguel.Name = "lblConsultaContratoAluguel";
            this.lblConsultaContratoAluguel.Size = new System.Drawing.Size(179, 51);
            this.lblConsultaContratoAluguel.TabIndex = 21;
            this.lblConsultaContratoAluguel.Text = "Consulte seus contratos de\r\nalugueis/arrendamentos de\r\npastos/armazéns.";
            this.lblConsultaContratoAluguel.Visible = false;
            // 
            // lblCadastroContratoAluguel
            // 
            this.lblCadastroContratoAluguel.AutoSize = true;
            this.lblCadastroContratoAluguel.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroContratoAluguel.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCadastroContratoAluguel.Location = new System.Drawing.Point(61, 1);
            this.lblCadastroContratoAluguel.Name = "lblCadastroContratoAluguel";
            this.lblCadastroContratoAluguel.Size = new System.Drawing.Size(248, 51);
            this.lblCadastroContratoAluguel.TabIndex = 16;
            this.lblCadastroContratoAluguel.Text = "Cadastre contratos de alugueis\r\npara armazenar os pastos e armazéns \r\nque são arr" +
    "endados/alugados.\r\n";
            this.lblCadastroContratoAluguel.Visible = false;
            // 
            // picArrowContratoAluguel
            // 
            this.picArrowContratoAluguel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picArrowContratoAluguel.BackgroundImage")));
            this.picArrowContratoAluguel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picArrowContratoAluguel.Location = new System.Drawing.Point(3, 0);
            this.picArrowContratoAluguel.Name = "picArrowContratoAluguel";
            this.picArrowContratoAluguel.Size = new System.Drawing.Size(52, 52);
            this.picArrowContratoAluguel.TabIndex = 22;
            this.picArrowContratoAluguel.TabStop = false;
            // 
            // btnConsultaContratoAluguel
            // 
            this.btnConsultaContratoAluguel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultaContratoAluguel.FlatAppearance.BorderSize = 0;
            this.btnConsultaContratoAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaContratoAluguel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultaContratoAluguel.ForeColor = System.Drawing.Color.White;
            this.btnConsultaContratoAluguel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaContratoAluguel.Location = new System.Drawing.Point(226, 212);
            this.btnConsultaContratoAluguel.Name = "btnConsultaContratoAluguel";
            this.btnConsultaContratoAluguel.Size = new System.Drawing.Size(205, 55);
            this.btnConsultaContratoAluguel.TabIndex = 41;
            this.btnConsultaContratoAluguel.Text = "Consulta de Contrato de Aluguel";
            this.btnConsultaContratoAluguel.UseVisualStyleBackColor = false;
            this.btnConsultaContratoAluguel.Click += new System.EventHandler(this.btnConsultaContratoAluguel_Click);
            this.btnConsultaContratoAluguel.MouseEnter += new System.EventHandler(this.btnConsultaContratoAluguel_MouseEnter);
            this.btnConsultaContratoAluguel.MouseLeave += new System.EventHandler(this.btnConsultaContratoAluguel_MouseLeave);
            // 
            // btnCadastroContratoAluguel
            // 
            this.btnCadastroContratoAluguel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastroContratoAluguel.FlatAppearance.BorderSize = 0;
            this.btnCadastroContratoAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroContratoAluguel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastroContratoAluguel.ForeColor = System.Drawing.Color.White;
            this.btnCadastroContratoAluguel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroContratoAluguel.Location = new System.Drawing.Point(15, 212);
            this.btnCadastroContratoAluguel.Name = "btnCadastroContratoAluguel";
            this.btnCadastroContratoAluguel.Size = new System.Drawing.Size(205, 55);
            this.btnCadastroContratoAluguel.TabIndex = 40;
            this.btnCadastroContratoAluguel.Text = "Cadastro de Contrato de Aluguel";
            this.btnCadastroContratoAluguel.UseVisualStyleBackColor = false;
            this.btnCadastroContratoAluguel.Click += new System.EventHandler(this.btnCadastroContratoAluguel_Click);
            this.btnCadastroContratoAluguel.MouseEnter += new System.EventHandler(this.btnCadastroContratoAluguel_MouseEnter);
            this.btnCadastroContratoAluguel.MouseLeave += new System.EventHandler(this.btnCadastroContratoAluguel_MouseLeave);
            // 
            // timerContratoAumenta
            // 
            this.timerContratoAumenta.Interval = 1;
            this.timerContratoAumenta.Tick += new System.EventHandler(this.timerContratoAumenta_Tick);
            // 
            // timerContratoRecolhe
            // 
            this.timerContratoRecolhe.Interval = 1;
            this.timerContratoRecolhe.Tick += new System.EventHandler(this.timerContratoRecolhe_Tick);
            // 
            // controlPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContratoAluguel);
            this.Controls.Add(this.btnConsultaContratoAluguel);
            this.Controls.Add(this.btnCadastroContratoAluguel);
            this.Controls.Add(this.panelPessoa);
            this.Controls.Add(this.btnConsultaPessoa);
            this.Controls.Add(this.btnCadastroPessoa);
            this.Name = "controlPessoas";
            this.Size = new System.Drawing.Size(939, 390);
            this.panelPessoa.ResumeLayout(false);
            this.panelPessoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowPessoa)).EndInit();
            this.panelContratoAluguel.ResumeLayout(false);
            this.panelContratoAluguel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowContratoAluguel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPessoa;
        private System.Windows.Forms.Label lblConsultaPessoa;
        private System.Windows.Forms.Label lblCadastroPessoa;
        private System.Windows.Forms.PictureBox picArrowPessoa;
        private System.Windows.Forms.Button btnConsultaPessoa;
        private System.Windows.Forms.Button btnCadastroPessoa;
        private System.Windows.Forms.Timer timerPessoaAumenta;
        private System.Windows.Forms.Timer timerPessoaRecolhe;
        private System.Windows.Forms.Panel panelContratoAluguel;
        private System.Windows.Forms.Label lblConsultaContratoAluguel;
        private System.Windows.Forms.Label lblCadastroContratoAluguel;
        private System.Windows.Forms.PictureBox picArrowContratoAluguel;
        private System.Windows.Forms.Button btnConsultaContratoAluguel;
        private System.Windows.Forms.Button btnCadastroContratoAluguel;
        private System.Windows.Forms.Timer timerContratoAumenta;
        private System.Windows.Forms.Timer timerContratoRecolhe;
    }
}
