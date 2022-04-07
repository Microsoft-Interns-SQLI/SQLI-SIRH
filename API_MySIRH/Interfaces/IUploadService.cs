using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Interfaces
{
    public interface IUploadService
    {
        Task<ActionResult> UploadFile(IFormFileCollection files);
    }
}