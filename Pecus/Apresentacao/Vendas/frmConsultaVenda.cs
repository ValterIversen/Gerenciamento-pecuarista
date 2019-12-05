using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WebForms;
using Negocios;
using ObjetoTransferencia;

namespace Apresentacao.Vendas
{
    public partial class frmConsultaVenda : Form
    {
        VendaCollection vendas = new VendaCollection();
        public frmConsultaVenda()
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

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            Usuario.frmConsultaUsuario frmConsultaUsuario = new Usuario.frmConsultaUsuario(true);
            frmConsultaUsuario.ShowDialog();
            if (frmConsultaUsuario.usuarioRetorno.UsuarioID != 0)
            {
                txtUsuario.Text = frmConsultaUsuario.usuarioRetorno.UsuarioID.ToString();
            }
        }

        private void btnBuscarPessoa_Click(object sender, EventArgs e)
        {
            Pessoa.frmConsultaPessoa frmConsultaPessoa = new Pessoa.frmConsultaPessoa(true);
            frmConsultaPessoa.ShowDialog();
            if (frmConsultaPessoa.pessoaRetorno.PessoaID != 0)
            {
                txtPessoa.Text = frmConsultaPessoa.pessoaRetorno.PessoaID.ToString();
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void btnBuscaAnimal_Click(object sender, EventArgs e)
        {
            Animal.frmConsultaAnimal frmConsultaAnimal = new Animal.frmConsultaAnimal(true);
            frmConsultaAnimal.ShowDialog();
            if (frmConsultaAnimal.animalRetorno.AnimalID != 0)
            {
                txtAnimal.Text = frmConsultaAnimal.animalRetorno.AnimalID.ToString();
            }
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

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void rbUsuario_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                VendaNegocios vendaNegocios = new VendaNegocios();

                if (rbID.Checked && txtId.Text.Trim() != "")
                {
                    vendas = vendaNegocios.ConsultaPorID(int.Parse(txtId.Text));
                    dgvResultados.DataSource = null;
                    dgvResultados.DataSource = vendas;
                }
                else if (rbAnimal.Checked && txtAnimal.Text.Trim() != "")
                {
                    vendas = vendaNegocios.ConsultaPorAnimal(int.Parse(txtAnimal.Text));
                    dgvResultados.DataSource = null;
                    dgvResultados.DataSource = vendas;
                }
                else if (rbPessoa.Checked && txtPessoa.Text.Trim() != "")
                {
                    vendas = vendaNegocios.ConsultaPorPessoa(int.Parse(txtPessoa.Text));
                    dgvResultados.DataSource = null;
                    dgvResultados.DataSource = vendas;
                }
                else if (rbUsuario.Checked && txtUsuario.Text.Trim() != "")
                {
                    vendas = vendaNegocios.ConsultaPorUsuario(int.Parse(txtUsuario.Text));
                    dgvResultados.DataSource = null;
                    dgvResultados.DataSource = vendas;
                }
                else if (rbData.Checked)
                {
                    if (rbApos.Checked)
                    {
                        vendas = vendaNegocios.ConsultaPorDataApos(dtpData1.Value);
                        dgvResultados.DataSource = null;
                        dgvResultados.DataSource = vendas;
                    }
                    else if (rbAntes.Checked)
                    {
                        vendas = vendaNegocios.ConsultaPorDataAntes(dtpData2.Value);
                        dgvResultados.DataSource = null;
                        dgvResultados.DataSource = vendas;
                    }
                    else
                    {
                        vendas = vendaNegocios.ConsultaPorDataEntre(dtpData1.Value, dtpData2.Value);
                        dgvResultados.DataSource = null;
                        dgvResultados.DataSource = vendas;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro.");
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

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < vendas.Count; i++)
            {
                if(int.Parse(dgvResultados.SelectedRows[0].Cells[0].Value.ToString()) == vendas[i].VendaID)
                {
                    frmAlterarVenda frmAlterarVenda = new frmAlterarVenda(vendas[i]);
                    frmAlterarVenda.ShowDialog();
                    break;
                }
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                VendaNegocios vendaNegocios = new VendaNegocios();
                string Path = "VendasReport.rdlc";

                if (rbPessoa.Checked)
                {
                    int PessoaID = 0;
                    if (int.TryParse(txtPessoa.Text, out PessoaID))
                    {
                        if (PessoaID != 0)
                        {
                            PessoaNegocios pessoaNegocios = new PessoaNegocios();
                            ObjetoTransferencia.Pessoa pessoa = new ObjetoTransferencia.Pessoa();
                            pessoa = pessoaNegocios.ConsultaPorID(PessoaID)[0];

                            vendas = vendaNegocios.ConsultaPorPessoa(PessoaID);

                            List<ReportParameter> listReportParameter = new List<ReportParameter>();
                            if(pessoa.PessoaFisica.PessoaFisicaNome != "")
                                listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório de pessoa física - " + pessoa.PessoaFisica.PessoaFisicaNome + "."));
                            else
                                listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório de pessoa jurídica - " + pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio + "."));
                            listReportParameter.Add(new ReportParameter("UsuarioEmissor", "Teste."));
                            listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));

                            List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                            reportDataSources.Add(new ReportDataSource("DataSetVendas", vendas));

                            Variados.Reports.ReportGenerator report = new Variados.Reports.ReportGenerator();
                            report.CallReport(Path, reportDataSources, listReportParameter);
                        }
                    }
                }
                else if (rbUsuario.Checked)
                {
                    int UsuarioID = 0;
                    if (int.TryParse(txtUsuario.Text, out UsuarioID))
                    {
                        if (UsuarioID != 0)
                        {
                            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
                            ObjetoTransferencia.Usuario usuario = new ObjetoTransferencia.Usuario();
                            usuario = usuarioNegocios.ConsultaPorID(UsuarioID);

                            vendas = vendaNegocios.ConsultaPorUsuario(UsuarioID);

                            List<ReportParameter> listReportParameter = new List<ReportParameter>();

                            listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório de usuário - " + usuario.UsuarioNome + "."));
                            listReportParameter.Add(new ReportParameter("UsuarioEmissor", "Teste."));
                            listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));

                            List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                            reportDataSources.Add(new ReportDataSource("DataSetVendas", vendas));

                            Variados.Reports.ReportGenerator report = new Variados.Reports.ReportGenerator();
                            report.CallReport(Path, reportDataSources, listReportParameter);
                        }
                    }
                }
                else if (rbData.Checked)
                {
                    if (rbAntes.Checked)
                    {
                        vendas = vendaNegocios.ConsultaPorDataAntes(dtpData2.Value);

                        List<ReportParameter> listReportParameter = new List<ReportParameter>();

                        listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório antes da data " + dtpData2.Value.ToString("dd/MM/yyy") + "."));
                        listReportParameter.Add(new ReportParameter("UsuarioEmissor", "Teste."));
                        listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));

                        List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                        reportDataSources.Add(new ReportDataSource("DataSetVendas", vendas));

                        Variados.Reports.ReportGenerator report = new Variados.Reports.ReportGenerator();
                        report.CallReport(Path, reportDataSources, listReportParameter);
                    }
                    else if (rbApos.Checked)
                    {
                        vendas = vendaNegocios.ConsultaPorDataApos(dtpData1.Value);

                        List<ReportParameter> listReportParameter = new List<ReportParameter>();

                        listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório após a data " + dtpData1.Value.ToString("dd/MM/yyy") + "."));
                        listReportParameter.Add(new ReportParameter("UsuarioEmissor", "Teste."));
                        listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));

                        List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                        reportDataSources.Add(new ReportDataSource("DataSetVendas", vendas));

                        Variados.Reports.ReportGenerator report = new Variados.Reports.ReportGenerator();
                        report.CallReport(Path, reportDataSources, listReportParameter);
                    }
                    else if (rbEntre.Checked)
                    {
                        vendas = vendaNegocios.ConsultaPorDataEntre(dtpData1.Value, dtpData2.Value);

                        List<ReportParameter> listReportParameter = new List<ReportParameter>();

                        listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório entre as datas " + dtpData1.Value.ToString("dd/MM/yyy") + " e " + dtpData2.Value.ToString("dd/MM/yyy") + "."));
                        listReportParameter.Add(new ReportParameter("UsuarioEmissor", "Teste."));
                        listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));

                        List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                        reportDataSources.Add(new ReportDataSource("DataSetVendas", vendas));

                        Variados.Reports.ReportGenerator report = new Variados.Reports.ReportGenerator();
                        report.CallReport(Path, reportDataSources, listReportParameter);
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
