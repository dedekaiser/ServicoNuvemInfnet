using MediatR;
using SpofityLite.Application.Usuario.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Usuario.Handler.Command
{
    public class EditUsuarioCommand : IRequest<EditUsuarioCommandResponse>
    {
        public UsuarioInputDto Usuario { get; set; }

        public Guid IdUsuario { get; set; }

        public EditUsuarioCommand(Guid idUsuario, UsuarioInputDto usuario)
        {
            IdUsuario = idUsuario;
            Usuario = usuario;
        }
    }

    public class EditUsuarioCommandResponse
    {
        public UsuarioOutputDto Usuario { get; set; }

        public EditUsuarioCommandResponse(UsuarioOutputDto usuario)
        {
            Usuario = usuario;
        }
    }
}
