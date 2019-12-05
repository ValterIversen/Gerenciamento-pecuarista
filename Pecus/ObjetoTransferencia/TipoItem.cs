using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class TipoItem
    {
        public int TipoItemID { get; set; }
        public string TipoItemDescricao { get; set; }
    }
    public class TipoItemCollection : List<TipoItem>
    {

    }
}
