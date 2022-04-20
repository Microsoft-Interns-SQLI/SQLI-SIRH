using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_MySIRH.Data.Migrations
{
    public partial class MigrateDBB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Site",
                table: "Collaborateurs");

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "Collaborateurs",
                type: "int",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "Sites",
                columns: new[] { "Id", "CreationDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 14, 3, 43, 87, DateTimeKind.Local).AddTicks(7033), "Rabat" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 14, 3, 43, 87, DateTimeKind.Local).AddTicks(7036), "Oujda" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 14, 3, 43, 87, DateTimeKind.Local).AddTicks(7037), "CasaBlanca" }
                });

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

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(4546), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(4753), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(4815), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(4866), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(4937), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(4989), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5035), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5112), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5194), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5248), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5328), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5384), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5439), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5512), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5567), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5621), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5693), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5796), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5870), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5925), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(5971), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6041), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6093), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6170), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6223), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6272), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6347), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6404), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6450), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6525), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6581), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6653), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6701), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6755), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6826), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6875), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6941), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(6993), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7040), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7111), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7159), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7235), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7288), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7341), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7416), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7469), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7519), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7594), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7640), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7718), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7764), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7811), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7882), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7928), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(7972), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8044), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8093), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8170), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8218), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8268), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8333), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8381), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8427), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8498), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8546), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8614), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8666), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8732), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8822), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8870), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8945), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(8995), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9038), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9103), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9156), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9221), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9266), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9311), 2 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9376), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9422), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9468), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9539), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9585), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9655), 1 });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ModificationDate", "SiteId" },
                values: new object[] { new DateTime(2022, 4, 19, 14, 3, 43, 98, DateTimeKind.Local).AddTicks(9705), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Collaborateurs_SiteId",
                table: "Collaborateurs",
                column: "SiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collaborateurs_Sites_SiteId",
                table: "Collaborateurs",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collaborateurs_Sites_SiteId",
                table: "Collaborateurs");

            migrationBuilder.DropIndex(
                name: "IX_Collaborateurs_SiteId",
                table: "Collaborateurs");

            migrationBuilder.DeleteData(
                table: "Sites",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sites",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sites",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Collaborateurs");

            migrationBuilder.AddColumn<string>(
                name: "Site",
                table: "Collaborateurs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "72f2e79d-e434-4ad9-8300-1a32f69ae8e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "a65aac7b-a271-4f6b-aba3-0c25df3177ad");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "046bcdb8-748d-41a3-b355-84131b996b34", "AQAAAAEAACcQAAAAEFP3hvfaeqocKjisB/k5uku/uJ5zBffhhYVlDdtVY/u2AiQFy96V7W8WylpJnQaf2g==" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 963, DateTimeKind.Local).AddTicks(9714), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 963, DateTimeKind.Local).AddTicks(9946), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(5), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(54), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(121), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(172), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(215), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(278), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(328), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(374), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(446), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(495), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(544), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(617), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(666), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(719), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(788), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(837), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(882), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(952), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1039), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1085), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1155), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1204), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1250), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1316), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1360), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1413), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1479), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1524), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1570), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1635), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1676), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1725), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1791), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1836), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1878), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1944), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(1986), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2027), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2090), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2132), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2174), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2242), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2289), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2339), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2419), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2465), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2508), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2571), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2614), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2655), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2722), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2765), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2805), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2869), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2912), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(2956), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3023), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3066), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3106), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3170), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3214), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3256), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3318), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3362), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3402), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3464), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3507), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3546), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3615), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3659), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3699), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3759), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3805), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3845), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3905), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(3946), "Oujda" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(4028), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(4095), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(4137), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(4179), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(4240), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(4288), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ModificationDate", "Site" },
                values: new object[] { new DateTime(2022, 4, 19, 13, 48, 30, 964, DateTimeKind.Local).AddTicks(4333), "Rabat" });

            migrationBuilder.UpdateData(
                table: "Niveaux",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 13, 48, 30, 959, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Niveaux",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 13, 48, 30, 959, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Niveaux",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 13, 48, 30, 959, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Niveaux",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 13, 48, 30, 959, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 13, 48, 30, 960, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 13, 48, 30, 960, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 13, 48, 30, 960, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 13, 48, 30, 960, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "SkillCenters",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 13, 48, 30, 955, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "SkillCenters",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 13, 48, 30, 955, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "SkillCenters",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 13, 48, 30, 955, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "SkillCenters",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 13, 48, 30, 955, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "SkillCenters",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 13, 48, 30, 955, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "TypeContrats",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 13, 48, 30, 957, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "TypeContrats",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 13, 48, 30, 957, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "TypeContrats",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 19, 13, 48, 30, 957, DateTimeKind.Local).AddTicks(1845));
        }
    }
}
