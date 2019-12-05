namespace Apresentacao.RetiradaItem
{
    partial class frmCadastroRetiradaItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroRetiradaItem));
            this.panelInside = new System.Windows.Forms.Panel();
            this.gpbEstoque = new System.Windows.Forms.GroupBox();
            this.lblItemDescricao = new System.Windows.Forms.Label();
            this.txtItemDescricao = new System.Windows.Forms.RichTextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.btnBuscarEstoque = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.dgvAtual = new System.Windows.Forms.DateTimePicker();
            this.lblDataAtual = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblArmazem = new System.Windows.Forms.Label();
            this.txtArmazem = new System.Windows.Forms.RichTextBox();
            btnCadastrar = new System.Windows.Forms.Button();
            this.panelInside.SuspendLayout();
            this.gpbEstoque.SuspendLayout();
            this.gpbDados.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
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
            btnCadastrar.Location = new System.Drawing.Point(190, 421);
            btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new System.Drawing.Size(239, 68);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbEstoque);
            this.panelInside.Controls.Add(btnCadastrar);
            this.panelInside.Controls.Add(this.gpbDados);
            this.panelInside.Location = new System.Drawing.Point(12, 67);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(443, 501);
            this.panelInside.TabIndex = 48;
            // 
            // gpbEstoque
            // 
            this.gpbEstoque.Controls.Add(this.lblArmazem);
            this.gpbEstoque.Controls.Add(this.txtArmazem);
            this.gpbEstoque.Controls.Add(this.lblItemDescricao);
            this.gpbEstoque.Controls.Add(this.txtItemDescricao);
            this.gpbEstoque.Controls.Add(this.lblItemID);
            this.gpbEstoque.Controls.Add(this.txtItemID);
            this.gpbEstoque.Controls.Add(this.btnBuscarEstoque);
            this.gpbEstoque.Controls.Add(this.txtQuantidade);
            this.gpbEstoque.Controls.Add(this.lblQuantidade);
            this.gpbEstoque.Location = new System.Drawing.Point(40, 140);
            this.gpbEstoque.Name = "gpbEstoque";
            this.gpbEstoque.Size = new System.Drawing.Size(354, 274);
            this.gpbEstoque.TabIndex = 1;
            this.gpbEstoque.TabStop = false;
            // 
            // lblItemDescricao
            // 
            this.lblItemDescricao.AutoSize = true;
            this.lblItemDescricao.Location = new System.Drawing.Point(27, 57);
            this.lblItemDescricao.Name = "lblItemDescricao";
            this.lblItemDescricao.Size = new System.Drawing.Size(38, 16);
            this.lblItemDescricao.TabIndex = 25;
            this.lblItemDescricao.Text = "Item:";
            // 
            // txtItemDescricao
            // 
            this.txtItemDescricao.Enabled = false;
            this.txtItemDescricao.Location = new System.Drawing.Point(88, 54);
            this.txtItemDescricao.Name = "txtItemDescricao";
            this.txtItemDescricao.Size = new System.Drawing.Size(202, 60);
            this.txtItemDescricao.TabIndex = 1;
            this.txtItemDescricao.Text = "";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(27, 27);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(72, 16);
            this.lblItemID.TabIndex = 23;
            this.lblItemID.Text = "ID do item:";
            // 
            // txtItemID
            // 
            this.txtItemID.Enabled = false;
            this.txtItemID.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtItemID.Location = new System.Drawing.Point(128, 24);
            this.txtItemID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(110, 23);
            this.txtItemID.TabIndex = 0;
            // 
            // btnBuscarEstoque
            // 
            this.btnBuscarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarEstoque.FlatAppearance.BorderSize = 0;
            this.btnBuscarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEstoque.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarEstoque.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarEstoque.Location = new System.Drawing.Point(99, 187);
            this.btnBuscarEstoque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarEstoque.Name = "btnBuscarEstoque";
            this.btnBuscarEstoque.Size = new System.Drawing.Size(185, 42);
            this.btnBuscarEstoque.TabIndex = 2;
            this.btnBuscarEstoque.Text = "Buscar Estoque";
            this.btnBuscarEstoque.UseVisualStyleBackColor = false;
            this.btnBuscarEstoque.Click += new System.EventHandler(this.BtnBuscarEstoque_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtQuantidade.Location = new System.Drawing.Point(124, 237);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantidade.MaxLength = 10;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(136, 23);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantidade_KeyPress);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(36, 240);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(82, 16);
            this.lblQuantidade.TabIndex = 20;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.dgvAtual);
            this.gpbDados.Controls.Add(this.lblDataAtual);
            this.gpbDados.Controls.Add(this.txtDescricao);
            this.gpbDados.Controls.Add(this.lblDescricao);
            this.gpbDados.Location = new System.Drawing.Point(12, 3);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(417, 131);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Cadastro de saída";
            // 
            // dgvAtual
            // 
            this.dgvAtual.Enabled = false;
            this.dgvAtual.Location = new System.Drawing.Point(92, 88);
            this.dgvAtual.Name = "dgvAtual";
            this.dgvAtual.Size = new System.Drawing.Size(280, 23);
            this.dgvAtual.TabIndex = 1;
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.AutoSize = true;
            this.lblDataAtual.Location = new System.Drawing.Point(14, 93);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(72, 16);
            this.lblDataAtual.TabIndex = 15;
            this.lblDataAtual.Text = "Data atual:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(119, 22);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(202, 60);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.Text = "";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(45, 25);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 16);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição:";
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
            this.panel2.Size = new System.Drawing.Size(469, 45);
            this.panel2.TabIndex = 46;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(279, 24);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Cadastro de Retirada de Item";
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(426, 4);
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
            this.panel4.Size = new System.Drawing.Size(469, 15);
            this.panel4.TabIndex = 47;
            // 
            // lblArmazem
            // 
            this.lblArmazem.AutoSize = true;
            this.lblArmazem.Location = new System.Drawing.Point(15, 123);
            this.lblArmazem.Name = "lblArmazem";
            this.lblArmazem.Size = new System.Drawing.Size(67, 16);
            this.lblArmazem.TabIndex = 27;
            this.lblArmazem.Text = "Armazém:";
            // 
            // txtArmazem
            // 
            this.txtArmazem.Enabled = false;
            this.txtArmazem.Location = new System.Drawing.Point(88, 120);
            this.txtArmazem.Name = "txtArmazem";
            this.txtArmazem.Size = new System.Drawing.Size(202, 60);
            this.txtArmazem.TabIndex = 26;
            this.txtArmazem.Text = "";
            // 
            // frmCadastroRetiradaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(469, 579);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCadastroRetiradaItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroRetiradaItem";
            this.panelInside.ResumeLayout(false);
            this.gpbEstoque.ResumeLayout(false);
            this.gpbEstoque.PerformLayout();
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.GroupBox gpbEstoque;
        private System.Windows.Forms.Label lblItemDescricao;
        private System.Windows.Forms.RichTextBox txtItemDescricao;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Button btnBuscarEstoque;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.DateTimePicker dgvAtual;
        private System.Windows.Forms.Label lblDataAtual;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblArmazem;
        private System.Windows.Forms.RichTextBox txtArmazem;
    }
}