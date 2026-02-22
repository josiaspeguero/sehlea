using Microsoft.EntityFrameworkCore;
using Sehlea.Api.Domain.Entities;
using System.Reflection;

namespace Sehlea.Api.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        //aplicar todas las configuraciones(directorio configurations) a las entidades
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Doctor> Doctores => Set<Doctor>();
        public DbSet<Paciente> Pacientes => Set<Paciente>();
        public DbSet<Consulta> Consultas => Set<Consulta>();
        public DbSet<EstudioMedico> EstudioMedicos => Set<EstudioMedico>();
        public DbSet<ResultadoEstudio> ResultadoEstudios => Set<ResultadoEstudio>();
    }
}
