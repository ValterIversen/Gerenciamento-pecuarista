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

namespace Apresentacao.Variados
{
    public partial class frmMenuPrincipal : Form
    {
        private ObjetoTransferencia.Usuario user = new ObjetoTransferencia.Usuario();
        public frmMenuPrincipal(ObjetoTransferencia.Usuario usuario)
        {
            InitializeComponent();
            controlAnimais.BringToFront();
            user = usuario;
            lblInfo.Text = "Seja bem vindo: " + user.UsuarioNome;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if(user.TipoUsuario.TipoUsuarioDescricao != "Administrador")
            {
                btnUsuario.Enabled = false;
                btnCompraVenda.Enabled = false;
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

        //Este método verifica qual botão estava ativo e recolhe o panel amarelo
        private void recolhePanelBtnMenuPrincipal(string btnAtual)
        {
            if (panelbtnAnimal.Width > 0 && btnAtual != "btnAnimal")
            {
                panelbtnAnimal.Width -= 1;
                var left = btnAnimal.Padding.Left - 1;
                btnAnimal.Padding = new Padding(left, 0, 0, 0);
            }
            if (panelbtnCompraVenda.Width > 0 && btnAtual != "btnCompraVenda")
            {
                panelbtnCompraVenda.Width -= 1;
                var left = btnCompraVenda.Padding.Left - 1;
                btnCompraVenda.Padding = new Padding(left, 0, 0, 0);
            }
            if (panelbtnEntradaSaida.Width > 0 && btnAtual != "btnEntradaSaida")
            {
                panelbtnEntradaSaida.Width -= 1;
                var left = btnEntradaSaida.Padding.Left - 1;
                btnEntradaSaida.Padding = new Padding(left, 0, 0, 0);
            }
            if (panelbtnClientePecuarista.Width > 0 && btnAtual != "btnClientePecuarista")
            {
                panelbtnClientePecuarista.Width -= 1;
                var left = btnClientePecuarista.Padding.Left - 1;
                btnClientePecuarista.Padding = new Padding(left, 0, 0, 0);
            }
            if (panelbtnEstoque.Width > 0 && btnAtual != "btnEstoque")
            {
                panelbtnEstoque.Width -= 1;
                var left = btnEstoque.Padding.Left - 1;
                btnEstoque.Padding = new Padding(left, 0, 0, 0);
            }
            if (panelbtnPastoPiquete.Width > 0 && btnAtual != "btnPastoPiquete")
            {
                panelbtnPastoPiquete.Width -= 1;
                var left = btnPastoPiquete.Padding.Left - 1;
                btnPastoPiquete.Padding = new Padding(left, 0, 0, 0);
            }
            if (panelbtnVeterinario.Width > 0 && btnAtual != "btnVeterinario")
            {
                panelbtnVeterinario.Width -= 1;
                var left = btnVeterinario.Padding.Left - 1;
                btnVeterinario.Padding = new Padding(left, 0, 0, 0);
            }
            if (panelbtnUsuario.Width > 0 && btnAtual != "btnUsuario")
            {
                panelbtnUsuario.Width -= 1;
                var left = btnUsuario.Padding.Left - 1;
                btnUsuario.Padding = new Padding(left, 0, 0, 0);
            }

        }

        private void BtnAnimal_Click(object sender, EventArgs e)
        {
            if (!timerbtnAnimal.Enabled && !timerbtnCompraVenda.Enabled && !timerbtnEntradaSaida.Enabled && !timerbtnClientePecuarista.Enabled && !timerbtnEstoque.Enabled
                   && !timerbtnPastoPiquete.Enabled && !timerbtnVeterinario.Enabled && !timerbtnUsuario.Enabled)
            {
                lblTitulo.Text = "Nesta sessão você pode gerir animais, raças e pesos.";
                timerbtnAnimal.Start();
                controlAnimais.BringToFront();
            }
        }
        private void BtnCompraVenda_Click(object sender, EventArgs e)
        {
            if (!timerbtnAnimal.Enabled && !timerbtnCompraVenda.Enabled && !timerbtnEntradaSaida.Enabled && !timerbtnClientePecuarista.Enabled && !timerbtnEstoque.Enabled
                   && !timerbtnPastoPiquete.Enabled && !timerbtnVeterinario.Enabled && !timerbtnUsuario.Enabled)
            {
                lblTitulo.Text = "Nesta sessão você pode gerir compras e vendas.";
                timerbtnCompraVenda.Start();
                controlCompraVendas.usuario = user;
                controlCompraVendas.BringToFront();
            }
        }

        private void BtnEntradaSaida_Click(object sender, EventArgs e)
        {
            if (!timerbtnAnimal.Enabled && !timerbtnCompraVenda.Enabled && !timerbtnEntradaSaida.Enabled && !timerbtnClientePecuarista.Enabled && !timerbtnEstoque.Enabled
                   && !timerbtnPastoPiquete.Enabled && !timerbtnVeterinario.Enabled && !timerbtnUsuario.Enabled)
            {
                lblTitulo.Text = "Nesta sessão você pode gerir entradas e saídas do seu armazém.";
                timerbtnEntradaSaida.Start();
                controlEntradaSaida.Usuario = user;
                controlEntradaSaida.BringToFront();
            }

        }

        private void BtnClientePecuarista_Click(object sender, EventArgs e)
        {
            if (!timerbtnAnimal.Enabled && !timerbtnCompraVenda.Enabled && !timerbtnEntradaSaida.Enabled && !timerbtnClientePecuarista.Enabled && !timerbtnEstoque.Enabled
                   && !timerbtnPastoPiquete.Enabled && !timerbtnVeterinario.Enabled && !timerbtnUsuario.Enabled)
            {
                lblTitulo.Text = "Gerencie clientes/pecuaristas e contratos de aluguel/arrendamento.";
                timerbtnClientePecuarista.Start();
                controlPessoas.User = user;
                controlPessoas.BringToFront();
            }
        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            if (!timerbtnAnimal.Enabled && !timerbtnCompraVenda.Enabled && !timerbtnEntradaSaida.Enabled && !timerbtnClientePecuarista.Enabled && !timerbtnEstoque.Enabled
                   && !timerbtnPastoPiquete.Enabled && !timerbtnVeterinario.Enabled && !timerbtnUsuario.Enabled)
            {
                lblTitulo.Text = "Nesta sessão você pode gerir armazéns e seus estoques.";
                timerbtnEstoque.Start();
                controlEstoque.user = user;
                controlEstoque.BringToFront();
            }
        }

        private void BtnPastoPiquete_Click(object sender, EventArgs e)
        {
            if (!timerbtnAnimal.Enabled && !timerbtnCompraVenda.Enabled && !timerbtnEntradaSaida.Enabled && !timerbtnClientePecuarista.Enabled && !timerbtnEstoque.Enabled
                   && !timerbtnPastoPiquete.Enabled && !timerbtnVeterinario.Enabled && !timerbtnUsuario.Enabled)
            {
                lblTitulo.Text = "Nesta sessão você pode gerir pastos e seus piquetes.";
                controlPastosPiquetes.user = user;
                timerbtnPastoPiquete.Start();
                controlPastosPiquetes.BringToFront();
            }
        }

        private void BtnVeterinario_Click(object sender, EventArgs e)
        {
            if (!timerbtnAnimal.Enabled && !timerbtnCompraVenda.Enabled && !timerbtnEntradaSaida.Enabled && !timerbtnClientePecuarista.Enabled && !timerbtnEstoque.Enabled
                   && !timerbtnPastoPiquete.Enabled && !timerbtnVeterinario.Enabled && !timerbtnUsuario.Enabled)
            {
                lblTitulo.Text = "Gerencie consultas veterinárias de seus animais.";
                timerbtnVeterinario.Start();
                controlVeterinario.BringToFront();
            }
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            if (!timerbtnAnimal.Enabled && !timerbtnCompraVenda.Enabled && !timerbtnEntradaSaida.Enabled && !timerbtnClientePecuarista.Enabled && !timerbtnEstoque.Enabled
                   && !timerbtnPastoPiquete.Enabled && !timerbtnVeterinario.Enabled && !timerbtnUsuario.Enabled)
            {
                lblTitulo.Text = "Gerenciamento de usuários do sistema.";
                timerbtnUsuario.Start();
                controlUsuario.BringToFront();
            }
        }

        private void TimerbtnCompraVenda_Tick(object sender, EventArgs e)
        {
            if (panelbtnCompraVenda.Width > 16)
            {
                timerbtnCompraVenda.Stop();
            }
            else
            {
                panelbtnCompraVenda.Width += 1;
                var left = btnCompraVenda.Padding.Left + 1;
                btnCompraVenda.Padding = new Padding(left, 0, 0, 0);
                recolhePanelBtnMenuPrincipal("btnCompraVenda");
            }
        }

        private void TimerbtnEntradaSaida_Tick(object sender, EventArgs e)
        {
            if (panelbtnEntradaSaida.Width > 16)
            {
                timerbtnEntradaSaida.Stop();
            }
            else
            {
                panelbtnEntradaSaida.Width += 1;
                var left = btnEntradaSaida.Padding.Left + 1;
                btnEntradaSaida.Padding = new Padding(left, 0, 0, 0);
                recolhePanelBtnMenuPrincipal("btnEntradaSaida");
            }
        }

        private void TimerbtnAnimal_Tick(object sender, EventArgs e)
        {
            if (panelbtnAnimal.Width > 16)
            {
                timerbtnAnimal.Stop();
            }
            else
            {
                panelbtnAnimal.Width += 1;
                var left = btnAnimal.Padding.Left + 1;
                btnAnimal.Padding = new Padding(left,0,0,0);
                recolhePanelBtnMenuPrincipal("btnAnimal");
            }
        }

        private void TimerbtnClientePecuarista_Tick(object sender, EventArgs e)
        {
            if (panelbtnClientePecuarista.Width > 16)
            {
                timerbtnClientePecuarista.Stop();
            }
            else
            {
                panelbtnClientePecuarista.Width += 1;
                var left = btnClientePecuarista.Padding.Left + 1;
                btnClientePecuarista.Padding = new Padding(left, 0, 0, 0);
                recolhePanelBtnMenuPrincipal("btnClientePecuarista");
            }
        }

        private void TimerbtnEstoque_Tick(object sender, EventArgs e)
        {
            if (panelbtnEstoque.Width > 16)
            {
                timerbtnEstoque.Stop();
            }
            else
            {
                panelbtnEstoque.Width += 1;
                var left = btnEstoque.Padding.Left + 1;
                btnEstoque.Padding = new Padding(left, 0, 0, 0);
                recolhePanelBtnMenuPrincipal("btnEstoque");
            }
        }

        private void TimerbtnPastoPiquete_Tick(object sender, EventArgs e)
        {
            if (panelbtnPastoPiquete.Width > 16)
            {
                timerbtnPastoPiquete.Stop();
            }
            else
            {
                panelbtnPastoPiquete.Width += 1;
                var left = btnPastoPiquete.Padding.Left + 1;
                btnPastoPiquete.Padding = new Padding(left, 0, 0, 0);
                recolhePanelBtnMenuPrincipal("btnPastoPiquete");
            }
        }

        private void TimerbtnVeterinario_Tick(object sender, EventArgs e)
        {
            if (panelbtnVeterinario.Width > 16)
            {
                timerbtnVeterinario.Stop();
            }
            else
            {
                panelbtnVeterinario.Width += 1;
                var left = btnVeterinario.Padding.Left + 1;
                btnVeterinario.Padding = new Padding(left, 0, 0, 0);
                recolhePanelBtnMenuPrincipal("btnVeterinario");
            }
        }

        private void TimerbtnUsuario_Tick(object sender, EventArgs e)
        {
            if (panelbtnUsuario.Width > 16)
            {
                timerbtnUsuario.Stop();
            }
            else
            {
                panelbtnUsuario.Width += 1;
                var left = btnUsuario.Padding.Left + 1;
                btnUsuario.Padding = new Padding(left, 0, 0, 0);
                recolhePanelBtnMenuPrincipal("btnUsuario");
            }
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Reports.FormsReport.frmReportPrincipal frmReportPrincipal = new Reports.FormsReport.frmReportPrincipal(user);
            frmReportPrincipal.ShowDialog();

        }

        private void picReports_MouseEnter(object sender, EventArgs e)
        {
            picReports.BackgroundImage = Apresentacao.Properties.Resources.chart_hover;
        }

        private void picReports_MouseLeave(object sender, EventArgs e)
        {
            picReports.BackgroundImage = Apresentacao.Properties.Resources.chart;
        }
    }
}
