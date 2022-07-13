using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Album.Handler.Command
{
    public class DeleteBandaCommand : IRequest<DeleteBandaCommandResponse>
    {
        public Guid IdBanda { get; set; }

        public DeleteBandaCommand(Guid idBanda)
        {
            IdBanda = idBanda;
        }
    }

    public class DeleteBandaCommandResponse
    {

    }
}
