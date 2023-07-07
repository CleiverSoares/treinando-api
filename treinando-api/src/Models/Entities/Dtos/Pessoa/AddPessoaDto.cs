using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace src.Models.Entities.Dtos.Pessoa
{
    public class AddPessoaDto
    {
        [Column("nome")]
        [Required(ErrorMessage = "Campo Nome obrigatorio", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        [Column("data_nascimento")]
        [Required(ErrorMessage = "Campo Data Nascimento obrigatorio")]
        public DateTime DataNascimento { get; set; }
    }
}