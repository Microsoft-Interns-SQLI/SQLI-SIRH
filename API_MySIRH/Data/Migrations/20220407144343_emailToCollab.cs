using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_MySIRH.Data.Migrations
{
    public partial class emailToCollab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Collaborateurs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "7d346384-5136-4513-b7f2-c53c8c229fec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "3e14b28b-5e1d-4956-8bd5-a00a15087f12");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b46eb8be-3225-4306-bed7-4775439a5d46", "AQAAAAEAACcQAAAAELVFUlBEvIz+L8hcDM3TRHgZNxuDFBoDx5UyKEwVIevvdFu4Ay7JntQDUazFoOPjPg==" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "abaazzi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 376, DateTimeKind.Local).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "aeljai@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 376, DateTimeKind.Local).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "ynaimi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 376, DateTimeKind.Local).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "mlasmak@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 376, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "mmajid@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 376, DateTimeKind.Local).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "nbennai@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 376, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "yazzi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 376, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "schouki@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 376, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "mboufaddi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "okarouite@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "adidiomarelalaoui@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "halaouiismaili@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "helhamdaoui@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "massayah@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "abouhafer@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "aelbouhafsi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(189) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "ymaaiden@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "zboukhris@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "iouazzi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "mbrahimi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "maelakkel@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "aeoubaid@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "iechenafi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "alahlou@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "mtouiyek@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "naelhachimi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "mkouakou@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "atoumi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "aaitelhad@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "nalboufarissi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "nnaji@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "folahmidi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "atayebi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "fsosseyalaoui@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(644) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "melhilali@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "schafik@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "fzhamdi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "beberaich@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "emlagzouli@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "yelkaddouri@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "fzmaadane@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "aelidrissijallal@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "ndroussi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "nhaouari@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "llaghoui@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "azouitni@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "aelyasni@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "mbounzaha@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "cchemmam@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "melboujbaoui@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "ahammeni@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "yelmousaoui@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "MROUDANI@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "MSIFANE@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "MZIDANI@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "hfarraji@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "ahjelti@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "momaghnouj@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "kmehdaoui@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "adbib@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "amotmani@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "lettout@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "selalami@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "mouelmrabet@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "zlahmidi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "onfaoui@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "oassanouni@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "kbenchamekh@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "zmiloudi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "mbouharrada@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "hkhazrouni@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "maaribech@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "kakhardid@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "zazoulay@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "mfliti@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "bybahi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "wberehil@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "knaimi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "slourhaoui@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "hbenmachi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "aouahdi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "zerrafiqi@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "aselhassani@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "adyar@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Email", "ModificationDate" },
                values: new object[] { "afourtit@sqli.com", new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 7, 14, 43, 43, 377, DateTimeKind.Local).AddTicks(1959));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Collaborateurs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ebf481eb-8047-4012-8c88-f52edb1e9b40");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "9e3c6527-40a1-4d5a-995e-dc9dd8b2ef2b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0eb0b2e0-8dff-45d6-8ca9-577063b3deb0", "AQAAAAEAACcQAAAAECXwC6Gx/9A3XH1aVuNlhbYwftGErILLRdS23MuDb4mUw7oeNyQa3neHFBCvoKUczQ==" });

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 12,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 13,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 14,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 15,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 16,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 17,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 18,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 19,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 20,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 21,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 22,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 23,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 24,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 25,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 26,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 27,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 28,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 29,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 30,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 31,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 32,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 33,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 34,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 35,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 36,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 37,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 38,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 39,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 40,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 41,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 42,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 43,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 44,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 45,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 46,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 47,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 48,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 49,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 50,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 51,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 52,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 53,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 54,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 55,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 56,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 57,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 58,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 59,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 60,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 205, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 61,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 62,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 63,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 64,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 65,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 66,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 67,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 68,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 69,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 70,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 71,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 72,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 73,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 74,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 75,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 76,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 77,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 78,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 79,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 80,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 81,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 82,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 83,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 84,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Collaborateurs",
                keyColumn: "Id",
                keyValue: 85,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Dashboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModificationDate",
                value: new DateTime(2022, 4, 6, 11, 15, 39, 206, DateTimeKind.Local).AddTicks(530));
        }
    }
}
