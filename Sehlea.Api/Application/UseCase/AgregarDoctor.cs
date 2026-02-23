using AutoMapper;
using Sehlea.Api.Application.DTOs;
using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;

namespace Sehlea.Api.Application.UseCase
{
    public class AgregarDoctor
    {
        private readonly IDoctorRepository _doctor;
        private readonly IMapper _mapper;

        public AgregarDoctor(IDoctorRepository doctor, IMapper mapper)
        {
            _doctor = doctor;
            _mapper = mapper;
        }
        public async Task<(bool status, string message)> AgregarDoctorTask(DoctorDTO doctorDTO)
        {

            var doctorExistente = await _doctor.BuscarDoctorAsync(doctorDTO.Cedula);
            if (doctorExistente != null)
            {
                return (false, "Ya existe alguien con ese DNI");
            }

            var nuevoDoctor = _mapper.Map<Doctor>(doctorDTO);
            await _doctor.AgregarDoctorAsync(nuevoDoctor);

            var doctorGuardado = await _doctor.GuardarDoctorAsync();
            if (!doctorGuardado)
            {
                return (false, "Ha ocurrido un error");
            }
            return (true, "Doctor agregado correctamente");
        }
    }
}
