using AutoMapper;
using Moq;
using SpofityLite.Application.Album.Dto;
using SpofityLite.Application.Album.Service;
using SpotifyLite.Domain.Album;
using SpotifyLite.Domain.Album.Repository;
using SpotifyLite.Domain.Album.ValueObject;

namespace SpotifyLite.Test.Application
{
    public class AlbumServiceTests //pegar esse cara aqui
    {
        [Fact]
        public async Task DeveCriarAlbumComSucesso()
        {
            //Arrange
            Guid guid = Guid.NewGuid();
            string Nome = "Teste";
            DateTime Date = DateTime.Now;
            string Backdrop = "TEste";
            string NomeMusica = "Musia";
            int NomeDuracao = 320;
            List<MusicaInputDto> InputMusicas = new() { new MusicaInputDto(NomeMusica, NomeDuracao) };
            List<MusicaOutputDto> OutputMusicas = new() { new MusicaOutputDto(guid, NomeMusica, NomeDuracao.ToString()) };
            AlbumInputDto dtoInput = new(Nome, Date, Backdrop, InputMusicas);
            AlbumOutputDto dtoOutput = new(guid, Nome, Date, Backdrop, OutputMusicas);
            Mock<IAlbumRepository> mockRepository = new();
            Mock<IMapper> mockMapper = new();
            Album album = new()
            {
                Nome = Nome,
                DataLancamento = Date,
                Backdrop = Backdrop,
                Musicas = new List<Musica>() {
                    new Musica()
                    {
                        Nome = NomeMusica,
                        Duracao = new Duracao(400)
                    }
                }
            };
            mockMapper.Setup(x => x.Map<Album>(dtoInput)).Returns(album);
            mockMapper.Setup(x => x.Map<AlbumOutputDto>(album)).Returns(dtoOutput);
            mockRepository.Setup(x => x.Save(It.IsAny<Album>())).Returns(Task.FromResult(album));

            //Act
            var service = new AlbumService(mockRepository.Object, mockMapper.Object);
            var result = await service.Criar(dtoInput);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(guid, result.Id);
            Assert.Equal(Nome, result.Nome);
            Assert.Equal(Date, result.DataLancamento);
            Assert.Equal(Backdrop, result.Backdrop);
            Assert.Equal(guid, result.Musicas[0].Id);
            Assert.Equal(NomeMusica, result.Musicas[0].Nome);
            Assert.Equal(NomeDuracao.ToString(), result.Musicas[0].Duracao);
        }

        [Fact]
        public async Task DeveObterUmAlbumComSucesso()
        {
            //Arrange
            Guid guid = Guid.NewGuid();
            string Nome = "Teste";
            DateTime Date = DateTime.Now;
            string Backdrop = "Teste";
            string NomeMusica = "Musica";
            int NomeDuracao = 280;
            List<MusicaInputDto> InputMusicas = new() { new MusicaInputDto(NomeMusica, NomeDuracao) };
            List<MusicaOutputDto> OutputMusicas = new() { new MusicaOutputDto(guid, NomeMusica, NomeDuracao.ToString()) };
            AlbumInputDto dtoInput = new(Nome, Date, Backdrop, InputMusicas);
            AlbumOutputDto dtoOutput = new(guid, Nome, Date, Backdrop, OutputMusicas);
            Mock<IAlbumRepository> mockRepository = new();
            Mock<IMapper> mockMapper = new();
            Album album = new()
            {
                Nome = Nome,
                DataLancamento = Date,
                Backdrop = Backdrop,
                Musicas = new List<Musica>() {
                    new Musica()
                    {
                        Nome = NomeMusica,
                        Duracao = new Duracao(400)
                    }
                }
            };
            mockMapper.Setup(x => x.Map<Album>(dtoInput)).Returns(album);
            mockMapper.Setup(x => x.Map<AlbumOutputDto>(album)).Returns(dtoOutput);
            mockRepository.Setup(x => x.Get(It.IsAny<Guid>())).Returns(Task.FromResult(album));

            //Act
            var service = new AlbumService(mockRepository.Object, mockMapper.Object);
            var result = await service.ObterUm(guid);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(guid, result.Id);
            Assert.Equal(Nome, result.Nome);
            Assert.Equal(Date, result.DataLancamento);
            Assert.Equal(Backdrop, result.Backdrop);
            Assert.Equal(guid, result.Musicas[0].Id);
            Assert.Equal(NomeMusica, result.Musicas[0].Nome);
            Assert.Equal(NomeDuracao.ToString(), result.Musicas[0].Duracao);




            
        }
    }
}


