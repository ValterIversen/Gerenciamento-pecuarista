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
using System.Reflection;

namespace Apresentacao.Item
{
    public partial class frmConsultaItem : Form
    {
        private bool retorno;
        public ObjetoTransferencia.Item item = new ObjetoTransferencia.Item();
        public frmConsultaItem(bool ret)
        {
            InitializeComponent();
            retorno = ret;
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

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ItemNegocios itemNegocios = new ItemNegocios();
                if (rbDescricao.Checked)
                {
                    dgvResultados.DataSource = itemNegocios.ConsultaPorDescricao(txtDescricao.Text);
                }
                else if(rbID.Checked && txtID.Text.Trim() != string.Empty)
                {
                    dgvResultados.DataSource = itemNegocios.ConsultaPorID(Convert.ToInt32(txtID.Text));
                }
                else if (rbTipo.Checked)
                {
                    dgvResultados.DataSource = itemNegocios.ConsultaPorTipoItem(Convert.ToInt32(cbbTipoItem.SelectedValue));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro no cadastro de Tipo de Item, por favor, contate seu suporte.\nObservações: " + ex.Message);
            }
        }

        private void RbDescricao_CheckedChanged(object sender, EventArgs e)
        {
            ControleRB();
        }

        private void RbTipo_CheckedChanged(object sender, EventArgs e)
        {
            ControleRB();
        }

        private void RbID_CheckedChanged(object sender, EventArgs e)
        {
            ControleRB();
        }
        private void ControleRB()
        {
            gpbDescricao.Visible = rbDescricao.Checked;
            gpbID.Visible = rbID.Checked;
            gpbTipoItem.Visible = rbTipo.Checked;
        }

        private void FrmConsultaItem_Load(object sender, EventArgs e)
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

        private void DgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemNegocios itemNegocios = new ItemNegocios();
            item = itemNegocios.ConsultaPorID(Convert.ToInt32(dgvResultados.SelectedRows[0].Cells[0].Value))[0];

            if (!retorno)
            {
                frmAlterarItem frmAlterarItem = new frmAlterarItem(item);
                frmAlterarItem.ShowDialog();
            }
            else
                Close();


            if (rbDescricao.Checked)
            {
                dgvResultados.DataSource = itemNegocios.ConsultaPorDescricao(txtDescricao.Text);
            }
            else if (rbID.Checked && txtID.Text.Trim() != string.Empty)
            {
                dgvResultados.DataSource = itemNegocios.ConsultaPorID(Convert.ToInt32(txtID.Text));
            }
            else if (rbTipo.Checked)
            {
                dgvResultados.DataSource = itemNegocios.ConsultaPorTipoItem(Convert.ToInt32(cbbTipoItem.SelectedValue));
            }
        }

        private void DgvResultados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvResultados.Rows[e.RowIndex].DataBoundItem != null) && (dgvResultados.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvResultados.Rows[e.RowIndex].DataBoundItem, dgvResultados.Columns[e.ColumnIndex].DataPropertyName);
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
    }
}
