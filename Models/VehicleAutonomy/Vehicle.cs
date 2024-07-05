
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace calcmaster_webapp.Models.VehicleAutonomy
{
    public class Vehicle
    {
        [Required(AllowEmptyStrings=false, ErrorMessage = "A especificação do veículo é obrigatória")]
        [MinLength(3, ErrorMessage = $"A especificação dever ser maior que 3 caracteres")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings=false, ErrorMessage = "O tamanho do tanque deve ser informado")]
        [Range(1, 999, ErrorMessage = "O tamanho do tanque deve ser maior que 1L (um litro)")]
        public double FuelTankSize { get; set; }

        [Required(AllowEmptyStrings=false, ErrorMessage = "O consumo médio deve ser informado")]
        [Range(1, 99999, ErrorMessage = "O consumo médio deve ser superior a 1 KM/L")]
        public double AverageFuelConsumption { get; set; }

        [BindNever]
        public double Kilometers { get; set; }
    }
}