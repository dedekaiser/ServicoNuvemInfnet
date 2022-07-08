using SpofityLite.Application.Usuario.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpofityLite.Application.Usuario.Profile
{
    public class UsuarioProfile :AutoMapper.Profile
    {
        public UsuarioProfile()
        {
            CreateMap<SpotifyLite.Domain.Account.Usuario, UsuarioOutputDto>()
                .ForPath(x => x.Email, f => f.MapFrom(n => n.Email.Valor))
                .ForPath(x => x.Password, f => f.MapFrom(n => n.Password.Valor));

            CreateMap<UsuarioInputDto, SpotifyLite.Domain.Account.Usuario>()
                .ForPath(x => x.Email.Valor, f => f.MapFrom(n => n.Email))
                .ForPath(x => x.Password.Valor, f => f.MapFrom(n => n.Password));
        }
    }
}
