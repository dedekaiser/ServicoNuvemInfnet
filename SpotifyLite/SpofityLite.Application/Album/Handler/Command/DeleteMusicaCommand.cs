using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Album.Handler.Command
{
    public class DeleteMusicaCommand : IRequest<DeleteMusicaCommandResponse>
    {
        public Guid IdMusica { get; set; }

        public DeleteMusicaCommand(Guid idMusica)
        {
            IdMusica = idMusica;
        }
    }

    public class DeleteMusicaCommandResponse
    {

    }
}
