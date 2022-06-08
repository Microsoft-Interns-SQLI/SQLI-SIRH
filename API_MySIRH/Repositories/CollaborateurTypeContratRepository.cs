using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_MySIRH.Data;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Repositories
{
    public class CollaborateurTypeContratRepository : ICollaborateurTypeContratRepository
    {
        private readonly DataContext _context;

        public CollaborateurTypeContratRepository(DataContext context)
        {
            this._context = context;
        }

        public async Task<List<CollaborateurTypeContrat>> GetAllCollabsContrats()
        {
            return await this._context.CollaborateurTypeContrats
            .Include(cc => cc.Collaborateur)
            .Include(cc => cc.TypeContrat)
            .ToListAsync();
        }

        public async Task<List<CollaborateurTypeContrat>> GetAllCollabsContratsByCollab(int idCollaborateur)
        {
            return await this._context.CollaborateurTypeContrats
                .Where(cc => cc.CollaborateurId == idCollaborateur)
                .Include(cc => cc.Collaborateur)
                .Include(cc => cc.TypeContrat)
                .ToListAsync();
        }

        public async Task<CollaborateurTypeContrat?> GetCollabContratById(int idCollabContrat)
        {
            return await this._context.CollaborateurTypeContrats
            .Include(cc => cc.Collaborateur)
            .Include(cc => cc.TypeContrat)
            .FirstOrDefaultAsync(cc => cc.Id == idCollabContrat);
        }

        public async Task<CollaborateurTypeContrat> AddCollabContrat(CollaborateurTypeContrat collaborateurTypeContrat)
        {
            await this._context.CollaborateurTypeContrats.AddAsync(collaborateurTypeContrat);
            await this._context.SaveChangesAsync();

            return await this.GetCollabContratById(collaborateurTypeContrat.Id);
        }

        public async Task UpdateCollabContrat(CollaborateurTypeContrat collaborateurTypeContrat)
        {
            this._context.Entry(collaborateurTypeContrat).State = EntityState.Modified;
            await this._context.SaveChangesAsync();
        }

        public async Task DeleteCollabContrat(int id)
        {
            var toDelete = await this._context.CollaborateurTypeContrats.FindAsync(id);
            if (toDelete is not null)
                this._context.CollaborateurTypeContrats.Remove(toDelete);
            await this._context.SaveChangesAsync();
        }


        public async Task<List<Collaborateur>> GetCollaborateursByContrat(int idContrat)
        {
            return await this._context.CollaborateurTypeContrats.Where(ctp => ctp.TypeContratId == idContrat)
            .Select(s => new Collaborateur
            {
                Id = s.Collaborateur!.Id,
                Nom = s.Collaborateur.Nom,
                Prenom = s.Collaborateur.Prenom
            })
            .ToListAsync();
        }

        public async Task<List<TypeContrat>> GetContratsByCollaborateur(int idCollaborateur)
        {
            return await this._context.CollaborateurTypeContrats.Where(ctp => ctp.CollaborateurId == idCollaborateur)
            .Select(s => new TypeContrat
            {
                Id = s.TypeContrat!.Id,
                Name = s.TypeContrat.Name
            })
            .ToListAsync();
        }

        public async Task<CollaborateurTypeContrat> GetCurrentContrat(int idCollaborateur)
        {
            return await _context.CollaborateurTypeContrats
                .Where(x => x.CollaborateurId == idCollaborateur)
                .Include(x => x.TypeContrat)
                .FirstOrDefaultAsync();

            //Uncomment the block below when the start date is not null in the DB

            //var result = await _context.CollaborateurTypeContrats
            //    .Where(x => x.CollaborateurId == idCollaborateur && x.DateDebut.Value.Year <= DateTime.Now.Year)
            //    .Include(x => x.TypeContrat)
            //    .OrderByDescending(x => x.DateDebut.Value.Year)
            //    .FirstOrDefaultAsync();
            //return result;
        }
    }
}