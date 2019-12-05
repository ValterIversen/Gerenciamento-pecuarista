using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;

namespace Apresentacao.Variados.Reports.FormsReport
{
    public partial class frmReportPrincipal : Form
    {
        ObjetoTransferencia.Usuario usuario = new ObjetoTransferencia.Usuario();
        public frmReportPrincipal(ObjetoTransferencia.Usuario usuarioP)
        {
            InitializeComponent();

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));
            usuario = usuarioP;

            if(usuario.TipoUsuario.TipoUsuarioDescricao != "Administrador")
            {
                btnCompras.Enabled = false;
                btnVendas.Enabled = false;
                btnConsultaVeterinaria.Enabled = false;
                btnEstoque.Enabled = false;
                btnContratoAluguel.Enabled = false;

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

        private void picExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            picExit.BackgroundImage = Apresentacao.Properties.Resources.exit_hover;
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.BackgroundImage = Apresentacao.Properties.Resources.exit;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmReportCompra frmReportCompra = new frmReportCompra(usuario);
            frmReportCompra.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            frmReportVenda frmReportVenda = new frmReportVenda(usuario);
            frmReportVenda.ShowDialog();
        }

        private void btnPesagem_Click(object sender, EventArgs e)
        {
            frmReportPesagem frmReportPesagem = new frmReportPesagem(usuario);
            frmReportPesagem.ShowDialog();
        }

        private void btnConsultaVeterinaria_Click(object sender, EventArgs e)
        {
            frmReportConsultaVeterinaria frmReportConsultaVeterinaria = new frmReportConsultaVeterinaria(usuario);
            frmReportConsultaVeterinaria.ShowDialog();
        }

        private void btnPiquetes_Click(object sender, EventArgs e)
        {
            frmReportPiquete frmReportPiquete = new frmReportPiquete(usuario);
            frmReportPiquete.ShowDialog();
        }

        private void btnContratoAluguel_Click(object sender, EventArgs e)
        {
            frmReportContratoAluguel frmReportContratoAluguel = new frmReportContratoAluguel(usuario);
            frmReportContratoAluguel.ShowDialog();
        }

        private void btnRacas_Click(object sender, EventArgs e)
        {
            frmReportRacas frmReportRacas = new frmReportRacas(usuario);
            frmReportRacas.ShowDialog();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmReportEstoqueLocalidade frmReportEstoqueLocalidade = new frmReportEstoqueLocalidade(usuario);
            frmReportEstoqueLocalidade.ShowDialog();
        }

        private void btnEntradaItem_Click(object sender, EventArgs e)
        {
            frmReportEntradaItem frmReportEntradaItem = new frmReportEntradaItem(usuario);
            frmReportEntradaItem.ShowDialog();
        }

        private void btnSaidaItens_Click(object sender, EventArgs e)
        {
            frmReportRetiradaItem frmReportRetiradaItem = new frmReportRetiradaItem(usuario);
            frmReportRetiradaItem.ShowDialog();
        }
    }
}
