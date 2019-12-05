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
    public partial class controlPessoas : UserControl
    {
        public ObjetoTransferencia.Usuario User { get; set; }
        public controlPessoas()
        {
            InitializeComponent();
        }

        private void timerPessoaAumenta_Tick(object sender, EventArgs e)
        {
            if (panelPessoa.Width > 444)
            {
                timerPessoaAumenta.Stop();
            }
            else
            {
                panelPessoa.Width += 15;
            }
        }

        private void timerPessoaRecolhe_Tick(object sender, EventArgs e)
        {
            if (panelPessoa.Width < 1)
            {
                timerPessoaRecolhe.Stop();
            }
            else
            {
                panelPessoa.Width -= 15;
            }
        }

        private void btnConsultaPessoa_Click(object sender, EventArgs e)
        {
            Pessoa.frmConsultaPessoa frmConsultaPessoa = new Pessoa.frmConsultaPessoa(false);
            frmConsultaPessoa.ShowDialog();
        }

        private void btnConsultaPessoa_MouseEnter(object sender, EventArgs e)
        {
            lblConsultaPessoa.Visible = true;
            lblCadastroPessoa.Visible = false;
            timerPessoaRecolhe.Stop();
            timerPessoaAumenta.Start();
        }

        private void btnConsultaPessoa_MouseLeave(object sender, EventArgs e)
        {
            timerPessoaAumenta.Stop();
            timerPessoaRecolhe.Start();
        }

        private void btnCadastroPessoa_MouseEnter(object sender, EventArgs e)
        {
            lblCadastroPessoa.Visible = true;
            lblConsultaPessoa.Visible = false;
            timerPessoaRecolhe.Stop();
            timerPessoaAumenta.Start();
        }

        private void btnCadastroPessoa_MouseLeave(object sender, EventArgs e)
        {
            timerPessoaAumenta.Stop();
            timerPessoaRecolhe.Start();
        }

        private void timerContratoAumenta_Tick(object sender, EventArgs e)
        {
            if (panelContratoAluguel.Width > 444)
            {
                timerContratoAumenta.Stop();
            }
            else
            {
                panelContratoAluguel.Width += 15;
            }
        }

        private void timerContratoRecolhe_Tick(object sender, EventArgs e)
        {
            if (panelContratoAluguel.Width < 1)
            {
                timerContratoRecolhe.Stop();
            }
            else
            {
                panelContratoAluguel.Width -= 15;
            }
        }

        private void btnCadastroContratoAluguel_MouseEnter(object sender, EventArgs e)
        {
            lblCadastroContratoAluguel.Visible = true;
            lblConsultaContratoAluguel.Visible = false;
            timerContratoRecolhe.Stop();
            timerContratoAumenta.Start();
        }

        private void btnCadastroContratoAluguel_MouseLeave(object sender, EventArgs e)
        {
            timerContratoAumenta.Stop();
            timerContratoRecolhe.Start();
        }

        private void btnConsultaContratoAluguel_MouseEnter(object sender, EventArgs e)
        {
            lblConsultaContratoAluguel.Visible = true;
            lblCadastroContratoAluguel.Visible = false;
            timerContratoRecolhe.Stop();
            timerContratoAumenta.Start();
        }

        private void btnConsultaContratoAluguel_MouseLeave(object sender, EventArgs e)
        {
            timerContratoAumenta.Stop();
            timerContratoRecolhe.Start();
        }

        private void btnCadastroContratoAluguel_Click(object sender, EventArgs e)
        {
            if (User.TipoUsuario.TipoUsuarioDescricao == "Administrador")
            {
                ContratoAluguel.frmCadastroContratoAluguel frmCadastroContratoAluguel = new ContratoAluguel.frmCadastroContratoAluguel(User);
                frmCadastroContratoAluguel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Somente usuários administradores.", "Permissão negada.");
            }
        }

        private void btnConsultaContratoAluguel_Click(object sender, EventArgs e)
        {
            if (User.TipoUsuario.TipoUsuarioDescricao == "Administrador")
            {
                ContratoAluguel.frmConsultaContratoAluguel frmConsultaContratoAluguel = new ContratoAluguel.frmConsultaContratoAluguel(false, User);
                frmConsultaContratoAluguel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Somente usuários administradores.", "Permissão negada.");
            }
        }

        private void btnCadastroPessoa_Click(object sender, EventArgs e)
        {
            Pessoa.frmCadastroPessoa frmCadastroPessoa = new Pessoa.frmCadastroPessoa();
            frmCadastroPessoa.ShowDialog();
        }
    }
}
