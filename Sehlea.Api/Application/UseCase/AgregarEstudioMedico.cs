using AutoMapper;
using Sehlea.Api.Application.DTOs;
using Sehlea.Api.Domain.Entities;
using Sehlea.Api.Domain.Interfaces;

namespace Sehlea.Api.Application.UseCase
{
    public class AgregarEstudioMedico
    {
        private readonly IEstudioMedicoRepository _estudioMedico;
        private readonly IMapper _mapper;

        public AgregarEstudioMedico(IEstudioMedicoRepository estudioMedico, IMapper mapper)
        {
            _estudioMedico = estudioMedico;
            _mapper = mapper;
        }
        public async Task<(bool status, string message)> AgregarEstudioMedicoTask(EstudioMedicoDTO estudioMedicoDTO)
        {
            var nuevoEstudio = _mapper.Map<EstudioMedico>(estudioMedicoDTO);
            await _estudioMedico.AgregarEstudioMedicoAsync(nuevoEstudio);
            var estudioGuardado = await _estudioMedico.GuardarEstudioMedicoAsync();

            if (!estudioGuardado)
            {
                return (false, "No se pudo guardar el estudio medico");
            }
            return (true, "Estudio creado correctamente");
        }
    }
}
