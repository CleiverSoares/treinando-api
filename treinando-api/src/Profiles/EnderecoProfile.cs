using AutoMapper;
using src.Models;
using src.Models.Entities.Dtos.Endereco;

namespace src.Profiles
{
    public class EnderecoProfile : Profile
    {

        public EnderecoProfile()
        {
            CreateMap<AddEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();

        }

    }
}