namespace Sehlea.Api.Entities
{
    public class Consulta
    {
        public int Id { get; set; }

        public TiposConsulta Tipo { get; set; }

        public DateTime FechaConsulta { get; set; }

        public string RazonConsulta { get; set; } = string.Empty; //razon medica

        public string? Observaciones { get; set; }

        public decimal PrecioConsulta { get; set; } 

    }
  
}
