using System;
using System.Collections.Generic;

namespace Sehlea.Front.Models
{
    public class EstudioMedico
    {
        public int Id { get; set; }
        public TipoEstudio Tipo { get; set; }
        public string? Observaciones { get; set; }
        public DateTime FechaEstudio { get; set; }
        public DateTime FechaPubicacion { get; set; }
        public bool IsPublished { get; set; }
        public int PacienteId { get; set; }
        public PacienteDTO? Paciente { get; set; }
        public int DoctorId { get; set; }
        // public Doctor? Doctor { get; set; } // Add if needed
        public List<ResultadoEstudio> ResultadosEstudios { get; set; } = new();
    }
}
