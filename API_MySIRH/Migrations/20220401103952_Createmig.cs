using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_MySIRH.Migrations
{
<<<<<<< HEAD:API_MySIRH/Migrations/20220401103111_init.cs
    public partial class init : Migration
=======
    public partial class Createmig : Migration
>>>>>>> develop:API_MySIRH/Migrations/20220401103952_Createmig.cs
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Matricule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Civilite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModeRecrutement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatePremiereExperience = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateEntreeSqli = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateSortieSqli = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDebutStage = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Diplomes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collaborateurs", x => x.Id);
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
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
<<<<<<< HEAD:API_MySIRH/Migrations/20220401103111_init.cs
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "efe43967-05ec-4bd7-b1ef-6cd66714582b", "Administrator", "ADMINISTRATOR" });
=======
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "147a34d7-c4a3-4808-babd-74c2ab4fd44e", "Administrator", "ADMINISTRATOR" });
>>>>>>> develop:API_MySIRH/Migrations/20220401103952_Createmig.cs

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
<<<<<<< HEAD:API_MySIRH/Migrations/20220401103111_init.cs
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "98f39d53-cf20-4185-bfb8-14d610c685d6", null, false, false, null, null, "MYUSER", "AQAAAAEAACcQAAAAEO1r8Z9Eo5KL4pqC/0eFLTmYK7P0ztrzOq/iSoytZURtLkP94/p73mVfqaq1vowPCg==", null, false, "ccebb4d3-56d5-44c5-afdd-91155ff20437", false, "myuser" });
=======
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "027ccd5b-a964-4e87-9175-4c50252bfe3a", null, false, false, null, null, "MYUSER", "AQAAAAEAACcQAAAAEHBL7iKgZpi8CUL8Wa2uRj/nM2FWRpM+F7AKC1DsRINSOdSNZDkHLSFZb+bWkTVUgA==", null, false, "ec067c7c-1258-4b3e-8f11-ca4b20c91e56", false, "myuser" });
>>>>>>> develop:API_MySIRH/Migrations/20220401103952_Createmig.cs

            migrationBuilder.InsertData(
                table: "Collaborateurs",
                columns: new[] { "Id", "Civilite", "CreationDate", "DateDebutStage", "DateEntreeSqli", "DateNaissance", "DatePremiereExperience", "DateSortieSqli", "Diplomes", "Matricule", "ModeRecrutement", "ModificationDate", "Nom", "Prenom" },
                values: new object[,]
                {
<<<<<<< HEAD:API_MySIRH/Migrations/20220401103111_init.cs
                    { 1, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2011, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "30783", "Autre", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(1477), "BAAZZI", "Abdellah" },
                    { 2, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2009:Ingénieur d'état en génie informatique", "30517", "Autre", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(1757), "Afaf", "El" },
                    { 3, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2007, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2010:Ingénieur d'Etat", "30595", "Autre", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(1790), "Naimi", "Youssef" },
                    { 4, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2012, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2012:Matser spécialisé en  Informatique|2010:Mastère en informatique|2010:Licence en physique informatique", "30903", "Autre", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(1810), "LASMAK", "Marouane" },
                    { 5, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2008, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:Diplôme d’ingénierie |2006:Diplôme universitaire de technologie", "30376", "Autre", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(1830), "MAJID", "Mostafa" },
                    { 6, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2007, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2004:MIAGE|2006:Master MBDS", "30238", "Autre", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(1850), "BENNAI", "Naoufal" },
                    { 7, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2013, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2014:MIAGE", "30984", "Autre", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(1874), "AZZI", "Younesse" },
                    { 8, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2010:Ingenieur", "30622", "Autre", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(1891), "Siham", "Chouki" },
                    { 9, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2013:Master Ingénierie Informatique", "30963", "Autre", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(1912), "Mahmoud", "Boufaddi" },
                    { 10, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2013, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2012:Master spécialisé |2005:Maîtrise Sciences et Techniques (MST)", "31012", "Autre", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(1933), "KAROUITE", "Ouadii" },
                    { 11, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2015:technicien spécialisé en développement m", "31281", "Spontané", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(1981), "DIDI", "OMAR" },
                    { 12, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2015:Diplôme d’ingénieur option MIAGE", "31317", "Autre", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2003), "ALAOUI", "ISMAILI" },
                    { 13, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2016:Ingénieur informatique|2012:Diplôme Universitaire de Technologie", "31334", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2025), "EL", "HAMDAOUI" },
                    { 14, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2012:Ingénieur d'état|2009:Licence en génie informatique", "31361", "Autre", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2045), "ASSAYAH", "Mimoun" },
                    { 15, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "31377", "Autre", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2066), "BOUHAFER", "Anass" },
                    { 16, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31375", "Autre", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2088), "EL", "BOUHAFSI" },
                    { 17, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "31447", "Autre", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2105), "MAAIDEN", "Yassine" },
                    { 18, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31436", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2129), "BOUKHRIS", "Zakaria" },
                    { 19, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "31478", "Recommandation", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2154), "OUAZZI", "Ilyas" },
                    { 20, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31479", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2178), "BRAHIMI", "Mouad" },
                    { 21, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31553", "E-Chalenge", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2202), "EL", "AKKEL" },
                    { 22, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2015:Ingénierie des systèmes d’informatique|2017:Ingénierie des systèmes d’informations", "31452", "E-Chalenge", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2220), "OUBAID", "Abd" },
                    { 23, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31394", "E-Chalenge", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2239), "Echenafi", "Imane" },
                    { 24, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31916", "Stage PFE", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2284), "Aadil", "LAHLOU" },
                    { 25, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2018, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31683", "E-Chalenge", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2306), "TOUIYEK", "Mehdi" },
                    { 26, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2018, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31687", "E-Chalenge", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2324), "EL", "HACHIMI" },
                    { 27, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "0", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2342), "Kouakou", "Miguel" },
                    { 28, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31824", "E-Chalenge", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2365), "TOUMI", "Achraf" },
                    { 29, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31835", "E-Chalenge", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2381), "AIT", "EL" },
                    { 30, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31838", "E-Chalenge", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2400), "ALBOUFARISSI", "Nidal" },
                    { 31, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31840", "E-Chalenge", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2421), "NAJI", "Naji" },
                    { 32, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31933", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2442), "Lahmidi", "Fouad" },
                    { 33, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "31939", "Cooptation", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2462), "TAYEBI", "Aziz" },
                    { 34, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31954", "Stage PFE", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2486), "SOSSEY", "ALAOUI" },
                    { 35, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2013:M2: Nouvelles technologies|2013:Ingénieur en informatique et réseau", "31293", "Cooptation", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2506), "EL", "HILALI" },
                    { 36, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:Technicien Spécialisé en Développement|2017:Licence Universitaire Professionnelle|2014:Baccalauréat Science Physique|2020:Master Universitaire Professionnelle", "31970", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2547), "CHAFIK", "Soufiane" },
                    { 37, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "32027", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2566), "Hamdi", "Fatima" },
                    { 38, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32000", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2587), "Beraich", "Badre" },
                    { 39, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32083", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2605), "Lagzouli", "El" },
                    { 40, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:GÉNIE LOGICIEL|2019:LOGICIEL ET SYSTÈME INFORMATIQUE", "32080", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2625), "El", "Kaddouri" }
=======
                    { 1, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2011, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "30783", "Autre", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(4499), "BAAZZI", "Abdellah" },
                    { 2, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2009:Ingénieur d'état en génie informatique", "30517", "Autre", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(4781), "Afaf", "El" },
                    { 3, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2007, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2010:Ingénieur d'Etat", "30595", "Autre", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(4837), "Naimi", "Youssef" },
                    { 4, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2012, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2012:Matser spécialisé en  Informatique|2010:Mastère en informatique|2010:Licence en physique informatique", "30903", "Autre", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(4861), "LASMAK", "Marouane" },
                    { 5, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2008, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:Diplôme d’ingénierie |2006:Diplôme universitaire de technologie", "30376", "Autre", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(4883), "MAJID", "Mostafa" },
                    { 6, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2007, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2004:MIAGE|2006:Master MBDS", "30238", "Autre", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(4907), "BENNAI", "Naoufal" },
                    { 7, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2013, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2014:MIAGE", "30984", "Autre", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(4925), "AZZI", "Younesse" },
                    { 8, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2010:Ingenieur", "30622", "Autre", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(4945), "Siham", "Chouki" },
                    { 9, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2013:Master Ingénierie Informatique", "30963", "Autre", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(4970), "Mahmoud", "Boufaddi" },
                    { 10, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2013, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2012:Master spécialisé |2005:Maîtrise Sciences et Techniques (MST)", "31012", "Autre", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(4992), "KAROUITE", "Ouadii" },
                    { 11, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2015:technicien spécialisé en développement m", "31281", "Spontané", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5015), "DIDI", "OMAR" },
                    { 12, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2015:Diplôme d’ingénieur option MIAGE", "31317", "Autre", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5036), "ALAOUI", "ISMAILI" },
                    { 13, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2016:Ingénieur informatique|2012:Diplôme Universitaire de Technologie", "31334", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5060), "EL", "HAMDAOUI" },
                    { 14, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2016, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2012:Ingénieur d'état|2009:Licence en génie informatique", "31361", "Autre", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5082), "ASSAYAH", "Mimoun" },
                    { 15, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "31377", "Autre", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5099), "BOUHAFER", "Anass" },
                    { 16, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31375", "Autre", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5143), "EL", "BOUHAFSI" },
                    { 17, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "31447", "Autre", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5162), "MAAIDEN", "Yassine" },
                    { 18, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31436", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5184), "BOUKHRIS", "Zakaria" },
                    { 19, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "31478", "Recommandation", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5205), "OUAZZI", "Ilyas" },
                    { 20, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31479", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5226), "BRAHIMI", "Mouad" },
                    { 21, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31553", "E-Chalenge", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5246), "EL", "AKKEL" },
                    { 22, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2017, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2015:Ingénierie des systèmes d’informatique|2017:Ingénierie des systèmes d’informations", "31452", "E-Chalenge", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5267), "OUBAID", "Abd" },
                    { 23, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31394", "E-Chalenge", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5287), "Echenafi", "Imane" },
                    { 24, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31916", "Stage PFE", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5311), "Aadil", "LAHLOU" },
                    { 25, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2018, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31683", "E-Chalenge", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5333), "TOUIYEK", "Mehdi" },
                    { 26, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2018, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31687", "E-Chalenge", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5352), "EL", "HACHIMI" },
                    { 27, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "0", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5371), "Kouakou", "Miguel" },
                    { 28, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31824", "E-Chalenge", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5398), "TOUMI", "Achraf" },
                    { 29, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31835", "E-Chalenge", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5422), "AIT", "EL" },
                    { 30, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31838", "E-Chalenge", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5465), "ALBOUFARISSI", "Nidal" },
                    { 31, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31840", "E-Chalenge", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5487), "NAJI", "Naji" },
                    { 32, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31933", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5507), "Lahmidi", "Fouad" },
                    { 33, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "31939", "Cooptation", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5525), "TAYEBI", "Aziz" },
                    { 34, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "31954", "Stage PFE", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5550), "SOSSEY", "ALAOUI" },
                    { 35, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2013:M2: Nouvelles technologies|2013:Ingénieur en informatique et réseau", "31293", "Cooptation", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5576), "EL", "HILALI" },
                    { 36, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:Technicien Spécialisé en Développement|2017:Licence Universitaire Professionnelle|2014:Baccalauréat Science Physique|2020:Master Universitaire Professionnelle", "31970", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5594), "CHAFIK", "Soufiane" },
                    { 37, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "32027", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5614), "Hamdi", "Fatima" },
                    { 38, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32000", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5636), "Beraich", "Badre" },
                    { 39, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32083", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5661), "Lagzouli", "El" },
                    { 40, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:GÉNIE LOGICIEL|2019:LOGICIEL ET SYSTÈME INFORMATIQUE", "32080", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5680), "El", "Kaddouri" }
>>>>>>> develop:API_MySIRH/Migrations/20220401103952_Createmig.cs
                });

            migrationBuilder.InsertData(
                table: "Collaborateurs",
                columns: new[] { "Id", "Civilite", "CreationDate", "DateDebutStage", "DateEntreeSqli", "DateNaissance", "DatePremiereExperience", "DateSortieSqli", "Diplomes", "Matricule", "ModeRecrutement", "ModificationDate", "Nom", "Prenom" },
                values: new object[,]
                {
<<<<<<< HEAD:API_MySIRH/Migrations/20220401103111_init.cs
                    { 41, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32021", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2644), "Maadane", "Fatima" },
                    { 42, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32062", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2662), "Adam", "El" },
                    { 43, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "0", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2680), "Droussi", "Nabil" },
                    { 44, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "0", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2700), "Haouari", "Nadir" },
                    { 45, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "0", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2721), "Laghoui", "Lhoucine" },
                    { 46, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "0", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2740), "Zouitni", "Abdelkrim" },
                    { 47, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2009:Ingénierie Concepteur de Systèmes d’info|2004:BTS- Génie Informatique|2001:Baccalauréat", "32134", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2761), "EL", "YASNI" },
                    { 48, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "0", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2780), "Bounzaha", "Mohamed" },
                    { 49, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32227", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2822), "Chaimaa", "Chemmam" },
                    { 50, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32209", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2841), "Mounib", "El" },
                    { 51, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2018:T. S. en développement Informatique", "32214", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2859), "Alaa", "Hammeni" },
                    { 52, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32194", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2878), "Yassine", "Elmousaoui" },
                    { 53, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32248", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2897), "Mohamed", "Roudani" },
                    { 54, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32247", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2913), "Mouad", "Sifane" },
                    { 55, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32245", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2929), "Mohamed", "Zidani" },
                    { 56, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32187", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2944), "Hicham", "Farraji" },
                    { 57, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32188", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2964), "Ahlam", "Jelti" },
                    { 58, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32189", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(2984), "Mohamed", "Maghnouj" },
                    { 59, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32190", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3003), "Kaoutar", "Mehdaoui" },
                    { 60, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32239", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3022), "Abdellah", "Dbib" },
                    { 61, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "0", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3041), "Otmani", "Amine" },
                    { 62, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32287", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3056), "Lahcen", "Ettout" },
                    { 63, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32300", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3073), "Salim", "El" },
                    { 64, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32304", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3110), "Mourad", "El" },
                    { 65, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32315", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3127), "Zakaria", "Lahmidi" },
                    { 66, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32325", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3148), "Oussama", "Nfaoui" },
                    { 67, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32334", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3177), "Omar", "Assanouni" },
                    { 68, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32339", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3194), "Benchamekh", "Khalil" },
                    { 69, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2021:MASTER - 2ASI", "32337", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3216), "Miloudi", "Zakaria" },
                    { 70, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32352", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3233), "Bouharrada", "Mohammed" },
                    { 71, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "0", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3250), "Khazrouni", "Hassan" },
                    { 72, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2017:Génie logiciel|2018:Sicences mathématiques et informatique|2021:Ingénierie logiciel", "32360", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3267), "aribech", "mohamed" },
                    { 73, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2018:Diplôme de Technicien Spécialisé|2011:Baccalauréat", "32358", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3284), "Akhardid", "Khadija" },
                    { 74, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2015:Master STRI", "32363", "Autre", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3306), "Azoulay", "Zakaria" },
                    { 75, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32367", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3325), "Fliti", "Mouad" },
                    { 76, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32366", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3370), "Bahi", "ben" },
                    { 77, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32370", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3387), "Berehil", "Walid" },
                    { 78, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32377", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3403), "Naimi", "Khalil" },
                    { 79, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32380", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3420), "Lourhaoui", "Soukaina" },
                    { 80, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32392", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3437), "Benmachi", "Hamza" },
                    { 81, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:Licence en EEA|2019:Ingénieur Automatisme Info Industrielle", "32402", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3453), "Ouahdi", "Abdachahid" },
                    { 82, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "0", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3470), "Zakaria", "Errafiqi" }
=======
                    { 41, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32021", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5699), "Maadane", "Fatima" },
                    { 42, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32062", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5750), "Adam", "El" },
                    { 43, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "0", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5769), "Droussi", "Nabil" },
                    { 44, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "0", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5790), "Haouari", "Nadir" },
                    { 45, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2019, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "0", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5811), "Laghoui", "Lhoucine" },
                    { 46, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "0", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5831), "Zouitni", "Abdelkrim" },
                    { 47, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2009:Ingénierie Concepteur de Systèmes d’info|2004:BTS- Génie Informatique|2001:Baccalauréat", "32134", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5853), "EL", "YASNI" },
                    { 48, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "0", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5871), "Bounzaha", "Mohamed" },
                    { 49, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32227", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5895), "Chaimaa", "Chemmam" },
                    { 50, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32209", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5913), "Mounib", "El" },
                    { 51, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2018:T. S. en développement Informatique", "32214", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5930), "Alaa", "Hammeni" },
                    { 52, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32194", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5953), "Yassine", "Elmousaoui" },
                    { 53, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32248", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5973), "Mohamed", "Roudani" },
                    { 54, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32247", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(5992), "Mouad", "Sifane" },
                    { 55, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32245", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6032), "Mohamed", "Zidani" },
                    { 56, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32187", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6049), "Hicham", "Farraji" },
                    { 57, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32188", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6069), "Ahlam", "Jelti" },
                    { 58, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32189", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6089), "Mohamed", "Maghnouj" },
                    { 59, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32190", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6109), "Kaoutar", "Mehdaoui" },
                    { 60, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32239", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6127), "Abdellah", "Dbib" },
                    { 61, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "0", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6144), "Otmani", "Amine" },
                    { 62, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32287", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6162), "Lahcen", "Ettout" },
                    { 63, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32300", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6179), "Salim", "El" },
                    { 64, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32304", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6195), "Mourad", "El" },
                    { 65, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32315", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6213), "Zakaria", "Lahmidi" },
                    { 66, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32325", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6231), "Oussama", "Nfaoui" },
                    { 67, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32334", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6248), "Omar", "Assanouni" },
                    { 68, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32339", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6290), "Benchamekh", "Khalil" },
                    { 69, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2021:MASTER - 2ASI", "32337", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6307), "Miloudi", "Zakaria" },
                    { 70, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32352", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6323), "Bouharrada", "Mohammed" },
                    { 71, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "0", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6340), "Khazrouni", "Hassan" },
                    { 72, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2017:Génie logiciel|2018:Sicences mathématiques et informatique|2021:Ingénierie logiciel", "32360", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6358), "aribech", "mohamed" },
                    { 73, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2018:Diplôme de Technicien Spécialisé|2011:Baccalauréat", "32358", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6375), "Akhardid", "Khadija" },
                    { 74, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2015:Master STRI", "32363", "Autre", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6392), "Azoulay", "Zakaria" },
                    { 75, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32367", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6413), "Fliti", "Mouad" },
                    { 76, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32366", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6430), "Bahi", "ben" },
                    { 77, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32370", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6448), "Berehil", "Walid" },
                    { 78, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32377", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6464), "Naimi", "Khalil" },
                    { 79, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32380", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6480), "Lourhaoui", "Soukaina" },
                    { 80, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "32392", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6498), "Benmachi", "Hamza" },
                    { 81, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2016:Licence en EEA|2019:Ingénieur Automatisme Info Industrielle", "32402", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6515), "Ouahdi", "Abdachahid" },
                    { 82, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "0", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6556), "Zakaria", "Errafiqi" }
>>>>>>> develop:API_MySIRH/Migrations/20220401103952_Createmig.cs
                });

            migrationBuilder.InsertData(
                table: "Collaborateurs",
                columns: new[] { "Id", "Civilite", "CreationDate", "DateDebutStage", "DateEntreeSqli", "DateNaissance", "DatePremiereExperience", "DateSortieSqli", "Diplomes", "Matricule", "ModeRecrutement", "ModificationDate", "Nom", "Prenom" },
<<<<<<< HEAD:API_MySIRH/Migrations/20220401103111_init.cs
                values: new object[] { 83, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2016:Ingénieur d’état en génie informatique", "32463", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3486), "Asmae", "El" });
=======
                values: new object[] { 83, "F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2016:Ingénieur d’état en génie informatique", "32463", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6572), "Asmae", "El" });
>>>>>>> develop:API_MySIRH/Migrations/20220401103952_Createmig.cs

            migrationBuilder.InsertData(
                table: "Collaborateurs",
                columns: new[] { "Id", "Civilite", "CreationDate", "DateDebutStage", "DateEntreeSqli", "DateNaissance", "DatePremiereExperience", "DateSortieSqli", "Diplomes", "Matricule", "ModeRecrutement", "ModificationDate", "Nom", "Prenom" },
<<<<<<< HEAD:API_MySIRH/Migrations/20220401103111_init.cs
                values: new object[] { 84, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2017:Diplome d'ingénieur informatique", "32524", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3506), "Abderrahmane", "Dyar" });
=======
                values: new object[] { 84, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2017:Diplome d'ingénieur informatique", "32524", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6593), "Abderrahmane", "Dyar" });
>>>>>>> develop:API_MySIRH/Migrations/20220401103952_Createmig.cs

            migrationBuilder.InsertData(
                table: "Collaborateurs",
                columns: new[] { "Id", "Civilite", "CreationDate", "DateDebutStage", "DateEntreeSqli", "DateNaissance", "DatePremiereExperience", "DateSortieSqli", "Diplomes", "Matricule", "ModeRecrutement", "ModificationDate", "Nom", "Prenom" },
<<<<<<< HEAD:API_MySIRH/Migrations/20220401103111_init.cs
                values: new object[] { 85, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "0", "", new DateTime(2022, 4, 1, 10, 31, 11, 96, DateTimeKind.Local).AddTicks(3525), "Fourtit", "Abdelaziz" });
=======
                values: new object[] { 85, "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "", "0", "", new DateTime(2022, 4, 1, 10, 39, 51, 972, DateTimeKind.Local).AddTicks(6613), "Fourtit", "Abdelaziz" });
>>>>>>> develop:API_MySIRH/Migrations/20220401103952_Createmig.cs

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

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
