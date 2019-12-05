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
    public partial class controlEstoque : UserControl
    {
        public ObjetoTransferencia.Usuario user { get; set; }
        public controlEstoque()
        {
            InitializeComponent();
        }

        private void BtnCadastroItem_MouseEnter(object sender, EventArgs e)
        {
            lblCadastroItem.Visible = true;
            lblConsultaItem.Visible = false;
            timerItemRecolhe.Stop();
            timerItemAumenta.Start();
        }

        private void BtnCadastroItem_MouseLeave(object sender, EventArgs e)
        {
            timerItemAumenta.Stop();
            timerItemRecolhe.Start();
        }

        private void BtnConsultaItem_MouseEnter(object sender, EventArgs e)
        {
            lblConsultaItem.Visible = true;
            lblCadastroItem.Visible = false;
            timerItemRecolhe.Stop();
            timerItemAumenta.Start();
        }

        private void BtnConsultaItem_MouseLeave(object sender, EventArgs e)
        {
            timerItemAumenta.Stop();
            timerItemRecolhe.Start();
        }

        private void TimerItemAumenta_Tick(object sender, EventArgs e)
        {
            if (panelItem.Width > 353)
            {
                timerItemAumenta.Stop();
            }
            else
            {
                panelItem.Width += 15;
            }
        }

        private void TimerItemRecolhe_Tick(object sender, EventArgs e)
        {
            if (panelItem.Width < 1)
            {
                timerItemRecolhe.Stop();
            }
            else
            {
                panelItem.Width -= 15;
            }
        }

        private void BtnCadastroTipoItem_MouseEnter(object sender, EventArgs e)
        {
            lblCadastroTipoItem.Visible = true;
            lblConsultaTipoItem.Visible = false;
            timerTipoItemRecolhe.Stop();
            timerTipoItemAumenta.Start();
        }

        private void BtnCadastroTipoItem_MouseLeave(object sender, EventArgs e)
        {
            timerTipoItemAumenta.Stop();
            timerTipoItemRecolhe.Start();
        }

        private void BtnConsultaTipoItem_MouseEnter(object sender, EventArgs e)
        {
            lblConsultaTipoItem.Visible = true;
            lblCadastroTipoItem.Visible = false;
            timerTipoItemRecolhe.Stop();
            timerTipoItemAumenta.Start();
        }

        private void BtnConsultaTipoItem_MouseLeave(object sender, EventArgs e)
        {
            timerTipoItemAumenta.Stop();
            timerTipoItemRecolhe.Start();
        }

        private void TimerTipoItemAumenta_Tick(object sender, EventArgs e)
        {
            if (panelTipoitem.Width > 353)
            {
                timerTipoItemAumenta.Stop();
            }
            else
            {
                panelTipoitem.Width += 15;
            }
        }

        private void TimerTipoItemRecolhe_Tick(object sender, EventArgs e)
        {
            if (panelTipoitem.Width < 1)
            {
                timerTipoItemRecolhe.Stop();
            }
            else
            {
                panelTipoitem.Width -= 15;
            }
        }

        private void BtnCadastroArmazem_MouseEnter(object sender, EventArgs e)
        {
            lblCadastroArmazem.Visible = true;
            lblConsultaArmazem.Visible = false;
            timerArmazemRecolhe.Stop();
            timerArmazemAumenta.Start();
        }

        private void BtnCadastroArmazem_MouseLeave(object sender, EventArgs e)
        {
            timerArmazemAumenta.Stop();
            timerArmazemRecolhe.Start();
        }

        private void BtnConsultaArmazem_MouseEnter(object sender, EventArgs e)
        {
            lblConsultaArmazem.Visible = true;
            lblCadastroArmazem.Visible = false;
            timerArmazemRecolhe.Stop();
            timerArmazemAumenta.Start();
        }

        private void BtnConsultaArmazem_MouseLeave(object sender, EventArgs e)
        {
            timerArmazemAumenta.Stop();
            timerArmazemRecolhe.Start();
        }

        private void TimerArmazemAumenta_Tick(object sender, EventArgs e)
        {
            if (panelArmazem.Width > 353)
            {
                timerArmazemAumenta.Stop();
            }
            else
            {
                panelArmazem.Width += 15;
            }
        }

        private void TimerArmazemRecolhe_Tick(object sender, EventArgs e)
        {
            if (panelArmazem.Width < 1)
            {
                timerArmazemRecolhe.Stop();
            }
            else
            {
                panelArmazem.Width -= 15;
            }
        }

        private void BtnCadastroTipoItem_Click(object sender, EventArgs e)
        {
            TipoItem.frmCadastroTipoItem frmCadastroTipoItem = new TipoItem.frmCadastroTipoItem();
            frmCadastroTipoItem.ShowDialog();
        }

        private void BtnCadastroItem_Click(object sender, EventArgs e)
        {
            Item.frmCadastroItem frmCadastroItem = new Item.frmCadastroItem();
            frmCadastroItem.ShowDialog();
        }

        private void BtnCadastroArmazem_Click(object sender, EventArgs e)
        {
            if (user.TipoUsuario.TipoUsuarioDescricao == "Administrador")
            {
                EstoqueLocalidade.frmCadastroEstoqueLocalidade frmCadastroEstoqueLocalidade = new EstoqueLocalidade.frmCadastroEstoqueLocalidade(false, user.UsuarioID);
                frmCadastroEstoqueLocalidade.ShowDialog();
            }
            else
            {
                MessageBox.Show("Somente usuários administradores.", "Permissão negada.");
            }
        }

        private void BtnCadastroEstoque_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsultaArmazem_Click(object sender, EventArgs e)
        {
            EstoqueLocalidade.frmConsultaEstoqueLocalidade frmConsultaEstoqueLocalidade = new EstoqueLocalidade.frmConsultaEstoqueLocalidade(false, user);
            frmConsultaEstoqueLocalidade.Show();
        }

        private void BtnConsultaTipoItem_Click(object sender, EventArgs e)
        {
            TipoItem.frmConsultaTipoItem frmConsultaTipoItem = new TipoItem.frmConsultaTipoItem();
            frmConsultaTipoItem.ShowDialog();
        }

        private void BtnConsultaItem_Click(object sender, EventArgs e)
        {
            Item.frmConsultaItem frmConsultaItem = new Item.frmConsultaItem(false);
            frmConsultaItem.ShowDialog();
        }
    }
}
