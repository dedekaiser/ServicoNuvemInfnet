using AutoMapper;
using Moq;
using SpofityLite.Application.Album.Dto;
using SpofityLite.Application.Album.Service;
using SpotifyLite.Domain.Album;
using SpotifyLite.Domain.Album.Repository;

namespace SpotifyLite.Test.Application
{
    public class BandaServiceTests
    {
        [Fact]
        public async Task CriarBanda()
        {
           
            Guid guid = Guid.NewGuid();
            BandaInputDto dtoInput = new("teste", "http://site.com/foto.png", "teste");
            BandaOutputDto dtoOutput = new(guid, "teste", "https://xpto.com/foto.png", "teste");
            Mock<IBandaRepository> mockRepository = new();
            Mock<IMapper> mockMapper = new();
            Banda banda = new()
            {
                Descricao = "teste",
                Foto = "http://site.com/foto.png",
                Nome = "teste"
            };
            mockMapper.Setup(x => x.Map<Banda>(dtoInput)).Returns(banda);
            mockMapper.Setup(x => x.Map<BandaOutputDto>(banda)).Returns(dtoOutput);
            mockRepository.Setup(x => x.Save(It.IsAny<Banda>())).Returns(Task.FromResult(banda));

            
            var service = new BandaService(mockRepository.Object, mockMapper.Object);
            var result = await service.Criar(dtoInput);

            
            Assert.NotNull(result);
            
        }

        [Fact]
        public async Task ObterUmaBanda()
        {
            
            Guid guid = new();
            BandaInputDto dtoInput = new("teste", "http://site.com/foto.png", "teste");
            BandaOutputDto dtoOutput = new(guid, "teste", "http://site.com/foto.png", "teste");
            Mock<IBandaRepository> mockRepository = new();
            Mock<IMapper> mockMapper = new();
            Banda banda = new()
            {
                Descricao = "teste",
                Foto = "http://site.com/foto.png",
                Nome = "teste"
            };
            mockMapper.Setup(x => x.Map<Banda>(dtoInput)).Returns(banda);
            mockMapper.Setup(x => x.Map<BandaOutputDto>(banda)).Returns(dtoOutput);
            mockRepository.Setup(x => x.Get(It.IsAny<Guid>())).Returns(Task.FromResult(banda));

            
            var service = new BandaService(mockRepository.Object, mockMapper.Object);
            var result = await service.ObterUm(guid);

            
            Assert.NotNull(result);
            
        }
    }
}
