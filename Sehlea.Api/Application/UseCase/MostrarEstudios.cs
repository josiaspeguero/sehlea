using AutoMapper;
using Sehlea.Api.Application.DTOs;
using Sehlea.Api.Domain.Interfaces;

namespace Sehlea.Api.Application.UseCase
{
    public class MostrarEstudios
    {
        private readonly IEstudioMedicoRepository _repository;
        private readonly IMapper _mapper;

        public MostrarEstudios(IEstudioMedicoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EstudioMedicoDTO>> ExecuteAsync()
        {
            var estudios = await _repository.GetAllEstudiosAsync();
            return _mapper.Map<IEnumerable<EstudioMedicoDTO>>(estudios);
        }
    }
}