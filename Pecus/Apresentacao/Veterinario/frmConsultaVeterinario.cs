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

namespace Apresentacao.Veterinario
{
    public partial class frmConsultaVeterinario : Form
    {
        VeterinarioCollection veterinarios = new VeterinarioCollection();
        public ObjetoTransferencia.Veterinario veterinario { get; set; }
        private bool retorno;
        public frmConsultaVeterinario(bool retornoP)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));

            dgvResultados.AutoGenerateColumns = false;
            retorno = retornoP;
            veterinario = new ObjetoTransferencia.Veterinario();
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

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            gpbID.Visible = false;
            gpbNome.Visible = true;
        }

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            gpbID.Visible = true;
            gpbNome.Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                VeterinarioNegocios veterinarioNegocios = new VeterinarioNegocios();
                if(rbID.Checked && txtID.Text != "" && txtID.Text != "0")
                {
                    veterinarios = veterinarioNegocios.ConsultaPorID(int.Parse(txtID.Text));
                    dgvResultados.DataSource = null;
                    dgvResultados.DataSource = veterinarios;
                }
                else
                {
                    veterinarios = veterinarioNegocios.ConsultaPorNome(txtNome.Text);
                    dgvResultados.DataSource = null;
                    dgvResultados.DataSource = veterinarios;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro.");
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < veterinarios.Count; i++)
            {
                if(veterinarios[i].VeterinarioID == int.Parse(dgvResultados.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    if (retorno)
                    {
                        veterinario = veterinarios[i];
                        Close();
                    }
                    else
                    {
                        frmAlteracaoVeterinario frmAlteracaoVeterinario = new frmAlteracaoVeterinario(veterinarios[i]);
                        frmAlteracaoVeterinario.ShowDialog();
                        btnCadastrar_Click(sender, e);
                    }
                }
            }
        }
    }
}
