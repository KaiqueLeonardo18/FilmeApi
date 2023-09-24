using FillmeApiPratica.Data.Dtos;
using FillmeApiPratica.Model;

namespace FillmeApiPratica.Profile
{
    public class EnderecoProfile : AutoMapper.Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();

        }
    }
}
