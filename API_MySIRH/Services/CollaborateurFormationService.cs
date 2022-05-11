using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Services
{
    public class CollaborateurFormationService : ICollaborateurFormationService
    {
        private readonly ICollaborateurFormationRepository _collaborateurFormationRepository;
        private readonly IMapper _mapper;

        public CollaborateurFormationService(ICollaborateurFormationRepository collaborateurFormationRepository, IMapper mapper)
        {
            _collaborateurFormationRepository = collaborateurFormationRepository;
            _mapper = mapper;
        }

        public Task Add(CollaborateurFormationDTO collaborateurFormation)
        {
            throw new NotImplementedException();
        }

        public Task Delete(CollaborateurFormationDTO collaborateurFormation)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CollaborateurFormationDTO>> GetAll(Status status)
        {
            var list = await _collaborateurFormationRepository.GetAll();

            if (status != null && status != 0)
            {
                list = list.Where(cf => cf.Status == status).ToList();
            }

            return _mapper.Map<List<CollaborateurFormationDTO>>(list);
        }

        public Task<List<CollaborateurFormationDTO>> GetByCollaborateur(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CollaborateurFormationDTO>> GetByFormation(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CollaborateurFormationDTO> GetOne(int collaborateurId, int formationId)
        {
            return _mapper.Map<CollaborateurFormationDTO>(await _collaborateurFormationRepository.GetOne(collaborateurId, formationId));
        }

        public async Task Update(CollaborateurFormationDTO collaborateurFormation)
        {
            await _collaborateurFormationRepository.Update(_mapper.Map<CollaborateurFormation>(collaborateurFormation));
        }
    }
}
