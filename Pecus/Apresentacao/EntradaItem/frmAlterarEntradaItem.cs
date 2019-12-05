using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;

namespace Apresentacao.EntradaItem
{
    public partial class frmAlterarEntradaItem : Form
    {
        private ObjetoTransferencia.EntradaItem entradaItem = new ObjetoTransferencia.EntradaItem();
        public frmAlterarEntradaItem(ObjetoTransferencia.EntradaItem entradaI)
        {
            InitializeComponent();
            entradaItem = entradaI;

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));

            try
            {
                txtDescricao.Text = entradaItem.EntradaItemDescricao;
                txtItem.Text = entradaItem.Item.ItemID.ToString();
                txtItemDescricao.Text = entradaItem.Item.ItemDescricao;
                EstoqueNegocios estoqueNegocios = new EstoqueNegocios();
                entradaItem.Estoque = estoqueNegocios.ConsultaPorID(entradaItem.Estoque.EstoqueID);
                txtArmazem.Text = entradaItem.Estoque.EstoqueLocalidade.EstoqueLocalidadeDescricao;
                txtQuantidade.Text = entradaItem.EntradaItemQuantidade.ToString();
                dtpData.Value = entradaItem.EntradaItemData;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Tente novamente.");
                Close();
            }
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
                if(txtDescricao.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Por favor, informe a descrição.", "Informe a descrição.");
                }
                else if(txtQuantidade.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Por favor, informe a quantidade.", "Informe a quantidade.");
                }
                else
                {
                    EntradaItemNegocios entradaItemNegocios = new EntradaItemNegocios();
                    entradaItem.EntradaItemDescricao = txtDescricao.Text.Trim();
                    entradaItem.EntradaItemQuantidade = decimal.Parse(txtQuantidade.Text);

                    entradaItemNegocios.Alterar(entradaItem);
                    MessageBox.Show("Entrada de ID " + entradaItem.EntradaItemID + " alterada com sucesso!", "Alteração realizada com sucesso!");
                    Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Tente novamente.");
            }
        }

        private void TxtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtQuantidade.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;
            else
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
            //if(txtQuantidade.Text.Length == txtQuantidade.Text.IndexOf(',') + 3 && txtQuantidade.Text.IndexOf(',') != null)
            //{
            //    txtQuantidade.Text = txtQuantidade.Text.Replace(",", "");

            //    txtQuantidade.Text = txtQuantidade.Text.Substring(0, txtQuantidade.Text.Length - 3) + "," + txtQuantidade.Text.Substring(txtQuantidade.Text.Length - 3, txtQuantidade.Text.Length);
            //}
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Você tem certeza sobre a exclusão?", "Confirme sua decisão.",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EntradaItemNegocios entradaItemNegocios = new EntradaItemNegocios();
                    entradaItemNegocios.Excluir(entradaItem.EntradaItemID);
                    MessageBox.Show("Entrada de ID " + entradaItem.EntradaItemID + " excluída com sucesso!", "Exclusão realizada com sucesso!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Tente novamente.");
            }
        }
    }
}
