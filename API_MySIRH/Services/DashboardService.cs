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
        private readonly IMdmService<Post, PostDTO> _postService;
        private readonly IMdmService<Niveau, NiveauDTO> _niveauService;
        private readonly ICollaborateurRepository _collaborateurRepository;
        private readonly IDemissionRepository _demissionRepository;

        public DashboardService(IMdmService<Post, PostDTO> postService, IMdmService<Niveau, NiveauDTO> niveauService,ICollaborateurRepository collaborateurRepository, IDemissionRepository demissionRepository)
        {
            _postService = postService;
            _niveauService = niveauService;
            _collaborateurRepository = collaborateurRepository;
            _demissionRepository = demissionRepository;
        }


        public double GetAverageAge()
        {
            double ageSum = 0;
            foreach(Collaborateur collaborateur in _collaborateurRepository.GetCollaborateurs())
            {
                ageSum += DateNaissanceCalcule(collaborateur.DateNaissance);
            }
            return ageSum/(double)_collaborateurRepository.GetCollaborateurs().Count();
        }

        public double GetAverageExp()
        {
            double ageSum = 0;
            foreach (Collaborateur collaborateur in _collaborateurRepository.GetCollaborateurs())
            {
                ageSum += ExperienceCalcule((DateTime)collaborateur.DateEntreeSqli);
            }
            return ageSum /(double) _collaborateurRepository.GetCollaborateurs().Count();
        }

        public double GetDemissionCount()
        {
            /*  return (from i in _demissionRepository.GetDemissions()
                      where i.Demissions.Count() > 0 && ((DateTime)i.Demissions.OrderByDescending(x => x.DateSortieSqli).First().DateSortieSqli).Year == DateTime.Now.Year
                      select i).Count();*/
           return _demissionRepository.GetDemissions().Where(dem => dem.DateSortieSqli != null && DateTime.Now.Year == ((DateTime)dem.DateSortieSqli).Year).Count();

        }

        public double GetFemaleCount()
        {
            return _collaborateurRepository.GetCollaborateurs().Where(collaborateur => collaborateur.Civilite.Equals("F")).Count();
        }

        public double GetHeadCount()
        {
            return _collaborateurRepository.GetCollaborateurs().Count()- _demissionRepository.GetDemissions().Count(); ;
        }

        public double GetHeadCountPerNiveaux(string niveauName)
        {
            NiveauDTO myNiveau = _niveauService.GetAll().Result.Where(niveau => niveau.Name.Equals(niveauName)).FirstOrDefault();
            if (myNiveau == null) return 0;
            return _collaborateurRepository.GetCollaborateurs().Where(collab => collab.Carrieres.Any() && collab.Carrieres.OrderByDescending(carr => carr.Annee).First().NiveauId == myNiveau.Id).ToList().Count();
        }

        public double GetHeadCountPerPoste(string postName)
        {
            PostDTO myPost = _postService.GetAll().Result.Where(post => post.Name.Equals(postName)).FirstOrDefault();
            if (myPost == null) return 0;
            return _collaborateurRepository.GetCollaborateurs().Where(collab => collab.Carrieres.Any() && collab.Carrieres.OrderByDescending(carr => carr.Annee).First().PosteId == myPost.Id).ToList().Count;
        }

        public double GetMaleCount()
        {
            return _collaborateurRepository.GetCollaborateurs().Where(collaborateur => collaborateur.Civilite.Equals("M")).Count();
        }

        public double GetTauxSoustraitant()
        {
            double freelanceCount = _collaborateurRepository.GetCollaborateurs().Where(collaborateur => collaborateur.Matricule.Equals("0")).Count();
            return freelanceCount / GetHeadCount();
        }

        private double DateNaissanceCalcule(DateTime dateNaissance)
        {
            return ((DateTime.Now - dateNaissance).TotalDays / 365);
        }

        private double ExperienceCalcule(DateTime dateEntreeSQli)
        {
            return ((DateTime.Now - dateEntreeSQli).TotalDays / 365);
        }

    }
}
