using AutoMapper;
using SpofityLite.Application.Album.Dto;
using SpotifyLite.Domain.Album;
using SpotifyLite.Domain.Album.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Album.Service
{
    public class BandaService : IBandaService
    {
        private readonly IBandaRepository bandaRepository;
        private readonly IMapper mapper;

        public BandaService(IBandaRepository bandaRepository, IMapper mapper)
        {
            this.bandaRepository = bandaRepository;
            this.mapper = mapper;
        }

        public async Task<BandaOutputDto> Criar(BandaInputDto dto)
        {
            var banda = this.mapper.Map<Banda>(dto);

            await this.bandaRepository.Save(banda);

            return this.mapper.Map<BandaOutputDto>(banda);
        }

        public async Task<List<BandaOutputDto>> ObterTodos()
        {
            var result = await this.bandaRepository.GetAll();

            return this.mapper.Map<List<BandaOutputDto>>(result);
        }

        //ed
        public async Task<BandaOutputDto> ObterUm(Guid id)
        {
            var banda = await this.bandaRepository.Get(id);

            return this.mapper.Map<BandaOutputDto>(banda);
        }

        public async Task<BandaOutputDto> Editar(Guid id, BandaInputDto dto)
        {
            var banda = this.mapper.Map<Banda>(dto);
            banda.Id = id;
            await this.bandaRepository.Update(banda);

            return this.mapper.Map<BandaOutputDto>(banda);
        }

        public async Task Deletar(Guid id)
        {
            var usuario = await this.bandaRepository.Get(id); //pegar esse cara

            await this.bandaRepository.Delete(usuario);

        }
    }
}
