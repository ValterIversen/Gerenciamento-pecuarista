using Microsoft.Reporting.WebForms;
using Negocios;
using ObjetoTransferencia;
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

namespace Apresentacao.Variados.Reports.FormsReport
{
    public partial class frmReportContratoAluguel : Form
    {
        ObjetoTransferencia.Usuario usuario = new ObjetoTransferencia.Usuario();
        public frmReportContratoAluguel(ObjetoTransferencia.Usuario usuarioP)
        {
            InitializeComponent();
            dgvResultado.AutoGenerateColumns = false;
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

        private void rbPessoa_CheckedChanged(object sender, EventArgs e)
        {
            ControleRadioButton();
        }

        private void rbEstoqueLocalidade_CheckedChanged(object sender, EventArgs e)
        {
            ControleRadioButton();
        }

        private void rbPasto_CheckedChanged(object sender, EventArgs e)
        {
            ControleRadioButton();
        }

        private void ControleRadioButton()
        {
            gpbPessoa.Enabled = rbPessoa.Checked;
            gpbPasto.Enabled = rbPasto.Checked;
            gpbEstoqueLocalidade.Enabled = rbEstoqueLocalidade.Checked;
        }

        private void btnBuscarPessoa_Click(object sender, EventArgs e)
        {
            Pessoa.frmConsultaPessoa frmConsultaPessoa = new Pessoa.frmConsultaPessoa(true);
            frmConsultaPessoa.ShowDialog();
            if (frmConsultaPessoa.pessoaRetorno.PessoaID != 0)
            {
                txtPessoaID.Text = frmConsultaPessoa.pessoaRetorno.PessoaID.ToString();
                txtNomeFicticio.Text = frmConsultaPessoa.pessoaRetorno.PessoaJuridica.PessoaJuridicaNomeFicticio;
                txtNome.Text = frmConsultaPessoa.pessoaRetorno.PessoaFisica.PessoaFisicaNome;
            }
        }

        private void btnBuscarLocalidadeEstoque_Click(object sender, EventArgs e)
        {
            EstoqueLocalidade.frmConsultaEstoqueLocalidade frmConsultaEstoqueLocalidade = new EstoqueLocalidade.frmConsultaEstoqueLocalidade(true, usuario);
            if (frmConsultaEstoqueLocalidade.ShowDialog() == DialogResult.OK)
            {
                txtEstoqueLocalidadeID.Text = frmConsultaEstoqueLocalidade.estoqueLocalidadeIDRetorno.ToString();
            }
        }

        private void btnBuscarPasto_Click(object sender, EventArgs e)
        {
            Pasto.frmConsultaPasto frmConsultaPasto = new Pasto.frmConsultaPasto(true, new ObjetoTransferencia.Usuario() { TipoUsuario = new TipoUsuario() });
            frmConsultaPasto.ShowDialog();
            if (frmConsultaPasto.pastoRetorno.PastoID != 0)
            {
                txtPastoID.Text = frmConsultaPasto.pastoRetorno.PastoID.ToString();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ContratoAluguelNegocios contratoAluguelNegocios = new ContratoAluguelNegocios();
                if (rbPessoa.Checked)
                {
                    if (txtPessoaID.Text != "" && txtPessoaID.Text != "0")
                    {
                        dgvResultado.DataSource = contratoAluguelNegocios.ConsultaPorPessoa(int.Parse(txtPessoaID.Text));
                    }
                }
                else if (rbEstoqueLocalidade.Checked)
                {
                    if (txtEstoqueLocalidadeID.Text != "" && txtEstoqueLocalidadeID.Text != "0")
                    {
                        dgvResultado.DataSource = contratoAluguelNegocios.ConsultaPorEstoqueLocalidade(int.Parse(txtEstoqueLocalidadeID.Text));
                    }
                }
                else if (rbPasto.Checked)
                {
                    if (txtPastoID.Text != "" && txtPastoID.Text != "0")
                    {
                        dgvResultado.DataSource = contratoAluguelNegocios.ConsultaPorPasto(int.Parse(txtPastoID.Text));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve algum erro, por favor, tente novamente.", "Por favor, tente novamente.");
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

        private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ContratoAluguelNegocios contratoAluguelNegocios = new ContratoAluguelNegocios();
                ObjetoTransferencia.ContratoAluguel contratoAluguel = new ObjetoTransferencia.ContratoAluguel();
                contratoAluguel = contratoAluguelNegocios.ConsultaPorID(int.Parse(dgvResultado.SelectedRows[0].Cells[0].Value.ToString()))[0];

                PastoNegocios pastoNegocios = new PastoNegocios();
                EstoqueLocalidadeNegocios estoqueLocalidadeNegocios = new EstoqueLocalidadeNegocios();

                contratoAluguel.Pastos = pastoNegocios.ConsultaPorContratoAluguel(contratoAluguel.ContratoAluguelID);
                contratoAluguel.EstoquesLocalidade = estoqueLocalidadeNegocios.ConsultaPorContratoAluguel(contratoAluguel.ContratoAluguelID);
                contratoAluguel.QuantidadePasto = contratoAluguel.Pastos.Count;
                contratoAluguel.QuantidadeEstoqueLocalidade = contratoAluguel.EstoquesLocalidade.Count;

                string Path = "ContratoAluguelReport.rdlc";

                List<ReportParameter> listReportParameter = new List<ReportParameter>();
                listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório de Contrato de Aluguel"));
                listReportParameter.Add(new ReportParameter("UsuarioEmissor", usuario.UsuarioNome));
                listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));
                listReportParameter.Add(new ReportParameter("ContratoAluguelID", contratoAluguel.ContratoAluguelID.ToString()));
                listReportParameter.Add(new ReportParameter("ContratoAluguelDataInicial", contratoAluguel.ContratoAluguelDataInicial.ToString()));
                listReportParameter.Add(new ReportParameter("ContratoAluguelDataFinal", contratoAluguel.ContratoAluguelDataFinal.ToString()));
                listReportParameter.Add(new ReportParameter("ContratoAluguelValor", contratoAluguel.ContratoAluguelValor.ToString()));
                listReportParameter.Add(new ReportParameter("QuantidadeEstoqueLocalidade", contratoAluguel.EstoquesLocalidade.Count.ToString()));
                listReportParameter.Add(new ReportParameter("QuantidadePasto", contratoAluguel.Pastos.Count.ToString()));
                if (contratoAluguel.Pessoa.PessoaFisica.PessoaFisicaCPF != "")
                    listReportParameter.Add(new ReportParameter("Pessoa", "Pessoa Física: " + contratoAluguel.Pessoa.PessoaID.ToString() +
                " | " + contratoAluguel.Pessoa.PessoaFisica.PessoaFisicaCPF +
                " | " + contratoAluguel.Pessoa.PessoaFisica.PessoaFisicaNome + "."));
                else
                    listReportParameter.Add(new ReportParameter("Pessoa", "Pessoa Jurídica: " + contratoAluguel.Pessoa.PessoaID.ToString() +
                " | " + contratoAluguel.Pessoa.PessoaJuridica.PessoaJuridicaCNPJ +
                " | " + contratoAluguel.Pessoa.PessoaJuridica.PessoaJuridicaRazaoSocial +
                " | " + contratoAluguel.Pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio + "."));

                List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                List<PastoRelatorio> pastosRelatorio = new List<PastoRelatorio>();
                for (int i = 0; i < contratoAluguel.Pastos.Count; i++)
                {
                    pastosRelatorio.Add(new PastoRelatorio()
                    {
                        PastoID = contratoAluguel.Pastos[i].PastoID,
                        PastoDescricao = contratoAluguel.Pastos[i].PastoDescricao,
                        PastoTamanho = contratoAluguel.Pastos[i].PastoTamanho,
                        PastoAtivo = contratoAluguel.Pastos[i].PastoAtivo,
                        CidadeNome = contratoAluguel.Pastos[i].Cidade.CidadeNome,
                        EstadoNome = contratoAluguel.Pastos[i].Cidade.EstadoNome
                    });
                }
                reportDataSources.Add(new ReportDataSource("DataSetPasto", pastosRelatorio));

                List<EstoqueLocalidadeRelatorio> estoquesLocalidadeRelatorio = new List<EstoqueLocalidadeRelatorio>();
                for (int i = 0; i < contratoAluguel.EstoquesLocalidade.Count; i++)
                {
                    estoquesLocalidadeRelatorio.Add(new EstoqueLocalidadeRelatorio()
                    {
                        EstoqueLocalidadeID = contratoAluguel.EstoquesLocalidade[i].EstoqueLocalidadeID,
                        EstoqueLocalidadeDescricao = contratoAluguel.EstoquesLocalidade[i].EstoqueLocalidadeDescricao,
                        EstoqueLocalidadeEndereco = contratoAluguel.EstoquesLocalidade[i].EstoqueLocalidadeEndereco,
                        CidadeNome = contratoAluguel.EstoquesLocalidade[i].Cidade.CidadeNome,
                        EstadoNome = contratoAluguel.EstoquesLocalidade[i].Cidade.EstadoNome
                    });
                }
                reportDataSources.Add(new ReportDataSource("DataSetEstoqueLocalidade", estoquesLocalidadeRelatorio));


                Variados.Reports.ReportGenerator report = new Variados.Reports.ReportGenerator();
                report.CallReport(Path, reportDataSources, listReportParameter);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve algum erro, por favor, tente novamente.", "Por favor, tente novamente.");
            }
        }
    }
}
