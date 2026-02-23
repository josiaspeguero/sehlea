using Sehlea.Api.Domain.Entities;

namespace Sehlea.Api.Application.DTOs
{
    public class EstudioMedicoDTO
    {
        public TipoEstudio Tipo { get; set; }
        public string? Observaciones { get; set; }
        public DateTime FechaEstudio { get; set; }
        public DateTime FechaPubicacion { get; set; }
        public bool IsPublished { get; set; } = false;

        public int PacienteId { get; set; }
        public int DoctorId { get; set; }

    }
}
