using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sehlea.Api.Domain.Entities;

namespace Sehlea.Api.Domain.configurations
{
    public class EstudiosMedicosConf : IEntityTypeConfiguration<EstudioMedico>
    {
        public void Configure(EntityTypeBuilder<EstudioMedico> builder)
        {
            //paciente
            builder.HasOne(e => e.Paciente)
                .WithMany(p => p.Estudios)
                .HasForeignKey(e => e.PacienteId)
                .OnDelete(DeleteBehavior.NoAction);

            //doctor
            builder.HasOne(e => e.Doctor)
                .WithMany(d => d.EstudiosMedicos)
                .HasForeignKey(e => e.DoctorId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
