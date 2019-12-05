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

namespace Apresentacao.Item
{
    public partial class frmCadastroItem : Form
    {
        public frmCadastroItem()
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

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtDescricao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor, informe a descrição.", "Informe a descrição.");
            }
            else
            {
                try
                {
                    ItemNegocios itemNegocios = new ItemNegocios();
                        ObjetoTransferencia.Item item = new ObjetoTransferencia.Item();
                        item.TipoItem = new ObjetoTransferencia.TipoItem();

                        item.ItemDescricao = txtDescricao.Text.Trim();
                        item.TipoItem.TipoItemID = Convert.ToInt32(cbbTipoItem.SelectedValue);
                    if (itemNegocios.ValidarExist(0, txtDescricao.Text.Trim()).Count > 0)
                        MessageBox.Show("Já existe um item com esta descrição cadastrado.", "Duplicação de item.");
                    else
                    {
                        MessageBox.Show("Item de ID: " + itemNegocios.Cadastrar(item) + " cadastrado com sucesso!");
                        Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um erro no cadastro do Item, por favor, contate seu suporte.\nObservações: " + ex.Message);
                }
            }
        }

        private void FrmCadastroItem_Load(object sender, EventArgs e)
        {
            TipoItemNegocios tipoItemNegocios = new TipoItemNegocios();
            cbbTipoItem.ValueMember = "TipoItemID";
            cbbTipoItem.DisplayMember = "TipoItemDescricao";
            TipoItemCollection tipoItems = tipoItemNegocios.ConsultaTodos();
            if (tipoItems.Count > 0)
                cbbTipoItem.DataSource = tipoItems;
            else
            {
                MessageBox.Show("Por favor, realize o cadastro dos tipos de itens.", "Cadastre tipos de itens.");
                Close();
            }   
        }
    }
}
