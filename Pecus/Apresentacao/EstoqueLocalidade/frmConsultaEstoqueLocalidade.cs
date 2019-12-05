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

namespace Apresentacao.EstoqueLocalidade
{
    public partial class frmConsultaEstoqueLocalidade : Form
    {
        private bool retorno;
        private EstoqueLocalidadeCollection estoqueLocalidades = new EstoqueLocalidadeCollection();
        public int estoqueLocalidadeIDRetorno = 0;
        private ObjetoTransferencia.Usuario user;
        public frmConsultaEstoqueLocalidade(bool retornoP, ObjetoTransferencia.Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
            retorno = retornoP;
            dgvResultado.AutoGenerateColumns = false;

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));
            gpbDescricao.Visible = true;
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

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                EstoqueLocalidadeNegocios estoqueLocalidadeNegocios = new EstoqueLocalidadeNegocios();
                if (rbDescricao.Checked)
                {
                    estoqueLocalidades = estoqueLocalidadeNegocios.ConsultaPorDescricao(textBox1.Text);
                    dgvResultado.DataSource = null;
                    dgvResultado.DataSource = estoqueLocalidades;
                }
                else if(rbID.Checked && txtID.Text != "" && txtID.Text != "0")
                {
                    estoqueLocalidades = new EstoqueLocalidadeCollection();
                    estoqueLocalidades.Add(estoqueLocalidadeNegocios.ConsultaPorID(int.Parse(txtID.Text)));
                    dgvResultado.DataSource = null;
                    dgvResultado.DataSource = estoqueLocalidades;

                }
                else if(rbContratoAluguel.Checked && txtContratoAluguel.Text != "" && txtContratoAluguel.Text != "0")
                {
                    estoqueLocalidades = estoqueLocalidadeNegocios.ConsultaPorContratoAluguel(int.Parse(txtContratoAluguel.Text));
                    dgvResultado.DataSource = null;
                    dgvResultado.DataSource = estoqueLocalidades;
                }
                else if (rbItem.Checked && txtItem.Text != "" && txtItem.Text != "0")
                {
                    estoqueLocalidades = estoqueLocalidadeNegocios.ConsultaPorItem(int.Parse(txtItem.Text));
                    dgvResultado.DataSource = null;
                    dgvResultado.DataSource = estoqueLocalidades;
                }
                else if (rbCidade.Checked)
                {
                    estoqueLocalidades = estoqueLocalidadeNegocios.ConsultaPorCidade(int.Parse(cbbCidade.SelectedValue.ToString()));
                    dgvResultado.DataSource = null;
                    dgvResultado.DataSource = estoqueLocalidades;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro durante a consulta, tente novamente.\nCaso o erro persista, por favor, contate seu suporte.\nObservações: " + ex.Message, "Houve um erro durante a consulta.");
            }
        }

        private void FrmConsultaEstoqueLocalidade_Load(object sender, EventArgs e)
        {
            CidadeEstagoNegocios cidadeEstagoNegocios = new CidadeEstagoNegocios();

            cbbEstado.DisplayMember = "EstadoNome";
            cbbEstado.ValueMember = "EstadoID";
            cbbEstado.DataSource = cidadeEstagoNegocios.ConsultaEstadoTodos();
            cbbEstado.Update();
            cbbEstado.SelectedIndex = 0;
        }

        private void DgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (retorno)
                {
                    this.DialogResult = DialogResult.OK;
                    estoqueLocalidadeIDRetorno = Convert.ToInt32(dgvResultado.SelectedRows[0].Cells[0].Value);

                    Close();
                }
                else
                {
                    if (user.TipoUsuario.TipoUsuarioDescricao == "Administrador")
                    {
                        int EstoqueLocalidadeParametroID = Convert.ToInt32(dgvResultado.SelectedRows[0].Cells[0].Value);
                        EstoqueLocalidade.frmAlterarEstoqueLocalidade frmAlterarEstoqueLocalidade = new EstoqueLocalidade.frmAlterarEstoqueLocalidade(EstoqueLocalidadeParametroID, user.UsuarioID) ;
                        frmAlterarEstoqueLocalidade.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Somente usuários administradores.", "Permissão negada.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o formulário, por favor, tente novamente.");
            }
        }

        private void CbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CidadeEstagoNegocios cidadeEstagoNegocios = new CidadeEstagoNegocios();

            cbbCidade.DisplayMember = "CidadeNome";
            cbbCidade.ValueMember = "CidadeID";
            cbbCidade.DataSource = cidadeEstagoNegocios.ConsultaCidadePorEstado(Convert.ToInt32(cbbEstado.SelectedValue));
            cbbCidade.Update();
            cbbCidade.SelectedIndex = 0;
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

        private void btnConsultarContratoAluguel_Click(object sender, EventArgs e)
        {
            try
            {
                ContratoAluguel.frmConsultaContratoAluguel frmConsultaContratoAluguel = new ContratoAluguel.frmConsultaContratoAluguel(true, new ObjetoTransferencia.Usuario() { TipoUsuario = new TipoUsuario() });
                frmConsultaContratoAluguel.ShowDialog();
                if (frmConsultaContratoAluguel.contratoAluguelRetorno.ContratoAluguelID != 0)
                    txtContratoAluguel.Text = frmConsultaContratoAluguel.contratoAluguelRetorno.ContratoAluguelID.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro, por favor, tente novamente.");
            }
        }

        private void btnConsultarItem_Click(object sender, EventArgs e)
        {
            try
            {
                Item.frmConsultaItem frmConsultaItem = new Item.frmConsultaItem(true);
                frmConsultaItem.ShowDialog();
                if (frmConsultaItem.item.ItemID != 0)
                    txtItem.Text = frmConsultaItem.item.ItemID.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro, por favor, tente novamente.", "Houve um erro, por favor, tente novamente.");
            }
        }

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void rbContratoAluguel_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void rbItem_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void rbCidade_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void rbDescricao_CheckedChanged(object sender, EventArgs e)
        {
            ControleRb();
        }

        private void ControleRb()
        {
            gpbID.Visible = rbID.Checked;
            gpbContratoAluguel.Visible = rbContratoAluguel.Checked;
            gpbItem.Visible = rbItem.Checked;
            gpbCidade.Visible = rbCidade.Checked;
            gpbDescricao.Visible = rbDescricao.Checked;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }
    }
}
