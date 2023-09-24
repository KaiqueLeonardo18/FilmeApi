using System.ComponentModel.DataAnnotations;

namespace FillmeApiPratica.Data.Dtos
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "O Campo de nome é obrigatório")]
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
    }
}
