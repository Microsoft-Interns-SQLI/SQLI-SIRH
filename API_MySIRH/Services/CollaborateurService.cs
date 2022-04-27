using API_MySIRH.DTOs.Collaborateur;
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
                // I added '.Name' : see if that's good or not ...
                query = query.Where(c => c.Site.Name == filterParams.Site); // todo-review : relation 'Site' may be nullable .. if so, (I think) that may be risky

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
        
        public IEnumerable<CollaborateurDTO> GetCollaborateurs()
        {
            return _mapper.Map<IEnumerable<CollaborateurDTO>>(_collaborateurRepository.GetCollaborateurs());
        }

        public async Task UpdateCollaborateur(int id, CollaborateurInsertDTO collaborateur)
        {
            await this._collaborateurRepository.UpdateCollaborateur(id, this._mapper.Map<Collaborateur>(collaborateur));
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