using MediatR;
using SpofityLite.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Album.Handler.Query
{
    public class GetMusicaQuery : IRequest<GetMusicaQueryResponse>
    {
        public Guid IdMusica { get; set; }

        public GetMusicaQuery(Guid idMusica)
        {
            IdMusica = idMusica;
        }
    }

    public class GetMusicaQueryResponse
    {
        public MusicaOutputDto Musica { get; set; }

        public GetMusicaQueryResponse(MusicaOutputDto musica)
        {
            Musica = musica;
        }
    }
}
