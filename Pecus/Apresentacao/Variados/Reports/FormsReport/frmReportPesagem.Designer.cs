namespace Apresentacao.Variados.Reports.FormsReport
{
    partial class frmReportPesagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportPesagem));
            this.panelInside = new System.Windows.Forms.Panel();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.gpbDatas = new System.Windows.Forms.GroupBox();
            this.dtpData2 = new System.Windows.Forms.DateTimePicker();
            this.dtpData1 = new System.Windows.Forms.DateTimePicker();
            this.lblTraco = new System.Windows.Forms.Label();
            this.gpbDataOpcoes = new System.Windows.Forms.GroupBox();
            this.rbEntre = new System.Windows.Forms.RadioButton();
            this.rbAntes = new System.Windows.Forms.RadioButton();
            this.rbApos = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelInside.SuspendLayout();
            this.gpbDatas.SuspendLayout();
            this.gpbDataOpcoes.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInside
            // 
            this.panelInside.BackColor = System.Drawing.SystemColors.Control;
            this.panelInside.Controls.Add(this.btnRelatorio);
            this.panelInside.Controls.Add(this.gpbDatas);
            this.panelInside.Controls.Add(this.gpbDataOpcoes);
            this.panelInside.Location = new System.Drawing.Point(12, 63);
            this.panelInside.Name = "panelInside";
            this.panelInside.Size = new System.Drawing.Size(500, 160);
            this.panelInside.TabIndex = 18;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(119, 77);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(239, 68);
            this.btnRelatorio.TabIndex = 4;
            this.btnRelatorio.Text = "Criar relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // gpbDatas
            // 
            this.gpbDatas.Controls.Add(this.dtpData2);
            this.gpbDatas.Controls.Add(this.dtpData1);
            this.gpbDatas.Controls.Add(this.lblTraco);
            this.gpbDatas.Location = new System.Drawing.Point(227, 13);
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
            // gpbDataOpcoes
            // 
            this.gpbDataOpcoes.Controls.Add(this.rbEntre);
            this.gpbDataOpcoes.Controls.Add(this.rbAntes);
            this.gpbDataOpcoes.Controls.Add(this.rbApos);
            this.gpbDataOpcoes.Location = new System.Drawing.Point(15, 13);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.panel4.Controls.Add(this.lblTitulo);
            this.panel4.Controls.Add(this.picExit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(525, 45);
            this.panel4.TabIndex = 17;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(211, 24);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Relatório de Pesagem";
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Location = new System.Drawing.Point(482, 3);
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
            this.panel2.Size = new System.Drawing.Size(525, 12);
            this.panel2.TabIndex = 16;
            // 
            // frmReportPesagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(525, 234);
            this.Controls.Add(this.panelInside);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReportPesagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportPesagem";
            this.panelInside.ResumeLayout(false);
            this.gpbDatas.ResumeLayout(false);
            this.gpbDatas.PerformLayout();
            this.gpbDataOpcoes.ResumeLayout(false);
            this.gpbDataOpcoes.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInside;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.GroupBox gpbDatas;
        private System.Windows.Forms.DateTimePicker dtpData2;
        private System.Windows.Forms.DateTimePicker dtpData1;
        private System.Windows.Forms.Label lblTraco;
        private System.Windows.Forms.GroupBox gpbDataOpcoes;
        private System.Windows.Forms.RadioButton rbEntre;
        private System.Windows.Forms.RadioButton rbAntes;
        private System.Windows.Forms.RadioButton rbApos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel2;
    }
}