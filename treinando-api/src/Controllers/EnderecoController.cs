
using Microsoft.AspNetCore.Mvc;
using src.Interfaces;
using src.Models.Entities.Dtos.Endereco;

namespace src.Controllers
{

     [ApiController]
    [Route("[Controller]")]
    public class EnderecoController : ControllerBase
    {
           private IEndereco _interfaces;
              public EnderecoController(IEndereco interfaces)
         {
            _interfaces = interfaces;
        }
        [HttpPost]
        public IActionResult Adicionar([FromBody] AddEnderecoDto dto)
        {
            var endereco = _interfaces.Adicionar(dto);
            if (endereco != null)
            {
                return Ok(endereco);
            }
            return BadRequest("Falha ao cadastrar endereco.");
        }
        [HttpGet]
        public IActionResult BuscarTodos()
        {
            var endereco = _interfaces.BuscarTodos();
            if (endereco != null)
            {
                return Ok(endereco);
            }
            return NotFound("enderecos não encontradas");
        }
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            var endereco = _interfaces.BuscarPorId(id);
            if (endereco != null)
            {
                return Ok(endereco);
            }
            return NotFound("endereco com  não encontrada");
        }
        [HttpPut("{id}")]
        public IActionResult Editar(int id, UpdateEnderecoDto dto)
        {
            var endereco = _interfaces.Editar(id, dto);
            if (endereco != null)
            {
                return Ok(endereco);
            }
            return BadRequest("Falha ao editar endereco.");
        }


        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var endereco = _interfaces.Excluir(id);
            if (endereco != true)
            {
                return BadRequest("Falha ao deletar endereco.");
            }
            return Ok("endereco deletada encontrada");
        }



    }
}