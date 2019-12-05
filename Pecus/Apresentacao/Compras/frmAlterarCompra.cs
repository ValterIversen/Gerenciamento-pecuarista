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

namespace Apresentacao.Compras
{
    public partial class frmAlterarCompra : Form
    {
        private Compra compra = new Compra();
        private ListaCompraCollection animaisRemocaoListaCompra = new ListaCompraCollection();
        private ListaCompraCollection animaisListaCompra = new ListaCompraCollection();
        private AnimalCollection animaisNovosCompra = new AnimalCollection();
        private int countID = 0;
        public frmAlterarCompra(Compra compraP)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            tabControl.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tabControl.Width, tabControl.Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));
            panelInside2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside2.Width, panelInside2.Height, 20, 20));
            panelInside3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside3.Width, panelInside3.Height, 20, 20));

            compra = compraP;
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

        private void frmAlterarCompra_Load(object sender, EventArgs e)
        {
            dgvAnimais.AutoGenerateColumns = false;
            dgvAnimaisNovos.AutoGenerateColumns = false;
            dgvAnimaisRemocao.AutoGenerateColumns = false;

            ListaCompraNegocios listaCompraNegocios = new ListaCompraNegocios();

            animaisListaCompra = listaCompraNegocios.ConsultaPorCompra(compra.CompraID);

            AnimalNegocios animalNegocios = new AnimalNegocios();
            for (int i = 0; i < animaisListaCompra.Count; i++)
            {
                animaisListaCompra[i].Animal = animalNegocios.ConsultaPorID(animaisListaCompra[i].Animal.AnimalID)[0];
            }

            dgvAnimais.DataSource = null;
            dgvAnimais.DataSource = animaisListaCompra;


            dtpData.Value = compra.CompraData;
            dtpDataEntrega.Value = compra.CompraDataEntrega;
            txtValorTotal.Text = compra.CompraValorTotal.ToString();
            lblQuantidade.Text = animaisListaCompra.Count.ToString();

            PessoaNegocios pessoaNegocios = new PessoaNegocios();
            compra.Pessoa = pessoaNegocios.ConsultaPorID(compra.Pessoa.PessoaID)[0];

            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            compra.Usuario = usuarioNegocios.ConsultaPorID(compra.Usuario.UsuarioID);
            txtNomeUsuario.Text = compra.Usuario.UsuarioNome;
            txtPessoa.Text = compra.Pessoa.PessoaID.ToString();
            txtCPF.Text = compra.Pessoa.PessoaFisica.PessoaFisicaCPF;
            txtNome.Text = compra.Pessoa.PessoaFisica.PessoaFisicaNome;
            txtCNPJ.Text = compra.Pessoa.PessoaJuridica.PessoaJuridicaCNPJ;
            txtNomeFicticio.Text = compra.Pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio;
            txtRazaoSocial.Text = compra.Pessoa.PessoaJuridica.PessoaJuridicaRazaoSocial;
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAnimais.SelectedRows.Count; i++)
            {
                for (int x = 0; x < animaisListaCompra.Count; x++)
                {
                    if(int.Parse(dgvAnimais.SelectedRows[i].Cells[0].Value.ToString()) == animaisListaCompra[x].ListaCompraID)
                    {
                        animaisRemocaoListaCompra.Add(animaisListaCompra[x]);
                        animaisListaCompra.RemoveAt(x);
                        break;
                    }
                }
            }

            updateValorTotal();

            dgvAnimais.DataSource = null;
            dgvAnimais.DataSource = animaisListaCompra;
            dgvAnimaisRemocao.DataSource = null;
            dgvAnimaisRemocao.DataSource = animaisRemocaoListaCompra;
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

        private void updateValorTotal()
        {
            lblQuantidade.Text = (animaisListaCompra.Count + animaisNovosCompra.Count).ToString();
            compra.CompraValorTotal = 0;
            for (int i = 0; i < animaisListaCompra.Count; i++)
            {
                compra.CompraValorTotal += animaisListaCompra[i].ListaCompraValor;
            }
            for (int i = 0; i < animaisNovosCompra.Count; i++)
            {
                compra.CompraValorTotal += animaisNovosCompra[i].AnimalValor;
            }
            txtValorTotal.Text = compra.CompraValorTotal.ToString();
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
                    lblInformeValorAnimal.Visible = false;
                    for (int i = 0; i < dgvAnimais.SelectedRows.Count; i++)
                    {
                        for (int x = 0; x < animaisListaCompra.Count; x++)
                        {
                            if (int.Parse(dgvAnimais.SelectedRows[i].Cells[0].Value.ToString()) == animaisListaCompra[x].ListaCompraID)
                            {
                                animaisListaCompra[x].ListaCompraValor = valor;
                            }
                        }
                    }

                    dgvAnimais.DataSource = null;
                    dgvAnimais.DataSource = animaisListaCompra;
                    updateValorTotal();
                }
            }
            else
                lblInformeValorAnimal.Visible = true;

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            decimal valor = 0;
            if (decimal.TryParse(txtValorAnimaisNovos.Text, out valor))
            {
                if (valor <= 0)
                {
                    MessageBox.Show("Por favor, informe o valor do animal.", "Informe o valor do animal.");
                }
                else
                {
                    Animal.frmCadastroAnimal frmCadastroAnimal = new Animal.frmCadastroAnimal(true);
                    frmCadastroAnimal.ShowDialog();
                    if (frmCadastroAnimal.animalRetorno != null)
                    {
                        countID++;
                        ObjetoTransferencia.Animal animal = new ObjetoTransferencia.Animal();
                        animal = frmCadastroAnimal.animalRetorno;
                        animal.AnimalID = countID;
                        animal.AnimalValor = valor;
                        animaisNovosCompra.Add(animal);
                        dgvAnimaisNovos.DataSource = null;
                        dgvAnimaisNovos.DataSource = animaisNovosCompra;
                        updateValorTotal();
                    }
                }
            }
            else
                lblInformeValorAnimalNovo.Visible = true;
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
                        for (int x = 0; x < animaisNovosCompra.Count; x++)
                        {
                            if (int.Parse(dgvAnimaisNovos.SelectedRows[i].Cells[0].Value.ToString()) == animaisNovosCompra[x].AnimalID)
                            {
                                animaisNovosCompra[x].AnimalValor = valor;
                            }
                        }
                    }

                    dgvAnimaisNovos.DataSource = null;
                    dgvAnimaisNovos.DataSource = animaisNovosCompra;
                    updateValorTotal();
                }
            }
            else
                lblInformeValorAnimalNovo.Visible = true;
        }

        private void btnRemoverNovos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAnimaisNovos.SelectedRows.Count; i++)
            {
                for (int x = 0; x < animaisNovosCompra.Count; x++)
                {
                    if(int.Parse(dgvAnimaisNovos.SelectedRows[i].Cells[0].Value.ToString()) == animaisNovosCompra[x].AnimalID)
                    {
                        animaisNovosCompra.RemoveAt(x);
                        break;
                    }
                }
            }

            updateValorTotal();

            dgvAnimaisNovos.DataSource = null;
            dgvAnimaisNovos.DataSource = animaisNovosCompra;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAnimaisRemocao.SelectedRows.Count; i++)
            {
                for (int x = 0; x < animaisRemocaoListaCompra.Count; x++)
                {
                    if(int.Parse(dgvAnimaisRemocao.SelectedRows[i].Cells[0].Value.ToString()) == animaisRemocaoListaCompra[x].ListaCompraID)
                    {
                        animaisListaCompra.Add(animaisRemocaoListaCompra[x]);
                        animaisRemocaoListaCompra.RemoveAt(x);
                        break;
                    }
                }
            }

            updateValorTotal();

            dgvAnimais.DataSource = null;
            dgvAnimais.DataSource = animaisListaCompra;
            dgvAnimaisRemocao.DataSource = null;
            dgvAnimaisRemocao.DataSource = animaisRemocaoListaCompra;
        }

        private void btnBuscarPessoa_Click(object sender, EventArgs e)
        {
            Pessoa.frmConsultaPessoa frmConsultaPessoa = new Pessoa.frmConsultaPessoa(true);
            frmConsultaPessoa.ShowDialog();
            if (frmConsultaPessoa.pessoaRetorno.PessoaID != 0)
            {
                compra.Pessoa = frmConsultaPessoa.pessoaRetorno;
                txtPessoa.Text = compra.Pessoa.PessoaID.ToString();
                txtCPF.Text = compra.Pessoa.PessoaFisica.PessoaFisicaCPF;
                txtNome.Text = compra.Pessoa.PessoaFisica.PessoaFisicaNome;
                txtCNPJ.Text = compra.Pessoa.PessoaJuridica.PessoaJuridicaCNPJ;
                txtNomeFicticio.Text = compra.Pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio;
                txtRazaoSocial.Text = compra.Pessoa.PessoaJuridica.PessoaJuridicaRazaoSocial;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (animaisListaCompra.Count == 0 && animaisNovosCompra.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione algum animal.", "Selecione algum animal.");
                }
                else if (compra.Pessoa.PessoaID == 0)
                {
                    MessageBox.Show("Por favor, selecione o vendedor dos animais.", "Selecione o vendedor.");
                }
                else if (txtValorTotal.Text == "" || txtValorTotal.Text == "0")
                {
                    MessageBox.Show("Por favor, informe o valor total da compra.", "Informe o valor total.");
                }
                else
                {
                    compra.CompraDataEntrega = dtpDataEntrega.Value;

                    CompraNegocios compraNegocios = new CompraNegocios(); 

                    
                    compraNegocios.Alterar(compra, animaisListaCompra, animaisNovosCompra, animaisRemocaoListaCompra);

                    MessageBox.Show("Compra de ID " + compra.CompraID + " cadastrada com sucesso!", "Compra cadastrada com sucesso!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro.");
            }
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

        private void txtValorAnimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtValorAnimal.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;
            else
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }

        private void txtValorAnimaisNovos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtValorAnimaisNovos.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;
            else
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }
    }
}
