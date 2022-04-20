using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_MySIRH.Data.Migrations
{
    public partial class MigrateDBBB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModeRecrutement",
                table: "Collaborateurs");

            migrationBuilder.AddColumn<int>(
                name: "ModeRecrutementId",
                table: "Collaborateurs",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c9426825-6ffa-4146-9fd2-95fdbb7c6904");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "324e2c88-4e84-410f-98d4-bb38dd260aaa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f96f934e-bcd7-4035-905e-ac2fa732f46b", "AQAAAAEAACcQAAAAEG5W9BDqwCVy5tBahGEZieLGM4ZUKZbOXO+Hkq+TjCLs+rF+mm3lHQWuwwdBTIo5ew==" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 13,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 18,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 20,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 27,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 32,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 36,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 37,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 38,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 39,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 40,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 41,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 42,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 43,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 44,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 45,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 46,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 47,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 48,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 49,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 50,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 51,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 52,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 53,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 54,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 55,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 56,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 57,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 58,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 59,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 60,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 61,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 62,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 63,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 64,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 65,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 66,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 67,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 68,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 69,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 70,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 71,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 72,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 73,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 75,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 76,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 77,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 78,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 79,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 80,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 81,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 82,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 83,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 277, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 84,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 277, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 85,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 277, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.InsertData(
                table: "ModesRecrutements",
                columns: new[] { "Id", "CreationDate", "Mode", "ModificationDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "E-Chalenge", new DateTime(2022, 4, 20, 15, 33, 38, 261, DateTimeKind.Local).AddTicks(1847) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Recommandation", new DateTime(2022, 4, 20, 15, 33, 38, 261, DateTimeKind.Local).AddTicks(1859) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stage PFE", new DateTime(2022, 4, 20, 15, 33, 38, 261, DateTimeKind.Local).AddTicks(1860) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cooptation", new DateTime(2022, 4, 20, 15, 33, 38, 261, DateTimeKind.Local).AddTicks(1860) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autre", new DateTime(2022, 4, 20, 15, 33, 38, 261, DateTimeKind.Local).AddTicks(1861) }
                });

            migrationBuilder.UpdateData(
                table: "Niveaux",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 271, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Niveaux",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 271, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Niveaux",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 271, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Niveaux",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 271, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 273, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 273, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 273, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 273, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 264, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 264, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 264, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "SkillCenters",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 266, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "SkillCenters",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 266, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "SkillCenters",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 266, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "SkillCenters",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 266, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "SkillCenters",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 266, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "TypeContrats",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 269, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "TypeContrats",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 269, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "TypeContrats",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 20, 15, 33, 38, 269, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 5, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 5, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 5, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 5, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 5, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 5, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 5, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 5, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 5, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 5, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 5, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 5, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 5, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 5, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 5, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 2, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 1, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 1, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 1, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 3, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 1, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 1, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 1, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 1, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 1, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 1, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 4, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 3, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 4, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ModeRecrutementId", "ModificationDate" },
                values: new object[] { 5, new DateTime(2022, 4, 20, 15, 33, 38, 276, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.CreateIndex(
                name: "IX_Collaborateurs_ModeRecrutementId",
                table: "Collaborateurs",
                column: "ModeRecrutementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collaborateurs_ModesRecrutements_ModeRecrutementId",
                table: "Collaborateurs",
                column: "ModeRecrutementId",
                principalTable: "ModesRecrutements",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collaborateurs_ModesRecrutements_ModeRecrutementId",
                table: "Collaborateurs");

            migrationBuilder.DropIndex(
                name: "IX_Collaborateurs_ModeRecrutementId",
                table: "Collaborateurs");

            migrationBuilder.DeleteData(
                table: "ModesRecrutements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ModesRecrutements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ModesRecrutements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ModesRecrutements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ModesRecrutements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "ModeRecrutementId",
                table: "Collaborateurs");

            migrationBuilder.AddColumn<string>(
                name: "ModeRecrutement",
                table: "Collaborateurs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2ba0ccb5-2c5a-44ab-8894-a7e1b4fdc48b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "12af58ca-363d-4a0c-8294-77f4545f2178");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "289bb207-9503-47e1-9b9e-aba9821591e7", "AQAAAAEAACcQAAAAEIAJEwCSrpBpAcpZWSz7/GxuLeFL/I7Ytu9oOnLIoDCeyJtemcu5AtviYhviBj78zw==" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Autre", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Autre", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Autre", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Autre", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Autre", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Autre", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Autre", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Autre", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Autre", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Autre", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Spontané", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Autre", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Autre", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Autre", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Autre", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Autre", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Recommandation", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "E-Chalenge", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "E-Chalenge", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "E-Chalenge", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Stage PFE", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "E-Chalenge", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "E-Chalenge", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "E-Chalenge", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "E-Chalenge", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "E-Chalenge", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "E-Chalenge", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Cooptation", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6701) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Stage PFE", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Cooptation", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8546) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "Autre", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ModeRecrutement", "ModificationDate" },
                values: new object[] { "", new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "Niveaux",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 93, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Niveaux",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 93, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Niveaux",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 93, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Niveaux",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 93, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 95, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 95, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 95, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 95, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 87, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 87, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Sites",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 87, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "SkillCenters",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 89, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "SkillCenters",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 89, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "SkillCenters",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 89, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "SkillCenters",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 89, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "SkillCenters",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 89, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "TypeContrats",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 91, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "TypeContrats",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 91, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "TypeContrats",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 14, 3, 43, 91, DateTimeKind.Local).AddTicks(5388));
        }
    }
}
