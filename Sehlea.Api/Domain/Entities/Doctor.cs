namespace Sehlea.Api.Domain.Entities
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

        public bool IsDeleted { get; set; } = false;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        //relaicones / propiedades de navegacion
        //paciente
        public List<Paciente> Pacientes { get; set; } = new(); //un doctor tiene varios pacientes

        //doctor
        public List<Consulta> Consultas { get; set; } = new();  //un doctor tiene varias consultas
                 
        //estudios medicos
        public List<EstudioMedico> EstudiosMedicos { get; set; } = new();  //un doctor tiene varios estudios medicos
    }
}
