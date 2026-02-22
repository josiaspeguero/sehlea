using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sehlea.Api.Entities.configurations
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
        }
    }
}
