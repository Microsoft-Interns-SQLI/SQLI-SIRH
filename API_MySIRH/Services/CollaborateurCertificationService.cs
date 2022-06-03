using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Helpers;
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

        public async Task Add(CollaborateurCertificationDTO collaborateurCertification)
        {
            await _collaborateurCertificationRepository.Add(_mapper.Map<CollaborateurCertification>(collaborateurCertification));
        }

        public async Task Delete(CollaborateurCertificationDTO collaborateurCertification)
        {
            await _collaborateurCertificationRepository.Delete(_mapper.Map<CollaborateurCertification>(collaborateurCertification));
        }

        public async Task<CollaborateurCertificationResponse> GetAll(FilterParamsForCertifAndFormation filter)
        {
            var list = await _collaborateurCertificationRepository.GetAll();

            list = FiltrerTable(filter, list);

            var cfDto = _mapper.Map<List<CollaborateurCertificationDTO>>(list);

            return cfDto.GroupBy(x => x.DateDebut.Value.Year).Select(grp => new CollaborateurCertificationResponse { Annee = grp.Key, List = grp.ToList() }).FirstOrDefault();
        }
        public async Task<List<int>> GetAnnees()
        {
            return  await _collaborateurCertificationRepository.GetAnnees();
        }
        public async Task<List<int>> GetAnneesByCollaborateur(int id)
        {
            return await _collaborateurCertificationRepository.GetAnneesByCollaborateur(id);
        }
        public Task<List<CollaborateurCertificationDTO>> GetByCertification(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CollaborateurCertificationResponse> GetByCollaborateur(int id, FilterParamsForCertifAndFormation filter)
        {
            var list = FiltrerTable(filter, await _collaborateurCertificationRepository.GetByCollaborateur(id));

            var cfDTO = _mapper.Map<List<CollaborateurCertificationDTO>>(list);

            return cfDTO.GroupBy(x => x.DateDebut.Value.Year).Select(g => new CollaborateurCertificationResponse { Annee = g.Key, List = g.ToList() }).FirstOrDefault();
        }

        public async Task<CollaborateurCertificationDTO> GetById(int id)
        {
            return _mapper.Map<CollaborateurCertificationDTO>(await _collaborateurCertificationRepository.GetById(id));
        }

        public async Task<List<CollaborateurCertificationDTO>> GetByCollabAndCertif(int collaborateurId, int certificationId)
        {
            return _mapper.Map<List<CollaborateurCertificationDTO>>(await _collaborateurCertificationRepository.GetByCollabAndCertif(collaborateurId, certificationId));
        }

        public async Task Update(CollaborateurCertificationDTO collaborateurCertification)
        {
            await _collaborateurCertificationRepository.Update(_mapper.Map<CollaborateurCertification>(collaborateurCertification));
        }
        private List<CollaborateurCertification> FiltrerTable(FilterParamsForCertifAndFormation filter, List<CollaborateurCertification> list)
        {
            if (filter.status != null && filter.status != 0)
            {
                list = list.Where(cf => cf.Status == filter.status).ToList();
            }

            if (filter.annee != null && filter.annee.ToString().Length >= 4 && filter.annee != 0)
            {
                list = list.Where(cc => cc.DateDebut.Value.Year == filter.annee).ToList();
            }

            return list;
        }
    }
}
