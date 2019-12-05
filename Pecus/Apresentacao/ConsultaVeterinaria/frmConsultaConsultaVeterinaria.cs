using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WebForms;
using Negocios;
using ObjetoTransferencia;

namespace Apresentacao.ConsultaVeterinaria
{
    public partial class frmConsultaConsultaVeterinaria : Form
    {
        private ObjetoTransferencia.ConsultaVeterinariaCollection consultas = new ConsultaVeterinariaCollection();
        public frmConsultaConsultaVeterinaria()
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

        private void rbVeterinario_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void rbDescricao_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }
        private void ControleRb()
        {
            gpbDataOpcoes.Visible = rbData.Checked;
            gpbAnimal.Visible = rbAnimal.Checked;
            gpbVeterinario.Visible = rbVeterinario.Checked;
            gpbID.Visible = rbID.Checked;
            gpbDescricao.Visible = rbDescricao.Checked;

            if (rbData.Checked)
            {
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
            }
        }

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < consultas.Count; i++)
            {
                if(consultas[i].ConsultaVeterinariaID == int.Parse(dgvResultados.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    frmAlterarConsultaVeterinaria frmAlterarConsultaVeterinaria = new frmAlterarConsultaVeterinaria(consultas[i]);
                    frmAlterarConsultaVeterinaria.ShowDialog();
                    btnConsultar_Click(sender, e);
                }
            }
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaVeterinariaNegocios consultaVeterinariaNegocios = new ConsultaVeterinariaNegocios();
                if (rbAnimal.Checked)
                {
                    if(txtAnimal.Text != "" && txtAnimal.Text != "0")
                    {
                        consultas = consultaVeterinariaNegocios.ConsultaPorAnimal(int.Parse(txtAnimal.Text));
                        dgvResultados.DataSource = null;
                        dgvResultados.DataSource = consultas;
                    }
                }
                else if (rbVeterinario.Checked)
                {
                    if (txtVeterinario.Text != "" && txtVeterinario.Text != "0")
                    {
                        consultas = consultaVeterinariaNegocios.ConsultaPorVeterinario(int.Parse(txtVeterinario.Text));
                        dgvResultados.DataSource = null;
                        dgvResultados.DataSource = consultas;
                    }
                }
                else if (rbID.Checked)
                {
                    if (txtID.Text != "" && txtID.Text != "0")
                    {
                        consultas = consultaVeterinariaNegocios.ConsultaPorID(int.Parse(txtID.Text));
                        dgvResultados.DataSource = null;
                        dgvResultados.DataSource = consultas;
                    }
                }
                else if (rbDescricao.Checked)
                {
                    consultas = consultaVeterinariaNegocios.ConsultaPorDescricao(txtDescricao.Text);
                    dgvResultados.DataSource = null;
                    dgvResultados.DataSource = consultas;
                }
                else if (rbData.Checked)
                {
                    if (rbApos.Checked)
                    {
                        consultas = consultaVeterinariaNegocios.ConsultaPorDataApos(dtpData1.Value);
                        dgvResultados.DataSource = null;
                        dgvResultados.DataSource = consultas;
                    }
                    else if (rbAntes.Checked)
                    {
                        consultas = consultaVeterinariaNegocios.ConsultaPorDataAntes(dtpData2.Value);
                        dgvResultados.DataSource = null;
                        dgvResultados.DataSource = consultas;
                    }
                    else
                    {
                        consultas = consultaVeterinariaNegocios.ConsultaPorDataEntre(dtpData1.Value, dtpData2.Value);
                        dgvResultados.DataSource = null;
                        dgvResultados.DataSource = consultas;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro.");
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
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

        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            Animal.frmConsultaAnimal frmConsultaAnimal = new Animal.frmConsultaAnimal(true);
            frmConsultaAnimal.ShowDialog();
            if(frmConsultaAnimal.animalRetorno.AnimalID != 0)
            {
                txtAnimal.Text = frmConsultaAnimal.animalRetorno.AnimalID.ToString();
            }
        }

        private void btnBuscarVeterinario_Click(object sender, EventArgs e)
        {
            Veterinario.frmConsultaVeterinario frmConsultaVeterinario = new Veterinario.frmConsultaVeterinario(true);
            frmConsultaVeterinario.ShowDialog();
            if(frmConsultaVeterinario.veterinario.VeterinarioID != 0)
            {
                txtVeterinario.Text = frmConsultaVeterinario.veterinario.VeterinarioID.ToString();
            }
        }

    }
}
