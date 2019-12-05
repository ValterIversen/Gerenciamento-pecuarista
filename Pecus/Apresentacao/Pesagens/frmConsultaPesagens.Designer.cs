﻿namespace Apresentacao.Pesagens
{
    partial class frmConsultaPesagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPesagens));
            this.panelInside = new System.Windows.Forms.Panel();
            this.gpbDatas = new System.Windows.Forms.GroupBox();
            this.dtpData2 = new System.Windows.Forms.DateTimePicker();
            this.dtpData1 = new System.Windows.Forms.DateTimePicker();
            this.lblTraco = new System.Windows.Forms.Label();
            this.gpbAnimal = new System.Windows.Forms.GroupBox();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.gpbDataOpcoes = new System.Windows.Forms.GroupBox();
            this.rbEntre = new System.Windows.Forms.RadioButton();
            this.rbAntes = new System.Windows.Forms.RadioButton();
            this.rbApos = new System.Windows.Forms.RadioButton();
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.rbAnimal = new System.Windows.Forms.RadioButton();
            this.gpbResultados = new System.Windows.Forms.GroupBox();
            this.dgvPesagens = new System.Windows.Forms.DataGridView();
            this.PesagemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesagemData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesagemPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelInside.SuspendLayout();
            this.gpbDatas.SuspendLayout();
            this.gpbAnimal.SuspendLayout();
            this.gpbDataOpcoes.SuspendLayout();
            this.gpbOpcoes.SuspendLayout();
            this.gpbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesagens)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbDatas);
            this.panelInside.Controls.Add(this.gpbAnimal);
            this.panelInside.Controls.Add(this.gpbDataOpcoes);
            this.panelInside.Controls.Add(this.gpbOpcoes);
            this.panelInside.Controls.Add(this.gpbResultados);
            this.panelInside.Controls.Add(this.btnConsultar);
            this.panelInside.Location = new System.Drawing.Point(12, 63);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(735, 422);
            this.panelInside.TabIndex = 15;
            // 
            // gpbDatas
            // 
            this.gpbDatas.Controls.Add(this.dtpData2);
            this.gpbDatas.Controls.Add(this.dtpData1);
            this.gpbDatas.Controls.Add(this.lblTraco);
            this.gpbDatas.Location = new System.Drawing.Point(389, 13);
            this.gpbDatas.Name = "gpbDatas";
            this.gpbDatas.Size = new System.Drawing.Size(261, 56);
            this.gpbDatas.TabIndex = 2;
            this.gpbDatas.TabStop = false;
            // 
            // dtpData2
            // 
            this.dtpData2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData2.Location = new System.Drawing.Point(137, 22);
            this.dtpData2.Name = "dtpData2";
            this.dtpData2.Size = new System.Drawing.Size(105, 23);
            this.dtpData2.TabIndex = 4;
            // 
            // dtpData1
            // 
            this.dtpData1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData1.Location = new System.Drawing.Point(7, 22);
            this.dtpData1.Name = "dtpData1";
            this.dtpData1.Size = new System.Drawing.Size(105, 23);
            this.dtpData1.TabIndex = 3;
            // 
            // lblTraco
            // 
            this.lblTraco.AutoSize = true;
            this.lblTraco.Location = new System.Drawing.Point(118, 25);
            this.lblTraco.Name = "lblTraco";
            this.lblTraco.Size = new System.Drawing.Size(13, 16);
            this.lblTraco.TabIndex = 2;
            this.lblTraco.Text = "-";
            // 
            // gpbAnimal
            // 
            this.gpbAnimal.Controls.Add(this.btnBuscarAnimal);
            this.gpbAnimal.Controls.Add(this.txtAnimal);
            this.gpbAnimal.Controls.Add(this.lblAnimal);
            this.gpbAnimal.Location = new System.Drawing.Point(177, 3);
            this.gpbAnimal.Name = "gpbAnimal";
            this.gpbAnimal.Size = new System.Drawing.Size(389, 77);
            this.gpbAnimal.TabIndex = 1;
            this.gpbAnimal.TabStop = false;
            this.gpbAnimal.Visible = false;
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarAnimal.FlatAppearance.BorderSize = 0;
            this.btnBuscarAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAnimal.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarAnimal.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(190, 22);
            this.btnBuscarAnimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(185, 42);
            this.btnBuscarAnimal.TabIndex = 15;
            this.btnBuscarAnimal.Text = "Buscar Animal";
            this.btnBuscarAnimal.UseVisualStyleBackColor = false;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // txtAnimal
            // 
            this.txtAnimal.Font = new System.Drawing.Font("Microsoft JhengHei", 9F);
            this.txtAnimal.Location = new System.Drawing.Point(99, 32);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.Size = new System.Drawing.Size(85, 23);
            this.txtAnimal.TabIndex = 5;
            this.txtAnimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnimal_KeyPress);
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(8, 35);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(85, 16);
            this.lblAnimal.TabIndex = 4;
            this.lblAnimal.Text = "ID do animal:";
            // 
            // gpbDataOpcoes
            // 
            this.gpbDataOpcoes.Controls.Add(this.rbEntre);
            this.gpbDataOpcoes.Controls.Add(this.rbAntes);
            this.gpbDataOpcoes.Controls.Add(this.rbApos);
            this.gpbDataOpcoes.Location = new System.Drawing.Point(177, 13);
            this.gpbDataOpcoes.Name = "gpbDataOpcoes";
            this.gpbDataOpcoes.Size = new System.Drawing.Size(206, 56);
            this.gpbDataOpcoes.TabIndex = 1;
            this.gpbDataOpcoes.TabStop = false;
            // 
            // rbEntre
            // 
            this.rbEntre.AutoSize = true;
            this.rbEntre.Location = new System.Drawing.Point(139, 24);
            this.rbEntre.Name = "rbEntre";
            this.rbEntre.Size = new System.Drawing.Size(58, 20);
            this.rbEntre.TabIndex = 3;
            this.rbEntre.Text = "Entre";
            this.rbEntre.UseVisualStyleBackColor = true;
            this.rbEntre.CheckedChanged += new System.EventHandler(this.rbEntre_CheckedChanged);
            // 
            // rbAntes
            // 
            this.rbAntes.AutoSize = true;
            this.rbAntes.Location = new System.Drawing.Point(72, 24);
            this.rbAntes.Name = "rbAntes";
            this.rbAntes.Size = new System.Drawing.Size(61, 20);
            this.rbAntes.TabIndex = 2;
            this.rbAntes.Text = "Antes";
            this.rbAntes.UseVisualStyleBackColor = true;
            this.rbAntes.CheckedChanged += new System.EventHandler(this.rbAntes_CheckedChanged);
            // 
            // rbApos
            // 
            this.rbApos.AutoSize = true;
            this.rbApos.Checked = true;
            this.rbApos.Location = new System.Drawing.Point(9, 23);
            this.rbApos.Name = "rbApos";
            this.rbApos.Size = new System.Drawing.Size(57, 20);
            this.rbApos.TabIndex = 1;
            this.rbApos.TabStop = true;
            this.rbApos.Text = "Após";
            this.rbApos.UseVisualStyleBackColor = true;
            this.rbApos.CheckedChanged += new System.EventHandler(this.rbApos_CheckedChanged);
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.rbData);
            this.gpbOpcoes.Controls.Add(this.rbAnimal);
            this.gpbOpcoes.Location = new System.Drawing.Point(12, 13);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(159, 52);
            this.gpbOpcoes.TabIndex = 0;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Opções  de consulta";
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Checked = true;
            this.rbData.Location = new System.Drawing.Point(14, 22);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(54, 20);
            this.rbData.TabIndex = 0;
            this.rbData.TabStop = true;
            this.rbData.Text = "Data";
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.rbData_CheckedChanged);
            // 
            // rbAnimal
            // 
            this.rbAnimal.AutoSize = true;
            this.rbAnimal.Location = new System.Drawing.Point(74, 22);
            this.rbAnimal.Name = "rbAnimal";
            this.rbAnimal.Size = new System.Drawing.Size(67, 20);
            this.rbAnimal.TabIndex = 1;
            this.rbAnimal.Text = "Animal";
            this.rbAnimal.UseVisualStyleBackColor = true;
            this.rbAnimal.CheckedChanged += new System.EventHandler(this.rbAnimal_CheckedChanged);
            // 
            // gpbResultados
            // 
            this.gpbResultados.Controls.Add(this.dgvPesagens);
            this.gpbResultados.Location = new System.Drawing.Point(12, 86);
            this.gpbResultados.Name = "gpbResultados";
            this.gpbResultados.Size = new System.Drawing.Size(709, 250);
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
            this.dgvPesagens.Size = new System.Drawing.Size(693, 225);
            this.dgvPesagens.TabIndex = 0;
            this.dgvPesagens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesagens_CellDoubleClick);
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
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(482, 342);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(239, 68);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.panel4.Controls.Add(this.lblTitulo);
            this.panel4.Controls.Add(this.picExit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(765, 45);
            this.panel4.TabIndex = 14;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(208, 24);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Consulta de Pesagem";
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(722, 3);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(40, 38);
            this.picExit.TabIndex = 4;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseEnter += new System.EventHandler(this.picExit_MouseEnter);
            this.picExit.MouseLeave += new System.EventHandler(this.picExit_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(88)))), ((int)(((byte)(46)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 12);
            this.panel2.TabIndex = 13;
            // 
            // frmConsultaPesagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(765, 496);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConsultaPesagens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaPesagens";
            this.panelInside.ResumeLayout(false);
            this.gpbDatas.ResumeLayout(false);
            this.gpbDatas.PerformLayout();
            this.gpbAnimal.ResumeLayout(false);
            this.gpbAnimal.PerformLayout();
            this.gpbDataOpcoes.ResumeLayout(false);
            this.gpbDataOpcoes.PerformLayout();
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.gpbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesagens)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.GroupBox gpbAnimal;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton rbAnimal;
        private System.Windows.Forms.GroupBox gpbResultados;
        private System.Windows.Forms.DataGridView dgvPesagens;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesagemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesagemData;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesagemPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnimalDescricao;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gpbDatas;
        private System.Windows.Forms.DateTimePicker dtpData2;
        private System.Windows.Forms.DateTimePicker dtpData1;
        private System.Windows.Forms.Label lblTraco;
        private System.Windows.Forms.GroupBox gpbDataOpcoes;
        private System.Windows.Forms.RadioButton rbEntre;
        private System.Windows.Forms.RadioButton rbAntes;
        private System.Windows.Forms.RadioButton rbApos;
        private System.Windows.Forms.Label lblTitulo;
    }
}