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

namespace Apresentacao.TipoItem
{
    public partial class frmAlterarTipoItem : Form
    {
        ObjetoTransferencia.TipoItem tipoItem = new ObjetoTransferencia.TipoItem();
        public frmAlterarTipoItem(ObjetoTransferencia.TipoItem tItem)
        {
            InitializeComponent();
            tipoItem = tItem;

            txtDescricao.Text = tipoItem.TipoItemDescricao;
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
            try
            {
                if (txtDescricao.Text.Trim() != string.Empty)
                {
                    TipoItemNegocios tipoItemNegocios = new TipoItemNegocios();
                    tipoItem.TipoItemDescricao = txtDescricao.Text.Trim();
                    tipoItemNegocios.Alterar(tipoItem);

                    MessageBox.Show("Tipo de Item de ID " + tipoItem.TipoItemID.ToString() + " alterado com sucesso!", "Alteração realizada!");
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve algum erro, por favor, tente novamente.", "Houve algum erro.");
            }
        }
    }
}
