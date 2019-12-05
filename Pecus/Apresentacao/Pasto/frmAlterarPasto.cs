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

using Negocios;
using ObjetoTransferencia;

namespace Apresentacao.Pasto
{
    public partial class frmAlterarPasto : Form
    {
        ObjetoTransferencia.Pasto pasto = new ObjetoTransferencia.Pasto();
        PiqueteCollection piquetesRemover = new PiqueteCollection();

        public frmAlterarPasto(int PastoID)
        {
            InitializeComponent();
            pasto.PastoID = PastoID;
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

        private void FrmAlterarPasto_Load(object sender, EventArgs e)
        {
            dgvPiquetes.AutoGenerateColumns = false;
            dgvPiqueteRemover.AutoGenerateColumns = false;

            CarregarPasto();
        }
        private void CarregarPasto()
        {
            dgvPiquetes.DataSource = null;

            PastoNegocios pastoNegocios = new PastoNegocios();

            pasto = pastoNegocios.ConsultaPorID(pasto.PastoID);

            txtDescricao.Text = pasto.PastoDescricao;
            txtTamanho.Text = pasto.PastoTamanho.ToString();
            ckbAtivo.Checked = pasto.PastoAtivo;

            CidadeEstagoNegocios cidadeEstagoNegocios = new CidadeEstagoNegocios();

            cbbEstado.DisplayMember = "EstadoNome";
            cbbEstado.ValueMember = "EstadoID";
            cbbEstado.DataSource = cidadeEstagoNegocios.ConsultaEstadoTodos();
            cbbEstado.Update();
            cbbEstado.SelectedValue = pasto.Cidade.EstadoID;

            cbbCidade.DisplayMember = "CidadeNome";
            cbbCidade.ValueMember = "CidadeID";
            cbbCidade.DataSource = cidadeEstagoNegocios.ConsultaCidadePorEstado(Convert.ToInt32(cbbEstado.SelectedValue));
            cbbCidade.Update();
            cbbCidade.SelectedValue = pasto.Cidade.CidadeID;

            if (pasto.ContratoAluguel.ContratoAluguelID != 0)
            {
                ckContrato.Checked = true;
                gpbContratoAluguel.Enabled = true;
                txtContratoAluguelID.Text = pasto.ContratoAluguel.ContratoAluguelID.ToString();
            }

            PiqueteNegocios piqueteNegocios = new PiqueteNegocios();
            pasto.Piquetes = piqueteNegocios.ConsultarPorPasto(pasto.PastoID);

            dgvPiquetes.DataSource = pasto.Piquetes;

            dgvPiqueteRemover.DataSource = null;
            piquetesRemover = new PiqueteCollection();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = DialogResult.OK;
            bool verificacaoAnimais = false;
            if (!ckbAtivo.Checked && pasto.PastoAtivo != ckbAtivo.Checked)
            {
                foreach (ObjetoTransferencia.Piquete p in pasto.Piquetes)
                {
                    if (p.PiqueteQuantidadeAnimais > 0)
                        verificacaoAnimais = true;
                }
                if (verificacaoAnimais)
                    MessageBox.Show("Você não pode desativar um pasto que ainda tenha animais em seus piquetes." +
                        "\nPor favor, mova os animais antes de realizar a operação.", "Impossível de realizar desativação.");
                else
                    resposta = MessageBox.Show("Você tem certeza que deseja desativar o pasto?\nEle ficará inativo para realização de ações.", "Confirme sua ação.", MessageBoxButtons.YesNo);
            }
            else if (pasto.PastoAtivo != ckbAtivo.Checked)
            {
                resposta = MessageBox.Show("Você tem certeza que deseja ativar o pasto?\nEle ficará ativo para realização de ações.", "Confirme sua ação.", MessageBoxButtons.YesNo);
            }
            else if(ckContrato.Checked && (txtContratoAluguelID.Text == string.Empty || txtContratoAluguelID.Text == "0"))
            {
                MessageBox.Show("Por favor, informe o contrato de alguel do pasto.", "Por favor, informe o contrato de aluguel do pasto.");
            }

            if (resposta == DialogResult.OK || !verificacaoAnimais)
            {
                if (txtDescricao.Text.Trim() == string.Empty)
                    MessageBox.Show("Por favor, preencha a descrição.", "Informe a descrição.");
                else if (txtTamanho.Text.Trim() == string.Empty)
                    MessageBox.Show("Por favor, preencha o tamanho.", "Informe o tamanho.");
                else
                {
                    try
                    {
                        PastoNegocios pastoNegocios = new PastoNegocios();
                        pasto.PastoDescricao = txtDescricao.Text.Trim();
                        pasto.PastoTamanho = decimal.Parse(txtTamanho.Text);
                        pasto.Cidade.CidadeID = int.Parse(cbbCidade.SelectedValue.ToString());
                        pasto.PastoAtivo = ckbAtivo.Checked;
                        if (ckContrato.Checked)
                            pasto.ContratoAluguel.ContratoAluguelID = int.Parse(txtContratoAluguelID.Text);
                        else
                            pasto.ContratoAluguel.ContratoAluguelID = 0;

                        int ID = pastoNegocios.Alterar(pasto, piquetesRemover);

                        MessageBox.Show("Pasto de ID: " + ID + " alterado com sucesso!", "Sucesso na alteração!");
                        CarregarPasto();
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Houve um erro na alteração do pasto, por favor, contate seu suporte.\nObservações: " + ex.Message);
                    }
                }
            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if (dgvPiquetes.SelectedRows.Count > 0)
            {
                int index = pasto.Piquetes.FindIndex(p => p.PiqueteID == Convert.ToInt32(dgvPiquetes.SelectedRows[0].Cells[0].Value.ToString()));
                if (pasto.Piquetes[index].PiqueteQuantidadeAnimais > 0)
                {
                    MessageBox.Show("Não é possível excluir um piquete onde tenha animais, mude a localização dos animais em um outro/novo piquete.", "Não é permitido excluir um piquete com animais.");
                }
                else
                {
                    if (Convert.ToInt32(dgvPiquetes.SelectedRows[0].Cells[0].Value.ToString()) != 0)
                    {
                        //Afim de evitar erros de index não encontrado, atribuímos NULO ao DataSource
                        // para depois alterar-mos a lista e reenviar o DataSource
                        dgvPiqueteRemover.DataSource = null;
                        dgvPiquetes.DataSource = null;

                        piquetesRemover.Add(pasto.Piquetes[index]);
                        pasto.Piquetes.RemoveAt(index);

                        dgvPiqueteRemover.DataSource = piquetesRemover;
                        dgvPiquetes.DataSource = pasto.Piquetes;
                    }
                    else
                    {
                        //Afim de evitar erros de index não encontrado, atribuímos NULO ao DataSource
                        // para depois alterar-mos a lista e reenviar o DataSource
                        dgvPiquetes.DataSource = null;

                        pasto.Piquetes.RemoveAt(index);

                        dgvPiquetes.DataSource = pasto.Piquetes;
                    }
                }
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text != "")
            {
                ObjetoTransferencia.Piquete piquete = new ObjetoTransferencia.Piquete();
                piquete.PiqueteID = 0;
                piquete.PiqueteDescricao = txtPiqueteDescricao.Text;
                piquete.PiqueteQuantidadeAnimais = 0;
                piquete.PiqueteAtivo = true;

                //Afim de evitar erros de index não encontrado, atribuímos NULO ao DataSource
                // para depois alterar-mos a lista e reenviar o DataSource
                dgvPiquetes.DataSource = null;

                pasto.Piquetes.Add(piquete);

                dgvPiquetes.DataSource = pasto.Piquetes;
            }
        }

        private void BtnCancelarPiqueteRemover_Click(object sender, EventArgs e)
        {
            if(dgvPiqueteRemover.SelectedRows.Count > 0)
            {
                int index = piquetesRemover.FindIndex(p => p.PiqueteID == Convert.ToInt32(dgvPiqueteRemover.SelectedRows[0].Cells[0].Value.ToString()));

                //Afim de evitar erros de index não encontrado, atribuímos NULO ao DataSource
                // para depois alterar-mos a lista e reenviar o DataSource
                dgvPiqueteRemover.DataSource = null;
                dgvPiquetes.DataSource = null;

                pasto.Piquetes.Add(piquetesRemover[index]);
                piquetesRemover.RemoveAt(index);

                dgvPiqueteRemover.DataSource = piquetesRemover;
                dgvPiquetes.DataSource = pasto.Piquetes;
            }
        }

        private void DgvPiquetes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PiqueteNegocios piqueteNegocios = new PiqueteNegocios();
                Piquete.frmAlterarPiquete frmAlterarPiquete = new Piquete.frmAlterarPiquete(
                    piqueteNegocios.ConsultarPorID(int.Parse(dgvPiquetes.SelectedRows[0].Cells[0].Value.ToString()))[0]);
                frmAlterarPiquete.ShowDialog();


                pasto.Piquetes = piqueteNegocios.ConsultarPorPasto(pasto.PastoID);

                for (int i = 0; i < pasto.Piquetes.Count; i++)
                {
                    for (int x = 0; x < piquetesRemover.Count; x++)
                    {
                        if (pasto.Piquetes[i].PiqueteID == piquetesRemover[x].PiqueteID)
                            pasto.Piquetes.RemoveAt(i);
                    }
                }

                dgvPiquetes.DataSource = pasto.Piquetes;
            }
            catch(Exception ex)
            {

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

        private void btnCadastrarContrato_Click(object sender, EventArgs e)
        {
            ContratoAluguel.frmConsultaContratoAluguel frmConsultaContratoAluguel = new ContratoAluguel.frmConsultaContratoAluguel(true, new ObjetoTransferencia.Usuario() { TipoUsuario = new TipoUsuario() });
            frmConsultaContratoAluguel.ShowDialog();
            if(frmConsultaContratoAluguel.contratoAluguelRetorno.ContratoAluguelID != 0)
            {
                txtContratoAluguelID.Text = frmConsultaContratoAluguel.contratoAluguelRetorno.ContratoAluguelID.ToString();
            }
        }
    }
}
