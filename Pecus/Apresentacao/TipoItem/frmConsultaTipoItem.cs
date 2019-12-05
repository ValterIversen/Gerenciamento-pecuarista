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
    public partial class frmConsultaTipoItem : Form
    {
        public frmConsultaTipoItem()
        {
            InitializeComponent();
            dgvResultados.AutoGenerateColumns = false;
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

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                TipoItemNegocios tipoItemNegocios = new TipoItemNegocios();
                if (rbID.Checked && txtID.Text.Trim() != string.Empty)
                {
                    dgvResultados.DataSource = tipoItemNegocios.ConsultaPorID(Convert.ToInt32(txtID.Text));
                }
                else if (rbDescricao.Checked)
                {
                    dgvResultados.DataSource = tipoItemNegocios.ConsultaPorDescricao(txtDescricao.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve algum erro, por favor, tente novamente.", "Houve algum erro.");
            }
        }

        private void DgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ObjetoTransferencia.TipoItem tipoItem = new ObjetoTransferencia.TipoItem();

                tipoItem.TipoItemID = Convert.ToInt32(dgvResultados.SelectedRows[0].Cells[0].Value.ToString());
                tipoItem.TipoItemDescricao = dgvResultados.SelectedRows[0].Cells[1].Value.ToString();

                frmAlterarTipoItem frmAlterarTipoItem = new frmAlterarTipoItem(tipoItem);
                frmAlterarTipoItem.ShowDialog();

                TipoItemNegocios tipoItemNegocios = new TipoItemNegocios();
                if (rbID.Checked && txtID.Text.Trim() != string.Empty)
                {
                    dgvResultados.DataSource = tipoItemNegocios.ConsultaPorID(Convert.ToInt32(txtID.Text));
                }
                else if (rbDescricao.Checked)
                {
                    dgvResultados.DataSource = tipoItemNegocios.ConsultaPorDescricao(txtDescricao.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve algum erro, por favor, tente novamente.", "Houve algum erro.");
            }
        }

        private void RbID_CheckedChanged(object sender, EventArgs e)
        {
            gpbDescricao.Visible = false;
            gpbID.Visible = true;
        }

        private void RbDescricao_CheckedChanged(object sender, EventArgs e)
        {
            gpbDescricao.Visible = true;
            gpbID.Visible = false;
        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
    }
}
