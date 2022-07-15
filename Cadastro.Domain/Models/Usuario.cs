
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
        public bool Habilitação { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataUpdate { get; private set; }
        public long EnderecoId { get; private set; }
        public Endereco Endereco { get; private set; }


        public Usuario(string nome, string cpf, string telefone, string email,
            bool habilitacao, int endereco)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Habilitação = true;
            DataCriacao = DateTime.Now;
            EnderecoId = endereco;
        }

        public void Atualizar( string nome, string telefone,
             string email, bool habilitacao)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Habilitação = true;
            DataUpdate = DateTime.Now;
         
        }
                
    }
}
