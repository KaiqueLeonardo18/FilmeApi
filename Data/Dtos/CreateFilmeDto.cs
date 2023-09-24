using System.ComponentModel.DataAnnotations;

namespace FillmeApiPratica.Data.Dtos
{
    public class CreateFilmeDto
    {

        [Required(ErrorMessage = "O Campo Nome eh obrigatorio")]
        [StringLength(50, ErrorMessage = "O nome do filme nao pode ter mais de 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo Duracao eh obrigatorio")]
        [Range(60, 300, ErrorMessage = "A duracao do filme deve ter no minimo 60 e maximo 300")]
        public int Duracao { get; set; }

        [Required(ErrorMessage = "O Campo Genero eh obrigatorio")]
        [StringLength(30, ErrorMessage = "O Genero nao pode ter mais de 30 caracteres")]
        public string Genero { get; set; }
    }
}
