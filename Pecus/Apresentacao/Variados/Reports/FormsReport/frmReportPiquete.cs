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

namespace Apresentacao.Variados.Reports.FormsReport
{
    public partial class frmReportPiquete : Form
    {
        ObjetoTransferencia.Usuario usuario = new ObjetoTransferencia.Usuario();
        public frmReportPiquete(ObjetoTransferencia.Usuario usuarioP)
        {
            InitializeComponent();

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));

            dgvResultados.AutoGenerateColumns = false;
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

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void rbPasto_CheckedChanged(object sender, EventArgs e)
        {
            gpbPasto.Visible = true;
            gpbID.Visible = false;
        }

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            gpbPasto.Visible = false;
            gpbID.Visible = true;
        }

        private void btnBuscarPasto_Click(object sender, EventArgs e)
        {
            try
            {
                Pasto.frmConsultaPasto frmConsultaPasto = new Pasto.frmConsultaPasto(true, new ObjetoTransferencia.Usuario() { TipoUsuario = new TipoUsuario() });
                frmConsultaPasto.ShowDialog();
                txtPasto.Text = frmConsultaPasto.pastoRetorno.PastoID.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao abrir o formulário, tente novamente.", "Houve um erro.");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                PiqueteNegocios piqueteNegocios = new PiqueteNegocios();
                if (rbID.Checked)
                {
                    if (txtID.Text == "")
                        MessageBox.Show("Por favor, informe o ID.", "Informe o ID.");
                    else
                    {
                        dgvResultados.DataSource = piqueteNegocios.ConsultarPorID(int.Parse(txtID.Text));
                    }
                }
                else
                {
                    if (txtPasto.Text == "")
                        MessageBox.Show("Por favor, informe o Pasto.", "Informe o Pasto.");
                    else
                    {
                        dgvResultados.DataSource = piqueteNegocios.ConsultarPorPasto(int.Parse(txtPasto.Text));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Tente novamente.");
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
            try
            {
                PiqueteNegocios piqueteNegocios = new PiqueteNegocios();
                ObjetoTransferencia.Piquete piquete = piqueteNegocios.ConsultarPorID(int.Parse(dgvResultados.SelectedRows[0].Cells[0].Value.ToString()))[0];

                string Path = "PiquetesReport.rdlc";

                List<ReportParameter> listReportParameter = new List<ReportParameter>();
                listReportParameter.Add(new ReportParameter("TipoRelatorio", "Teste"));
                listReportParameter.Add(new ReportParameter("UsuarioEmissor", "Teste."));
                listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));
                listReportParameter.Add(new ReportParameter("PiqueteID", piquete.PiqueteID.ToString()));
                listReportParameter.Add(new ReportParameter("PiqueteDescricao", piquete.PiqueteDescricao.ToString()));
                if (piquete.PiqueteAtivo)
                    listReportParameter.Add(new ReportParameter("PiqueteAtivo", "Ativo"));
                else
                    listReportParameter.Add(new ReportParameter("PiqueteAtivo", "Inativo"));
                listReportParameter.Add(new ReportParameter("PiqueteQuantidadeAnimais", piquete.PiqueteQuantidadeAnimais.ToString()));

                PastoNegocios pastoNegocios = new PastoNegocios();
                piquete.Pasto = pastoNegocios.ConsultaPorID(piquete.Pasto.PastoID);

                listReportParameter.Add(new ReportParameter("PastoTamanho", piquete.Pasto.PastoTamanho.ToString()));
                listReportParameter.Add(new ReportParameter("PastoDescricao", piquete.Pasto.PastoDescricao.ToString()));

                List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                AnimalCollection animais = new AnimalCollection();
                AnimalNegocios animalNegocios = new AnimalNegocios();
                animais = animalNegocios.ConsultaPorPiquete(piquete.PiqueteID);
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

                reportDataSources.Add(new ReportDataSource("DataSetAnimalPiquete", animaisRelatorio));

                Variados.Reports.ReportGenerator report = new Variados.Reports.ReportGenerator();
                report.CallReport(Path, reportDataSources, listReportParameter);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Tente novamente.");
            }
        }
    }
}
