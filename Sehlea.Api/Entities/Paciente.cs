namespace Sehlea.Api.Entities
{
    public class Paciente
    {
        public int Id { get; set; } // Esto se genera automatico en la bd

        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;

        public string? Email { get; set; } //El correo puede ser nulo porque no todos los pacientes tienen uno

        public string Telefono { get; set; } = string.Empty;

        public string Direccion { get; set; } = string.Empty;

        public string Cedula { get; set; } = string.Empty; //En el caso de los niños, se coloca la de los padres

        public DateTime FechaNacimiento { get; set; }

        public string Sexo { get; set; } = string.Empty;

        public string ContactoEmergencia { get; set; } = string.Empty;

        public string TelefonoEmergencia { get; set; } = string.Empty;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
