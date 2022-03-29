using API_MySIRH.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ToDoItem> ToDoItems { get; set; }

        public DbSet<ToDoList> ToDoLists { get; set; }

        public DbSet<Memo> Memos { get; set; }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            
            this.ChangeTracker.DetectChanges();
            var added = this.ChangeTracker.Entries()
                        .Where(t => t.State == EntityState.Added)
                        .Select(t => t.Entity)
                        .ToArray();

            foreach (var entity in added)
            {
                if (entity is EntityBase)
                {
                    var track = entity as EntityBase;
                    track.CreationDate = DateTime.Now;
                    track.ModificationDate= DateTime.Now;
                }
            }

            var modified = this.ChangeTracker.Entries()
                        .Where(t => t.State == EntityState.Modified)
                        .Select(t => t.Entity)
                        .ToArray();

            foreach (var entity in modified)
            {
                if (entity is EntityBase)
                {
                    var track = entity as EntityBase;
                    track.ModificationDate = DateTime.Now;
                }
            }

            // return await base.SaveChangesAsync().ConfigureAwait(false);

            return base.SaveChangesAsync();
        }

    }

}

