using AutoMapper;
using Moq;
using SpofityLite.Application.Album.Dto;
using SpofityLite.Application.Album.Service;
using SpotifyLite.Domain.Album;
using SpotifyLite.Domain.Album.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Test.Application
{

    public class MusicaServiceTests
    {


        [Fact]
        public async Task DeletarTeste()
        {
            var mockMapper = new Mock<IMapper>();


            Guid guid = Guid.NewGuid();
            Mock<IMusicaRepository> mockRepository = new();
            Musica musica = new();

            mockRepository.Setup(x => x.Get(guid)).Returns(Task.FromResult(musica));
            mockRepository.Setup(x => x.Delete(musica));

            var service = new MusicaService(mockRepository.Object, mockMapper.Object);
            var result = await service.Deletar(guid);

            Assert.Null(result);


            


        }

        [Fact]

        public async Task EditarTeste()
        {
            var mockMapper = new Mock<IMapper>();


            Guid guid = Guid.NewGuid();
            Mock<IMusicaRepository> mockRepository = new();
            Musica musica = new();
            MusicaInputDto dtoInput = new("musicateste", 300);
            MusicaOutputDto dtoOutput = new(guid, "musicateste", "300");

            mockMapper.Setup(x => x.Map<Musica>(dtoInput)).Returns(musica);
            mockMapper.Setup(x => x.Map<MusicaOutputDto>(musica)).Returns(dtoOutput);
            mockRepository.Setup(x => x.Update(musica));

            var service = new MusicaService(mockRepository.Object, mockMapper.Object);
            var result = await service.Editar(guid, dtoInput);

            Assert.NotNull(result);

        }

      
    }
}
