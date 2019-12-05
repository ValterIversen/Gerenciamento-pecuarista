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
using Microsoft.Reporting.WebForms;
using Negocios;
using ObjetoTransferencia;

namespace Apresentacao.Variados.Reports.FormsReport
{
    public partial class frmReportConsultaVeterinaria : Form
    {
        ObjetoTransferencia.Usuario usuario = new ObjetoTransferencia.Usuario();
        private ObjetoTransferencia.ConsultaVeterinariaCollection consultas = new ConsultaVeterinariaCollection();
        public frmReportConsultaVeterinaria(ObjetoTransferencia.Usuario usuarioP)
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

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

            try
            {
                ConsultaVeterinariaNegocios consultaVeterinariaNegocios = new ConsultaVeterinariaNegocios();
                string Path = "ConsultaVeterinariasReport.rdlc";

                if (rbAntes.Checked)
                {
                    consultas = consultaVeterinariaNegocios.ConsultaPorDataAntes(dtpData2.Value);

                    AnimalNegocios animalNegocios = new AnimalNegocios();
                    for (int i = 0; i < consultas.Count; i++)
                    {
                        consultas[i].Animal = animalNegocios.ConsultaPorID(consultas[i].Animal.AnimalID)[0];
                    }

                    List<ConsultaVeterinariaRelatorio> consultasRelatorio = new List<ConsultaVeterinariaRelatorio>();
                    for (int i = 0; i < consultas.Count; i++)
                    {
                        consultasRelatorio.Add(new ConsultaVeterinariaRelatorio()
                        {
                            ConsultaVeterinariaID = consultas[i].ConsultaVeterinariaID,
                            ConsultaVeterinariaData = consultas[i].ConsultaVeterinariaData,
                            ConsultaVeterinariaDescricao = consultas[i].ConsultaVeterinariaDescricao,
                            ConsultaVeterinariaCusto = consultas[i].ConsultaVeterinariaCusto,
                            AnimalDescricao = consultas[i].Animal.AnimalDescricao,
                            AnimalIdentificador = consultas[i].Animal.AnimalIdentificador,
                            RacaNome = consultas[i].Animal.Raca.RacaNome
                        });
                    }

                    List<ReportParameter> listReportParameter = new List<ReportParameter>();

                    listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório antes da data " + dtpData2.Value.ToString("dd/MM/yyy") + "."));
                    listReportParameter.Add(new ReportParameter("UsuarioEmissor", usuario.UsuarioNome));
                    listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));

                    List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                    reportDataSources.Add(new ReportDataSource("DataSetConsultaVeterinaria", consultasRelatorio));

                    Variados.Reports.ReportGenerator report = new Variados.Reports.ReportGenerator();
                    report.CallReport(Path, reportDataSources, listReportParameter);
                }
                else if (rbApos.Checked)
                {
                    consultas = consultaVeterinariaNegocios.ConsultaPorDataApos(dtpData1.Value);

                    AnimalNegocios animalNegocios = new AnimalNegocios();
                    for (int i = 0; i < consultas.Count; i++)
                    {
                        consultas[i].Animal = animalNegocios.ConsultaPorID(consultas[i].Animal.AnimalID)[0];
                    }

                    List<ConsultaVeterinariaRelatorio> consultasRelatorio = new List<ConsultaVeterinariaRelatorio>();
                    for (int i = 0; i < consultas.Count; i++)
                    {
                        consultasRelatorio.Add(new ConsultaVeterinariaRelatorio()
                        {
                            ConsultaVeterinariaID = consultas[i].ConsultaVeterinariaID,
                            ConsultaVeterinariaData = consultas[i].ConsultaVeterinariaData,
                            ConsultaVeterinariaDescricao = consultas[i].ConsultaVeterinariaDescricao,
                            ConsultaVeterinariaCusto = consultas[i].ConsultaVeterinariaCusto,
                            AnimalDescricao = consultas[i].Animal.AnimalDescricao,
                            AnimalIdentificador = consultas[i].Animal.AnimalIdentificador,
                            RacaNome = consultas[i].Animal.Raca.RacaNome
                        });
                    }

                    List<ReportParameter> listReportParameter = new List<ReportParameter>();

                    listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório após a data " + dtpData1.Value.ToString("dd/MM/yyy") + "."));
                    listReportParameter.Add(new ReportParameter("UsuarioEmissor", usuario.UsuarioNome));
                    listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));

                    List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                    reportDataSources.Add(new ReportDataSource("DataSetConsultaVeterinaria", consultasRelatorio));

                    Variados.Reports.ReportGenerator report = new Variados.Reports.ReportGenerator();
                    report.CallReport(Path, reportDataSources, listReportParameter);
                }
                else if (rbEntre.Checked)
                {
                    consultas = consultaVeterinariaNegocios.ConsultaPorDataEntre(dtpData1.Value, dtpData2.Value);

                    AnimalNegocios animalNegocios = new AnimalNegocios();
                    for (int i = 0; i < consultas.Count; i++)
                    {
                        consultas[i].Animal = animalNegocios.ConsultaPorID(consultas[i].Animal.AnimalID)[0];
                    }

                    List<ConsultaVeterinariaRelatorio> consultasRelatorio = new List<ConsultaVeterinariaRelatorio>();
                    for (int i = 0; i < consultas.Count; i++)
                    {
                        consultasRelatorio.Add(new ConsultaVeterinariaRelatorio()
                        {
                            ConsultaVeterinariaID = consultas[i].ConsultaVeterinariaID,
                            ConsultaVeterinariaData = consultas[i].ConsultaVeterinariaData,
                            ConsultaVeterinariaDescricao = consultas[i].ConsultaVeterinariaDescricao,
                            ConsultaVeterinariaCusto = consultas[i].ConsultaVeterinariaCusto,
                            AnimalDescricao = consultas[i].Animal.AnimalDescricao,
                            AnimalIdentificador = consultas[i].Animal.AnimalIdentificador,
                            RacaNome = consultas[i].Animal.Raca.RacaNome
                        });
                    }

                    List<ReportParameter> listReportParameter = new List<ReportParameter>();

                    listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório entre as datas " + dtpData1.Value.ToString("dd/MM/yyy") + " e " + dtpData2.Value.ToString("dd/MM/yyy") + "."));
                    listReportParameter.Add(new ReportParameter("UsuarioEmissor", usuario.UsuarioNome));
                    listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));

                    List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                    reportDataSources.Add(new ReportDataSource("DataSetConsultaVeterinaria", consultasRelatorio));

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
