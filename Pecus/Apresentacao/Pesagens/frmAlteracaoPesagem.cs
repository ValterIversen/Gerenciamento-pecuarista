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

namespace Apresentacao.Pesagens
{
    public partial class frmAlteracaoPesagem : Form
    {
        Pesagem pesagem = new Pesagem();
        public frmAlteracaoPesagem(Pesagem pesagemP)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));

            dtpDataPesagem.MaxDate = DateTime.Now;
            pesagem = pesagemP;
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

        private void frmAlteracaoPesagem_Load(object sender, EventArgs e)
        {
            txtPeso.Text = pesagem.PesagemPeso.ToString();
            dtpDataPesagem.Value = pesagem.PesagemData;
            txtAnimal.Text = pesagem.Animal.AnimalID.ToString();
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPeso.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;
            else
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPeso.Text == "" || txtPeso.Text == "0")
                {
                    MessageBox.Show("Por favor, informe o peso.", "Informe o peso.");
                }
                else
                {
                    pesagem.PesagemData = dtpDataPesagem.Value;
                    pesagem.PesagemPeso = decimal.Parse(txtPeso.Text);

                    PesagemNegocios pesagemNegocios = new PesagemNegocios();
                    pesagemNegocios.Alterar(pesagem);
                    MessageBox.Show("Pesagem de ID " + pesagem.PesagemID + " alterada com sucesso!", "Pesagem alterada com sucesso!");
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Por favor, tente novamente.");
            }
        }
    }
}
