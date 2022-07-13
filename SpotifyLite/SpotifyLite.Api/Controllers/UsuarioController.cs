using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpofityLite.Application.Usuario.DTO;
using SpofityLite.Application.Usuario.Service;
using SpotifyLite.Domain.Account.Repository;
using MediatR;
using SpofityLite.Application.Usuario.Handler.Command;

namespace SpotifyLite.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        

        public IUsuarioService UsuarioService { get; }
        public IMediator mediator;

        public UsuarioController(IUsuarioService usuarioService, IMediator mediator)
        {
            UsuarioService = usuarioService;
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Criar(UsuarioInputDto Dto)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            var result = await this.mediator.Send(new CreateUsuarioCommand(Dto));
            return Created($"{result.usuario.Id}", result);
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
