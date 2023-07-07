
using AutoMapper;
using src.Models;
using src.Models.Entities.Dtos.Pessoa;

namespace src.Profiles
{
    public class PessoaProfile : Profile
    {
        public PessoaProfile()
        {
            CreateMap<AddPessoaDto, Pessoa>();
            CreateMap<Pessoa, ReadPessoaDto>();
            CreateMap<UpdatePessoaDto, Pessoa>();
        }

    }
}