using AutoMapper;
using Sehlea.Api.Application.DTOs;
using Sehlea.Api.Domain.Interfaces;

namespace Sehlea.Api.Application.UseCase
{
    public class BuscarEstudioPorId
    {
        private readonly IEstudioMedicoRepository _repository;
        private readonly IMapper _mapper;

        public BuscarEstudioPorId(IEstudioMedicoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EstudioMedicoDTO?> ExecuteAsync(int id)
        {
            var estudio = await _repository.BuscarEstudioPorIdAsync(id);
            return _mapper.Map<EstudioMedicoDTO>(estudio);
        }
    }
}