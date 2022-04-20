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
                name: "ModesRecrutements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModesRecrutements", x => x.Id);
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
                    Site = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    SkillCenterId = table.Column<int>(type: "int", nullable: true),
                    TypeContratId = table.Column<int>(type: "int", nullable: true),
                    PosteId = table.Column<int>(type: "int", nullable: true),
                    NiveauId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collaborateurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Collaborateurs_Niveaux_NiveauId",
                        column: x => x.NiveauId,
                        principalTable: "Niveaux",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Collaborateurs_Posts_PosteId",
                        column: x => x.PosteId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Collaborateurs_SkillCenters_SkillCenterId",
                        column: x => x.SkillCenterId,
                        principalTable: "SkillCenters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Collaborateurs_TypeContrats_TypeContratId",
                        column: x => x.TypeContratId,
                        principalTable: "TypeContrats",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 2, "72f2e79d-e434-4ad9-8300-1a32f69ae8e9", "Admin", "ADMIN" },
                    { 3, "a65aac7b-a271-4f6b-aba3-0c25df3177ad", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "046bcdb8-748d-41a3-b355-84131b996b34", "Admin@sqli.com", false, false, null, "ADMIN@SQLI.COM", "ADMINUSER", "AQAAAAEAACcQAAAAEFP3hvfaeqocKjisB/k5uku/uJ5zBffhhYVlDdtVY/u2AiQFy96V7W8WylpJnQaf2g==", null, false, null, false, "AdminUser" });

            migrationBuilder.InsertData(
                table: "Niveaux",
                columns: new[] { "Id", "CreationDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 13, 48, 30, 959, DateTimeKind.Local).AddTicks(357), "Junior" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 13, 48, 30, 959, DateTimeKind.Local).AddTicks(358), "Opérationnel" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 13, 48, 30, 959, DateTimeKind.Local).AddTicks(359), "Confirmé" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 13, 48, 30, 959, DateTimeKind.Local).AddTicks(359), "Sénior" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CreationDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 13, 48, 30, 960, DateTimeKind.Local).AddTicks(9827), "Ingénieur Concepteur développeur" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 13, 48, 30, 960, DateTimeKind.Local).AddTicks(9827), "Expert technique" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 13, 48, 30, 960, DateTimeKind.Local).AddTicks(9828), "Chef de projet technique" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 13, 48, 30, 960, DateTimeKind.Local).AddTicks(9828), "Manager" }
                });

            migrationBuilder.InsertData(
                table: "SkillCenters",
                columns: new[] { "Id", "CreationDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 13, 48, 30, 955, DateTimeKind.Local).AddTicks(825), "Skill Microsoft" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 13, 48, 30, 955, DateTimeKind.Local).AddTicks(828), "Skill Java" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 13, 48, 30, 955, DateTimeKind.Local).AddTicks(828), "Skill PHP" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 13, 48, 30, 955, DateTimeKind.Local).AddTicks(829), "Skill Front & Mobile" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 13, 48, 30, 955, DateTimeKind.Local).AddTicks(830), "Skill DevOps" }
                });

            migrationBuilder.InsertData(
                table: "TypeContrats",
                columns: new[] { "Id", "CreationDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 13, 48, 30, 957, DateTimeKind.Local).AddTicks(1844), "CDI" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 13, 48, 30, 957, DateTimeKind.Local).AddTicks(1845), "CDD" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 13, 48, 30, 957, DateTimeKind.Local).AddTicks(1845), "Freelance" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "Collaborateurs",
                columns: new[] { "Id", "Adresse", "AutreTechnos", "Certifications", "Civilite", "CreationDate", "DateDebutStage", "DateEntreeSqli", "DateNaissance", "DatePremiereExperience", "DateSortieSqli", "Diplomes", "Email", "EmailPersonnel", "Files", "HadAlreadyWorkedAtSQLI", "Langues", "LieuNaissance", "Matricule", "ModeRecrutement", "ModificationDate", "Nationnalite", "NiveauId", "Nom", "Note", "NumCin", "PhonePersonnel", "PhoneProfesionnel", "PosteId", "Prenom", "Site", "SituationFamiliale", "SkillCenterId", "TypeContratId" },
                values: new object[,]
                {
                    { 1, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2011, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "abaazzi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "30783", "Autre", new DateTime(2022, 4, 19, 13, 48, 30, 963, DateTimeKind.Local).AddTicks(9714), "Marocaine", 4, "BAAZZI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Abdellah", "Rabat", "Célibataire", 1, 3 },
                    { 2, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2009:Ingénieur d'état en génie informatique", "aeljai@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "30517", "Autre", new DateTime(2022, 4, 19, 13, 48, 30, 963, DateTimeKind.Local).AddTicks(9946), "Marocaine", 3, "Afaf", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 3, "El", "Oujda", "Célibataire", 1, 1 },
                    { 3, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2007, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2010:Ingénieur d'Etat", "ynaimi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "30595", "Autre", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(5), "Marocaine", 1, "Naimi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 4, "Youssef", "Oujda", "Célibataire", 1, 1 },
                    { 4, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2012, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2012:Matser spécialisé en  Informatique|2010:Mastère en informatique|2010:Licence en physique informatique", "mlasmak@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "30903", "Autre", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(54), "Marocaine", 3, "LASMAK", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Marouane", "Rabat", "Célibataire", 1, 1 },
                    { 5, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2008, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:Diplôme d’ingénierie |2006:Diplôme universitaire de technologie", "mmajid@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "30376", "Autre", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(121), "Marocaine", 3, "MAJID", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Mostafa", "Rabat", "Célibataire", 1, 3 },
                    { 6, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2007, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2004:MIAGE|2006:Master MBDS", "nbennai@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "30238", "Autre", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(172), "Marocaine", 3, "BENNAI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Naoufal", "Rabat", "Célibataire", 1, 1 },
                    { 7, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2013, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2014:MIAGE", "yazzi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "30984", "Autre", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(215), "Marocaine", 3, "AZZI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Younesse", "Rabat", "Célibataire", 1, 1 },
                    { 8, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2010:Ingenieur", "schouki@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "30622", "Autre", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(278), "Marocaine", 1, "Siham", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 3, "Chouki", "Oujda", "Célibataire", 1, 1 },
                    { 9, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2013:Master Ingénierie Informatique", "mboufaddi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "30963", "Autre", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(328), "Marocaine", 4, "Mahmoud", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Boufaddi", "Oujda", "Célibataire", 1, 1 },
                    { 10, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2013, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2012:Master spécialisé |2005:Maîtrise Sciences et Techniques (MST)", "okarouite@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31012", "Autre", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(374), "Marocaine", 2, "KAROUITE", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Ouadii", "Rabat", "Célibataire", 1, 1 },
                    { 11, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2015:technicien spécialisé en développement m", "adidiomarelalaoui@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31281", "Spontané", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(446), "Marocaine", 4, "DIDI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "OMAR", "Rabat", "Célibataire", 1, 1 },
                    { 12, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2015:Diplôme d’ingénieur option MIAGE", "halaouiismaili@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31317", "Autre", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(495), "Marocaine", 4, "ALAOUI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "ISMAILI", "Rabat", "Célibataire", 1, 1 },
                    { 13, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2016:Ingénieur informatique|2012:Diplôme Universitaire de Technologie", "helhamdaoui@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31334", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(544), "Marocaine", 3, "EL", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "HAMDAOUI", "Rabat", "Célibataire", 1, 1 },
                    { 14, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2012:Ingénieur d'état|2009:Licence en génie informatique", "massayah@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31361", "Autre", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(617), "Marocaine", 4, "ASSAYAH", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Mimoun", "Rabat", "Célibataire", 1, 1 },
                    { 15, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "abouhafer@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31377", "Autre", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(666), "Marocaine", 4, "BOUHAFER", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Anass", "Rabat", "Célibataire", 1, 1 },
                    { 16, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "aelbouhafsi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31375", "Autre", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(719), "Marocaine", 4, "EL", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "BOUHAFSI", "Rabat", "Célibataire", 1, 1 },
                    { 17, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "ymaaiden@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31447", "Autre", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(788), "Marocaine", 4, "MAAIDEN", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Yassine", "Rabat", "Célibataire", 1, 1 },
                    { 18, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "zboukhris@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31436", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(837), "Marocaine", 4, "BOUKHRIS", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Zakaria", "Rabat", "Célibataire", 1, 1 },
                    { 19, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "iouazzi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31478", "Recommandation", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(882), "Marocaine", 4, "OUAZZI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Ilyas", "Rabat", "Célibataire", 1, 1 },
                    { 20, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "mbrahimi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31479", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(952), "Marocaine", 2, "BRAHIMI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Mouad", "Rabat", "Célibataire", 1, 1 },
                    { 21, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "maelakkel@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31553", "E-Chalenge", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1039), "Marocaine", 4, "EL", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "AKKEL", "Rabat", "Célibataire", 1, 1 },
                    { 22, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2015:Ingénierie des systèmes d’informatique|2017:Ingénierie des systèmes d’informations", "aeoubaid@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31452", "E-Chalenge", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1085), "Marocaine", 2, "OUBAID", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Abd", "Rabat", "Célibataire", 1, 1 },
                    { 23, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "iechenafi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31394", "E-Chalenge", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1155), "Marocaine", 3, "Echenafi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Imane", "Oujda", "Célibataire", 1, 1 },
                    { 24, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "alahlou@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31916", "Stage PFE", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1204), "Marocaine", 2, "Aadil", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "LAHLOU", "Oujda", "Célibataire", 1, 1 },
                    { 25, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2018, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "mtouiyek@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31683", "E-Chalenge", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1250), "Marocaine", 2, "TOUIYEK", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Mehdi", "Rabat", "Célibataire", 1, 1 },
                    { 26, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2018, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "naelhachimi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31687", "E-Chalenge", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1316), "Marocaine", 2, "EL", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "HACHIMI", "Rabat", "Célibataire", 1, 1 },
                    { 27, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "mkouakou@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1360), "Marocaine", 1, "Kouakou", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Miguel", "Rabat", "Célibataire", 1, 3 },
                    { 28, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "atoumi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31824", "E-Chalenge", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1413), "Marocaine", 2, "TOUMI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Achraf", "Rabat", "Célibataire", 1, 1 },
                    { 29, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "aaitelhad@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31835", "E-Chalenge", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1479), "Marocaine", 2, "AIT", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "EL", "Rabat", "Célibataire", 1, 1 },
                    { 30, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "nalboufarissi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31838", "E-Chalenge", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1524), "Marocaine", 2, "ALBOUFARISSI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Nidal", "Rabat", "Célibataire", 1, 1 },
                    { 31, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "nnaji@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31840", "E-Chalenge", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1570), "Marocaine", 2, "NAJI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Naji", "Rabat", "Célibataire", 1, 1 },
                    { 32, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "folahmidi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31933", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1635), "Marocaine", 2, "Lahmidi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Fouad", "Oujda", "Célibataire", 1, 1 },
                    { 33, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "atayebi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31939", "Cooptation", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1676), "Marocaine", 4, "TAYEBI", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Aziz", "Rabat", "Célibataire", 1, 1 },
                    { 34, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "fsosseyalaoui@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31954", "Stage PFE", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1725), "Marocaine", 2, "SOSSEY", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "ALAOUI", "Rabat", "Célibataire", 1, 1 },
                    { 35, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2013:M2: Nouvelles technologies|2013:Ingénieur en informatique et réseau", "melhilali@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31293", "Cooptation", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1791), "Marocaine", 3, "EL", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 3, "HILALI", "Rabat", "Célibataire", 1, 1 },
                    { 36, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:Technicien Spécialisé en Développement|2017:Licence Universitaire Professionnelle|2014:Baccalauréat Science Physique|2020:Master Universitaire Professionnelle", "schafik@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "31970", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1836), "Marocaine", 2, "CHAFIK", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Soufiane", "Rabat", "Célibataire", 1, 1 },
                    { 37, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "fzhamdi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32027", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1878), "Marocaine", 1, "Hamdi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Fatima", "Oujda", "Célibataire", 1, 1 },
                    { 38, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "beberaich@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32000", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1944), "Marocaine", 1, "Beraich", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Badre", "Oujda", "Célibataire", 1, 1 },
                    { 39, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "emlagzouli@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32083", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1986), "Marocaine", 1, "Lagzouli", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "El", "Rabat", "Célibataire", 1, 1 },
                    { 40, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:GÉNIE LOGICIEL|2019:LOGICIEL ET SYSTÈME INFORMATIQUE", "yelkaddouri@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32080", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2027), "Marocaine", 1, "El", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Kaddouri", "Rabat", "Célibataire", 1, 1 },
                    { 41, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "fzmaadane@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32021", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2090), "Marocaine", 1, "Maadane", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Fatima", "Oujda", "Célibataire", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Collaborateurs",
                columns: new[] { "Id", "Adresse", "AutreTechnos", "Certifications", "Civilite", "CreationDate", "DateDebutStage", "DateEntreeSqli", "DateNaissance", "DatePremiereExperience", "DateSortieSqli", "Diplomes", "Email", "EmailPersonnel", "Files", "HadAlreadyWorkedAtSQLI", "Langues", "LieuNaissance", "Matricule", "ModeRecrutement", "ModificationDate", "Nationnalite", "NiveauId", "Nom", "Note", "NumCin", "PhonePersonnel", "PhoneProfesionnel", "PosteId", "Prenom", "Site", "SituationFamiliale", "SkillCenterId", "TypeContratId" },
                values: new object[,]
                {
                    { 42, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "aelidrissijallal@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32062", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2132), "Marocaine", 1, "Adam", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "El", "Rabat", "Célibataire", 1, 1 },
                    { 43, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "ndroussi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2174), "Marocaine", 3, "Droussi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Nabil", "Rabat", "Célibataire", 1, 3 },
                    { 44, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "nhaouari@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2242), "Marocaine", 1, "Haouari", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Nadir", "Rabat", "Célibataire", 1, 3 },
                    { 45, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "llaghoui@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2289), "Marocaine", 3, "Laghoui", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Lhoucine", "Rabat", "Célibataire", 1, 3 },
                    { 46, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "azouitni@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2339), "Marocaine", 3, "Zouitni", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Abdelkrim", "Rabat", "Célibataire", 1, 3 },
                    { 47, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2009:Ingénierie Concepteur de Systèmes d’info|2004:BTS- Génie Informatique|2001:Baccalauréat", "aelyasni@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32134", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2419), "Marocaine", 4, "EL", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "YASNI", "Rabat", "Célibataire", 1, 1 },
                    { 48, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "mbounzaha@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2465), "Marocaine", 1, "Bounzaha", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Mohamed", "Rabat", "Célibataire", 1, 3 },
                    { 49, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "cchemmam@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32227", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2508), "Marocaine", 1, "Chaimaa", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Chemmam", "Rabat", "Célibataire", 1, 1 },
                    { 50, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "melboujbaoui@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32209", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2571), "Marocaine", 1, "Mounib", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "El", "Rabat", "Célibataire", 1, 1 },
                    { 51, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2018:T. S. en développement Informatique", "ahammeni@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32214", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2614), "Marocaine", 1, "Alaa", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Hammeni", "Rabat", "Célibataire", 1, 1 },
                    { 52, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "yelmousaoui@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32194", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2655), "Marocaine", 1, "Yassine", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Elmousaoui", "Oujda", "Célibataire", 1, 1 },
                    { 53, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "MROUDANI@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32248", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2722), "Marocaine", 1, "Mohamed", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Roudani", "Rabat", "Célibataire", 1, 1 },
                    { 54, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "MSIFANE@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32247", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2765), "Marocaine", 1, "Mouad", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Sifane", "Rabat", "Célibataire", 1, 1 },
                    { 55, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "MZIDANI@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32245", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2805), "Marocaine", 1, "Mohamed", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Zidani", "Rabat", "Célibataire", 1, 1 },
                    { 56, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "hfarraji@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32187", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2869), "Marocaine", 1, "Hicham", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Farraji", "Oujda", "Célibataire", 1, 1 },
                    { 57, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "ahjelti@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32188", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2912), "Marocaine", 1, "Ahlam", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Jelti", "Oujda", "Célibataire", 1, 1 },
                    { 58, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "momaghnouj@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32189", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2956), "Marocaine", 1, "Mohamed", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Maghnouj", "Oujda", "Célibataire", 1, 1 },
                    { 59, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "kmehdaoui@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32190", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3023), "Marocaine", 1, "Kaoutar", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Mehdaoui", "Oujda", "Célibataire", 1, 1 },
                    { 60, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "adbib@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32239", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3066), "Marocaine", 1, "Abdellah", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Dbib", "Rabat", "Célibataire", 1, 1 },
                    { 61, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "amotmani@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3106), "Marocaine", 1, "Otmani", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Amine", "Rabat", "Célibataire", 1, 3 },
                    { 62, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "lettout@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32287", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3170), "Marocaine", 4, "Lahcen", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Ettout", "Rabat", "Célibataire", 1, 1 },
                    { 63, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "selalami@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32300", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3214), "Marocaine", 4, "Salim", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "El", "Rabat", "Célibataire", 1, 1 },
                    { 64, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "mouelmrabet@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32304", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3256), "Marocaine", 3, "Mourad", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "El", "Rabat", "Célibataire", 1, 1 },
                    { 65, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "zlahmidi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32315", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3318), "Marocaine", 4, "Zakaria", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Lahmidi", "Rabat", "Célibataire", 1, 1 },
                    { 66, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "onfaoui@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32325", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3362), "Marocaine", 2, "Oussama", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Nfaoui", "Oujda", "Célibataire", 1, 1 },
                    { 67, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "oassanouni@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32334", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3402), "Marocaine", 1, "Omar", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Assanouni", "Rabat", "Célibataire", 1, 1 },
                    { 68, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "kbenchamekh@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32339", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3464), "Marocaine", 4, "Benchamekh", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Khalil", "Rabat", "Célibataire", 1, 1 },
                    { 69, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2021:MASTER - 2ASI", "zmiloudi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32337", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3507), "Marocaine", 1, "Miloudi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Zakaria", "Oujda", "Célibataire", 1, 1 },
                    { 70, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "mbouharrada@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32352", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3546), "Marocaine", 2, "Bouharrada", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Mohammed", "Oujda", "Célibataire", 1, 1 },
                    { 71, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "hkhazrouni@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3615), "Marocaine", 1, "Khazrouni", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Hassan", "Rabat", "Célibataire", 1, 3 },
                    { 72, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2017:Génie logiciel|2018:Sicences mathématiques et informatique|2021:Ingénierie logiciel", "maaribech@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32360", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3659), "Marocaine", 1, "aribech", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "mohamed", "Rabat", "Célibataire", 1, 1 },
                    { 73, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2018:Diplôme de Technicien Spécialisé|2011:Baccalauréat", "kakhardid@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32358", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3699), "Marocaine", 1, "Akhardid", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Khadija", "Rabat", "Célibataire", 1, 1 },
                    { 74, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2015:Master STRI", "zazoulay@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32363", "Autre", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3759), "Marocaine", 4, "Azoulay", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Zakaria", "Rabat", "Célibataire", 1, 1 },
                    { 75, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "mfliti@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32367", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3805), "Marocaine", 1, "Fliti", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Mouad", "Oujda", "Célibataire", 1, 1 },
                    { 76, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "bybahi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32366", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3845), "Marocaine", 1, "Bahi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "ben", "Oujda", "Célibataire", 1, 1 },
                    { 77, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "wberehil@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32370", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3905), "Marocaine", 1, "Berehil", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Walid", "Oujda", "Célibataire", 1, 1 },
                    { 78, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "knaimi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32377", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3946), "Marocaine", 1, "Naimi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Khalil", "Oujda", "Célibataire", 1, 1 },
                    { 79, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "slourhaoui@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32380", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(4028), "Marocaine", 2, "Lourhaoui", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Soukaina", "Rabat", "Célibataire", 1, 1 },
                    { 80, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "hbenmachi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32392", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(4095), "Marocaine", 3, "Benmachi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Hamza", "Rabat", "Célibataire", 1, 1 },
                    { 81, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:Licence en EEA|2019:Ingénieur Automatisme Info Industrielle", "aouahdi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32402", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(4137), "Marocaine", 3, "Ouahdi", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Abdachahid", "Rabat", "Célibataire", 1, 1 },
                    { 82, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "zerrafiqi@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(4179), "Marocaine", 1, "Zakaria", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Errafiqi", "Rabat", "Célibataire", 1, 3 },
                    { 83, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2016:Ingénieur d’état en génie informatique", "aselhassani@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32463", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(4240), "Marocaine", 4, "Asmae", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "El", "Rabat", "Célibataire", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Collaborateurs",
                columns: new[] { "Id", "Adresse", "AutreTechnos", "Certifications", "Civilite", "CreationDate", "DateDebutStage", "DateEntreeSqli", "DateNaissance", "DatePremiereExperience", "DateSortieSqli", "Diplomes", "Email", "EmailPersonnel", "Files", "HadAlreadyWorkedAtSQLI", "Langues", "LieuNaissance", "Matricule", "ModeRecrutement", "ModificationDate", "Nationnalite", "NiveauId", "Nom", "Note", "NumCin", "PhonePersonnel", "PhoneProfesionnel", "PosteId", "Prenom", "Site", "SituationFamiliale", "SkillCenterId", "TypeContratId" },
                values: new object[] { 84, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2017:Diplome d'ingénieur informatique", "adyar@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "32524", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(4288), "Marocaine", 4, "Abderrahmane", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 1, "Dyar", "Rabat", "Célibataire", 1, 1 });

            migrationBuilder.InsertData(
                table: "Collaborateurs",
                columns: new[] { "Id", "Adresse", "AutreTechnos", "Certifications", "Civilite", "CreationDate", "DateDebutStage", "DateEntreeSqli", "DateNaissance", "DatePremiereExperience", "DateSortieSqli", "Diplomes", "Email", "EmailPersonnel", "Files", "HadAlreadyWorkedAtSQLI", "Langues", "LieuNaissance", "Matricule", "ModeRecrutement", "ModificationDate", "Nationnalite", "NiveauId", "Nom", "Note", "NumCin", "PhonePersonnel", "PhoneProfesionnel", "PosteId", "Prenom", "Site", "SituationFamiliale", "SkillCenterId", "TypeContratId" },
                values: new object[] { 85, "Hay Andalous, Rue les orangers, Nr 2", "Dapper|NUnit|Angular|Bootstrap|TailWind|PostgreSQL", "Certified .Net Developper|Angular Certification|Français avancé C1", "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "afourtit@sqli.com", "email.personnel@gmail.com", "", false, "Français|Anglais", "Rabat", "0", "", new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(4333), "Marocaine", 1, "Fourtit", "ceci est une note et remarque concernant le collaborateur.", "F580877", "+212 06 66 20 17 40", "+212 06 12 34 56 78", 2, "Abdelaziz", "Rabat", "Célibataire", 1, 3 });

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
                name: "IX_Collaborateurs_NiveauId",
                table: "Collaborateurs",
                column: "NiveauId");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborateurs_PosteId",
                table: "Collaborateurs",
                column: "PosteId");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborateurs_SkillCenterId",
                table: "Collaborateurs",
                column: "SkillCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Collaborateurs_TypeContratId",
                table: "Collaborateurs",
                column: "TypeContratId");

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
                name: "ModesRecrutements");

            migrationBuilder.DropTable(
                name: "Sites");

            migrationBuilder.DropTable(
                name: "ToDoItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Niveaux");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "SkillCenters");

            migrationBuilder.DropTable(
                name: "TypeContrats");

            migrationBuilder.DropTable(
                name: "ToDoLists");
        }
    }
}
