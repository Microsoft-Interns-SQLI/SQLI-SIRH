using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Helpers;
using API_MySIRH.Interfaces;
using AutoMapper;

namespace API_MySIRH.Services
{
    public class DemissionService : IDemissionService
    {
        private readonly IDemissionRepository _demissionRepository;
        private readonly IMapper _mapper;

        public DemissionService(IDemissionRepository demissionRepository, IMapper mapper)
        {
            _demissionRepository = demissionRepository;
            _mapper = mapper;
        }

        public async Task<DemissionDTO?> AddDemission(DemissionDTO demission)
        {
            var data = await this._demissionRepository.AddDemission(this._mapper.Map<Demission>(demission));
            return this._mapper.Map<DemissionDTO>(data);
        }

        public async Task DeleteDemission(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<DemissionDTO?> GetDemissionById(int id)
        {
            var data = await this._demissionRepository.GetDemissionByID(id);
            return this._mapper.Map<DemissionDTO>(data);
        }

        public IQueryable<Collaborateur> GetDemissions(FilterParams filterParams)
        {
            var data = _demissionRepository.GetDemissions();
            return data.Where(collab => collab.Demissions.Any() && collab.Demissions.Where(demission => ((DateTime)demission.DateSortieSqli).Year == filterParams.Year).Count()!=0).AsQueryable();
        }

        public async Task<DemissionDTO?> UpdateDemission(DemissionDTO demission)
        {
            var data = await this._demissionRepository.UpdateDemission(this._mapper.Map<Demission>(demission));
            return this._mapper.Map<DemissionDTO>(data);
        }
    }
}
