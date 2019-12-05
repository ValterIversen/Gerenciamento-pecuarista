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

namespace Apresentacao.ConsultaVeterinaria
{
    public partial class frmCadastroConsultaVeterinaria : Form
    {
        ObjetoTransferencia.Veterinario veterinario = new ObjetoTransferencia.Veterinario();
        ObjetoTransferencia.ConsultaVeterinaria consultaVeterinaria = new ObjetoTransferencia.ConsultaVeterinaria();
        public frmCadastroConsultaVeterinaria()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            tabControl.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tabControl.Width, tabControl.Height, 20, 20));

            dgvVeterinarios.AutoGenerateColumns = false;
            dtpData.MaxDate = DateTime.Now;
            consultaVeterinaria.Veterinarios = new VeterinarioCollection();
            consultaVeterinaria.Animal = new ObjetoTransferencia.Animal();

            RacaNegocios racaNegocios = new RacaNegocios();
            cbbRaca.DisplayMember = "RacaNome";
            cbbRaca.ValueMember = "RacaID";
            cbbRaca.DataSource = racaNegocios.ConsultaPorNome("");
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

        private void btnBuscarVeterinario_Click(object sender, EventArgs e)
        {
            Veterinario.frmConsultaVeterinario frmConsultaVeterinario = new Veterinario.frmConsultaVeterinario(true);
            frmConsultaVeterinario.ShowDialog();
            if(frmConsultaVeterinario.veterinario.VeterinarioID != 0)
            {
                veterinario = frmConsultaVeterinario.veterinario;
                txtVeterinario.Text = veterinario.VeterinarioID.ToString();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            bool verif = false;
            for (int i = 0; i < consultaVeterinaria.Veterinarios.Count; i++)
            {
                if (consultaVeterinaria.Veterinarios[i].VeterinarioID == veterinario.VeterinarioID)
                    verif = true;
            }
            if (!verif)
            {
                consultaVeterinaria.Veterinarios.Add(veterinario);
                dgvVeterinarios.DataSource = null;
                dgvVeterinarios.DataSource = consultaVeterinaria.Veterinarios;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvVeterinarios.SelectedRows.Count; i++)
            {
                for (int x = 0; x < consultaVeterinaria.Veterinarios.Count; x++)
                {
                    if (int.Parse(dgvVeterinarios.SelectedRows[i].Cells[0].Value.ToString()) == consultaVeterinaria.Veterinarios[x].VeterinarioID)
                    {
                        consultaVeterinaria.Veterinarios.RemoveAt(x);
                        break;
                    }
                }
            }

            dgvVeterinarios.DataSource = null;
            dgvVeterinarios.DataSource = consultaVeterinaria.Veterinarios;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCusto.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor, informe o custo.", "Informe o custo.");
                }
                else if (txtDescricao.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor, informe a descrição.", "Informe a descrição.");
                }
                else if (consultaVeterinaria.Animal.AnimalID == 0)
                {
                    MessageBox.Show("Por favor, informe o animal.", "Informe o animal.");
                }
                else if (consultaVeterinaria.Veterinarios.Count == 0)
                {
                    MessageBox.Show("Por favor, informe os veterinários.", "Informe os veterinários.");
                }
                else
                {
                    consultaVeterinaria.ConsultaVeterinariaData = dtpData.Value;
                    consultaVeterinaria.ConsultaVeterinariaCusto = decimal.Parse(txtCusto.Text);
                    consultaVeterinaria.ConsultaVeterinariaDescricao = txtDescricao.Text.Trim();

                    ConsultaVeterinariaNegocios consultaVeterinariaNegocios = new ConsultaVeterinariaNegocios();
                    MessageBox.Show("Consulta veterinária de ID " + consultaVeterinariaNegocios.Cadastrar(consultaVeterinaria) + " cadastrada com sucesso!",
                        "Consulta veterinária cadastrada com sucesso!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro.");
            }
        }

        private void txtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCusto.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;
            else
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }

        private void btnBuscarAnimal_Click_1(object sender, EventArgs e)
        {
            Animal.frmConsultaAnimal frmConsultaAnimal = new Animal.frmConsultaAnimal(true);
            frmConsultaAnimal.ShowDialog();
            if (frmConsultaAnimal.animalRetorno.AnimalID != 0)
            {
                consultaVeterinaria.Animal = frmConsultaAnimal.animalRetorno;
                txtAnimal.Text = consultaVeterinaria.Animal.AnimalID.ToString();
                txtAnimalDescricao.Text = consultaVeterinaria.Animal.AnimalDescricao;
                txtIdentificador.Text = consultaVeterinaria.Animal.AnimalIdentificador.ToString();
                txtPiquete.Text = consultaVeterinaria.Animal.Piquete.PiqueteID.ToString();
                cbbRaca.SelectedValue = consultaVeterinaria.Animal.Raca.RacaID;
                ckbAtivo.Checked = consultaVeterinaria.Animal.AnimalAtivo;
            }
        }

        private void dgvVeterinarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
    }
}
