using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpofityLite.Application.Usuario.DTO;
using SpofityLite.Application.Usuario.Service;
using SpotifyLite.Domain.Account.Repository;

namespace SpotifyLite.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public IUsuarioService UsuarioService { get; }

        public UsuarioController(IUsuarioService usuarioService)
        {
            UsuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            return Ok(await this.UsuarioService.ObterTodos());
        }

        [Route("{id?}")]
        [HttpGet]
        public async Task<IActionResult> ObterUm(Guid id)
        {
            return Ok(await this.UsuarioService.ObterUm(id));
        }

        [HttpPost]
        public async Task<IActionResult> Criar(UsuarioInputDto Dto)
        {
            if(ModelState.IsValid == false)
                return BadRequest(ModelState);

            var result = await UsuarioService.Criar(Dto);
            return Created($"{result.Id}", result);
        }

        [Route("{id?}")]
        [HttpPut]
        public async Task<IActionResult> Editar(Guid id, UsuarioInputDto Dto)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            var result = await UsuarioService.Editar(id, Dto);
            return Created($"{result.Id}", result);
        }

        [Route("{id?}")]
        [HttpDelete]
        public async Task<IActionResult> Deletar(Guid id)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            await UsuarioService.Deletar(id);
            return NoContent();
        }
    }
}
