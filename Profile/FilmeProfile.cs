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
    }
}
