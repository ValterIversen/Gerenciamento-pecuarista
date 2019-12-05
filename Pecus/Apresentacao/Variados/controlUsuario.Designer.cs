namespace Apresentacao.Variados
{
    partial class controlUsuario
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
            this.btnConsultaUsuario = new System.Windows.Forms.Button();
            this.btnCadastroUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultaUsuario
            // 
            this.btnConsultaUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnConsultaUsuario.FlatAppearance.BorderSize = 0;
            this.btnConsultaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaUsuario.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultaUsuario.ForeColor = System.Drawing.Color.White;
            this.btnConsultaUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaUsuario.Location = new System.Drawing.Point(439, 144);
            this.btnConsultaUsuario.Name = "btnConsultaUsuario";
            this.btnConsultaUsuario.Size = new System.Drawing.Size(205, 55);
            this.btnConsultaUsuario.TabIndex = 32;
            this.btnConsultaUsuario.Text = "Consulta de Usuários";
            this.btnConsultaUsuario.UseVisualStyleBackColor = false;
            this.btnConsultaUsuario.Click += new System.EventHandler(this.BtnConsultaUsuario_Click);
            // 
            // btnCadastroUsuario
            // 
            this.btnCadastroUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(204)))), ((int)(((byte)(54)))));
            this.btnCadastroUsuario.FlatAppearance.BorderSize = 0;
            this.btnCadastroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroUsuario.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastroUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCadastroUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroUsuario.Location = new System.Drawing.Point(186, 144);
            this.btnCadastroUsuario.Name = "btnCadastroUsuario";
            this.btnCadastroUsuario.Size = new System.Drawing.Size(205, 55);
            this.btnCadastroUsuario.TabIndex = 31;
            this.btnCadastroUsuario.Text = "Cadastro de Usuários";
            this.btnCadastroUsuario.UseVisualStyleBackColor = false;
            this.btnCadastroUsuario.Click += new System.EventHandler(this.BtnCadastroUsuario_Click);
            // 
            // controlUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConsultaUsuario);
            this.Controls.Add(this.btnCadastroUsuario);
            this.Name = "controlUsuario";
            this.Size = new System.Drawing.Size(939, 390);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaUsuario;
        private System.Windows.Forms.Button btnCadastroUsuario;
    }
}
