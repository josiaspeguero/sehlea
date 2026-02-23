using Sehlea.Api.Domain.Entities;

namespace Sehlea.Api.Application.DTOs
{
    public class PacienteDTO
    {
        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;

        public string? Email { get; set; } //El correo puede ser nulo porque no todos los pacientes tienen uno

        public string Telefono { get; set; } = string.Empty;

        public string Direccion { get; set; } = string.Empty;

        public string Cedula { get; set; } = string.Empty;

        public DateTime FechaNacimiento { get; set; }

        public string Sexo { get; set; } = string.Empty;

        public string ContactoEmergencia { get; set; } = string.Empty;

        public string TelefonoEmergencia { get; set; } = string.Empty;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public int DoctorId { get; set; }
    }
}
