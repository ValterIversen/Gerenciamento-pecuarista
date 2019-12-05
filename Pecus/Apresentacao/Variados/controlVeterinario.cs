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
    public partial class controlVeterinario : UserControl
    {
        public controlVeterinario()
        {
            InitializeComponent();
        }

        private void btnCadastroVeterinario_Click(object sender, EventArgs e)
        {
            Veterinario.frmCadastroVeterinario frmCadastroVeterinario = new Veterinario.frmCadastroVeterinario();
            frmCadastroVeterinario.ShowDialog();
        }

        private void btnConsultaVeterinario_Click(object sender, EventArgs e)
        {
            Veterinario.frmConsultaVeterinario frmConsultaVeterinario = new Veterinario.frmConsultaVeterinario(false);
            frmConsultaVeterinario.ShowDialog();
        }

        private void btnConsultaVeterinario_MouseEnter(object sender, EventArgs e)
        {
            lblConsultaVeterinario.Visible = true;
            lblCadastroVeterinario.Visible = false;
            timerVeterinarioRecolher.Stop();
            timerVeterinarioAumentar.Start();
        }

        private void btnConsultaVeterinario_MouseLeave(object sender, EventArgs e)
        {
            timerVeterinarioAumentar.Stop();
            timerVeterinarioRecolher.Start();
        }

        private void btnCadastroVeterinario_MouseEnter(object sender, EventArgs e)
        {
            lblCadastroVeterinario.Visible = true;
            lblConsultaVeterinario.Visible = false;
            timerVeterinarioRecolher.Stop();
            timerVeterinarioAumentar.Start();
        }

        private void btnCadastroVeterinario_MouseLeave(object sender, EventArgs e)
        {
            timerVeterinarioAumentar.Stop();
            timerVeterinarioRecolher.Start();
        }

        private void timerVeterinarioAumentar_Tick(object sender, EventArgs e)
        {
            if (panelVeterinario.Width > 444)
            {
                timerVeterinarioAumentar.Stop();
            }
            else
            {
                panelVeterinario.Width += 15;
            }
        }

        private void timerVeterinarioRecolher_Tick(object sender, EventArgs e)
        {
            if (panelVeterinario.Width < 1)
            {
                timerVeterinarioRecolher.Stop();
            }
            else
            {
                panelVeterinario.Width -= 15;
            }
        }

        private void btnCadastroConsultaVeterinario_Click(object sender, EventArgs e)
        {
            ConsultaVeterinaria.frmCadastroConsultaVeterinaria frmCadastroConsultaVeterinaria = new ConsultaVeterinaria.frmCadastroConsultaVeterinaria();
            frmCadastroConsultaVeterinaria.ShowDialog();
        }

        private void btnConsultaConsultaVeterinario_Click(object sender, EventArgs e)
        {
            ConsultaVeterinaria.frmConsultaConsultaVeterinaria frmConsultaConsultaVeterinaria = new ConsultaVeterinaria.frmConsultaConsultaVeterinaria();
            frmConsultaConsultaVeterinaria.ShowDialog();
        }

        private void btnConsultaConsultaVeterinario_MouseEnter(object sender, EventArgs e)
        {
            lblCadastroConsultaVeterinario.Visible = false;
            lblConsultaConsultaVeterinario.Visible = true;
            timerConsultaVeterinarioRecolher.Stop();
            timerConsultaVeterinarioAumentar.Start();
        }

        private void btnConsultaConsultaVeterinario_MouseLeave(object sender, EventArgs e)
        {
            timerConsultaVeterinarioAumentar.Stop();
            timerConsultaVeterinarioRecolher.Start();
        }

        private void btnCadastroConsultaVeterinario_MouseEnter(object sender, EventArgs e)
        {
            lblCadastroConsultaVeterinario.Visible = true;
            lblConsultaConsultaVeterinario.Visible = false;
            timerConsultaVeterinarioRecolher.Stop();
            timerConsultaVeterinarioAumentar.Start();
        }

        private void btnCadastroConsultaVeterinario_MouseLeave(object sender, EventArgs e)
        {
            timerConsultaVeterinarioAumentar.Stop();
            timerConsultaVeterinarioRecolher.Start();
        }

        private void timerConsultaVeterinarioAumentar_Tick(object sender, EventArgs e)
        {
            if (panelConsultaVeterinario.Width > 444)
            {
                timerConsultaVeterinarioAumentar.Stop();
            }
            else
            {
                panelConsultaVeterinario.Width += 15;
            }
        }

        private void timerConsultaVeterinarioRecolher_Tick(object sender, EventArgs e)
        {
            if (panelConsultaVeterinario.Width < 1)
            {
                timerConsultaVeterinarioRecolher.Stop();
            }
            else
            {
                panelConsultaVeterinario.Width -= 15;
            }
        }
    }
}
