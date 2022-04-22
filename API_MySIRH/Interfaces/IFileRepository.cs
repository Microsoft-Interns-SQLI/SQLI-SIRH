using API_MySIRH.DTOs;
using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface IFileRepository
    {
        Task<Document> Upload(Document file);
    }
}