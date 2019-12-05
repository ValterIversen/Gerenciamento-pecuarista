using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Apresentacao.Pessoa
{
    public partial class frmConsultaPessoa : Form
    {
        private bool retorno;
        private ObjetoTransferencia.PessoaCollection pessoas = new ObjetoTransferencia.PessoaCollection();
        public ObjetoTransferencia.Pessoa pessoaRetorno = new ObjetoTransferencia.Pessoa();
        public frmConsultaPessoa(bool retornoParametro)
        {
            InitializeComponent();

            retorno = retornoParametro;
            dgvResultado.AutoGenerateColumns = false;

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

        private void RbCPF_CheckedChanged(object sender, EventArgs e)
        {
            ControleRadioButton();
        }

        private void RbNome_CheckedChanged(object sender, EventArgs e)
        {
            ControleRadioButton();
        }

        private void RbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            ControleRadioButton();
        }

        private void RbRazaoSocial_CheckedChanged(object sender, EventArgs e)
        {
            ControleRadioButton();
        }

        private void RbNomeFicticio_CheckedChanged(object sender, EventArgs e)
        {
            ControleRadioButton();
        }

        private void ControleRadioButton()
        {
            txtCPF.Enabled = rbCPF.Checked;
            txtNome.Enabled = rbNome.Checked;
            txtCNPJ.Enabled = rbCNPJ.Checked;
            txtRazaoSocial.Enabled = rbRazaoSocial.Checked;
            txtNomeFicticio.Enabled = rbNomeFicticio.Checked;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbCPF.Checked)
                {
                    if (!txtCPF.MaskCompleted)
                        MessageBox.Show("Por favor, preencha todo o campo de CPF.", "Preencha o campo CPF.");
                    else
                    {
                        PessoaFisicaNegocios pessoaFisicaNegocios = new PessoaFisicaNegocios();

                        pessoas = pessoaFisicaNegocios.ConsultaPorCPF(txtCPF.Text);
                        dgvResultado.DataSource = pessoas;
                    }
                }
                else if (rbNome.Checked)
                {
                    PessoaFisicaNegocios pessoaFisicaNegocios = new PessoaFisicaNegocios();

                    pessoas = pessoaFisicaNegocios.ConsultaPorNome(txtNome.Text);
                    dgvResultado.DataSource = pessoas;
                }
                else if (rbCNPJ.Checked)
                {
                    if (!txtCNPJ.MaskCompleted)
                        MessageBox.Show("Por favor, preencha todo o campo de CNPJ.", "Preencha o campo CNPJ.");
                    else
                    {
                        PessoaJuridicaNegocios pessoaJuridicaNegocios = new PessoaJuridicaNegocios();

                        pessoas = pessoaJuridicaNegocios.ConsultaPorCNPJ(txtCNPJ.Text);
                        dgvResultado.DataSource = pessoas;
                    }
                }
                else if (rbRazaoSocial.Checked)
                {
                    PessoaJuridicaNegocios pessoaJuridicaNegocios = new PessoaJuridicaNegocios();

                    pessoas = pessoaJuridicaNegocios.ConsultaPorRazaoSocial(txtRazaoSocial.Text);
                    dgvResultado.DataSource = pessoas;
                }
                else if (rbNomeFicticio.Checked)
                {
                    PessoaJuridicaNegocios pessoaJuridicaNegocios = new PessoaJuridicaNegocios();

                    pessoas = pessoaJuridicaNegocios.ConsultaPorNomeFicticio(txtNomeFicticio.Text);
                    dgvResultado.DataSource = pessoas;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve algum erro ao realizar a consulta, por favor tente novamente.\nCaso o erro persista, consulte seu suporte", "Houve algum erro durante a consulta.");
            }
        }

        private void DgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                PessoaNegocios pessoaNegocios = new PessoaNegocios();
                if (retorno)
                {
                    pessoaRetorno = pessoaNegocios.ConsultaPorID(int.Parse(dgvResultado.SelectedRows[0].Cells[0].Value.ToString()))[0];
                    Close();
                }
                else
                {
                    pessoaRetorno = pessoaNegocios.ConsultaPorID(int.Parse(dgvResultado.SelectedRows[0].Cells[0].Value.ToString()))[0];
                    frmAlterarPessoa frmAlterarPessoa = new frmAlterarPessoa(pessoaRetorno);
                    frmAlterarPessoa.ShowDialog();
                    BtnConsultar_Click(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Tente novamente.");
            }
        }

        private void dgvResultado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
    }
}
