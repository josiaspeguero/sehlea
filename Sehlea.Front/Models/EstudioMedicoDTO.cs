using System;
using System.Collections.Generic;

namespace Sehlea.Front.Models
{
    public class EstudioMedicoDTO
    {
        public int Id { get; set; }
        public bool ShowDetails { get; set; } = false;
        public TipoEstudio Tipo { get; set; }
        public string? Observaciones { get; set; }
        public DateTime FechaEstudio { get; set; }
        public DateTime FechaPubicacion { get; set; }
        public bool IsPublished { get; set; } = false;
        public int PacienteId { get; set; }
        public int DoctorId { get; set; }
        public List<ResultadoEstudioDTO> ResultadosEstudios { get; set; } = new();
    }
}
