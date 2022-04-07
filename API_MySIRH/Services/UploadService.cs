using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Services
{
    public class UploadService : IUploadService
    {
        public Task<ActionResult> UploadFile(IFormFileCollection files)
        {
            throw new NotImplementedException();
        }
    }
}