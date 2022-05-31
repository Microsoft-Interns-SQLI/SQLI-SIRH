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
            var collection = _collaborateurService.GetCollaborateurs(); // .Where(collab => collab.DateSortieSqli == null || DateTime.Compare((DateTime)collab.DateSortieSqli, DateTime.Now) > 0 );
                                                                        // ikhadem: TODO: getData from related Object 
            dashboard.HeadCount = _dashboardService.GetHeadCount(collection);
            dashboard.FemaleCount = _dashboardService.GetFemaleCount(collection);
            dashboard.MaleCount = _dashboardService.GetMaleCount(collection);
            dashboard.DemissionCount = _dashboardService.GetDemissionCount(_collaborateurService.GetCollaborateurs());
            dashboard.AverageAge = _dashboardService.GetAverageAge(collection);
            dashboard.AverageExp = _dashboardService.GetAverageExp(collection);
            dashboard.ICDCount = _dashboardService.GetHeadCountPerPoste(collection, "Ingénieur Concepteur développeur");
            dashboard.ExpertTechCount = _dashboardService.GetHeadCountPerPoste(collection, "Expert technique");
            dashboard.ChefDeProjetCount = _dashboardService.GetHeadCountPerPoste(collection, "Chef de projet technique");
            dashboard.ManagerCount = _dashboardService.GetHeadCountPerPoste(collection, "Manager");
            dashboard.JuniorCount = _dashboardService.GetHeadCountPerNiveaux(collection, "Junior");
            dashboard.OperationnelCount = _dashboardService.GetHeadCountPerNiveaux(collection, "Opérationnel");
            dashboard.ConfirmeCount = _dashboardService.GetHeadCountPerNiveaux(collection, "Confirmé");
            dashboard.SeniorCount = _dashboardService.GetHeadCountPerNiveaux(collection, "Sénior");
            dashboard.TauxSoustraitant = _dashboardService.GetTauxSoustraitant(collection) * 100;
            dashboard.TauxEncadrement = ((dashboard.ChefDeProjetCount + dashboard.ExpertTechCount + dashboard.ManagerCount)/dashboard.HeadCount)*100;
            return dashboard;
        }

         

    }
}
