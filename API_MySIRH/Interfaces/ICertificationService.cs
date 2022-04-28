using API_MySIRH.DTOs;

namespace API_MySIRH.Interfaces
{
    public interface ICertificationService
    {
        Task<List<CertificationDTO>> GetAll();
        Task<CertificationDTO> GetById();
        Task<CertificationDTO> GetByLibelle();
        Task Update(CertificationDTO certification);
        Task Add(CertificationDTO certification);
        Task Delete(CertificationDTO certification);
    }
}
