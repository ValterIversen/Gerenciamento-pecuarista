using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;
using System.Reflection;
using Microsoft.Reporting.WebForms;

namespace Apresentacao.Compras
{
    public partial class frmConsultaCompra : Form
    {
        private CompraCollection compras = new CompraCollection();
        public frmConsultaCompra()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));

            dgvResultados.AutoGenerateColumns = false;
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


        private void picExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            picExit.BackgroundImage = Apresentacao.Properties.Resources.exit_hover;
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.BackgroundImage = Apresentacao.Properties.Resources.exit;
        }

        private void rbData_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void rbAnimal_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void rbPessoa_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void rbUsuario_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void rbApos_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void rbAntes_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void rbEntre_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }
        private void ControleRb()
        {
            gpbAnimal.Visible = rbAnimal.Checked;
            gpbPessoa.Visible = rbPessoa.Checked;
            gpbUsuario.Visible = rbUsuario.Checked;
            gpbID.Visible = rbID.Checked;
            if (rbData.Checked)
            {
                gpbDataOpcoes.Visible = true;
                gpbDatas.Visible = true;
                if (rbApos.Checked)
                {
                    dtpData1.Enabled = true;
                    dtpData2.Enabled = false;
                }
                else if (rbAntes.Checked)
                {
                    dtpData1.Enabled = false;
                    dtpData2.Enabled = true;
                }
                else
                {
                    dtpData1.Enabled = true;
                    dtpData2.Enabled = true;
                }
            }
            else
            {
                gpbDatas.Visible = false;
                gpbDataOpcoes.Visible = false;
            }
        }

        private void btnBuscaAnimal_Click(object sender, EventArgs e)
        {
            Animal.frmConsultaAnimal frmConsultaAnimal = new Animal.frmConsultaAnimal(true);
            frmConsultaAnimal.ShowDialog();
            if(frmConsultaAnimal.animalRetorno.AnimalID != 0)
            {
                txtAnimal.Text = frmConsultaAnimal.animalRetorno.AnimalID.ToString();
            }
        }

        private void btnBuscarPessoa_Click(object sender, EventArgs e)
        {
            Pessoa.frmConsultaPessoa frmConsultaPessoa = new Pessoa.frmConsultaPessoa(true);
            frmConsultaPessoa.ShowDialog();
            if(frmConsultaPessoa.pessoaRetorno.PessoaID != 0)
            {
                txtPessoa.Text = frmConsultaPessoa.pessoaRetorno.PessoaID.ToString();
            }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            Usuario.frmConsultaUsuario frmConsultaUsuario = new Usuario.frmConsultaUsuario(true);
            frmConsultaUsuario.ShowDialog();
            if(frmConsultaUsuario.usuarioRetorno.UsuarioID != 0)
            {
                txtUsuario.Text = frmConsultaUsuario.usuarioRetorno.UsuarioID.ToString();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                CompraNegocios compraNegocios = new CompraNegocios();

                if(rbID.Checked && txtId.Text.Trim() != "")
                {
                    compras = compraNegocios.ConsultaPorID(int.Parse(txtId.Text));
                    dgvResultados.DataSource = null;
                    dgvResultados.DataSource = compras;
                }
                else if(rbAnimal.Checked && txtAnimal.Text.Trim() != "")
                {
                    compras = compraNegocios.ConsultaPorAnimal(int.Parse(txtAnimal.Text));
                    dgvResultados.DataSource = null;
                    dgvResultados.DataSource = compras;
                }
                else if(rbPessoa.Checked && txtPessoa.Text.Trim() != "")
                {
                    compras = compraNegocios.ConsultaPorPessoa(int.Parse(txtPessoa.Text));
                    dgvResultados.DataSource = null;
                    dgvResultados.DataSource = compras;
                }
                else if (rbUsuario.Checked && txtUsuario.Text.Trim() != "")
                {
                    compras = compraNegocios.ConsultaPorUsuario(int.Parse(txtUsuario.Text));
                    dgvResultados.DataSource = null;
                    dgvResultados.DataSource = compras;
                }
                else if (rbData.Checked)
                {
                    if (rbApos.Checked)
                    {
                        compras = compraNegocios.ConsultaPorDataApos(dtpData1.Value);
                        dgvResultados.DataSource = null;
                        dgvResultados.DataSource = compras;
                    }
                    else if (rbAntes.Checked)
                    {
                        compras = compraNegocios.ConsultaPorDataAntes(dtpData2.Value);
                        dgvResultados.DataSource = null;
                        dgvResultados.DataSource = compras;
                    }
                    else
                    {
                        compras = compraNegocios.ConsultaPorDataEntre(dtpData1.Value, dtpData2.Value);
                        dgvResultados.DataSource = null;
                        dgvResultados.DataSource = compras;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro.");
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void dgvResultados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < compras.Count; i++)
            {
                if(int.Parse(dgvResultados.SelectedRows[0].Cells[0].Value.ToString()) == compras[i].CompraID)
                {
                    frmAlterarCompra frmAlterarCompra = new frmAlterarCompra(compras[i]);
                    frmAlterarCompra.ShowDialog();
                    break;
                }
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

        }
    }
}
