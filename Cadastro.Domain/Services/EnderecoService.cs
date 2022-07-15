using Cadastro.Domain.Interfaces.Repositories;
using Cadastro.Domain.Interfaces.Services;
using Cadastro.Domain.Models;
using Cadastro.Domain.Models.Commands;


namespace Cadastro.Domain.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        public async Task<Endereco> EnderecoUsuarioId(long id)
        {
            return await _enderecoRepository.Get(x => x.UsuarioId == id);
        }

        public async Task<Endereco> CadastrarEndereco(Endereco endereco)
        {
            await _enderecoRepository.CadastrarEndereco(endereco);
            await _enderecoRepository.UnitOfWork.SaveChangesAsync();

            return endereco;
        }

        public async Task<Endereco> AtualizarEndereco(AtualizarEnderecoCommand command)
        {
            var endereco = await _enderecoRepository.Get(x => x.Id == command.Id);
            if (endereco == null) return null;

            endereco.Atualizar(command.Estado,
                    command.Cidade,
                    command.CEP,
                    command.Logradouro,
                    command.Numero,
                    command.Complemento);

            await _enderecoRepository.AtualizarEndereco(endereco);
            await _enderecoRepository.UnitOfWork.SaveChangesAsync();
            return endereco;
        }

    }
}
