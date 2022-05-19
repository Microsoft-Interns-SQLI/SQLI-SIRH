using API_MySIRH.DTOs;
using API_MySIRH.Helpers;
using API_MySIRH.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Services
{
    public class DemissionService : IDemissionService
    {
        private readonly IDemissionRepository _demissionRepository;
        private readonly ICollaborateurRepository _collaborateurRepository;
        private readonly IMapper _mapper;

        public DemissionService(IDemissionRepository demissionRepository, ICollaborateurRepository collaborateurService, IMapper mapper)
        {
            _demissionRepository = demissionRepository;
            _collaborateurRepository = collaborateurService;
            _mapper = mapper;
        }


        public Task DeleteDemission(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedList<CollaborateurDTO>> GetCollaborateursDemissioned(FilterParams filterParams)
        {
            var query = _collaborateurRepository.GetCollaborateurs().Where(x => x.Demissions.Any()).AsQueryable();

            if (!string.IsNullOrEmpty(filterParams.Site))
                query = query.Where(c => c.Site.Name == filterParams.Site);

            if (!(string.IsNullOrWhiteSpace(filterParams.Search)))
                query = query.Where(c => c.Nom.Contains(filterParams.Search) || c.Prenom.Contains(filterParams.Search));

            query = filterParams.OrderBy switch
            {
                "nom_desc" => query.OrderByDescending(c => c.Nom),
                "prenom_asc" => query.OrderBy(c => c.Prenom),
                "prenom_desc" => query.OrderByDescending(c => c.Prenom),
                "matricule_asc" => query.OrderBy(c => c.Matricule),
                "matricule_desc" => query.OrderByDescending(c => c.Matricule),
                "exp_asc" => query.OrderBy(c => c.DateEntreeSqli),
                "exp_desc" => query.OrderByDescending(c => c.DateEntreeSqli),
                "poste_asc" => query.OrderBy(c => c.Poste.Name),
                "poste_desc" => query.OrderByDescending(c => c.Poste.Name),
                "niveau_asc" => query.OrderBy(c => c.Niveau.Name),
                "niveau_desc" => query.OrderByDescending(c => c.Niveau.Name),
                _ => query.OrderBy(c => c.Nom)
            };
            return await PagedList<CollaborateurDTO>.CreateAsync(query.ProjectTo<CollaborateurDTO>(_mapper.ConfigurationProvider).AsNoTracking(), filterParams.pageNumber, filterParams.pageSize);
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
