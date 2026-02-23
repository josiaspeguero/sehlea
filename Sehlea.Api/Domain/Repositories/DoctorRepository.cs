using Microsoft.EntityFrameworkCore;
using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;
using Sehlea.Api.Infrastructure.Persistence;

namespace Sehlea.Api.Domain.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly AppDbContext _appDbContext;

        public DoctorRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task AgregarDoctorAsync(Doctor doctor)
        {
            await _appDbContext.AddAsync(doctor);
        }

        public async Task<Doctor?> BuscarDoctorAsync(string dni)
        {
            return await _appDbContext.Doctores.FirstOrDefaultAsync(d => d.Cedula == dni);
        }

        public async Task<bool> GuardarDoctorAsync()
        {
            var res = await _appDbContext.SaveChangesAsync();
            if (res <= 0)
            {
                return false;
            }
            return true;
        }

        public async Task<IEnumerable<Doctor>> MostrarDoctoresAsync()
        {
            return await _appDbContext.Doctores.ToListAsync();
        }
    }
}
