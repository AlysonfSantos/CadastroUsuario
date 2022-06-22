using Cadastro.Application.Services.Interfaces;
using Cadastro.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController1 : ControllerBase
    {
        private readonly ICadastroAppService _cadastroAppService;

        public UsuarioController1(ICadastroAppService cadastroAppService)
        {
            _cadastroAppService = cadastroAppService;
        }
        [HttpGet]
        public async Task<IActionResult> ListarUsuario()
        {
            var usuario = await _cadastroAppService.ListarUsuario();
            if (usuario == null) return NotFound("Nenhum Usuário encontrado");
            return Ok(usuario);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> UsuarioId(long id)
        {
            var usuario = await _cadastroAppService.UsuarioId(id);
            if (usuario == null) return NotFound("Nenhum Usuário encontrado");

            return Ok(usuario);
        }


        [HttpPost]
        public async Task<IActionResult> CadastrarUsuario([FromBody] NovoUsuarioViewModel vm)
        {
            var result = await _cadastroAppService.CadastrarUsuario(vm);
            if (result == null) return BadRequest("Não foi possível cadastrar nenhum Usuário");
            return Ok(result);
        }

        [HttpPut]

        public async Task<IActionResult> AtualizarProduto([FromBody] AtualizarUsuarioViewModel vm)
        {
            var result = await _cadastroAppService.AtualizarUsuario(vm);
            if (result == null) return BadRequest("Não foi possível Atualizar o Usuário");
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]

        public async Task<IActionResult> DeletarUsuario(long id)
        {
            var result = await _cadastroAppService.DeletarUsuario(id);
            if (!result) return BadRequest($"Não foi possível excluir produto {id}");
            if (result) return Ok();
            return NotFound();
        }


    }
}
