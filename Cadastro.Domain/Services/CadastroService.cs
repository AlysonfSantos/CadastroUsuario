using Cadastro.Domain.Interfaces.Repositories;
using Cadastro.Domain.Interfaces.Services;
using Cadastro.Domain.Models;
using Cadastro.Domain.Models.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Services
{
    public class CadastroService : ICadastroService
    {
        private readonly ICadastroRepository _cadastroRepository;

        public CadastroService( ICadastroRepository cadastroRepository)
        {
            _cadastroRepository = cadastroRepository;
        }

        public async Task<IEnumerable<Usuario>> ListarUsuario()
        {
            return await _cadastroRepository.ListarUsuario();
        }

        public async Task<Usuario> UsuarioId(long id)
        {
            return await _cadastroRepository.Get(x => x.Id == id);
        }

        public async Task<Usuario> CadastrarUsuario(Usuario usuario)
        {
            await _cadastroRepository.CadastrarUsuario(usuario);

            if (!ValidaCPF(usuario.CPF)) return null;
            
            await _cadastroRepository.UnitOfWork.SaveChangesAsync();

            return usuario;
        }

        public async Task<Usuario> AtualizarUsuario(AtualizarUsuarioCommand command)
        {
            var usuario = await _cadastroRepository.Get(x => x.Id == command.Id);
            if (usuario == null) return null;

            usuario.Atualizar(command.Nome,
                    command.Telefone,
                    command.Email,
                    command.Ativo,
                    command.DataUpdate);
                
            await _cadastroRepository.AtualizarUsuario(usuario);
            await _cadastroRepository.UnitOfWork.SaveChangesAsync();
            return usuario;
        }

        public async Task<bool> DeletarUsuario(long id)
        {
            var usuario = await _cadastroRepository.Get(x => x.Id == id);
            if (usuario == null) return false;

            await _cadastroRepository.DeletarUsuario(usuario);
            await _cadastroRepository.UnitOfWork.SaveChangesAsync();

            return true;

        }
        public static bool ValidaCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}

