using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Cidade : Estado
    {
        public int CidadeID { get; set; }
        public string CidadeNome { get; set; }
    }
    public class CidadeCollection : List<Cidade>
    {

    }
}
