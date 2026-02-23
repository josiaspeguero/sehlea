using AutoMapper;
using Sehlea.Api.Domain.Entities;

namespace Sehlea.Api.Application.DTOs.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<DoctorDTO, Doctor>().ReverseMap();
            CreateMap<PacienteDTO, Paciente>().ReverseMap();
            CreateMap<ConsultaDTO, Consulta>().ReverseMap();
            CreateMap<EstudioMedicoDTO, EstudioMedico>().ReverseMap();
            CreateMap<ResultadoEstudioDTO, ResultadoEstudio>().ReverseMap();
        }
    }
}
