using System;
using System.ComponentModel.DataAnnotations;

namespace AlumnosASPNETMVC.Models
{
    public class AlumnoViewModel
    {
        [Required]
        [RegularExpression(@"^([A-ZÑ\x26]{3,4}([0-9]{2})(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])([A-Z]|[0-9]){2}([A]|[0-9]){1})?$", ErrorMessage= "RFC con formato inválido")]
        public string RFC { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Display(Name = "Apellido Paterno")]
        [Required]
        public string ApPaterno { get; set; }
        [Display(Name = "Apellido Materno")]
        [Required]
        public string ApMaterno { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNac { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Ingreso")]
        public DateTime FechaIngreso { get; set; }
        [Required]
        public bool Activo { get; set; }
    }
}
