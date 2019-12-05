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
using Apresentacao.Properties;

namespace Apresentacao.Usuario
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioNegocios usuarioNegocios = new UsuarioNegocios();

                ObjetoTransferencia.Usuario usuario = new ObjetoTransferencia.Usuario();

                Variados.Criptografia criptografia = new Variados.Criptografia();

                usuario.UsuarioLogin = txtLogin.Text;
                usuario.UsuarioSenha = criptografia.getMD5Hash(txtSenha.Text.Trim());

                ObjetoTransferencia.Usuario resultado = new ObjetoTransferencia.Usuario();
                resultado = usuarioNegocios.Validacao(usuario);

                if (resultado != null)
                {
                    resultado = usuarioNegocios.ConsultaPorID(resultado.UsuarioID);
                    Variados.frmMenuPrincipal frmMenuPrincipal = new Variados.frmMenuPrincipal(resultado);
                    frmMenuPrincipal.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Usuario não identificado, verifique seus dados e tente novamente.", "Login não efetuado");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro ao conectar com o banco, por favor, cosulte seu suporte.", "Erro ao inicializar o sistema.");
            }
        }

        private void PicConfig_MouseEnter(object sender, EventArgs e)
        {
            picConfig.BackgroundImage = Apresentacao.Properties.Resources.question_hover;
        }

        private void PicConfig_MouseLeave(object sender, EventArgs e)
        {
            picConfig.BackgroundImage = Apresentacao.Properties.Resources.question;
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

        private void PicMinimizar_MouseEnter(object sender, EventArgs e)
        {
            picMinimizar.BackgroundImage = Apresentacao.Properties.Resources.minimize_hover;
        }

        private void PicMinimizar_MouseLeave(object sender, EventArgs e)
        {
            picMinimizar.BackgroundImage = Apresentacao.Properties.Resources.minimize;
        }

        private void PicMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicConfig_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (Settings.Default.PrimeiraVez == true)
            {
                frmCadastroUsuario frmCadastroUsuario = new frmCadastroUsuario();
                frmCadastroUsuario.ShowDialog();
            }
        }
    }
}
