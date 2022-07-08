using MediatR;
using SpofityLite.Application.Usuario.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Usuario.Handler.Command
{
    public class CreateUsuarioCommand : IRequest<CreateUsuarioCommandResponse>
    {
        public CreateUsuarioCommand(UsuarioInputDto usuario)
        {
            this.usuario = usuario;
        }

        public UsuarioInputDto usuario { get; set; }

    }
    public class CreateUsuarioCommandResponse
    {
        public CreateUsuarioCommandResponse(UsuarioOutputDto usuario)
        {
            this.usuario = usuario;
        }

        public UsuarioOutputDto usuario { get; set; }

    }


        
}
