using Microsoft.Reporting.WebForms;
using Negocios;
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

namespace Apresentacao.Variados.Reports.FormsReport
{
    public partial class frmReportVenda : Form
    {
        ObjetoTransferencia.Usuario usuario = new ObjetoTransferencia.Usuario();
        VendaCollection vendas = new VendaCollection();
        public frmReportVenda(ObjetoTransferencia.Usuario usuarioP)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));
            usuario = usuarioP;
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
            gpbPessoa.Visible = rbPessoa.Checked;
            gpbUsuario.Visible = rbUsuario.Checked;
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

        private void btnBuscarPessoa_Click(object sender, EventArgs e)
        {
            Pessoa.frmConsultaPessoa frmConsultaPessoa = new Pessoa.frmConsultaPessoa(true);
            frmConsultaPessoa.ShowDialog();
            if (frmConsultaPessoa.pessoaRetorno.PessoaID != 0)
            {
                txtPessoa.Text = frmConsultaPessoa.pessoaRetorno.PessoaID.ToString();
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
                            if (pessoa.PessoaFisica.PessoaFisicaNome != "")
                                listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório de pessoa física - " + pessoa.PessoaFisica.PessoaFisicaNome + "."));
                            else
                                listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório de pessoa jurídica - " + pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio + "."));
                            listReportParameter.Add(new ReportParameter("UsuarioEmissor", usuario.UsuarioNome));
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
                            listReportParameter.Add(new ReportParameter("UsuarioEmissor", usuario.UsuarioNome));
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
                        listReportParameter.Add(new ReportParameter("UsuarioEmissor", usuario.UsuarioNome));
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
                        listReportParameter.Add(new ReportParameter("UsuarioEmissor", usuario.UsuarioNome));
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
                        listReportParameter.Add(new ReportParameter("UsuarioEmissor", usuario.UsuarioNome));
                        listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));

                        List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                        reportDataSources.Add(new ReportDataSource("DataSetVendas", vendas));

                        Variados.Reports.ReportGenerator report = new Variados.Reports.ReportGenerator();
                        report.CallReport(Path, reportDataSources, listReportParameter);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
