using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class ListaVeterinario
    {
        public int ListaVeterinarioID { get; set; }
        public Veterinario Veterinario { get; set; }
        public ConsultaVeterinaria ConsultaVeterinaria { get; set; }
    }
    public class ListaVeterinarioCollection : List<ListaVeterinario>
    {

    }
}
