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

namespace Apresentacao.ConsultaVeterinaria
{
    public partial class frmAlterarConsultaVeterinaria : Form
    {
        ObjetoTransferencia.ConsultaVeterinaria consulta = new ObjetoTransferencia.ConsultaVeterinaria();
        public frmAlterarConsultaVeterinaria(ObjetoTransferencia.ConsultaVeterinaria consultaP)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));

            dtpData.MaxDate = DateTime.Now;
            dgvVeterinarios.AutoGenerateColumns = false;
            consulta = consultaP;

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

        private void btnBuscarAnimal_Click(object sender, EventArgs e)
        {
            Animal.frmConsultaAnimal frmConsultaAnimal = new Animal.frmConsultaAnimal(true);
            frmConsultaAnimal.ShowDialog();
            if (frmConsultaAnimal.animalRetorno.AnimalID != 0)
            {
                consulta.Animal = frmConsultaAnimal.animalRetorno;
                txtAnimal.Text = consulta.Animal.AnimalID.ToString();
                txtAnimalDescricao.Text = consulta.Animal.AnimalDescricao;
                txtIdentificador.Text = consulta.Animal.AnimalIdentificador.ToString();
                txtPiquete.Text = consulta.Animal.Piquete.PiqueteID.ToString();
                cbbRaca.SelectedValue = consulta.Animal.Raca.RacaID;
                ckbAtivo.Checked = consulta.Animal.AnimalAtivo;
            }
        }

        private void dgvVeterinarios_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < consulta.Veterinarios.Count; i++)
            {
                if(consulta.Veterinarios[i].VeterinarioID == int.Parse(dgvVeterinarios.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    Veterinario.frmAlteracaoVeterinario frmAlteracaoVeterinario = new Veterinario.frmAlteracaoVeterinario(consulta.Veterinarios[i]);
                    frmAlteracaoVeterinario.ShowDialog();
                }
            }
        }

        private void dgvVeterinarios_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvVeterinarios.Rows[e.RowIndex].DataBoundItem != null) && (dgvVeterinarios.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvVeterinarios.Rows[e.RowIndex].DataBoundItem, dgvVeterinarios.Columns[e.ColumnIndex].DataPropertyName);
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

        private void frmAlterarConsultaVeterinaria_Load(object sender, EventArgs e)
        {
            RacaNegocios racaNegocios = new RacaNegocios();
            cbbRaca.DisplayMember = "RacaNome";
            cbbRaca.ValueMember = "RacaID";
            cbbRaca.DataSource = racaNegocios.ConsultaPorNome("");

            dtpData.Value = consulta.ConsultaVeterinariaData;
            txtCusto.Text = consulta.ConsultaVeterinariaCusto.ToString();
            txtDescricao.Text = consulta.ConsultaVeterinariaDescricao;

            txtAnimal.Text = consulta.Animal.AnimalID.ToString();
            txtAnimalDescricao.Text = consulta.Animal.AnimalDescricao;
            txtIdentificador.Text = consulta.Animal.AnimalIdentificador.ToString();
            txtPiquete.Text = consulta.Animal.Piquete.PiqueteID.ToString();
            cbbRaca.SelectedValue = consulta.Animal.Raca.RacaID;
            ckbAtivo.Checked = consulta.Animal.AnimalAtivo;

            ListaVeterinarioNegocios listaVeterinarioNegocios = new ListaVeterinarioNegocios();
            consulta.Veterinarios = listaVeterinarioNegocios.ConsultaPorConsultaVeterinaria(consulta.ConsultaVeterinariaID);

            dgvVeterinarios.DataSource = consulta.Veterinarios;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCusto.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor, informe o custo.", "Informe o custo.");
                }
                else if (txtDescricao.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor, informe a descrição.", "Informe a descrição.");
                }
                else if (consulta.Animal.AnimalID == 0)
                {
                    MessageBox.Show("Por favor, informe o animal.", "Informe o animal.");
                }
                else
                {
                    consulta.ConsultaVeterinariaData = dtpData.Value;
                    consulta.ConsultaVeterinariaCusto = decimal.Parse(txtCusto.Text);
                    consulta.ConsultaVeterinariaDescricao = txtDescricao.Text.Trim();

                    ConsultaVeterinariaNegocios consultaVeterinariaNegocios = new ConsultaVeterinariaNegocios();
                    consultaVeterinariaNegocios.Alterar(consulta);
                    MessageBox.Show("Consulta veterinária de ID " + consulta.ConsultaVeterinariaID + " alterada com sucesso!",
                        "Consulta veterinária alterada com sucesso!");
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro.");
            }
        }
    }
}
