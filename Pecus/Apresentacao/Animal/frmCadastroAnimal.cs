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

using Negocios;
using ObjetoTransferencia;

namespace Apresentacao.Animal
{
    public partial class frmCadastroAnimal : Form
    {
        private bool retorno;
        public ObjetoTransferencia.Animal animalRetorno { get; set; }
        private ObjetoTransferencia.Piquete piquete = new ObjetoTransferencia.Piquete();
        public frmCadastroAnimal(bool retornoP)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));

            try
            {
                RacaNegocios racaNegocios = new RacaNegocios();
                RacaCollection racas = new RacaCollection();
                racas = racaNegocios.ConsultaPorNome("");
                if (racas.Count == 0)
                {
                    MessageBox.Show("Não há raças cadastradas. Por favor, cadastre raças antes de proceder.", "Não há raças cadastradas.");
                    Close();
                }
                else
                {
                    cbbRaca.DisplayMember = "RacaNome";
                    cbbRaca.ValueMember = "RacaID";
                    cbbRaca.DataSource = racas;
                    cbbRaca.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Close();
            }

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

        private void btnBuscarPiquete_Click(object sender, EventArgs e)
        {
            try
            {
                Piquete.frmConsultaPiquete frmConsultaPiquete = new Piquete.frmConsultaPiquete(true);
                frmConsultaPiquete.ShowDialog();
                if (frmConsultaPiquete.piquete.PiqueteID != 0)
                {
                    txtPiquete.Text = frmConsultaPiquete.piquete.PiqueteID.ToString();
                    piquete = frmConsultaPiquete.piquete;
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void TxtDescricao_Enter(object sender, EventArgs e)
        {
            if(txtDescricao.ForeColor == Color.DarkGray)
            {
                txtDescricao.Text = "";
                txtDescricao.ForeColor = Color.Black;
            }
        }

        private void TxtDescricao_Leave(object sender, EventArgs e)
        {
            if(txtDescricao.Text == "")
            {
                txtDescricao.Text = "Descreva informações importantes para o animal, informações que o identifique e/ou são importantes para sua criação.";
                txtDescricao.ForeColor = Color.DarkGray;
            }
        }

        private void TxtLocalidade_Leave(object sender, EventArgs e)
        {
            if(txtLocalidade.Text == "")
            {
                txtLocalidade.Text = "Descreva informações que identifique a localidade de nascimento do animal.";
                txtLocalidade.ForeColor = Color.DarkGray;
            }
        }

        private void TxtLocalidade_Enter(object sender, EventArgs e)
        {
            if (txtLocalidade.ForeColor == Color.DarkGray)
            {
                txtLocalidade.Text = "";
                txtLocalidade.ForeColor = Color.Black;
            }
        }

        private void BtnBuscarAnimalMae_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaAnimal frmConsultaAnimal = new frmConsultaAnimal(true);
                frmConsultaAnimal.ShowDialog();
                if (frmConsultaAnimal.animalRetorno.AnimalID != 0)
                    txtMae.Text = frmConsultaAnimal.animalRetorno.AnimalID.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnConsultaAnimalPai_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaAnimal frmConsultaAnimal = new frmConsultaAnimal(true);
                frmConsultaAnimal.ShowDialog();
                if (frmConsultaAnimal.animalRetorno.AnimalID != 0)
                    txtPai.Text = frmConsultaAnimal.animalRetorno.AnimalID.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescricao.Text.Trim() == string.Empty)
                    MessageBox.Show("Por favor, preencha a descrição.", "Informe a descrição.");
                else if (txtIdentificador.Text.Trim() == string.Empty)
                    MessageBox.Show("Por favor, informe o identificador do animal.", "Informe o identificador");
                else if (txtPiquete.Text.Trim() == string.Empty || txtPiquete.Text == "0")
                    MessageBox.Show("Por favor, informe o piquete do animal.", "Informe o piquete");
                else if(txtPeso.Text.Trim() == string.Empty)
                    MessageBox.Show("Por favor, informe o peso do animal.", "Informe o peso");
                else
                {
                    AnimalNegocios animalNegocios = new AnimalNegocios();
                    ObjetoTransferencia.Animal animal = new ObjetoTransferencia.Animal();
                    animal.Piquete = new ObjetoTransferencia.Piquete();
                    animal.Raca = new ObjetoTransferencia.Raca();
                    animal.AnimalParentescoMae = new ObjetoTransferencia.Animal();
                    animal.AnimalParentescoPai = new ObjetoTransferencia.Animal();
                    animal.Pesagens = new PesagemCollection();

                    animal.AnimalDescricao = txtDescricao.Text.Trim();
                    animal.AnimalIdentificador = txtIdentificador.Text.Trim();
                    animal.Raca.RacaID = int.Parse(cbbRaca.SelectedValue.ToString());
                    animal.Raca.RacaNome = cbbRaca.Text;
                    animal.Piquete.PiqueteID = int.Parse(txtPiquete.Text);
                    animal.Piquete.PiqueteDescricao = piquete.PiqueteDescricao;
                    animal.AnimalParentescoMae.AnimalID = int.Parse(txtMae.Text);
                    animal.AnimalParentescoPai.AnimalID = int.Parse(txtPai.Text);
                    animal.AnimalDataNascimento = dtpDataNascimento.Value;
                    if(txtLocalidade.ForeColor != Color.DarkGray && txtLocalidade.Text != "Descreva informações que identifique a localidade de nascimento do animal.")
                        animal.AnimalLocalidadeNascimento = txtLocalidade.Text.Trim();

                    ObjetoTransferencia.Pesagem pesagem = new Pesagem();
                    pesagem.PesagemData = dtpDataNascimento.Value;
                    pesagem.PesagemPeso = Convert.ToDecimal(txtPeso.Text);
                    animal.Pesagens.Add(pesagem);

                    if (retorno)
                    {
                        animalRetorno = animal;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Animal de ID " + animalNegocios.Cadastrar(animal) + " cadastrado com sucesso!", "Animal cadastrado com sucesso!");
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Tente novamente.");
            }
        }

        private void FrmCadastroAnimal_Load(object sender, EventArgs e)
        {

        }

        private void TxtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }

        private void dtpDataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
