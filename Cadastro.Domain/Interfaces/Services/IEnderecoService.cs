using Cadastro.Domain.Models;
using Cadastro.Domain.Models.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Interfaces.Services
{
    public interface IEnderecoService
    {
        Task<Endereco> EnderecoUsuarioId(long id);
        Task<Endereco> CadastrarEndereco(Endereco endereco);
        Task<Endereco> AtualizarEndereco(AtualizarEnderecoCommand command);
    }
}
