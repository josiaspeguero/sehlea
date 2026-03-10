using System.Text.Json.Serialization;

namespace Sehlea.Api.Domain.Entities
{
    public class EstudioMedico
    {
        public int Id { get; set; }
        public TipoEstudio Tipo { get; set; }
        public string? Observaciones { get; set; }
        public DateTime FechaEstudio { get; set; }
        public DateTime FechaPubicacion { get; set; }
        public bool IsPublished { get; set; } = false;

        //propiedades de navegacion
        //paciente
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; } = null!; //un estudio pertenece a un paciente

        //doctor
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } = null!; //un estudio es realizado por un doctor

        //resultados
        [JsonIgnore]
        public List<ResultadoEstudio> ResultadosEstudios { get; set; } = new(); //un estudio tiene varios resultados

    }
}
