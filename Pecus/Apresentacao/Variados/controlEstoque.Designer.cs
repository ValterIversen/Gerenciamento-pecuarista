namespace Apresentacao.Variados
{
    partial class controlEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlEstoque));
            this.panelItem = new System.Windows.Forms.Panel();
            this.lblConsultaItem = new System.Windows.Forms.Label();
            this.lblCadastroItem = new System.Windows.Forms.Label();
            this.picArrowItem = new System.Windows.Forms.PictureBox();
            this.panelArmazem = new System.Windows.Forms.Panel();
            this.picArrowArmazem = new System.Windows.Forms.PictureBox();
            this.lblCadastroArmazem = new System.Windows.Forms.Label();
            this.lblConsultaArmazem = new System.Windows.Forms.Label();
            this.btnConsultaArmazem = new System.Windows.Forms.Button();
            this.btnCadastroArmazem = new System.Windows.Forms.Button();
            this.btnConsultaItem = new System.Windows.Forms.Button();
            this.btnCadastroItem = new System.Windows.Forms.Button();
            this.panelTipoitem = new System.Windows.Forms.Panel();
            this.lblConsultaTipoItem = new System.Windows.Forms.Label();
            this.lblCadastroTipoItem = new System.Windows.Forms.Label();
            this.picArrowTipoItem = new System.Windows.Forms.PictureBox();
            this.btnConsultaTipoItem = new System.Windows.Forms.Button();
            this.btnCadastroTipoItem = new System.Windows.Forms.Button();
            this.timerItemAumenta = new System.Windows.Forms.Timer(this.components);
            this.timerItemRecolhe = new System.Windows.Forms.Timer(this.components);
            this.timerTipoItemAumenta = new System.Windows.Forms.Timer(this.components);
            this.timerTipoItemRecolhe = new System.Windows.Forms.Timer(this.components);
            this.timerArmazemAumenta = new System.Windows.Forms.Timer(this.components);
            this.timerArmazemRecolhe = new System.Windows.Forms.Timer(this.components);
            this.timerEstoqueAumenta = new System.Windows.Forms.Timer(this.components);
            this.timerEstoqueRecolhe = new System.Windows.Forms.Timer(this.components);
            this.panelItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowItem)).BeginInit();
            this.panelArmazem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowArmazem)).BeginInit();
            this.panelTipoitem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowTipoItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelItem
            // 
            this.panelItem.Controls.Add(this.lblConsultaItem);
            this.panelItem.Controls.Add(this.lblCadastroItem);
            this.panelItem.Controls.Add(this.picArrowItem);
            this.panelItem.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.panelItem.Location = new System.Drawing.Point(442, 72);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(0, 55);
            this.panelItem.TabIndex = 36;
            // 
            // lblConsultaItem
            // 
            this.lblConsultaItem.AutoSize = true;
            this.lblConsultaItem.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaItem.ForeColor = System.Drawing.Color.DarkGray;
            this.lblConsultaItem.Location = new System.Drawing.Point(61, 9);
            this.lblConsultaItem.Name = "lblConsultaItem";
            this.lblConsultaItem.Size = new System.Drawing.Size(228, 34);
            this.lblConsultaItem.TabIndex = 21;
            this.lblConsultaItem.Text = "Consulte seus itens para gerenciar \r\nseus armazéns, entradas e saídas.";
            this.lblConsultaItem.Visible = false;
            // 
            // lblCadastroItem
            // 
            this.lblCadastroItem.AutoSize = true;
            this.lblCadastroItem.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroItem.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCadastroItem.Location = new System.Drawing.Point(61, 0);
            this.lblCadastroItem.Name = "lblCadastroItem";
            this.lblCadastroItem.Size = new System.Drawing.Size(223, 51);
            this.lblCadastroItem.TabIndex = 16;
            this.lblCadastroItem.Text = "Cadastre recursos e/ou itens para \r\ngerenciar as entradas e saídas de \r\nrecursos " +
    "dos seus armazéns.\r\n";
            this.lblCadastroItem.Visible = false;
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
            // panelArmazem
            // 
            this.panelArmazem.Controls.Add(this.picArrowArmazem);
            this.panelArmazem.Controls.Add(this.lblCadastroArmazem);
            this.panelArmazem.Controls.Add(this.lblConsultaArmazem);
            this.panelArmazem.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.panelArmazem.Location = new System.Drawing.Point(442, 251);
            this.panelArmazem.Name = "panelArmazem";
            this.panelArmazem.Size = new System.Drawing.Size(0, 55);
            this.panelArmazem.TabIndex = 35;
            // 
            // picArrowArmazem
            // 
            this.picArrowArmazem.BackgroundImage = global::Apresentacao.Properties.Resources.arrow_info;
            this.picArrowArmazem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picArrowArmazem.Location = new System.Drawing.Point(3, 0);
            this.picArrowArmazem.Name = "picArrowArmazem";
            this.picArrowArmazem.Size = new System.Drawing.Size(52, 52);
            this.picArrowArmazem.TabIndex = 23;
            this.picArrowArmazem.TabStop = false;
            // 
            // lblCadastroArmazem
            // 
            this.lblCadastroArmazem.AutoSize = true;
            this.lblCadastroArmazem.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCadastroArmazem.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCadastroArmazem.Location = new System.Drawing.Point(61, 9);
            this.lblCadastroArmazem.Name = "lblCadastroArmazem";
            this.lblCadastroArmazem.Size = new System.Drawing.Size(231, 34);
            this.lblCadastroArmazem.TabIndex = 17;
            this.lblCadastroArmazem.Text = "Cadastre armazéns como forma de \r\ngerenciar estoques como barracões.";
            this.lblCadastroArmazem.Visible = false;
            // 
            // lblConsultaArmazem
            // 
            this.lblConsultaArmazem.AutoSize = true;
            this.lblConsultaArmazem.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblConsultaArmazem.ForeColor = System.Drawing.Color.DarkGray;
            this.lblConsultaArmazem.Location = new System.Drawing.Point(61, 9);
            this.lblConsultaArmazem.Name = "lblConsultaArmazem";
            this.lblConsultaArmazem.Size = new System.Drawing.Size(241, 34);
            this.lblConsultaArmazem.TabIndex = 20;
            this.lblConsultaArmazem.Text = "Consulte seu armazéns com todos os\r\nitens estocados, entradas e saídas.";
            this.lblConsultaArmazem.Visible = false;
            // 
            // btnConsultaArmazem
            // 
            this.btnConsultaArmazem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultaArmazem.FlatAppearance.BorderSize = 0;
            this.btnConsultaArmazem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaArmazem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultaArmazem.ForeColor = System.Drawing.Color.White;
            this.btnConsultaArmazem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaArmazem.Location = new System.Drawing.Point(231, 251);
            this.btnConsultaArmazem.Name = "btnConsultaArmazem";
            this.btnConsultaArmazem.Size = new System.Drawing.Size(205, 55);
            this.btnConsultaArmazem.TabIndex = 31;
            this.btnConsultaArmazem.Text = "Consulta de Armazéns";
            this.btnConsultaArmazem.UseVisualStyleBackColor = false;
            this.btnConsultaArmazem.Click += new System.EventHandler(this.BtnConsultaArmazem_Click);
            this.btnConsultaArmazem.MouseEnter += new System.EventHandler(this.BtnConsultaArmazem_MouseEnter);
            this.btnConsultaArmazem.MouseLeave += new System.EventHandler(this.BtnConsultaArmazem_MouseLeave);
            // 
            // btnCadastroArmazem
            // 
            this.btnCadastroArmazem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastroArmazem.FlatAppearance.BorderSize = 0;
            this.btnCadastroArmazem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroArmazem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastroArmazem.ForeColor = System.Drawing.Color.White;
            this.btnCadastroArmazem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroArmazem.Location = new System.Drawing.Point(20, 251);
            this.btnCadastroArmazem.Name = "btnCadastroArmazem";
            this.btnCadastroArmazem.Size = new System.Drawing.Size(205, 55);
            this.btnCadastroArmazem.TabIndex = 30;
            this.btnCadastroArmazem.Text = "Cadastro de Armazéns";
            this.btnCadastroArmazem.UseVisualStyleBackColor = false;
            this.btnCadastroArmazem.Click += new System.EventHandler(this.BtnCadastroArmazem_Click);
            this.btnCadastroArmazem.MouseEnter += new System.EventHandler(this.BtnCadastroArmazem_MouseEnter);
            this.btnCadastroArmazem.MouseLeave += new System.EventHandler(this.BtnCadastroArmazem_MouseLeave);
            // 
            // btnConsultaItem
            // 
            this.btnConsultaItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultaItem.FlatAppearance.BorderSize = 0;
            this.btnConsultaItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultaItem.ForeColor = System.Drawing.Color.White;
            this.btnConsultaItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaItem.Location = new System.Drawing.Point(231, 72);
            this.btnConsultaItem.Name = "btnConsultaItem";
            this.btnConsultaItem.Size = new System.Drawing.Size(205, 55);
            this.btnConsultaItem.TabIndex = 29;
            this.btnConsultaItem.Text = "Consulta de Itens";
            this.btnConsultaItem.UseVisualStyleBackColor = false;
            this.btnConsultaItem.Click += new System.EventHandler(this.BtnConsultaItem_Click);
            this.btnConsultaItem.MouseEnter += new System.EventHandler(this.BtnConsultaItem_MouseEnter);
            this.btnConsultaItem.MouseLeave += new System.EventHandler(this.BtnConsultaItem_MouseLeave);
            // 
            // btnCadastroItem
            // 
            this.btnCadastroItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastroItem.FlatAppearance.BorderSize = 0;
            this.btnCadastroItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastroItem.ForeColor = System.Drawing.Color.White;
            this.btnCadastroItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroItem.Location = new System.Drawing.Point(20, 72);
            this.btnCadastroItem.Name = "btnCadastroItem";
            this.btnCadastroItem.Size = new System.Drawing.Size(205, 55);
            this.btnCadastroItem.TabIndex = 28;
            this.btnCadastroItem.Text = "Cadastro de Itens";
            this.btnCadastroItem.UseVisualStyleBackColor = false;
            this.btnCadastroItem.Click += new System.EventHandler(this.BtnCadastroItem_Click);
            this.btnCadastroItem.MouseEnter += new System.EventHandler(this.BtnCadastroItem_MouseEnter);
            this.btnCadastroItem.MouseLeave += new System.EventHandler(this.BtnCadastroItem_MouseLeave);
            // 
            // panelTipoitem
            // 
            this.panelTipoitem.Controls.Add(this.lblConsultaTipoItem);
            this.panelTipoitem.Controls.Add(this.lblCadastroTipoItem);
            this.panelTipoitem.Controls.Add(this.picArrowTipoItem);
            this.panelTipoitem.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.panelTipoitem.Location = new System.Drawing.Point(442, 163);
            this.panelTipoitem.Name = "panelTipoitem";
            this.panelTipoitem.Size = new System.Drawing.Size(0, 55);
            this.panelTipoitem.TabIndex = 39;
            // 
            // lblConsultaTipoItem
            // 
            this.lblConsultaTipoItem.AutoSize = true;
            this.lblConsultaTipoItem.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaTipoItem.ForeColor = System.Drawing.Color.DarkGray;
            this.lblConsultaTipoItem.Location = new System.Drawing.Point(67, 9);
            this.lblConsultaTipoItem.Name = "lblConsultaTipoItem";
            this.lblConsultaTipoItem.Size = new System.Drawing.Size(222, 34);
            this.lblConsultaTipoItem.TabIndex = 21;
            this.lblConsultaTipoItem.Text = "Consulte seus tipos de itens para \r\nclassificar melhor os seus itens.";
            this.lblConsultaTipoItem.Visible = false;
            // 
            // lblCadastroTipoItem
            // 
            this.lblCadastroTipoItem.AutoSize = true;
            this.lblCadastroTipoItem.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroTipoItem.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCadastroTipoItem.Location = new System.Drawing.Point(61, 9);
            this.lblCadastroTipoItem.Name = "lblCadastroTipoItem";
            this.lblCadastroTipoItem.Size = new System.Drawing.Size(245, 34);
            this.lblCadastroTipoItem.TabIndex = 16;
            this.lblCadastroTipoItem.Text = "Cadastre tipos de itens para classifcar\r\nseus itens.\r\n";
            this.lblCadastroTipoItem.Visible = false;
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
            // btnConsultaTipoItem
            // 
            this.btnConsultaTipoItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultaTipoItem.FlatAppearance.BorderSize = 0;
            this.btnConsultaTipoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaTipoItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultaTipoItem.ForeColor = System.Drawing.Color.White;
            this.btnConsultaTipoItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaTipoItem.Location = new System.Drawing.Point(231, 163);
            this.btnConsultaTipoItem.Name = "btnConsultaTipoItem";
            this.btnConsultaTipoItem.Size = new System.Drawing.Size(205, 55);
            this.btnConsultaTipoItem.TabIndex = 38;
            this.btnConsultaTipoItem.Text = "Consulta de Tipos de Item";
            this.btnConsultaTipoItem.UseVisualStyleBackColor = false;
            this.btnConsultaTipoItem.Click += new System.EventHandler(this.BtnConsultaTipoItem_Click);
            this.btnConsultaTipoItem.MouseEnter += new System.EventHandler(this.BtnConsultaTipoItem_MouseEnter);
            this.btnConsultaTipoItem.MouseLeave += new System.EventHandler(this.BtnConsultaTipoItem_MouseLeave);
            // 
            // btnCadastroTipoItem
            // 
            this.btnCadastroTipoItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastroTipoItem.FlatAppearance.BorderSize = 0;
            this.btnCadastroTipoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroTipoItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastroTipoItem.ForeColor = System.Drawing.Color.White;
            this.btnCadastroTipoItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroTipoItem.Location = new System.Drawing.Point(20, 163);
            this.btnCadastroTipoItem.Name = "btnCadastroTipoItem";
            this.btnCadastroTipoItem.Size = new System.Drawing.Size(205, 55);
            this.btnCadastroTipoItem.TabIndex = 37;
            this.btnCadastroTipoItem.Text = "Cadastro de Tipos de Item";
            this.btnCadastroTipoItem.UseVisualStyleBackColor = false;
            this.btnCadastroTipoItem.Click += new System.EventHandler(this.BtnCadastroTipoItem_Click);
            this.btnCadastroTipoItem.MouseEnter += new System.EventHandler(this.BtnCadastroTipoItem_MouseEnter);
            this.btnCadastroTipoItem.MouseLeave += new System.EventHandler(this.BtnCadastroTipoItem_MouseLeave);
            // 
            // timerItemAumenta
            // 
            this.timerItemAumenta.Interval = 1;
            this.timerItemAumenta.Tick += new System.EventHandler(this.TimerItemAumenta_Tick);
            // 
            // timerItemRecolhe
            // 
            this.timerItemRecolhe.Interval = 1;
            this.timerItemRecolhe.Tick += new System.EventHandler(this.TimerItemRecolhe_Tick);
            // 
            // timerTipoItemAumenta
            // 
            this.timerTipoItemAumenta.Interval = 1;
            this.timerTipoItemAumenta.Tick += new System.EventHandler(this.TimerTipoItemAumenta_Tick);
            // 
            // timerTipoItemRecolhe
            // 
            this.timerTipoItemRecolhe.Interval = 1;
            this.timerTipoItemRecolhe.Tick += new System.EventHandler(this.TimerTipoItemRecolhe_Tick);
            // 
            // timerArmazemAumenta
            // 
            this.timerArmazemAumenta.Interval = 1;
            this.timerArmazemAumenta.Tick += new System.EventHandler(this.TimerArmazemAumenta_Tick);
            // 
            // timerArmazemRecolhe
            // 
            this.timerArmazemRecolhe.Interval = 1;
            this.timerArmazemRecolhe.Tick += new System.EventHandler(this.TimerArmazemRecolhe_Tick);
            // 
            // controlEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTipoitem);
            this.Controls.Add(this.panelItem);
            this.Controls.Add(this.btnConsultaTipoItem);
            this.Controls.Add(this.btnCadastroTipoItem);
            this.Controls.Add(this.panelArmazem);
            this.Controls.Add(this.btnConsultaArmazem);
            this.Controls.Add(this.btnCadastroArmazem);
            this.Controls.Add(this.btnConsultaItem);
            this.Controls.Add(this.btnCadastroItem);
            this.Name = "controlEstoque";
            this.Size = new System.Drawing.Size(939, 390);
            this.panelItem.ResumeLayout(false);
            this.panelItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowItem)).EndInit();
            this.panelArmazem.ResumeLayout(false);
            this.panelArmazem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowArmazem)).EndInit();
            this.panelTipoitem.ResumeLayout(false);
            this.panelTipoitem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowTipoItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.Label lblConsultaItem;
        private System.Windows.Forms.Label lblCadastroItem;
        private System.Windows.Forms.PictureBox picArrowItem;
        private System.Windows.Forms.Panel panelArmazem;
        private System.Windows.Forms.PictureBox picArrowArmazem;
        private System.Windows.Forms.Label lblCadastroArmazem;
        private System.Windows.Forms.Label lblConsultaArmazem;
        private System.Windows.Forms.Button btnConsultaArmazem;
        private System.Windows.Forms.Button btnCadastroArmazem;
        private System.Windows.Forms.Button btnConsultaItem;
        private System.Windows.Forms.Button btnCadastroItem;
        private System.Windows.Forms.Panel panelTipoitem;
        private System.Windows.Forms.Label lblConsultaTipoItem;
        private System.Windows.Forms.Label lblCadastroTipoItem;
        private System.Windows.Forms.PictureBox picArrowTipoItem;
        private System.Windows.Forms.Button btnConsultaTipoItem;
        private System.Windows.Forms.Button btnCadastroTipoItem;
        private System.Windows.Forms.Timer timerItemAumenta;
        private System.Windows.Forms.Timer timerItemRecolhe;
        private System.Windows.Forms.Timer timerTipoItemAumenta;
        private System.Windows.Forms.Timer timerTipoItemRecolhe;
        private System.Windows.Forms.Timer timerArmazemAumenta;
        private System.Windows.Forms.Timer timerArmazemRecolhe;
        private System.Windows.Forms.Timer timerEstoqueAumenta;
        private System.Windows.Forms.Timer timerEstoqueRecolhe;
    }
}
