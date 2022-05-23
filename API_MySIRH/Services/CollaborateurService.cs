using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Helpers;
using API_MySIRH.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Services
{
    public class CollaborateurService : ICollaborateurService
    {
        private readonly ICollaborateurRepository _collaborateurRepository;
        private readonly IMapper _mapper;

        public CollaborateurService(ICollaborateurRepository collaborateurRepository, IMapper mapper)
        {
            this._collaborateurRepository = collaborateurRepository;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<int>>    GetIntegrationsYearsRange()
        {
            var res = this._collaborateurRepository.GetCollaborateurs()
                                .Select(c => c.DateEntreeSqli.HasValue ? new DateTime(c.DateEntreeSqli.Value.Year, 1, 1) : new DateTime(1, 1, 1)) /* Work Around Nullable Dates */
                                .Select(c => c.Year)
                                .Distinct();
            return (res);
        }

        public async Task<PagedList<CollaborateurDTO>> GetIntegrations(FilterParams filterParams)
        {
            var query =  this._collaborateurRepository.GetCollaborateurs()
                            .Where(c => c.DateEntreeSqli.Value.Year == filterParams.Year)
                            .AsQueryable();
            if (!string.IsNullOrEmpty(filterParams.Site))
                query = query.Where(c => c.Site.Name == filterParams.Site);

            if (!(string.IsNullOrWhiteSpace(filterParams.Search)))
                query = query.Where(c => c.Nom.Contains(filterParams.Search) || c.Prenom.Contains(filterParams.Search));

            if (!string.IsNullOrWhiteSpace(filterParams.OrderByCertification))
            {
                query = query.OrderByDescending(
                    x => x.Certifications.Where(x => x.Libelle == filterParams.OrderByCertification).Any());
            }
            else if (!string.IsNullOrWhiteSpace(filterParams.OrderByFormation))
            {
                query = query.OrderByDescending(
                    x => x.Formations.Where(x => x.Libelle == filterParams.OrderByFormation).Any());
            }
            else
            {
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
            }
            return await PagedList<CollaborateurDTO>.CreateAsync(query.ProjectTo<CollaborateurDTO>(_mapper.ConfigurationProvider).AsNoTracking(), filterParams.pageNumber, filterParams.pageSize);
        }

        public async Task<CollaborateurDTO> AddCollaborateur(CollaborateurDTO collaborateur)
        {
            var returnedCollaborateur = await this._collaborateurRepository.AddCollaborateur(this._mapper.Map<Collaborateur>(collaborateur));
            return this._mapper.Map<CollaborateurDTO>(returnedCollaborateur);
        }

        public async Task DeleteCollaborateur(int id)
        {
            await this._collaborateurRepository.DeleteCollaborateur(id);
        }

        public async Task<CollaborateurDTO> GetCollaborateurById(int id)
        {
            return this._mapper.Map<CollaborateurDTO>(await this._collaborateurRepository.GetCollaborateurById(id));
        }

        public async Task<CollaborateurDTO> GetCollaborateurByMatricule(string matricule)
        {
            return this._mapper.Map<CollaborateurDTO>(await this._collaborateurRepository.GetCollaborateurByMatricule(matricule));
        }

        public async Task<CollaborateurDTO> GetCollaborateurByEmail(string email)
        {
            return this._mapper.Map<CollaborateurDTO>(await this._collaborateurRepository.GetCollaborateurByEmail(email));
        }

        public async Task<PagedList<CollaborateurDTO>> GetCollaborateurs(FilterParams filterParams)
        {
            var query = this._collaborateurRepository.GetCollaborateurs().AsQueryable();

            if (!string.IsNullOrEmpty(filterParams.Site))
                query = query.Where(c => c.Site.Name == filterParams.Site);

            if (!(string.IsNullOrWhiteSpace(filterParams.Search)))
                query = query.Where(c => c.Nom.Contains(filterParams.Search) || c.Prenom.Contains(filterParams.Search));

            if (!string.IsNullOrWhiteSpace(filterParams.OrderByCertification))
            {
                query = query.OrderByDescending(
                    x => x.Certifications.Where(x => x.Libelle == filterParams.OrderByCertification).Any());
            }
            else if (!string.IsNullOrWhiteSpace(filterParams.OrderByFormation))
            {
                query = query.OrderByDescending(
                    x => x.Formations.Where(x => x.Libelle == filterParams.OrderByFormation).Any());
            }
            else
            {
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
            }
            return await PagedList<CollaborateurDTO>.CreateAsync(query.ProjectTo<CollaborateurDTO>(_mapper.ConfigurationProvider).AsNoTracking(), filterParams.pageNumber, filterParams.pageSize);
        }

        public async Task<PagedList<CollaborateurDTO>> GetDemissions(FilterParams filterParams)
        {
            var query = this._collaborateurRepository.GetCollaborateurs().Where(x => x.Demissions.Any()).AsQueryable();

            if (!string.IsNullOrEmpty(filterParams.Site))
                query = query.Where(c => c.Site.Name == filterParams.Site);

            if (!(string.IsNullOrWhiteSpace(filterParams.Search)))
                query = query.Where(c => c.Nom.Contains(filterParams.Search) || c.Prenom.Contains(filterParams.Search));

            if (!string.IsNullOrWhiteSpace(filterParams.OrderByCertification))
            {
                query = query.OrderByDescending(
                    x => x.Certifications.Where(x => x.Libelle == filterParams.OrderByCertification).Any());
            }
            else if (!string.IsNullOrWhiteSpace(filterParams.OrderByFormation))
            {
                query = query.OrderByDescending(
                    x => x.Formations.Where(x => x.Libelle == filterParams.OrderByFormation).Any());
            }
            else
            {
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
            }
            return await PagedList<CollaborateurDTO>.CreateAsync(query.ProjectTo<CollaborateurDTO>(_mapper.ConfigurationProvider).AsNoTracking(), filterParams.pageNumber, filterParams.pageSize);
        }

        public IEnumerable<CollaborateurDTO> GetCollaborateurs()
        {
            var list = _collaborateurRepository.GetCollaborateurs().ProjectTo<CollaborateurDTO>(_mapper.ConfigurationProvider).AsNoTracking();
            return list;
        }

        public async Task UpdateCollaborateur(CollaborateurDTO collaborateur)
        {
            await this._collaborateurRepository.UpdateCollaborateur(this._mapper.Map<Collaborateur>(collaborateur));
        }

        public Task<bool> CollaborateurExistsById(int id)
        {
            return _collaborateurRepository.CollaborateurExistsById(id);
        }

        public Task<bool> CollaborateurExistsByMatricule(string matricule)
        {
            return _collaborateurRepository.CollaborateurExistsByMatricule(matricule);
        }

        public Task<bool> CollaborateurExistsByEmail(string email)
        {
            return _collaborateurRepository.CollaborateurExistsByEmail(email);
        }


    }
}