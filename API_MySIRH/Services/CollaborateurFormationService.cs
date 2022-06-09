using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Helpers;
using API_MySIRH.Interfaces;
using AutoMapper;

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

        public async Task<CollaborateurFormationDTO> Add(CollaborateurFormationDTO collaborateurFormation)
        {

            var cf = _mapper.Map<CollaborateurFormationDTO>(await _collaborateurFormationRepository.Add(_mapper.Map<CollaborateurFormation>(collaborateurFormation)));
            return cf;
        }

        public async Task Delete(CollaborateurFormationDTO collaborateurFormation)
        {
            await _collaborateurFormationRepository.Delete(_mapper.Map<CollaborateurFormation>(collaborateurFormation));
        }

        public async Task<CollaborateurFormationResponse> GetAll(FilterParamsForCertifAndFormation filter)
        {
            var list = await _collaborateurFormationRepository.GetAll();

            list = FiltrerTable(filter, list);

            var cfDto = _mapper.Map<List<CollaborateurFormationDTO>>(list);

            return cfDto.GroupBy(x => x.DateDebut.Value.Year).Select(grp => new CollaborateurFormationResponse { Annee = grp.Key, List = grp.ToList() }).FirstOrDefault();
        }
        
        public async Task<List<int>> GetAnnees()
        {
            return await _collaborateurFormationRepository.GetAnnees();

        }
        public async Task<List<int>> GetAnneesByCollaborateur(int id)
        {
            return await _collaborateurFormationRepository.GetAnneesByCollaborateur(id);

        }

        public async Task<List<CollaborateurFormationDTO>> GetByCollabAndFormation(int collabId, int formationId)
        {
            return _mapper.Map<List<CollaborateurFormationDTO>>(await _collaborateurFormationRepository.GetByCollabAndFormation(collabId, formationId));
        }

        public async Task<CollaborateurFormationResponse> GetByCollaborateur(int id, FilterParamsForCertifAndFormation filter)
        {
            var list = FiltrerTable(filter,await _collaborateurFormationRepository.GetByCollaborateur(id));

            var cfDTO = _mapper.Map<List<CollaborateurFormationDTO>>(list);

            return cfDTO.GroupBy(x => x.DateDebut.Value.Year).Select(g => new CollaborateurFormationResponse { Annee = g.Key, List = g.ToList() }).FirstOrDefault();
        }

        public Task<List<CollaborateurFormationDTO>> GetByFormation(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CollaborateurFormationDTO> GetById(int id)
        {
            return _mapper.Map<CollaborateurFormationDTO>(await _collaborateurFormationRepository.GetById(id));
        }

        public async Task<CollaborateurFormationDTO> Update(CollaborateurFormationDTO collaborateurFormation)
        {
            return _mapper.Map<CollaborateurFormationDTO>(await _collaborateurFormationRepository.Update(_mapper.Map<CollaborateurFormation>(collaborateurFormation)));
        }


        private List<CollaborateurFormation> FiltrerTable(FilterParamsForCertifAndFormation filter, List<CollaborateurFormation> list)
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
