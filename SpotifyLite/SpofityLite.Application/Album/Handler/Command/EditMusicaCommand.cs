using MediatR;
using SpofityLite.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Album.Handler.Command
{
    public class EditMusicaCommand : IRequest<EditMusicaCommandResponse>
    {
        public MusicaInputDto Musica { get; set; }

        public Guid IdMusica { get; set; }

        public EditMusicaCommand(Guid idMusica, MusicaInputDto album)
        {
            IdMusica = idMusica;
            Musica = album;
        }
    }

    public class EditMusicaCommandResponse
    {
        public MusicaOutputDto Musica { get; set; }

        public EditMusicaCommandResponse(MusicaOutputDto album)
        {
            Musica = album;
        }
    }
}
