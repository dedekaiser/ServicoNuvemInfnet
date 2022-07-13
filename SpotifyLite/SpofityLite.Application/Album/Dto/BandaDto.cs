using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Album.Dto
{
    public record BandaInputDto(
                [Required(ErrorMessage = "Nome é obrigatório")] string Nome,
                [Required(ErrorMessage = "Foto é obrigatório")] string Foto,
                [Required(ErrorMessage = "Descrição é obrigatório")] string Descricao);
    public record BandaOutputDto(Guid Id, string Nome, string Foto, string Descricao);
}
