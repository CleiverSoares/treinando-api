
using Microsoft.AspNetCore.Mvc;
using src.Interfaces;
using src.Models.Entities.Dtos.Pessoa;

namespace src.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class PessoaController : ControllerBase
    {
        private IPessoa _interfaces;
        public PessoaController(IPessoa interfaces)
        {
            _interfaces = interfaces;
        }
        [HttpPost]
        public IActionResult Adicionar([FromBody] AddPessoaDto pessoaDto)
        {
            var pessoa = _interfaces.Adicionar(pessoaDto);
            if (pessoa != null)
            {
                return Ok(pessoa);
            }
            return BadRequest("Falha ao cadastrar pessoa.");
        }
        [HttpGet]
        public IActionResult BuscarTodos()
        {
            var pessoa = _interfaces.BuscarTodos();
            if (pessoa != null)
            {
                return Ok(pessoa);
            }
            return NotFound("Pessoas não encontradas");
        }
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            var pessoa = _interfaces.BuscarPorId(id);
            if (pessoa != null)
            {
                return Ok(pessoa);
            }
            return NotFound("Pessoa com  não encontrada");
        }
        [HttpPut("{id}")]
        public IActionResult Editar(int id, UpdatePessoaDto dto)
        {
            var pessoa = _interfaces.Editar(id, dto);
            if (pessoa != null)
            {
                return Ok(pessoa);
            }
            return BadRequest("Falha ao editar pessoa.");
        }


        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var pessoa = _interfaces.Excluir(id);
            if (pessoa != true)
            {
                return BadRequest("Falha ao deletar pessoa.");
            }
            return Ok("Pessoa deletada encontrada");
        }



    }
}