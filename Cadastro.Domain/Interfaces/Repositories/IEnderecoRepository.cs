using Cadastro.Domain.Models;

namespace Cadastro.Domain.Interfaces.Repositories
{
    public interface IEnderecoRepository : IBaseRepository<Endereco>
    {
        Task<Endereco> EnderecoEnderecoId(long id);
        Task CadastrarEndereco(Endereco endereco);
        Task AtualizarEndereco(Endereco endereco);

    }
}
