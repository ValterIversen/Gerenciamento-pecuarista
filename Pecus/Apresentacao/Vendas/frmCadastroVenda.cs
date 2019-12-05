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
using System.Runtime.InteropServices;
using System.Reflection;

namespace Apresentacao.Vendas
{
    public partial class frmCadastroVenda : Form
    {

        private Venda venda = new Venda();
        private ObjetoTransferencia.Piquete piqueteOutro = new ObjetoTransferencia.Piquete();
        private ObjetoTransferencia.Animal animalSel = new ObjetoTransferencia.Animal();

        public frmCadastroVenda(ObjetoTransferencia.Usuario usuario)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            tabControl.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tabControl.Width, tabControl.Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));
            panelInside2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside2.Width, panelInside2.Height, 20, 20));
            panelInside3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside3.Width, panelInside3.Height, 20, 20));

            venda.Animais = new AnimalCollection();
            venda.Usuario = usuario;

            dgvAnimais.AutoGenerateColumns = false;
            dgvAnimaisOutroPiquete.AutoGenerateColumns = false;
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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAnimais.SelectedRows.Count; i++)
            {
                for (int x = 0; x < venda.Animais.Count; x++)
                {
                    if (int.Parse(dgvAnimais.SelectedRows[i].Cells[0].Value.ToString()) == venda.Animais[x].AnimalID)
                    {
                        venda.Animais.RemoveAt(x);
                    }
                }
            }

            dgvAnimais.DataSource = null;
            dgvAnimais.DataSource = venda.Animais;
        }

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

        private void btnBuscarPiquete_Click(object sender, EventArgs e)
        {
            try
            {
                Piquete.frmConsultaPiquete frmConsultaPiquete = new Piquete.frmConsultaPiquete(true);
                frmConsultaPiquete.ShowDialog();
                if (frmConsultaPiquete.piquete != null)
                {
                    piqueteOutro = frmConsultaPiquete.piquete;
                    txtPiqueteOutroID.Text = piqueteOutro.PiqueteID.ToString();

                    piqueteOutro.Animais = new AnimalCollection();
                    AnimalNegocios animalNegocios = new AnimalNegocios();
                    piqueteOutro.Animais = animalNegocios.ConsultaPorPiquete(piqueteOutro.PiqueteID);

                    for (int i = 0; i < venda.Animais.Count; i++)
                    {
                        for (int x = 0; x < piqueteOutro.Animais.Count; x++)
                        {
                            if (venda.Animais[i].AnimalID == piqueteOutro.Animais[x].AnimalID)
                            {
                                piqueteOutro.Animais.RemoveAt(x);
                                break;
                            }
                        }
                    }
                    dgvAnimaisOutroPiquete.DataSource = null;
                    dgvAnimaisOutroPiquete.DataSource = piqueteOutro.Animais;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAnimais.SelectedRows.Count; i++)
            {
                for (int x = 0; x < venda.Animais.Count; x++)
                {
                    if (int.Parse(dgvAnimais.SelectedRows[i].Cells[0].Value.ToString()) == venda.Animais[x].AnimalID)
                    {
                        venda.Animais.RemoveAt(x);
                        break;
                    }
                }
            }

            dgvAnimais.DataSource = null;
            dgvAnimais.DataSource = venda.Animais;
            UpdateValor();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            decimal valor = 0;
            if (decimal.TryParse(txtValorAnimalOutroPiquete.Text, out valor))
            {
                if (valor <= 0)
                {
                    MessageBox.Show("Por favor, informe o valor do animal.", "Informe o valor do animal.");
                }
                else
                {
                    lblValorANimalPiquete.Visible = false;
                    for (int i = 0; i < dgvAnimaisOutroPiquete.SelectedRows.Count; i++)
                    {
                        for (int x = 0; x < piqueteOutro.Animais.Count; x++)
                        {
                            if (int.Parse(dgvAnimaisOutroPiquete.SelectedRows[i].Cells[0].Value.ToString()) == piqueteOutro.Animais[x].AnimalID)
                            {
                                piqueteOutro.Animais[x].AnimalValor = valor;
                                venda.Animais.Add(piqueteOutro.Animais[x]);
                                piqueteOutro.Animais.RemoveAt(x);
                                break;
                            }
                        }
                    }

                    dgvAnimaisOutroPiquete.DataSource = null;
                    dgvAnimaisOutroPiquete.DataSource = piqueteOutro.Animais;
                    dgvAnimais.DataSource = null;
                    dgvAnimais.DataSource = venda.Animais;
                    UpdateValor();
                }
            }
            else
                lblValorANimalPiquete.Visible = true;
        }

        private void UpdateValor()
        {
            lblQuantidade.Text = venda.Animais.Count.ToString();
            venda.VendaValorTotal = 0;
            for (int i = 0; i < venda.Animais.Count; i++)
            {
                venda.VendaValorTotal += venda.Animais[i].AnimalValor;
            }
            txtValorTotal.Text = venda.VendaValorTotal.ToString();
        }

        private void btnAdicionarIndividual_Click(object sender, EventArgs e)
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
                    if (animalSel.AnimalID != 0)
                    {
                        bool verif = false;
                        for (int i = 0; i < venda.Animais.Count; i++)
                        {
                            if (animalSel.AnimalID == venda.Animais[i].AnimalID)
                                verif = true;
                        }
                        if (!verif)
                        {
                            animalSel.AnimalValor = valor;
                            venda.Animais.Add(animalSel);
                            dgvAnimais.DataSource = null;
                            dgvAnimais.DataSource = venda.Animais;
                            UpdateValor();
                        }
                    }
                }
            }
            else
                lblInformeValorAnimal.Visible = true;
        }

        private void btnConsultarAnimal_Click(object sender, EventArgs e)
        {
            Animal.frmConsultaAnimal frmConsultaAnimal = new Animal.frmConsultaAnimal(true);
            frmConsultaAnimal.ShowDialog();
            if(frmConsultaAnimal.animalRetorno.AnimalID != 0)
            {
                animalSel = frmConsultaAnimal.animalRetorno;
                txtAnimalID.Text = animalSel.AnimalID.ToString();
            }

        }

        private void dgvAnimais_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void dgvAnimaisOutroPiquete_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvAnimaisOutroPiquete.Rows[e.RowIndex].DataBoundItem != null) && (dgvAnimaisOutroPiquete.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvAnimaisOutroPiquete.Rows[e.RowIndex].DataBoundItem, dgvAnimaisOutroPiquete.Columns[e.ColumnIndex].DataPropertyName);
            }
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

        private void txtValorAnimalOutroPiquete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtValorAnimalOutroPiquete.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;
            else
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }

        private void txtValorAnimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtValorAnimal.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;
            else
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (venda.Animais.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione algum animal.", "Selecione algum animal.");
                }
                else if (venda.Pessoa.PessoaID == 0)
                {
                    MessageBox.Show("Por favor, selecione o vendedor dos animais.", "Selecione o vendedor.");
                }
                else if (txtValorTotal.Text == "" || txtValorTotal.Text == "0")
                {
                    MessageBox.Show("Por favor, informe o valor total da compra.", "Informe o valor total.");
                }
                else
                {
                    venda.VendaData = dtpData.Value;
                    venda.VendaDataEntrega = dtpDataEntrega.Value;

                    for (int i = 0; i < venda.Animais.Count; i++)
                    {
                        venda.Animais[i].AnimalAtivo = false;
                    }

                    VendaNegocios vendaNegocios = new VendaNegocios();
                    MessageBox.Show("Venda de ID " + vendaNegocios.Cadastrar(venda) + " cadastrada com sucesso!", "Venda cadastrada com sucesso!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro.");
            }
        }
    }
}
