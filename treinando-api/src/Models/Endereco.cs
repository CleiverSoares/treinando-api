using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace src.Models
{
    [Table("endereco")]
    public class Endereco
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

        [JsonIgnore]
          [Column("pessoa_id")]
        public int PessoaId { get; set; }
        [JsonIgnore]
        public virtual Pessoa Pessoa { get; set; }
    }
}