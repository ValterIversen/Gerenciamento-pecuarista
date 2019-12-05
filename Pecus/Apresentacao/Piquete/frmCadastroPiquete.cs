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

using ObjetoTransferencia;
using Negocios;
using System.Reflection;

namespace Apresentacao.Piquete
{
    public partial class frmCadastroPiquete : Form
    {
        public ObjetoTransferencia.Piquete piquete { get; set; }
        private ObjetoTransferencia.Piquete piqueteOutro = new ObjetoTransferencia.Piquete();
        private ObjetoTransferencia.Animal animalEmQuestao = new ObjetoTransferencia.Animal();
        private ObjetoTransferencia.AnimalCollection animaisOutrosPiquetes = new AnimalCollection();
        public frmCadastroPiquete(AnimalCollection animalCollection)
        {
            InitializeComponent();

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));

            piquete = new ObjetoTransferencia.Piquete();
            piquete.Animais = new AnimalCollection();
            piquete.Pasto = new ObjetoTransferencia.Pasto();
            animaisOutrosPiquetes = animalCollection;

            dgvAnimaisAtual.AutoGenerateColumns = false;
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

        private void PicArrowLeftAnimal_Click(object sender, EventArgs e)
        {
            bool verif = false;
            for (int i = 0; i < piquete.Animais.Count; i++)
                if (piquete.Animais[i].AnimalID == animalEmQuestao.AnimalID)
                    verif = true;

            if (!verif)
            {
                animalEmQuestao.Piquete.PiqueteID = piquete.PiqueteID;
                piquete.Animais.Add(animalEmQuestao);
                animalEmQuestao = new ObjetoTransferencia.Animal();
                txtAnimalID.Text = "0";
            }

            dgvAnimaisAtual.DataSource = null;

            dgvAnimaisAtual.DataSource = piquete.Animais;
        }

        private void PicArrowLeftPiquete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAnimaisOutroPiquete.SelectedRows.Count; i++)
            {
                bool verif = true;
                for (int x = 0; x < animaisOutrosPiquetes.Count; x++)
                {
                    if (animaisOutrosPiquetes.Count <= x)
                    {
                        if (int.Parse(dgvAnimaisAtual.SelectedRows[i].Cells[0].Value.ToString()) == animaisOutrosPiquetes[x].AnimalID)
                        {
                            verif = false;
                            break;
                        }
                    }
                }
                if (verif) {
                    for (int x = 0; x < piqueteOutro.Animais.Count; x++)
                    {
                        if (piqueteOutro.Animais[x].AnimalID == int.Parse(dgvAnimaisOutroPiquete.SelectedRows[i].Cells[0].Value.ToString()))
                        {
                            piqueteOutro.Animais[x].Piquete.PiqueteID = piquete.PiqueteID;
                            piquete.Animais.Add(piqueteOutro.Animais[x]);
                            piqueteOutro.Animais.RemoveAt(x);
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Esse animal já foi colocado em um piquete anterior.", "Animal já foi selecionado anteriormente.");
                }
            }

            dgvAnimaisOutroPiquete.DataSource = null;
            dgvAnimaisAtual.DataSource = null;

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
                        piquete.Animais[x].Piquete.PiqueteID = piqueteOutro.PiqueteID;
                        animaisOutrosPiquetes.Add(piquete.Animais[x]);
                        piqueteOutro.Animais.Add(piquete.Animais[x]);
                        piquete.Animais.RemoveAt(x);
                    }
                }
            }

            dgvAnimaisOutroPiquete.DataSource = null;
            dgvAnimaisAtual.DataSource = null;

            dgvAnimaisOutroPiquete.DataSource = piqueteOutro.Animais;
            dgvAnimaisAtual.DataSource = piquete.Animais;
        }

        private void BtnBuscarPiquete_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultaPiquete frmConsultaPiquete = new frmConsultaPiquete(true);
                frmConsultaPiquete.ShowDialog();
                if (frmConsultaPiquete.piquete != null)
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
                                break;
                            }
                        }
                    }
                    for (int i = 0; i < animaisOutrosPiquetes.Count; i++)
                    {
                        if (animaisOutrosPiquetes[i].Piquete.PiqueteID == piqueteOutro.PiqueteID)
                            piqueteOutro.Animais.Add(animaisOutrosPiquetes[i]);
                    }
                    dgvAnimaisOutroPiquete.DataSource = null;
                    dgvAnimaisOutroPiquete.DataSource = piqueteOutro.Animais;
                }
            }
            catch (Exception ex)
            {

            }
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescricao.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Por favor, informe a descrição.", "Informe a descrição.");
                }
                else
                {
                    piquete.PiqueteDescricao = txtDescricao.Text.Trim();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro.");
            }
        }

        private void DgvAnimaisOutroPiquete_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvAnimaisOutroPiquete.Rows[e.RowIndex].DataBoundItem != null) && (dgvAnimaisOutroPiquete.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvAnimaisOutroPiquete.Rows[e.RowIndex].DataBoundItem, dgvAnimaisOutroPiquete.Columns[e.ColumnIndex].DataPropertyName);
            }
        }

        private void DgvAnimaisAtual_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvAnimaisAtual.Rows[e.RowIndex].DataBoundItem != null) && (dgvAnimaisAtual.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvAnimaisAtual.Rows[e.RowIndex].DataBoundItem, dgvAnimaisAtual.Columns[e.ColumnIndex].DataPropertyName);
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
    }
}
