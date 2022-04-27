using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using AutoMapper;

namespace API_MySIRH.Services
{
    public class CollaborateurCertificationService : ICollaborateurCertificationService
    {
        private readonly ICollaborateurCertificationRepository _collaborateurCertificationRepository;
        private readonly IMapper _mapper;

        public CollaborateurCertificationService(ICollaborateurCertificationRepository collaborateurCertificationRepository, IMapper mapper)
        {
            _collaborateurCertificationRepository = collaborateurCertificationRepository;
            _mapper = mapper;
        }

        public Task Add(CollaborateurCertificationDTO collaborateurCertification)
        {
            throw new NotImplementedException();
        }

        public Task Delete(CollaborateurCertificationDTO collaborateurCertification)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CollaborateurCertificationDTO>> GetAll()
        {
            var list = await _collaborateurCertificationRepository.GetAll();
            return _mapper.Map<List<CollaborateurCertificationDTO>>(await _collaborateurCertificationRepository.GetAll());
        }

        public Task<List<CollaborateurCertificationDTO>> GetByCertification(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CollaborateurCertificationDTO>> GetByCollaborateur(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CollaborateurCertificationDTO> GetOne(int collaborateurId, int certificationId)
        {
            return _mapper.Map<CollaborateurCertificationDTO>(await _collaborateurCertificationRepository.GetOne(collaborateurId, certificationId));
        }

        public async Task Update(CollaborateurCertificationDTO collaborateurCertification)
        {
            await _collaborateurCertificationRepository.Update(_mapper.Map<CollaborateurCertification>(collaborateurCertification));
        }
    }
}
