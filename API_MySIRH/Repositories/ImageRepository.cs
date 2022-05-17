using API_MySIRH.Data;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly DataContext _context;

        public ImageRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Image> GetImage(int id)
        {
            return await _context.Images.Where(x => x.CollaborateurId == id).FirstOrDefaultAsync();
        }

        public async Task<bool> IsExists(int collaborateurId, string name)
        {
            return await _context.Images.Where(x=>x.CollaborateurId == collaborateurId && x.Name == name).AnyAsync();
        }
        public async Task<bool> IsExistById(int collaborateurId)
        {
            return await _context.Images.Where(x => x.CollaborateurId == collaborateurId).AnyAsync();
        }


        public async Task<Image> UploadImage(Image image)
        {
            if(await IsExistById(image.CollaborateurId))
            {
                _context.Images.Remove(await GetImage(image.CollaborateurId));
                _context.Images.Add(image);
            }
            else
            {
                _context.Images.Add(image);
            }
            await _context.SaveChangesAsync();
            return image;
        }
    }
}
