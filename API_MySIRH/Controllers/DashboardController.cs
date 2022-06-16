using API_MySIRH.DTOs;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
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
            // .Where(collab => collab.DateSortieSqli == null || DateTime.Compare((DateTime)collab.DateSortieSqli, DateTime.Now) > 0 );
                                                                        // ikhadem: TODO: getData from related Object 
            dashboard.HeadCount = _dashboardService.GetHeadCount();
            dashboard.FemaleCount = _dashboardService.GetFemaleCount();
            dashboard.MaleCount = _dashboardService.GetMaleCount();
            dashboard.DemissionCount = _dashboardService.GetDemissionCount();
            dashboard.AverageAge = _dashboardService.GetAverageAge();
            dashboard.AverageExp = _dashboardService.GetAverageExp();
            dashboard.ICDCount = _dashboardService.GetHeadCountPerPoste( "Ingénieur Concepteur développeur");
            dashboard.ExpertTechCount = _dashboardService.GetHeadCountPerPoste( "Expert technique");
            dashboard.ChefDeProjetCount = _dashboardService.GetHeadCountPerPoste( "Chef de projet technique");
            dashboard.ManagerCount = _dashboardService.GetHeadCountPerPoste("Manager");
            dashboard.JuniorCount = _dashboardService.GetHeadCountPerNiveaux( "Junior");
            dashboard.OperationnelCount = _dashboardService.GetHeadCountPerNiveaux( "Opérationnel");
            dashboard.ConfirmeCount = _dashboardService.GetHeadCountPerNiveaux( "Confirmé");
            dashboard.SeniorCount = _dashboardService.GetHeadCountPerNiveaux( "Sénior");
            dashboard.TauxSoustraitant = _dashboardService.GetTauxSoustraitant() * 100;
            dashboard.TauxEncadrement = ((dashboard.ChefDeProjetCount + dashboard.ExpertTechCount + dashboard.ManagerCount)/dashboard.HeadCount)*100;
            return Ok(dashboard);
        }

         

    }
}
