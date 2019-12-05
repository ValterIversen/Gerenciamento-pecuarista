using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Estado
    {
        public int EstadoID { get; set; }
        public string EstadoNome { get; set; }
        public string EstadoSigla { get; set; }
        public CidadeCollection Cidades { get; set; }
    }
    public class EstadoCollection : List<Estado>
    {

    }
}
