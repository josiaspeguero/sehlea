using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sehlea.Api.Entities.configurations
{
    public class PacienteConf : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            //relacion paciente a doctores
            builder.HasOne(p => p.Doctor)
                .WithMany(d => d.Pacientes)
                .HasForeignKey(p => p.DoctorId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
