using Cadastro.Domain.Interfaces.Repositories;
using Cadastro.Domain.Models;
using Cadastro.Infra.Data.EF;
using Cadastro.Infra.Data.Repositories.Abstract;


namespace Cadastro.Infra.Data.Repositories
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        private readonly CadastroContext _context;

        public EnderecoRepository(CadastroContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Endereco> EnderecoEnderecoId(long id)
        {
            return await _context.Enderecos.FindAsync(id);
        }
        public async Task CadastrarEndereco(Endereco endereco)
        {
            await _context.AddAsync(endereco);
        }

        public async Task AtualizarEndereco(Endereco endereco)
        {
            await Task.FromResult(_context.Update(endereco));
        }
  
    }
}
