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

namespace Apresentacao.Pesagens
{
    public partial class frmConsultaPesagens : Form
    {
        PesagemCollection pesagemCollection = new PesagemCollection();
        public frmConsultaPesagens()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));

            dgvPesagens.AutoGenerateColumns = false;
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

        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            Animal.frmConsultaAnimal frmConsultaAnimal = new Animal.frmConsultaAnimal(true);
            frmConsultaAnimal.ShowDialog();
            if (frmConsultaAnimal.animalRetorno.AnimalID != 0)
                txtAnimal.Text = frmConsultaAnimal.animalRetorno.AnimalID.ToString();
        }

        private void rbAnimal_CheckedChanged(object sender, EventArgs e)
        {
            gpbAnimal.Visible = true;
            gpbDataOpcoes.Visible = false;
            gpbDatas.Visible = false;
        }

        private void rbData_CheckedChanged(object sender, EventArgs e)
        {
            gpbAnimal.Visible = false;
            gpbDataOpcoes.Visible = true;
            gpbDatas.Visible = true;
        }
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                PesagemNegocios pesagemNegocios = new PesagemNegocios();
                if(rbAnimal.Checked && txtAnimal.Text != "" && txtAnimal.Text != "0")
                {
                    pesagemCollection = pesagemNegocios.ConsultaPorAnimal(int.Parse(txtAnimal.Text));
                    dgvPesagens.DataSource = null;
                    dgvPesagens.DataSource = pesagemCollection;
                }
                else
                {
                    if (rbApos.Checked)
                    {
                        pesagemCollection = pesagemNegocios.ConsultaPorApos(dtpData1.Value);
                        dgvPesagens.DataSource = null;
                        dgvPesagens.DataSource = pesagemCollection;
                    }
                    else if (rbAntes.Checked)
                    {
                        pesagemCollection = pesagemNegocios.ConsultaPorAntes(dtpData2.Value);
                        dgvPesagens.DataSource = null;
                        dgvPesagens.DataSource = pesagemCollection;
                    }
                    else
                    {
                        pesagemCollection = pesagemNegocios.ConsultaPorEntre(dtpData1.Value, dtpData2.Value);
                        dgvPesagens.DataSource = null;
                        dgvPesagens.DataSource = pesagemCollection;
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro.");
            }
        }

        private void txtAnimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void dgvPesagens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < pesagemCollection.Count; i++)
            {
                if(pesagemCollection[i].PesagemID == int.Parse(dgvPesagens.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    frmAlteracaoPesagem frmAlteracaoPesagem = new frmAlteracaoPesagem(pesagemCollection[i]);
                    frmAlteracaoPesagem.ShowDialog();
                    btnConsultar_Click(sender, e);
                }
            }
        }

        private void rbApos_CheckedChanged(object sender, EventArgs e)
        {
            dtpData1.Enabled = true;
            dtpData2.Enabled = false;
        }

        private void rbAntes_CheckedChanged(object sender, EventArgs e)
        {
            dtpData1.Enabled = false;
            dtpData2.Enabled = true;
        }

        private void rbEntre_CheckedChanged(object sender, EventArgs e)
        {
            dtpData1.Enabled = true;
            dtpData2.Enabled = true;
        }

        private void dgvPesagens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvPesagens.Rows[e.RowIndex].DataBoundItem != null) && (dgvPesagens.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvPesagens.Rows[e.RowIndex].DataBoundItem, dgvPesagens.Columns[e.ColumnIndex].DataPropertyName);
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

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                PesagemNegocios pesagemNegocios = new PesagemNegocios();
                string Path = "PesagensReport.rdlc";
                if (rbAntes.Checked)
                {
                    pesagemCollection = pesagemNegocios.ConsultaPorAntes(dtpData2.Value);
                    AnimalNegocios animalNegocios = new AnimalNegocios();
                    for (int i = 0; i < pesagemCollection.Count; i++)
                    {
                        pesagemCollection[i].Animal = animalNegocios.ConsultaPorID(pesagemCollection[i].Animal.AnimalID)[0];
                    }

                    List<PesagemRelatorio> pesagensRelatorio = new List<PesagemRelatorio>();
                    for (int i = 0; i < pesagemCollection.Count; i++)
                    {
                        pesagensRelatorio.Add(new PesagemRelatorio {
                            PesagemID = pesagemCollection[i].PesagemID,
                            PesagemData = pesagemCollection[i].PesagemData,
                            PesagemPeso = pesagemCollection[i].PesagemPeso,
                            AnimalRaca = pesagemCollection[i].Animal.Raca.RacaNome,
                            AnimalIdentificador = pesagemCollection[i].Animal.AnimalIdentificador,
                            AnimalDescricao = pesagemCollection[i].Animal.AnimalDescricao
                        });
                    }

                    List<PesagemRacaPeso> pesagensRacaPeso = new List<PesagemRacaPeso>();
                    pesagensRacaPeso = pesagemNegocios.ConsultaPesagemRacaAntes(dtpData2.Value);

                    List<ReportParameter> listReportParameter = new List<ReportParameter>();

                    listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório antes da data " + dtpData2.Value.ToString("dd/MM/yyy") + "."));
                    listReportParameter.Add(new ReportParameter("UsuarioEmissor", "Teste."));
                    listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));

                    List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                    reportDataSources.Add(new ReportDataSource("DataSetPesosTabela", pesagensRelatorio));
                    reportDataSources.Add(new ReportDataSource("DataSetPesagemRaca", pesagensRacaPeso));

                    Variados.Reports.ReportGenerator report = new Variados.Reports.ReportGenerator();
                    report.CallReport(Path, reportDataSources, listReportParameter);
                }
                else if (rbApos.Checked)
                {
                    pesagemCollection = pesagemNegocios.ConsultaPorApos(dtpData1.Value);
                    AnimalNegocios animalNegocios = new AnimalNegocios();
                    for (int i = 0; i < pesagemCollection.Count; i++)
                    {
                        pesagemCollection[i].Animal = animalNegocios.ConsultaPorID(pesagemCollection[i].Animal.AnimalID)[0];
                    }
                    List<PesagemRelatorio> pesagensRelatorio = new List<PesagemRelatorio>();
                    for (int i = 0; i < pesagemCollection.Count; i++)
                    {
                        pesagensRelatorio.Add(new PesagemRelatorio
                        {
                            PesagemID = pesagemCollection[i].PesagemID,
                            PesagemData = pesagemCollection[i].PesagemData,
                            PesagemPeso = pesagemCollection[i].PesagemPeso,
                            AnimalRaca = pesagemCollection[i].Animal.Raca.RacaNome,
                            AnimalIdentificador = pesagemCollection[i].Animal.AnimalIdentificador,
                            AnimalDescricao = pesagemCollection[i].Animal.AnimalDescricao
                        });
                    }

                    List<PesagemRacaPeso> pesagensRacaPeso = new List<PesagemRacaPeso>();
                    pesagensRacaPeso = pesagemNegocios.ConsultaPesagemRacaApos(dtpData1.Value);


                    List<ReportParameter> listReportParameter = new List<ReportParameter>();

                    listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório após a data " + dtpData1.Value.ToString("dd/MM/yyy") + "."));
                    listReportParameter.Add(new ReportParameter("UsuarioEmissor", "Teste."));
                    listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));

                    List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                    reportDataSources.Add(new ReportDataSource("DataSetPesosTabela", pesagensRelatorio));
                    reportDataSources.Add(new ReportDataSource("DataSetPesagemRaca", pesagensRacaPeso));

                    Variados.Reports.ReportGenerator report = new Variados.Reports.ReportGenerator();
                    report.CallReport(Path, reportDataSources, listReportParameter);
                }
                else if (rbEntre.Checked)
                {
                    pesagemCollection = pesagemNegocios.ConsultaPorEntre(dtpData1.Value, dtpData2.Value);
                    AnimalNegocios animalNegocios = new AnimalNegocios();
                    for (int i = 0; i < pesagemCollection.Count; i++)
                    {
                        pesagemCollection[i].Animal = animalNegocios.ConsultaPorID(pesagemCollection[i].Animal.AnimalID)[0];
                    }
                    List<PesagemRelatorio> pesagensRelatorio = new List<PesagemRelatorio>();
                    for (int i = 0; i < pesagemCollection.Count; i++)
                    {
                        pesagensRelatorio.Add(new PesagemRelatorio
                        {
                            PesagemID = pesagemCollection[i].PesagemID,
                            PesagemData = pesagemCollection[i].PesagemData,
                            PesagemPeso = pesagemCollection[i].PesagemPeso,
                            AnimalRaca = pesagemCollection[i].Animal.Raca.RacaNome,
                            AnimalIdentificador = pesagemCollection[i].Animal.AnimalIdentificador,
                            AnimalDescricao = pesagemCollection[i].Animal.AnimalDescricao
                        });
                    }


                    List<PesagemRacaPeso> pesagensRacaPeso = new List<PesagemRacaPeso>();
                    pesagensRacaPeso = pesagemNegocios.ConsultaPesagemRacaEntre(dtpData1.Value, dtpData2.Value);

                    List<ReportParameter> listReportParameter = new List<ReportParameter>();

                    listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório entre as datas " + dtpData1.Value.ToString("dd/MM/yyy") + " e " + dtpData2.Value.ToString("dd/MM/yyy") + "."));
                    listReportParameter.Add(new ReportParameter("UsuarioEmissor", "Teste."));
                    listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));

                    List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                    reportDataSources.Add(new ReportDataSource("DataSetPesosTabela", pesagensRelatorio));
                    reportDataSources.Add(new ReportDataSource("DataSetPesagemRaca", pesagensRacaPeso));

                    Variados.Reports.ReportGenerator report = new Variados.Reports.ReportGenerator();
                    report.CallReport(Path, reportDataSources, listReportParameter);
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
