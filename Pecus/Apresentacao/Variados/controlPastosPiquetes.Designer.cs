namespace Apresentacao.Variados
{
    partial class controlPastosPiquetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlPastosPiquetes));
            this.panelPasto = new System.Windows.Forms.Panel();
            this.lblConsultaPasto = new System.Windows.Forms.Label();
            this.lblCadastroPasto = new System.Windows.Forms.Label();
            this.picArrowAnimal = new System.Windows.Forms.PictureBox();
            this.btnConsultaPasto = new System.Windows.Forms.Button();
            this.btnCadastroPasto = new System.Windows.Forms.Button();
            this.timerPastoAumentar = new System.Windows.Forms.Timer(this.components);
            this.timerPastoRecolher = new System.Windows.Forms.Timer(this.components);
            this.panelPasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPasto
            // 
            this.panelPasto.Controls.Add(this.lblConsultaPasto);
            this.panelPasto.Controls.Add(this.lblCadastroPasto);
            this.panelPasto.Controls.Add(this.picArrowAnimal);
            this.panelPasto.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.panelPasto.Location = new System.Drawing.Point(445, 156);
            this.panelPasto.Name = "panelPasto";
            this.panelPasto.Size = new System.Drawing.Size(0, 55);
            this.panelPasto.TabIndex = 33;
            // 
            // lblConsultaPasto
            // 
            this.lblConsultaPasto.AutoSize = true;
            this.lblConsultaPasto.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaPasto.ForeColor = System.Drawing.Color.DarkGray;
            this.lblConsultaPasto.Location = new System.Drawing.Point(77, 1);
            this.lblConsultaPasto.Name = "lblConsultaPasto";
            this.lblConsultaPasto.Size = new System.Drawing.Size(213, 51);
            this.lblConsultaPasto.TabIndex = 21;
            this.lblConsultaPasto.Text = "Realize consultas de pastos para\r\nmonitorar seus bovinos e alterar\r\nos dados de s" +
    "eus pastos.";
            this.lblConsultaPasto.Visible = false;
            // 
            // lblCadastroPasto
            // 
            this.lblCadastroPasto.AutoSize = true;
            this.lblCadastroPasto.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroPasto.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCadastroPasto.Location = new System.Drawing.Point(77, 11);
            this.lblCadastroPasto.Name = "lblCadastroPasto";
            this.lblCadastroPasto.Size = new System.Drawing.Size(254, 34);
            this.lblCadastroPasto.TabIndex = 16;
            this.lblCadastroPasto.Text = "Cadastre seus pastos para monitorar e\r\ngerir os bovinos em diferentes regiões.";
            this.lblCadastroPasto.Visible = false;
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
            // btnConsultaPasto
            // 
            this.btnConsultaPasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultaPasto.FlatAppearance.BorderSize = 0;
            this.btnConsultaPasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaPasto.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultaPasto.ForeColor = System.Drawing.Color.White;
            this.btnConsultaPasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaPasto.Location = new System.Drawing.Point(234, 156);
            this.btnConsultaPasto.Name = "btnConsultaPasto";
            this.btnConsultaPasto.Size = new System.Drawing.Size(205, 55);
            this.btnConsultaPasto.TabIndex = 29;
            this.btnConsultaPasto.Text = "Consulta de Pastos";
            this.btnConsultaPasto.UseVisualStyleBackColor = false;
            this.btnConsultaPasto.Click += new System.EventHandler(this.BtnConsultaPasto_Click);
            this.btnConsultaPasto.MouseEnter += new System.EventHandler(this.BtnConsultaPasto_MouseEnter);
            this.btnConsultaPasto.MouseLeave += new System.EventHandler(this.BtnConsultaPasto_MouseLeave);
            // 
            // btnCadastroPasto
            // 
            this.btnCadastroPasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastroPasto.FlatAppearance.BorderSize = 0;
            this.btnCadastroPasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroPasto.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastroPasto.ForeColor = System.Drawing.Color.White;
            this.btnCadastroPasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroPasto.Location = new System.Drawing.Point(23, 156);
            this.btnCadastroPasto.Name = "btnCadastroPasto";
            this.btnCadastroPasto.Size = new System.Drawing.Size(205, 55);
            this.btnCadastroPasto.TabIndex = 28;
            this.btnCadastroPasto.Text = "Cadastro de Pastos";
            this.btnCadastroPasto.UseVisualStyleBackColor = false;
            this.btnCadastroPasto.Click += new System.EventHandler(this.BtnCadastroPasto_Click);
            this.btnCadastroPasto.MouseEnter += new System.EventHandler(this.BtnCadastroPasto_MouseEnter);
            this.btnCadastroPasto.MouseLeave += new System.EventHandler(this.BtnCadastroPasto_MouseLeave);
            // 
            // timerPastoAumentar
            // 
            this.timerPastoAumentar.Interval = 1;
            this.timerPastoAumentar.Tick += new System.EventHandler(this.TimerPastoAumentar_Tick);
            // 
            // timerPastoRecolher
            // 
            this.timerPastoRecolher.Interval = 1;
            this.timerPastoRecolher.Tick += new System.EventHandler(this.TimerPastoRecolher_Tick);
            // 
            // controlPastosPiquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPasto);
            this.Controls.Add(this.btnConsultaPasto);
            this.Controls.Add(this.btnCadastroPasto);
            this.Name = "controlPastosPiquetes";
            this.Size = new System.Drawing.Size(939, 390);
            this.panelPasto.ResumeLayout(false);
            this.panelPasto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPasto;
        private System.Windows.Forms.Label lblConsultaPasto;
        private System.Windows.Forms.Label lblCadastroPasto;
        private System.Windows.Forms.PictureBox picArrowAnimal;
        private System.Windows.Forms.Button btnConsultaPasto;
        private System.Windows.Forms.Button btnCadastroPasto;
        private System.Windows.Forms.Timer timerPastoAumentar;
        private System.Windows.Forms.Timer timerPastoRecolher;
    }
}
