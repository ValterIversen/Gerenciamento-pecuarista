using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemDescricao { get; set; }
        public TipoItem TipoItem { get; set; }
    }
    public class ItemCollection : List<Item>
    {

    }
}
