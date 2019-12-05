﻿using System;
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

namespace Apresentacao.Veterinario
{
    public partial class frmCadastroVeterinario : Form
    {
        public frmCadastroVeterinario()
        {
            InitializeComponent();
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

        private void ckNoveDigito_CheckedChanged(object sender, EventArgs e)
        {
            if (ckNoveDigito.Checked)
                txtTelefone.Mask = "(00) 00000-0000";
            else
                txtTelefone.Mask = "(00) 0000-0000";
        }

        private void cbbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CidadeEstagoNegocios cidadeEstagoNegocios = new CidadeEstagoNegocios();

                cbbCidade.DisplayMember = "CidadeNome";
                cbbCidade.ValueMember = "CidadeID";
                cbbCidade.DataSource = cidadeEstagoNegocios.ConsultaCidadePorEstado(Convert.ToInt32(cbbEstado.SelectedValue));
                cbbCidade.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao consultar as cidades. Por favor, tente novamente.", "Houve um erro ao consulta as cidades.");
            }
        }

        private void frmCadastroVeterinario_Load(object sender, EventArgs e)
        {
            try
            {
                CidadeEstagoNegocios cidadeEstagoNegocios = new CidadeEstagoNegocios();

                cbbEstado.DisplayMember = "EstadoNome";
                cbbEstado.ValueMember = "EstadoID";
                cbbEstado.DataSource = cidadeEstagoNegocios.ConsultaEstadoTodos();
                cbbEstado.Update();
                cbbEstado.SelectedValue = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao consultar os estados. Por favor, tente novamente.", "Houve um erro ao consulta os estados.");
                Close();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCRMV.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Por favor, informe o CRMV.", "Informe o CRMV.");
                }
                else if (txtNome.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Por favor, informe o nome.", "Informe o nome.");
                }
                else if (!txtTelefone.MaskCompleted)
                {
                    MessageBox.Show("Por favor, informe o telefone.", "Informe o telefone.");
                }
                else if (txtBairro.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Por favor, informe o bairro.", "Informe o bairro.");
                }
                else if (txtEndereco.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Por favor, informe o endereço.", "Informe o endereço.");
                }
                else
                {
                    ObjetoTransferencia.Veterinario veterinario = new ObjetoTransferencia.Veterinario();

                    veterinario.VeterinarioCRMV = txtCRMV.Text.Trim();
                    veterinario.VeterinarioNome = txtNome.Text.Trim();
                    veterinario.VeterinarioTelefone = txtTelefone.Text;
                    veterinario.VeterinarioBairro = txtBairro.Text.Trim();
                    veterinario.VeterinarioEndereco = txtEndereco.Text.Trim();
                    veterinario.Cidade = new Cidade();
                    veterinario.Cidade.CidadeID = int.Parse(cbbCidade.SelectedValue.ToString());

                    VeterinarioNegocios veterinarioNegocios = new VeterinarioNegocios();
                    MessageBox.Show("Veterinário de ID " + veterinarioNegocios.Cadastrar(veterinario) + " cadastrado com sucesso!", "Cadastro realizado com sucesso!");
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