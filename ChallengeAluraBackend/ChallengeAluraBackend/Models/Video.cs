using System.ComponentModel.DataAnnotations;

namespace ChallengeAluraBackend.Models
{
    public class Video
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Url é obrigatório")]
        public string Url { get; set; }
    }
}
