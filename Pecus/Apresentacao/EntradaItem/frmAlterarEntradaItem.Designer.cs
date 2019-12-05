namespace Apresentacao.EntradaItem
{
    partial class frmAlterarEntradaItem
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
            System.Windows.Forms.Button btnSalvar;
            System.Windows.Forms.Button btnExcluir;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarEntradaItem));
            this.panelInside = new System.Windows.Forms.Panel();
            this.gpbEstoque = new System.Windows.Forms.GroupBox();
            this.lblItemDescricao = new System.Windows.Forms.Label();
            this.txtItemDescricao = new System.Windows.Forms.RichTextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblDataAtual = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblArmazem = new System.Windows.Forms.Label();
            this.txtArmazem = new System.Windows.Forms.RichTextBox();
            btnSalvar = new System.Windows.Forms.Button();
            btnExcluir = new System.Windows.Forms.Button();
            this.panelInside.SuspendLayout();
            this.gpbEstoque.SuspendLayout();
            this.gpbDados.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalvar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            btnSalvar.ForeColor = System.Drawing.Color.White;
            btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSalvar.Location = new System.Drawing.Point(235, 446);
            btnSalvar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new System.Drawing.Size(239, 68);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = System.Drawing.Color.DarkRed;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExcluir.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            btnExcluir.ForeColor = System.Drawing.Color.White;
            btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnExcluir.Location = new System.Drawing.Point(53, 455);
            btnExcluir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new System.Drawing.Size(148, 50);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(btnExcluir);
            this.panelInside.Controls.Add(this.gpbEstoque);
            this.panelInside.Controls.Add(btnSalvar);
            this.panelInside.Controls.Add(this.gpbDados);
            this.panelInside.Location = new System.Drawing.Point(12, 69);
            this.panelInside.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(514, 525);
            this.panelInside.TabIndex = 0;
            // 
            // gpbEstoque
            // 
            this.gpbEstoque.Controls.Add(this.lblArmazem);
            this.gpbEstoque.Controls.Add(this.txtArmazem);
            this.gpbEstoque.Controls.Add(this.lblItemDescricao);
            this.gpbEstoque.Controls.Add(this.txtItemDescricao);
            this.gpbEstoque.Controls.Add(this.lblItemID);
            this.gpbEstoque.Controls.Add(this.txtItem);
            this.gpbEstoque.Controls.Add(this.txtQuantidade);
            this.gpbEstoque.Controls.Add(this.lblQuantidade);
            this.gpbEstoque.Location = new System.Drawing.Point(47, 172);
            this.gpbEstoque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbEstoque.Name = "gpbEstoque";
            this.gpbEstoque.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbEstoque.Size = new System.Drawing.Size(413, 265);
            this.gpbEstoque.TabIndex = 1;
            this.gpbEstoque.TabStop = false;
            // 
            // lblItemDescricao
            // 
            this.lblItemDescricao.AutoSize = true;
            this.lblItemDescricao.Location = new System.Drawing.Point(17, 70);
            this.lblItemDescricao.Name = "lblItemDescricao";
            this.lblItemDescricao.Size = new System.Drawing.Size(38, 16);
            this.lblItemDescricao.TabIndex = 25;
            this.lblItemDescricao.Text = "Item:";
            // 
            // txtItemDescricao
            // 
            this.txtItemDescricao.Enabled = false;
            this.txtItemDescricao.Location = new System.Drawing.Point(103, 66);
            this.txtItemDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemDescricao.Name = "txtItemDescricao";
            this.txtItemDescricao.Size = new System.Drawing.Size(235, 73);
            this.txtItemDescricao.TabIndex = 1;
            this.txtItemDescricao.Text = "";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(31, 33);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(72, 16);
            this.lblItemID.TabIndex = 23;
            this.lblItemID.Text = "ID do item:";
            // 
            // txtItem
            // 
            this.txtItem.Enabled = false;
            this.txtItem.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtItem.Location = new System.Drawing.Point(149, 30);
            this.txtItem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(128, 23);
            this.txtItem.TabIndex = 0;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtQuantidade.Location = new System.Drawing.Point(137, 226);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtQuantidade.MaxLength = 14;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(158, 23);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantidade_KeyPress);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(35, 230);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(82, 16);
            this.lblQuantidade.TabIndex = 20;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.dtpData);
            this.gpbDados.Controls.Add(this.lblDataAtual);
            this.gpbDados.Controls.Add(this.txtDescricao);
            this.gpbDados.Controls.Add(this.lblDescricao);
            this.gpbDados.Location = new System.Drawing.Point(14, 4);
            this.gpbDados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpbDados.Size = new System.Drawing.Size(486, 161);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Alteração de entrada";
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Location = new System.Drawing.Point(107, 108);
            this.dtpData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(300, 23);
            this.dtpData.TabIndex = 1;
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.AutoSize = true;
            this.lblDataAtual.Location = new System.Drawing.Point(50, 116);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(39, 16);
            this.lblDataAtual.TabIndex = 15;
            this.lblDataAtual.Text = "Data:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(139, 27);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(235, 73);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.Text = "";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(52, 31);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 45);
            this.panel2.TabIndex = 46;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(279, 24);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Alteração de Entrada de Item";
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(496, 5);
            this.picExit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(540, 15);
            this.panel4.TabIndex = 47;
            // 
            // lblArmazem
            // 
            this.lblArmazem.AutoSize = true;
            this.lblArmazem.Location = new System.Drawing.Point(17, 151);
            this.lblArmazem.Name = "lblArmazem";
            this.lblArmazem.Size = new System.Drawing.Size(67, 16);
            this.lblArmazem.TabIndex = 27;
            this.lblArmazem.Text = "Armazém:";
            // 
            // txtArmazem
            // 
            this.txtArmazem.Enabled = false;
            this.txtArmazem.Location = new System.Drawing.Point(103, 147);
            this.txtArmazem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArmazem.Name = "txtArmazem";
            this.txtArmazem.Size = new System.Drawing.Size(235, 73);
            this.txtArmazem.TabIndex = 26;
            this.txtArmazem.Text = "";
            // 
            // frmAlterarEntradaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(540, 604);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAlterarEntradaItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlterarEntradaItem";
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
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.DateTimePicker dtpData;
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