using Microsoft.EntityFrameworkCore;
using Sehlea.Api.Application.DTOs;
using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;
using Sehlea.Api.Infrastructure.Persistence;

namespace Sehlea.Api.Domain.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly AppDbContext _appDbContext;

        public PacienteRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task AgregarPacienteAsync(Paciente paciente)
        {
            await _appDbContext.AddAsync(paciente);
        }

        public async Task<Paciente?> BuscarPacienteAsync(string dni)
        {
            return await _appDbContext.Pacientes.FirstOrDefaultAsync(p => p.Cedula == dni);
        }

        public async Task<bool> GuardarPacienteAsync()
        {
            var res = await _appDbContext.SaveChangesAsync();
            if (res <= 0)
            {
                return false;
            }
            return true;
        }

        public async Task<IEnumerable<PacienteDTO?>> MostrarPacientesAsync()
        {
            var pacientes = await _appDbContext.Pacientes.Select(p => new PacienteDTO
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Email = p.Email,
                Telefono = p.Telefono,
                Direccion = p.Direccion,
                Cedula = p.Cedula,
                FechaNacimiento = p.FechaNacimiento,
                Sexo = p.Sexo,
                ContactoEmergencia = p.ContactoEmergencia,
                TelefonoEmergencia = p.TelefonoEmergencia,
                FechaRegistro = p.FechaRegistro,
                DoctorId = p.DoctorId
            }).ToListAsync();

            return pacientes;
        }
    }
}
