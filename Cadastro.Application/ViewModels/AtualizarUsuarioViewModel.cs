namespace Cadastro.Application.ViewModels
{
    public class AtualizarUsuarioViewModel
    {
        public long Id { get; set; }
        public string Nome { get; set; } 
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataUpdate { get; set; }
    }
}
