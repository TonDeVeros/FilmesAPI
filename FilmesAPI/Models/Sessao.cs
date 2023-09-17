using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Sessao
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public virtual int FilmeId { get; set; }
        public virtual Filme Filme { get; set; } //colocamos aqui para indicar a relacao

        //O cinema não vai ser required pois já existia uma sessao cadastrada,
        //mas em um cenario do zero ele seria [required]
        public virtual int? CinemaId { get; set; }
        public virtual Cinema Cinema { get; set; }
    }
}
