using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Interfaces
{
    public interface IFilesService
    {
        Task<ICollection<string>> UploadFile(IFormFileCollection files);
        Task<FileResult> Download(string path);
    }
}