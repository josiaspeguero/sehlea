namespace Sehlea.Api.Application.DTOs
{
    public class ResultadoEstudioDTO
    {
        public CamposEstudioMedico NombreDelCampo { get; set; }
        public decimal ValorEncontrado { get; set; }
        public decimal? RangoValorMinimo { get; set; }
        public decimal? RangoValorMaximo { get; set; }
        public string? Comentario { get; set; }
        public int EstudioId { get; set; }
    }
}

