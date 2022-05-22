using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using AutoMapper;
using System.Net.Http.Headers;

namespace API_MySIRH.Services
{
    public class ImageService : IImageService
    {
        private readonly IWebHostEnvironment _env;
        private readonly IImageRepository _imageRepository;
        private readonly ICollaborateurRepository _collaborateurRepository;
        private readonly IMapper _mapper;

        public ImageService(IWebHostEnvironment env, IImageRepository imageRepository, ICollaborateurRepository collaborateurRepository, IMapper mapper)
        {
            _env = env;
            _imageRepository = imageRepository;
            _collaborateurRepository = collaborateurRepository;
            _mapper = mapper;
        }
        public async Task<FileStream> GetImage(int id)
        {
            var data = await _imageRepository.GetImage(id);

            if (data != null)
            {
                var folderName = Path.Combine(_env.ContentRootPath, "Upload\\Images");
                var path = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                var fullPath = Path.Combine(path, data.Id + "_" + data.Name);
                return File.OpenRead(fullPath);

            }
            else
            {
                throw new Exception("No picture found!");
            }
        }

        public async Task<ImageDTO> UploadImage(IFormFile image, int id)
        {
            if (await _imageRepository.IsExists(id, image.FileName))
            {
                throw new Exception("This collaborator already had this profile photo name, please try with another!");
            }
            if (!await _collaborateurRepository.CollaborateurExistsById(id))
            {
                // add 
                throw new Exception("Collaborator unfound!");
            }
            
            var folderName = Path.Combine(_env.ContentRootPath, "Upload\\Images");
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

            if (await _imageRepository.IsExistById(id))
            {
                var previousImage = await _imageRepository.GetImage(id);
                var fullPath = Path.Combine(pathToSave, previousImage.Id + "_" + previousImage.Name);
                if (File.Exists(fullPath))
                    File.Delete(fullPath);
            }
            if (image.Length > 0)
            {
                if (image.ContentType.Contains("image"))
                {
                    var fileId = Guid.NewGuid();
                    var fileName = ContentDispositionHeaderValue.Parse(image.ContentDisposition).FileName?.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileId + "_" + fileName);
                                       
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        await image.CopyToAsync(stream);
                    }
                    var imageDTO = new ImageDTO
                    {
                        Id = fileId,
                        URL = fullPath.Substring(fullPath.Length - fileName.Length - fileId.ToString().Length - 1),
                        Name = fileName,
                        CollaborateurId = id
                    };

                    await _imageRepository.UploadImage(_mapper.Map<Image>(imageDTO));
                    return imageDTO;
                }
                else
                {
                    throw new Exception("File type is invalid!");
                }
            }
            else
            {
                throw new Exception("File can't be empty");
            }
        }
    }
}
