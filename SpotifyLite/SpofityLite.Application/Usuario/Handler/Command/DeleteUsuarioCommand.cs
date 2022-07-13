using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Usuario.Handler.Command
{
    
        public class DeleteUsuarioCommand : IRequest<DeleteUsuarioCommandResponse>
        {
            public Guid IdUsuario { get; set; }

            public DeleteUsuarioCommand(Guid idUsuario)
            {
                IdUsuario = idUsuario;
            }
        }

        public class DeleteUsuarioCommandResponse
        {

        }
}