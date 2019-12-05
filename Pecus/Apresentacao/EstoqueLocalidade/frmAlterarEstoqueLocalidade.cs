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
using Microsoft.Reporting.WebForms;

namespace Apresentacao.EstoqueLocalidade
{
    public partial class frmAlterarEstoqueLocalidade : Form
    {
        private ObjetoTransferencia.EstoqueLocalidade estoqueLocalidade = new ObjetoTransferencia.EstoqueLocalidade();
        private ObjetoTransferencia.Item item = new ObjetoTransferencia.Item();
        private int UsuarioID;
        public frmAlterarEstoqueLocalidade(int EstoqueLocalidadeParametroID, int UserID)
        {
            InitializeComponent();
            EstoqueLocalidadeNegocios estoqueLocalidadeNegocios = new EstoqueLocalidadeNegocios();
            estoqueLocalidade = estoqueLocalidadeNegocios.ConsultaPorID(EstoqueLocalidadeParametroID);
            UsuarioID = UserID;

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

        private void FrmAlterarEstoqueLocalidade_Load(object sender, EventArgs e)
        {

            CidadeEstagoNegocios cidadeEstagoNegocios = new CidadeEstagoNegocios();

            cbbEstado.DisplayMember = "EstadoNome";
            cbbEstado.ValueMember = "EstadoID";
            cbbEstado.DataSource = cidadeEstagoNegocios.ConsultaEstadoTodos();
            cbbEstado.Update();
            cbbEstado.SelectedValue = estoqueLocalidade.Cidade.EstadoID;


            cbbCidade.DisplayMember = "CidadeNome";
            cbbCidade.ValueMember = "CidadeID";
            cbbCidade.DataSource = cidadeEstagoNegocios.ConsultaCidadePorEstado(estoqueLocalidade.Cidade.EstadoID);
            cbbCidade.Update();
            cbbCidade.SelectedValue = estoqueLocalidade.Cidade.CidadeID;

            txtDescricao.Text = estoqueLocalidade.EstoqueLocalidadeDescricao;
            txtEndereco.Text = estoqueLocalidade.EstoqueLocalidadeEndereco;

            txtContratoAluguelID.Text = estoqueLocalidade.ContratoAluguel.ContratoAluguelID.ToString();
            if (estoqueLocalidade.ContratoAluguel.ContratoAluguelID != 0)
                ckbContratoAluguel.Checked = true;

            EstoqueNegocios estoqueNegocios = new EstoqueNegocios();
            estoqueLocalidade.Estoques = estoqueNegocios.ConsultaPorEstoqueLocalidade(estoqueLocalidade.EstoqueLocalidadeID);

            dgvEstoques.AutoGenerateColumns = false;
            dgvEstoques.DataSource = estoqueLocalidade.Estoques;
        }

        private void BtnAdicionarEstoque_Click(object sender, EventArgs e)
        {
            if (item.ItemID == 0)
            {
                MessageBox.Show("Por favor, informe o item.", "Informe o item.");
            }
            else if (txtQuantidade.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor, informe a quantidade.", "Informe a quantidade.");
            }
            else
            {
                ObjetoTransferencia.Estoque estoque = new ObjetoTransferencia.Estoque();
                estoque.Item = new ObjetoTransferencia.Item();
                estoque.EstoqueLocalidade = new ObjetoTransferencia.EstoqueLocalidade();

                estoque.EstoqueQuantidade = Convert.ToDecimal(txtQuantidade.Text);
                estoque.EstoqueAtivo = true;
                estoque.Item.ItemID = item.ItemID;
                estoque.Item.ItemDescricao = item.ItemDescricao;

                bool verifExistencia = false;
                foreach (ObjetoTransferencia.Estoque est in estoqueLocalidade.Estoques)
                {
                    if (estoque.Item.ItemID == est.Item.ItemID)
                        verifExistencia = true;
                }
                if (!verifExistencia)
                {
                    estoqueLocalidade.Estoques.Add(estoque);

                    dgvEstoques.DataSource = null;
                    dgvEstoques.DataSource = estoqueLocalidade.Estoques;
                    dgvEstoques.Update();
                }
                else
                    MessageBox.Show("Já existe um controle deste item nesse armazém.", "Item já cadastrado no armazém.");
            }
        }

        private void BtnBuscarContrato_Click(object sender, EventArgs e)
        {
            ContratoAluguel.frmConsultaContratoAluguel frmConsultaContratoAluguel = new ContratoAluguel.frmConsultaContratoAluguel(true, new ObjetoTransferencia.Usuario() { TipoUsuario = new TipoUsuario() });
            frmConsultaContratoAluguel.ShowDialog();
            if(frmConsultaContratoAluguel.contratoAluguelRetorno.ContratoAluguelID != 0)
            {
                txtContratoAluguelID.Text = frmConsultaContratoAluguel.contratoAluguelRetorno.ContratoAluguelID.ToString();
            }
            
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor, informe a descrição.", "Informe a descrição.");
            }
            else if (txtEndereco.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor, informe o endereço.", "Informe o endereço.");
            }
            else if (ckbContratoAluguel.Checked && (txtContratoAluguelID.Text == string.Empty || txtContratoAluguelID.Text == "0"))
            {
                MessageBox.Show("Por favor, informe o contrato de aluguel do armazém.", "Informe o contrato de aluguel do armazém.");
            }
            else
            {
                try
                {
                    estoqueLocalidade.Cidade = new Cidade();
                    estoqueLocalidade.ContratoAluguel = new ObjetoTransferencia.ContratoAluguel();

                    estoqueLocalidade.EstoqueLocalidadeDescricao = txtDescricao.Text.Trim();
                    estoqueLocalidade.EstoqueLocalidadeEndereco = txtEndereco.Text.Trim();
                    estoqueLocalidade.Cidade.CidadeID = Convert.ToInt32(cbbCidade.SelectedValue);
                    if (ckbContratoAluguel.Checked)
                    {
                        estoqueLocalidade.ContratoAluguel.ContratoAluguelID = Convert.ToInt32(txtContratoAluguelID.Text);
                    }
                    else
                        estoqueLocalidade.ContratoAluguel.ContratoAluguelID = 0;

                    EstoqueLocalidadeNegocios estoqueLocalidadeNegocios = new EstoqueLocalidadeNegocios();
                    estoqueLocalidadeNegocios.Alterar(estoqueLocalidade, UsuarioID);

                    MessageBox.Show("Armazém de ID: " + estoqueLocalidade.EstoqueLocalidadeID + " alterado com sucesso!", "Armazém cadastrado com sucesso!");

                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um erro ao alterar o armazém, por favor, contate seu suporte.\nObservações: " + ex.Message);
                }
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

        private void TxtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtQuantidade.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;
            else
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }

        private void DgvEstoques_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ItemID = Convert.ToInt32(dgvEstoques.SelectedRows[0].Cells[0].FormattedValue);
            foreach (ObjetoTransferencia.Estoque est in estoqueLocalidade.Estoques)
            {
                if (ItemID == est.Item.ItemID)
                {
                    Estoque.frmAlterarEstoque frmAlterarEstoque = new Estoque.frmAlterarEstoque(est);
                    frmAlterarEstoque.ShowDialog();
                    EstoqueNegocios estoqueNegocios = new EstoqueNegocios();
                    estoqueLocalidade.Estoques = estoqueNegocios.ConsultaPorEstoqueLocalidade(estoqueLocalidade.EstoqueLocalidadeID);

                    dgvEstoques.DataSource = estoqueLocalidade.Estoques;
                    break;
                }
            }

        }

        private void DgvEstoques_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if ((dgvEstoques.Rows[e.RowIndex].DataBoundItem != null) && (dgvEstoques.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvEstoques.Rows[e.RowIndex].DataBoundItem, dgvEstoques.Columns[e.ColumnIndex].DataPropertyName);
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

        private void TxtQuantidade_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (txtQuantidade.Text.Contains(",") && e.KeyChar == ',')
                e.Handled = true;
            else
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }

        private void BtnBuscarItem_Click(object sender, EventArgs e)
        {
            Item.frmConsultaItem frmConsultaItem = new Item.frmConsultaItem(true);
            frmConsultaItem.ShowDialog();
            item = new ObjetoTransferencia.Item();
            if (frmConsultaItem.item.ItemID != 0)
            {
                txtItem.Text = frmConsultaItem.item.ItemID.ToString();
                item = frmConsultaItem.item;
            }
        }

    }
}
