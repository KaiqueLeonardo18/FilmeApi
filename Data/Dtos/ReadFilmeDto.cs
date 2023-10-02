using System.ComponentModel.DataAnnotations;

namespace FillmeApiPratica.Data.Dtos
{
    public class ReadFilmeDto
    {
        public string Nome { get; set; }

        public int Duracao { get; set; }

        public string Genero { get; set; }

        public DateTime horaConsulta { get; set; } = DateTime.Now;
        public ICollection<ReadSessaoDto> Sessoes { get; set; }
    }
}
