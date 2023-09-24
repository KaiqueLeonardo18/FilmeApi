using System.ComponentModel.DataAnnotations;

namespace FillmeApiPratica.Model
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public virtual Cinema Cinema { get; set; }
    }
}
