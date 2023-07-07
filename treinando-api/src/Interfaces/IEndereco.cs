using src.Models.Entities.Dtos.Endereco;

namespace src.Interfaces
{
    public interface IEndereco : IBaseInt<AddEnderecoDto, ReadEnderecoDto>,
    IUpdate<UpdateEnderecoDto, ReadEnderecoDto>

    {

    }
}