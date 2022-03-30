using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using AutoMapper;

namespace API_MySIRH.Services
{
    public class SiteService:ISiteService
    {
        private readonly ISiteRepository _siteRepository;
        private readonly IMapper _mapper;

        public SiteService(ISiteRepository siteRepository, IMapper mapper)
        {
            this._siteRepository = siteRepository;
            this._mapper = mapper;
        }

        public async Task<SiteDTO> AddSite(SiteDTO siteDTO)
        {
            var returnedSite = await _siteRepository.AddSite(_mapper.Map<Site>(siteDTO));
            return _mapper.Map<SiteDTO>(returnedSite);
        }

        public async Task DeleteSite(int id)
        {
            await _siteRepository.DeleteSite(id);
        }

        public async Task<SiteDTO> GetSite(int id)
        {
            var result = await _siteRepository.GetSite(id);
            return _mapper.Map<SiteDTO>(result);
        }

        public async Task<IEnumerable<SiteDTO>> GetSites()
        {
            var result = await _siteRepository.GetSites();
            return _mapper.Map<IEnumerable<Site>, IEnumerable<SiteDTO>>(result);
        }

        public async Task UpdateSite(int id, SiteDTO siteDTO)
        {
            var site = _mapper.Map<Site>(siteDTO);
            await _siteRepository.UpdateSite(id, site);
        }
    }
}
