using MediatR;
using SpofityLite.Application.Usuario.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Usuario.Handler.Query
{
    public class GetUsuarioQuery : IRequest<GetUsuarioQueryResponse>
    {
        public Guid IdUsuario { get; set; }

        public GetUsuarioQuery(Guid idUsuario)
        {
            IdUsuario = idUsuario;
        }
    }

    public class GetUsuarioQueryResponse
    {
        public UsuarioOutputDto Usuario { get; set; }

        public GetUsuarioQueryResponse(UsuarioOutputDto usuario)
        {
            Usuario = usuario;
        }
    }
}
