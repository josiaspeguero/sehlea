using System;

namespace Sehlea.Front.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public TiposConsulta Tipo { get; set; }
        public DateTime FechaConsulta { get; set; }
        public string RazonConsulta { get; set; } = string.Empty;
        public string? Observaciones { get; set; }
        public decimal PrecioConsulta { get; set; }
        public int PacienteId { get; set; }
        public PacienteDTO? Paciente { get; set; }
        public int DoctorId { get; set; }
    }
}
