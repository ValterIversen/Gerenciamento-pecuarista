using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class PessoaFisica
    {
        public string PessoaFisicaCPF { get; set; }
        public string PessoaFisicaNome { get; set; }
    }
    public class PessoaFisicaCollection : List<PessoaFisica>
    {

    }
}
