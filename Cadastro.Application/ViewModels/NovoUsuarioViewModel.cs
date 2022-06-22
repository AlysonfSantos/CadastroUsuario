
namespace Cadastro.Application.ViewModels
{
    public class NovoUsuarioViewModel
    {
   
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCriacao { get; set; }
        
    }
}
