using AutoMapper;
using FillmeApiPratica.Data.Dtos;
using FillmeApiPratica.Model;

namespace FillmeApiPratica.Profile;

public class FilmeProfile : AutoMapper.Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, ReadFilmeDto>();
        CreateMap<Cinema, ReadCinemaDto>().ForMember(filmeDto => filmeDto.Endereco, opt => opt.MapFrom(filmeDto => filmeDto.Endereco));
    }
}
