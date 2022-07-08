using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Usuario.DTO
{
    public record UsuarioInputDto([Required(ErrorMessage ="Nome é obrigatório")]string Nome,
        [Required(ErrorMessage = "email é obrigatório")] string Email,
        [Required(ErrorMessage = "pwd é obrigatório")] string Password);

    public record UsuarioOutputDto(Guid Id, string Email, string Password);
}
