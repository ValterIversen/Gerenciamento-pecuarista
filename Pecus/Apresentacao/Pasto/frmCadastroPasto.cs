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

namespace Apresentacao.Pasto
{
    public partial class frmCadastroPasto : Form
    {
        public ObjetoTransferencia.Pasto pasto = new ObjetoTransferencia.Pasto();
        private AnimalCollection animaisPiquetes = new AnimalCollection();
        private int countPiquete;
        private bool ContratoAluguel;

        public frmCadastroPasto(bool CadastroContratoAluguel)
        {
            InitializeComponent();
            pasto.Piquetes = new PiqueteCollection();
            ContratoAluguel = CadastroContratoAluguel;
            //O boolean é enviado pois caso a tela de cadastro tenha sido aberta pela
            //  tela de cadastro de contrato de aluguel, devemos bloquear os campos que 
            //  especificam o contrato de aluguel pertencente ao pasto
            if (CadastroContratoAluguel)
            {
                ckContrato.Checked = true;
                ckContrato.Enabled = false;
                gpbContratoAluguel.Enabled = false;
            }
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            tabControl.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tabControl.Width, tabControl.Height, 20, 20));
            panelInside.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside.Width, panelInside.Height, 20, 20));
            panelInside2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelInside2.Width, panelInside2.Height, 20, 20));
            countPiquete = 0;
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

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                countPiquete++;
                Piquete.frmCadastroPiquete frmCadastroPiquete = new Piquete.frmCadastroPiquete(animaisPiquetes);
                frmCadastroPiquete.ShowDialog();
                frmCadastroPiquete.piquete.PiqueteID = countPiquete;
                if (frmCadastroPiquete.piquete.PiqueteDescricao != "")
                {
                    pasto.Piquetes.Add(frmCadastroPiquete.piquete);
                    foreach (ObjetoTransferencia.Animal animal in frmCadastroPiquete.piquete.Animais)
                    {
                        animaisPiquetes.Add(animal);
                    }
                    dgvPiquetes.DataSource = null;
                    dgvPiquetes.DataSource = pasto.Piquetes;
                }
            }
            catch(Exception ex){

            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPiquetes.SelectedRows.Count; i++)
            {
                for (int x = 0; x < pasto.Piquetes.Count; x++)
                {
                    if (int.Parse(dgvPiquetes.SelectedRows[i].Cells[0].Value.ToString()) == pasto.Piquetes[x].PiqueteID)
                    {
                        for (int y = 0; y < animaisPiquetes.Count; y++)
                        {
                            for (int p = 0; p < pasto.Piquetes[x].Animais.Count; p++)
                            {
                                if (animaisPiquetes[y].AnimalID == pasto.Piquetes[x].Animais[p].AnimalID)
                                {
                                    animaisPiquetes.RemoveAt(p);
                                    break;
                                }
                            }
                        }

                        pasto.Piquetes.RemoveAt(x);
                    }
                }
            }
            dgvPiquetes.DataSource = pasto.Piquetes;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor, informe a descrição do pasto.", "Informe a descrição do pasto.");
            }
            else if (txtTamanho.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor, informe o tamanho do pasto.", "Informe o tamanho do pasto.");
            }
            else if ((ckContrato.Checked && (txtContratoAluguelID.Text == string.Empty || txtContratoAluguelID.Text == "0")) && !ContratoAluguel)
            {
                MessageBox.Show("Por favor, informe o contrato de aluguel do pasto.", "Informe o contrato de aluguel do pasto.");
            }
            else
            {
                try
                {
                    pasto.PastoDescricao = txtDescricao.Text.Trim();
                    pasto.PastoTamanho = decimal.Parse(txtTamanho.Text);
                    pasto.Cidade = new Cidade();
                    pasto.Cidade.CidadeID = Convert.ToInt32(cbbCidade.SelectedValue);
                    pasto.ContratoAluguel = new ObjetoTransferencia.ContratoAluguel();

                    if (!gpbContratoAluguel.Enabled)
                    {
                        this.DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {

                        if (ckContrato.Checked)
                        {
                            pasto.ContratoAluguel.ContratoAluguelID = Convert.ToInt32(txtContratoAluguelID.Text);
                        }

                        PastoNegocios pastoNegocios = new PastoNegocios();
                        pasto.PastoID = pastoNegocios.Cadastrar(pasto);

                        MessageBox.Show("Pasto de ID: " + pasto.PastoID + " cadastrado com sucesso!");
                        this.DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um erro no cadastro do pasto, por favor, contate seu suporte.\nObservações: " + ex.Message);
                }

            }
        }

        private void TxtTamanho_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',';
        }

        private void FrmCadastroPasto_Load(object sender, EventArgs e)
        {
            CidadeEstagoNegocios cidadeEstagoNegocios = new CidadeEstagoNegocios();

            cbbEstado.DisplayMember = "EstadoNome";
            cbbEstado.ValueMember = "EstadoID";
            cbbEstado.DataSource = cidadeEstagoNegocios.ConsultaEstadoTodos();
            cbbEstado.Update();
            cbbEstado.SelectedIndex = 0;
        }

        private void CbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CidadeEstagoNegocios cidadeEstagoNegocios = new CidadeEstagoNegocios();

            cbbCidade.DisplayMember = "CidadeNome";
            cbbCidade.ValueMember = "CidadeID";
            cbbCidade.DataSource = cidadeEstagoNegocios.ConsultaCidadePorEstado(Convert.ToInt32(cbbEstado.SelectedValue));
            cbbCidade.Update();
        }

        private void TxtDescricao_Enter(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "Aqui você pode descrever observações desejadas como características do pasto, localização, responsável pelo pasto e muitos outros")
            {
                txtDescricao.Text = string.Empty;
                txtDescricao.ForeColor = SystemColors.WindowText;
            }
        }

        private void TxtDescricao_Leave(object sender, EventArgs e)
        {
            if(txtDescricao.Text.Trim() == string.Empty)
            {
                txtDescricao.Text = "Aqui você pode descrever observações desejadas como características do pasto, localização, responsável pelo pasto e muitos outros";
                txtDescricao.ForeColor = Color.DarkGray;
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

        private void CkContrato_CheckedChanged(object sender, EventArgs e)
        {
            gpbContratoAluguel.Enabled = ckContrato.Checked;
        }
    }
}
