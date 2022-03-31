using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [ApiController]
    [Route("/api/mdm")]
    public class MdmController<T, TDto> : ControllerBase
    {
        protected readonly IMdmService<T, TDto> _mdmService;

        public MdmController(IMdmService<T, TDto> mdmService)
        {
            _mdmService = mdmService;
        }
    }
}