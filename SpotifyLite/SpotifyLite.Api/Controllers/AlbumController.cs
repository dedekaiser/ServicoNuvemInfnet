using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpofityLite.Application.Album.Dto;
using SpofityLite.Application.Album.Handler.Command;
using SpofityLite.Application.Album.Handler.Query;
using SpofityLite.Application.Album.Service;
using SpotifyLite.Domain.Album.Repository;

namespace SpotifyLite.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IMediator mediator;

        public AlbumController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await this.mediator.Send(new GetAllAlbumQuery()));
        }

        [HttpPost()]
        public async Task<IActionResult> Criar(AlbumInputDto dto)
        {
            var result = await this.mediator.Send(new CreateAlbumCommand(dto));
            return Created($"{result.Album.Id}", result.Album);
        }

       
        /*
        [Route("{id?}")]
        [HttpPut]
        public async Task<IActionResult> Editar(Guid id, BandaInputDto Dto)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            var result = await AlbumService.Editar(id, Dto);
            return Created($"{result.Id}", result);
        }

        [Route("{id?}")]
        [HttpDelete]
        public async Task<IActionResult> Deletar(Guid id)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

           await AlbumService.Deletar(id);
            return NoContent();
        }
        */
    }
}
