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
using System.Reflection;

namespace Apresentacao.Estoque
{
    public partial class frmConsultaEstoque : Form
    {
        public ObjetoTransferencia.Estoque estoqueRetorno = new ObjetoTransferencia.Estoque();
        private ObjetoTransferencia.Usuario user;
        public frmConsultaEstoque(ObjetoTransferencia.Usuario usuario)
        {
            InitializeComponent();
            dgvResultado.AutoGenerateColumns = false;
            user = usuario;

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

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                EstoqueNegocios estoqueNegocios = new EstoqueNegocios();
                if (rbArmazem.Checked)
                {
                    if (txtEstoqueLocalidade.Text != string.Empty && txtEstoqueLocalidade.Text != "0")
                        dgvResultado.DataSource = estoqueNegocios.ConsultaPorEstoqueLocalidade(int.Parse(txtEstoqueLocalidade.Text));
                }
                else if (rbItem.Checked)
                {
                    if (txtItem.Text != string.Empty && txtItem.Text != "0")
                        dgvResultado.DataSource = estoqueNegocios.ConsultaPorItem(int.Parse(txtItem.Text));
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void BtnBuscarItem_Click(object sender, EventArgs e)
        {
            Item.frmConsultaItem frmConsultaItem = new Item.frmConsultaItem(true);
            frmConsultaItem.ShowDialog();
            txtItem.Text = frmConsultaItem.item.ItemID.ToString();
        }

        private void BtnBuscarEstoqueLocalidade_Click(object sender, EventArgs e)
        {
            EstoqueLocalidade.frmConsultaEstoqueLocalidade frmConsultaEstoqueLocalidade = new EstoqueLocalidade.frmConsultaEstoqueLocalidade(true, user);
            frmConsultaEstoqueLocalidade.ShowDialog();
            txtEstoqueLocalidade.Text = frmConsultaEstoqueLocalidade.estoqueLocalidadeIDRetorno.ToString();
        }

        private void DgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EstoqueNegocios estoqueNegocios = new EstoqueNegocios();
                estoqueRetorno = estoqueNegocios.ConsultaPorID(int.Parse(dgvResultado.SelectedRows[0].Cells[0].Value.ToString()));
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro.");
                estoqueRetorno = null;
                Close();
            }
        }

        private void DgvResultado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvResultado.Rows[e.RowIndex].DataBoundItem != null) && (dgvResultado.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvResultado.Rows[e.RowIndex].DataBoundItem, dgvResultado.Columns[e.ColumnIndex].DataPropertyName);
            }
        }
        private string BindProperty(object property, string propertyName)
        {
            string retValue = "";
            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;
                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();
                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(
                          propertyInfo.GetValue(property, null),
                          propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;
                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }
            return retValue;
        }

        private void RbArmazem_CheckedChanged(object sender, EventArgs e)
        {
            gpbEstoqueLocalidade.Visible = true;
            gpbItem.Visible = false;
        }

        private void RbItem_CheckedChanged(object sender, EventArgs e)
        {
            gpbItem.Visible = true;
            gpbEstoqueLocalidade.Visible = false;
        }

        private void panelInside_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
