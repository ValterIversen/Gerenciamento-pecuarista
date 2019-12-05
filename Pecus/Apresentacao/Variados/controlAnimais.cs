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
    public partial class controlAnimais : UserControl
    {
        public controlAnimais()
        {
            InitializeComponent();
        }

        private void BtnCadastroAnimal_MouseEnter(object sender, EventArgs e)
        {
            lblCadastroAnimal.Visible = true;
            lblConsultaAnimal.Visible = false;
            timerAnimalRecolher.Stop();
            timerAnimalAumentar.Start();
        }

        private void BtnCadastroAnimal_MouseLeave(object sender, EventArgs e)
        {
            timerAnimalAumentar.Stop();
            timerAnimalRecolher.Start();
        }

        private void BtnConsultaAnimal_MouseEnter(object sender, EventArgs e)
        {
            lblConsultaAnimal.Visible = true;
            lblCadastroAnimal.Visible = false;
            timerAnimalRecolher.Stop();
            timerAnimalAumentar.Start();
        }

        private void BtnConsultaAnimal_MouseLeave(object sender, EventArgs e)
        {
            timerAnimalAumentar.Stop();
            timerAnimalRecolher.Start();
        }

        private void TimerAnimalAumentar_Tick(object sender, EventArgs e)
        {
            if (panelAnimal.Width > 353)
            {
                timerAnimalAumentar.Stop();
            }
            else
            {
                panelAnimal.Width += 15;
            }
        }

        private void TimerAnimalRecolher_Tick(object sender, EventArgs e)
        {
            if (panelAnimal.Width < 1)
            {
                timerAnimalRecolher.Stop();
            }
            else
            {
                panelAnimal.Width -= 15;
            }
        }

        private void BtnCadastroPesagem_MouseEnter(object sender, EventArgs e)
        {
            lblCadastroPesagem.Visible = true;
            lblConsultaPesagem.Visible = false;
            timerPesagemRecolher.Stop();
            timerPesagemAumentar.Start();
        }

        private void BtnCadastroPesagem_MouseLeave(object sender, EventArgs e)
        {
            timerPesagemAumentar.Stop();
            timerPesagemRecolher.Start();
        }

        private void BtnConsultaPesagem_MouseEnter(object sender, EventArgs e)
        {
            lblConsultaPesagem.Visible = true;
            lblCadastroPesagem.Visible = false;
            timerPesagemRecolher.Stop();
            timerPesagemAumentar.Start();
        }

        private void BtnConsultaPesagem_MouseLeave(object sender, EventArgs e)
        {
            timerPesagemAumentar.Stop();
            timerPesagemRecolher.Start();
        }

        private void TimerPesagemAumentar_Tick(object sender, EventArgs e)
        {
            if (panelPesagem.Width > 353)
            {
                timerPesagemAumentar.Stop();
            }
            else
            {
                panelPesagem.Width += 15;
            }
        }

        private void TimerPesagemRecolher_Tick(object sender, EventArgs e)
        {
            if (panelPesagem.Width < 1)
            {
                timerPesagemRecolher.Stop();
            }
            else
            {
                panelPesagem.Width -= 15;
            }
        }

        private void BtnCadastroRaca_MouseEnter(object sender, EventArgs e)
        {
            lblCadastroRaca.Visible = true;
            lblConsultaRaca.Visible = false;
            timerRacaRecolher.Stop();
            timerRacaAumentar.Start();
        }

        private void BtnCadastroRaca_MouseLeave(object sender, EventArgs e)
        {
            timerRacaAumentar.Stop();
            timerRacaRecolher.Start();
        }

        private void BtnConsultaRaca_MouseEnter(object sender, EventArgs e)
        {
            lblConsultaRaca.Visible = true;
            lblCadastroRaca.Visible = false;
            timerRacaRecolher.Stop();
            timerRacaAumentar.Start();
        }

        private void BtnConsultaRaca_MouseLeave(object sender, EventArgs e)
        {
            timerRacaAumentar.Stop();
            timerRacaRecolher.Start();
        }

        private void TimerRacaAumentar_Tick(object sender, EventArgs e)
        {
            if (panelRaca.Width > 353)
            {
                timerRacaAumentar.Stop();
            }
            else
            {
                panelRaca.Width += 15;
            }
        }

        private void TimerRacaRecolher_Tick(object sender, EventArgs e)
        {
            if (panelRaca.Width < 1)
            {
                timerRacaRecolher.Stop();
            }
            else
            {
                panelRaca.Width -= 15;
            }
        }

        private void BtnCadastroRaca_Click(object sender, EventArgs e)
        {
            Raca.frmCadastroRaca frmCadastroRaca = new Raca.frmCadastroRaca();
            frmCadastroRaca.ShowDialog();
        }

        private void BtnConsultaRaca_Click(object sender, EventArgs e)
        {
            Raca.frmConsultaRaca frmConsultaRaca = new Raca.frmConsultaRaca();
            frmConsultaRaca.ShowDialog();
        }

        private void BtnCadastroAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                Animal.frmCadastroAnimal frmCadastroAnimal = new Animal.frmCadastroAnimal(false);
                frmCadastroAnimal.ShowDialog();
            }
            catch(Exception ex)
            {

            }
        }

        private void BtnConsultaAnimal_Click(object sender, EventArgs e)
        {
            Animal.frmConsultaAnimal frmConsultaAnimal = new Animal.frmConsultaAnimal(false);
            frmConsultaAnimal.ShowDialog();
        }

        private void btnCadastroPesagem_Click(object sender, EventArgs e)
        {
            Pesagens.frmCadastroPesagens frmCadastroPesagens = new Pesagens.frmCadastroPesagens();
            frmCadastroPesagens.ShowDialog();
        }

        private void btnConsultaPesagem_Click(object sender, EventArgs e)
        {
            Pesagens.frmConsultaPesagens frmConsultaPesagens = new Pesagens.frmConsultaPesagens();
            frmConsultaPesagens.ShowDialog();
        }
    }
}
