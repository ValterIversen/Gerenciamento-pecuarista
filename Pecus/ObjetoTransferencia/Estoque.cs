using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Estoque
    {
        public int EstoqueID { get; set; }
        public decimal EstoqueQuantidade { get; set; }
        public bool EstoqueAtivo { get; set; }
        public EstoqueLocalidade EstoqueLocalidade { get; set; }
        public Item Item { get; set; }
    }
    public class EstoqueRelatorio
    {
        public int EstoqueID { get; set; }
        public decimal EstoqueQuantidade { get; set; }
        public bool EstoqueAtivo { get; set; }
        public string ItemDescricao { get; set; }
        public string TipoItemDescricao { get; set; }
    }
    public class EstoqueCollection : List<Estoque>
    {

    }
}
