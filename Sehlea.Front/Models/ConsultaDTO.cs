using System;
using System.Collections.Generic;

namespace Sehlea.Front.Models
{
    public class ConsultaDTO
    {
        public TiposConsulta Tipo { get; set; }
        public DateTime FechaConsulta { get; set; }
        public string RazonConsulta { get; set; } = string.Empty;
        public string? Observaciones { get; set; }
        public decimal PrecioConsulta { get; set; }
        public int PacienteId { get; set; }
        public int DoctorId { get; set; }
    }
}
