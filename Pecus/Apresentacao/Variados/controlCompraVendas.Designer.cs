namespace Apresentacao.Variados
{
    partial class controlCompraVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlCompraVendas));
            this.panelVenda = new System.Windows.Forms.Panel();
            this.lblConsultaVenda = new System.Windows.Forms.Label();
            this.lblCadastroVenda = new System.Windows.Forms.Label();
            this.picArrowVenda = new System.Windows.Forms.PictureBox();
            this.btnConsultaVenda = new System.Windows.Forms.Button();
            this.btnCadastroVenda = new System.Windows.Forms.Button();
            this.panelCompra = new System.Windows.Forms.Panel();
            this.lblConsultaCompra = new System.Windows.Forms.Label();
            this.lblCadastroCompra = new System.Windows.Forms.Label();
            this.picArrowCompra = new System.Windows.Forms.PictureBox();
            this.btnConsultaCompra = new System.Windows.Forms.Button();
            this.btnCadastroCompra = new System.Windows.Forms.Button();
            this.timerPessoaAumenta = new System.Windows.Forms.Timer(this.components);
            this.timerPessoaRecolhe = new System.Windows.Forms.Timer(this.components);
            this.timerVendaAumenta = new System.Windows.Forms.Timer(this.components);
            this.timerVendaRecolhe = new System.Windows.Forms.Timer(this.components);
            this.panelVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowVenda)).BeginInit();
            this.panelCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVenda
            // 
            this.panelVenda.Controls.Add(this.lblConsultaVenda);
            this.panelVenda.Controls.Add(this.lblCadastroVenda);
            this.panelVenda.Controls.Add(this.picArrowVenda);
            this.panelVenda.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.panelVenda.Location = new System.Drawing.Point(478, 215);
            this.panelVenda.Name = "panelVenda";
            this.panelVenda.Size = new System.Drawing.Size(0, 55);
            this.panelVenda.TabIndex = 48;
            // 
            // lblConsultaVenda
            // 
            this.lblConsultaVenda.AutoSize = true;
            this.lblConsultaVenda.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaVenda.ForeColor = System.Drawing.Color.DarkGray;
            this.lblConsultaVenda.Location = new System.Drawing.Point(61, 1);
            this.lblConsultaVenda.Name = "lblConsultaVenda";
            this.lblConsultaVenda.Size = new System.Drawing.Size(211, 51);
            this.lblConsultaVenda.TabIndex = 21;
            this.lblConsultaVenda.Text = "Consulte suas vendas\r\npara saber quais animais foram \r\nvendidos e para quem.";
            this.lblConsultaVenda.Visible = false;
            // 
            // lblCadastroVenda
            // 
            this.lblCadastroVenda.AutoSize = true;
            this.lblCadastroVenda.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroVenda.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCadastroVenda.Location = new System.Drawing.Point(61, 1);
            this.lblCadastroVenda.Name = "lblCadastroVenda";
            this.lblCadastroVenda.Size = new System.Drawing.Size(195, 51);
            this.lblCadastroVenda.TabIndex = 16;
            this.lblCadastroVenda.Text = "Cadastre suas vendas para\r\npara tomar decisões baseadas\r\nem resultados.\r\n";
            this.lblCadastroVenda.Visible = false;
            // 
            // picArrowVenda
            // 
            this.picArrowVenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picArrowVenda.BackgroundImage")));
            this.picArrowVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picArrowVenda.Location = new System.Drawing.Point(3, 0);
            this.picArrowVenda.Name = "picArrowVenda";
            this.picArrowVenda.Size = new System.Drawing.Size(52, 52);
            this.picArrowVenda.TabIndex = 22;
            this.picArrowVenda.TabStop = false;
            // 
            // btnConsultaVenda
            // 
            this.btnConsultaVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultaVenda.FlatAppearance.BorderSize = 0;
            this.btnConsultaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaVenda.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultaVenda.ForeColor = System.Drawing.Color.White;
            this.btnConsultaVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaVenda.Location = new System.Drawing.Point(267, 215);
            this.btnConsultaVenda.Name = "btnConsultaVenda";
            this.btnConsultaVenda.Size = new System.Drawing.Size(205, 55);
            this.btnConsultaVenda.TabIndex = 47;
            this.btnConsultaVenda.Text = "Consulta de Venda";
            this.btnConsultaVenda.UseVisualStyleBackColor = false;
            this.btnConsultaVenda.Click += new System.EventHandler(this.btnConsultaVenda_Click);
            this.btnConsultaVenda.MouseEnter += new System.EventHandler(this.btnConsultaVenda_MouseEnter);
            this.btnConsultaVenda.MouseLeave += new System.EventHandler(this.btnConsultaVenda_MouseLeave);
            // 
            // btnCadastroVenda
            // 
            this.btnCadastroVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastroVenda.FlatAppearance.BorderSize = 0;
            this.btnCadastroVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroVenda.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastroVenda.ForeColor = System.Drawing.Color.White;
            this.btnCadastroVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroVenda.Location = new System.Drawing.Point(56, 215);
            this.btnCadastroVenda.Name = "btnCadastroVenda";
            this.btnCadastroVenda.Size = new System.Drawing.Size(205, 55);
            this.btnCadastroVenda.TabIndex = 46;
            this.btnCadastroVenda.Text = "Cadastro de Venda";
            this.btnCadastroVenda.UseVisualStyleBackColor = false;
            this.btnCadastroVenda.Click += new System.EventHandler(this.btnCadastroVenda_Click);
            this.btnCadastroVenda.MouseEnter += new System.EventHandler(this.btnCadastroVenda_MouseEnter);
            this.btnCadastroVenda.MouseLeave += new System.EventHandler(this.btnCadastroVenda_MouseLeave);
            // 
            // panelCompra
            // 
            this.panelCompra.Controls.Add(this.lblConsultaCompra);
            this.panelCompra.Controls.Add(this.lblCadastroCompra);
            this.panelCompra.Controls.Add(this.picArrowCompra);
            this.panelCompra.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.panelCompra.Location = new System.Drawing.Point(478, 99);
            this.panelCompra.Name = "panelCompra";
            this.panelCompra.Size = new System.Drawing.Size(0, 55);
            this.panelCompra.TabIndex = 45;
            // 
            // lblConsultaCompra
            // 
            this.lblConsultaCompra.AutoSize = true;
            this.lblConsultaCompra.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaCompra.ForeColor = System.Drawing.Color.DarkGray;
            this.lblConsultaCompra.Location = new System.Drawing.Point(61, 1);
            this.lblConsultaCompra.Name = "lblConsultaCompra";
            this.lblConsultaCompra.Size = new System.Drawing.Size(209, 51);
            this.lblConsultaCompra.TabIndex = 21;
            this.lblConsultaCompra.Text = "Consulte suas compras \r\nde animais para ver detalhes da\r\nreposição de animais.";
            this.lblConsultaCompra.Visible = false;
            // 
            // lblCadastroCompra
            // 
            this.lblCadastroCompra.AutoSize = true;
            this.lblCadastroCompra.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroCompra.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCadastroCompra.Location = new System.Drawing.Point(61, 1);
            this.lblCadastroCompra.Name = "lblCadastroCompra";
            this.lblCadastroCompra.Size = new System.Drawing.Size(209, 51);
            this.lblCadastroCompra.TabIndex = 16;
            this.lblCadastroCompra.Text = "Cadastre as compras de animais\r\nque você realizou de outros\r\npecuaristas.";
            this.lblCadastroCompra.Visible = false;
            // 
            // picArrowCompra
            // 
            this.picArrowCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picArrowCompra.BackgroundImage")));
            this.picArrowCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picArrowCompra.Location = new System.Drawing.Point(3, 0);
            this.picArrowCompra.Name = "picArrowCompra";
            this.picArrowCompra.Size = new System.Drawing.Size(52, 52);
            this.picArrowCompra.TabIndex = 22;
            this.picArrowCompra.TabStop = false;
            // 
            // btnConsultaCompra
            // 
            this.btnConsultaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultaCompra.FlatAppearance.BorderSize = 0;
            this.btnConsultaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaCompra.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultaCompra.ForeColor = System.Drawing.Color.White;
            this.btnConsultaCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaCompra.Location = new System.Drawing.Point(267, 99);
            this.btnConsultaCompra.Name = "btnConsultaCompra";
            this.btnConsultaCompra.Size = new System.Drawing.Size(205, 55);
            this.btnConsultaCompra.TabIndex = 44;
            this.btnConsultaCompra.Text = "Consulta de Compra";
            this.btnConsultaCompra.UseVisualStyleBackColor = false;
            this.btnConsultaCompra.Click += new System.EventHandler(this.btnConsultaCompra_Click);
            this.btnConsultaCompra.MouseEnter += new System.EventHandler(this.btnConsultaCompra_MouseEnter);
            this.btnConsultaCompra.MouseLeave += new System.EventHandler(this.btnConsultaCompra_MouseLeave);
            // 
            // btnCadastroCompra
            // 
            this.btnCadastroCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastroCompra.FlatAppearance.BorderSize = 0;
            this.btnCadastroCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCompra.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastroCompra.ForeColor = System.Drawing.Color.White;
            this.btnCadastroCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroCompra.Location = new System.Drawing.Point(56, 99);
            this.btnCadastroCompra.Name = "btnCadastroCompra";
            this.btnCadastroCompra.Size = new System.Drawing.Size(205, 55);
            this.btnCadastroCompra.TabIndex = 43;
            this.btnCadastroCompra.Text = "Cadastro de Compra";
            this.btnCadastroCompra.UseVisualStyleBackColor = false;
            this.btnCadastroCompra.Click += new System.EventHandler(this.btnCadastroCompra_Click);
            this.btnCadastroCompra.MouseEnter += new System.EventHandler(this.btnCadastroCompra_MouseEnter);
            this.btnCadastroCompra.MouseLeave += new System.EventHandler(this.btnCadastroCompra_MouseLeave);
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
            // timerVendaAumenta
            // 
            this.timerVendaAumenta.Interval = 1;
            this.timerVendaAumenta.Tick += new System.EventHandler(this.timerVendaAumenta_Tick);
            // 
            // timerVendaRecolhe
            // 
            this.timerVendaRecolhe.Interval = 1;
            this.timerVendaRecolhe.Tick += new System.EventHandler(this.timerVendaRecolhe_Tick);
            // 
            // controlCompraVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelVenda);
            this.Controls.Add(this.btnConsultaVenda);
            this.Controls.Add(this.btnCadastroVenda);
            this.Controls.Add(this.panelCompra);
            this.Controls.Add(this.btnConsultaCompra);
            this.Controls.Add(this.btnCadastroCompra);
            this.Name = "controlCompraVendas";
            this.Size = new System.Drawing.Size(939, 390);
            this.panelVenda.ResumeLayout(false);
            this.panelVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowVenda)).EndInit();
            this.panelCompra.ResumeLayout(false);
            this.panelCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVenda;
        private System.Windows.Forms.Label lblConsultaVenda;
        private System.Windows.Forms.Label lblCadastroVenda;
        private System.Windows.Forms.PictureBox picArrowVenda;
        private System.Windows.Forms.Button btnConsultaVenda;
        private System.Windows.Forms.Button btnCadastroVenda;
        private System.Windows.Forms.Panel panelCompra;
        private System.Windows.Forms.Label lblConsultaCompra;
        private System.Windows.Forms.Label lblCadastroCompra;
        private System.Windows.Forms.PictureBox picArrowCompra;
        private System.Windows.Forms.Button btnConsultaCompra;
        private System.Windows.Forms.Button btnCadastroCompra;
        private System.Windows.Forms.Timer timerPessoaAumenta;
        private System.Windows.Forms.Timer timerPessoaRecolhe;
        private System.Windows.Forms.Timer timerVendaAumenta;
        private System.Windows.Forms.Timer timerVendaRecolhe;
    }
}
