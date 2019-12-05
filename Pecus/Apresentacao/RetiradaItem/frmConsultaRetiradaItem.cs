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
using System.Reflection;


namespace Apresentacao.RetiradaItem
{
    public partial class frmConsultaRetiradaItem : Form
    {
        public frmConsultaRetiradaItem()
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

        private void ControleRb()
        {
            if (rbData.Checked)
            {
                gpbDataOpcoes.Visible = true;
                gpbDatas.Visible = true;
                gpbDescricao.Visible = false;
                gpbID.Visible = false;
                txtData1.Text = "";
                txtData2.Text = "";
                if (rbEntre.Checked)
                    txtData2.Enabled = true;

                else
                    txtData2.Enabled = false;
            }
            else if (rbDescricao.Checked)
            {
                txtDescricao.Text = "";
                gpbDescricao.Visible = true;
                gpbDataOpcoes.Visible = false;
                gpbDatas.Visible = false;
                gpbID.Visible = false;
            }
            else if (rbID.Checked)
            {
                txtID.Text = "";
                gpbID.Visible = true;
                gpbDescricao.Visible = false;
                gpbDataOpcoes.Visible = false;
                gpbDatas.Visible = false;
            }
        }

        private void RbData_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void RbID_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void RbDescricao_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void RbApos_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void RbAntes_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void RbEntre_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                RetiradaItemNegocios retiradaItemNegocios = new RetiradaItemNegocios();

                if (rbData.Checked)
                {
                    if (rbEntre.Checked)
                    {
                        DateTime data1, data2;
                        if (DateTime.TryParse(txtData1.Text, out data1) && DateTime.TryParse(txtData2.Text, out data2))
                        {
                            dgvResultados.DataSource = retiradaItemNegocios.ConsultaPorDataEntre(data1, data2);
                        }
                        else
                        {
                            MessageBox.Show("Por favor, preencha os campos de data corretamente.\nInforme primeiramente a data inicial e depois a data final.", "Informe corretamente as datas.");
                        }
                    }
                    else if (rbApos.Checked)
                    {
                        DateTime data;
                        if (DateTime.TryParse(txtData1.Text, out data))
                        {
                            dgvResultados.DataSource = retiradaItemNegocios.ConsultaPorDataApos(data);
                        }
                        else
                        {
                            MessageBox.Show("Por favor, preencha o campo de data corretamente.", "Informe corretamente a data.");
                        }
                    }
                    else if (rbAntes.Checked)
                    {
                        DateTime data;
                        if (DateTime.TryParse(txtData1.Text, out data))
                        {
                            dgvResultados.DataSource = retiradaItemNegocios.ConsultaPorDataAntes(data);
                        }
                        else
                        {
                            MessageBox.Show("Por favor, preencha o campo de data corretamente.", "Informe corretamente a data.");
                        }
                    }
                }
                else if (rbDescricao.Checked)
                {
                    dgvResultados.DataSource = retiradaItemNegocios.ConsultaPorDescricao(txtDescricao.Text);
                }
                else if (rbID.Checked)
                {
                    if (txtID.Text.Trim() != "")
                    {
                        dgvResultados.DataSource = retiradaItemNegocios.ConsultaPorID(int.Parse(txtID.Text));
                    }
                    else
                    {
                        MessageBox.Show("Por favor, informe o ID.", "Informe o ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Tente novamente.");
            }
        }

        private void DgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RetiradaItemNegocios retiradaItemNegocios = new RetiradaItemNegocios();
                ObjetoTransferencia.RetiradaItem retiradaitem = new ObjetoTransferencia.RetiradaItem();
                retiradaitem = retiradaItemNegocios.ConsultaPorID(int.Parse(dgvResultados.SelectedRows[0].Cells[0].Value.ToString()));

                frmAlterarRetiradaItem frmAlterarRetiradaItem = new frmAlterarRetiradaItem(retiradaitem);
                frmAlterarRetiradaItem.ShowDialog();

                BtnConsultar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Tente novamente.");
            }
        }
    }
}
