namespace Apresentacao.Pesagens
{
    partial class frmCadastroPesagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroPesagens));
            this.panel4 = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.lblKG = new System.Windows.Forms.Label();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.dtpDataPesagem = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.panelInside = new System.Windows.Forms.Panel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.gpbResultados = new System.Windows.Forms.GroupBox();
            this.dgvPesagens = new System.Windows.Forms.DataGridView();
            this.PesagemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesagemData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesagemPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.gpbDados.SuspendLayout();
            this.panelInside.SuspendLayout();
            this.gpbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesagens)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.panel4.Controls.Add(this.lblTitulo);
            this.panel4.Controls.Add(this.picExit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1069, 45);
            this.panel4.TabIndex = 6;
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(1026, 3);
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
            this.panel2.Size = new System.Drawing.Size(1069, 12);
            this.panel2.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(794, 270);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(239, 68);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.lblKG);
            this.gpbDados.Controls.Add(this.btnBuscarAnimal);
            this.gpbDados.Controls.Add(this.txtAnimal);
            this.gpbDados.Controls.Add(this.lblAnimal);
            this.gpbDados.Controls.Add(this.dtpDataPesagem);
            this.gpbDados.Controls.Add(this.lblData);
            this.gpbDados.Controls.Add(this.txtPeso);
            this.gpbDados.Controls.Add(this.lblPeso);
            this.gpbDados.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDados.Location = new System.Drawing.Point(12, 14);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(407, 149);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Cadastro de pesagem";
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.ForeColor = System.Drawing.Color.Blue;
            this.lblKG.Location = new System.Drawing.Point(305, 29);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(31, 16);
            this.lblKG.TabIndex = 16;
            this.lblKG.Text = "*KG";
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarAnimal.FlatAppearance.BorderSize = 0;
            this.btnBuscarAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAnimal.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarAnimal.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(188, 90);
            this.btnBuscarAnimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(185, 42);
            this.btnBuscarAnimal.TabIndex = 3;
            this.btnBuscarAnimal.Text = "Buscar Animal";
            this.btnBuscarAnimal.UseVisualStyleBackColor = false;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // txtAnimal
            // 
            this.txtAnimal.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtAnimal.Location = new System.Drawing.Point(97, 100);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.Size = new System.Drawing.Size(85, 23);
            this.txtAnimal.TabIndex = 2;
            this.txtAnimal.TextChanged += new System.EventHandler(this.txtAnimal_TextChanged);
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(6, 103);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(85, 16);
            this.lblAnimal.TabIndex = 4;
            this.lblAnimal.Text = "ID do animal:";
            // 
            // dtpDataPesagem
            // 
            this.dtpDataPesagem.Location = new System.Drawing.Point(126, 60);
            this.dtpDataPesagem.Name = "dtpDataPesagem";
            this.dtpDataPesagem.Size = new System.Drawing.Size(260, 23);
            this.dtpDataPesagem.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(6, 65);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(114, 16);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data da pesagem:";
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtPeso.Location = new System.Drawing.Point(113, 26);
            this.txtPeso.MaxLength = 10;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(186, 23);
            this.txtPeso.TabIndex = 0;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(6, 29);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(101, 16);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso do animal:";
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.btnRemover);
            this.panelInside.Controls.Add(this.btnAdicionar);
            this.panelInside.Controls.Add(this.gpbResultados);
            this.panelInside.Controls.Add(this.gpbDados);
            this.panelInside.Controls.Add(this.btnCadastrar);
            this.panelInside.Location = new System.Drawing.Point(13, 64);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(1044, 349);
            this.panelInside.TabIndex = 0;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(213, 170);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(185, 42);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover Pesagem";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(21, 170);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(185, 42);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar Pesagem";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // gpbResultados
            // 
            this.gpbResultados.Controls.Add(this.dgvPesagens);
            this.gpbResultados.Location = new System.Drawing.Point(425, 14);
            this.gpbResultados.Name = "gpbResultados";
            this.gpbResultados.Size = new System.Drawing.Size(608, 250);
            this.gpbResultados.TabIndex = 3;
            this.gpbResultados.TabStop = false;
            // 
            // dgvPesagens
            // 
            this.dgvPesagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesagens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PesagemID,
            this.PesagemData,
            this.PesagemPeso,
            this.AnimalID,
            this.AnimalDescricao});
            this.dgvPesagens.Location = new System.Drawing.Point(7, 15);
            this.dgvPesagens.Name = "dgvPesagens";
            this.dgvPesagens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesagens.Size = new System.Drawing.Size(593, 225);
            this.dgvPesagens.TabIndex = 0;
            this.dgvPesagens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPesagens_CellFormatting);
            // 
            // PesagemID
            // 
            this.PesagemID.DataPropertyName = "PesagemID";
            this.PesagemID.HeaderText = "ID";
            this.PesagemID.Name = "PesagemID";
            this.PesagemID.ReadOnly = true;
            // 
            // PesagemData
            // 
            this.PesagemData.DataPropertyName = "PesagemData";
            this.PesagemData.HeaderText = "Data";
            this.PesagemData.Name = "PesagemData";
            this.PesagemData.ReadOnly = true;
            this.PesagemData.Width = 150;
            // 
            // PesagemPeso
            // 
            this.PesagemPeso.DataPropertyName = "PesagemPeso";
            this.PesagemPeso.HeaderText = "Peso";
            this.PesagemPeso.Name = "PesagemPeso";
            this.PesagemPeso.ReadOnly = true;
            // 
            // AnimalID
            // 
            this.AnimalID.DataPropertyName = "Animal.AnimalID";
            this.AnimalID.HeaderText = "ID do Animal";
            this.AnimalID.Name = "AnimalID";
            this.AnimalID.ReadOnly = true;
            // 
            // AnimalDescricao
            // 
            this.AnimalDescricao.DataPropertyName = "Animal.AnimalDescricao";
            this.AnimalDescricao.HeaderText = "Descrição do Animal";
            this.AnimalDescricao.Name = "AnimalDescricao";
            this.AnimalDescricao.ReadOnly = true;
            this.AnimalDescricao.Width = 200;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(210, 24);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Cadastro de Pesagem";
            // 
            // frmCadastroPesagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1069, 424);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCadastroPesagens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroPesagens";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.panelInside.ResumeLayout(false);
            this.gpbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesagens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.DateTimePicker dtpDataPesagem;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Label lblKG;
        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.GroupBox gpbResultados;
        private System.Windows.Forms.DataGridView dgvPesagens;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesagemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesagemData;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesagemPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalDescricao;
        private System.Windows.Forms.Label lblTitulo;
    }
}