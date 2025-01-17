﻿using MediatR;
using SpofityLite.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Album.Handler.Command
{
    public class CreateBandaCommand : IRequest<CreateBandaCommandResponse>
    {
        public BandaInputDto Banda { get; set; }

        public CreateBandaCommand(BandaInputDto album)
        {
            this.Banda = album;
        }
    }

    public class CreateBandaCommandResponse
    {
        public BandaOutputDto Banda { get; set; }

        public CreateBandaCommandResponse(BandaOutputDto album)
        {
            Banda = album;
        }
    }
}
