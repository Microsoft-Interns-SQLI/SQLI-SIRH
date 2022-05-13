using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_MySIRH.DTOs;

namespace API_MySIRH.Interfaces
{
    public interface IDiplomeService
    {
        Task<DiplomeDTO> AddDiplomeToCollab(DiplomeDTO diplomeDTO);
        Task UpdateCollabDiplome(DiplomeDTO diplomeDTO);
        Task DeleteDiplomeToCollab(int idDiplome);
        Task<bool> Exists(int idDiplome);

        Task<List<DiplomeDTO>> GetAllDiplomes();
        Task<List<DiplomeDTO>> GetCollabDiplomes(int idCollab);
        Task<DiplomeDTO?> GetDiplome(int idDiplome);
    }
}