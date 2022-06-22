using Cadastro.Application.ViewModels;

namespace Cadastro.Application.Services.Interfaces
{
    public interface ICadastroAppService
    {
        Task<IEnumerable<UsuarioViewModel>> ListarUsuario();
        Task<UsuarioViewModel> UsuarioId(long id);
        Task<UsuarioViewModel> CadastrarUsuario(NovoUsuarioViewModel novoUsuarioViewModel);
        Task<UsuarioViewModel> AtualizarUsuario(AtualizarUsuarioViewModel atualizarUsuarioViewModel);
        Task<bool> DeletarUsuario(long id);
    }
}
