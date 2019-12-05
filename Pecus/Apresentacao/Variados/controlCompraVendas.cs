using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjetoTransferencia;

namespace Apresentacao.Variados
{
    public partial class controlCompraVendas : UserControl
    {
        public ObjetoTransferencia.Usuario usuario = new ObjetoTransferencia.Usuario();
        public controlCompraVendas()
        {
            InitializeComponent();
        }

        private void timerPessoaAumenta_Tick(object sender, EventArgs e)
        {
            if (panelCompra.Width > 444)
            {
                timerPessoaAumenta.Stop();
            }
            else
            {
                panelCompra.Width += 15;
            }
        }

        private void timerPessoaRecolhe_Tick(object sender, EventArgs e)
        {
            if (panelCompra.Width < 1)
            {
                timerPessoaRecolhe.Stop();
            }
            else
            {
                panelCompra.Width -= 15;
            }
        }

        private void btnCadastroCompra_MouseEnter(object sender, EventArgs e)
        {
            lblCadastroCompra.Visible = true;
            lblConsultaCompra.Visible = false;
            timerPessoaRecolhe.Stop();
            timerPessoaAumenta.Start();
        }

        private void btnCadastroCompra_MouseLeave(object sender, EventArgs e)
        {
            timerPessoaAumenta.Stop();
            timerPessoaRecolhe.Start();
        }

        private void btnConsultaCompra_MouseEnter(object sender, EventArgs e)
        {
            lblConsultaCompra.Visible = true;
            lblCadastroCompra.Visible = false;
            timerPessoaRecolhe.Stop();
            timerPessoaAumenta.Start();
        }

        private void btnConsultaCompra_MouseLeave(object sender, EventArgs e)
        {
            timerPessoaAumenta.Stop();
            timerPessoaRecolhe.Start();
        }

        private void timerVendaAumenta_Tick(object sender, EventArgs e)
        {
            if (panelVenda.Width > 444)
            {
                timerVendaAumenta.Stop();
            }
            else
            {
                panelVenda.Width += 15;
            }
        }

        private void timerVendaRecolhe_Tick(object sender, EventArgs e)
        {
            if (panelVenda.Width < 1)
            {
                timerVendaRecolhe.Stop();
            }
            else
            {
                panelVenda.Width -= 15;
            }
        }

        private void btnCadastroVenda_MouseEnter(object sender, EventArgs e)
        {
            lblCadastroVenda.Visible = true;
            lblConsultaVenda.Visible = false;
            timerVendaRecolhe.Stop();
            timerVendaAumenta.Start();
        }

        private void btnCadastroVenda_MouseLeave(object sender, EventArgs e)
        {
            timerVendaAumenta.Stop();
            timerVendaRecolhe.Start();
        }

        private void btnConsultaVenda_MouseEnter(object sender, EventArgs e)
        {
            lblCadastroVenda.Visible = false;
            lblConsultaVenda.Visible = true;
            timerVendaRecolhe.Stop();
            timerVendaAumenta.Start();
        }

        private void btnConsultaVenda_MouseLeave(object sender, EventArgs e)
        {
            timerVendaAumenta.Stop();
            timerVendaRecolhe.Start();
        }

        private void btnCadastroCompra_Click(object sender, EventArgs e)
        {
            Compras.frmCadastroCompras frmCadastroCompras = new Compras.frmCadastroCompras(usuario);
            frmCadastroCompras.ShowDialog();
        }

        private void btnCadastroVenda_Click(object sender, EventArgs e)
        {
            Vendas.frmCadastroVenda frmCadastroVenda = new Vendas.frmCadastroVenda(usuario);
            frmCadastroVenda.ShowDialog();
        }

        private void btnConsultaCompra_Click(object sender, EventArgs e)
        {
            Compras.frmConsultaCompra frmConsultaCompra = new Compras.frmConsultaCompra();
            frmConsultaCompra.ShowDialog();
        }

        private void btnConsultaVenda_Click(object sender, EventArgs e)
        {
            Vendas.frmConsultaVenda frmConsultaVenda = new Vendas.frmConsultaVenda();
            frmConsultaVenda.ShowDialog();
        }
    }
}
