using System.Net.Http.Headers;
using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Services
{
    public class FilesService : IFilesService
    {
        private readonly IWebHostEnvironment _env;
        private readonly IFileRepository _fileRepository;
        private readonly IMapper _mapper;

        public FilesService(IWebHostEnvironment env, IFileRepository fileRepository, IMapper mapper)
        {
            _env = env;
            _fileRepository = fileRepository;
            _mapper = mapper;
        }

        public Task<FileResult> Download(string path)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<FileDTO>> UploadFile(IFormFileCollection files, int collabId)
        {
            var folderName = Path.Combine(_env.ContentRootPath, "Upload\\files");
            ICollection<FileDTO> Paths = new List<FileDTO>();
            foreach (var file in files)
            {
                if (!Directory.Exists(folderName))
                {
                    Directory.CreateDirectory(folderName);
                }
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName?.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    var fileToAdd = new FileDTO();
                    fileToAdd.URL = dbPath;
                    fileToAdd.FileName = fileName;
                    fileToAdd.CollaborateurId = collabId;
                    await _fileRepository.Upload(_mapper.Map<Document>(fileToAdd));
                    Paths.Add(fileToAdd);

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