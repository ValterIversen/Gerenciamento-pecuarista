using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class PessoaJuridica
    {
        public string PessoaJuridicaCNPJ { get; set; }
        public string PessoaJuridicaRazaoSocial { get; set; }
        public string PessoaJuridicaNomeFicticio { get; set; }
    }
    public class PessoaJuridicaCollection : List<PessoaJuridica>
    {

    }
}
