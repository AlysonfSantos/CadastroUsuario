
namespace Cadastro.Application.ViewModels
{
    public class NovoUsuarioViewModel
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Habilitação { get; set; }
        public DateTime DataCriacao { get; set; }
        public int EnderecoId { get; set; }


    }
}
