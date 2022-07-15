
namespace Cadastro.Application.ViewModels
{
    public class AtualizarEnderecoViewModel
    {
        public long Id { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public int EnderecoId { get; set; }

    }
}
