using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using AutoMapper;

namespace API_MySIRH.Services
{
    public class TypeContratService : ITypeContratService
    {

        private readonly ITypeContratRepository _typeContratRepository;
        private readonly IMapper _mapper;

        public TypeContratService(ITypeContratRepository typeContratRepository, IMapper mapper)
        {
            _typeContratRepository = typeContratRepository;
            _mapper = mapper;
        }

        public async Task Add(TypeContratDTO typeDto)
        {
            await _typeContratRepository.Add(_mapper.Map<TypeContrat>(typeDto));
        }

        public async Task Delete(int id)
        {
            await _typeContratRepository.Delete(id);
        }

        public async Task<IEnumerable<TypeContratDTO>> GetAll()
        {
            var list = await _typeContratRepository.GetAll();
            return _mapper.Map<IEnumerable<TypeContrat>, IEnumerable<TypeContratDTO>>(list);
        }

        public async Task<TypeContratDTO> GetById(int id)
        {
            var entity = await _typeContratRepository.GetById(id);
            return _mapper.Map<TypeContratDTO>(entity);
        }

        public async Task Update(int id, TypeContratDTO type)
        {
            await _typeContratRepository.Update(id, _mapper.Map<TypeContrat>(type));
        }
    }
}
