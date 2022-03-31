using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_MySIRH.Migrations
{
    public partial class fixDiplomesField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "3891da00-5684-40d4-8622-85102b70dc06");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a0b8490-9b43-4e94-8d16-56a10af91555", "AQAAAAEAACcQAAAAEMAvV1F17I9a5ZSDMwzJ2UUefYDSuUWh4Rs06C3vQcy+B4yEbTYL2EbUMZTkEhRKPA==", "a96e1a80-dbc6-45e9-aa5f-c2d084cca28c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
