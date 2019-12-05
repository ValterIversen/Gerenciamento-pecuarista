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

using Negocios;
using ObjetoTransferencia;

namespace Apresentacao.Vendas
{
    public partial class frmAlterarVenda : Form
    {
        private Venda venda = new Venda();
        private ListaVendaCollection animaisRemocaoListaVenda = new ListaVendaCollection();
        private ListaVendaCollection animaisListaVenda = new ListaVendaCollection();
        private AnimalCollection animaisNovosVenda = new AnimalCollection();
        private ObjetoTransferencia.Animal animalSel = new ObjetoTransferencia.Animal();
        public frmAlterarVenda(Venda vendaP)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            tabControl.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tabControl.Width, tabControl.Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));
            panelInside2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside2.Width, panelInside2.Height, 20, 20));
            panelInside3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside3.Width, panelInside3.Height, 20, 20));

            venda = vendaP;
            dgvAnimais.AutoGenerateColumns = false;
            dgvAnimaisNovos.AutoGenerateColumns = false;
            dgvAnimaisRemocao.AutoGenerateColumns = false;
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

        private void btnAlterarValor_Click(object sender, EventArgs e)
        {
            decimal valor = 0;
            if (decimal.TryParse(txtValorAnimal.Text, out valor))
            {
                if (valor <= 0)
                {
                    MessageBox.Show("Por favor, informe o valor do animal.", "Informe o valor do animal.");
                }
                else
                {
                    lblInfoValorAnimal.Visible = false;
                    for (int i = 0; i < dgvAnimais.SelectedRows.Count; i++)
                    {
                        for (int x = 0; x < animaisListaVenda.Count; x++)
                        {
                            if (int.Parse(dgvAnimais.SelectedRows[i].Cells[0].Value.ToString()) == animaisListaVenda[x].ListaVendaID)
                            {
                                animaisListaVenda[x].ListaVendaValor = valor;
                            }
                        }
                    }

                    dgvAnimais.DataSource = null;
                    dgvAnimais.DataSource = animaisListaVenda;
                    updateValorTotal();
                }
            }
            else
                lblInfoValorAnimal.Visible = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAnimais.SelectedRows.Count; i++)
            {
                for (int x = 0; x < animaisListaVenda.Count; x++)
                {
                    if (int.Parse(dgvAnimais.SelectedRows[i].Cells[0].Value.ToString()) == animaisListaVenda[x].ListaVendaID)
                    {
                        animaisRemocaoListaVenda.Add(animaisListaVenda[x]);
                        animaisListaVenda.RemoveAt(x);
                        break;
                    }
                }
            }

            updateValorTotal();

            dgvAnimais.DataSource = null;
            dgvAnimais.DataSource = animaisListaVenda;
            dgvAnimaisRemocao.DataSource = null;
            dgvAnimaisRemocao.DataSource = animaisRemocaoListaVenda;
        }

        private void txtValorAnimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtValorAnimal.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;
            else
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAnimaisRemocao.SelectedRows.Count; i++)
            {
                for (int x = 0; x < animaisRemocaoListaVenda.Count; x++)
                {
                    if (int.Parse(dgvAnimaisRemocao.SelectedRows[i].Cells[0].Value.ToString()) == animaisRemocaoListaVenda[x].ListaVendaID)
                    {
                        animaisListaVenda.Add(animaisRemocaoListaVenda[x]);
                        animaisRemocaoListaVenda.RemoveAt(x);
                        break;
                    }
                }
            }

            updateValorTotal();

            dgvAnimais.DataSource = null;
            dgvAnimais.DataSource = animaisListaVenda;
            dgvAnimaisRemocao.DataSource = null;
            dgvAnimaisRemocao.DataSource = animaisRemocaoListaVenda;
        }

        private void btnConsultarAnimal_Click(object sender, EventArgs e)
        {
            Animal.frmConsultaAnimal frmConsultaAnimal = new Animal.frmConsultaAnimal(true);
            frmConsultaAnimal.ShowDialog();
            if (frmConsultaAnimal.animalRetorno.AnimalID != 0)
            {
                animalSel = frmConsultaAnimal.animalRetorno;
                txtAnimalID.Text = animalSel.AnimalID.ToString();
            }
        }

        private void btnAdicionarIndividual_Click(object sender, EventArgs e)
        {
            decimal valor = 0;
            if (decimal.TryParse(txtValorAnimalSel.Text, out valor))
            {
                if (valor <= 0)
                {
                    MessageBox.Show("Por favor, informe o valor do animal.", "Informe o valor do animal.");
                }
                else
                {
                    lblInfoValorAnimalNovo.Visible = false;
                    if (animalSel.AnimalID != 0)
                    {
                        bool verif = false;
                        for (int i = 0; i < animaisNovosVenda.Count; i++)
                        {
                            if (animalSel.AnimalID == animaisNovosVenda[i].AnimalID)
                                verif = true;
                        }
                        if (!verif)
                        {
                            animalSel.AnimalValor = valor;
                            animaisNovosVenda.Add(animalSel);
                            dgvAnimaisNovos.DataSource = null;
                            dgvAnimaisNovos.DataSource = animaisNovosVenda;
                            updateValorTotal();
                        }
                    }
                }
            }
            else
                lblInfoValorAnimalNovo.Visible = true;
        }

        private void txtValorAnimalSel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtValorAnimalSel.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;
            else
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }

        private void btnBuscarPessoa_Click(object sender, EventArgs e)
        {
            Pessoa.frmConsultaPessoa frmConsultaPessoa = new Pessoa.frmConsultaPessoa(true);
            frmConsultaPessoa.ShowDialog();
            if (frmConsultaPessoa.pessoaRetorno.PessoaID != 0)
            {
                venda.Pessoa = frmConsultaPessoa.pessoaRetorno;
                txtPessoa.Text = venda.Pessoa.PessoaID.ToString();
                txtCPF.Text = venda.Pessoa.PessoaFisica.PessoaFisicaCPF;
                txtNome.Text = venda.Pessoa.PessoaFisica.PessoaFisicaNome;
                txtCNPJ.Text = venda.Pessoa.PessoaJuridica.PessoaJuridicaCNPJ;
                txtNomeFicticio.Text = venda.Pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio;
                txtRazaoSocial.Text = venda.Pessoa.PessoaJuridica.PessoaJuridicaRazaoSocial;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (animaisListaVenda.Count == 0 && animaisNovosVenda.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione algum animal.", "Selecione algum animal.");
                }
                else if (venda.Pessoa.PessoaID == 0)
                {
                    MessageBox.Show("Por favor, selecione o vendedor dos animais.", "Selecione o vendedor.");
                }
                else if (txtValorTotal.Text == "" || txtValorTotal.Text == "0")
                {
                    MessageBox.Show("Por favor, informe o valor total da venda.", "Informe o valor total.");
                }
                else
                {
                    venda.VendaDataEntrega = dtpDataEntrega.Value;

                    VendaNegocios vendaNegocios = new VendaNegocios();


                    vendaNegocios.Alterar(venda, animaisNovosVenda, animaisListaVenda, animaisRemocaoListaVenda);

                    MessageBox.Show("Venda de ID " + venda.VendaID + " cadastrada com sucesso!", "Venda cadastrada com sucesso!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro.");
            }
        }

        private void updateValorTotal()
        {
            {
                lblQuantidade.Text = (animaisListaVenda.Count + animaisNovosVenda.Count).ToString();
                venda.VendaValorTotal = 0;
                for (int i = 0; i < animaisListaVenda.Count; i++)
                {
                    venda.VendaValorTotal += animaisListaVenda[i].ListaVendaValor;
                }
                for (int i = 0; i < animaisNovosVenda.Count; i++)
                {
                    venda.VendaValorTotal += animaisNovosVenda[i].AnimalValor;
                }
                txtValorTotal.Text = venda.VendaValorTotal.ToString();
            }
        }

        private void btnAlterarValorAnimaisNovos_Click(object sender, EventArgs e)
        {
            decimal valor = 0;
            if (decimal.TryParse(txtValorAnimal.Text, out valor))
            {
                if (valor <= 0)
                {
                    MessageBox.Show("Por favor, informe o valor do animal.", "Informe o valor do animal.");
                }
                else
                {
                    lblInformeValorAnimalNovo.Visible = false;
                    for (int i = 0; i < dgvAnimaisNovos.SelectedRows.Count; i++)
                    {
                        for (int x = 0; x < animaisNovosVenda.Count; x++)
                        {
                            if (int.Parse(dgvAnimaisNovos.SelectedRows[i].Cells[0].Value.ToString()) == animaisNovosVenda[x].AnimalID)
                            {
                                animaisNovosVenda[x].AnimalValor = valor;
                            }
                        }
                    }

                    dgvAnimaisNovos.DataSource = null;
                    dgvAnimaisNovos.DataSource = animaisNovosVenda;
                    updateValorTotal();
                }
            }
            else
                lblInformeValorAnimalNovo.Visible = true;
        }

        private void txtValorAnimaisNovos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtValorAnimaisNovos.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;
            else
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }

        private void btnRemoverNovos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAnimaisNovos.SelectedRows.Count; i++)
            {
                for (int x = 0; x < animaisNovosVenda.Count; x++)
                {
                    if (int.Parse(dgvAnimaisNovos.SelectedRows[i].Cells[0].Value.ToString()) == animaisNovosVenda[x].AnimalID)
                    {
                        animaisNovosVenda.RemoveAt(x);
                        break;
                    }
                }
            }

            updateValorTotal();

            dgvAnimaisNovos.DataSource = null;
            dgvAnimaisNovos.DataSource = animaisNovosVenda;
        }

        private void frmAlterarVenda_Load(object sender, EventArgs e)
        {
            dgvAnimais.AutoGenerateColumns = false;
            dgvAnimaisNovos.AutoGenerateColumns = false;
            dgvAnimaisRemocao.AutoGenerateColumns = false;

            ListaVendaNegocios listaVendaNegocios = new ListaVendaNegocios();

            animaisListaVenda = listaVendaNegocios.ConsultaPorVenda(venda.VendaID);

            AnimalNegocios animalNegocios = new AnimalNegocios();
            for (int i = 0; i < animaisListaVenda.Count; i++)
            {
                animaisListaVenda[i].Animal = animalNegocios.ConsultaPorID(animaisListaVenda[i].Animal.AnimalID)[0];
            }

            dgvAnimais.DataSource = null;
            dgvAnimais.DataSource = animaisListaVenda;


            dtpData.Value = venda.VendaData;
            dtpDataEntrega.Value = venda.VendaDataEntrega;
            txtValorTotal.Text = venda.VendaValorTotal.ToString();
            lblQuantidade.Text = animaisListaVenda.Count.ToString();

            PessoaNegocios pessoaNegocios = new PessoaNegocios();
            venda.Pessoa = pessoaNegocios.ConsultaPorID(venda.Pessoa.PessoaID)[0];

            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            venda.Usuario = usuarioNegocios.ConsultaPorID(venda.Usuario.UsuarioID);
            txtNomeUsuario.Text = venda.Usuario.UsuarioNome;
            txtPessoa.Text = venda.Pessoa.PessoaID.ToString();
            txtCPF.Text = venda.Pessoa.PessoaFisica.PessoaFisicaCPF;
            txtNome.Text = venda.Pessoa.PessoaFisica.PessoaFisicaNome;
            txtCNPJ.Text = venda.Pessoa.PessoaJuridica.PessoaJuridicaCNPJ;
            txtNomeFicticio.Text = venda.Pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio;
            txtRazaoSocial.Text = venda.Pessoa.PessoaJuridica.PessoaJuridicaRazaoSocial;
        }

        private void dgvAnimais_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvAnimais.Rows[e.RowIndex].DataBoundItem != null) && (dgvAnimais.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvAnimais.Rows[e.RowIndex].DataBoundItem, dgvAnimais.Columns[e.ColumnIndex].DataPropertyName);
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

        private void dgvAnimaisRemocao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvAnimaisRemocao.Rows[e.RowIndex].DataBoundItem != null) && (dgvAnimaisRemocao.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvAnimaisRemocao.Rows[e.RowIndex].DataBoundItem, dgvAnimaisRemocao.Columns[e.ColumnIndex].DataPropertyName);
            }
        }

        private void dgvAnimaisNovos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvAnimaisNovos.Rows[e.RowIndex].DataBoundItem != null) && (dgvAnimaisNovos.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvAnimaisNovos.Rows[e.RowIndex].DataBoundItem, dgvAnimaisNovos.Columns[e.ColumnIndex].DataPropertyName);
            }
        }
    }
}
