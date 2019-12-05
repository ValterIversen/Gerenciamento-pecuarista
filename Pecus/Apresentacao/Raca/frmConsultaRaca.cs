using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using ObjetoTransferencia;
using Negocios;
using Microsoft.Reporting.WebForms;

namespace Apresentacao.Raca
{
    public partial class frmConsultaRaca : Form
    {
        public frmConsultaRaca()
        {
            InitializeComponent();
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

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            RacaCollection racaCollection = new RacaCollection();
            RacaNegocios racaNegocios = new RacaNegocios();
            if (rbNome.Checked)
            {
                racaCollection = racaNegocios.ConsultaPorNome(txtDados.Text);
            }
            else
            {
                racaCollection = racaNegocios.ConsultaPorDescricao(txtDados.Text);
            }

            dgvResultados.DataSource = racaCollection;
            dgvResultados.Update();
        }

        private void DgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ObjetoTransferencia.Raca raca = new ObjetoTransferencia.Raca();

            raca.RacaID = Convert.ToInt32(dgvResultados.SelectedRows[0].Cells[0].Value.ToString());
            raca.RacaNome = dgvResultados.SelectedRows[0].Cells[1].Value.ToString();
            raca.RacaDescricao = dgvResultados.SelectedRows[0].Cells[2].Value.ToString();

            frmAlteracaoRaca frmAlteracaoRaca = new frmAlteracaoRaca(raca);
            frmAlteracaoRaca.ShowDialog();
        }

        private void RbDescricao_CheckedChanged(object sender, EventArgs e)
        {
            txtDados.MaxLength = 60;
        }

        private void RbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtDados.MaxLength = 30;
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                string Path = "RacasReport.rdlc";

                List<ReportParameter> listReportParameter = new List<ReportParameter>();
                listReportParameter.Add(new ReportParameter("TipoRelatorio", "Teste"));
                listReportParameter.Add(new ReportParameter("UsuarioEmissor", "Teste."));
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
