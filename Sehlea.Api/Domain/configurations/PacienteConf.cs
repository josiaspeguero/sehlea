using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sehlea.Api.Domain.Entities;

namespace Sehlea.Api.Domain.configurations
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
