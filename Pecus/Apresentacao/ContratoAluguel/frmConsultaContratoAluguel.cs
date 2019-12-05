using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjetoTransferencia;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Apresentacao.ContratoAluguel
{
    public partial class frmConsultaContratoAluguel : Form
    {
        private ObjetoTransferencia.Usuario user;
        public ObjetoTransferencia.ContratoAluguel contratoAluguelRetorno { get; set; }
        private Boolean retorno;
        public frmConsultaContratoAluguel(Boolean retornoP, ObjetoTransferencia.Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
            dgvResultado.AutoGenerateColumns = false;
            contratoAluguelRetorno = new ObjetoTransferencia.ContratoAluguel();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));


            retorno = retornoP;
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

        private void PicExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void PicExit_MouseEnter(object sender, EventArgs e)
        {
            picExit.BackgroundImage = Apresentacao.Properties.Resources.exit_hover;
        }

        private void PicExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.BackgroundImage = Apresentacao.Properties.Resources.exit;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try{
                ContratoAluguelNegocios contratoAluguelNegocios = new ContratoAluguelNegocios();
                if (rbPessoa.Checked)
                {
                    if(txtPessoaID.Text != "" && txtPessoaID.Text != "0")
                    {
                        dgvResultado.DataSource = contratoAluguelNegocios.ConsultaPorPessoa(int.Parse(txtPessoaID.Text));
                    }
                }
                else if (rbEstoqueLocalidade.Checked)
                {
                    if(txtEstoqueLocalidadeID.Text != "" && txtEstoqueLocalidadeID.Text != "0")
                    {
                        dgvResultado.DataSource = contratoAluguelNegocios.ConsultaPorEstoqueLocalidade(int.Parse(txtEstoqueLocalidadeID.Text));
                    }
                }
                else if (rbPasto.Checked)
                {
                    if(txtPastoID.Text != "" && txtPastoID.Text != "0")
                    {
                        dgvResultado.DataSource = contratoAluguelNegocios.ConsultaPorPasto(int.Parse(txtPastoID.Text));
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve algum erro, por favor, tente novamente.", "Por favor, tente novamente.");
            }
        }

        private void RbPessoa_CheckedChanged(object sender, EventArgs e)
        {
            ControleRadioButton();
        }

        private void RbEstoqueLocalidade_CheckedChanged(object sender, EventArgs e)
        {
            ControleRadioButton();
        }

        private void RbPasto_CheckedChanged(object sender, EventArgs e)
        {
            ControleRadioButton();
        }

        private void ControleRadioButton()
        {
            gpbPessoa.Enabled = rbPessoa.Checked;
            gpbPasto.Enabled = rbPasto.Checked;
            gpbEstoqueLocalidade.Enabled = rbEstoqueLocalidade.Checked;
        }

        private void BtnBuscarPessoa_Click(object sender, EventArgs e)
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

        private void BtnBuscarLocalidadeEstoque_Click(object sender, EventArgs e)
        {
            EstoqueLocalidade.frmConsultaEstoqueLocalidade frmConsultaEstoqueLocalidade = new EstoqueLocalidade.frmConsultaEstoqueLocalidade(true, user);
            if(frmConsultaEstoqueLocalidade.ShowDialog() == DialogResult.OK)
            {
                txtEstoqueLocalidadeID.Text = frmConsultaEstoqueLocalidade.estoqueLocalidadeIDRetorno.ToString();
            }
        }

        private void BtnBuscarPasto_Click(object sender, EventArgs e)
        {
            Pasto.frmConsultaPasto frmConsultaPasto = new Pasto.frmConsultaPasto(true, new ObjetoTransferencia.Usuario() { TipoUsuario = new TipoUsuario() });
            frmConsultaPasto.ShowDialog();
            if (frmConsultaPasto.pastoRetorno.PastoID != 0)
            {
                txtPastoID.Text = frmConsultaPasto.pastoRetorno.PastoID.ToString();
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
            try{
                if (retorno)
                {
                    ContratoAluguelNegocios contratoAluguelNegocios = new ContratoAluguelNegocios();

                    contratoAluguelRetorno = contratoAluguelNegocios.ConsultaPorID(int.Parse(dgvResultado.SelectedRows[0].Cells[0].Value.ToString()))[0];
                    Close();
                }
                else
                {
                    if (user.TipoUsuario.TipoUsuarioDescricao == "Administrador")
                    {
                        ContratoAluguelNegocios contratoAluguelNegocios = new ContratoAluguelNegocios();
                        ObjetoTransferencia.ContratoAluguel contratoAluguel = new ObjetoTransferencia.ContratoAluguel();
                        contratoAluguel = contratoAluguelNegocios.ConsultaPorID(int.Parse(dgvResultado.SelectedRows[0].Cells[0].Value.ToString()))[0];

                        frmAlterarContratoAluguel frmAlterarContratoAluguel = new frmAlterarContratoAluguel(contratoAluguel, user);
                        frmAlterarContratoAluguel.ShowDialog();
                        BtnConsultar_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Somente usuários administradores.", "Permissão negada.");
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve algum erro, por favor, tente novamente.", "Por favor, tente novamente.");
            }
        }
    }
}
