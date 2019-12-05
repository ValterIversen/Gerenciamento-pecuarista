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
    public partial class frmReportEstoqueLocalidade : Form
    {
        ObjetoTransferencia.Usuario usuario = new ObjetoTransferencia.Usuario();
        EstoqueLocalidadeCollection estoqueLocalidades = new EstoqueLocalidadeCollection();
        public frmReportEstoqueLocalidade(ObjetoTransferencia.Usuario usuarioP)
        {
            InitializeComponent();
            dgvResultado.AutoGenerateColumns = false;

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));
            gpbDescricao.Visible = true;

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

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void rbContratoAluguel_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void rbItem_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void rbCidade_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void rbDescricao_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void ControleRb()
        {
            gpbID.Visible = rbID.Checked;
            gpbContratoAluguel.Visible = rbContratoAluguel.Checked;
            gpbItem.Visible = rbItem.Checked;
            gpbCidade.Visible = rbCidade.Checked;
            gpbDescricao.Visible = rbDescricao.Checked;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void cbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CidadeEstagoNegocios cidadeEstagoNegocios = new CidadeEstagoNegocios();

            cbbCidade.DisplayMember = "CidadeNome";
            cbbCidade.ValueMember = "CidadeID";
            cbbCidade.DataSource = cidadeEstagoNegocios.ConsultaCidadePorEstado(Convert.ToInt32(cbbEstado.SelectedValue));
            cbbCidade.Update();
            cbbCidade.SelectedIndex = 0;
        }

        private void btnConsultarItem_Click(object sender, EventArgs e)
        {
            try
            {
                Item.frmConsultaItem frmConsultaItem = new Item.frmConsultaItem(true);
                frmConsultaItem.ShowDialog();
                if (frmConsultaItem.item.ItemID != 0)
                    txtItem.Text = frmConsultaItem.item.ItemID.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro, por favor, tente novamente.");
            }
        }

        private void btnConsultarContratoAluguel_Click(object sender, EventArgs e)
        {
            try
            {
                ContratoAluguel.frmConsultaContratoAluguel frmConsultaContratoAluguel = new ContratoAluguel.frmConsultaContratoAluguel(true, new ObjetoTransferencia.Usuario() { TipoUsuario = new TipoUsuario() });
                frmConsultaContratoAluguel.ShowDialog();
                if (frmConsultaContratoAluguel.contratoAluguelRetorno.ContratoAluguelID != 0)
                    txtContratoAluguel.Text = frmConsultaContratoAluguel.contratoAluguelRetorno.ContratoAluguelID.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro, por favor, tente novamente.");
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
                int EstoqueLocalidadeParametroID = Convert.ToInt32(dgvResultado.SelectedRows[0].Cells[0].Value);
                EstoqueLocalidadeNegocios estoqueLocalidadeNegocios = new EstoqueLocalidadeNegocios();
                ObjetoTransferencia.EstoqueLocalidade estoqueLocalidade = new ObjetoTransferencia.EstoqueLocalidade();
                estoqueLocalidade = estoqueLocalidadeNegocios.ConsultaPorID(EstoqueLocalidadeParametroID);


                string Path = "EstoquesReport.rdlc";

                List<ReportParameter> listReportParameter = new List<ReportParameter>();
                listReportParameter.Add(new ReportParameter("TipoRelatorio", "Relatório de Armazém"));
                listReportParameter.Add(new ReportParameter("UsuarioEmissor", usuario.UsuarioNome));
                listReportParameter.Add(new ReportParameter("DataEmissao", DateTime.Now.ToString("dd/MM/yyy")));
                listReportParameter.Add(new ReportParameter("EstoqueLocalidadeID", estoqueLocalidade.EstoqueLocalidadeID.ToString()));
                listReportParameter.Add(new ReportParameter("EstoqueLocalidadeDescricao", estoqueLocalidade.EstoqueLocalidadeDescricao));
                listReportParameter.Add(new ReportParameter("EstoqueLocalidadeEndereco", estoqueLocalidade.EstoqueLocalidadeEndereco));
                listReportParameter.Add(new ReportParameter("CidadeNome", estoqueLocalidade.Cidade.CidadeNome));
                listReportParameter.Add(new ReportParameter("EstadoNome", estoqueLocalidade.Cidade.EstadoNome));

                List<ReportDataSource> reportDataSources = new List<ReportDataSource>();

                EstoqueCollection estoques = new EstoqueCollection();
                EstoqueNegocios estoqueNegocios = new EstoqueNegocios();

                estoques = estoqueNegocios.ConsultaPorEstoqueLocalidade(estoqueLocalidade.EstoqueLocalidadeID);

                List<EstoqueRelatorio> estoqueRelatorio = new List<EstoqueRelatorio>();
                for (int i = 0; i < estoques.Count; i++)
                {
                    estoqueRelatorio.Add(new EstoqueRelatorio()
                    {
                        EstoqueID = estoques[i].EstoqueID,
                        EstoqueQuantidade = estoques[i].EstoqueQuantidade,
                        EstoqueAtivo = estoques[i].EstoqueAtivo,
                        ItemDescricao = estoques[i].Item.ItemDescricao,
                        TipoItemDescricao = estoques[i].Item.TipoItem.TipoItemDescricao
                    });
                }

                reportDataSources.Add(new ReportDataSource("DataSetEstoques", estoqueRelatorio));

                Variados.Reports.ReportGenerator report = new Variados.Reports.ReportGenerator();
                report.CallReport(Path, reportDataSources, listReportParameter);
            }
            catch (Exception ex)
            {

            }
        }

        private void frmReportEstoqueLocalidade_Load(object sender, EventArgs e)
        {
            CidadeEstagoNegocios cidadeEstagoNegocios = new CidadeEstagoNegocios();

            cbbEstado.DisplayMember = "EstadoNome";
            cbbEstado.ValueMember = "EstadoID";
            cbbEstado.DataSource = cidadeEstagoNegocios.ConsultaEstadoTodos();
            cbbEstado.Update();
            cbbEstado.SelectedIndex = 0;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                EstoqueLocalidadeNegocios estoqueLocalidadeNegocios = new EstoqueLocalidadeNegocios();
                if (rbDescricao.Checked)
                {
                    estoqueLocalidades = estoqueLocalidadeNegocios.ConsultaPorDescricao(textBox1.Text);
                    dgvResultado.DataSource = null;
                    dgvResultado.DataSource = estoqueLocalidades;
                }
                else if (rbID.Checked && txtID.Text != "" && txtID.Text != "0")
                {
                    estoqueLocalidades = new EstoqueLocalidadeCollection();
                    estoqueLocalidades.Add(estoqueLocalidadeNegocios.ConsultaPorID(int.Parse(txtID.Text)));
                    dgvResultado.DataSource = null;
                    dgvResultado.DataSource = estoqueLocalidades;

                }
                else if (rbContratoAluguel.Checked && txtContratoAluguel.Text != "" && txtContratoAluguel.Text != "0")
                {
                    estoqueLocalidades = estoqueLocalidadeNegocios.ConsultaPorContratoAluguel(int.Parse(txtContratoAluguel.Text));
                    dgvResultado.DataSource = null;
                    dgvResultado.DataSource = estoqueLocalidades;
                }
                else if (rbItem.Checked && txtItem.Text != "" && txtItem.Text != "0")
                {
                    estoqueLocalidades = estoqueLocalidadeNegocios.ConsultaPorItem(int.Parse(txtItem.Text));
                    dgvResultado.DataSource = null;
                    dgvResultado.DataSource = estoqueLocalidades;
                }
                else if (rbCidade.Checked)
                {
                    estoqueLocalidades = estoqueLocalidadeNegocios.ConsultaPorCidade(int.Parse(cbbCidade.SelectedValue.ToString()));
                    dgvResultado.DataSource = null;
                    dgvResultado.DataSource = estoqueLocalidades;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro durante a consulta, tente novamente.\nCaso o erro persista, por favor, contate seu suporte.\nObservações: " + ex.Message, "Houve um erro durante a consulta.");
            }
        }
    }
}
