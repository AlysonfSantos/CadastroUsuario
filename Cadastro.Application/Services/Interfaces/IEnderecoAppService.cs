using Cadastro.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Interfaces
{
    public interface IEnderecoAppService
    {
        Task<EnderecoViewModel> EnderecoUsuarioId(long id);
        Task<EnderecoViewModel> CadastrarEndereco(NovoEnderecoViewModel novoEnderecoViewModel);
        Task<EnderecoViewModel> AtualizarEndereco(AtualizarEnderecoViewModel atualizarEnderecoViewModel);

    }
}

