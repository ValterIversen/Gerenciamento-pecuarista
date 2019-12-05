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

using ObjetoTransferencia;
using Negocios;

namespace Apresentacao.Raca
{
    public partial class frmAlteracaoRaca : Form
    {
        private ObjetoTransferencia.Raca raca = new ObjetoTransferencia.Raca();
        private RacaNegocios racaNegocios = new RacaNegocios();

        public frmAlteracaoRaca(ObjetoTransferencia.Raca racaParametro)
        {
            InitializeComponent();
            txtNome.Text = racaParametro.RacaNome;
            txtDescricao.Text = racaParametro.RacaDescricao;
            raca = racaParametro;
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


        private void PicExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PicExit_MouseEnter(object sender, EventArgs e)
        {
            picExit.BackgroundImage = Apresentacao.Properties.Resources.exit_hover;
        }

        private void PicExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.BackgroundImage = Apresentacao.Properties.Resources.exit;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor, preencha o Nome da raça.", "Preencha o Nome");
            }
            else if (txtDescricao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor, preencha a Descrição da raça.", "Preencha a Descrição");
            }
            else
            {
                try
                {
                    raca.RacaNome = txtNome.Text.Trim();
                    raca.RacaDescricao = txtDescricao.Text.Trim();

                    if (racaNegocios.ValidExist(raca.RacaID, raca.RacaDescricao).Count > 0)
                    {
                        MessageBox.Show("Já existe uma raça com este nome cadastrado.", "Duplicação de raça.");
                    }
                    else
                    {
                        racaNegocios.Alterar(raca);
                        MessageBox.Show("Raça de ID " + raca.RacaID + " alterada com sucesso!", "Alteração realizada com sucesso!");
                        Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro durante a alteração, tente novamente.\nCaso o erro persista, consulte seu suporte.\nErro: " + ex.Message, "Alteração não realizada.");
                }
            }
        }
    }
}
