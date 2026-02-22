namespace Sehlea.Api.Domain.Entities
{
    public class Consulta
    {
        public int Id { get; set; }

        public TiposConsulta Tipo { get; set; }

        public DateTime FechaConsulta { get; set; }

        public string RazonConsulta { get; set; } = string.Empty; //razon medica

        public string? Observaciones { get; set; }

        public decimal PrecioConsulta { get; set; }

        //propiedades de navegacion
        //paciente
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; } = null!; //una consulta pertenece a un solo paciente

        //doctor
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } = null!; //una consulta pertenece a un solo doctor principal
    }

}
