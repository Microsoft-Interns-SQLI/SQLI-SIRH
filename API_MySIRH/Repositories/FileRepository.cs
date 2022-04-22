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

        public async Task<Document> Upload(Document file)
        {
            _context.Documents.Add(file);
            await _context.SaveChangesAsync();
            return file;
        }
    }
}