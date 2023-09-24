using System.ComponentModel.DataAnnotations;

namespace FillmeApiPratica.Data.Dtos
{
    public class ReadEnderecoDto
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
    }
}
