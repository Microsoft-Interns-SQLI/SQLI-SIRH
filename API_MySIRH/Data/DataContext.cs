using API_MySIRH.Entities;
using API_MySIRH.Entities.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Data
{
    public class DataContext : IdentityDbContext
        <
            User,
            Role,
            int,
            IdentityUserClaim<int>,
            UserRole,
            IdentityUserLogin<int>,
            IdentityRoleClaim<int>,
            IdentityUserToken<int>
        >
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ToDoItem> ToDoItems { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<Memo> Memos { get; set; }
        public DbSet<Niveau> Niveaux { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<TypeContrat> TypeContrats { get; set; }
        public DbSet<Collaborateur> Collaborateurs { get; set; }
        public DbSet<SkillCenter> SkillCenters { get; set; }
        public DbSet<Dashboard> Dashboards { get; set; }
        public DbSet<ModeRecrutement> ModesRecrutements { get; set; }
        public DbSet<Document> Documents { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seeding a  'Admin' and 'Manager' role to AspNetRoles table
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 2, Name = "Admin", NormalizedName = "ADMIN".ToUpper() },
                new Role { Id = 3, Name = "Manager", NormalizedName = "Manager".ToUpper() });


            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<User>();


            //Seeding the User to AspNetUsers table
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1, // primary key
                    Email = "Admin@sqli.com",
                    NormalizedEmail = "ADMIN@SQLI.COM",
                    UserName = "AdminUser",
                    NormalizedUserName = "ADMINUSER",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd")
                }
            );


            //Seeding the relation between our user and role to AspNetUserRoles table
            modelBuilder.Entity<UserRole>().HasData(
                new UserRole
                {
                    RoleId = 2,
                    UserId = 1
                }
            );

            DataInitializer.SeedData().TryGetValue("ModesRecrutement", out Object modesRecrutement);
            modelBuilder.Entity<ModeRecrutement>().HasData(
                (List<ModeRecrutement>)modesRecrutement
            );

            DataInitializer.SeedData().TryGetValue("Sites", out Object sites);
            modelBuilder.Entity<Site>().HasData(
                (List<Site>)sites
            );

            DataInitializer.SeedData().TryGetValue("SkillCenters", out Object skillCenters);
            modelBuilder.Entity<SkillCenter>().HasData(
                (List<SkillCenter>)skillCenters
            );

            DataInitializer.SeedData().TryGetValue("TypesContrat", out Object typesContrat);
            modelBuilder.Entity<TypeContrat>().HasData(
                (List<TypeContrat>)typesContrat
            );

            DataInitializer.SeedData().TryGetValue("Niveaux", out Object niveaux);
            modelBuilder.Entity<Niveau>().HasData(
                (List<Niveau>)niveaux
            );

            DataInitializer.SeedData().TryGetValue("Postes", out Object postes);
            modelBuilder.Entity<Post>().HasData(
                (List<Post>)postes
            );

            //Get init collaborateurs and add it to db
            DataInitializer.SeedData().TryGetValue("Collaborateurs", out Object collaborateurs);
            modelBuilder.Entity<Collaborateur>().HasData(
                 (List<Collaborateur>)collaborateurs
             );

            modelBuilder.Entity<User>()
                .HasMany(u => u.UserRoles)
                .WithOne(ur => ur.User)
                .HasForeignKey(u => u.UserId)
                .IsRequired();

            modelBuilder.Entity<Role>()
                .HasMany(r => r.UserRoles)
                .WithOne(ur => ur.Role)
                .HasForeignKey(r => r.RoleId)
                .IsRequired();
        }

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
                    track.ModificationDate = DateTime.Now;
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

