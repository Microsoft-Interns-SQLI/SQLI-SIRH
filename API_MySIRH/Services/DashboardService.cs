using API_MySIRH.DTOs;
using API_MySIRH.DTOs.Collaborateur;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_MySIRH.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly IMapper _mapper;
        private readonly ICollaborateurRepository _collaborateurRepository;
        private readonly IMdmService<Post,PostDTO> _postService;
        private readonly IMdmService<Niveau, NiveauDTO> _niveauService;

        public DashboardService(IMdmService<Post,PostDTO> postService, IMapper mapper,ICollaborateurRepository collaborateurRepository, IMdmService<Niveau, NiveauDTO> niveauService)
        {
            _mapper = mapper;
            _postService = postService;
            _niveauService = niveauService;
            _collaborateurRepository = collaborateurRepository;
        }

        public double GetAverageAge(IEnumerable<CollaborateurDTO> collaborateurs)
        {
            return collaborateurs.Average(collaborateur => DateCalcule(collaborateur.DateNaissance));                 
        }
        /*
        public async Task<DashboardDto> getDashboard()
        {
            return _mapper.Map<DashboardDto>(await _repository.getDashboard());
        }
        */
        public double GetFemaleCount(IEnumerable<CollaborateurDTO> collaborateurs)
        {
            return collaborateurs.Where(collaborateur => collaborateur.Civilite.Equals("F")).Count();
        }

        public double GetHeadCount(IEnumerable<CollaborateurDTO> collaborateurs)
        {
            return collaborateurs.Count();
        }

        public int GetHeadCountPerNiveaux(IEnumerable<CollaborateurDTO> collaborateurs, string niveauName)
        {
            NiveauDTO myNiveau = _niveauService.GetAll().Result.Where(niveau => niveau.Name.Equals(niveauName)).FirstOrDefault();
            if (myNiveau == null) return 0;
            return collaborateurs.Where(collab => collab.NiveauId == myNiveau.Id).ToList().Count();
        }

        public int GetHeadCountPerPoste(IEnumerable<CollaborateurDTO> collaborateurs,string postName)
        {
            PostDTO myPost= _postService.GetAll().Result.Where(post => post.Name.Equals(postName)).FirstOrDefault();
            if (myPost == null) return 0;
            return collaborateurs.Where(collab => collab.PosteId == myPost.Id).ToList().Count();
        }

        public double GetMaleCount(IEnumerable<CollaborateurDTO> collaborateurs)
        {
            return collaborateurs.Where(collaborateur => collaborateur.Civilite.Equals("M")).Count();
        }
        
        private int DateCalcule(DateTime dateNaissance)
        {
            return DateTime.Now.Year - dateNaissance.Year;
        }

    }
}
