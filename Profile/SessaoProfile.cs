using FillmeApiPratica.Data.Dtos;
using FillmeApiPratica.Model;

namespace FillmeApiPratica.Profile
{
    public class SessaoProfile : AutoMapper.Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>();
        }
    }
}
