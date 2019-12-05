using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class EntradaItem
    {
        public int EntradaItemID { get; set; }
        public string EntradaItemDescricao { get; set; }
        public decimal EntradaItemQuantidade { get; set; }
        public DateTime EntradaItemData { get; set; }
        public Estoque Estoque { get; set; }
        public Usuario Usuario { get; set; }
        public Item Item { get; set; }
    }
    public class EntradaItemRelatorio
    {
        public int EntradaItemID { get; set; }
        public string EntradaItemDescricao { get; set; }
        public decimal EntradaItemQuantidade { get; set; }
        public DateTime EntradaItemData { get; set; }
        public string UsuarioNome { get; set; }
        public string ItemDescricao { get; set; }
        public string TipoItemDescricao { get; set; }
    }
    public class EntradaItemCollection : List<EntradaItem>
    {

    }
}
