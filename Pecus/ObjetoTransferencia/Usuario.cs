using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string UsuarioLogin { get; set; }
        public string UsuarioSenha { get; set; }
        public string UsuarioNome { get; set; }
        public bool UsuarioAtivo { get; set; }
        public TipoUsuario TipoUsuario { get; set; }

    }
    public class UsuarioCollection : List<Usuario>
    {

    }
}
