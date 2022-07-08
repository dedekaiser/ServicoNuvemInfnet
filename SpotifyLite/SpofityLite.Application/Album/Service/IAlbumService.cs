using SpofityLite.Application.Album.Dto;

namespace SpofityLite.Application.Album.Service
{
    public interface IAlbumService
    {
        Task<AlbumOutputDto> Criar(AlbumInputDto dto);
        Task<List<AlbumOutputDto>> ObterTodos();
        Task<AlbumOutputDto> Editar(Guid id, AlbumInputDto dto);
        Task Deletar(Guid id);
        Task<AlbumOutputDto> ObterUm(Guid id);
    }
}