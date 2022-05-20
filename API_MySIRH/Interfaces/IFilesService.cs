using API_MySIRH.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Interfaces
{
    public interface IFilesService
    {
        Task<ICollection<FileDTO>> UploadFile(IFormFileCollection files, string type, int collabId);
        Task<FileResult> Download(string path);
    }
}