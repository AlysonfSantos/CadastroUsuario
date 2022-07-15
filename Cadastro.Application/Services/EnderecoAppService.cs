using AutoMapper;
using Cadastro.Application.Services.Interfaces;
using Cadastro.Application.ViewModels;
using Cadastro.Domain.Interfaces.Services;
using Cadastro.Domain.Models;
using Cadastro.Domain.Models.Commands;

namespace Cadastro.Application.Services
{
    public class EnderecoAppService : IEnderecoAppService
    {

        private readonly IEnderecoService _enderecoService;
        private readonly IMapper _mapper;

        public EnderecoAppService(IEnderecoService enderecoService, IMapper mapper)
        {
            _enderecoService = enderecoService;
            _mapper = mapper;
        }

        public async Task<EnderecoViewModel> EnderecoUsuarioId(long id)
        {
            var endereco = await _enderecoService.EnderecoUsuarioId(id);
            return _mapper.Map<EnderecoViewModel>(endereco);
        }

        public async Task<EnderecoViewModel> CadastrarEndereco(NovoEnderecoViewModel novoEnderecoViewModel)
        {
            var novoEndereco = new Endereco(novoEnderecoViewModel.Estado,
                novoEnderecoViewModel.Cidade,
                novoEnderecoViewModel.CEP,
                novoEnderecoViewModel.Logradouro,
                novoEnderecoViewModel.Numero,
                novoEnderecoViewModel.Complemento,
                novoEnderecoViewModel.UsuarioId
                );
            var enderecoCadastrado = await _enderecoService.CadastrarEndereco(novoEndereco);
            return _mapper.Map<EnderecoViewModel>(enderecoCadastrado);
        }

        public async Task<EnderecoViewModel> AtualizarEndereco(AtualizarEnderecoViewModel atualizarEnderecoViewModel)
        {
            var command = new AtualizarEnderecoCommand
            {
                Id = atualizarEnderecoViewModel.Id,
                Estado = atualizarEnderecoViewModel.Estado,
                Cidade = atualizarEnderecoViewModel.Cidade,
                CEP = atualizarEnderecoViewModel.CEP,
                Numero = atualizarEnderecoViewModel.Numero,
                Complemento = atualizarEnderecoViewModel.Complemento
            };
            var enderecoAtualizado = await _enderecoService.AtualizarEndereco(command);
            return _mapper.Map<EnderecoViewModel>(enderecoAtualizado);
        }
    }
}
