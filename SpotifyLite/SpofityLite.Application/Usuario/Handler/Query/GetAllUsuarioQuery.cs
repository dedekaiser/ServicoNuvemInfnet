﻿using MediatR;
using SpofityLite.Application.Usuario.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Usuario.Handler.Query
{
    public class GetAllUsuarioQuery : IRequest<GetAllUsuarioQueryResponse>
    {

    }

    public class GetAllUsuarioQueryResponse
    {
        public IList<UsuarioOutputDto> Usuarios { get; set; }

        public GetAllUsuarioQueryResponse(IList<UsuarioOutputDto> usuario)
        {
            Usuarios = usuario;
        }
    }
}
