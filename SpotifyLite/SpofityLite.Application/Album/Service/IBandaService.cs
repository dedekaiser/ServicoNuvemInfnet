using SpofityLite.Application.Album.Dto;

namespace SpofityLite.Application.Album.Service
{
    public interface IBandaService
    {
        Task<BandaOutputDto> Criar(BandaInputDto dto);
        Task<List<BandaOutputDto>> ObterTodos();

        Task<BandaOutputDto> Editar(Guid id, BandaInputDto dto);
        Task Deletar(Guid id);
        Task<BandaOutputDto> ObterUm(Guid id);
    }
}