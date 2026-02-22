using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sehlea.Api.Domain.Entities;

namespace Sehlea.Api.Domain.configurations
{
    public class ConsultaConf : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            //relacion consulta a doctor
            builder.HasOne(c => c.Doctor)
                .WithMany(d => d.Consultas)
                .HasForeignKey(c => c.DoctorId)
                .OnDelete(DeleteBehavior.NoAction);

            //relacion consulta a paciente
            builder.HasOne(c => c.Paciente)
                .WithMany(p => p.Consultas)
                .HasForeignKey(c => c.PacienteId)
                .OnDelete(DeleteBehavior.NoAction);

            //configuraciones generales
            builder.Property(c => c.PrecioConsulta).HasColumnType("decimal(18, 2)");
        }
    }
}
