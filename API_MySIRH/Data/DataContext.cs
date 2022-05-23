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
        public DbSet<Diplome> Diplomes { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<CollaborateurTypeContrat> CollaborateurTypeContrats { get; set; }

        public DbSet<Certification> Certifications { get; set; }
        public DbSet<CollaborateurCertification> CollaborateurCertifications { get; set; }
        public DbSet<Formation> Formations { get; set; }
        public DbSet<CollaborateurFormation> CollaborateurFormations { get; set; }
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

            // Collaborateur 1 <---> * CollaborateurFormation * <---> 1 Formation
            modelBuilder.Entity<Collaborateur>()
                .HasMany(c => c.Formations)
                .WithMany(f => f.Collaborateurs)
                .UsingEntity<CollaborateurFormation>
                (
                    j => j
                        .HasOne(cf => cf.Formation)
                        .WithMany(f => f.CollaborateurFormations)
                        .HasForeignKey(cf => cf.FormationId),
                    j => j
                        .HasOne(cf=>cf.Collaborateur)
                        .WithMany(c=>c.CollaborateurFormations)
                        .HasForeignKey(cc=>cc.CollaborateurId)
                );
            modelBuilder.Entity<CollaborateurFormation>()
                .Property(cf=>cf.Status)
                .HasConversion(
                    v => (int)v,
                    v=> (Status)v
                );

            // Collaborateur 1 <---> * CollaborateurCertification * <---> 1 Certification
            modelBuilder.Entity<Collaborateur>()
                .HasMany(c => c.Certifications)
                .WithMany(cf => cf.Collaborateurs)
                .UsingEntity<CollaborateurCertification>
                (
                    j => j
                        .HasOne(cc => cc.Certification)
                        .WithMany(c => c.CollaborateurCertifications)
                        .HasForeignKey(cc => cc.CertificationId),
                    j => j
                        .HasOne(cc => cc.Collaborateur)
                        .WithMany(cf => cf.CollaborateurCertifications)
                        .HasForeignKey(cc => cc.CollaborateurId)
                );
            modelBuilder.Entity<CollaborateurCertification>()
                .Property(cc => cc.Status)
                .HasConversion(
                    v => (int)v,
                    v => (Status)v
                );
        }

        internal Task<bool> AnyAsync()
        {
            throw new NotImplementedException();
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

