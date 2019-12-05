using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using Negocios;
using ObjetoTransferencia;

namespace Apresentacao.Usuario
{
    public partial class frmConsultaUsuario : Form
    {
        private bool retorno;
        public ObjetoTransferencia.Usuario usuarioRetorno = new ObjetoTransferencia.Usuario();
        public frmConsultaUsuario(bool retornoP)
        {
            InitializeComponent();
            dgvResultado.AutoGenerateColumns = false;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));
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

        private void PicExit_MouseEnter(object sender, EventArgs e)
        {
            picExit.BackgroundImage = Apresentacao.Properties.Resources.exit_hover;
        }

        private void PicExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.BackgroundImage = Apresentacao.Properties.Resources.exit;
        }

        private void PicExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
                dgvResultado.DataSource = usuarioNegocios.ConsultaPorNome(txtNome.Text);
                dgvResultado.Update();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante a consulta, tente novamente.\nCaso o erro persista, consulte seu suporte.\nErro: " + ex.Message, "Consulta não realizada.");
            }
        }

        private void DgvResultado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            DataGridViewRow row = grid.Rows[e.RowIndex];
            DataGridViewColumn col = grid.Columns[e.ColumnIndex];
            if (row.DataBoundItem != null && col.DataPropertyName.Contains("."))
            {
                string[] props = col.DataPropertyName.Split('.');
                PropertyInfo propInfo = row.DataBoundItem.GetType().GetProperty(props[0]);
                object val = propInfo.GetValue(row.DataBoundItem, null);
                for (int i = 1; i < props.Length; i++)
                {
                    propInfo = val.GetType().GetProperty(props[i]);
                    val = propInfo.GetValue(val, null);
                }
                e.Value = val;
            }
        }

        private void DgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (retorno)
            {
                UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
                usuarioRetorno = usuarioNegocios.ConsultaPorID(Convert.ToInt32(dgvResultado.SelectedRows[0].Cells[0].Value.ToString()));
                Close();
            }
            else
            {
                Usuario.frmAlteracaoUsuario frmAlteracaoUsuario = new frmAlteracaoUsuario(Convert.ToInt32(dgvResultado.SelectedRows[0].Cells[0].Value.ToString()));
                frmAlteracaoUsuario.ShowDialog();
            }
        }

        private void DgvResultado_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void FrmConsultaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
