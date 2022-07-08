using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpofityLite.Application.Album.Dto;
using SpofityLite.Application.Album.Service;

namespace SpotifyLite.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BandaController : ControllerBase
    {
        private readonly IBandaService BandaService;

        public BandaController(IBandaService bandaService)
        {
            this.BandaService = bandaService;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            return Ok(await this.BandaService.ObterTodos());
        }

        [HttpPost]
        public async Task<IActionResult> Criar(BandaInputDto dto)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            var result = await this.BandaService.Criar(dto);

            return Created($"/{result.Id}", result);
        }

        [Route("{id?}")]
        [HttpGet]
        public async Task<IActionResult> ObterUm(Guid id)
        {
            return Ok(await this.BandaService.ObterUm(id));
        }

        [Route("{id?}")]
        [HttpPut]
        public async Task<IActionResult> Editar(Guid id, BandaInputDto Dto)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            var result = await BandaService.Editar(id, Dto);
            return Created($"{result.Id}", result);
        }

        [Route("{id?}")]
        [HttpDelete]
        public async Task<IActionResult> Deletar(Guid id)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            await BandaService.Deletar(id);
            return NoContent();
        }
    }
}
