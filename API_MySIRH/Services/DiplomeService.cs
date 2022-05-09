using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using AutoMapper;

namespace API_MySIRH.Services
{
    public class DiplomeService : IDiplomeService
    {
        private readonly IDiplomeRepository _diplomeRepository;
        private readonly ICollaborateurRepository _collaborateurRepository;
        private readonly IMapper _mapper;
        public DiplomeService(
            IDiplomeRepository diplomeRepository,
            ICollaborateurRepository collaborateurRepository,
            IMapper mapper
        )
        {
            this._diplomeRepository = diplomeRepository;
            this._collaborateurRepository = collaborateurRepository;
            this._mapper = mapper;
        }

        public async Task<List<DiplomeDTO>> GetAllDiplomes()
        {
            return this._mapper.Map<List<DiplomeDTO>>(await this._diplomeRepository.GetAllDiplomes());
        }

        public async Task<DiplomeDTO?> GetDiplome(int idDiplome)
        {
            return this._mapper.Map<DiplomeDTO>(await this._diplomeRepository.GetDiplome(idDiplome));
        }

        public async Task<DiplomeDTO> AddDiplomeToCollab(DiplomeDTO diplomeDTO)
        {
            var collaborateur = await this._diplomeRepository.AddDiplomeToCollab(this._mapper.Map<Diplome>(diplomeDTO));
            return this._mapper.Map<DiplomeDTO>(collaborateur);
        }

        public async Task UpdateCollabDiplome(DiplomeDTO diplomeDTO)
        {
            await this._diplomeRepository.UpdateCollabDiplome(this._mapper.Map<Diplome>(diplomeDTO));
        }

        public async Task DeleteDiplomeToCollab(int idDiplome)
        {
            await this._diplomeRepository.DeleteDiplomeToCollab(idDiplome);
        }
    }
}