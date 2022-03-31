using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_MySIRH.Migrations
{
    public partial class AddCollaborateurTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Civilite = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ModeRecrutement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatePremiereExperience = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEntreeSqli = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateSortieSqli = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDebutStage = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Diplomes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collaborateurs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "049f03cf-40dc-40ef-9b36-410a173ae976");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8e0949e-cd5d-4fd4-8c89-f9b811db3256", "AQAAAAEAACcQAAAAEEVV8OqIGSjhsgUpofOYevEmUIJIBWJK8SQrg17Z59s8S8ipPaF54u9w7TEAL879yg==", "e6d35e78-0c78-433c-9b92-c1decf7b0f0a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Collaborateurs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "f1070b6c-918f-491f-a9b8-3ac5ee34dcc5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6c22342-9491-45e1-83e9-3653dd82ada9", "AQAAAAEAACcQAAAAEJN4zJer6X/qAMBXoBVGMKYJAY7yE7+SfNq7dgKiqUFnBmkHmQCOSsJfPxQkmfK7rg==", "2810a6dd-7865-47e3-8a77-9b6c6c898628" });
        }
    }
}
