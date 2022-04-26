using API_MySIRH.DTOs;
using API_MySIRH.DTOs.Collaborateur;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _dashboardService;
        private readonly ICollaborateurService _collaborateurService;

        public DashboardController(IDashboardService dashboardService,ICollaborateurService collaborateurService)
        {
            _dashboardService = dashboardService;
            _collaborateurService = collaborateurService;
        }

        [HttpGet]
        public async Task<ActionResult<DashboardDto>> GetDashboard()
        {
            DashboardDto dashboard = new();
            var collection =  _collaborateurService.GetCollaborateurs().Where(collab => collab.DateSortieSqli > DateTime.Now || collab.DateSortieSqli== null);
            dashboard.HeadCount = HeadCount(collection);
            dashboard.FemaleCount = FemaleCount(collection);
            dashboard.MaleCount = MaleCount(collection);
            return dashboard;
        }

        private int HeadCount(IEnumerable<CollaborateurDTO> collaborateurs)
        {
            return collaborateurs.Count();
        }

        private int FemaleCount(IEnumerable<CollaborateurDTO> collaborateurs)
        {
            return collaborateurs.Where(collab => collab.Civilite.ToUpper().Equals("F"))
                        .Count();
        }

        private int MaleCount(IEnumerable<CollaborateurDTO> collaborateurs)
        {
            return collaborateurs.Where(collab => collab.Civilite.ToUpper().Equals("M"))
                        .Count();
        }

         

    }
}
