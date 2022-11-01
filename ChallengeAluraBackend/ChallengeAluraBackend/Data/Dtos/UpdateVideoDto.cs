using System.ComponentModel.DataAnnotations;

namespace ChallengeAluraBackend.Data.Dtos
{
    public class UpdateVideoDto
    {
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Url é obrigatório")]
        public string Url { get; set; }
    }
}
