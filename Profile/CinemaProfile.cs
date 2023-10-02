using FillmeApiPratica.Data.Dtos;
using FillmeApiPratica.Model;

namespace FillmeApiPratica.Profile
{
    public class CinemaProfile : AutoMapper.Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>().ForMember(cinemaDto => cinemaDto.Endereco, opt => opt.MapFrom(cinema => cinema.Endereco))
                .ForMember(cinemaDto => cinemaDto.Sessoes, opt => opt.MapFrom(cinemaDto => cinemaDto.Sessoes));
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
