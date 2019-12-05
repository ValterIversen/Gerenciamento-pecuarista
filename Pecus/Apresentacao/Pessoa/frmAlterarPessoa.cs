using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Apresentacao.Pessoa
{
    public partial class frmAlterarPessoa : Form
    {
        private ObjetoTransferencia.Pessoa pessoa = new ObjetoTransferencia.Pessoa();
        private ObjetoTransferencia.CompraCollection compras = new ObjetoTransferencia.CompraCollection();
        private ObjetoTransferencia.VendaCollection vendas = new ObjetoTransferencia.VendaCollection();
        private ObjetoTransferencia.ContratoAluguelCollection contratosAluguel = new ObjetoTransferencia.ContratoAluguelCollection();
        public frmAlterarPessoa(ObjetoTransferencia.Pessoa pessoaP)
        {
            InitializeComponent();
            pessoa = pessoaP;

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));

            dgvCompras.AutoGenerateColumns = false;
            dgvVendas.AutoGenerateColumns = false;
            dgvContratoAluguel.AutoGenerateColumns = false;
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

        private void RbCompras_CheckedChanged(object sender, EventArgs e)
        {
            CompraNegocios compraNegocios = new CompraNegocios();
            CompraCollection compras = compraNegocios.ConsultaPorPessoa(pessoa.PessoaID);
            ListaCompraNegocios listaCompraNegocios = new ListaCompraNegocios();
            for (int i = 0; i < compras.Count; i++)
            {
                compras[i].CompraQuantidade = listaCompraNegocios.ConsultaPorCompra(compras[i].CompraID).Count;
            }
            dgvCompras.DataSource = compras;
            dgvCompras.Visible = true;
            dgvVendas.Visible = false;
            dgvContratoAluguel.Visible = false;
        }

        private void RbVendas_CheckedChanged(object sender, EventArgs e)
        {
            VendaNegocios vendaNegocios = new VendaNegocios(); 
            VendaCollection vendas = vendaNegocios.ConsultaPorPessoa(pessoa.PessoaID);
            ListaVendaNegocios listaVendaNegocios = new ListaVendaNegocios();
            for (int i = 0; i < vendas.Count; i++)
            {
                vendas[i].VendaQuantidade = listaVendaNegocios.ConsultaPorVenda(vendas[i].VendaID).Count;
            }
            dgvVendas.DataSource = vendaNegocios.ConsultaPorPessoa(pessoa.PessoaID);
            dgvVendas.Visible = true;
            dgvCompras.Visible = false;
            dgvContratoAluguel.Visible = false;
        }

        private void RbContratoAluguel_CheckedChanged(object sender, EventArgs e)
        {
            ContratoAluguelNegocios contratoAluguelNegocios = new ContratoAluguelNegocios();
            dgvContratoAluguel.DataSource = contratoAluguelNegocios.ConsultaPorPessoa(pessoa.PessoaID);
            dgvContratoAluguel.Visible = true;
            dgvCompras.Visible = false;
            dgvVendas.Visible = false;
        }

        private void FrmAlterarPessoa_Load(object sender, EventArgs e)
        {
            try
            {
                CidadeEstagoNegocios cidadeEstagoNegocios = new CidadeEstagoNegocios();

                cbbEstado.DisplayMember = "EstadoNome";
                cbbEstado.ValueMember = "EstadoID";
                cbbEstado.DataSource = cidadeEstagoNegocios.ConsultaEstadoTodos();
                cbbEstado.Update();
                cbbEstado.SelectedValue = cidadeEstagoNegocios.ConsultaCidadePorID(pessoa.Cidade.CidadeID).EstadoID;

                cbbCidade.DisplayMember = "CidadeNome";
                cbbCidade.ValueMember = "CidadeID";
                cbbCidade.DataSource = cidadeEstagoNegocios.ConsultaCidadePorEstado(Convert.ToInt32(cbbEstado.SelectedValue));
                cbbCidade.Update();
                cbbCidade.SelectedValue = pessoa.Cidade.CidadeID;


                txtEndereco.Text = pessoa.PessoaEndereco;
                txtBairro.Text = pessoa.PessoaBairro;

                if (pessoa.PessoaTelefone.Length > 14)
                {
                    ckNoveDigito.Checked = true;
                    txtTelefone.Mask = "(00) 00000-0000";
                }
                txtTelefone.Text = pessoa.PessoaTelefone;


                if (pessoa.PessoaFisica.PessoaFisicaCPF == "")
                {
                    rbPessoaJuridica.Checked = true;
                    gpbPessoaFisica.Enabled = false;
                    gpbPessoaJuridica.Enabled = true;
                    txtCNPJ.Enabled = false;
                    txtCPF.Enabled = true;
                    txtCNPJ.Text = pessoa.PessoaJuridica.PessoaJuridicaCNPJ;
                    txtRazaoSocial.Text = pessoa.PessoaJuridica.PessoaJuridicaRazaoSocial;
                    txtNomeFicticio.Text = pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio;
                }
                else
                {
                    rbPessoaFisica.Checked = true;
                    gpbPessoaJuridica.Enabled = false;
                    gpbPessoaFisica.Enabled = true;
                    txtCPF.Enabled = false;
                    txtCNPJ.Enabled = true;
                    txtCPF.Text = pessoa.PessoaFisica.PessoaFisicaCPF;
                    txtNome.Text = pessoa.PessoaFisica.PessoaFisicaNome;
                }

                CompraNegocios compraNegocios = new CompraNegocios();
                dgvCompras.DataSource = compraNegocios.ConsultaPorPessoa(pessoa.PessoaID);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro ao abrir o formulário, por favor, tente novamente.\nCaso o erro persista, consulte seu suporte.\nObservações: " + ex.Message, "Houve um erro ao abrir o formulário.");
            }
        }
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

        private void CbbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CidadeEstagoNegocios cidadeEstagoNegocios = new CidadeEstagoNegocios();

                cbbCidade.DisplayMember = "CidadeNome";
                cbbCidade.ValueMember = "CidadeID";
                cbbCidade.DataSource = cidadeEstagoNegocios.ConsultaCidadePorEstado(Convert.ToInt32(cbbEstado.SelectedValue));
                cbbCidade.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao consultar as cidades. Por favor, tente novamente.", "Houve um erro ao consulta as cidades.");
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtEndereco.Text.Trim() == string.Empty)
                    MessageBox.Show("Por favor, informe o endereço.", "Informe o endereço.");
                else if (txtBairro.Text.Trim() == string.Empty)
                    MessageBox.Show("Por favor, informe o bairro.", "Informe o bairro.");
                else if (!txtTelefone.MaskCompleted)
                    MessageBox.Show("Por favor, informe o telefone.", "Informe o telefone.");
                else if (!txtTelefone.MaskCompleted)
                    MessageBox.Show("Por favor, informe o telefone.", "Informe o telefone.");
                else if (rbPessoaFisica.Checked)
                {
                    if(!txtCPF.MaskCompleted)
                        MessageBox.Show("Por favor, informe o CPF.", "Informe o CPF.");
                    else if (txtNome.Text.Trim() == string.Empty)
                        MessageBox.Show("Por favor, informe o nome.", "Informe o nome.");
                    else
                    {
                        PessoaFisicaNegocios pessoaFisicaNegocios = new PessoaFisicaNegocios();
                        pessoa.PessoaFisica = new PessoaFisica();

                        pessoa.PessoaEndereco = txtEndereco.Text.Trim();
                        pessoa.PessoaBairro = txtBairro.Text.Trim();
                        pessoa.PessoaTelefone = txtTelefone.Text.Trim();
                        pessoa.Cidade = new Cidade();
                        pessoa.Cidade.CidadeID = int.Parse(cbbCidade.SelectedValue.ToString());

                        pessoa.PessoaFisica.PessoaFisicaCPF = txtCPF.Text;
                        pessoa.PessoaFisica.PessoaFisicaNome = txtNome.Text.Trim();

                        pessoaFisicaNegocios.Alterar(pessoa);

                        if(pessoa.PessoaJuridica.PessoaJuridicaCNPJ != "")
                        {
                            PessoaJuridicaNegocios pessoaJuridicaNegocios = new PessoaJuridicaNegocios();
                            pessoaJuridicaNegocios.Excluir(pessoa);
                        }
                        MessageBox.Show("Pessoa alterada com sucesso!", "Alteração realizada com sucesso!");
                        Close();
                    }
                }
                else
                {
                    if (!txtCNPJ.MaskCompleted)
                        MessageBox.Show("Por favor, informe o CNPJ.", "Informe o CNPJ.");
                    else if (txtNomeFicticio.Text.Trim() == string.Empty)
                        MessageBox.Show("Por favor, informe o nome fictício.", "Informe o nome fictício.");
                    else if (txtRazaoSocial.Text.Trim() == string.Empty)
                        MessageBox.Show("Por favor, informe a razão social.", "Informe a razão social.");
                    else
                    {
                        PessoaJuridicaNegocios pessoaJuridicaNegocios = new PessoaJuridicaNegocios();
                        pessoa.PessoaJuridica = new PessoaJuridica();

                        pessoa.PessoaEndereco = txtEndereco.Text.Trim();
                        pessoa.PessoaBairro = txtBairro.Text.Trim();
                        pessoa.PessoaTelefone = txtTelefone.Text.Trim();
                        pessoa.Cidade = new Cidade();
                        pessoa.Cidade.CidadeID = int.Parse(cbbCidade.SelectedValue.ToString());

                        pessoa.PessoaJuridica.PessoaJuridicaCNPJ = txtCNPJ.Text;
                        pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio = txtNomeFicticio.Text.Trim();
                        pessoa.PessoaJuridica.PessoaJuridicaRazaoSocial = txtRazaoSocial.Text.Trim();

                        pessoaJuridicaNegocios.Alterar(pessoa);

                        if(pessoa.PessoaFisica.PessoaFisicaCPF != "")
                        {
                            PessoaFisicaNegocios pessoaFisicaNegocios = new PessoaFisicaNegocios();
                            pessoaFisicaNegocios.Excluir(pessoa);
                        }
                        MessageBox.Show("Pessoa alterada com sucesso!", "Alteração realizada com sucesso!");
                        Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Tente novamente.");
            }
        }

        private void ckNoveDigito_CheckedChanged(object sender, EventArgs e)
        {
            if (ckNoveDigito.Checked)
                txtTelefone.Mask = "(00) 00000-0000";
            else
                txtTelefone.Mask = "(00) 0000-0000";
        }

        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            gpbPessoaFisica.Enabled = true;
            gpbPessoaJuridica.Enabled = false;
        }

        private void rbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            gpbPessoaJuridica.Enabled = true;
            gpbPessoaFisica.Enabled = false;
        }

        private void dgvCompras_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvCompras.Rows[e.RowIndex].DataBoundItem != null) && (dgvCompras.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvCompras.Rows[e.RowIndex].DataBoundItem, dgvCompras.Columns[e.ColumnIndex].DataPropertyName);
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

        private void dgvVendas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvVendas.Rows[e.RowIndex].DataBoundItem != null) && (dgvVendas.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvVendas.Rows[e.RowIndex].DataBoundItem, dgvVendas.Columns[e.ColumnIndex].DataPropertyName);
            }
        }

        private void dgvContratoAluguel_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvContratoAluguel.Rows[e.RowIndex].DataBoundItem != null) && (dgvContratoAluguel.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvContratoAluguel.Rows[e.RowIndex].DataBoundItem, dgvContratoAluguel.Columns[e.ColumnIndex].DataPropertyName);
            }
        }
    }
}
