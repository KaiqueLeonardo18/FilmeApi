using FillmeApiPratica.Data.Dtos;
using FillmeApiPratica.Model;

namespace FillmeApiPratica.Profile
{
    public class CinemaProfile : AutoMapper.Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>();
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
