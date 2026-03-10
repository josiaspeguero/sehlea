using Microsoft.EntityFrameworkCore;
using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;
using Sehlea.Api.Infrastructure.Persistence;

namespace Sehlea.Api.Domain.Repositories
{
    public class EstudioMedicosRepository : IEstudioMedicoRepository
    {
        private readonly AppDbContext _appDbContext;

        public EstudioMedicosRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task AgregarEstudioMedicoAsync(EstudioMedico estudioMedico)
        {
            await _appDbContext.AddAsync(estudioMedico);
        }

        public async Task<EstudioMedico?> BuscarEstudioMedicoAsync(string cedula)
        {
            return await _appDbContext.EstudioMedicos
          .Include(e => e.ResultadosEstudios)
          .FirstOrDefaultAsync(e => e.Paciente.Cedula == cedula);
        }

        public async Task<bool> GuardarEstudioMedicoAsync()
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
