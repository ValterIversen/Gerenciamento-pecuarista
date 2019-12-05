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
    public partial class frmAlterarAnimal : Form
    {
        private ObjetoTransferencia.Animal animal = new ObjetoTransferencia.Animal();
        public frmAlterarAnimal(ObjetoTransferencia.Animal animalP)
        {
            InitializeComponent();

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));

            animal = animalP;
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

        private void FrmAlterarAnimal_Load(object sender, EventArgs e)
        {
            try
            {
                txtDescricao.ForeColor = Color.Black;
                txtDescricao.Text = animal.AnimalDescricao;
                txtIdentificador.Text = animal.AnimalIdentificador;

                RacaNegocios racaNegocios = new RacaNegocios();
                cbbRaca.DisplayMember = "RacaNome";
                cbbRaca.ValueMember = "RacaID";
                cbbRaca.DataSource = racaNegocios.ConsultaPorNome("");
                cbbRaca.SelectedValue = animal.Raca.RacaID;

                txtPiquete.Text = animal.Piquete.PiqueteID.ToString();
                txtPai.Text = animal.AnimalParentescoPai.AnimalID.ToString();
                txtMae.Text = animal.AnimalParentescoMae.AnimalID.ToString();
                txtLocalidade.Text = animal.AnimalLocalidadeNascimento;
                if(animal.AnimalDataNascimento != null)
                    dtpDataNascimento.Value = animal.AnimalDataNascimento;
                ckbAtivo.Checked = animal.AnimalAtivo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao carregar as raças. Tente novamente.", "Erro ao abrir o formulário.");
                Close();
            }
        }

        private void BtnBuscarPiquete_Click(object sender, EventArgs e)
        {
            try
            {
                Piquete.frmConsultaPiquete frmConsultaPiquete = new Piquete.frmConsultaPiquete(true);
                frmConsultaPiquete.ShowDialog();
                if (frmConsultaPiquete.piquete.PiqueteID != 0)
                    txtPiquete.Text = frmConsultaPiquete.piquete.PiqueteID.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void BtnConsultaAnimalPai_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaAnimal frmConsultaAnimal = new frmConsultaAnimal(true);
                frmConsultaAnimal.ShowDialog();
                if (frmConsultaAnimal.animalRetorno.AnimalID != 0)
                    txtPai.Text = frmConsultaAnimal.animalRetorno.AnimalID.ToString();
            }
            catch (Exception ex)
            {

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
            catch (Exception ex)
            {

            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtDescricao.ForeColor == Color.DarkGray || txtDescricao.Text == string.Empty)
                {
                    MessageBox.Show("Por favor, informe a descrição.", "Informe a descrição.");
                }
                else if(txtIdentificador.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor, informe o identificador.", "Informe o identificador.");
                }
                else
                {
                    AnimalNegocios animalNegocios = new AnimalNegocios();

                    animal.AnimalDescricao = txtDescricao.Text.Trim();
                    animal.AnimalIdentificador = txtIdentificador.Text.Trim();
                    animal.Raca.RacaID = int.Parse(cbbRaca.SelectedValue.ToString());
                    animal.Piquete.PiqueteID = int.Parse(txtPiquete.Text);
                    animal.AnimalParentescoPai.AnimalID = int.Parse(txtPai.Text);
                    animal.AnimalParentescoMae.AnimalID = int.Parse(txtMae.Text);
                    animal.AnimalLocalidadeNascimento = txtLocalidade.Text.Trim();
                    animal.AnimalDataNascimento = dtpDataNascimento.Value;

                    if (ckbAtivo.Checked != animal.AnimalAtivo)
                    {
                        if (MessageBox.Show("Você tem certeza que deseja desativar o animal?", "Confirme sua decisão.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            animal.AnimalAtivo = ckbAtivo.Checked;
                            animalNegocios.Alterar(animal);
                            MessageBox.Show("Animal de ID " + animal.AnimalID + " alterado com sucesso!", "Alteração realizada com sucesso!");
                            Close();
                        }
                    }
                    else
                    {
                        animalNegocios.Alterar(animal);
                        MessageBox.Show("Animal de ID " + animal.AnimalID + " alterado com sucesso!", "Alteração realizada com sucesso!");
                        Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro.");
            }
        }

        private void TxtDescricao_Enter(object sender, EventArgs e)
        {
            if (txtDescricao.ForeColor == Color.DarkGray)
            {
                txtDescricao.Text = "";
                txtDescricao.ForeColor = Color.Black;
            }
        }

        private void TxtDescricao_Leave(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                txtDescricao.Text = "Descreva informações importantes para o animal, informações que o identifique e/ou são importantes para sua criação.";
                txtDescricao.ForeColor = Color.DarkGray;
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

        private void TxtLocalidade_Leave(object sender, EventArgs e)
        {

            if (txtLocalidade.Text == "")
            {
                txtLocalidade.Text = "Descreva informações que identifique a localidade de nascimento do animal.";
                txtLocalidade.ForeColor = Color.DarkGray;
            }
        }
    }
}
