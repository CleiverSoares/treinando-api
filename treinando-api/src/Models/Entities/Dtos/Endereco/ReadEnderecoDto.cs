using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace src.Models.Entities.Dtos.Endereco
{
    public class ReadEnderecoDto
    {
       [Key]
        [Required]
        [Column("id_endereco")]
        public int Id { get; set; }
        [Column("rua")]
        [Required(ErrorMessage = "Campo Rua obrigatorio", AllowEmptyStrings = false)]
        public string Rua { get; set; }
        [Column("cep")]
        [Required(ErrorMessage = "Campo Cep obrigatorio", AllowEmptyStrings = false)]
        public string Cep { get; set; }
        [Column("bairro")]
        [Required(ErrorMessage = "Campo Bairro obrigatorio", AllowEmptyStrings = false)]
        public string Bairro { get; set; }
        [Column("numero")]
        [Required(ErrorMessage = "Campo Número obrigatorio", AllowEmptyStrings = false)]
        public string Numero { get; set; }
    }
}