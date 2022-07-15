using Cadastro.Application.Services.Interfaces;
using Cadastro.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnderecoController : Controller
    {
     
        private readonly IEnderecoAppService _enderecoAppService;

        public EnderecoController(IEnderecoAppService enderecoAppService)
        {
            _enderecoAppService = enderecoAppService;
        }

 
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> EnderecoUsuarioId(long id)
        {
            var endereco = await _enderecoAppService.EnderecoUsuarioId(id);
            if (endereco == null) return NotFound("Nenhum endereço encontrado");

            return Ok(endereco);
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarEndereco([FromBody] NovoEnderecoViewModel vm)
        {
            var result = await _enderecoAppService.CadastrarEndereco(vm);
            if (result == null) return BadRequest("Não foi possível cadastrar nenhum Endereço");
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarEndereco([FromBody] AtualizarEnderecoViewModel vm)
        {
            var result = await _enderecoAppService.AtualizarEndereco(vm);
            if (result == null) return BadRequest("Não foi possível Atualizar o Endereço");
            return Ok(result);
        }

      
    }
}
