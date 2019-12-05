namespace Apresentacao.Variados.Reports.FormsReport
{
    partial class frmReportVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportVenda));
            this.panelInside = new System.Windows.Forms.Panel();
            this.gpbUsuario = new System.Windows.Forms.GroupBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gpbPessoa = new System.Windows.Forms.GroupBox();
            this.btnBuscarPessoa = new System.Windows.Forms.Button();
            this.txtPessoa = new System.Windows.Forms.TextBox();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.gpbDatas = new System.Windows.Forms.GroupBox();
            this.dtpData2 = new System.Windows.Forms.DateTimePicker();
            this.dtpData1 = new System.Windows.Forms.DateTimePicker();
            this.lblTraco = new System.Windows.Forms.Label();
            this.gpbDataOpcoes = new System.Windows.Forms.GroupBox();
            this.rbEntre = new System.Windows.Forms.RadioButton();
            this.rbAntes = new System.Windows.Forms.RadioButton();
            this.rbApos = new System.Windows.Forms.RadioButton();
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbPessoa = new System.Windows.Forms.RadioButton();
            this.rbUsuario = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelInside.SuspendLayout();
            this.gpbUsuario.SuspendLayout();
            this.gpbPessoa.SuspendLayout();
            this.gpbDatas.SuspendLayout();
            this.gpbDataOpcoes.SuspendLayout();
            this.gpbOpcoes.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.gpbUsuario);
            this.panelInside.Controls.Add(this.gpbPessoa);
            this.panelInside.Controls.Add(this.btnRelatorio);
            this.panelInside.Controls.Add(this.gpbDatas);
            this.panelInside.Controls.Add(this.gpbDataOpcoes);
            this.panelInside.Controls.Add(this.gpbOpcoes);
            this.panelInside.Location = new System.Drawing.Point(12, 67);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(761, 189);
            this.panelInside.TabIndex = 50;
            // 
            // gpbUsuario
            // 
            this.gpbUsuario.Controls.Add(this.btnBuscarUsuario);
            this.gpbUsuario.Controls.Add(this.txtUsuario);
            this.gpbUsuario.Controls.Add(this.lblUsuario);
            this.gpbUsuario.Location = new System.Drawing.Point(268, 17);
            this.gpbUsuario.Name = "gpbUsuario";
            this.gpbUsuario.Size = new System.Drawing.Size(378, 73);
            this.gpbUsuario.TabIndex = 6;
            this.gpbUsuario.TabStop = false;
            this.gpbUsuario.Visible = false;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarUsuario.FlatAppearance.BorderSize = 0;
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnBuscarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(187, 19);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(165, 42);
            this.btnBuscarUsuario.TabIndex = 15;
            this.btnBuscarUsuario.Text = "Buscar Usuário";
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(72, 29);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(109, 23);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(9, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 16);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário:";
            // 
            // gpbPessoa
            // 
            this.gpbPessoa.Controls.Add(this.btnBuscarPessoa);
            this.gpbPessoa.Controls.Add(this.txtPessoa);
            this.gpbPessoa.Controls.Add(this.lblPessoa);
            this.gpbPessoa.Location = new System.Drawing.Point(268, 17);
            this.gpbPessoa.Name = "gpbPessoa";
            this.gpbPessoa.Size = new System.Drawing.Size(378, 73);
            this.gpbPessoa.TabIndex = 5;
            this.gpbPessoa.TabStop = false;
            this.gpbPessoa.Visible = false;
            // 
            // btnBuscarPessoa
            // 
            this.btnBuscarPessoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.btnBuscarPessoa.FlatAppearance.BorderSize = 0;
            this.btnBuscarPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPessoa.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPessoa.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPessoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPessoa.Location = new System.Drawing.Point(187, 19);
            this.btnBuscarPessoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarPessoa.Name = "btnBuscarPessoa";
            this.btnBuscarPessoa.Size = new System.Drawing.Size(165, 42);
            this.btnBuscarPessoa.TabIndex = 15;
            this.btnBuscarPessoa.Text = "Buscar Pessoa";
            this.btnBuscarPessoa.UseVisualStyleBackColor = false;
            this.btnBuscarPessoa.Click += new System.EventHandler(this.btnBuscarPessoa_Click);
            // 
            // txtPessoa
            // 
            this.txtPessoa.Enabled = false;
            this.txtPessoa.Location = new System.Drawing.Point(72, 29);
            this.txtPessoa.Name = "txtPessoa";
            this.txtPessoa.Size = new System.Drawing.Size(109, 23);
            this.txtPessoa.TabIndex = 1;
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Location = new System.Drawing.Point(14, 32);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(53, 16);
            this.lblPessoa.TabIndex = 0;
            this.lblPessoa.Text = "Pessoa:";
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(268, 107);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(239, 68);
            this.btnRelatorio.TabIndex = 3;
            this.btnRelatorio.Text = "Criar relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // gpbDatas
            // 
            this.gpbDatas.Controls.Add(this.dtpData2);
            this.gpbDatas.Controls.Add(this.dtpData1);
            this.gpbDatas.Controls.Add(this.lblTraco);
            this.gpbDatas.Location = new System.Drawing.Point(480, 27);
            this.gpbDatas.Name = "gpbDatas";
            this.gpbDatas.Size = new System.Drawing.Size(261, 56);
            this.gpbDatas.TabIndex = 2;
            this.gpbDatas.TabStop = false;
            // 
            // dtpData2
            // 
            this.dtpData2.Enabled = false;
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
            // gpbDataOpcoes
            // 
            this.gpbDataOpcoes.Controls.Add(this.rbEntre);
            this.gpbDataOpcoes.Controls.Add(this.rbAntes);
            this.gpbDataOpcoes.Controls.Add(this.rbApos);
            this.gpbDataOpcoes.Location = new System.Drawing.Point(268, 27);
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
            this.rbEntre.TabIndex = 0;
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
            this.rbAntes.TabIndex = 3;
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
            this.rbApos.TabIndex = 0;
            this.rbApos.TabStop = true;
            this.rbApos.Text = "Após";
            this.rbApos.UseVisualStyleBackColor = true;
            this.rbApos.CheckedChanged += new System.EventHandler(this.rbApos_CheckedChanged);
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.rbPessoa);
            this.gpbOpcoes.Controls.Add(this.rbUsuario);
            this.gpbOpcoes.Controls.Add(this.rbData);
            this.gpbOpcoes.Location = new System.Drawing.Point(12, 15);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(250, 76);
            this.gpbOpcoes.TabIndex = 0;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Opções  de consulta";
            // 
            // rbPessoa
            // 
            this.rbPessoa.AutoSize = true;
            this.rbPessoa.Location = new System.Drawing.Point(154, 33);
            this.rbPessoa.Name = "rbPessoa";
            this.rbPessoa.Size = new System.Drawing.Size(68, 20);
            this.rbPessoa.TabIndex = 2;
            this.rbPessoa.Text = "Pessoa";
            this.rbPessoa.UseVisualStyleBackColor = true;
            this.rbPessoa.CheckedChanged += new System.EventHandler(this.rbPessoa_CheckedChanged);
            // 
            // rbUsuario
            // 
            this.rbUsuario.AutoSize = true;
            this.rbUsuario.Location = new System.Drawing.Point(76, 33);
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.Size = new System.Drawing.Size(72, 20);
            this.rbUsuario.TabIndex = 3;
            this.rbUsuario.Text = "Usuário";
            this.rbUsuario.UseVisualStyleBackColor = true;
            this.rbUsuario.CheckedChanged += new System.EventHandler(this.rbUsuario_CheckedChanged);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Checked = true;
            this.rbData.Location = new System.Drawing.Point(16, 33);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(54, 20);
            this.rbData.TabIndex = 0;
            this.rbData.TabStop = true;
            this.rbData.Text = "Data";
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.rbData_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.panel4.Controls.Add(this.lblTitulo);
            this.panel4.Controls.Add(this.picExit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 15);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(785, 45);
            this.panel4.TabIndex = 49;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(195, 24);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Relatório de Vendas";
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(742, 4);
            this.picExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 15);
            this.panel2.TabIndex = 48;
            // 
            // frmReportVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(785, 265);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReportVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportVenda";
            this.panelInside.ResumeLayout(false);
            this.gpbUsuario.ResumeLayout(false);
            this.gpbUsuario.PerformLayout();
            this.gpbPessoa.ResumeLayout(false);
            this.gpbPessoa.PerformLayout();
            this.gpbDatas.ResumeLayout(false);
            this.gpbDatas.PerformLayout();
            this.gpbDataOpcoes.ResumeLayout(false);
            this.gpbDataOpcoes.PerformLayout();
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.GroupBox gpbUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gpbPessoa;
        private System.Windows.Forms.Button btnBuscarPessoa;
        private System.Windows.Forms.TextBox txtPessoa;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.GroupBox gpbDatas;
        private System.Windows.Forms.DateTimePicker dtpData2;
        private System.Windows.Forms.DateTimePicker dtpData1;
        private System.Windows.Forms.Label lblTraco;
        private System.Windows.Forms.GroupBox gpbDataOpcoes;
        private System.Windows.Forms.RadioButton rbEntre;
        private System.Windows.Forms.RadioButton rbAntes;
        private System.Windows.Forms.RadioButton rbApos;
        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.RadioButton rbPessoa;
        private System.Windows.Forms.RadioButton rbUsuario;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel2;
    }
}