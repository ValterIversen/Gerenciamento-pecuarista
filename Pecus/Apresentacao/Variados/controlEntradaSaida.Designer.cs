namespace Apresentacao.Variados
{
    partial class controlEntradaSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlEntradaSaida));
            this.panelSaida = new System.Windows.Forms.Panel();
            this.lblConsultaSaida = new System.Windows.Forms.Label();
            this.lblCadastroSaida = new System.Windows.Forms.Label();
            this.picArrowTipoItem = new System.Windows.Forms.PictureBox();
            this.panelEntrada = new System.Windows.Forms.Panel();
            this.lblConsultaEntrada = new System.Windows.Forms.Label();
            this.lblCadastroEntrada = new System.Windows.Forms.Label();
            this.picArrowItem = new System.Windows.Forms.PictureBox();
            this.btnConsultaSaida = new System.Windows.Forms.Button();
            this.btnCadastroSaida = new System.Windows.Forms.Button();
            this.btnConsultaEntrada = new System.Windows.Forms.Button();
            this.btnCadastroEntrada = new System.Windows.Forms.Button();
            this.timerEntradaAumentar = new System.Windows.Forms.Timer(this.components);
            this.timerEntradaRecolher = new System.Windows.Forms.Timer(this.components);
            this.timerSaidaAumentar = new System.Windows.Forms.Timer(this.components);
            this.timerSaidaRecolher = new System.Windows.Forms.Timer(this.components);
            this.panelSaida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowTipoItem)).BeginInit();
            this.panelEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSaida
            // 
            this.panelSaida.Controls.Add(this.lblConsultaSaida);
            this.panelSaida.Controls.Add(this.lblCadastroSaida);
            this.panelSaida.Controls.Add(this.picArrowTipoItem);
            this.panelSaida.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.panelSaida.Location = new System.Drawing.Point(435, 228);
            this.panelSaida.Name = "panelSaida";
            this.panelSaida.Size = new System.Drawing.Size(0, 55);
            this.panelSaida.TabIndex = 45;
            // 
            // lblConsultaSaida
            // 
            this.lblConsultaSaida.AutoSize = true;
            this.lblConsultaSaida.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaSaida.ForeColor = System.Drawing.Color.DarkGray;
            this.lblConsultaSaida.Location = new System.Drawing.Point(67, 9);
            this.lblConsultaSaida.Name = "lblConsultaSaida";
            this.lblConsultaSaida.Size = new System.Drawing.Size(143, 34);
            this.lblConsultaSaida.TabIndex = 21;
            this.lblConsultaSaida.Text = "Consulte as saídas de\r\ncada armazém.";
            this.lblConsultaSaida.Visible = false;
            // 
            // lblCadastroSaida
            // 
            this.lblCadastroSaida.AutoSize = true;
            this.lblCadastroSaida.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroSaida.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCadastroSaida.Location = new System.Drawing.Point(61, 1);
            this.lblCadastroSaida.Name = "lblCadastroSaida";
            this.lblCadastroSaida.Size = new System.Drawing.Size(130, 51);
            this.lblCadastroSaida.TabIndex = 16;
            this.lblCadastroSaida.Text = "Cadastre saídas de \r\nitens como vacinas,\r\nrações e outros.";
            this.lblCadastroSaida.Visible = false;
            // 
            // picArrowTipoItem
            // 
            this.picArrowTipoItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picArrowTipoItem.BackgroundImage")));
            this.picArrowTipoItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picArrowTipoItem.Location = new System.Drawing.Point(3, 0);
            this.picArrowTipoItem.Name = "picArrowTipoItem";
            this.picArrowTipoItem.Size = new System.Drawing.Size(52, 52);
            this.picArrowTipoItem.TabIndex = 22;
            this.picArrowTipoItem.TabStop = false;
            // 
            // panelEntrada
            // 
            this.panelEntrada.Controls.Add(this.lblConsultaEntrada);
            this.panelEntrada.Controls.Add(this.lblCadastroEntrada);
            this.panelEntrada.Controls.Add(this.picArrowItem);
            this.panelEntrada.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.panelEntrada.Location = new System.Drawing.Point(435, 83);
            this.panelEntrada.Name = "panelEntrada";
            this.panelEntrada.Size = new System.Drawing.Size(0, 55);
            this.panelEntrada.TabIndex = 42;
            // 
            // lblConsultaEntrada
            // 
            this.lblConsultaEntrada.AutoSize = true;
            this.lblConsultaEntrada.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaEntrada.ForeColor = System.Drawing.Color.DarkGray;
            this.lblConsultaEntrada.Location = new System.Drawing.Point(61, 9);
            this.lblConsultaEntrada.Name = "lblConsultaEntrada";
            this.lblConsultaEntrada.Size = new System.Drawing.Size(163, 34);
            this.lblConsultaEntrada.TabIndex = 21;
            this.lblConsultaEntrada.Text = "Consulte as entradas de \r\ncada armazém.";
            this.lblConsultaEntrada.Visible = false;
            // 
            // lblCadastroEntrada
            // 
            this.lblCadastroEntrada.AutoSize = true;
            this.lblCadastroEntrada.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroEntrada.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCadastroEntrada.Location = new System.Drawing.Point(61, 0);
            this.lblCadastroEntrada.Name = "lblCadastroEntrada";
            this.lblCadastroEntrada.Size = new System.Drawing.Size(144, 51);
            this.lblCadastroEntrada.TabIndex = 16;
            this.lblCadastroEntrada.Text = "Cadastre entradas de \r\nitens como vacinas,\r\nrações e outros.\r\n";
            this.lblCadastroEntrada.Visible = false;
            // 
            // picArrowItem
            // 
            this.picArrowItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picArrowItem.BackgroundImage")));
            this.picArrowItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picArrowItem.Location = new System.Drawing.Point(3, 0);
            this.picArrowItem.Name = "picArrowItem";
            this.picArrowItem.Size = new System.Drawing.Size(52, 52);
            this.picArrowItem.TabIndex = 22;
            this.picArrowItem.TabStop = false;
            // 
            // btnConsultaSaida
            // 
            this.btnConsultaSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultaSaida.FlatAppearance.BorderSize = 0;
            this.btnConsultaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaSaida.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultaSaida.ForeColor = System.Drawing.Color.White;
            this.btnConsultaSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaSaida.Location = new System.Drawing.Point(224, 228);
            this.btnConsultaSaida.Name = "btnConsultaSaida";
            this.btnConsultaSaida.Size = new System.Drawing.Size(205, 55);
            this.btnConsultaSaida.TabIndex = 44;
            this.btnConsultaSaida.Text = "Consulta de Saídas";
            this.btnConsultaSaida.UseVisualStyleBackColor = false;
            this.btnConsultaSaida.Click += new System.EventHandler(this.BtnConsultaSaida_Click);
            this.btnConsultaSaida.MouseEnter += new System.EventHandler(this.BtnConsultaSaida_MouseEnter);
            this.btnConsultaSaida.MouseLeave += new System.EventHandler(this.BtnConsultaSaida_MouseLeave);
            // 
            // btnCadastroSaida
            // 
            this.btnCadastroSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastroSaida.FlatAppearance.BorderSize = 0;
            this.btnCadastroSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroSaida.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastroSaida.ForeColor = System.Drawing.Color.White;
            this.btnCadastroSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroSaida.Location = new System.Drawing.Point(13, 228);
            this.btnCadastroSaida.Name = "btnCadastroSaida";
            this.btnCadastroSaida.Size = new System.Drawing.Size(205, 55);
            this.btnCadastroSaida.TabIndex = 43;
            this.btnCadastroSaida.Text = "Cadastro de Saídas";
            this.btnCadastroSaida.UseVisualStyleBackColor = false;
            this.btnCadastroSaida.Click += new System.EventHandler(this.BtnCadastroSaida_Click);
            this.btnCadastroSaida.MouseEnter += new System.EventHandler(this.BtnCadastroSaida_MouseEnter);
            this.btnCadastroSaida.MouseLeave += new System.EventHandler(this.BtnCadastroSaida_MouseLeave);
            // 
            // btnConsultaEntrada
            // 
            this.btnConsultaEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultaEntrada.FlatAppearance.BorderSize = 0;
            this.btnConsultaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaEntrada.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultaEntrada.ForeColor = System.Drawing.Color.White;
            this.btnConsultaEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaEntrada.Location = new System.Drawing.Point(224, 83);
            this.btnConsultaEntrada.Name = "btnConsultaEntrada";
            this.btnConsultaEntrada.Size = new System.Drawing.Size(205, 55);
            this.btnConsultaEntrada.TabIndex = 41;
            this.btnConsultaEntrada.Text = "Consulta de Entradas";
            this.btnConsultaEntrada.UseVisualStyleBackColor = false;
            this.btnConsultaEntrada.Click += new System.EventHandler(this.BtnConsultaEntrada_Click);
            this.btnConsultaEntrada.MouseEnter += new System.EventHandler(this.BtnConsultaEntrada_MouseEnter);
            this.btnConsultaEntrada.MouseLeave += new System.EventHandler(this.BtnConsultaEntrada_MouseLeave);
            // 
            // btnCadastroEntrada
            // 
            this.btnCadastroEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastroEntrada.FlatAppearance.BorderSize = 0;
            this.btnCadastroEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroEntrada.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastroEntrada.ForeColor = System.Drawing.Color.White;
            this.btnCadastroEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroEntrada.Location = new System.Drawing.Point(13, 83);
            this.btnCadastroEntrada.Name = "btnCadastroEntrada";
            this.btnCadastroEntrada.Size = new System.Drawing.Size(205, 55);
            this.btnCadastroEntrada.TabIndex = 40;
            this.btnCadastroEntrada.Text = "Cadastro de Entradas";
            this.btnCadastroEntrada.UseVisualStyleBackColor = false;
            this.btnCadastroEntrada.Click += new System.EventHandler(this.BtnCadastroEntrada_Click);
            this.btnCadastroEntrada.MouseEnter += new System.EventHandler(this.BtnCadastroEntrada_MouseEnter);
            this.btnCadastroEntrada.MouseLeave += new System.EventHandler(this.BtnCadastroEntrada_MouseLeave);
            // 
            // timerEntradaAumentar
            // 
            this.timerEntradaAumentar.Interval = 1;
            this.timerEntradaAumentar.Tick += new System.EventHandler(this.TimerEntradaAumentar_Tick);
            // 
            // timerEntradaRecolher
            // 
            this.timerEntradaRecolher.Interval = 1;
            this.timerEntradaRecolher.Tick += new System.EventHandler(this.TimerEntradaRecolher_Tick);
            // 
            // timerSaidaAumentar
            // 
            this.timerSaidaAumentar.Interval = 1;
            this.timerSaidaAumentar.Tick += new System.EventHandler(this.TimerSaidaAumentar_Tick);
            // 
            // timerSaidaRecolher
            // 
            this.timerSaidaRecolher.Interval = 1;
            this.timerSaidaRecolher.Tick += new System.EventHandler(this.TimerSaidaRecolher_Tick);
            // 
            // controlEntradaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSaida);
            this.Controls.Add(this.panelEntrada);
            this.Controls.Add(this.btnConsultaSaida);
            this.Controls.Add(this.btnCadastroSaida);
            this.Controls.Add(this.btnConsultaEntrada);
            this.Controls.Add(this.btnCadastroEntrada);
            this.Name = "controlEntradaSaida";
            this.Size = new System.Drawing.Size(939, 390);
            this.panelSaida.ResumeLayout(false);
            this.panelSaida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowTipoItem)).EndInit();
            this.panelEntrada.ResumeLayout(false);
            this.panelEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSaida;
        private System.Windows.Forms.Label lblConsultaSaida;
        private System.Windows.Forms.Label lblCadastroSaida;
        private System.Windows.Forms.PictureBox picArrowTipoItem;
        private System.Windows.Forms.Panel panelEntrada;
        private System.Windows.Forms.Label lblConsultaEntrada;
        private System.Windows.Forms.Label lblCadastroEntrada;
        private System.Windows.Forms.PictureBox picArrowItem;
        private System.Windows.Forms.Button btnConsultaSaida;
        private System.Windows.Forms.Button btnCadastroSaida;
        private System.Windows.Forms.Button btnConsultaEntrada;
        private System.Windows.Forms.Button btnCadastroEntrada;
        private System.Windows.Forms.Timer timerEntradaAumentar;
        private System.Windows.Forms.Timer timerEntradaRecolher;
        private System.Windows.Forms.Timer timerSaidaAumentar;
        private System.Windows.Forms.Timer timerSaidaRecolher;
    }
}
