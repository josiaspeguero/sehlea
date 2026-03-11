using System;

namespace Sehlea.Front.Models
{
    public class ResultadoEstudio
    {
        public int Id { get; set; }
        public CamposEstudioMedico NombreDelCampo { get; set; }
        public decimal ValorEncontrado { get; set; }
        public decimal? RangoValorMinimo { get; set; }
        public decimal? RangoValorMaximo { get; set; }
        public string? Comentario { get; set; }
        public int EstudioId { get; set; }
    }
}
