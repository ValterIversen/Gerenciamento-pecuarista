namespace Apresentacao.Variados
{
    partial class controlAnimais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlAnimais));
            this.btnCadastroAnimal = new System.Windows.Forms.Button();
            this.btnConsultaAnimal = new System.Windows.Forms.Button();
            this.btnConsultaPesagem = new System.Windows.Forms.Button();
            this.btnCadastroPesagem = new System.Windows.Forms.Button();
            this.btnCadastroRaca = new System.Windows.Forms.Button();
            this.btnConsultaRaca = new System.Windows.Forms.Button();
            this.lblCadastroAnimal = new System.Windows.Forms.Label();
            this.lblCadastroPesagem = new System.Windows.Forms.Label();
            this.lblCadastroRaca = new System.Windows.Forms.Label();
            this.lblConsultaRaca = new System.Windows.Forms.Label();
            this.lblConsultaPesagem = new System.Windows.Forms.Label();
            this.lblConsultaAnimal = new System.Windows.Forms.Label();
            this.timerAnimalAumentar = new System.Windows.Forms.Timer(this.components);
            this.timerPesagemAumentar = new System.Windows.Forms.Timer(this.components);
            this.timerRacaAumentar = new System.Windows.Forms.Timer(this.components);
            this.panelRaca = new System.Windows.Forms.Panel();
            this.picArrowRaca = new System.Windows.Forms.PictureBox();
            this.panelPesagem = new System.Windows.Forms.Panel();
            this.picArrowPesagem = new System.Windows.Forms.PictureBox();
            this.panelAnimal = new System.Windows.Forms.Panel();
            this.picArrowAnimal = new System.Windows.Forms.PictureBox();
            this.timerAnimalRecolher = new System.Windows.Forms.Timer(this.components);
            this.timerPesagemRecolher = new System.Windows.Forms.Timer(this.components);
            this.timerRacaRecolher = new System.Windows.Forms.Timer(this.components);
            this.panelRaca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowRaca)).BeginInit();
            this.panelPesagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowPesagem)).BeginInit();
            this.panelAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastroAnimal
            // 
            this.btnCadastroAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastroAnimal.FlatAppearance.BorderSize = 0;
            this.btnCadastroAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroAnimal.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastroAnimal.ForeColor = System.Drawing.Color.White;
            this.btnCadastroAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroAnimal.Location = new System.Drawing.Point(12, 22);
            this.btnCadastroAnimal.Name = "btnCadastroAnimal";
            this.btnCadastroAnimal.Size = new System.Drawing.Size(205, 55);
            this.btnCadastroAnimal.TabIndex = 8;
            this.btnCadastroAnimal.Text = "Cadastro de Animais";
            this.btnCadastroAnimal.UseVisualStyleBackColor = false;
            this.btnCadastroAnimal.Click += new System.EventHandler(this.BtnCadastroAnimal_Click);
            this.btnCadastroAnimal.MouseEnter += new System.EventHandler(this.BtnCadastroAnimal_MouseEnter);
            this.btnCadastroAnimal.MouseLeave += new System.EventHandler(this.BtnCadastroAnimal_MouseLeave);
            // 
            // btnConsultaAnimal
            // 
            this.btnConsultaAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultaAnimal.FlatAppearance.BorderSize = 0;
            this.btnConsultaAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaAnimal.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultaAnimal.ForeColor = System.Drawing.Color.White;
            this.btnConsultaAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaAnimal.Location = new System.Drawing.Point(223, 22);
            this.btnConsultaAnimal.Name = "btnConsultaAnimal";
            this.btnConsultaAnimal.Size = new System.Drawing.Size(205, 55);
            this.btnConsultaAnimal.TabIndex = 9;
            this.btnConsultaAnimal.Text = "Consulta de Animais";
            this.btnConsultaAnimal.UseVisualStyleBackColor = false;
            this.btnConsultaAnimal.Click += new System.EventHandler(this.BtnConsultaAnimal_Click);
            this.btnConsultaAnimal.MouseEnter += new System.EventHandler(this.BtnConsultaAnimal_MouseEnter);
            this.btnConsultaAnimal.MouseLeave += new System.EventHandler(this.BtnConsultaAnimal_MouseLeave);
            // 
            // btnConsultaPesagem
            // 
            this.btnConsultaPesagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultaPesagem.FlatAppearance.BorderSize = 0;
            this.btnConsultaPesagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaPesagem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultaPesagem.ForeColor = System.Drawing.Color.White;
            this.btnConsultaPesagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaPesagem.Location = new System.Drawing.Point(223, 161);
            this.btnConsultaPesagem.Name = "btnConsultaPesagem";
            this.btnConsultaPesagem.Size = new System.Drawing.Size(205, 55);
            this.btnConsultaPesagem.TabIndex = 11;
            this.btnConsultaPesagem.Text = "Consulta de Pesagens";
            this.btnConsultaPesagem.UseVisualStyleBackColor = false;
            this.btnConsultaPesagem.Click += new System.EventHandler(this.btnConsultaPesagem_Click);
            this.btnConsultaPesagem.MouseEnter += new System.EventHandler(this.BtnConsultaPesagem_MouseEnter);
            this.btnConsultaPesagem.MouseLeave += new System.EventHandler(this.BtnConsultaPesagem_MouseLeave);
            // 
            // btnCadastroPesagem
            // 
            this.btnCadastroPesagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastroPesagem.FlatAppearance.BorderSize = 0;
            this.btnCadastroPesagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroPesagem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastroPesagem.ForeColor = System.Drawing.Color.White;
            this.btnCadastroPesagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroPesagem.Location = new System.Drawing.Point(12, 161);
            this.btnCadastroPesagem.Name = "btnCadastroPesagem";
            this.btnCadastroPesagem.Size = new System.Drawing.Size(205, 55);
            this.btnCadastroPesagem.TabIndex = 10;
            this.btnCadastroPesagem.Text = "Cadastro de Pesagens";
            this.btnCadastroPesagem.UseVisualStyleBackColor = false;
            this.btnCadastroPesagem.Click += new System.EventHandler(this.btnCadastroPesagem_Click);
            this.btnCadastroPesagem.MouseEnter += new System.EventHandler(this.BtnCadastroPesagem_MouseEnter);
            this.btnCadastroPesagem.MouseLeave += new System.EventHandler(this.BtnCadastroPesagem_MouseLeave);
            // 
            // btnCadastroRaca
            // 
            this.btnCadastroRaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastroRaca.FlatAppearance.BorderSize = 0;
            this.btnCadastroRaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroRaca.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastroRaca.ForeColor = System.Drawing.Color.White;
            this.btnCadastroRaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroRaca.Location = new System.Drawing.Point(12, 297);
            this.btnCadastroRaca.Name = "btnCadastroRaca";
            this.btnCadastroRaca.Size = new System.Drawing.Size(205, 55);
            this.btnCadastroRaca.TabIndex = 12;
            this.btnCadastroRaca.Text = "Cadastro de Raças";
            this.btnCadastroRaca.UseVisualStyleBackColor = false;
            this.btnCadastroRaca.Click += new System.EventHandler(this.BtnCadastroRaca_Click);
            this.btnCadastroRaca.MouseEnter += new System.EventHandler(this.BtnCadastroRaca_MouseEnter);
            this.btnCadastroRaca.MouseLeave += new System.EventHandler(this.BtnCadastroRaca_MouseLeave);
            // 
            // btnConsultaRaca
            // 
            this.btnConsultaRaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultaRaca.FlatAppearance.BorderSize = 0;
            this.btnConsultaRaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaRaca.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultaRaca.ForeColor = System.Drawing.Color.White;
            this.btnConsultaRaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaRaca.Location = new System.Drawing.Point(223, 296);
            this.btnConsultaRaca.Name = "btnConsultaRaca";
            this.btnConsultaRaca.Size = new System.Drawing.Size(205, 55);
            this.btnConsultaRaca.TabIndex = 13;
            this.btnConsultaRaca.Text = "Consulta de Raças";
            this.btnConsultaRaca.UseVisualStyleBackColor = false;
            this.btnConsultaRaca.Click += new System.EventHandler(this.BtnConsultaRaca_Click);
            this.btnConsultaRaca.MouseEnter += new System.EventHandler(this.BtnConsultaRaca_MouseEnter);
            this.btnConsultaRaca.MouseLeave += new System.EventHandler(this.BtnConsultaRaca_MouseLeave);
            // 
            // lblCadastroAnimal
            // 
            this.lblCadastroAnimal.AutoSize = true;
            this.lblCadastroAnimal.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroAnimal.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCadastroAnimal.Location = new System.Drawing.Point(77, -1);
            this.lblCadastroAnimal.Name = "lblCadastroAnimal";
            this.lblCadastroAnimal.Size = new System.Drawing.Size(265, 51);
            this.lblCadastroAnimal.TabIndex = 16;
            this.lblCadastroAnimal.Text = "Faça cadastro de animais recem-nascidos\r\nou de origem não negociável (presente,\r\n" +
    "troca entre outros).\r\n";
            this.lblCadastroAnimal.Visible = false;
            // 
            // lblCadastroPesagem
            // 
            this.lblCadastroPesagem.AutoSize = true;
            this.lblCadastroPesagem.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCadastroPesagem.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCadastroPesagem.Location = new System.Drawing.Point(61, 12);
            this.lblCadastroPesagem.Name = "lblCadastroPesagem";
            this.lblCadastroPesagem.Size = new System.Drawing.Size(239, 34);
            this.lblCadastroPesagem.TabIndex = 17;
            this.lblCadastroPesagem.Text = "Gerencie o crescimento dos bovinos \r\nrealizando pesagens.";
            this.lblCadastroPesagem.Visible = false;
            // 
            // lblCadastroRaca
            // 
            this.lblCadastroRaca.AutoSize = true;
            this.lblCadastroRaca.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCadastroRaca.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCadastroRaca.Location = new System.Drawing.Point(61, 10);
            this.lblCadastroRaca.Name = "lblCadastroRaca";
            this.lblCadastroRaca.Size = new System.Drawing.Size(216, 34);
            this.lblCadastroRaca.TabIndex = 18;
            this.lblCadastroRaca.Text = "Cadastre as raças para armazenar\r\nas raças dos bovinos.";
            this.lblCadastroRaca.Visible = false;
            // 
            // lblConsultaRaca
            // 
            this.lblConsultaRaca.AutoSize = true;
            this.lblConsultaRaca.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblConsultaRaca.ForeColor = System.Drawing.Color.DarkGray;
            this.lblConsultaRaca.Location = new System.Drawing.Point(61, 10);
            this.lblConsultaRaca.Name = "lblConsultaRaca";
            this.lblConsultaRaca.Size = new System.Drawing.Size(193, 34);
            this.lblConsultaRaca.TabIndex = 19;
            this.lblConsultaRaca.Text = "Consulte as raças cadastradas\r\ne realize alterações.";
            this.lblConsultaRaca.Visible = false;
            // 
            // lblConsultaPesagem
            // 
            this.lblConsultaPesagem.AutoSize = true;
            this.lblConsultaPesagem.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblConsultaPesagem.ForeColor = System.Drawing.Color.DarkGray;
            this.lblConsultaPesagem.Location = new System.Drawing.Point(61, 1);
            this.lblConsultaPesagem.Name = "lblConsultaPesagem";
            this.lblConsultaPesagem.Size = new System.Drawing.Size(257, 51);
            this.lblConsultaPesagem.TabIndex = 20;
            this.lblConsultaPesagem.Text = "Consulte as pesagem de seus animais\r\npara se ter um relatório de crescimento\r\nind" +
    "ividual ou em conjunto.";
            this.lblConsultaPesagem.Visible = false;
            // 
            // lblConsultaAnimal
            // 
            this.lblConsultaAnimal.AutoSize = true;
            this.lblConsultaAnimal.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaAnimal.ForeColor = System.Drawing.Color.DarkGray;
            this.lblConsultaAnimal.Location = new System.Drawing.Point(77, 11);
            this.lblConsultaAnimal.Name = "lblConsultaAnimal";
            this.lblConsultaAnimal.Size = new System.Drawing.Size(193, 34);
            this.lblConsultaAnimal.TabIndex = 21;
            this.lblConsultaAnimal.Text = "Realize consultas e alterações\r\nem seus animais.";
            this.lblConsultaAnimal.Visible = false;
            // 
            // timerAnimalAumentar
            // 
            this.timerAnimalAumentar.Interval = 1;
            this.timerAnimalAumentar.Tick += new System.EventHandler(this.TimerAnimalAumentar_Tick);
            // 
            // timerPesagemAumentar
            // 
            this.timerPesagemAumentar.Interval = 1;
            this.timerPesagemAumentar.Tick += new System.EventHandler(this.TimerPesagemAumentar_Tick);
            // 
            // timerRacaAumentar
            // 
            this.timerRacaAumentar.Interval = 1;
            this.timerRacaAumentar.Tick += new System.EventHandler(this.TimerRacaAumentar_Tick);
            // 
            // panelRaca
            // 
            this.panelRaca.Controls.Add(this.picArrowRaca);
            this.panelRaca.Controls.Add(this.lblCadastroRaca);
            this.panelRaca.Controls.Add(this.lblConsultaRaca);
            this.panelRaca.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.panelRaca.Location = new System.Drawing.Point(434, 296);
            this.panelRaca.Name = "panelRaca";
            this.panelRaca.Size = new System.Drawing.Size(0, 55);
            this.panelRaca.TabIndex = 25;
            // 
            // picArrowRaca
            // 
            this.picArrowRaca.BackgroundImage = global::Apresentacao.Properties.Resources.arrow_info;
            this.picArrowRaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picArrowRaca.Location = new System.Drawing.Point(3, 0);
            this.picArrowRaca.Name = "picArrowRaca";
            this.picArrowRaca.Size = new System.Drawing.Size(52, 52);
            this.picArrowRaca.TabIndex = 24;
            this.picArrowRaca.TabStop = false;
            // 
            // panelPesagem
            // 
            this.panelPesagem.Controls.Add(this.picArrowPesagem);
            this.panelPesagem.Controls.Add(this.lblCadastroPesagem);
            this.panelPesagem.Controls.Add(this.lblConsultaPesagem);
            this.panelPesagem.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.panelPesagem.Location = new System.Drawing.Point(434, 161);
            this.panelPesagem.Name = "panelPesagem";
            this.panelPesagem.Size = new System.Drawing.Size(0, 55);
            this.panelPesagem.TabIndex = 26;
            // 
            // picArrowPesagem
            // 
            this.picArrowPesagem.BackgroundImage = global::Apresentacao.Properties.Resources.arrow_info;
            this.picArrowPesagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picArrowPesagem.Location = new System.Drawing.Point(3, 0);
            this.picArrowPesagem.Name = "picArrowPesagem";
            this.picArrowPesagem.Size = new System.Drawing.Size(52, 52);
            this.picArrowPesagem.TabIndex = 23;
            this.picArrowPesagem.TabStop = false;
            // 
            // panelAnimal
            // 
            this.panelAnimal.Controls.Add(this.lblConsultaAnimal);
            this.panelAnimal.Controls.Add(this.lblCadastroAnimal);
            this.panelAnimal.Controls.Add(this.picArrowAnimal);
            this.panelAnimal.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.panelAnimal.Location = new System.Drawing.Point(434, 22);
            this.panelAnimal.Name = "panelAnimal";
            this.panelAnimal.Size = new System.Drawing.Size(0, 55);
            this.panelAnimal.TabIndex = 27;
            // 
            // picArrowAnimal
            // 
            this.picArrowAnimal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picArrowAnimal.BackgroundImage")));
            this.picArrowAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picArrowAnimal.Location = new System.Drawing.Point(3, 0);
            this.picArrowAnimal.Name = "picArrowAnimal";
            this.picArrowAnimal.Size = new System.Drawing.Size(52, 52);
            this.picArrowAnimal.TabIndex = 22;
            this.picArrowAnimal.TabStop = false;
            // 
            // timerAnimalRecolher
            // 
            this.timerAnimalRecolher.Interval = 1;
            this.timerAnimalRecolher.Tick += new System.EventHandler(this.TimerAnimalRecolher_Tick);
            // 
            // timerPesagemRecolher
            // 
            this.timerPesagemRecolher.Interval = 1;
            this.timerPesagemRecolher.Tick += new System.EventHandler(this.TimerPesagemRecolher_Tick);
            // 
            // timerRacaRecolher
            // 
            this.timerRacaRecolher.Interval = 1;
            this.timerRacaRecolher.Tick += new System.EventHandler(this.TimerRacaRecolher_Tick);
            // 
            // controlAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelAnimal);
            this.Controls.Add(this.panelPesagem);
            this.Controls.Add(this.panelRaca);
            this.Controls.Add(this.btnConsultaRaca);
            this.Controls.Add(this.btnCadastroRaca);
            this.Controls.Add(this.btnConsultaPesagem);
            this.Controls.Add(this.btnCadastroPesagem);
            this.Controls.Add(this.btnConsultaAnimal);
            this.Controls.Add(this.btnCadastroAnimal);
            this.DoubleBuffered = true;
            this.Name = "controlAnimais";
            this.Size = new System.Drawing.Size(939, 390);
            this.panelRaca.ResumeLayout(false);
            this.panelRaca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowRaca)).EndInit();
            this.panelPesagem.ResumeLayout(false);
            this.panelPesagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowPesagem)).EndInit();
            this.panelAnimal.ResumeLayout(false);
            this.panelAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroAnimal;
        private System.Windows.Forms.Button btnConsultaAnimal;
        private System.Windows.Forms.Button btnConsultaPesagem;
        private System.Windows.Forms.Button btnCadastroPesagem;
        private System.Windows.Forms.Button btnCadastroRaca;
        private System.Windows.Forms.Button btnConsultaRaca;
        private System.Windows.Forms.Label lblCadastroAnimal;
        private System.Windows.Forms.Label lblCadastroPesagem;
        private System.Windows.Forms.Label lblCadastroRaca;
        private System.Windows.Forms.Label lblConsultaRaca;
        private System.Windows.Forms.Label lblConsultaPesagem;
        private System.Windows.Forms.Label lblConsultaAnimal;
        private System.Windows.Forms.PictureBox picArrowAnimal;
        private System.Windows.Forms.PictureBox picArrowPesagem;
        private System.Windows.Forms.PictureBox picArrowRaca;
        private System.Windows.Forms.Timer timerAnimalAumentar;
        private System.Windows.Forms.Timer timerPesagemAumentar;
        private System.Windows.Forms.Timer timerRacaAumentar;
        private System.Windows.Forms.Panel panelRaca;
        private System.Windows.Forms.Panel panelPesagem;
        private System.Windows.Forms.Panel panelAnimal;
        private System.Windows.Forms.Timer timerAnimalRecolher;
        private System.Windows.Forms.Timer timerPesagemRecolher;
        private System.Windows.Forms.Timer timerRacaRecolher;
    }
}
