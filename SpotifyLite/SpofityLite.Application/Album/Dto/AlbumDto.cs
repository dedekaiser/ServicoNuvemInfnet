using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Album.Dto
{
    public record AlbumInputDto(string Nome, DateTime DataLancamento, string Backdrop, List<MusicaInputDto> Musicas);
    public record AlbumOutputDto(Guid Id, string Nome, DateTime DataLancamento, string Backdrop, List<MusicaOutputDto> Musicas);
    
    

}
