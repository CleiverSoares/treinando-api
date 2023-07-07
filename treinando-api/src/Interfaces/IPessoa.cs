
using src.Models.Entities.Dtos.Pessoa;

namespace src.Interfaces
{
    public interface IPessoa : IBaseInt<AddPessoaDto, ReadPessoaDto>, IUpdate<UpdatePessoaDto, ReadPessoaDto>
    {
    }
}