using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using Negocios;
using ObjetoTransferencia;

namespace Apresentacao.Usuario
{
    public partial class frmAlteracaoUsuario : Form
    {
        private ObjetoTransferencia.Usuario usuario = new ObjetoTransferencia.Usuario();
        UsuarioNegocios usuarioNegocios = new UsuarioNegocios();

        public frmAlteracaoUsuario(int ID)
        {
            InitializeComponent();
            TipoUsuarioNegocios tipoUsuarioNegocios = new TipoUsuarioNegocios();
            TipoUsuarioCollection tipoUsuarioCollection = new TipoUsuarioCollection();

            tipoUsuarioCollection = tipoUsuarioNegocios.ConsultarTodos();

            cbbTipoUsuario.DataSource = tipoUsuarioCollection;
            cbbTipoUsuario.DisplayMember = "TipoUsuarioDescricao";
            cbbTipoUsuario.ValueMember = "TipoUsuarioID";
            cbbTipoUsuario.Update();

            usuario.UsuarioID = ID; this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

        );

        private void PicExit_MouseEnter(object sender, EventArgs e)
        {
            picExit.BackgroundImage = Apresentacao.Properties.Resources.exit_hover;
        }

        private void PicExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.BackgroundImage = Apresentacao.Properties.Resources.exit;
        }

        private void PicExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor, informe o Login do usuário.", "Preencha o campo de Login");
            }
            else if (txtNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor, informe o Nome do usuário.", "Preencha o campo de Nome");
            }
            else if (txtSenha.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor, informe o Senha do usuário.", "Preencha o campo de Senha");
            }
            else if (txtConfirmeSenha.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor, Confirme a Senha do usuário.", "Preencha o campo de Confirmação de Senha");
            }
            else if (txtSenha.Text != txtConfirmeSenha.Text)
            {
                MessageBox.Show("A Senha e a Confirmação de senha não são iguais.", "Senha e Confirmação de Senha incorretas");
            }
            else if (cbbTipoUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione o Tipo de Usuário.", "Selecione o Tipo de Usuário");
            }
            else
            {
                try
                {
                    Variados.Criptografia criptografia = new Variados.Criptografia();
                    usuario.UsuarioLogin = txtLogin.Text.Trim();
                    usuario.UsuarioNome = txtNome.Text.Trim();
                    usuario.UsuarioSenha = criptografia.getMD5Hash(txtSenha.Text.Trim());
                    usuario.UsuarioAtivo = ckAtivo.Checked;
                    usuario.TipoUsuario.TipoUsuarioID = Convert.ToInt32(cbbTipoUsuario.SelectedValue);
                    usuarioNegocios.Alterar(usuario);

                    MessageBox.Show("Usuário de ID " + usuario.UsuarioID + " alterado com sucesso!", "Alteração realizada com sucesso!");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro durante a alteração, tente novamente.\nCaso o erro persista, consulte seu suporte.\nErro: " + ex.Message, "Alteração não realizada.");
                }

            }

        }
        private void FrmAlteracaoUsuario_Load(object sender, EventArgs e)
        {
            usuario = usuarioNegocios.ConsultaPorID(usuario.UsuarioID);

            txtID.Text = usuario.UsuarioID.ToString();
            txtLogin.Text = usuario.UsuarioLogin;
            txtNome.Text = usuario.UsuarioNome;
            txtSenha.Text = usuario.UsuarioSenha;
            txtConfirmeSenha.Text = usuario.UsuarioSenha;
            cbbTipoUsuario.SelectedValue = usuario.TipoUsuario.TipoUsuarioID;
            ckAtivo.Checked = usuario.UsuarioAtivo;
        }
    }
}
