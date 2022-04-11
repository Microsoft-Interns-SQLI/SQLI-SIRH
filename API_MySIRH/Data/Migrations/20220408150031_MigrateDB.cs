using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_MySIRH.Data.Migrations
{
    public partial class MigrateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Collaborateurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Matricule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Civilite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Poste = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillCenter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Site = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Niveau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeContrat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutreTechnos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModeRecrutement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SituationFamiliale = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumCin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationnalite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LieuNaissance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneProfesionnel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhonePersonnel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailPersonnel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Langues = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatePremiereExperience = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateEntreeSqli = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateSortieSqli = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDebutStage = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Diplomes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Certifications = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HadAlreadyWorkedAtSQLI = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collaborateurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dashboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nbFemale = table.Column<int>(type: "int", nullable: false),
                    nbMale = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dashboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Memos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HtmlContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Niveaux",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Niveaux", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillCenters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillCenters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToDoLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ordre = table.Column<int>(type: "int", nullable: false),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeContrats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeContrats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ToDoItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ordre = table.Column<int>(type: "int", nullable: false),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statut = table.Column<bool>(type: "bit", nullable: false),
                    ToDoListId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ToDoItems_ToDoLists_ToDoListId",
                        column: x => x.ToDoListId,
                        principalTable: "ToDoLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 2, "b4abf734-30a7-4de4-a63f-b8b4b3f3e5da", "Admin", "ADMIN" },
                    { 3, "0493c23b-d37c-4976-a90a-2b34657a2741", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "33cea607-6b54-450e-aee3-ffa9745fd114", "Admin@sqli.com", false, false, null, "ADMIN@SQLI.COM", "ADMINUSER", "AQAAAAEAACcQAAAAEICtWMXCOj1gpW3LDuwLMZxOvCbVNi+oxag2Xo518cJXWtqYIcA5vNbHC6nW5l1rWQ==", null, false, null, false, "AdminUser" });

            migrationBuilder.InsertData(
                table: "Collaborateurs",
                columns: new[] { "Id", "Adresse", "AutreTechnos", "Certifications", "Civilite", "CreationDate", "DateDebutStage", "DateEntreeSqli", "DateNaissance", "DatePremiereExperience", "DateSortieSqli", "Diplomes", "Email", "EmailPersonnel", "HadAlreadyWorkedAtSQLI", "Langues", "LieuNaissance", "Matricule", "ModeRecrutement", "ModificationDate", "Nationnalite", "Niveau", "Nom", "Note", "NumCin", "PhonePersonnel", "PhoneProfesionnel", "Poste", "Prenom", "Site", "SituationFamiliale", "SkillCenter", "TypeContrat" },
                values: new object[,]
                {
                    { 1, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2011, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "abaazzi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "30783", "Autre", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(7881), "Marocaine", "Sénior", "BAAZZI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Abdellah", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 2, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2009:Ingénieur d'état en génie informatique", "aeljai@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "30517", "Autre", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8256), "Marocaine", "Sénior", "Afaf", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "El", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 3, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2007, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2010:Ingénieur d'Etat", "ynaimi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "30595", "Autre", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8302), "Marocaine", "Sénior", "Naimi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Youssef", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 4, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2012, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2012:Matser spécialisé en  Informatique|2010:Mastère en informatique|2010:Licence en physique informatique", "mlasmak@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "30903", "Autre", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8363), "Marocaine", "Sénior", "LASMAK", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Marouane", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 5, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2008, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:Diplôme d’ingénierie |2006:Diplôme universitaire de technologie", "mmajid@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "30376", "Autre", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8391), "Marocaine", "Sénior", "MAJID", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Mostafa", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 6, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2007, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2004:MIAGE|2006:Master MBDS", "nbennai@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "30238", "Autre", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8417), "Marocaine", "Sénior", "BENNAI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Naoufal", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 7, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2013, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2014:MIAGE", "yazzi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "30984", "Autre", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8446), "Marocaine", "Sénior", "AZZI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Younesse", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 8, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2010:Ingenieur", "schouki@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "30622", "Autre", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8466), "Marocaine", "Sénior", "Siham", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Chouki", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 9, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2013:Master Ingénierie Informatique", "mboufaddi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "30963", "Autre", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8492), "Marocaine", "Sénior", "Mahmoud", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Boufaddi", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 10, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2013, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2012:Master spécialisé |2005:Maîtrise Sciences et Techniques (MST)", "okarouite@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31012", "Autre", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8519), "Marocaine", "Sénior", "KAROUITE", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Ouadii", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 11, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2015:technicien spécialisé en développement m", "adidiomarelalaoui@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31281", "Spontané", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8543), "Marocaine", "Sénior", "DIDI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "OMAR", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 12, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2015:Diplôme d’ingénieur option MIAGE", "halaouiismaili@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31317", "Autre", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8569), "Marocaine", "Sénior", "ALAOUI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "ISMAILI", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 13, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2016:Ingénieur informatique|2012:Diplôme Universitaire de Technologie", "helhamdaoui@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31334", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8593), "Marocaine", "Sénior", "EL", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "HAMDAOUI", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 14, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2012:Ingénieur d'état|2009:Licence en génie informatique", "massayah@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31361", "Autre", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8639), "Marocaine", "Sénior", "ASSAYAH", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Mimoun", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 15, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "abouhafer@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31377", "Autre", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8659), "Marocaine", "Sénior", "BOUHAFER", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Anass", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 16, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "aelbouhafsi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31375", "Autre", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8683), "Marocaine", "Sénior", "EL", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "BOUHAFSI", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 17, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "ymaaiden@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31447", "Autre", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8708), "Marocaine", "Sénior", "MAAIDEN", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Yassine", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 18, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "zboukhris@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31436", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8730), "Marocaine", "Sénior", "BOUKHRIS", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Zakaria", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 19, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "iouazzi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31478", "Recommandation", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8757), "Marocaine", "Sénior", "OUAZZI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Ilyas", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 20, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "mbrahimi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31479", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8791), "Marocaine", "Sénior", "BRAHIMI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Mouad", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 21, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "maelakkel@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31553", "E-Chalenge", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8819), "Marocaine", "Sénior", "EL", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "AKKEL", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 22, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2015:Ingénierie des systèmes d’informatique|2017:Ingénierie des systèmes d’informations", "aeoubaid@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31452", "E-Chalenge", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8842), "Marocaine", "Sénior", "OUBAID", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Abd", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 23, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "iechenafi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31394", "E-Chalenge", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8868), "Marocaine", "Sénior", "Echenafi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Imane", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 24, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "alahlou@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31916", "Stage PFE", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8916), "Marocaine", "Sénior", "Aadil", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "LAHLOU", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 25, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2018, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "mtouiyek@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31683", "E-Chalenge", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8941), "Marocaine", "Sénior", "TOUIYEK", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Mehdi", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 26, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2018, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "naelhachimi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31687", "E-Chalenge", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8960), "Marocaine", "Sénior", "EL", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "HACHIMI", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 27, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "mkouakou@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8983), "Marocaine", "Sénior", "Kouakou", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Miguel", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 28, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "atoumi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31824", "E-Chalenge", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9010), "Marocaine", "Sénior", "TOUMI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Achraf", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 29, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "aaitelhad@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31835", "E-Chalenge", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9037), "Marocaine", "Sénior", "AIT", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "EL", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 30, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "nalboufarissi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31838", "E-Chalenge", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9060), "Marocaine", "Sénior", "ALBOUFARISSI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Nidal", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 31, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "nnaji@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31840", "E-Chalenge", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9089), "Marocaine", "Sénior", "NAJI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Naji", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 32, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "folahmidi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31933", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9111), "Marocaine", "Sénior", "Lahmidi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Fouad", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 33, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "atayebi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31939", "Cooptation", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9134), "Marocaine", "Sénior", "TAYEBI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Aziz", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 34, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "fsosseyalaoui@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31954", "Stage PFE", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9184), "Marocaine", "Sénior", "SOSSEY", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "ALAOUI", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 35, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2013:M2: Nouvelles technologies|2013:Ingénieur en informatique et réseau", "melhilali@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31293", "Cooptation", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9208), "Marocaine", "Sénior", "EL", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "HILALI", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 36, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:Technicien Spécialisé en Développement|2017:Licence Universitaire Professionnelle|2014:Baccalauréat Science Physique|2020:Master Universitaire Professionnelle", "schafik@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "31970", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9231), "Marocaine", "Sénior", "CHAFIK", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Soufiane", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 37, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "fzhamdi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32027", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9255), "Marocaine", "Sénior", "Hamdi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Fatima", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 38, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "beberaich@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32000", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9282), "Marocaine", "Sénior", "Beraich", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Badre", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 39, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "emlagzouli@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32083", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9308), "Marocaine", "Sénior", "Lagzouli", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "El", "Rabat", "Célibataire", "SQLI Rabat", "CDI" }
                });

            migrationBuilder.InsertData(
                table: "Collaborateurs",
                columns: new[] { "Id", "Adresse", "AutreTechnos", "Certifications", "Civilite", "CreationDate", "DateDebutStage", "DateEntreeSqli", "DateNaissance", "DatePremiereExperience", "DateSortieSqli", "Diplomes", "Email", "EmailPersonnel", "HadAlreadyWorkedAtSQLI", "Langues", "LieuNaissance", "Matricule", "ModeRecrutement", "ModificationDate", "Nationnalite", "Niveau", "Nom", "Note", "NumCin", "PhonePersonnel", "PhoneProfesionnel", "Poste", "Prenom", "Site", "SituationFamiliale", "SkillCenter", "TypeContrat" },
                values: new object[,]
                {
                    { 40, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:GÉNIE LOGICIEL|2019:LOGICIEL ET SYSTÈME INFORMATIQUE", "yelkaddouri@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32080", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9329), "Marocaine", "Sénior", "El", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Kaddouri", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 41, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "fzmaadane@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32021", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9348), "Marocaine", "Sénior", "Maadane", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Fatima", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 42, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "aelidrissijallal@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32062", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9369), "Marocaine", "Sénior", "Adam", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "El", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 43, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "ndroussi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9392), "Marocaine", "Sénior", "Droussi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Nabil", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 44, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "nhaouari@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9441), "Marocaine", "Sénior", "Haouari", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Nadir", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 45, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "llaghoui@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9463), "Marocaine", "Sénior", "Laghoui", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Lhoucine", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 46, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "azouitni@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9484), "Marocaine", "Sénior", "Zouitni", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Abdelkrim", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 47, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2009:Ingénierie Concepteur de Systèmes d’info|2004:BTS- Génie Informatique|2001:Baccalauréat", "aelyasni@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32134", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9507), "Marocaine", "Sénior", "EL", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "YASNI", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 48, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "mbounzaha@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9528), "Marocaine", "Sénior", "Bounzaha", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Mohamed", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 49, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "cchemmam@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32227", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9552), "Marocaine", "Sénior", "Chaimaa", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Chemmam", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 50, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "melboujbaoui@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32209", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9574), "Marocaine", "Sénior", "Mounib", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "El", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 51, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2018:T. S. en développement Informatique", "ahammeni@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32214", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9594), "Marocaine", "Sénior", "Alaa", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Hammeni", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 52, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "yelmousaoui@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32194", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9612), "Marocaine", "Sénior", "Yassine", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Elmousaoui", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 53, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "MROUDANI@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32248", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9635), "Marocaine", "Sénior", "Mohamed", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Roudani", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 54, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "MSIFANE@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32247", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9684), "Marocaine", "Sénior", "Mouad", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Sifane", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 55, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "MZIDANI@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32245", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9703), "Marocaine", "Sénior", "Mohamed", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Zidani", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 56, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "hfarraji@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32187", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9720), "Marocaine", "Sénior", "Hicham", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Farraji", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 57, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "ahjelti@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32188", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9742), "Marocaine", "Sénior", "Ahlam", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Jelti", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 58, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "momaghnouj@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32189", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9764), "Marocaine", "Sénior", "Mohamed", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Maghnouj", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 59, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "kmehdaoui@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32190", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9786), "Marocaine", "Sénior", "Kaoutar", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Mehdaoui", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 60, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "adbib@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32239", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9806), "Marocaine", "Sénior", "Abdellah", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Dbib", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 61, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "amotmani@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9825), "Marocaine", "Sénior", "Otmani", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Amine", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 62, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "lettout@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32287", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9843), "Marocaine", "Sénior", "Lahcen", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Ettout", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 63, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "selalami@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32300", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9861), "Marocaine", "Sénior", "Salim", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "El", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 64, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "mouelmrabet@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32304", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9879), "Marocaine", "Sénior", "Mourad", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "El", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 65, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "zlahmidi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32315", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9919), "Marocaine", "Sénior", "Zakaria", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Lahmidi", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 66, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "onfaoui@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32325", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9938), "Marocaine", "Sénior", "Oussama", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Nfaoui", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 67, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "oassanouni@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32334", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9956), "Marocaine", "Sénior", "Omar", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Assanouni", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 68, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "kbenchamekh@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32339", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9974), "Marocaine", "Sénior", "Benchamekh", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Khalil", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 69, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2021:MASTER - 2ASI", "zmiloudi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32337", "", new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9992), "Marocaine", "Sénior", "Miloudi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Zakaria", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 70, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "mbouharrada@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32352", "", new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(9), "Marocaine", "Sénior", "Bouharrada", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Mohammed", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 71, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "hkhazrouni@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(28), "Marocaine", "Sénior", "Khazrouni", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Hassan", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 72, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2017:Génie logiciel|2018:Sicences mathématiques et informatique|2021:Ingénierie logiciel", "maaribech@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32360", "", new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(46), "Marocaine", "Sénior", "aribech", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "mohamed", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 73, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2018:Diplôme de Technicien Spécialisé|2011:Baccalauréat", "kakhardid@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32358", "", new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(65), "Marocaine", "Sénior", "Akhardid", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Khadija", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 74, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2015:Master STRI", "zazoulay@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32363", "Autre", new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(83), "Marocaine", "Sénior", "Azoulay", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Zakaria", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 75, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "mfliti@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32367", "", new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(127), "Marocaine", "Sénior", "Fliti", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Mouad", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 76, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "bybahi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32366", "", new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(145), "Marocaine", "Sénior", "Bahi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "ben", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 77, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "wberehil@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32370", "", new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(163), "Marocaine", "Sénior", "Berehil", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Walid", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 78, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "knaimi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32377", "", new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(181), "Marocaine", "Sénior", "Naimi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Khalil", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 79, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "slourhaoui@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32380", "", new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(198), "Marocaine", "Sénior", "Lourhaoui", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Soukaina", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 80, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "hbenmachi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32392", "", new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(217), "Marocaine", "Sénior", "Benmachi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Hamza", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 81, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:Licence en EEA|2019:Ingénieur Automatisme Info Industrielle", "aouahdi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32402", "", new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(235), "Marocaine", "Sénior", "Ouahdi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Abdachahid", "Rabat", "Célibataire", "SQLI Rabat", "CDI" }
                });

            migrationBuilder.InsertData(
                table: "Collaborateurs",
                columns: new[] { "Id", "Adresse", "AutreTechnos", "Certifications", "Civilite", "CreationDate", "DateDebutStage", "DateEntreeSqli", "DateNaissance", "DatePremiereExperience", "DateSortieSqli", "Diplomes", "Email", "EmailPersonnel", "HadAlreadyWorkedAtSQLI", "Langues", "LieuNaissance", "Matricule", "ModeRecrutement", "ModificationDate", "Nationnalite", "Niveau", "Nom", "Note", "NumCin", "PhonePersonnel", "PhoneProfesionnel", "Poste", "Prenom", "Site", "SituationFamiliale", "SkillCenter", "TypeContrat" },
                values: new object[,]
                {
                    { 82, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "zerrafiqi@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(254), "Marocaine", "Sénior", "Zakaria", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Errafiqi", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 83, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2016:Ingénieur d’état en génie informatique", "aselhassani@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32463", "", new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(271), "Marocaine", "Sénior", "Asmae", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "El", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 84, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2017:Diplome d'ingénieur informatique", "adyar@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "32524", "", new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(293), "Marocaine", "Sénior", "Abderrahmane", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Dyar", "Rabat", "Célibataire", "SQLI Rabat", "CDI" },
                    { 85, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "afourtit@sqli.com", "email.personnel@gmail.com", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(343), "Marocaine", "Sénior", "Fourtit", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur Développeur", "Abdelaziz", "Rabat", "Célibataire", "SQLI Rabat", "CDI" }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreationDate", "ModificationDate", "nbFemale", "nbMale" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(578), 13, 72 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 2, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ToDoItems_ToDoListId",
                table: "ToDoItems",
                column: "ToDoListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Collaborateurs");

            migrationBuilder.DropTable(
                name: "Dashboards");

            migrationBuilder.DropTable(
                name: "Memos");

            migrationBuilder.DropTable(
                name: "Niveaux");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Sites");

            migrationBuilder.DropTable(
                name: "SkillCenters");

            migrationBuilder.DropTable(
                name: "ToDoItems");

            migrationBuilder.DropTable(
                name: "TypeContrats");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ToDoLists");
        }
    }
}
