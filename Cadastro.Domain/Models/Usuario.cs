using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Models
{
    public class Usuario
    {
        public Usuario() {  }

        public long Id { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public bool Ativo { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataUpdate { get; private set; }

  

        public Usuario(string nome, string cpf, string telefone, string email, bool ativo, DateTime dataCriacao)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Ativo = true;
            DataCriacao = dataCriacao;
        }

        public void Atualizar( string nome, string telefone,
             string email, bool ativo, DateTime dataUpdate)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Ativo = true;
            DataUpdate = dataUpdate;
        }
    }
}
