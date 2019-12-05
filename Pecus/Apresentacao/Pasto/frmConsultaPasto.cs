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
using System.Reflection;

namespace Apresentacao.Pasto
{
    public partial class frmConsultaPasto : Form
    {
        private bool retorno;
        public ObjetoTransferencia.Pasto pastoRetorno = new ObjetoTransferencia.Pasto();
        ObjetoTransferencia.Usuario user;
        public frmConsultaPasto(bool retornoP,ObjetoTransferencia.Usuario usuario)
        {
            InitializeComponent();

            retorno = retornoP;
            dgvResultado.AutoGenerateColumns = false;
            user = usuario;

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));
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

        private void RbDescricao_CheckedChanged(object sender, EventArgs e)
        {
            gpbDescricao.Visible = true;
            gpbCidade.Visible = false;
            gpbContratoAluguel.Visible = false;
            gpbID.Visible = false;
        }

        private void RbCidade_CheckedChanged(object sender, EventArgs e)
        {
            gpbDescricao.Visible = false;
            gpbCidade.Visible = true;
            gpbContratoAluguel.Visible = false;
            gpbID.Visible = false;
        }

        private void RbContratoAluguel_CheckedChanged(object sender, EventArgs e)
        {
            gpbDescricao.Visible = false;
            gpbCidade.Visible = false;
            gpbContratoAluguel.Visible = true;
            gpbID.Visible = false;
        }

        private void RbID_CheckedChanged(object sender, EventArgs e)
        {
            gpbDescricao.Visible = false;
            gpbCidade.Visible = false;
            gpbContratoAluguel.Visible = false;
            gpbID.Visible = true;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            PastoNegocios pastoNegocios = new PastoNegocios();
            if (rbDescricao.Checked)
            {
                dgvResultado.DataSource = pastoNegocios.ConsultaPorDescricao(txtDescricao.Text);
            }
            else if (rbCidade.Checked)
            {
                dgvResultado.DataSource = pastoNegocios.ConsultaPorCidade(Convert.ToInt32(cbbCidade.SelectedValue));
            }
            else if (rbContratoAluguel.Checked && txtID.Text != "")
            {
                dgvResultado.DataSource = pastoNegocios.ConsultaPorContratoAluguel(Convert.ToInt32(txtContratoAluguel.Text));
            }
            else if (rbID.Checked && txtID.Text != "")
            {
                PastoCollection pastos = new PastoCollection();
                pastos.Add(pastoNegocios.ConsultaPorID(Convert.ToInt32(txtID.Text)));
                dgvResultado.DataSource = pastos;
            }
        }

        private void CbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CidadeEstagoNegocios cidadeEstagoNegocios = new CidadeEstagoNegocios();

            cbbCidade.DisplayMember = "CidadeNome";
            cbbCidade.ValueMember = "CidadeID";
            cbbCidade.DataSource = cidadeEstagoNegocios.ConsultaCidadePorEstado(Convert.ToInt32(cbbEstado.SelectedValue));
            cbbCidade.Update();
        }

        private void FrmConsultaPasto_Load(object sender, EventArgs e)
        {
            dgvResultado.AutoGenerateColumns = false;
            CidadeEstagoNegocios cidadeEstagoNegocios = new CidadeEstagoNegocios();

            cbbEstado.DisplayMember = "EstadoNome";
            cbbEstado.ValueMember = "EstadoID";
            cbbEstado.DataSource = cidadeEstagoNegocios.ConsultaEstadoTodos();
            cbbEstado.Update();
            cbbEstado.SelectedValue = 1;
        }

        private void DgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!retorno)
            {
                if (user.TipoUsuario.TipoUsuarioDescricao == "Administrador")
                {
                    frmAlterarPasto frmAlterarPasto = new frmAlterarPasto(Convert.ToInt32(dgvResultado.SelectedRows[0].Cells[0].Value.ToString()));
                    this.DialogResult = DialogResult.OK;
                    frmAlterarPasto.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Somente usuários administradores.", "Permissão negada.");
                }
            }
            else
            {
                if (MessageBox.Show("Você tem certeza que deseja selecionar o pasto de ID: " + dgvResultado.SelectedRows[0].Cells[0].Value.ToString() + ".",
                    "Você tem certeza que deseja selecionar este pasto?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    pastoRetorno.ContratoAluguel = new ObjetoTransferencia.ContratoAluguel();
                    pastoRetorno.Piquetes = new PiqueteCollection();
                    PastoNegocios pastoNegocios = new PastoNegocios();
                    pastoRetorno = pastoNegocios.ConsultaPorID(Convert.ToInt32(dgvResultado.SelectedRows[0].Cells[0].Value.ToString()));
                    Close();
                }

            }
        }

        private void DgvResultado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if ((dgvResultado.Rows[e.RowIndex].DataBoundItem != null) && (dgvResultado.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvResultado.Rows[e.RowIndex].DataBoundItem, dgvResultado.Columns[e.ColumnIndex].DataPropertyName);
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
