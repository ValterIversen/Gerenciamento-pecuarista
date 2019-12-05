using Microsoft.Reporting.WebForms;
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

using Negocios;
using ObjetoTransferencia;

namespace Apresentacao.Variados.Reports.FormsReport
{
    public partial class frmReportRetiradaItem : Form
    {
        ObjetoTransferencia.Usuario usuario = new ObjetoTransferencia.Usuario();
        public frmReportRetiradaItem(ObjetoTransferencia.Usuario usuarioP)
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

        private void rbApos_CheckedChanged(object sender, EventArgs e)
        {
            txtData1.Enabled = true;
            txtData2.Enabled = false;
        }

        private void rbAntes_CheckedChanged(object sender, EventArgs e)
        {
            txtData1.Enabled = false;
            txtData2.Enabled = true;
        }

        private void rbEntre_CheckedChanged(object sender, EventArgs e)
        {
            txtData1.Enabled = true;
            txtData2.Enabled = true;
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

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                RetiradaItemNegocios retiradaItemNegocios = new RetiradaItemNegocios();
                RetiradaItemCollection retiradasItem = new RetiradaItemCollection();
                string Path = "RetiradaItemReport.rdlc";
                if (rbAntes.Checked)
                {
                    retiradasItem = retiradaItemNegocios.ConsultaPorDataAntes(Convert.ToDateTime(txtData2.Text));
                    AnimalNegocios animalNegocios = new AnimalNegocios();
                    List<RetiradaItemRelatorio> retiradasItemRelatorio = new List<RetiradaItemRelatorio>();

                    for (int i = 0; i < retiradasItem.Count; i++)
                    {
                        retiradasItemRelatorio.Add(new RetiradaItemRelatorio()
                        {
                            RetiradaItemID = retiradasItem[i].RetiradaItemID,
                            RetiradaItemDescricao = retiradasItem[i].RetiradaItemDescricao,
                            RetiradaItemQuantidade = retiradasItem[i].RetiradaItemQuantidade,
                            RetiradaItemData = retiradasItem[i].RetiradaItemData,
                            UsuarioNome = retiradasItem[i].Usuario.UsuarioNome,
                            ItemDescricao = retiradasItem[i].Item.ItemDescricao,
                            TipoItemDescricao = retiradasItem[i].Item.TipoItem.TipoItemDescricao
                        });
                    }


                    List<ReportParameter> listReportParameter = new List<ReportParameter>();

                    listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório antes da data " + txtData2.Text + "."));
                    listReportParameter.Add(new ReportParameter("UsuarioEmissor", usuario.UsuarioNome));
                    listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));

                    List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                    reportDataSources.Add(new ReportDataSource("DataSetRetiradaItem", retiradasItemRelatorio));

                    Variados.Reports.ReportGenerator report = new Variados.Reports.ReportGenerator();
                    report.CallReport(Path, reportDataSources, listReportParameter);
                }
                else if (rbApos.Checked)
                {
                    retiradasItem = retiradaItemNegocios.ConsultaPorDataApos(Convert.ToDateTime(txtData1.Text));
                    AnimalNegocios animalNegocios = new AnimalNegocios();
                    List<RetiradaItemRelatorio> retiradasItemRelatorio = new List<RetiradaItemRelatorio>();

                    for (int i = 0; i < retiradasItem.Count; i++)
                    {
                        retiradasItemRelatorio.Add(new RetiradaItemRelatorio()
                        {
                            RetiradaItemID = retiradasItem[i].RetiradaItemID,
                            RetiradaItemDescricao = retiradasItem[i].RetiradaItemDescricao,
                            RetiradaItemQuantidade = retiradasItem[i].RetiradaItemQuantidade,
                            RetiradaItemData = retiradasItem[i].RetiradaItemData,
                            UsuarioNome = retiradasItem[i].Usuario.UsuarioNome,
                            ItemDescricao = retiradasItem[i].Item.ItemDescricao,
                            TipoItemDescricao = retiradasItem[i].Item.TipoItem.TipoItemDescricao
                        });
                    }


                    List<ReportParameter> listReportParameter = new List<ReportParameter>();

                    listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório após a data " + txtData1.Text + "."));
                    listReportParameter.Add(new ReportParameter("UsuarioEmissor", usuario.UsuarioNome));
                    listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));

                    List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                    reportDataSources.Add(new ReportDataSource("DataSetRetiradaItem", retiradasItemRelatorio));

                    Variados.Reports.ReportGenerator report = new Variados.Reports.ReportGenerator();
                    report.CallReport(Path, reportDataSources, listReportParameter);
                }
                else if (rbEntre.Checked)
                {
                    retiradasItem = retiradaItemNegocios.ConsultaPorDataEntre(Convert.ToDateTime(txtData1.Text), Convert.ToDateTime(txtData2.Text));
                    AnimalNegocios animalNegocios = new AnimalNegocios();
                    List<RetiradaItemRelatorio> retiradasItemRelatorio = new List<RetiradaItemRelatorio>();

                    for (int i = 0; i < retiradasItem.Count; i++)
                    {
                        retiradasItemRelatorio.Add(new RetiradaItemRelatorio()
                        {
                            RetiradaItemID = retiradasItem[i].RetiradaItemID,
                            RetiradaItemDescricao = retiradasItem[i].RetiradaItemDescricao,
                            RetiradaItemQuantidade = retiradasItem[i].RetiradaItemQuantidade,
                            RetiradaItemData = retiradasItem[i].RetiradaItemData,
                            UsuarioNome = retiradasItem[i].Usuario.UsuarioNome,
                            ItemDescricao = retiradasItem[i].Item.ItemDescricao,
                            TipoItemDescricao = retiradasItem[i].Item.TipoItem.TipoItemDescricao
                        });
                    }


                    List<ReportParameter> listReportParameter = new List<ReportParameter>();

                    listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório entre a data " + txtData1.Text + " e " + txtData2.Text + "."));
                    listReportParameter.Add(new ReportParameter("UsuarioEmissor", usuario.UsuarioNome));
                    listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));

                    List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                    reportDataSources.Add(new ReportDataSource("DataSetRetiradaItem", retiradasItemRelatorio));

                    Variados.Reports.ReportGenerator report = new Variados.Reports.ReportGenerator();
                    report.CallReport(Path, reportDataSources, listReportParameter);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
