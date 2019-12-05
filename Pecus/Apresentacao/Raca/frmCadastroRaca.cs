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
    public partial class frmCadastroRaca : Form
    {
        public frmCadastroRaca()
        {
            InitializeComponent();
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

        private void TxtDescricao_Enter(object sender, EventArgs e)
        {
            if(txtDescricao.ForeColor == Color.DarkGray)
            {
                txtDescricao.ForeColor = Color.Black;
                txtDescricao.Text = "";
            }
        }

        private void TxtDescricao_Leave(object sender, EventArgs e)
        {
            if(txtDescricao.Text.Trim() == string.Empty)
            {
                txtDescricao.Text = "Aqui você pode descrever observações desejadas como características da raça, objetivo da criação da raça, cuidados necessários com estes animais e muitos outros.";
                txtDescricao.ForeColor = Color.DarkGray;
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ObjetoTransferencia.Raca raca = new ObjetoTransferencia.Raca();
                if (txtNome.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Por favor, informe o nome.");
                    txtNome.Focus();
                }
                else if (txtDescricao.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Por favor, informe a descrição");
                    txtDescricao.Focus();
                }
                else
                {
                    raca.RacaNome = txtNome.Text.Trim();
                    raca.RacaDescricao = txtDescricao.Text.Trim();

                    RacaNegocios racaNegocios = new RacaNegocios();

                    if (racaNegocios.ValidExist(0, raca.RacaDescricao).Count > 0)
                    {
                        MessageBox.Show("Já existe uma raça com este nome cadastrado.", "Duplicação de raça.");
                    }
                    else
                    {
                        raca.RacaID = racaNegocios.Cadastrar(raca);
                        if (raca.RacaID != 0)
                        {
                            MessageBox.Show("Raça de ID: " + raca.RacaID + " cadastrada com sucesso!");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Houve um erro no cadastro da raça, por favor, contate seu suporte.");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro no cadastro da raça, por favor, contate seu suporte.\nObservações: " + ex.Message);
            }
        }
    }
}
