using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Album.Handler.Command
{
    public class DeleteAlbumCommand : IRequest<DeleteAlbumCommandResponse>
    {
        public Guid IdAlbum { get; set; }

        public DeleteAlbumCommand(Guid idAlbum)
        {
            IdAlbum = idAlbum;
        }
    }

    public class DeleteAlbumCommandResponse
    {

    }
}
