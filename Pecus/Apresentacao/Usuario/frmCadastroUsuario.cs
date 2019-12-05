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

using ObjetoTransferencia;
using Negocios;
using Apresentacao.Properties;

namespace Apresentacao.Usuario
{
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                TipoUsuarioNegocios tipoUsuarioNegocios = new TipoUsuarioNegocios();
                TipoUsuarioCollection tipoUsuarioCollection = new TipoUsuarioCollection();

                tipoUsuarioCollection = tipoUsuarioNegocios.ConsultarTodos();

                cbbTipoUsuario.DataSource = tipoUsuarioCollection;
                cbbTipoUsuario.DisplayMember = "TipoUsuarioDescricao";
                cbbTipoUsuario.ValueMember = "TipoUsuarioID";
                cbbTipoUsuario.Update();
                cbbTipoUsuario.SelectedIndex = 0;
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));
                if (Settings.Default.PrimeiraVez == true)
                {
                    for (int i = 0; i < tipoUsuarioCollection.Count; i++)
                    {
                        if (tipoUsuarioCollection[i].TipoUsuarioDescricao == "Administrador")
                        {
                            cbbTipoUsuario.SelectedValue = tipoUsuarioCollection[i].TipoUsuarioID;
                            cbbTipoUsuario.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
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

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text.Trim() == string.Empty)
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
                    UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
                    ObjetoTransferencia.Usuario usuario = new ObjetoTransferencia.Usuario();
                    Variados.Criptografia criptografia = new Variados.Criptografia();
                    if (usuarioNegocios.ValidacaoLogin(txtLogin.Text.Trim()) != 0)
                    {
                        MessageBox.Show("Este login já está cadastrado. Não é permitido duplicação de logins. Por favor, tente outro diferente.", "Duplicação de login.");
                        txtLogin.Focus();
                    }
                    else
                    {
                        usuario.UsuarioLogin = txtLogin.Text.Trim();
                        usuario.UsuarioNome = txtNome.Text.Trim();
                        usuario.UsuarioSenha = criptografia.getMD5Hash(txtSenha.Text.Trim());
                        usuario.TipoUsuario = new TipoUsuario();
                        usuario.TipoUsuario.TipoUsuarioID = Convert.ToInt32(cbbTipoUsuario.SelectedValue);

                        int ID = usuarioNegocios.Cadastrar(usuario);

                        if (ID > 0)
                        {
                            MessageBox.Show("Usuário de ID " + ID + " cadastrado com sucesso!", "Cadastro realizado com sucesso!");
                            Settings.Default.PrimeiraVez = false;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("O cadastro não foi realizado corretamente, tente novamente.", "Cadastro não realizado.");
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro durante o cadastro, tente novamente.\nCaso o erro persista, consulte seu suporte.\nErro: " + ex.Message, "Cadastro não realizado.");
                }
            }
        }

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

        private void TxtLogin_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtLogin.Text.Trim() != "")
                {
                    UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
                    if (usuarioNegocios.ValidacaoLogin(txtLogin.Text.Trim()) != 0)
                    {
                        MessageBox.Show("Este login já está cadastrado. Não é permitido duplicação de logins. Por favor, tente outro diferente.", "Duplicação de login.");
                        txtLogin.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante o cadastro, tente novamente.\nCaso o erro persista, consulte seu suporte.\nErro: " + ex.Message, "Cadastro não realizado.");
            }
        }
    }
}
