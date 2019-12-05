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
    public partial class frmCadastroPessoa : Form
    {
        public frmCadastroPessoa()
        {
            InitializeComponent();

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

        private void RbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            gpbPessoaFisica.Enabled = true;
            gpbPessoaJuridica.Enabled = false;
        }

        private void RbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            gpbPessoaJuridica.Enabled = true;
            gpbPessoaFisica.Enabled = false;
        }

        private void FrmCadastroPessoa_Load(object sender, EventArgs e)
        {
            try { 
                CidadeEstagoNegocios cidadeEstagoNegocios = new CidadeEstagoNegocios();

                cbbEstado.DisplayMember = "EstadoNome";
                cbbEstado.ValueMember = "EstadoID";
                cbbEstado.DataSource = cidadeEstagoNegocios.ConsultaEstadoTodos();
                cbbEstado.Update();
                cbbEstado.SelectedValue = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro ao consultar os estados. Por favor, tente novamente.", "Houve um erro ao consulta os estados.");
                Close();
            }
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

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEndereco.Text.Trim() == string.Empty)
                    MessageBox.Show("Por favor, informe o endereço.", "Informe o endereço.");
                else if (txtBairro.Text.Trim() == string.Empty)
                    MessageBox.Show("Por favor, informe o bairro.", "Informe o bairro.");
                else if (!txtTelefone.MaskCompleted)
                    MessageBox.Show("Por favor, informe o telefone/celular.", "Informe o telefone/celular.");
                else
                {
                    if (rbPessoaFisica.Checked)
                    {
                        if(!txtCPF.MaskCompleted)
                            MessageBox.Show("Por favor, informe o CPF.", "Informe o CPF.");
                        else if(txtNome.Text.Trim() == string.Empty)
                            MessageBox.Show("Por favor, informe o nome.", "Informe o nome.");
                        else
                        {
                            PessoaFisicaNegocios pessoaFisicaNegocios = new PessoaFisicaNegocios();
                            ObjetoTransferencia.Pessoa pessoa = new ObjetoTransferencia.Pessoa();
                            pessoa.PessoaFisica = new PessoaFisica();
                            pessoa.Cidade = new Cidade();

                            pessoa.PessoaAtivo = true;
                            pessoa.PessoaEndereco = txtEndereco.Text.Trim();
                            pessoa.PessoaBairro = txtBairro.Text.Trim();
                            pessoa.PessoaTelefone = txtTelefone.Text.Trim();
                            pessoa.Cidade.CidadeID = Convert.ToInt32(cbbCidade.SelectedValue);
                            pessoa.PessoaFisica.PessoaFisicaCPF = txtCPF.Text;
                            pessoa.PessoaFisica.PessoaFisicaNome = txtNome.Text.Trim();
                            pessoaFisicaNegocios.Cadastrar(pessoa);
                            MessageBox.Show("Pessoa física cadastrada com sucesso!", "Cadastro realizado com sucesso!");
                            Close();
                        }
                    }
                    else
                    {
                        if (!txtCNPJ.MaskCompleted)
                            MessageBox.Show("Por favor, informe o CNPJ.", "Informe o CNPJ.");
                        else if (txtRazaoSocial.Text.Trim() == string.Empty)
                            MessageBox.Show("Por favor, informe a razão social.", "Informe a razão social.");
                        else if (txtNomeFicticio.Text.Trim() == string.Empty)
                            MessageBox.Show("Por favor, informe o nome fictício.", "Informe o nome fictício.");
                        else
                        {
                            PessoaJuridicaNegocios pessoaJuridicaNegocios = new PessoaJuridicaNegocios();
                            ObjetoTransferencia.Pessoa pessoa = new ObjetoTransferencia.Pessoa();
                            pessoa.PessoaJuridica = new PessoaJuridica();
                            pessoa.Cidade = new Cidade();

                            pessoa.PessoaAtivo = true;
                            pessoa.PessoaEndereco = txtEndereco.Text.Trim();
                            pessoa.PessoaBairro = txtBairro.Text.Trim();
                            pessoa.PessoaTelefone = txtTelefone.Text.Trim();
                            pessoa.Cidade.CidadeID = Convert.ToInt32(cbbCidade.SelectedValue);
                            pessoa.PessoaJuridica.PessoaJuridicaCNPJ = txtCNPJ.Text;
                            pessoa.PessoaJuridica.PessoaJuridicaRazaoSocial = txtRazaoSocial.Text.Trim();
                            pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio = txtNomeFicticio.Text.Trim();
                            pessoaJuridicaNegocios.Cadastrar(pessoa);
                            MessageBox.Show("Pessoa jurídica cadastrada com sucesso!", "Cadastro realizado com sucesso!");
                            Close();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve algum erro durante o cadastro, por favor, tente novamente.\nCaso o erro persista, consulte seu suporte.", "Houve algum erro durante o cadastro.");
            }
        }

        private void ckNoveDigito_CheckedChanged(object sender, EventArgs e)
        {
            if (ckNoveDigito.Checked)
                txtTelefone.Mask = "(00) 00000-0000";
            else
                txtTelefone.Mask = "(00) 0000-0000";
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.MaskCompleted)
            {
                PessoaFisicaNegocios pessoaFisicaNegocios = new PessoaFisicaNegocios();
                if(pessoaFisicaNegocios.ConsultaPorCPF(txtCPF.Text).Count > 0)
                {
                    MessageBox.Show("Já há um cliente/pecuarista cadastrado com este CPF.", "CPF já cadastrado.");
                    txtCPF.Focus();
                }
            }
        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            if (txtCNPJ.MaskCompleted)
            {
                PessoaJuridicaNegocios pessoaJuridicaNegocios = new PessoaJuridicaNegocios();
                if (pessoaJuridicaNegocios.ConsultaPorCNPJ(txtCNPJ.Text).Count > 0)
                {
                    MessageBox.Show("Já há um cliente/pecuarista cadastrado com este CNPJ.", "CNPJ já cadastrado.");
                    txtCNPJ.Focus();
                }
            }
        }
    }
}
