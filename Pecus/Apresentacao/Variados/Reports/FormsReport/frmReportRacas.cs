using Microsoft.Reporting.WebForms;
using Negocios;
using ObjetoTransferencia;
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

namespace Apresentacao.Variados.Reports.FormsReport
{
    public partial class frmReportRacas : Form
    {
        ObjetoTransferencia.Usuario usuario = new ObjetoTransferencia.Usuario();
        public frmReportRacas(ObjetoTransferencia.Usuario usuarioP)
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

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            picExit.BackgroundImage = Apresentacao.Properties.Resources.exit_hover;
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.BackgroundImage = Apresentacao.Properties.Resources.exit;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                string Path = "RacasReport.rdlc";

                List<ReportParameter> listReportParameter = new List<ReportParameter>();
                listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório geral de raças"));
                listReportParameter.Add(new ReportParameter("UsuarioEmissor", usuario.UsuarioNome));
                listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));

                List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                RacaCollection racas = new RacaCollection();
                RacaNegocios racaNegocios = new RacaNegocios();

                racas = racaNegocios.ConsultaPorDescricao("");

                AnimalCollection animais = new AnimalCollection();
                AnimalNegocios animalNegocios = new AnimalNegocios();
                animais = animalNegocios.ConsultaPorDescricao("");

                List<AnimalRelatorio> animaisRelatorio = new List<AnimalRelatorio>();
                for (int i = 0; i < animais.Count; i++)
                {
                    animaisRelatorio.Add(new AnimalRelatorio()
                    {
                        AnimalID = animais[i].AnimalID,
                        AnimalDescricao = animais[i].AnimalDescricao,
                        AnimalIdentificador = animais[i].AnimalIdentificador,
                        AnimalAtivo = animais[i].AnimalAtivo,
                        RacaDescricao = animais[i].Raca.RacaDescricao,
                        RacaNome = animais[i].Raca.RacaNome,
                        PesagemData = animais[i].Pesagens[0].PesagemData,
                        PesagemPeso = animais[i].Pesagens[0].PesagemPeso,
                    }); ;
                }

                reportDataSources.Add(new ReportDataSource("DataSetRacas", racas));
                reportDataSources.Add(new ReportDataSource("DataSetAnimais", animaisRelatorio));

                Variados.Reports.ReportGenerator report = new Variados.Reports.ReportGenerator();
                report.CallReport(Path, reportDataSources, listReportParameter);

            }
            catch (Exception ex)
            {

            }
        }
    }
}
