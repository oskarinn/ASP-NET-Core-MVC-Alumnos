using System;
namespace AlumnosASPNETMVC.Models
{
    public class AlumnoModel
    {
        public AlumnoModel()
        {
            public string RFC { get; set; }
            public string Nombre { get; set; }
            public string ApPaterno { get; set; }
            public string ApMaterno { get; set; }
            public DateTime FechaNac { get; set; }
            public string Genero { get; set; }
            public DateTime FechaIngreso { get; set; }
            public bool Activo { get; set; }
        }
    }
}
