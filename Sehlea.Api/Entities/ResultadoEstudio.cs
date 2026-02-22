namespace Sehlea.Api.Entities
{
    public class ResultadoEstudio
    {
        public int Id { get; set; }
        public CamposEstudioMedico NombreDelCampo { get; set; }
        public decimal ValorEncontrado { get; set; }
        public decimal? RangoValorMinimo { get; set; }
        public decimal? RangoValorMaximo { get; set; }
        public string? Comentario { get; set; }

        //propiedades de navegacion
        public int EstudioId { get; set; }
        public EstudioMedico Estudio { get; set; } = null!; //un resultado pertenece a un solo estudio
    }
}
