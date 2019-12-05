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

using Negocios;
using ObjetoTransferencia;

namespace Apresentacao.Estoque
{
    public partial class frmAlterarEstoque : Form
    {
        ObjetoTransferencia.Estoque estoque = new ObjetoTransferencia.Estoque();
        public frmAlterarEstoque(ObjetoTransferencia.Estoque est)
        {
            InitializeComponent();
            estoque = est;

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            gpbEstoque.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, gpbEstoque.Width, gpbEstoque.Height, 20, 20));

            txtItem.Text = estoque.Item.ItemID.ToString();
            txtQuantidade.Text = estoque.EstoqueQuantidade.ToString();
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
            this.DialogResult = DialogResult.Cancel;
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
            try
            {

                if (txtItem.Text == "" || txtItem.Text == "0")
                {
                    MessageBox.Show("Por favor, informe o tipo de item.", "Informe o tipo de item.");
                }
                else if (txtQuantidade.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Por favor, informe a quantidade.", "Informe a quantidade.");
                }
                else
                {
                    EstoqueNegocios estoqueNegocios = new EstoqueNegocios();
                    estoque.EstoqueAtivo = ckAtivo.Checked;
                    estoque.EstoqueQuantidade = Convert.ToDecimal(txtQuantidade.Text);
                    estoque.Item.ItemID = Convert.ToInt32(txtItem.Text);

                    estoqueNegocios.Alterar(estoque);
                    MessageBox.Show("Estoque de ID " + estoque.EstoqueID + " alterado com sucesso!", "Estoque alterado com sucesso!");

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao alterar o estoque, por favor, contate seu suporte.\nObservações: " + ex.Message);
            }
        }

        private void BtnBuscarItem_Click(object sender, EventArgs e)
        {
            Item.frmConsultaItem frmConsultaItem = new Item.frmConsultaItem(true);
            frmConsultaItem.ShowDialog();
            txtItem.Text = frmConsultaItem.item.ItemID.ToString();
        }
    }
}
