using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;
using System.Reflection;

namespace Apresentacao.Animal
{
    public partial class frmConsultaAnimal : Form
    {
        private bool retorno;
        public ObjetoTransferencia.Animal animalRetorno { get; set; }
        private ObjetoTransferencia.Animal animal = new ObjetoTransferencia.Animal();
        private AnimalCollection animais = new AnimalCollection();
        public frmConsultaAnimal(bool retornoP)
        {
            InitializeComponent();

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));
            retorno = retornoP;
            dgvResultados.AutoGenerateColumns = false;
            animalRetorno = new ObjetoTransferencia.Animal();
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

        private void PicExit_MouseEnter(object sender, EventArgs e)
        {
            picExit.BackgroundImage = Apresentacao.Properties.Resources.exit_hover;
        }

        private void PicExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.BackgroundImage = Apresentacao.Properties.Resources.exit;
        }

        private void PicExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            ControleRB();
        }

        private void rbDescricao_CheckedChanged(object sender, EventArgs e)
        {
            ControleRB();
        }

        private void rbIdentificacao_CheckedChanged(object sender, EventArgs e)
        {
            ControleRB();
        }

        private void rbPiquete_CheckedChanged(object sender, EventArgs e)
        {
            ControleRB();
        }

        private void rbRaca_CheckedChanged(object sender, EventArgs e)
        {
            ControleRB();
        }
        private void ControleRB()
        {
            gpbID.Visible = rbID.Checked;
            gpbDescricao.Visible = rbDescricao.Checked;
            gpbIdentificador.Visible = rbIdentificacao.Checked;
            gpbPiquete.Visible = rbPiquete.Checked;
            gpbRaca.Visible = rbRaca.Checked;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                AnimalNegocios animalNegocios = new AnimalNegocios();
                if (rbID.Checked)
                {
                    if (txtID.Text.Trim() != string.Empty)
                    {
                        animais = animalNegocios.ConsultaPorID(int.Parse(txtID.Text));
                        dgvResultados.DataSource = null;
                        dgvResultados.DataSource = animais;
                    }

                }
                else if (rbDescricao.Checked)
                {
                    animais = animalNegocios.ConsultaPorDescricao(txtDescricao.Text);
                    dgvResultados.DataSource = null;
                    dgvResultados.DataSource = animais;
                }
                else if (rbIdentificacao.Checked)
                {
                    animais = animalNegocios.ConsultaPorIdentificador(txtIdentificador.Text);
                    dgvResultados.DataSource = null;
                    dgvResultados.DataSource = animais;
                }
                else if (rbPiquete.Checked)
                {
                    if (txtPiquete.Text.Trim() != "" && txtPiquete.Text.Trim() != "0")
                    {
                        animais = animalNegocios.ConsultaPorPiquete(int.Parse(txtPiquete.Text));
                        dgvResultados.DataSource = null;
                        dgvResultados.DataSource = animais;
                    }
                }
                else if (rbRaca.Checked)
                {
                    animais = animalNegocios.ConsultaPorRaca(int.Parse(cbbRaca.SelectedValue.ToString()));
                    dgvResultados.DataSource  = null;
                    dgvResultados.DataSource = animais;
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

        private void DgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AnimalNegocios animalNegocios = new AnimalNegocios();
                animal = animalNegocios.ConsultaPorID(int.Parse(dgvResultados.SelectedRows[0].Cells[0].Value.ToString()))[0];
                if (retorno)
                {
                    animalRetorno = animal;
                    Close();
                }
                else
                {
                    frmAlterarAnimal frmAlterarAnimal = new frmAlterarAnimal(animal);
                    frmAlterarAnimal.ShowDialog();

                    btnConsultar_Click(sender, e);
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
