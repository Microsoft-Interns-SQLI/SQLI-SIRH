using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using API_MySIRH.Repositories;
using AutoMapper;

namespace API_MySIRH.Services
{
    public class CollaborateurTypeContratService : ICollaborateurTypeContratService
    {
        private readonly ICollaborateurTypeContratRepository _collaborateurTypeContratRepository;
        private readonly IMapper _mapper;

        public CollaborateurTypeContratService(ICollaborateurTypeContratRepository collaborateurTypeContratRepository, IMapper mapper)
        {
            this._collaborateurTypeContratRepository = collaborateurTypeContratRepository;
            this._mapper = mapper;
        }

        public async Task<List<CollaborateurTypeContratDTO>?> GetAllCollabsContrats()
        {
            return this._mapper.Map<List<CollaborateurTypeContratDTO>>(await this._collaborateurTypeContratRepository.GetAllCollabsContrats());
        }

        public async Task<List<CollaborateurTypeContratDTO>?> GetAllCollabsContratsByCollab(int idCollaborateur)
        {
            return this._mapper.Map<List<CollaborateurTypeContratDTO>>(await this._collaborateurTypeContratRepository.GetAllCollabsContratsByCollab(idCollaborateur));
        }

        public async Task<CollaborateurTypeContratDTO> GetCollabContratById(int idCollabTypeContrat)
        {
            return this._mapper.Map<CollaborateurTypeContratDTO>(await this._collaborateurTypeContratRepository.GetCollabContratById(idCollabTypeContrat));
        }

        public async Task<CollaborateurTypeContratDTO> AddCollabContrat(CollaborateurTypeContratDTO collaborateurTypeContratDTO)
        {
            var dto = await this._collaborateurTypeContratRepository.AddCollabContrat(this._mapper.Map<CollaborateurTypeContrat>(collaborateurTypeContratDTO));
            return this._mapper.Map<CollaborateurTypeContratDTO>(dto);
        }

        public async Task UpdateCollabContrat(CollaborateurTypeContratDTO collaborateurTypeContratDTO)
        {
            await this._collaborateurTypeContratRepository.UpdateCollabContrat(this._mapper.Map<CollaborateurTypeContrat>(collaborateurTypeContratDTO));
        }

        public async Task DeleteCollabContrat(int idCollabContrat)
        {
            await this._collaborateurTypeContratRepository.DeleteCollabContrat(idCollabContrat);
        }


        public async Task<List<CollaborateurDTO>> GetCollaborateursByContrat(int idContrat)
        {
            return this._mapper.Map<List<CollaborateurDTO>>(await this._collaborateurTypeContratRepository.GetCollaborateursByContrat(idContrat));
        }

        public async Task<List<TypeContratDTO>> GetContratsByCollaborateur(int idCollaborateur)
        {
            return this._mapper.Map<List<TypeContratDTO>>(await this._collaborateurTypeContratRepository.GetContratsByCollaborateur(idCollaborateur));
        }

        public async Task<CollaborateurTypeContratDTO> GetCurrentContrat(int idCollaborateur)
        {
            return _mapper.Map<CollaborateurTypeContratDTO>(await _collaborateurTypeContratRepository.GetCurrentContrat(idCollaborateur));
        }
    }
}