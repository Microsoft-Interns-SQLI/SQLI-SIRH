using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_MySIRH.Data.Migrations
{
    public partial class newdtos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d0499b83-ee03-443e-aca9-ce6c04bfa648");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "97951d2a-a328-4cd9-a30b-0474e67e826e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c664c638-95aa-430e-88da-0750e56c203a", "AQAAAAEAACcQAAAAEFdFssSLW5Y4NFQm6K5G/jAsrq1NcNEtpoj8f2YnLkPIeWcBdjnkYaREvSucJ60OeQ==" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(2712), "Expert technique", "Skill Microsoft", "Freelance" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(2992), "Confirmé", "Chef de projet technique", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3035), "Junior", "Manager", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3097), "Confirmé", "Expert technique", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3129), "Confirmé", "Expert technique", "Skill Microsoft", "Freelance" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3157), "Confirmé", "Expert technique", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3184), "Confirmé", "Expert technique", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3210), "Junior", "Chef de projet technique", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ModificationDate", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3238), "Expert technique", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3268), "Opérationnel", "Expert technique", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3297), "Expert technique", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3328), "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3356), "Confirmé", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3404), "Expert technique", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3432), "Expert technique", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3465), "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3490), "Expert technique", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3520), "Expert technique", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3548), "Expert technique", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3579), "Opérationnel", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3608), "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3633), "Opérationnel", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3662), "Confirmé", "Ingénieur Concepteur développeur", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3714), "Opérationnel", "Ingénieur Concepteur développeur", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3742), "Opérationnel", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3766), "Opérationnel", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3791), "Junior", "Expert technique", "Skill Microsoft", "Freelance" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3824), "Opérationnel", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3851), "Opérationnel", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3879), "Opérationnel", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3912), "Opérationnel", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3941), "Opérationnel", "Ingénieur Concepteur développeur", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(3965), "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4016), "Opérationnel", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4046), "Confirmé", "Chef de projet technique", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4076), "Opérationnel", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4100), "Junior", "Ingénieur Concepteur développeur", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4130), "Junior", "Ingénieur Concepteur développeur", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4156), "Junior", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4182), "Junior", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4206), "Junior", "Ingénieur Concepteur développeur", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4231), "Junior", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4255), "Confirmé", "Expert technique", "Skill Microsoft", "Freelance" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4304), "Junior", "Expert technique", "Skill Microsoft", "Freelance" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4331), "Confirmé", "Expert technique", "Skill Microsoft", "Freelance" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4357), "Confirmé", "Expert technique", "Skill Microsoft", "Freelance" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4385), "Expert technique", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4412), "Junior", "Ingénieur Concepteur développeur", "Skill Microsoft", "Freelance" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4435), "Junior", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4458), "Junior", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4482), "Junior", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4509), "Junior", "Ingénieur Concepteur développeur", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4536), "Junior", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4560), "Junior", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4605), "Junior", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4629), "Junior", "Ingénieur Concepteur développeur", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4656), "Junior", "Ingénieur Concepteur développeur", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4683), "Junior", "Ingénieur Concepteur développeur", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4708), "Junior", "Ingénieur Concepteur développeur", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4734), "Junior", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4758), "Junior", "Expert technique", "Skill Microsoft", "Freelance" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4781), "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4804), "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4828), "Confirmé", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4856), "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4903), "Opérationnel", "Ingénieur Concepteur développeur", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4927), "Junior", "Expert technique", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4950), "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4973), "Junior", "Ingénieur Concepteur développeur", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(4997), "Opérationnel", "Ingénieur Concepteur développeur", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(5020), "Junior", "Expert technique", "Skill Microsoft", "Freelance" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(5043), "Junior", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(5067), "Junior", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(5091), "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(5142), "Junior", "Ingénieur Concepteur développeur", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(5167), "Junior", "Ingénieur Concepteur développeur", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(5191), "Junior", "Ingénieur Concepteur développeur", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(5214), "Junior", "Ingénieur Concepteur développeur", "Oujda", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(5237), "Opérationnel", "Expert technique", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(5261), "Confirmé", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(5285), "Confirmé", "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(5308), "Junior", "Ingénieur Concepteur développeur", "Skill Microsoft", "Freelance" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(5331), "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(5358), "Ingénieur Concepteur développeur", "Skill Microsoft" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(5384), "Junior", "Expert technique", "Skill Microsoft", "Freelance" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 10, 16, 14, 45, 625, DateTimeKind.Local).AddTicks(5557));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b4abf734-30a7-4de4-a63f-b8b4b3f3e5da");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "0493c23b-d37c-4976-a90a-2b34657a2741");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "33cea607-6b54-450e-aee3-ffa9745fd114", "AQAAAAEAACcQAAAAEICtWMXCOj1gpW3LDuwLMZxOvCbVNi+oxag2Xo518cJXWtqYIcA5vNbHC6nW5l1rWQ==" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(7881), "Ingénieur Concepteur Développeur", "SQLI Rabat", "CDI" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8256), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8302), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8363), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8391), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat", "CDI" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8417), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8446), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8466), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ModificationDate", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8492), "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8519), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8543), "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8569), "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8593), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8639), "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8659), "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8683), "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8708), "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8730), "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8757), "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8791), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8819), "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8842), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8868), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8916), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8941), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8960), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(8983), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat", "CDI" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9010), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9037), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9060), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9089), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9111), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9134), "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9184), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9208), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9231), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9255), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9282), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9308), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9329), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9348), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9369), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9392), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat", "CDI" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9441), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat", "CDI" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9463), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat", "CDI" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9484), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat", "CDI" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9507), "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9528), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat", "CDI" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9552), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9574), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9594), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9612), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9635), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9684), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9703), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9720), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9742), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9764), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9786), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9806), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9825), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat", "CDI" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9843), "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9861), "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9879), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9919), "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9938), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9956), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9974), "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 557, DateTimeKind.Local).AddTicks(9992), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(9), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(28), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat", "CDI" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(46), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(65), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(83), "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(127), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(145), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(163), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "Site", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(181), "Sénior", "Ingénieur Concepteur Développeur", "Rabat", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(198), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(217), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(235), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(254), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat", "CDI" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(271), "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ModificationDate", "Poste", "SkillCenter" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(293), "Ingénieur Concepteur Développeur", "SQLI Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ModificationDate", "Niveau", "Poste", "SkillCenter", "TypeContrat" },
                values: new object[] { new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(343), "Sénior", "Ingénieur Concepteur Développeur", "SQLI Rabat", "CDI" });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 8, 15, 0, 31, 558, DateTimeKind.Local).AddTicks(578));
        }
    }
}
