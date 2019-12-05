using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class EstoqueLocalidade
    {
        public int EstoqueLocalidadeID { get; set; }
        public string EstoqueLocalidadeDescricao { get; set; }
        public string EstoqueLocalidadeEndereco { get; set; }
        public Cidade Cidade { get; set; }
        public ContratoAluguel ContratoAluguel { get; set; }
        public EstoqueCollection Estoques { get; set; }
    }
    public class EstoqueLocalidadeRelatorio
    {
        public int EstoqueLocalidadeID { get; set; }
        public string EstoqueLocalidadeDescricao { get; set; }
        public string EstoqueLocalidadeEndereco { get; set; }
        public string CidadeNome { get; set; }
        public string EstadoNome { get; set; }
    }

    public class EstoqueLocalidadeCollection : List<EstoqueLocalidade>
    {

    }
}
