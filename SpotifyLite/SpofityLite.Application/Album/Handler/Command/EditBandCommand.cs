using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SpofityLite.Application.Album.Dto;

namespace SpofityLite.Application.Album.Handler.Command
{
    public class EditBandaCommand : IRequest<EditBandaCommandResponse>
    {
        public BandaInputDto Banda { get; set; }

        public Guid IdBanda { get; set; }

        public EditBandaCommand(Guid idBanda, BandaInputDto album)
        {
            IdBanda = idBanda;
            Banda = album;
        }
    }

    public class EditBandaCommandResponse
    {
        public BandaOutputDto Banda { get; set; }

        public EditBandaCommandResponse(BandaOutputDto album)
        {
            Banda = album;
        }
    }
}
