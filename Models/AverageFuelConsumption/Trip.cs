using System.ComponentModel.DataAnnotations;

namespace calcmaster_webapp.Models.AverageFuelConsumption
{
    public class Trip
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O título da viagem deve ser informado")]
        [MinLength(3, ErrorMessage = "Deve conter mais de 3 caracteres")]
        public string Title { get; set; }

        [Required(ErrorMessage = "A distância percorrida deve ser informada")]
        [Range(0.1, 999999999999, ErrorMessage = "A distância percorrida deve ser superior a 0KM (zero quilômetros)")]
        public double Kilometers { get; init; }

        [Required(ErrorMessage = "A quantidade de combustível abastecido deve ser informada")]
        [Range(0.1, 999999999999, ErrorMessage = "A quantidade de combustível abastecido deve ser superior a 0L (zero litros)")]
        public double LitersFilled { get; init; }

        public double AverageFuelConsumption { get; set; }
    }
}