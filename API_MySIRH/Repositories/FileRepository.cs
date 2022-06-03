using API_MySIRH.Data;
using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;

namespace API_MySIRH.Repositories
{
    public class FileRepository : IFileRepository
    {
        private readonly DataContext _context;

        public FileRepository(DataContext context)
        {
            _context = context;
        }

        public async Task Delete(int id)
        {
            var Doc = await _context.Documents.FindAsync(id);
            try
            {
                // Check if file exists with its full path    
                if (File.Exists(Doc?.URL))
                {
                    // If file found, delete it    
                    File.Delete(Doc.URL);
                }
                if (Doc is not null)
                    _context.Documents.Remove(Doc);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Document> Upload(Document file)
        {
            await _context.Documents.AddAsync(file);
            await _context.SaveChangesAsync();
            return await _context.Documents.FindAsync(file.Id);
        }
    }
}