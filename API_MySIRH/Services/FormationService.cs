using API_MySIRH.DTOs;
using API_MySIRH.Interfaces;
using AutoMapper;

namespace API_MySIRH.Services
{
    public class FormationService : IFormationService
    {
        private readonly IFormationRepository _formationRepository;
        private readonly IMapper _mapper;

        public FormationService(IFormationRepository formationRepository, IMapper mapper)
        {
            _formationRepository = formationRepository;
            _mapper = mapper;
        }

        public Task Add(FormationDTO formation)
        {
            throw new NotImplementedException();
        }

        public Task Delete(FormationDTO formation)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FormationDTO>> GetAll()
        {
            return  _mapper.Map<List<FormationDTO>>(await _formationRepository.GetAll());
        }

        public async Task<FormationDTO> GetById(int id)
        {
            return _mapper.Map<FormationDTO>(await _formationRepository.GetById(id));
        }

        public Task<FormationDTO> GetByLibelle()
        {
            throw new NotImplementedException();
        }

        public Task Update(FormationDTO formation)
        {
            throw new NotImplementedException();
        }
    }
}
