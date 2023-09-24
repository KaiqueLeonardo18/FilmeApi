using System.ComponentModel.DataAnnotations;

namespace FillmeApiPratica.Model
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "O nome do filme nao pode ter mais de 50 caracteres")]
        public string Nome { get; set; }

        [Required]
        [Range(60,300, ErrorMessage = "A duracao do filme deve ter no minimo 60 e maximo 300")]
        public int Duracao { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "O Genero nao pode ter mais de 30 caracteres")]
        public string Genero { get; set; }
    }
}
