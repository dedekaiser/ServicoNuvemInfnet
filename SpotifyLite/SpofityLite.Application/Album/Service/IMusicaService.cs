using SpofityLite.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Album.Service
{
    public interface IMusicaService
    {
        Task<MusicaOutputDto> Criar(MusicaInputDto dto);
        Task<List<MusicaOutputDto>> ObterTodos();
        Task<MusicaOutputDto> ObterUm(Guid id);
        Task<MusicaOutputDto> Editar(Guid id, MusicaInputDto dto);
        Task<MusicaOutputDto> Deletar(Guid id);
    }
}
