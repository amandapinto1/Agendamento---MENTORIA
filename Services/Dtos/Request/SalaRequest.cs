using System.ComponentModel.DataAnnotations;

namespace Agendamento.Services.Dtos.Request
{
    public class SalaRequest
    {
        [Required(ErrorMessage = "Propriedade obrigatória.")]
        [MaxLength(200, ErrorMessage = "Quantidade de caracteres inválida.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Propriedade obrigatória.")]
        public int QuantidadeDeLugares { get; set; }

        [Required(ErrorMessage = "Propriedade obrigatória.")]
        [Range(1, 15, ErrorMessage = "O andar deve estar entre 1 e 15.")]
        public int Andar { get; set; }
    }
}
