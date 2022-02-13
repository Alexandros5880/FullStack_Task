using Microsoft.EntityFrameworkCore.Migrations;

namespace FullStack_Task.Migrations
{
    public partial class RefuctoBusinsessAreaApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f445",
                column: "ConcurrencyStamp",
                value: "3bfd4faf-7d94-4050-a1ea-7c5f70ea21bf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7d03d61-249b-46d4-b0cb-3fad2cafc573", "AQAAAAEAACcQAAAAEJlHDr+U8D2ozuwtoiv3ue7TQdrC4m8QrANq0ZD0yl/WFJcPTBkdnH0AUyVTDDqWMw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f-9eab-4bb9-9fca-30b01540f445",
                column: "ConcurrencyStamp",
                value: "ce01477f-bea7-44fa-85d4-53fddf7bb70a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "48e0d581-5e12-485d-8757-46f76ffac49a", "AQAAAAEAACcQAAAAEGxXVJkngAB4FrLhSK4FlAHwSO5/zizWuJTL/VSWUc5q1jZml8nX6fuQqEwzFx5UCg==" });
        }
    }
}
