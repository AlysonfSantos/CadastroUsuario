using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Models.Commands
{
    public class AtualizarEnderecoCommand
    {
        public long Id { get;  set; }
        public string Estado { get;  set; }
        public string Cidade { get;  set; }
        public string CEP { get;  set; }
        public string Logradouro { get;  set; }
        public int Numero { get;  set; }
        public string Complemento { get;  set; }
        

    }
}
