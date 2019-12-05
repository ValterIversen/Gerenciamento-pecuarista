using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class RetiradaItem
    {
        public int RetiradaItemID { get; set; }
        public string RetiradaItemDescricao { get; set; }
        public decimal RetiradaItemQuantidade { get; set; }
        public DateTime RetiradaItemData { get; set; }
        public Estoque Estoque { get; set; }
        public Usuario Usuario { get; set; }
        public Item Item { get; set; }
    }
    public class RetiradaItemRelatorio
    {
        public int RetiradaItemID { get; set; }
        public string RetiradaItemDescricao { get; set; }
        public decimal RetiradaItemQuantidade { get; set; }
        public DateTime RetiradaItemData { get; set; }
        public string UsuarioNome { get; set; }
        public string ItemDescricao { get; set; }
        public string TipoItemDescricao { get; set; }
    }
    public class RetiradaItemCollection : List<RetiradaItem>
    {

    }
}
