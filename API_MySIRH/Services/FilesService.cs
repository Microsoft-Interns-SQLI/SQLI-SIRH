using System.Net.Http.Headers;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Services
{
    public class FilesService : IFilesService
    {
        private readonly IWebHostEnvironment _env;

        public FilesService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public Task<FileResult> Download(string path)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<string>> UploadFile(IFormFileCollection files)
        {
            var folderName = Path.Combine(_env.ContentRootPath, "Upload\\files");
            ICollection<string> Paths = new List<string>();
            foreach (var file in files)
            {
                if (!Directory.Exists(folderName))
                {
                    Directory.CreateDirectory(folderName);
                }
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    Paths.Add(dbPath);

                }
                else
                {
                    throw new Exception("File can't be empty");
                }
            }
            return Paths;
        }
    }
}