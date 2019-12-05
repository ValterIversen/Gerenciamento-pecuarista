using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Veterinario
    {
        public int VeterinarioID { get; set; }
        public string VeterinarioCRMV { get; set; }
        public string VeterinarioNome { get; set; }
        public string VeterinarioTelefone { get; set; }
        public string VeterinarioBairro { get; set; }
        public string VeterinarioEndereco { get; set; }
        public bool VeterinarioAtivo { get; set; }
        public Cidade Cidade { get; set; }
        public ConsultaVeterinariaCollection ConsultasVeterinarias{ get; set; }
    }
    public class VeterinarioCollection : List<Veterinario>
    {

    }
}
