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

namespace Apresentacao.Pesagens
{
    public partial class frmCadastroPesagens : Form
    {
        PesagemCollection pesagens = new PesagemCollection();
        ObjetoTransferencia.Animal animalAtual = new ObjetoTransferencia.Animal();
        private int count = 0;
        public frmCadastroPesagens()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));

            dtpDataPesagem.MaxDate = DateTime.Now;
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

        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            Animal.frmConsultaAnimal frmConsultaAnimal = new Animal.frmConsultaAnimal(true);
            frmConsultaAnimal.ShowDialog();
            if (frmConsultaAnimal.animalRetorno.AnimalID != 0)
            {
                animalAtual = frmConsultaAnimal.animalRetorno;
                txtAnimal.Text = animalAtual.AnimalID.ToString();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                PesagemNegocios pesagemNegocios = new PesagemNegocios();
                if (pesagens.Count <= 0)
                {
                    MessageBox.Show("Por favor, adicione uma pesagem.","Adicione uma pesagem.");
                }
                else
                {
                    for (int i = 0; i < pesagens.Count; i++)
                    {
                        pesagemNegocios.Cadastrar(pesagens[i], pesagens[i].Animal.AnimalID);
                    }

                    MessageBox.Show("Pesagens cadastradas com sucesso!", "Pesagens cadastradas com sucesso!");
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve algum erro, por favor, tente novamente.", "Houve algum erro.");
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPeso.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;
            else
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtAnimal.Text == "" || txtAnimal.Text == "0")
            {
                MessageBox.Show("Por favor, selecione o animal.", "Selecione o animal.");
            }
            else if (txtPeso.Text == "" || txtPeso.Text == "0")
            {
                MessageBox.Show("Por favor, informe o peso.", "Informe o peso.");
            }
            else
            {
                Pesagem pesagem = new Pesagem();
                count++;
                pesagem.PesagemID = count;
                pesagem.PesagemData = dtpDataPesagem.Value;
                pesagem.PesagemPeso = decimal.Parse(txtPeso.Text);
                pesagem.Animal = animalAtual;

                pesagens.Add(pesagem);
                dgvPesagens.DataSource = null;
                dgvPesagens.DataSource = pesagens;
            }
        }

        private void dgvPesagens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvPesagens.Rows[e.RowIndex].DataBoundItem != null) && (dgvPesagens.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvPesagens.Rows[e.RowIndex].DataBoundItem, dgvPesagens.Columns[e.ColumnIndex].DataPropertyName);
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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPesagens.SelectedRows.Count; i++)
            {
                for (int x = 0; x < pesagens.Count; x++)
                {
                    if(int.Parse(dgvPesagens.SelectedRows[i].Cells[0].Value.ToString()) == pesagens[x].PesagemID)
                    {
                        pesagens.RemoveAt(x);
                        break;
                    }
                }
            }

            dgvPesagens.DataSource = null;
            dgvPesagens.DataSource = pesagens;
        }

        private void txtAnimal_TextChanged(object sender, EventArgs e)
        {
            if(txtAnimal.Text != "" && txtAnimal.Text != "0")
            {
                AnimalNegocios animalNegocios = new AnimalNegocios();
                animalAtual = animalNegocios.ConsultaPorID(int.Parse(txtAnimal.Text))[0];
            }
        }
    }
}
