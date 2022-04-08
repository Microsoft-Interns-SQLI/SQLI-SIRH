using API_MySIRH.DTOs;
using API_MySIRH.Interfaces;
using AutoMapper;

namespace API_MySIRH.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly IDashboardRepository _repository;
        private readonly IMapper _mapper;

        public DashboardService(IDashboardRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<DashboardDto> getDashboard()
        {
            return _mapper.Map<DashboardDto>(await _repository.getDashboard());
        }
    }
}
