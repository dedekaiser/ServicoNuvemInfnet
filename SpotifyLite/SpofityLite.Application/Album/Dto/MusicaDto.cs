using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Album.Dto
{
    public record MusicaInputDto(string Nome, int Duracao);
    public record MusicaOutputDto(Guid Id, string Nome, string Duracao);
}
