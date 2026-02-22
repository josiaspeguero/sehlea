using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sehlea.Api.Domain.Entities;

namespace Sehlea.Api.Domain.configurations
{
    public class ResultadoEstudioConf : IEntityTypeConfiguration<ResultadoEstudio>
    {
        public void Configure(EntityTypeBuilder<ResultadoEstudio> builder)
        {
            //relacion estudios medicos a resultados
            builder.HasOne(r => r.Estudio)
                .WithMany(e => e.ResultadosEstudios)
                .HasForeignKey(r => r.EstudioId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(r => r.ValorEncontrado).HasColumnType("decimal(16, 2)");
            builder.Property(r => r.RangoValorMinimo).HasColumnType("decimal(16, 2)");
            builder.Property(r => r.RangoValorMaximo).HasColumnType("decimal(16, 2)");
        }
    }
}
