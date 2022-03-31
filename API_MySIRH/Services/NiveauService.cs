using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using AutoMapper;

namespace API_MySIRH.Services
{
    public class NiveauService : INiveauService
    {
        private readonly INiveauRepository _niveauRepository;
        private readonly IMapper _mapper;

        public NiveauService(INiveauRepository niveauRepository, IMapper mapper)
        {
            _niveauRepository = niveauRepository;
            _mapper = mapper;
        }

        public async Task<NiveauDTO> AddNiveau(NiveauDTO niveau)
        {
            var returnedNiveau = await _niveauRepository.AddNiveau(_mapper.Map<Niveau>(niveau));
            return _mapper.Map<NiveauDTO>(returnedNiveau);
        }

        public async Task DeleteNiveau(int id)
        {
            await _niveauRepository.DeleteNiveau(id);
        }

        public async Task<NiveauDTO> GetNiveau(int id)
        {
            return _mapper.Map<NiveauDTO>(await _niveauRepository.GetNiveau(id));
        }

        public async Task<IEnumerable<NiveauDTO>> GetNiveaux()
        {
            return _mapper.Map<IEnumerable<Niveau>, IEnumerable<NiveauDTO>>(await _niveauRepository.GetNiveaux());
        }

        public async Task UpdateNiveau(int id, NiveauDTO niveau)
        {
            await _niveauRepository.UpdateNiveau(id, _mapper.Map<Niveau>(niveau));
        }
    }
}