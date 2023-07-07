
using AutoMapper;
using src.Data;
using src.Interfaces;
using src.Models;
using src.Models.Entities.Dtos.Pessoa;

namespace src.Domain
{
    public class PessoaDomain : IPessoa
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public PessoaDomain(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadPessoaDto Adicionar(AddPessoaDto dto)
        {
            Pessoa pessoa = _mapper.Map<Pessoa>(dto);
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
            ReadPessoaDto pessoaDto = _mapper.Map<ReadPessoaDto>(pessoa);
            return pessoaDto;
        }

        public ReadPessoaDto BuscarPorId(int id)
        {
            Pessoa classPessoa = _context.Pessoas.FirstOrDefault(pessoa => pessoa.Id == id);
            ReadPessoaDto pessoaDto = _mapper.Map<ReadPessoaDto>(classPessoa);
            return pessoaDto;
        }


        public IEnumerable<ReadPessoaDto> BuscarTodos()
        {
            var lista = _context.Pessoas.ToList();
            IEnumerable<ReadPessoaDto> readPessoaDto = _mapper.Map<List<ReadPessoaDto>>(lista);
            return readPessoaDto;
        }

        public ReadPessoaDto Editar(int id, UpdatePessoaDto dto)
        {
            Pessoa classPessoa = _context.Pessoas.FirstOrDefault(pessoa => pessoa.Id == id);
            if (classPessoa != null)
            {
                _mapper.Map(dto, classPessoa);
                ReadPessoaDto readPessoaDto = _mapper.Map<ReadPessoaDto>(classPessoa);
                _context.SaveChanges();
                return readPessoaDto;
            }
            return null;
        }

        public bool Excluir(int id)
        {
            var pessoa = _context.Pessoas.FirstOrDefault(pessoa => pessoa.Id == id);

            if (pessoa != null)
            {
                _context.Pessoas.Remove(pessoa);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}