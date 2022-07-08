using SpofityLite.Application.Usuario.DTO;

namespace SpofityLite.Application.Usuario.Service
{
    public interface IUsuarioService
    {
        Task<UsuarioOutputDto> Criar(UsuarioInputDto dto);
        Task<List<UsuarioOutputDto>> ObterTodos();
        Task<UsuarioOutputDto> Editar(Guid id, UsuarioInputDto dto);
        Task Deletar(Guid id);
        Task<UsuarioOutputDto> ObterUm(Guid id);

    }
}