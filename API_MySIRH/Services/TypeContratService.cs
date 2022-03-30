using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using AutoMapper;

namespace API_MySIRH.Services
{
    public class TypeContratService : ITypeContratService
    {

        private readonly ITypeContratRepository _typeContratRepository;
        private readonly IMapper _iMapper;

        public TypeContratService(ITypeContratRepository typeContratRepository, IMapper mapper)
        {
            _typeContratRepository = typeContratRepository;
            _iMapper = mapper;
        }

        public async Task Add(TypeContratDto typeDto)
        {
            await _typeContratRepository.Add(_iMapper.Map<TypeContrat>(typeDto));
        }

        public async Task Delete(int id)
        {
            await _typeContratRepository.Delete(id);
        }

        public async Task<IEnumerable<TypeContratDto>> GetAll()
        {
            var list = await _typeContratRepository.GetAll();
            return _iMapper.Map<IEnumerable<TypeContrat>, IEnumerable<TypeContratDto>>(list);
        }

        public async Task<TypeContratDto> GetById(int id)
        {
            var entity = await _typeContratRepository.GetById(id);
            return _iMapper.Map<TypeContratDto>(entity);
        }

        public async Task Update(int id, TypeContratDto type)
        {
            await _typeContratRepository.Update(id,_iMapper.Map<TypeContrat>(type));
        }
    }
}
