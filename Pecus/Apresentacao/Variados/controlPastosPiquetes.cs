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
    public partial class controlPastosPiquetes : UserControl
    {
        public ObjetoTransferencia.Usuario user;
        public controlPastosPiquetes()
        {
            InitializeComponent();
        }

        private void BtnCadastroPasto_MouseEnter(object sender, EventArgs e)
        {
            lblCadastroPasto.Visible = true;
            lblConsultaPasto.Visible = false;
            timerPastoRecolher.Stop();
            timerPastoAumentar.Start();
        }

        private void BtnCadastroPasto_MouseLeave(object sender, EventArgs e)
        {
            timerPastoAumentar.Stop();
            timerPastoRecolher.Start();
        }

        private void BtnConsultaPasto_MouseEnter(object sender, EventArgs e)
        {
            lblConsultaPasto.Visible = true;
            lblCadastroPasto.Visible = false;
            timerPastoRecolher.Stop();
            timerPastoAumentar.Start();
        }

        private void BtnConsultaPasto_MouseLeave(object sender, EventArgs e)
        {
            timerPastoAumentar.Stop();
            timerPastoRecolher.Start();
        }

        private void TimerPastoAumentar_Tick(object sender, EventArgs e)
        {
            if (panelPasto.Width > 444)
            {
                timerPastoAumentar.Stop();
            }
            else
            {
                panelPasto.Width += 15;
            }
        }

        private void TimerPastoRecolher_Tick(object sender, EventArgs e)
        {
            if (panelPasto.Width < 1)
            {
                timerPastoRecolher.Stop();
            }
            else
            {
                panelPasto.Width -= 15;
            }
        }

        private void BtnCadastroPasto_Click(object sender, EventArgs e)
        {
            if (user.TipoUsuario.TipoUsuarioDescricao == "Administrador")
            {
                Pasto.frmCadastroPasto frmCadastroPasto = new Pasto.frmCadastroPasto(false);
                frmCadastroPasto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Somente usuários administradores.", "Permissão negada.");
            }
        }

        private void BtnConsultaPasto_Click(object sender, EventArgs e)
        {
            Pasto.frmConsultaPasto frmConsultaPasto = new Pasto.frmConsultaPasto(false, user);
            frmConsultaPasto.ShowDialog();
        }
    }
}
