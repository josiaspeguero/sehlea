using Microsoft.EntityFrameworkCore;
using Sehlea.Api.Application.DTOs;
using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;
using Sehlea.Api.Infrastructure.Persistence;

namespace Sehlea.Api.Domain.Repositories
{
    public class ConsultaRepository : IConsultasRepository
    {
        private readonly AppDbContext _appDbContext;

        public ConsultaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task AgregarConsultaAsync(Consulta consulta)
        {
            await _appDbContext.AddAsync(consulta);
        }

        public async Task<ConsultaDTO?> BuscarConsultaAsync(int id)
        {
            return await _appDbContext.Consultas.Select(c => new ConsultaDTO
            {
                FechaConsulta = c.FechaConsulta,
                RazonConsulta = c.RazonConsulta,
                Tipo = c.Tipo,
                Observaciones = c.Observaciones,
                DoctorId = c.DoctorId,
                PacienteId = c.PacienteId,
                PrecioConsulta = c.PrecioConsulta
            }).FirstOrDefaultAsync();
        }

        public async Task<List<Consulta>> ObtenerProximasConsultasAsync()
        {
            return await _appDbContext.Consultas
                .Where(c => c.FechaConsulta >= DateTime.Now)
                .OrderBy(c => c.FechaConsulta)
                .ToListAsync();
        }

        public async Task<bool> GuardarConsultaAsync()
        {
            var res = await _appDbContext.SaveChangesAsync();
            if (res <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
