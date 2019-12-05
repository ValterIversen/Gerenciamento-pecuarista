using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Variados
{
    public partial class controlEntradaSaida : UserControl
    {
        public ObjetoTransferencia.Usuario Usuario { get; set; }
        public controlEntradaSaida()
        {
            InitializeComponent();
        }

        private void TimerEntradaAumentar_Tick(object sender, EventArgs e)
        {
            if (panelEntrada.Width > 444)
            {
                timerEntradaAumentar.Stop();
            }
            else
            {
                panelEntrada.Width += 15;
            }
        }

        private void TimerEntradaRecolher_Tick(object sender, EventArgs e)
        {
            if (panelEntrada.Width < 1)
            {
                timerEntradaRecolher.Stop();
            }
            else
            {
                panelEntrada.Width -= 15;
            }
        }

        private void BtnCadastroEntrada_MouseEnter(object sender, EventArgs e)
        {
            lblCadastroEntrada.Visible = true;
            lblConsultaEntrada.Visible = false;
            timerEntradaRecolher.Stop();
            timerEntradaAumentar.Start();
        }

        private void BtnCadastroEntrada_MouseLeave(object sender, EventArgs e)
        {
            timerEntradaAumentar.Stop();
            timerEntradaRecolher.Start();
        }

        private void BtnConsultaEntrada_MouseEnter(object sender, EventArgs e)
        {
            lblConsultaEntrada.Visible = true;
            lblCadastroEntrada.Visible = false;
            timerEntradaRecolher.Stop();
            timerEntradaAumentar.Start();
        }

        private void BtnConsultaEntrada_MouseLeave(object sender, EventArgs e)
        {
            timerEntradaAumentar.Stop();
            timerEntradaRecolher.Start();
        }

        private void TimerSaidaAumentar_Tick(object sender, EventArgs e)
        {
            if (panelSaida.Width > 444)
            {
                timerSaidaAumentar.Stop();
            }
            else
            {
                panelSaida.Width += 15;
            }
        }

        private void TimerSaidaRecolher_Tick(object sender, EventArgs e)
        {
            if (panelSaida.Width < 1)
            {
                timerSaidaRecolher.Stop();
            }
            else
            {
                panelSaida.Width -= 15;
            }
        }

        private void BtnConsultaSaida_MouseEnter(object sender, EventArgs e)
        {
            lblConsultaSaida.Visible = true;
            lblCadastroSaida.Visible = false;
            timerSaidaRecolher.Stop();
            timerSaidaAumentar.Start();
        }

        private void BtnConsultaSaida_MouseLeave(object sender, EventArgs e)
        {
            timerSaidaAumentar.Stop();
            timerSaidaRecolher.Start();
        }

        private void BtnCadastroSaida_MouseEnter(object sender, EventArgs e)
        {
            lblCadastroSaida.Visible = true;
            lblConsultaSaida.Visible = false;
            timerSaidaRecolher.Stop();
            timerSaidaAumentar.Start();
        }

        private void BtnCadastroSaida_MouseLeave(object sender, EventArgs e)
        {
            timerSaidaAumentar.Stop();
            timerSaidaRecolher.Start();
        }

        private void BtnCadastroEntrada_Click(object sender, EventArgs e)
        {
            EntradaItem.frmCadastroEntradaItem frmCadastroEntradaItem = new EntradaItem.frmCadastroEntradaItem(Usuario);
            frmCadastroEntradaItem.ShowDialog();
        }

        private void BtnConsultaEntrada_Click(object sender, EventArgs e)
        {
            EntradaItem.frmConsultaEntradaitem frmConsultaEntradaitem = new EntradaItem.frmConsultaEntradaitem();
            frmConsultaEntradaitem.ShowDialog();
        }

        private void BtnCadastroSaida_Click(object sender, EventArgs e)
        {
            RetiradaItem.frmCadastroRetiradaItem frmCadastroRetiradaItem = new RetiradaItem.frmCadastroRetiradaItem(Usuario);
            frmCadastroRetiradaItem.ShowDialog();
        }

        private void BtnConsultaSaida_Click(object sender, EventArgs e)
        {
            RetiradaItem.frmConsultaRetiradaItem frmConsultaRetiradaItem = new RetiradaItem.frmConsultaRetiradaItem();
            frmConsultaRetiradaItem.ShowDialog();
        }
    }
}
