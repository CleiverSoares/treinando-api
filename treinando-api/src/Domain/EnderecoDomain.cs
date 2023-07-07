using AutoMapper;
using src.Data;
using src.Interfaces;
using src.Models;
using src.Models.Entities.Dtos.Endereco;

namespace src.Domain
{
    public class EnderecoDomain : IEndereco
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public EnderecoDomain(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ReadEnderecoDto Adicionar(AddEnderecoDto dto)
        {
            Endereco endereco = _mapper.Map<Endereco>(dto);
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
            ReadEnderecoDto enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);
            return enderecoDto;
        }
        public ReadEnderecoDto BuscarPorId(int id)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            ReadEnderecoDto enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);
            return enderecoDto;
        }
        public IEnumerable<ReadEnderecoDto> BuscarTodos()
        {
            var lista = _context.Enderecos.ToList();
            IEnumerable<ReadEnderecoDto> readEnderecos = _mapper.Map<List<ReadEnderecoDto>>(lista);
            return readEnderecos;

        }
        public ReadEnderecoDto Editar(int id, UpdateEnderecoDto dto)
        {

            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco != null)
            {
                _mapper.Map(dto, endereco);
                ReadEnderecoDto readPessoaDto = _mapper.Map<ReadEnderecoDto>(endereco);
                _context.SaveChanges();
                return readPessoaDto;
            }
            return null;

        }
        public bool Excluir(int id)
        {
            var endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);

            if (endereco != null)
            {
                _context.Enderecos.Remove(endereco);
                _context.SaveChanges();
                return true;
            }
            return false;

        }
    }
}