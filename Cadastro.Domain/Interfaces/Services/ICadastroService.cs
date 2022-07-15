using Cadastro.Domain.Models;
using Cadastro.Domain.Models.Commands;

namespace Cadastro.Domain.Interfaces.Services
{
    public interface ICadastroService
    {
        Task<IEnumerable<Usuario>> ListarUsuario();
        Task<Usuario> UsuarioId(long id);
        Task<Usuario> CadastrarUsuario(Usuario usuario);
        Task<Usuario> AtualizarUsuario(AtualizarUsuarioCommand command);
        Task<bool> DeletarUsuario(long id);


    }
}
