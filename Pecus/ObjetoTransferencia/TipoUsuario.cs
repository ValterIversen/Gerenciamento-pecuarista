using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class TipoUsuario
    {
        public int TipoUsuarioID { get; set; }
        public string TipoUsuarioDescricao { get; set; }
    }
    public class TipoUsuarioCollection : List<TipoUsuario>
    {

    }
}
