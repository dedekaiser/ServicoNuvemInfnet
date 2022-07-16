using AutoMapper;
using Moq;
using SpofityLite.Application.Usuario.DTO;
using SpofityLite.Application.Usuario.Service;
using SpotifyLite.Domain.Account;
using SpotifyLite.Domain.Account.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Test.Application
{
    public class UsuarioServiceTests
    {


        [Fact]
        public async Task DeletarTeste()
        {
            var mockMapper = new Mock<IMapper>();


            Guid guid = Guid.NewGuid();
            Usuario usuario = new();
            Mock<IUsuarioRepository> mockRepository = new();
            mockRepository.Setup(x => x.Get(guid)).Returns(Task.FromResult(usuario));
            mockRepository.Setup(x => x.Delete(usuario));

            var service = new UsuarioService(mockRepository.Object, mockMapper.Object);
            var result = service.Deletar(guid);

            Assert.NotNull(result);

        }

        [Fact]

        public async Task EditarTeste()
        {
            var mockMapper = new Mock<IMapper>();

            Guid guid = Guid.NewGuid();
            Usuario usuario = new();
            Mock<IUsuarioRepository> mockRepository = new();
            UsuarioInputDto dtoInput = new("nome", "email@gmail.com", "123456");
            UsuarioOutputDto dtoOutput = new(guid, "email@gmail.com", "123456");

            mockMapper.Setup(x => x.Map<Usuario>(dtoInput)).Returns(usuario);
            mockMapper.Setup(x => x.Map<UsuarioOutputDto>(usuario)).Returns(dtoOutput);
            mockRepository.Setup(x => x.Update(usuario));

            var service = new UsuarioService(mockRepository.Object, mockMapper.Object);
            var result = await service.Editar(guid, dtoInput);

            Assert.NotNull(result);

        }
    }
}
