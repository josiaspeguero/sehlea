namespace Sehlea.Api.Entities
{
    public class EstudioMedico
    {
        public int Id { get; set; }
        public TipoEstudio Tipo { get; set; }
        public string? Observaciones { get; set; }
        public DateTime FechaEstudio { get; set; }
        public DateTime FechaPubicacion { get; set; }
        public bool IsPublished { get; set; } = false;
    }
}
