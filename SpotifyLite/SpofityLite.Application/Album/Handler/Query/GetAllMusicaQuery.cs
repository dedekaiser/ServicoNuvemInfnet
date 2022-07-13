using MediatR;
using SpofityLite.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Album.Handler.Query
{
    public class GetAllMusicaQuery : IRequest<GetAllMusicaQueryResponse>
    {

    }

    public class GetAllMusicaQueryResponse
    {
        public IList<MusicaOutputDto> Musicas { get; set; }

        public GetAllMusicaQueryResponse(IList<MusicaOutputDto> Musicas)
        {
            this.Musicas = Musicas;
        }
    }
}
