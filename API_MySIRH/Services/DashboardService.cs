using API_MySIRH.DTOs;
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
        private readonly IMdmService<Post,PostDTO> _postService;
        private readonly IMdmService<Niveau, NiveauDTO> _niveauService;

        public DashboardService(IMdmService<Post,PostDTO> postService, IMdmService<Niveau, NiveauDTO> niveauService)
        {
            _postService = postService;
            _niveauService = niveauService;
        }

        public double GetAverageAge(IEnumerable<CollaborateurDTO> collaborateurs)
        {
            return collaborateurs.Average(collaborateur => DateNaissanceCalcule(collaborateur.DateNaissance));                 
        }

        public double GetAverageExp(IEnumerable<CollaborateurDTO> collaborateurs)
        {
            return collaborateurs.Average(collaborateur => ExperienceCalcule((DateTime)collaborateur.DateEntreeSqli));
        }

        public double GetDemissionCount(IEnumerable<CollaborateurDTO> collaborateurs)
        {
            return collaborateurs.Count(); // .Where(collaborateur => collaborateur.DateSortieSqli < DateTime.Now).Count(); // ikhadem: TODO: get data from related object
        }

        public double GetFemaleCount(IEnumerable<CollaborateurDTO> collaborateurs)
        {
            return collaborateurs.Where(collaborateur => collaborateur.Civilite.Equals("F")).Count();
        }

        public double GetHeadCount(IEnumerable<CollaborateurDTO> collaborateurs)
        {
            return collaborateurs.Count();
        }

        public double GetHeadCountPerNiveaux(IEnumerable<CollaborateurDTO> collaborateurs, string niveauName)
        {
            NiveauDTO myNiveau = _niveauService.GetAll().Result.Where(niveau => niveau.Name.Equals(niveauName)).FirstOrDefault();
            if (myNiveau == null) return 0;
            return collaborateurs.Where(collab => collab.NiveauId == myNiveau.Id).ToList().Count();
        }

        public double GetHeadCountPerPoste(IEnumerable<CollaborateurDTO> collaborateurs,string postName)
        {
            PostDTO myPost= _postService.GetAll().Result.Where(post => post.Name.Equals(postName)).FirstOrDefault();
            if (myPost == null) return 0;
            return collaborateurs.Where(collab => collab.PosteId == myPost.Id).ToList().Count();
        }

        public double GetMaleCount(IEnumerable<CollaborateurDTO> collaborateurs)
        {
            return collaborateurs.Where(collaborateur => collaborateur.Civilite.Equals("M")).Count();
        }

        public double GetTauxSoustraitant(IEnumerable<CollaborateurDTO> collaborateurs)
        {
            double freelanceCount = collaborateurs.Where(collaborateur => collaborateur.Matricule.Equals("0")).Count();
            return freelanceCount/GetHeadCount(collaborateurs);
        }

        private int DateNaissanceCalcule(DateTime dateNaissance)
        {
            return (int)((DateTime.Now - dateNaissance).TotalDays / 365);
        }

        private int ExperienceCalcule(DateTime dateEntreeSQli)
        {
            return (int)((DateTime.Now - dateEntreeSQli).TotalDays / 365);
        }

    }
}
