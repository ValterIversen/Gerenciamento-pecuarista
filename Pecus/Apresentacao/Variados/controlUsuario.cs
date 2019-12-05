using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Variados
{
    public partial class controlUsuario : UserControl
    {
        public controlUsuario()
        {
            InitializeComponent();
        }

        private void BtnCadastroUsuario_Click(object sender, EventArgs e)
        {
            Usuario.frmCadastroUsuario frmCadastroUsuario = new Usuario.frmCadastroUsuario();
            frmCadastroUsuario.ShowDialog();
        }

        private void BtnConsultaUsuario_Click(object sender, EventArgs e)
        {
            Usuario.frmConsultaUsuario frmConsultaUsuario = new Usuario.frmConsultaUsuario(false) ;
            frmConsultaUsuario.ShowDialog();
        }
    }
}
