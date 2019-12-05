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
    public partial class frmCadastroEntradaItem : Form
    {
        ObjetoTransferencia.Usuario usuario = new ObjetoTransferencia.Usuario();
        ObjetoTransferencia.Estoque estoque = new ObjetoTransferencia.Estoque();
        public frmCadastroEntradaItem(ObjetoTransferencia.Usuario user)
        {
            InitializeComponent();

            usuario = user;

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

        private void BtnBuscarEstoque_Click(object sender, EventArgs e)
        {
            Estoque.frmConsultaEstoque frmConsultaEstoque = new Estoque.frmConsultaEstoque(usuario);
            frmConsultaEstoque.ShowDialog();
            if (frmConsultaEstoque.estoqueRetorno.EstoqueID != 0)
            {
                estoque = frmConsultaEstoque.estoqueRetorno;
                txtItemID.Text = frmConsultaEstoque.estoqueRetorno.Item.ItemID.ToString();
                txtItem.Text = frmConsultaEstoque.estoqueRetorno.Item.ItemDescricao;
                txtArmazem.Text = frmConsultaEstoque.estoqueRetorno.EstoqueLocalidade.EstoqueLocalidadeDescricao;
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtDescricao.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Por favor, informe a descrição da entrada.", "Informe a descrição.");
                }
                else if (txtItemID.Text.Trim() == string.Empty || txtItemID.Text == "0")
                {
                    MessageBox.Show("Por favor, informe o estoque.", "Informe o estoque.");
                }
                else if (txtQuantidade.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Por favor, informe a quantidade.", "Informe a quantidade.");
                }
                else
                {
                    ObjetoTransferencia.EntradaItem entradaItem = new ObjetoTransferencia.EntradaItem();
                    EntradaItemNegocios entradaItemNegocios = new EntradaItemNegocios();

                    entradaItem.EntradaItemDescricao = txtDescricao.Text.Trim();
                    entradaItem.EntradaItemData = DateTime.Now;
                    entradaItem.EntradaItemQuantidade = decimal.Parse(txtQuantidade.Text);
                    entradaItem.Estoque = new ObjetoTransferencia.Estoque();
                    entradaItem.Estoque.EstoqueID = estoque.EstoqueID;
                    entradaItem.Usuario = new ObjetoTransferencia.Usuario();
                    entradaItem.Usuario.UsuarioID = usuario.UsuarioID;

                    entradaItem.EntradaItemID = entradaItemNegocios.Cadastrar(entradaItem);

                    MessageBox.Show("Entrada de ID " + entradaItem.EntradaItemID + " cadastrado com sucesso!", "Cadastrado com sucesso!");
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro.");
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
    }
}
