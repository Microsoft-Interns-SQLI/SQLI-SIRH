using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_MySIRH.Migrations
{
    public partial class MigrateDb : Migration
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
                    Files = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { 2, "38eb840c-58b5-48d9-9049-88e528f7f23a", "Admin", "ADMIN" },
                    { 3, "8c84529c-dff8-4d8a-8c44-bc646858bc15", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "e67af93c-c258-434f-9fe9-e1d952163c5f", "Admin@sqli.com", false, false, null, "ADMIN@SQLI.COM", "ADMINUSER", "AQAAAAEAACcQAAAAEGZRMgJZU7IfSpIRSGc3y1VEochUe1FVDCrOuLriqrli0NHzBiBRDTFfYKSaHOh0gg==", null, false, null, false, "AdminUser" });

            migrationBuilder.InsertData(
                table: "Collaborateurs",
                columns: new[] { "Id", "Adresse", "AutreTechnos", "Certifications", "Civilite", "CreationDate", "DateDebutStage", "DateEntreeSqli", "DateNaissance", "DatePremiereExperience", "DateSortieSqli", "Diplomes", "Email", "EmailPersonnel", "Files", "HadAlreadyWorkedAtSQLI", "Langues", "LieuNaissance", "Matricule", "ModeRecrutement", "ModificationDate", "Nationnalite", "Niveau", "Nom", "Note", "NumCin", "PhonePersonnel", "PhoneProfesionnel", "Poste", "Prenom", "Site", "SituationFamiliale", "SkillCenter", "TypeContrat" },
                values: new object[,]
                {
                    { 1, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2011, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "abaazzi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "30783", "Autre", new DateTime(2022, 4, 11, 11, 40, 43, 625, DateTimeKind.Local).AddTicks(9568), "Marocaine", "Sénior", "BAAZZI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Abdellah", "Rabat", "Célibataire", "Skill Microsoft", "Freelance" },
                    { 2, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2009:Ingénieur d'état en génie informatique", "aeljai@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "30517", "Autre", new DateTime(2022, 4, 11, 11, 40, 43, 625, DateTimeKind.Local).AddTicks(9855), "Marocaine", "Confirmé", "Afaf", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Chef de projet technique", "El", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 3, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2007, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2010:Ingénieur d'Etat", "ynaimi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "30595", "Autre", new DateTime(2022, 4, 11, 11, 40, 43, 625, DateTimeKind.Local).AddTicks(9900), "Marocaine", "Junior", "Naimi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Manager", "Youssef", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 4, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2012, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2012:Matser spécialisé en  Informatique|2010:Mastère en informatique|2010:Licence en physique informatique", "mlasmak@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "30903", "Autre", new DateTime(2022, 4, 11, 11, 40, 43, 625, DateTimeKind.Local).AddTicks(9931), "Marocaine", "Confirmé", "LASMAK", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Marouane", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 5, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2008, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:Diplôme d’ingénierie |2006:Diplôme universitaire de technologie", "mmajid@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "30376", "Autre", new DateTime(2022, 4, 11, 11, 40, 43, 625, DateTimeKind.Local).AddTicks(9960), "Marocaine", "Confirmé", "MAJID", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Mostafa", "Rabat", "Célibataire", "Skill Microsoft", "Freelance" },
                    { 6, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2007, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2004:MIAGE|2006:Master MBDS", "nbennai@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "30238", "Autre", new DateTime(2022, 4, 11, 11, 40, 43, 625, DateTimeKind.Local).AddTicks(9990), "Marocaine", "Confirmé", "BENNAI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Naoufal", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 7, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2013, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2014:MIAGE", "yazzi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "30984", "Autre", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(16), "Marocaine", "Confirmé", "AZZI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Younesse", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 8, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2010:Ingenieur", "schouki@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "30622", "Autre", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(46), "Marocaine", "Junior", "Siham", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Chef de projet technique", "Chouki", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 9, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2013:Master Ingénierie Informatique", "mboufaddi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "30963", "Autre", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(76), "Marocaine", "Sénior", "Mahmoud", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Boufaddi", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 10, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2013, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2012:Master spécialisé |2005:Maîtrise Sciences et Techniques (MST)", "okarouite@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31012", "Autre", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(107), "Marocaine", "Opérationnel", "KAROUITE", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Ouadii", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 11, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2015:technicien spécialisé en développement m", "adidiomarelalaoui@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31281", "Spontané", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(162), "Marocaine", "Sénior", "DIDI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "OMAR", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 12, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2015:Diplôme d’ingénieur option MIAGE", "halaouiismaili@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31317", "Autre", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(193), "Marocaine", "Sénior", "ALAOUI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "ISMAILI", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 13, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2016:Ingénieur informatique|2012:Diplôme Universitaire de Technologie", "helhamdaoui@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31334", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(226), "Marocaine", "Confirmé", "EL", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "HAMDAOUI", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 14, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2012:Ingénieur d'état|2009:Licence en génie informatique", "massayah@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31361", "Autre", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(257), "Marocaine", "Sénior", "ASSAYAH", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Mimoun", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 15, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "abouhafer@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31377", "Autre", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(285), "Marocaine", "Sénior", "BOUHAFER", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Anass", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 16, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "aelbouhafsi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31375", "Autre", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(315), "Marocaine", "Sénior", "EL", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "BOUHAFSI", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 17, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "ymaaiden@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31447", "Autre", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(342), "Marocaine", "Sénior", "MAAIDEN", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Yassine", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 18, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "zboukhris@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31436", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(374), "Marocaine", "Sénior", "BOUKHRIS", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Zakaria", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 19, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "iouazzi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31478", "Recommandation", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(401), "Marocaine", "Sénior", "OUAZZI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Ilyas", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 20, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "mbrahimi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31479", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(434), "Marocaine", "Opérationnel", "BRAHIMI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Mouad", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 21, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "maelakkel@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31553", "E-Chalenge", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(482), "Marocaine", "Sénior", "EL", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "AKKEL", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 22, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2015:Ingénierie des systèmes d’informatique|2017:Ingénierie des systèmes d’informations", "aeoubaid@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31452", "E-Chalenge", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(509), "Marocaine", "Opérationnel", "OUBAID", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Abd", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 23, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "iechenafi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31394", "E-Chalenge", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(536), "Marocaine", "Confirmé", "Echenafi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Imane", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 24, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "alahlou@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31916", "Stage PFE", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(564), "Marocaine", "Opérationnel", "Aadil", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "LAHLOU", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 25, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2018, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "mtouiyek@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31683", "E-Chalenge", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(594), "Marocaine", "Opérationnel", "TOUIYEK", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Mehdi", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 26, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2018, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "naelhachimi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31687", "E-Chalenge", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(626), "Marocaine", "Opérationnel", "EL", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "HACHIMI", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 27, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "mkouakou@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(653), "Marocaine", "Junior", "Kouakou", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Miguel", "Rabat", "Célibataire", "Skill Microsoft", "Freelance" },
                    { 28, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "atoumi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31824", "E-Chalenge", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(686), "Marocaine", "Opérationnel", "TOUMI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Achraf", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 29, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "aaitelhad@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31835", "E-Chalenge", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(714), "Marocaine", "Opérationnel", "AIT", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "EL", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 30, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "nalboufarissi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31838", "E-Chalenge", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(742), "Marocaine", "Opérationnel", "ALBOUFARISSI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Nidal", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 31, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "nnaji@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31840", "E-Chalenge", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(793), "Marocaine", "Opérationnel", "NAJI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Naji", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 32, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "folahmidi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31933", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(819), "Marocaine", "Opérationnel", "Lahmidi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Fouad", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 33, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "atayebi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31939", "Cooptation", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(846), "Marocaine", "Sénior", "TAYEBI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Aziz", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 34, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "fsosseyalaoui@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31954", "Stage PFE", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(877), "Marocaine", "Opérationnel", "SOSSEY", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "ALAOUI", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 35, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2013:M2: Nouvelles technologies|2013:Ingénieur en informatique et réseau", "melhilali@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31293", "Cooptation", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(904), "Marocaine", "Confirmé", "EL", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Chef de projet technique", "HILALI", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 36, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:Technicien Spécialisé en Développement|2017:Licence Universitaire Professionnelle|2014:Baccalauréat Science Physique|2020:Master Universitaire Professionnelle", "schafik@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31970", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(931), "Marocaine", "Opérationnel", "CHAFIK", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Soufiane", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 37, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "fzhamdi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32027", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(957), "Marocaine", "Junior", "Hamdi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Fatima", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 38, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "beberaich@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32000", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(989), "Marocaine", "Junior", "Beraich", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Badre", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 39, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "emlagzouli@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32083", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1016), "Marocaine", "Junior", "Lagzouli", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "El", "Rabat", "Célibataire", "Skill Microsoft", "CDI" }
                });

            migrationBuilder.InsertData(
                table: "Collaborateurs",
                columns: new[] { "Id", "Adresse", "AutreTechnos", "Certifications", "Civilite", "CreationDate", "DateDebutStage", "DateEntreeSqli", "DateNaissance", "DatePremiereExperience", "DateSortieSqli", "Diplomes", "Email", "EmailPersonnel", "Files", "HadAlreadyWorkedAtSQLI", "Langues", "LieuNaissance", "Matricule", "ModeRecrutement", "ModificationDate", "Nationnalite", "Niveau", "Nom", "Note", "NumCin", "PhonePersonnel", "PhoneProfesionnel", "Poste", "Prenom", "Site", "SituationFamiliale", "SkillCenter", "TypeContrat" },
                values: new object[,]
                {
                    { 40, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:GÉNIE LOGICIEL|2019:LOGICIEL ET SYSTÈME INFORMATIQUE", "yelkaddouri@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32080", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1062), "Marocaine", "Junior", "El", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Kaddouri", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 41, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "fzmaadane@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32021", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1089), "Marocaine", "Junior", "Maadane", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Fatima", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 42, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "aelidrissijallal@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32062", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1116), "Marocaine", "Junior", "Adam", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "El", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 43, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "ndroussi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1146), "Marocaine", "Confirmé", "Droussi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Nabil", "Rabat", "Célibataire", "Skill Microsoft", "Freelance" },
                    { 44, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "nhaouari@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1175), "Marocaine", "Junior", "Haouari", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Nadir", "Rabat", "Célibataire", "Skill Microsoft", "Freelance" },
                    { 45, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "llaghoui@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1204), "Marocaine", "Confirmé", "Laghoui", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Lhoucine", "Rabat", "Célibataire", "Skill Microsoft", "Freelance" },
                    { 46, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "azouitni@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1233), "Marocaine", "Confirmé", "Zouitni", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Abdelkrim", "Rabat", "Célibataire", "Skill Microsoft", "Freelance" },
                    { 47, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2009:Ingénierie Concepteur de Systèmes d’info|2004:BTS- Génie Informatique|2001:Baccalauréat", "aelyasni@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32134", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1266), "Marocaine", "Sénior", "EL", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "YASNI", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 48, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "mbounzaha@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1292), "Marocaine", "Junior", "Bounzaha", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Mohamed", "Rabat", "Célibataire", "Skill Microsoft", "Freelance" },
                    { 49, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "cchemmam@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32227", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1318), "Marocaine", "Junior", "Chaimaa", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Chemmam", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 50, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "melboujbaoui@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32209", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1343), "Marocaine", "Junior", "Mounib", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "El", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 51, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2018:T. S. en développement Informatique", "ahammeni@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32214", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1391), "Marocaine", "Junior", "Alaa", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Hammeni", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 52, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "yelmousaoui@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32194", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1416), "Marocaine", "Junior", "Yassine", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Elmousaoui", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 53, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "MROUDANI@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32248", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1446), "Marocaine", "Junior", "Mohamed", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Roudani", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 54, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "MSIFANE@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32247", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1473), "Marocaine", "Junior", "Mouad", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Sifane", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 55, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "MZIDANI@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32245", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1503), "Marocaine", "Junior", "Mohamed", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Zidani", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 56, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "hfarraji@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32187", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1527), "Marocaine", "Junior", "Hicham", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Farraji", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 57, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "ahjelti@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32188", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1555), "Marocaine", "Junior", "Ahlam", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Jelti", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 58, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "momaghnouj@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32189", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1583), "Marocaine", "Junior", "Mohamed", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Maghnouj", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 59, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "kmehdaoui@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32190", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1612), "Marocaine", "Junior", "Kaoutar", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Mehdaoui", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 60, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "adbib@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32239", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1640), "Marocaine", "Junior", "Abdellah", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Dbib", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 61, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "amotmani@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1684), "Marocaine", "Junior", "Otmani", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Amine", "Rabat", "Célibataire", "Skill Microsoft", "Freelance" },
                    { 62, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "lettout@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32287", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1710), "Marocaine", "Sénior", "Lahcen", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Ettout", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 63, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "selalami@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32300", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1735), "Marocaine", "Sénior", "Salim", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "El", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 64, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "mouelmrabet@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32304", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1762), "Marocaine", "Confirmé", "Mourad", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "El", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 65, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "zlahmidi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32315", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1787), "Marocaine", "Sénior", "Zakaria", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Lahmidi", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 66, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "onfaoui@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32325", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1813), "Marocaine", "Opérationnel", "Oussama", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Nfaoui", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 67, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "oassanouni@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32334", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1838), "Marocaine", "Junior", "Omar", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Assanouni", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 68, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "kbenchamekh@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32339", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1863), "Marocaine", "Sénior", "Benchamekh", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Khalil", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 69, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2021:MASTER - 2ASI", "zmiloudi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32337", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1888), "Marocaine", "Junior", "Miloudi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Zakaria", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 70, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "mbouharrada@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32352", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1912), "Marocaine", "Opérationnel", "Bouharrada", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Mohammed", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 71, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "hkhazrouni@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1967), "Marocaine", "Junior", "Khazrouni", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Hassan", "Rabat", "Célibataire", "Skill Microsoft", "Freelance" },
                    { 72, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2017:Génie logiciel|2018:Sicences mathématiques et informatique|2021:Ingénierie logiciel", "maaribech@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32360", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(1993), "Marocaine", "Junior", "aribech", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "mohamed", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 73, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2018:Diplôme de Technicien Spécialisé|2011:Baccalauréat", "kakhardid@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32358", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(2018), "Marocaine", "Junior", "Akhardid", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Khadija", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 74, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2015:Master STRI", "zazoulay@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32363", "Autre", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(2043), "Marocaine", "Sénior", "Azoulay", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Zakaria", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 75, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "mfliti@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32367", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(2071), "Marocaine", "Junior", "Fliti", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Mouad", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 76, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "bybahi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32366", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(2096), "Marocaine", "Junior", "Bahi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "ben", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 77, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "wberehil@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32370", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(2121), "Marocaine", "Junior", "Berehil", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Walid", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 78, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "knaimi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32377", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(2146), "Marocaine", "Junior", "Naimi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Khalil", "Oujda", "Célibataire", "Skill Microsoft", "CDI" },
                    { 79, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "slourhaoui@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32380", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(2172), "Marocaine", "Opérationnel", "Lourhaoui", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Soukaina", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 80, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "hbenmachi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32392", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(2197), "Marocaine", "Confirmé", "Benmachi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Hamza", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 81, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:Licence en EEA|2019:Ingénieur Automatisme Info Industrielle", "aouahdi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32402", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(2243), "Marocaine", "Confirmé", "Ouahdi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Abdachahid", "Rabat", "Célibataire", "Skill Microsoft", "CDI" }
                });

            migrationBuilder.InsertData(
                table: "Collaborateurs",
                columns: new[] { "Id", "Adresse", "AutreTechnos", "Certifications", "Civilite", "CreationDate", "DateDebutStage", "DateEntreeSqli", "DateNaissance", "DatePremiereExperience", "DateSortieSqli", "Diplomes", "Email", "EmailPersonnel", "Files", "HadAlreadyWorkedAtSQLI", "Langues", "LieuNaissance", "Matricule", "ModeRecrutement", "ModificationDate", "Nationnalite", "Niveau", "Nom", "Note", "NumCin", "PhonePersonnel", "PhoneProfesionnel", "Poste", "Prenom", "Site", "SituationFamiliale", "SkillCenter", "TypeContrat" },
                values: new object[,]
                {
                    { 82, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "zerrafiqi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(2268), "Marocaine", "Junior", "Zakaria", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Errafiqi", "Rabat", "Célibataire", "Skill Microsoft", "Freelance" },
                    { 83, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2016:Ingénieur d’état en génie informatique", "aselhassani@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32463", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(2292), "Marocaine", "Sénior", "Asmae", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "El", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 84, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2017:Diplome d'ingénieur informatique", "adyar@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32524", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(2321), "Marocaine", "Sénior", "Abderrahmane", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Ingénieur Concepteur développeur", "Dyar", "Rabat", "Célibataire", "Skill Microsoft", "CDI" },
                    { 85, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "afourtit@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(2349), "Marocaine", "Junior", "Fourtit", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", "Expert technique", "Abdelaziz", "Rabat", "Célibataire", "Skill Microsoft", "Freelance" }
                });

            migrationBuilder.InsertData(
                table: "Dashboards",
                columns: new[] { "Id", "CreationDate", "ModificationDate", "nbFemale", "nbMale" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 11, 11, 40, 43, 626, DateTimeKind.Local).AddTicks(2509), 13, 72 });

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
