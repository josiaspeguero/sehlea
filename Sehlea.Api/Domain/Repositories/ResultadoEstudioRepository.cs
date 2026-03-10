using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;
using Sehlea.Api.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Sehlea.Api.Domain.Repositories
{
    public class ResultadoEstudioRepository : IResultadoEstudioRepository
    {
        private readonly AppDbContext _appDbContext;

        public ResultadoEstudioRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<ResultadoEstudio>> ObtenerResultadosPorEstudioIdAsync(int estudioId)
        {
            return await _appDbContext.ResultadoEstudios
                .Where(r => r.EstudioId == estudioId)
                .ToListAsync();
        }

        public async Task AgregarResultadoEstudioAsync(ResultadoEstudio resultadoEstudio)
        {
            await _appDbContext.AddAsync(resultadoEstudio);
        }

        public Task<ResultadoEstudio?> BuscarResultadoEstudioAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> GuardarResultadoEstudioAsync()
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
