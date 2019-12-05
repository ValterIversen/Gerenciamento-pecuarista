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

namespace Apresentacao.Compras
{
    public partial class frmCadastroCompras : Form
    {
        private Compra compra = new Compra();
        private ObjetoTransferencia.Piquete piqueteOutro = new ObjetoTransferencia.Piquete();
        private int countID = 0;
        public frmCadastroCompras(ObjetoTransferencia.Usuario usuario)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            tabControl.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tabControl.Width, tabControl.Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));
            panelInside2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside2.Width, panelInside2.Height, 20, 20));
            panelInside3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside3.Width, panelInside3.Height, 20, 20));

            compra.Animais = new AnimalCollection();
            compra.Usuario = usuario;
            compra.Pessoa = new ObjetoTransferencia.Pessoa();
            dgvAnimais.AutoGenerateColumns = false;

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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAnimais.SelectedRows.Count; i++)
            {
                for (int x = 0; x < compra.Animais.Count; x++)
                {
                    if (int.Parse(dgvAnimais.SelectedRows[i].Cells[0].Value.ToString()) == compra.Animais[x].AnimalID)
                    {
                        compra.Animais.RemoveAt(x);
                        break;
                    }
                }
            }

            updateValorTotal();

            dgvAnimais.DataSource = null;
            dgvAnimais.DataSource = compra.Animais;
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

        private void btnAdicionar_Click_1(object sender, EventArgs e)
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
                    Animal.frmCadastroAnimal frmCadastroAnimal = new Animal.frmCadastroAnimal(true);
                    frmCadastroAnimal.ShowDialog();
                    if (frmCadastroAnimal.animalRetorno != null)
                    {
                        countID++;
                        ObjetoTransferencia.Animal animal = new ObjetoTransferencia.Animal();
                        animal = frmCadastroAnimal.animalRetorno;
                        animal.AnimalID = countID;
                        animal.AnimalValor = valor;
                        compra.Animais.Add(animal);
                        dgvAnimais.DataSource = null;
                        dgvAnimais.DataSource = compra.Animais;
                        updateValorTotal();
                    }
                }
            }
            else
                lblInformeValorAnimal.Visible = true;

        }

        private void updateValorTotal()
        {
            lblQuantidade.Text = compra.Animais.Count.ToString();
            compra.CompraValorTotal = 0;
            for (int i = 0; i < compra.Animais.Count; i++)
            {
                compra.CompraValorTotal += compra.Animais[i].AnimalValor;
            }
            txtValorTotal.Text = compra.CompraValorTotal.ToString();
        }

        private void btnBuscarPessoa_Click(object sender, EventArgs e)
        {
            Pessoa.frmConsultaPessoa frmConsultaPessoa = new Pessoa.frmConsultaPessoa(true);
            frmConsultaPessoa.ShowDialog();
            if(frmConsultaPessoa.pessoaRetorno.PessoaID != 0)
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

        private void txtValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtValorTotal.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;
            else
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(compra.Animais.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione algum animal.","Selecione algum animal.");
                }
                else if(compra.Pessoa.PessoaID == 0)
                {
                    MessageBox.Show("Por favor, selecione o vendedor dos animais.", "Selecione o vendedor.");
                }
                else if(txtValorTotal.Text == "" || txtValorTotal.Text == "0")
                {
                    MessageBox.Show("Por favor, informe o valor total da compra.", "Informe o valor total.");
                }
                else
                {
                    compra.CompraData = dtpData.Value;
                    compra.CompraDataEntrega = dtpDataEntrega.Value;

                    CompraNegocios compraNegocios = new CompraNegocios();
                    MessageBox.Show("Compra de ID " + compraNegocios.Cadastrar(compra) + " cadastrada com sucesso!", "Compra cadastrada com sucesso!");
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro.");
            }
        }

        private void txtValorAnimal_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (txtValorAnimal.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;
            else
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }
    }
}
