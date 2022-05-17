using API_MySIRH.DTOs;
using API_MySIRH.Helpers;
using API_MySIRH.Interfaces;
using AutoMapper;

namespace API_MySIRH.Services
{
    public class DemissionService : IDemissionService
    {
        private readonly IDemissionRepository _demissionRepository;
        private readonly ICollaborateurService _collaborateurService;
        private readonly IMapper _mapper;

        public DemissionService(IDemissionRepository demissionRepository, ICollaborateurService collaborateurService, IMapper mapper)
        {
            _demissionRepository = demissionRepository;
            _collaborateurService = collaborateurService;
            _mapper = mapper;
        }


        public Task DeleteDemission(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CollaborateurDTO> GetCollaborateursDemissioned(FilterParams filterParams)
        {
            var query = _collaborateurService.GetCollaborateurs().AsQueryable();
            return query.AsEnumerable();
        }

        public DemissionDTO GetDemission(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DemissionDTO> GetDemissions()
        {
            throw new NotImplementedException();
        }

        public Task UpdateDemission(DemissionDTO demission)
        {
            throw new NotImplementedException();
        }
    }
}
