
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace src.Models
{
    [Table("pessoa")]
    public class Pessoa
    {
        [Key]
        [Required]
        [Column("id_pessoa")]
        public int Id { get; set; }
        [Column("nome")]
        [Required(ErrorMessage = "Campo Nome obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        [Column("data_nascimento")]
        [Required(ErrorMessage = "Campo Data Nascimento obrigatório")]
        public DateTime DataNascimento { get; set; }
        [Column("endereco")]
        public virtual List<Endereco> Enderecos { get; set; }

    }
}