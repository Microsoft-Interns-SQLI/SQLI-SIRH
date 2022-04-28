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
            var collection = _collaborateurService.GetCollaborateurs().Where(collab => collab.DateSortieSqli == null || DateTime.Compare((DateTime)collab.DateSortieSqli, DateTime.Now) > 0 );
            dashboard.HeadCount = _dashboardService.GetHeadCount(collection);
            dashboard.FemaleCount = _dashboardService.GetFemaleCount(collection);
            dashboard.MaleCount = _dashboardService.GetMaleCount(collection);
            dashboard.AverageAge = _dashboardService.GetAverageAge(collection);
            dashboard.ICDCount = _dashboardService.GetHeadCountPerPoste(collection, "Ingénieur Concepteur développeur");
            dashboard.ExpertTechCount = _dashboardService.GetHeadCountPerPoste(collection, "Expert technique");
            dashboard.ChefDeProjetCount = _dashboardService.GetHeadCountPerPoste(collection, "Chef de projet technique");
            dashboard.ManagerCount = _dashboardService.GetHeadCountPerPoste(collection, "Manager");
            dashboard.JuniorCount = _dashboardService.GetHeadCountPerNiveaux(collection, "Junior");
            dashboard.OperationnelCount = _dashboardService.GetHeadCountPerNiveaux(collection, "Opérationnel");
            dashboard.ConfirmeCount = _dashboardService.GetHeadCountPerNiveaux(collection, "Confirmé");
            dashboard.SeniorCount = _dashboardService.GetHeadCountPerNiveaux(collection, "Sénior");
            return dashboard;
        }

         

    }
}
