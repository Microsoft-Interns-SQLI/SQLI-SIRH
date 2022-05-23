using API_MySIRH.DTOs;
using API_MySIRH.Interfaces;
using AutoMapper;

namespace API_MySIRH.Services
{
    public class CertificationService : ICertificationService
    {
        private readonly ICertificationRepository _certificationRepository;
        private readonly IMapper _mapper;

        public CertificationService(ICertificationRepository certificationRepository, IMapper mapper)
        {
            _certificationRepository = certificationRepository;
            _mapper = mapper;
        }

        public Task Add(CertificationDTO certification)
        {
            throw new NotImplementedException();
        }

        public Task Delete(CertificationDTO certification)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CertificationDTO>> GetAll()
        {
            return _mapper.Map<List<CertificationDTO>>(await _certificationRepository.GetAll());
        }

        public async Task<CertificationDTO> GetById(int id)
        {
            return _mapper.Map<CertificationDTO>(await _certificationRepository.GetById(id));
        }

        public Task<CertificationDTO> GetByLibelle()
        {
            throw new NotImplementedException();
        }

        public Task Update(CertificationDTO certification)
        {
            throw new NotImplementedException();
        }
    }
}
