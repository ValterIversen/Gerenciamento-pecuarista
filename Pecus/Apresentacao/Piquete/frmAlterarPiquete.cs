using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;
using System.Reflection;
using Microsoft.Reporting.WebForms;

namespace Apresentacao.Piquete
{
    public partial class frmAlterarPiquete : Form
    {
        private ObjetoTransferencia.Piquete piquete = new ObjetoTransferencia.Piquete();
        private ObjetoTransferencia.Piquete piqueteOutro = new ObjetoTransferencia.Piquete();
        private ObjetoTransferencia.Animal animalEmQuestao = new ObjetoTransferencia.Animal();
        private ObjetoTransferencia.AnimalCollection animaisOutrosPiquetes = new AnimalCollection();
        public frmAlterarPiquete(ObjetoTransferencia.Piquete piqueteP)
        {
            InitializeComponent();
            piquete = piqueteP;

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));

            dgvAnimaisAtual.AutoGenerateColumns = false;
            dgvAnimaisOutroPiquete.AutoGenerateColumns = false;
            ckbAtivo.Checked = piquete.PiqueteAtivo;
            txtDescricao.Text = piquete.PiqueteDescricao;

            try
            {
                piquete.Animais = new AnimalCollection();
                AnimalNegocios animalNegocios = new AnimalNegocios();
                piquete.Animais = animalNegocios.ConsultaPorPiquete(piquete.PiqueteID);
                dgvAnimaisAtual.DataSource = piquete.Animais;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro ao carregar o formulário, por favor, tente novamente.", "Houve um erro.");
                Close();
            }
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

        private void BtnConsultarAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                Animal.frmConsultaAnimal frmConsultaAnimal = new Animal.frmConsultaAnimal(true);
                frmConsultaAnimal.ShowDialog();
                if (frmConsultaAnimal.animalRetorno.AnimalID != 0)
                {
                    animalEmQuestao = frmConsultaAnimal.animalRetorno;
                    txtAnimalID.Text = animalEmQuestao.AnimalID.ToString();
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void BtnBuscarPiquete_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaPiquete frmConsultaPiquete = new frmConsultaPiquete(true);
                frmConsultaPiquete.ShowDialog();
                if(frmConsultaPiquete.piquete != null)
                {
                    piqueteOutro = frmConsultaPiquete.piquete;
                    txtPiqueteOutroID.Text = piqueteOutro.PiqueteID.ToString();

                    piqueteOutro.Animais = new AnimalCollection();
                    AnimalNegocios animalNegocios = new AnimalNegocios();
                    piqueteOutro.Animais = animalNegocios.ConsultaPorPiquete(piqueteOutro.PiqueteID);

                    for (int i = 0; i < piquete.Animais.Count; i++)
                    {
                        for (int x = 0; x < piqueteOutro.Animais.Count; x++)
                        {
                            if (piquete.Animais[i].AnimalID == piqueteOutro.Animais[x].AnimalID)
                            {
                                piqueteOutro.Animais.RemoveAt(x);
                            }
                        }
                    }
                    for (int i = 0; i < animaisOutrosPiquetes.Count; i++)
                    {
                        if (animaisOutrosPiquetes[i].Piquete.PiqueteID == piqueteOutro.PiqueteID)
                            piqueteOutro.Animais.Add(animaisOutrosPiquetes[i]);
                    }
                    dgvAnimaisOutroPiquete.DataSource = piqueteOutro.Animais;
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean verif = true;
                if (txtDescricao.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Por favor, informe a descrição.", "Informe a descrição.");
                    verif = false;
                }
                else if (ckbAtivo.Checked != piquete.PiqueteAtivo)
                {
                    if(piquete.Animais.Count != 0)
                    {
                        MessageBox.Show("Não é possível realizar a inativação de um pasto com animais, por favor, transfira os animais para outro piquete.", "Transfira os animais.");
                        verif = false;
                    }
                    else
                    {
                        if(MessageBox.Show("Você deseja realmente desativar o piquete? Ele ficará indisponível para realizar operações.", "Confirme sua escolha.", MessageBoxButtons.YesNo)== DialogResult.No)
                        {
                            verif = false;
                        }
                    }
                }
                if(verif)
                {
                    piquete.PiqueteDescricao = txtDescricao.Text.Trim();
                    PiqueteNegocios piqueteNegocios = new PiqueteNegocios();
                    piqueteNegocios.Alterar(piquete, animaisOutrosPiquetes);

                    MessageBox.Show("Piquete de ID " + piquete.PiqueteID + " alterado com sucesso!", "Alteração realizada com sucesso!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro.");
            }
        }

        private void PicArrowLeftAnimal_Click(object sender, EventArgs e)
        {
            bool verif = false;
            for (int i = 0; i < piquete.Animais.Count; i++)
                if(piquete.Animais[i].AnimalID == animalEmQuestao.AnimalID)
                    verif = true;

            if (!verif)
            {
                animalEmQuestao.Piquete.PiqueteID = piquete.PiqueteID;
                piquete.Animais.Add(animalEmQuestao);
                animalEmQuestao = new ObjetoTransferencia.Animal();
                txtAnimalID.Text = "0";
            }

            dgvAnimaisAtual.DataSource = piquete.Animais;
        }

        private void PicArrowLeftPiquete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAnimaisOutroPiquete.SelectedRows.Count; i++)
            {
                for (int x = 0; x < animaisOutrosPiquetes.Count; x++)
                {
                    if (animaisOutrosPiquetes[x].AnimalID == int.Parse(dgvAnimaisOutroPiquete.SelectedRows[i].Cells[0].Value.ToString()))
                    {
                        animaisOutrosPiquetes.RemoveAt(x);
                    }
                }
                for (int x = 0; x < piqueteOutro.Animais.Count; x++)
                {
                    if(piqueteOutro.Animais[x].AnimalID == int.Parse(dgvAnimaisOutroPiquete.SelectedRows[i].Cells[0].Value.ToString()))
                    {
                        piqueteOutro.Animais[x].Piquete.PiqueteID = piquete.PiqueteID;
                        piquete.Animais.Add(piqueteOutro.Animais[x]);
                        piqueteOutro.Animais.RemoveAt(x);
                    }
                }
            }

            dgvAnimaisOutroPiquete.DataSource = piqueteOutro.Animais;
            dgvAnimaisAtual.DataSource = piquete.Animais;
        }

        private void PicArrowRightPiquete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAnimaisAtual.SelectedRows.Count; i++)
            {
                for (int x = 0; x < piquete.Animais.Count; x++)
                {
                    if (piquete.Animais[x].AnimalID == int.Parse(dgvAnimaisAtual.SelectedRows[i].Cells[0].Value.ToString()))
                    {
                        piquete.Animais[x].Piquete.PiqueteID = int.Parse(txtPiqueteOutroID.Text);
                        animaisOutrosPiquetes.Add(piquete.Animais[x]);
                        piqueteOutro.Animais.Add(piquete.Animais[x]);
                        piquete.Animais.RemoveAt(x);
                    }
                }
            }

            dgvAnimaisOutroPiquete.DataSource = piqueteOutro.Animais;
            dgvAnimaisAtual.DataSource = piquete.Animais;
        }

    }
}
