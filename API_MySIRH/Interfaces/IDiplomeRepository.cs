using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_MySIRH.Entities;

namespace API_MySIRH.Interfaces
{
    public interface IDiplomeRepository
    {
        Task<Diplome> AddDiplomeToCollab(Diplome diplome);
        Task UpdateCollabDiplome(Diplome diplome);
        Task DeleteDiplomeToCollab(int idDiplome);

        Task<List<Diplome>> GetAllDiplomes();
        Task<Diplome?> GetDiplome(int idDiplome);
    }
}