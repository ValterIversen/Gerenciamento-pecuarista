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

namespace Apresentacao.Piquete
{
    public partial class frmConsultaPiquete : Form
    {
        private bool retorno;
        public ObjetoTransferencia.Piquete piquete = new ObjetoTransferencia.Piquete();
        public frmConsultaPiquete(bool retornop)
        {
            InitializeComponent();
            retorno = retornop;
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

        private void RbPasto_CheckedChanged(object sender, EventArgs e)
        {
            gpbPasto.Visible = true;
            gpbID.Visible = false;
        }

        private void RbID_CheckedChanged(object sender, EventArgs e)
        {
            gpbPasto.Visible = false;
            gpbID.Visible = true;
        }

        private void BtnBuscarPasto_Click(object sender, EventArgs e)
        {
            try
            {
                Pasto.frmConsultaPasto frmConsultaPasto = new Pasto.frmConsultaPasto(true, new ObjetoTransferencia.Usuario() { TipoUsuario = new TipoUsuario() });
                frmConsultaPasto.ShowDialog();
                txtPasto.Text = frmConsultaPasto.pastoRetorno.PastoID.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro ao abrir o formulário, tente novamente.", "Houve um erro.");
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                PiqueteNegocios piqueteNegocios = new PiqueteNegocios();
                if (rbID.Checked)
                {
                    if (txtID.Text == "")
                        MessageBox.Show("Por favor, informe o ID.", "Informe o ID.");
                    else
                    {
                        dgvResultados.DataSource = piqueteNegocios.ConsultarPorID(int.Parse(txtID.Text));
                    }
                }
                else
                {
                    if (txtPasto.Text == "")
                        MessageBox.Show("Por favor, informe o Pasto.", "Informe o Pasto.");
                    else
                    {
                        dgvResultados.DataSource = piqueteNegocios.ConsultarPorPasto(int.Parse(txtPasto.Text));
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Tente novamente.");
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

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            //if(txtQuantidade.Text.Length == txtQuantidade.Text.IndexOf(',') + 3 && txtQuantidade.Text.IndexOf(',') != null)
            //{
            //    txtQuantidade.Text = txtQuantidade.Text.Replace(",", "");

            //    txtQuantidade.Text = txtQuantidade.Text.Substring(0, txtQuantidade.Text.Length - 3) + "," + txtQuantidade.Text.Substring(txtQuantidade.Text.Length - 3, txtQuantidade.Text.Length);
            //}
        }

        private void DgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PiqueteNegocios piqueteNegocios = new PiqueteNegocios();
                piquete = piqueteNegocios.ConsultarPorID(int.Parse(dgvResultados.SelectedRows[0].Cells[0].Value.ToString()))[0];
                if(retorno)
                    Close();
                else
                {
                    frmAlterarPiquete frmAlterarPiquete = new frmAlterarPiquete(piquete);
                    frmAlterarPiquete.ShowDialog();
                    BtnConsultar_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Tente novamente.");
            }
        }
    }
}
