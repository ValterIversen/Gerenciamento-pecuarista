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
using System.Windows.Forms;
using Negocios;
using ObjetoTransferencia;
using Microsoft.Reporting.WebForms;

namespace Apresentacao.ContratoAluguel
{
    public partial class frmAlterarContratoAluguel : Form
    {
        private ObjetoTransferencia.ContratoAluguel contratoAluguel = new ObjetoTransferencia.ContratoAluguel();
        private ObjetoTransferencia.Usuario user;
        private PastoCollection pastoRemocao = new PastoCollection();
        private EstoqueLocalidadeCollection estoqueLocalidadeRemocao = new EstoqueLocalidadeCollection();
        public frmAlterarContratoAluguel(ObjetoTransferencia.ContratoAluguel contratoP, ObjetoTransferencia.Usuario usuario)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));

            contratoAluguel = contratoP;
            user = usuario;
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

        private void btnCadastrarArmazem_Click(object sender, EventArgs e)
        {
            EstoqueLocalidade.frmCadastroEstoqueLocalidade frmCadastroEstoqueLocalidade = new EstoqueLocalidade.frmCadastroEstoqueLocalidade(true, user.UsuarioID);
            if (frmCadastroEstoqueLocalidade.ShowDialog() == DialogResult.OK)
            {
                contratoAluguel.EstoquesLocalidade.Add(frmCadastroEstoqueLocalidade.estoqueLocalidade);
                dgvLocalidadesEstoque.DataSource = null;
                dgvLocalidadesEstoque.DataSource = contratoAluguel.EstoquesLocalidade;
            }
        }

        private void btnConsultarArmazem_Click(object sender, EventArgs e)
        {
            EstoqueLocalidade.frmConsultaEstoqueLocalidade frmConsultaEstoqueLocalidade = new EstoqueLocalidade.frmConsultaEstoqueLocalidade(true, user);
            frmConsultaEstoqueLocalidade.ShowDialog();
            if (frmConsultaEstoqueLocalidade.estoqueLocalidadeIDRetorno != 0)
            {
                EstoqueLocalidadeNegocios estoqueLocalidadeNegocios = new EstoqueLocalidadeNegocios();
                contratoAluguel.EstoquesLocalidade.Add(estoqueLocalidadeNegocios.ConsultaPorID(frmConsultaEstoqueLocalidade.estoqueLocalidadeIDRetorno));
                dgvLocalidadesEstoque.DataSource = null;
                dgvLocalidadesEstoque.DataSource = contratoAluguel.EstoquesLocalidade;
            }
        }

        private void btnRemoverArmazem_Click(object sender, EventArgs e)
        {
            if (dgvLocalidadesEstoque.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvLocalidadesEstoque.SelectedRows.Count; i++)
                {
                    for (int x = 0; x < contratoAluguel.EstoquesLocalidade.Count; x++)
                    {
                        if (int.Parse(dgvLocalidadesEstoque.SelectedRows[i].Cells[0].Value.ToString()) == contratoAluguel.EstoquesLocalidade[x].EstoqueLocalidadeID)
                        {
                            contratoAluguel.EstoquesLocalidade[x].ContratoAluguel.ContratoAluguelID = 0;
                            estoqueLocalidadeRemocao.Add(contratoAluguel.EstoquesLocalidade[x]);
                            contratoAluguel.EstoquesLocalidade.RemoveAt(x);
                            break;
                        }
                    }
                }
                dgvLocalidadesEstoque.DataSource = null;
                dgvLocalidadesEstoque.DataSource = contratoAluguel.EstoquesLocalidade;
            }
        }

        private void btnCadastrarPasto_Click(object sender, EventArgs e)
        {
            Pasto.frmCadastroPasto frmCadastroPasto = new Pasto.frmCadastroPasto(true);
            if (frmCadastroPasto.ShowDialog() == DialogResult.OK)
            {
                contratoAluguel.Pastos.Add(frmCadastroPasto.pasto);
                dgvPastos.DataSource = null;
                dgvPastos.DataSource = contratoAluguel.Pastos;
            }
        }

        private void btnConsultarPasto_Click(object sender, EventArgs e)
        {
            Pasto.frmConsultaPasto frmConsultaPasto = new Pasto.frmConsultaPasto(true, new ObjetoTransferencia.Usuario() { TipoUsuario = new TipoUsuario() });
            frmConsultaPasto.ShowDialog();
            if (frmConsultaPasto.pastoRetorno.PastoID != 0)
            {
                PastoNegocios pastoNegocios = new PastoNegocios();
                ObjetoTransferencia.Pasto pasto = new ObjetoTransferencia.Pasto();
                pasto = pastoNegocios.ConsultaPorID(frmConsultaPasto.pastoRetorno.PastoID);
                contratoAluguel.Pastos.Add(pasto);
                dgvPastos.DataSource = null;
                dgvPastos.DataSource = contratoAluguel.Pastos;
            }
        }

        private void btnBuscarPessoa_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa.frmConsultaPessoa frmConsultaPessoa = new Pessoa.frmConsultaPessoa(true);
                frmConsultaPessoa.ShowDialog();
                if (frmConsultaPessoa.pessoaRetorno.PessoaID != 0)
                {
                    txtPessoaID.Text = frmConsultaPessoa.pessoaRetorno.PessoaID.ToString();
                    txtNome.Text = frmConsultaPessoa.pessoaRetorno.PessoaFisica.PessoaFisicaNome;
                    txtNomeFicticio.Text = frmConsultaPessoa.pessoaRetorno.PessoaJuridica.PessoaJuridicaNomeFicticio;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Por favor, tente novamente.");
            }
        }

        private void btnRemoverPasto_Click(object sender, EventArgs e)
        {
            if (dgvPastos.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvPastos.SelectedRows.Count; i++)
                {
                    for (int x = 0; x < contratoAluguel.Pastos.Count; x++)
                    {
                        if (int.Parse(dgvPastos.SelectedRows[i].Cells[0].Value.ToString()) == contratoAluguel.Pastos[x].PastoID)
                        {
                            contratoAluguel.Pastos[x].ContratoAluguel.ContratoAluguelID = 0;
                            pastoRemocao.Add(contratoAluguel.Pastos[x]);
                            contratoAluguel.Pastos.RemoveAt(x);
                            break;
                        }
                    }
                }
                dgvPastos.DataSource = null;
                dgvPastos.DataSource = contratoAluguel.Pastos;
            }
        }

        private void frmAlterarContratoAluguel_Load(object sender, EventArgs e)
        {
            try
            {
                dgvPastos.AutoGenerateColumns = false;
                dgvLocalidadesEstoque.AutoGenerateColumns = false;

                dtpFinal.Value = contratoAluguel.ContratoAluguelDataFinal;
                dtpInicial.Value = contratoAluguel.ContratoAluguelDataInicial;
                txtValor.Text = contratoAluguel.ContratoAluguelValor.ToString();
                PessoaNegocios pessoaNegocios = new PessoaNegocios();
                contratoAluguel.Pessoa = pessoaNegocios.ConsultaPorID(contratoAluguel.Pessoa.PessoaID)[0];
                PastoNegocios pastoNegocios = new PastoNegocios();
                contratoAluguel.Pastos = pastoNegocios.ConsultaPorContratoAluguel(contratoAluguel.ContratoAluguelID);
                EstoqueLocalidadeNegocios estoqueLocalidadeNegocios = new EstoqueLocalidadeNegocios();
                contratoAluguel.EstoquesLocalidade = estoqueLocalidadeNegocios.ConsultaPorContratoAluguel(contratoAluguel.ContratoAluguelID);
                txtPessoaID.Text = contratoAluguel.Pessoa.PessoaID.ToString();
                txtNome.Text = contratoAluguel.Pessoa.PessoaFisica.PessoaFisicaNome;
                txtNomeFicticio.Text = contratoAluguel.Pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio;

                dgvPastos.DataSource = contratoAluguel.Pastos;
                dgvLocalidadesEstoque.DataSource = contratoAluguel.EstoquesLocalidade;
                
            }
            catch(Exception ex)
            {

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtValor.Text == "")
                    MessageBox.Show("Por favor, informe o valor do aluguel.", "Informe o valor.");
                else if (txtPessoaID.Text == "" || txtPessoaID.Text == "0")
                    MessageBox.Show("Por favor, selecione o locador (dono da propriedade).", "Selecione o locador.");
                else if (dgvLocalidadesEstoque.Rows.Count == 0 && dgvPastos.Rows.Count == 0)
                    MessageBox.Show("Por favor, informe os pastos ou armazéns que você irá alugar.", "Informe os pastos/armazéns.");
                else
                {
                    ContratoAluguelNegocios contratoAluguelNegocios = new ContratoAluguelNegocios();

                    contratoAluguel.Pessoa.PessoaID = int.Parse(txtPessoaID.Text);
                    contratoAluguel.ContratoAluguelValor = decimal.Parse(txtValor.Text);
                    contratoAluguel.ContratoAluguelDataInicial = dtpInicial.Value;
                    contratoAluguel.ContratoAluguelDataFinal = dtpFinal.Value;

                    contratoAluguelNegocios.Alterar(contratoAluguel, user.UsuarioID, pastoRemocao, estoqueLocalidadeRemocao);
                    MessageBox.Show("Contrato de aluguel de ID " + contratoAluguel.ContratoAluguelID + " alterado com sucesso!", "Alteração realizado com sucesso!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Por favor, tente novamente.");
            }
        }

        private void dtpInicial_ValueChanged(object sender, EventArgs e)
        {
            dtpFinal.MinDate = dtpInicial.Value;
            if (dtpInicial.Value > dtpFinal.Value)
            {
                var final = dtpFinal.Value;
                var yesterday = final.AddDays(-1);
                dtpInicial.Value = yesterday;
            }
        }

        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            dtpInicial.MaxDate = dtpFinal.Value;
            if (dtpFinal.Value < dtpInicial.Value)
            {
                var inicial = dtpInicial.Value;
                var tomorrow = inicial.AddDays(1);
                dtpFinal.Value = tomorrow;
            }
        }

    }
}
