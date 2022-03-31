using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using AutoMapper;

namespace API_MySIRH.Services
{
    public class MdmService<T, TDto> : IMdmService<T, TDto>
    {
        private readonly IMdmRepository<T> _mdmRepository;
        private readonly IMapper _mapper;

        public MdmService(IMdmRepository<T> mdmRepository, IMapper mapper)
        {
            _mdmRepository = mdmRepository;
            _mapper = mapper;
        }

        public async Task<TDto> Add(TDto obj)
        {
            var returnedObj = await _mdmRepository.Add(_mapper.Map<T>(obj));
            return _mapper.Map<TDto>(returnedObj);
        }

        public async Task Delete(int id)
        {
            await _mdmRepository.Delete(id);
        }

        public async Task<IEnumerable<TDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<T>, IEnumerable<TDto>>(await _mdmRepository.GetAll());
        }

        public async Task<TDto> GetById(int id)
        {
            return _mapper.Map<TDto>(await _mdmRepository.GetById(id));
        }

        public async Task Update(int id, TDto objDTO)
        {
            await _mdmRepository.Update(id, _mapper.Map<T>(objDTO));
        }
    }
}