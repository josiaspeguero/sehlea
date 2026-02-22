namespace Sehlea.Api.Entities
{
    public class Doctor
    {
        public int Id { get; set; } 
        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;

        public string Cedula { get; set; } = string.Empty;

        public string NumeroLicenciaMedica { get; set; } = string.Empty;

        public string Especialidad { get; set; } = string.Empty;

        public int AnosExperiencia { get; set; }

        public string Universidad { get; set; } = string.Empty;

        public DateTime FechaContratacion { get; set; }

        public string ConsultorioAsignado { get; set; } = string.Empty;

        public string HorarioAtencion { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
