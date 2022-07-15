namespace Cadastro.Domain.Models
{
    public class Endereco
    {
        public long Id { get; private set; }
        public string Estado { get; private set; }
        public string Cidade { get; private set; }
        public string CEP { get; private set; }
        public string Logradouro { get; private set; }
        public int Numero { get; private set; }
        public string Complemento { get; private set; }
        public long UsuarioId { get; private set; }
        public ICollection<Usuario> Usuario { get; private set; }

        public Endereco(string estado, string cidade, string cEP, string logradouro, int numero, string complemento, long usuarioId)
        {

            Estado = estado;
            Cidade = cidade;
            CEP = cEP;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            UsuarioId = usuarioId;
         
        }

        public void Atualizar( string estado, string cidade, string cEP, string logradouro, int numero, string complemento)
        {
         
            Estado = estado;
            Cidade = cidade;
            CEP = cEP;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
          
        }
    }
}
