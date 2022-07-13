using MediatR;
using SpofityLite.Application.Album.Handler.Command;
using SpofityLite.Application.Album.Handler.Query;
using SpofityLite.Application.Album.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Album.Handler
{
    public class AlbumHandler : IRequestHandler<CreateAlbumCommand, CreateAlbumCommandResponse>,
                                IRequestHandler<GetAllAlbumQuery, GetAllAlbumQueryResponse>
    {
        private readonly IAlbumService _albumService;

        public AlbumHandler(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public async Task<CreateAlbumCommandResponse> Handle(CreateAlbumCommand request, CancellationToken cancellationToken)
        {
            var result = await this._albumService.Criar(request.Album);
            return new CreateAlbumCommandResponse(result); 
        }

        public async Task<GetAllAlbumQueryResponse> Handle(GetAllAlbumQuery request, CancellationToken cancellationToken)
        {
            var result = await this._albumService.ObterTodos();
            return new GetAllAlbumQueryResponse(result);
        }
        public async Task<GetAlbumQueryResponse> Handle(GetAlbumQuery request, CancellationToken cancellationToken)
        {
            var result = await this._albumService.ObterUm(request.IdAlbum);
            return new GetAlbumQueryResponse(result);
        }

        public async Task<DeleteAlbumCommandResponse> Handle(DeleteAlbumCommand request, CancellationToken cancellationToken)
        {
            await this._albumService.Deletar(request.IdAlbum);
            return new DeleteAlbumCommandResponse();
        }

        public async Task<EditAlbumCommandResponse> Handle(EditAlbumCommand request, CancellationToken cancellationToken)
        {
            var result = await this._albumService.Editar(request.IdAlbum, request.Album);
            return new EditAlbumCommandResponse(result);
        }
    }
}
